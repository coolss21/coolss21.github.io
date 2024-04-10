<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Label2 As System.Windows.Forms.Label
        Me.txtCityName = New System.Windows.Forms.TextBox()
        Me.btnGetWeather = New System.Windows.Forms.Button()
        Me.lblCityName = New System.Windows.Forms.Label()
        Me.lblWeatherDesc = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxWeatherIcon = New System.Windows.Forms.PictureBox()
        Me.lblHumidity = New System.Windows.Forms.Label()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.lblTimeZone = New System.Windows.Forms.Label()
        Me.lblTimeInTimezone = New System.Windows.Forms.Label()
        Me.lblTimeOfDay = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxWeatherIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("HP Simplified Hans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Label2.Location = New System.Drawing.Point(179, 9)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(144, 18)
        Label2.TabIndex = 9
        Label2.Text = "Weather Forecast"
        '
        'txtCityName
        '
        Me.txtCityName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCityName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCityName.Location = New System.Drawing.Point(172, 47)
        Me.txtCityName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCityName.Name = "txtCityName"
        Me.txtCityName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCityName.Size = New System.Drawing.Size(199, 22)
        Me.txtCityName.TabIndex = 0
        '
        'btnGetWeather
        '
        Me.btnGetWeather.Location = New System.Drawing.Point(185, 435)
        Me.btnGetWeather.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGetWeather.Name = "btnGetWeather"
        Me.btnGetWeather.Size = New System.Drawing.Size(100, 33)
        Me.btnGetWeather.TabIndex = 1
        Me.btnGetWeather.Text = "Submit"
        Me.btnGetWeather.UseVisualStyleBackColor = True
        '
        'lblCityName
        '
        Me.lblCityName.AutoSize = True
        Me.lblCityName.Font = New System.Drawing.Font("HP Simplified Jpan", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityName.Location = New System.Drawing.Point(32, 108)
        Me.lblCityName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCityName.MinimumSize = New System.Drawing.Size(13, 12)
        Me.lblCityName.Name = "lblCityName"
        Me.lblCityName.Size = New System.Drawing.Size(18, 19)
        Me.lblCityName.TabIndex = 2
        Me.lblCityName.Text = " -"
        '
        'lblWeatherDesc
        '
        Me.lblWeatherDesc.AutoSize = True
        Me.lblWeatherDesc.Font = New System.Drawing.Font("HP Simplified Jpan", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeatherDesc.Location = New System.Drawing.Point(32, 213)
        Me.lblWeatherDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeatherDesc.MinimumSize = New System.Drawing.Size(13, 12)
        Me.lblWeatherDesc.Name = "lblWeatherDesc"
        Me.lblWeatherDesc.Size = New System.Drawing.Size(18, 19)
        Me.lblWeatherDesc.TabIndex = 3
        Me.lblWeatherDesc.Text = " -"
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Font = New System.Drawing.Font("HP Simplified Jpan", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.Location = New System.Drawing.Point(32, 159)
        Me.lblTemperature.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTemperature.MinimumSize = New System.Drawing.Size(13, 12)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(18, 19)
        Me.lblTemperature.TabIndex = 4
        Me.lblTemperature.Text = " -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the City name:"
        '
        'PictureBoxWeatherIcon
        '
        Me.PictureBoxWeatherIcon.BackColor = System.Drawing.Color.White
        Me.PictureBoxWeatherIcon.Location = New System.Drawing.Point(251, 265)
        Me.PictureBoxWeatherIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxWeatherIcon.Name = "PictureBoxWeatherIcon"
        Me.PictureBoxWeatherIcon.Size = New System.Drawing.Size(133, 146)
        Me.PictureBoxWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxWeatherIcon.TabIndex = 6
        Me.PictureBoxWeatherIcon.TabStop = False
        '
        'lblHumidity
        '
        Me.lblHumidity.AutoSize = True
        Me.lblHumidity.Font = New System.Drawing.Font("HP Simplified Jpan", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumidity.Location = New System.Drawing.Point(32, 319)
        Me.lblHumidity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHumidity.MinimumSize = New System.Drawing.Size(13, 12)
        Me.lblHumidity.Name = "lblHumidity"
        Me.lblHumidity.Size = New System.Drawing.Size(18, 19)
        Me.lblHumidity.TabIndex = 7
        Me.lblHumidity.Text = " -"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Font = New System.Drawing.Font("HP Simplified Jpan", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindSpeed.Location = New System.Drawing.Point(32, 265)
        Me.lblWindSpeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWindSpeed.MinimumSize = New System.Drawing.Size(13, 12)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(18, 19)
        Me.lblWindSpeed.TabIndex = 8
        Me.lblWindSpeed.Text = " -"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.Location = New System.Drawing.Point(95, 373)
        Me.lblLastUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastUpdate.MinimumSize = New System.Drawing.Size(13, 12)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(17, 17)
        Me.lblLastUpdate.TabIndex = 12
        Me.lblLastUpdate.Text = " -"
        '
        'lblTimeZone
        '
        Me.lblTimeZone.AutoSize = True
        Me.lblTimeZone.Location = New System.Drawing.Point(259, 214)
        Me.lblTimeZone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeZone.Name = "lblTimeZone"
        Me.lblTimeZone.Size = New System.Drawing.Size(0, 19)
        Me.lblTimeZone.TabIndex = 13
        '
        'lblTimeInTimezone
        '
        Me.lblTimeInTimezone.AutoSize = True
        Me.lblTimeInTimezone.Location = New System.Drawing.Point(259, 159)
        Me.lblTimeInTimezone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeInTimezone.Name = "lblTimeInTimezone"
        Me.lblTimeInTimezone.Size = New System.Drawing.Size(0, 19)
        Me.lblTimeInTimezone.TabIndex = 14
        '
        'lblTimeOfDay
        '
        Me.lblTimeOfDay.AutoSize = True
        Me.lblTimeOfDay.Location = New System.Drawing.Point(259, 108)
        Me.lblTimeOfDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeOfDay.Name = "lblTimeOfDay"
        Me.lblTimeOfDay.Size = New System.Drawing.Size(0, 19)
        Me.lblTimeOfDay.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(483, 478)
        Me.Controls.Add(Me.lblTimeOfDay)
        Me.Controls.Add(Me.lblTimeInTimezone)
        Me.Controls.Add(Me.lblTimeZone)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.lblWindSpeed)
        Me.Controls.Add(Me.lblHumidity)
        Me.Controls.Add(Me.PictureBoxWeatherIcon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.lblWeatherDesc)
        Me.Controls.Add(Me.lblCityName)
        Me.Controls.Add(Me.btnGetWeather)
        Me.Controls.Add(Me.txtCityName)
        Me.Font = New System.Drawing.Font("HP Simplified Jpan", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = " "
        Me.TopMost = True
        CType(Me.PictureBoxWeatherIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCityName As TextBox
    Friend WithEvents btnGetWeather As Button
    Friend WithEvents lblCityName As Label
    Friend WithEvents lblWeatherDesc As Label
    Friend WithEvents lblTemperature As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxWeatherIcon As PictureBox
    Friend WithEvents lblHumidity As Label
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents lblLastUpdate As Label
    Friend WithEvents lblTimeZone As Label
    Friend WithEvents lblTimeInTimezone As Label
    Friend WithEvents lblTimeOfDay As Label
End Class
