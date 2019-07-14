<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btShowDigit = New System.Windows.Forms.Button()
        Me.txtDigitValue = New System.Windows.Forms.TextBox()
        Me.pbSegment1 = New System.Windows.Forms.PictureBox()
        Me.pbSegment3 = New System.Windows.Forms.PictureBox()
        Me.pbSegment4 = New System.Windows.Forms.PictureBox()
        Me.pbSegment7 = New System.Windows.Forms.PictureBox()
        Me.pbSegment6 = New System.Windows.Forms.PictureBox()
        Me.pbSegment2 = New System.Windows.Forms.PictureBox()
        Me.pbSegment5 = New System.Windows.Forms.PictureBox()
        Me.btAddOne = New System.Windows.Forms.Button()
        Me.btStop = New System.Windows.Forms.Button()
        Me.pbOneSec = New System.Windows.Forms.PictureBox()
        Me.txtOneSecs = New System.Windows.Forms.TextBox()
        Me.btShowDigit2 = New System.Windows.Forms.Button()
        Me.pbTenSecs = New System.Windows.Forms.PictureBox()
        Me.txtTenSecs = New System.Windows.Forms.TextBox()
        Me.btShowDigit3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btStartTimer = New System.Windows.Forms.Button()
        Me.txtTheTime = New System.Windows.Forms.TextBox()
        Me.btTimeNow = New System.Windows.Forms.Button()
        Me.pbOneMin = New System.Windows.Forms.PictureBox()
        Me.txtOneMin = New System.Windows.Forms.TextBox()
        Me.btShowDigit4 = New System.Windows.Forms.Button()
        Me.pbTenMins = New System.Windows.Forms.PictureBox()
        Me.txtTenMins = New System.Windows.Forms.TextBox()
        Me.btShowDigit5 = New System.Windows.Forms.Button()
        Me.txtStopOneSec = New System.Windows.Forms.TextBox()
        Me.txtStopTenMins = New System.Windows.Forms.TextBox()
        Me.txtStopTenSecs = New System.Windows.Forms.TextBox()
        Me.txtStopOneMin = New System.Windows.Forms.TextBox()
        Me.lbEnterMinutes = New System.Windows.Forms.Label()
        Me.lbEnterSeconds = New System.Windows.Forms.Label()
        Me.cbTimeNow = New System.Windows.Forms.CheckBox()
        Me.cbStopTimer = New System.Windows.Forms.CheckBox()
        CType(Me.pbSegment1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSegment3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSegment4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSegment7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSegment6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSegment2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSegment5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOneSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTenSecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOneMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTenMins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btShowDigit
        '
        Me.btShowDigit.Location = New System.Drawing.Point(657, 68)
        Me.btShowDigit.Name = "btShowDigit"
        Me.btShowDigit.Size = New System.Drawing.Size(89, 23)
        Me.btShowDigit.TabIndex = 0
        Me.btShowDigit.Text = "Show the Digit"
        Me.btShowDigit.UseVisualStyleBackColor = True
        '
        'txtDigitValue
        '
        Me.txtDigitValue.Location = New System.Drawing.Point(542, 70)
        Me.txtDigitValue.Name = "txtDigitValue"
        Me.txtDigitValue.Size = New System.Drawing.Size(100, 20)
        Me.txtDigitValue.TabIndex = 1
        Me.txtDigitValue.Text = "0"
        '
        'pbSegment1
        '
        Me.pbSegment1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbSegment1.Location = New System.Drawing.Point(974, 42)
        Me.pbSegment1.Name = "pbSegment1"
        Me.pbSegment1.Size = New System.Drawing.Size(73, 19)
        Me.pbSegment1.TabIndex = 2
        Me.pbSegment1.TabStop = False
        '
        'pbSegment3
        '
        Me.pbSegment3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbSegment3.Location = New System.Drawing.Point(1046, 61)
        Me.pbSegment3.Name = "pbSegment3"
        Me.pbSegment3.Size = New System.Drawing.Size(19, 75)
        Me.pbSegment3.TabIndex = 3
        Me.pbSegment3.TabStop = False
        '
        'pbSegment4
        '
        Me.pbSegment4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbSegment4.Location = New System.Drawing.Point(974, 135)
        Me.pbSegment4.Name = "pbSegment4"
        Me.pbSegment4.Size = New System.Drawing.Size(73, 19)
        Me.pbSegment4.TabIndex = 4
        Me.pbSegment4.TabStop = False
        '
        'pbSegment7
        '
        Me.pbSegment7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbSegment7.Location = New System.Drawing.Point(974, 226)
        Me.pbSegment7.Name = "pbSegment7"
        Me.pbSegment7.Size = New System.Drawing.Size(73, 19)
        Me.pbSegment7.TabIndex = 5
        Me.pbSegment7.TabStop = False
        '
        'pbSegment6
        '
        Me.pbSegment6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbSegment6.Location = New System.Drawing.Point(1046, 153)
        Me.pbSegment6.Name = "pbSegment6"
        Me.pbSegment6.Size = New System.Drawing.Size(19, 75)
        Me.pbSegment6.TabIndex = 6
        Me.pbSegment6.TabStop = False
        '
        'pbSegment2
        '
        Me.pbSegment2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbSegment2.Location = New System.Drawing.Point(956, 61)
        Me.pbSegment2.Name = "pbSegment2"
        Me.pbSegment2.Size = New System.Drawing.Size(19, 75)
        Me.pbSegment2.TabIndex = 7
        Me.pbSegment2.TabStop = False
        '
        'pbSegment5
        '
        Me.pbSegment5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbSegment5.Location = New System.Drawing.Point(956, 153)
        Me.pbSegment5.Name = "pbSegment5"
        Me.pbSegment5.Size = New System.Drawing.Size(19, 75)
        Me.pbSegment5.TabIndex = 8
        Me.pbSegment5.TabStop = False
        '
        'btAddOne
        '
        Me.btAddOne.Location = New System.Drawing.Point(859, 42)
        Me.btAddOne.Name = "btAddOne"
        Me.btAddOne.Size = New System.Drawing.Size(75, 23)
        Me.btAddOne.TabIndex = 9
        Me.btAddOne.Text = "Add One"
        Me.btAddOne.UseVisualStyleBackColor = True
        '
        'btStop
        '
        Me.btStop.Location = New System.Drawing.Point(1087, 70)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(75, 23)
        Me.btStop.TabIndex = 10
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = True
        '
        'pbOneSec
        '
        Me.pbOneSec.BackColor = System.Drawing.Color.Aqua
        Me.pbOneSec.Location = New System.Drawing.Point(936, 270)
        Me.pbOneSec.Name = "pbOneSec"
        Me.pbOneSec.Size = New System.Drawing.Size(170, 259)
        Me.pbOneSec.TabIndex = 11
        Me.pbOneSec.TabStop = False
        '
        'txtOneSecs
        '
        Me.txtOneSecs.Location = New System.Drawing.Point(956, 535)
        Me.txtOneSecs.Name = "txtOneSecs"
        Me.txtOneSecs.Size = New System.Drawing.Size(100, 20)
        Me.txtOneSecs.TabIndex = 12
        Me.txtOneSecs.Text = "0"
        '
        'btShowDigit2
        '
        Me.btShowDigit2.Location = New System.Drawing.Point(974, 561)
        Me.btShowDigit2.Name = "btShowDigit2"
        Me.btShowDigit2.Size = New System.Drawing.Size(75, 23)
        Me.btShowDigit2.TabIndex = 13
        Me.btShowDigit2.Text = "Show Digit 2"
        Me.btShowDigit2.UseVisualStyleBackColor = True
        '
        'pbTenSecs
        '
        Me.pbTenSecs.BackColor = System.Drawing.Color.Aqua
        Me.pbTenSecs.Location = New System.Drawing.Point(711, 270)
        Me.pbTenSecs.Name = "pbTenSecs"
        Me.pbTenSecs.Size = New System.Drawing.Size(178, 259)
        Me.pbTenSecs.TabIndex = 14
        Me.pbTenSecs.TabStop = False
        '
        'txtTenSecs
        '
        Me.txtTenSecs.Location = New System.Drawing.Point(745, 535)
        Me.txtTenSecs.Name = "txtTenSecs"
        Me.txtTenSecs.Size = New System.Drawing.Size(100, 20)
        Me.txtTenSecs.TabIndex = 15
        Me.txtTenSecs.Text = "0"
        '
        'btShowDigit3
        '
        Me.btShowDigit3.Location = New System.Drawing.Point(757, 561)
        Me.btShowDigit3.Name = "btShowDigit3"
        Me.btShowDigit3.Size = New System.Drawing.Size(75, 23)
        Me.btShowDigit3.TabIndex = 16
        Me.btShowDigit3.Text = "Show Digit 3"
        Me.btShowDigit3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'btStartTimer
        '
        Me.btStartTimer.Location = New System.Drawing.Point(1087, 38)
        Me.btStartTimer.Name = "btStartTimer"
        Me.btStartTimer.Size = New System.Drawing.Size(75, 23)
        Me.btStartTimer.TabIndex = 17
        Me.btStartTimer.Text = "Start Timer"
        Me.btStartTimer.UseVisualStyleBackColor = True
        '
        'txtTheTime
        '
        Me.txtTheTime.Location = New System.Drawing.Point(206, 68)
        Me.txtTheTime.Name = "txtTheTime"
        Me.txtTheTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTheTime.TabIndex = 18
        '
        'btTimeNow
        '
        Me.btTimeNow.Location = New System.Drawing.Point(208, 95)
        Me.btTimeNow.Name = "btTimeNow"
        Me.btTimeNow.Size = New System.Drawing.Size(98, 23)
        Me.btTimeNow.TabIndex = 19
        Me.btTimeNow.Text = "The Time Now"
        Me.btTimeNow.UseVisualStyleBackColor = True
        '
        'pbOneMin
        '
        Me.pbOneMin.BackColor = System.Drawing.Color.Aqua
        Me.pbOneMin.Location = New System.Drawing.Point(504, 270)
        Me.pbOneMin.Name = "pbOneMin"
        Me.pbOneMin.Size = New System.Drawing.Size(178, 259)
        Me.pbOneMin.TabIndex = 20
        Me.pbOneMin.TabStop = False
        '
        'txtOneMin
        '
        Me.txtOneMin.Location = New System.Drawing.Point(531, 535)
        Me.txtOneMin.Name = "txtOneMin"
        Me.txtOneMin.Size = New System.Drawing.Size(100, 20)
        Me.txtOneMin.TabIndex = 21
        Me.txtOneMin.Text = "0"
        '
        'btShowDigit4
        '
        Me.btShowDigit4.Location = New System.Drawing.Point(542, 561)
        Me.btShowDigit4.Name = "btShowDigit4"
        Me.btShowDigit4.Size = New System.Drawing.Size(75, 23)
        Me.btShowDigit4.TabIndex = 22
        Me.btShowDigit4.Text = "Show Digit 4"
        Me.btShowDigit4.UseVisualStyleBackColor = True
        '
        'pbTenMins
        '
        Me.pbTenMins.BackColor = System.Drawing.Color.Aqua
        Me.pbTenMins.Location = New System.Drawing.Point(300, 270)
        Me.pbTenMins.Name = "pbTenMins"
        Me.pbTenMins.Size = New System.Drawing.Size(178, 259)
        Me.pbTenMins.TabIndex = 23
        Me.pbTenMins.TabStop = False
        '
        'txtTenMins
        '
        Me.txtTenMins.Location = New System.Drawing.Point(336, 535)
        Me.txtTenMins.Name = "txtTenMins"
        Me.txtTenMins.Size = New System.Drawing.Size(100, 20)
        Me.txtTenMins.TabIndex = 24
        Me.txtTenMins.Text = "0"
        '
        'btShowDigit5
        '
        Me.btShowDigit5.Location = New System.Drawing.Point(346, 561)
        Me.btShowDigit5.Name = "btShowDigit5"
        Me.btShowDigit5.Size = New System.Drawing.Size(75, 23)
        Me.btShowDigit5.TabIndex = 25
        Me.btShowDigit5.Text = "Show Digit 5"
        Me.btShowDigit5.UseVisualStyleBackColor = True
        '
        'txtStopOneSec
        '
        Me.txtStopOneSec.Location = New System.Drawing.Point(635, 177)
        Me.txtStopOneSec.Name = "txtStopOneSec"
        Me.txtStopOneSec.Size = New System.Drawing.Size(100, 20)
        Me.txtStopOneSec.TabIndex = 26
        Me.txtStopOneSec.Text = "0"
        '
        'txtStopTenMins
        '
        Me.txtStopTenMins.Location = New System.Drawing.Point(321, 177)
        Me.txtStopTenMins.Name = "txtStopTenMins"
        Me.txtStopTenMins.Size = New System.Drawing.Size(100, 20)
        Me.txtStopTenMins.TabIndex = 27
        Me.txtStopTenMins.Text = "0"
        '
        'txtStopTenSecs
        '
        Me.txtStopTenSecs.Location = New System.Drawing.Point(531, 177)
        Me.txtStopTenSecs.Name = "txtStopTenSecs"
        Me.txtStopTenSecs.Size = New System.Drawing.Size(100, 20)
        Me.txtStopTenSecs.TabIndex = 28
        Me.txtStopTenSecs.Text = "0"
        '
        'txtStopOneMin
        '
        Me.txtStopOneMin.Location = New System.Drawing.Point(425, 177)
        Me.txtStopOneMin.Name = "txtStopOneMin"
        Me.txtStopOneMin.Size = New System.Drawing.Size(100, 20)
        Me.txtStopOneMin.TabIndex = 29
        Me.txtStopOneMin.Text = "0"
        '
        'lbEnterMinutes
        '
        Me.lbEnterMinutes.AutoSize = True
        Me.lbEnterMinutes.Location = New System.Drawing.Point(365, 153)
        Me.lbEnterMinutes.Name = "lbEnterMinutes"
        Me.lbEnterMinutes.Size = New System.Drawing.Size(124, 13)
        Me.lbEnterMinutes.TabIndex = 30
        Me.lbEnterMinutes.Text = "Enter Minutes to Stop at:"
        '
        'lbEnterSeconds
        '
        Me.lbEnterSeconds.AutoSize = True
        Me.lbEnterSeconds.Location = New System.Drawing.Point(578, 153)
        Me.lbEnterSeconds.Name = "lbEnterSeconds"
        Me.lbEnterSeconds.Size = New System.Drawing.Size(129, 13)
        Me.lbEnterSeconds.TabIndex = 31
        Me.lbEnterSeconds.Text = "Enter Seconds to Stop at:"
        '
        'cbTimeNow
        '
        Me.cbTimeNow.AutoSize = True
        Me.cbTimeNow.Location = New System.Drawing.Point(49, 70)
        Me.cbTimeNow.Name = "cbTimeNow"
        Me.cbTimeNow.Size = New System.Drawing.Size(122, 17)
        Me.cbTimeNow.TabIndex = 32
        Me.cbTimeNow.Text = "Show the Time Now"
        Me.cbTimeNow.UseVisualStyleBackColor = True
        '
        'cbStopTimer
        '
        Me.cbStopTimer.AutoSize = True
        Me.cbStopTimer.Location = New System.Drawing.Point(494, 226)
        Me.cbStopTimer.Name = "cbStopTimer"
        Me.cbStopTimer.Size = New System.Drawing.Size(123, 17)
        Me.cbStopTimer.TabIndex = 33
        Me.cbStopTimer.Text = "Set the Time to Stop"
        Me.cbStopTimer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 616)
        Me.Controls.Add(Me.cbStopTimer)
        Me.Controls.Add(Me.cbTimeNow)
        Me.Controls.Add(Me.lbEnterSeconds)
        Me.Controls.Add(Me.lbEnterMinutes)
        Me.Controls.Add(Me.txtStopOneMin)
        Me.Controls.Add(Me.txtStopTenSecs)
        Me.Controls.Add(Me.txtStopTenMins)
        Me.Controls.Add(Me.txtStopOneSec)
        Me.Controls.Add(Me.btShowDigit5)
        Me.Controls.Add(Me.txtTenMins)
        Me.Controls.Add(Me.pbTenMins)
        Me.Controls.Add(Me.btShowDigit4)
        Me.Controls.Add(Me.txtOneMin)
        Me.Controls.Add(Me.pbOneMin)
        Me.Controls.Add(Me.btTimeNow)
        Me.Controls.Add(Me.txtTheTime)
        Me.Controls.Add(Me.btStartTimer)
        Me.Controls.Add(Me.btShowDigit3)
        Me.Controls.Add(Me.txtTenSecs)
        Me.Controls.Add(Me.pbTenSecs)
        Me.Controls.Add(Me.btShowDigit2)
        Me.Controls.Add(Me.txtOneSecs)
        Me.Controls.Add(Me.pbOneSec)
        Me.Controls.Add(Me.btStop)
        Me.Controls.Add(Me.btAddOne)
        Me.Controls.Add(Me.pbSegment5)
        Me.Controls.Add(Me.pbSegment2)
        Me.Controls.Add(Me.pbSegment6)
        Me.Controls.Add(Me.pbSegment7)
        Me.Controls.Add(Me.pbSegment4)
        Me.Controls.Add(Me.pbSegment3)
        Me.Controls.Add(Me.pbSegment1)
        Me.Controls.Add(Me.txtDigitValue)
        Me.Controls.Add(Me.btShowDigit)
        Me.Name = "Form1"
        Me.Text = "Digital Timer"
        CType(Me.pbSegment1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSegment3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSegment4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSegment7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSegment6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSegment2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSegment5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOneSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTenSecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOneMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTenMins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btShowDigit As System.Windows.Forms.Button
    Friend WithEvents txtDigitValue As System.Windows.Forms.TextBox
    Friend WithEvents pbSegment1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbSegment3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbSegment4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbSegment7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbSegment6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbSegment2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbSegment5 As System.Windows.Forms.PictureBox
    Friend WithEvents btAddOne As System.Windows.Forms.Button
    Friend WithEvents btStop As System.Windows.Forms.Button
    Friend WithEvents pbOneSec As System.Windows.Forms.PictureBox
    Friend WithEvents txtOneSecs As System.Windows.Forms.TextBox
    Friend WithEvents btShowDigit2 As System.Windows.Forms.Button
    Friend WithEvents pbTenSecs As System.Windows.Forms.PictureBox
    Friend WithEvents txtTenSecs As System.Windows.Forms.TextBox
    Friend WithEvents btShowDigit3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btStartTimer As System.Windows.Forms.Button
    Friend WithEvents txtTheTime As System.Windows.Forms.TextBox
    Friend WithEvents btTimeNow As System.Windows.Forms.Button
    Friend WithEvents pbOneMin As System.Windows.Forms.PictureBox
    Friend WithEvents txtOneMin As System.Windows.Forms.TextBox
    Friend WithEvents btShowDigit4 As System.Windows.Forms.Button
    Friend WithEvents pbTenMins As System.Windows.Forms.PictureBox
    Friend WithEvents txtTenMins As System.Windows.Forms.TextBox
    Friend WithEvents btShowDigit5 As System.Windows.Forms.Button
    Friend WithEvents txtStopOneSec As System.Windows.Forms.TextBox
    Friend WithEvents txtStopTenMins As System.Windows.Forms.TextBox
    Friend WithEvents txtStopTenSecs As System.Windows.Forms.TextBox
    Friend WithEvents txtStopOneMin As System.Windows.Forms.TextBox
    Friend WithEvents lbEnterMinutes As System.Windows.Forms.Label
    Friend WithEvents lbEnterSeconds As System.Windows.Forms.Label
    Friend WithEvents cbTimeNow As System.Windows.Forms.CheckBox
    Friend WithEvents cbStopTimer As System.Windows.Forms.CheckBox

End Class
