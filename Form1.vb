Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class Form1

    ' Add a global variable to store the timezone offset
    Private timezoneOffset As Integer = 0

    Private Async Sub btnGetWeather_Click(sender As Object, e As EventArgs) Handles btnGetWeather.Click
        Dim weatherApiKey As String = "b7e316d0a50c2cf1fe2c1a0c56216cc7"
        Dim timezoneApiKey As String = "V9UHTNGNX9EQ" ' Your TimezoneDB API key
        Dim city As String = txtCityName.Text.Trim()

        If String.IsNullOrEmpty(city) Then
            MessageBox.Show("Please enter a city name.")
            Return
        End If

        Dim weatherApiUrl As String = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={weatherApiKey}&units=metric"

        Try
            Dim client As New WebClient()

            ' Fetch weather data
            Dim weatherResponse As String = Await client.DownloadStringTaskAsync(weatherApiUrl)
            Dim weatherData As JObject = JObject.Parse(weatherResponse)

            Dim cityName As String = weatherData.SelectToken("name").ToString()
            Dim temperature As Double = Convert.ToDouble(weatherData.SelectToken("main.temp"))
            Dim weatherDesc As String = weatherData.SelectToken("weather[0].description").ToString()
            Dim weatherCode As String = weatherData.SelectToken("weather[0].icon").ToString()
            Dim windSpeed As Double = Convert.ToDouble(weatherData.SelectToken("wind.speed"))
            Dim humidity As Integer = Convert.ToInt32(weatherData.SelectToken("main.humidity"))
            Dim lastUpdateUnixTime As Double = Convert.ToDouble(weatherData.SelectToken("dt"))
            Dim lastUpdateTime As DateTime = DateTimeOffset.FromUnixTimeSeconds(lastUpdateUnixTime).LocalDateTime

            ' Display weather information
            lblCityName.Text = $"City Name: {cityName}"
            lblTemperature.Text = $"Temperature in °C: {temperature} °C"
            lblWeatherDesc.Text = $"Weather: {weatherDesc}"
            lblWindSpeed.Text = $"Wind Speed: {windSpeed} m/s"
            lblHumidity.Text = $"Humidity: {humidity}%"
            lblLastUpdate.Text = $"Last Weather Update: {lastUpdateTime.ToString()}"

            ' Fetch timezone data by position
            Dim latitude As Double = Convert.ToDouble(weatherData.SelectToken("coord.lat"))
            Dim longitude As Double = Convert.ToDouble(weatherData.SelectToken("coord.lon"))
            Dim timezoneApiUrl As String = $"http://api.timezonedb.com/v2.1/get-time-zone?key={timezoneApiKey}&format=json&by=position&lat={latitude}&lng={longitude}"
            Dim timezoneResponse As String = Await client.DownloadStringTaskAsync(timezoneApiUrl)
            Dim timezoneData As JObject = JObject.Parse(timezoneResponse)
            Dim timezoneName As String = timezoneData.SelectToken("zoneName").ToString()

            ' Display timezone information
            lblTimeZone.Text = $"Timezone: {timezoneName}"

            ' Extract timezone offset from the response
            Dim offset As Integer = Convert.ToInt32(timezoneData.SelectToken("gmtOffset"))
            timezoneOffset = offset

            ' Display current time in the timezone
            DisplayTimeInTimezone()

            ' Change colors based on weather conditions
            ChangeColors(weatherCode)

            Await DisplayWeatherIcon(weatherCode)

        Catch ex As WebException
            Dim errorResponse As HttpWebResponse = DirectCast(ex.Response, HttpWebResponse)
            If errorResponse IsNot Nothing Then
                MessageBox.Show($"API Error: {errorResponse.StatusCode} - {errorResponse.StatusDescription}")
            Else
                MessageBox.Show("Network Error: " & ex.Message)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayTimeInTimezone()
        ' Calculate current time in the timezone
        Dim currentTimeInTimezone As DateTime = DateTime.UtcNow.AddSeconds(timezoneOffset)

        ' Display current time in the timezone
        lblTimeInTimezone.Text = $"Current Time: {currentTimeInTimezone.ToString("hh:mm:ss tt")}"

        ' Determine if it's day, night, evening, or dawn
        Dim timeOfDay As String = DetermineTimeOfDay(currentTimeInTimezone)
        lblTimeOfDay.Text = $"Time of Day: {timeOfDay}"
    End Sub

    Private Function DetermineTimeOfDay(currentTime As DateTime) As String
        Dim hour As Integer = currentTime.Hour

        If hour >= 6 AndAlso hour < 12 Then
            Return "Morning (Dawn)"
        ElseIf hour >= 12 AndAlso hour < 18 Then
            Return "Afternoon (Day)"
        ElseIf hour >= 18 AndAlso hour < 21 Then
            Return "Evening"
        Else
            Return "Night"
        End If
    End Function

    Private Async Function DisplayWeatherIcon(weatherCode As String) As Task
        Dim iconUrl As String = $"http://openweathermap.org/img/wn/{weatherCode}.png"

        Try
            PictureBoxWeatherIcon.Image = Await DownloadImageAsync(iconUrl)
            Await AnimatePictureBox()
        Catch ex As Exception
            MessageBox.Show("Error loading weather icon: " & ex.Message)
        End Try
    End Function

    Private Async Function DownloadImageAsync(url As String) As Task(Of Image)
        Using client As New WebClient()
            Dim data As Byte() = Await client.DownloadDataTaskAsync(url)
            Using stream As New IO.MemoryStream(data)
                Return Image.FromStream(stream)
            End Using
        End Using
    End Function

    Private Async Function AnimatePictureBox() As Task
        Dim targetLeft As Integer = 320
        Dim targetTop As Integer = 400

        PictureBoxWeatherIcon.Left = 270
        PictureBoxWeatherIcon.Top = 290
        PictureBoxWeatherIcon.Width = 0
        PictureBoxWeatherIcon.Height = 0

        'PictureBox popping up
        Do Until PictureBoxWeatherIcon.Width >= 100
            PictureBoxWeatherIcon.Width += 5
            PictureBoxWeatherIcon.Height += 5
            PictureBoxWeatherIcon.Left -= 2
            PictureBoxWeatherIcon.Top -= 2
            Await Task.Delay(0.01)
            Me.Refresh()
        Loop
    End Function

    Private Sub ChangeColors(weatherCode As String)
        Select Case weatherCode
            Case "01d", "01n" ' Clear sky
                Me.BackColor = Color.LightBlue
                txtCityName.BackColor = Color.LightBlue
                PictureBoxWeatherIcon.BackColor = Color.LightBlue
            Case "02d", "02n", "03d", "03n" ' Few clouds or scattered clouds
                Me.BackColor = Color.LightGray
                txtCityName.BackColor = Color.LightGray
                PictureBoxWeatherIcon.BackColor = Color.LightGray
            Case "04d", "04n" ' Broken clouds
                Me.BackColor = Color.Gray
                txtCityName.BackColor = Color.Gray
                PictureBoxWeatherIcon.BackColor = Color.Gray
            Case "09d", "09n", "10d", "10n" ' Rain
                Me.BackColor = Color.LightGreen
                txtCityName.BackColor = Color.LightGreen
                PictureBoxWeatherIcon.BackColor = Color.LightGreen
            Case "11d", "11n" ' Thunderstorm
                Me.BackColor = Color.DarkBlue
                txtCityName.BackColor = Color.DarkBlue
                PictureBoxWeatherIcon.BackColor = Color.DarkBlue
            Case "13d", "13n" ' Snow
                Me.BackColor = Color.White
                txtCityName.BackColor = Color.White
                PictureBoxWeatherIcon.BackColor = Color.White
            Case "50d", "50n" ' Mist
                Me.BackColor = Color.LightGray
                txtCityName.BackColor = Color.LightGray
                PictureBoxWeatherIcon.BackColor = Color.LightGray
            Case Else ' Default color
                Me.BackColor = SystemColors.Control
                txtCityName.BackColor = SystemColors.Control
                PictureBoxWeatherIcon.BackColor = SystemColors.Control
        End Select
    End Sub

    Private Sub btnGetWeather_MouseEnter(sender As Object, e As EventArgs) Handles btnGetWeather.MouseEnter
        btnGetWeather.BackColor = Color.FromArgb(0, 255, 255, 255)
    End Sub

    Private Sub btnGetWeather_MouseLeave(sender As Object, e As EventArgs) Handles btnGetWeather.MouseLeave
        btnGetWeather.BackColor = SystemColors.Control
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No need to call UpdateTimeAndDayNight() in Form_Load anymore
    End Sub
End Class
