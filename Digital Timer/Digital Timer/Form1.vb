Public Class Form1

    Private Sub btShowDigit_Click(sender As Object, e As EventArgs) Handles btShowDigit.Click
        Dim Digit1 As Integer = txtDigitValue.Text
       
        If Digit1 = 0 Then
            pbSegment1.Visible = True
            pbSegment2.Visible = True
            pbSegment3.Visible = True
            pbSegment4.Visible = False
            pbSegment5.Visible = True
            pbSegment6.Visible = True
            pbSegment7.Visible = True

        ElseIf Digit1 = 1 Then
            pbSegment1.Visible = False
            pbSegment2.Visible = False
            pbSegment3.Visible = True
            pbSegment4.Visible = False
            pbSegment5.Visible = False
            pbSegment6.Visible = True
            pbSegment7.Visible = False

        ElseIf Digit1 = 2 Then
            pbSegment1.Visible = True
            pbSegment2.Visible = False
            pbSegment3.Visible = True
            pbSegment4.Visible = True
            pbSegment5.Visible = True
            pbSegment6.Visible = False
            pbSegment7.Visible = True

        ElseIf Digit1 = 3 Then
            pbSegment1.Visible = True
            pbSegment2.Visible = False
            pbSegment3.Visible = True
            pbSegment4.Visible = True
            pbSegment5.Visible = False
            pbSegment6.Visible = True
            pbSegment7.Visible = True

        ElseIf Digit1 = 4 Then
            pbSegment1.Visible = False
            pbSegment2.Visible = True
            pbSegment3.Visible = True
            pbSegment4.Visible = True
            pbSegment5.Visible = False
            pbSegment6.Visible = True
            pbSegment7.Visible = False

        ElseIf Digit1 = 5 Then
            pbSegment1.Visible = True
            pbSegment2.Visible = True
            pbSegment3.Visible = False
            pbSegment4.Visible = True
            pbSegment5.Visible = False
            pbSegment6.Visible = True
            pbSegment7.Visible = True

        ElseIf Digit1 = 6 Then
            pbSegment1.Visible = True
            pbSegment2.Visible = True
            pbSegment3.Visible = False
            pbSegment4.Visible = True
            pbSegment5.Visible = True
            pbSegment6.Visible = True
            pbSegment7.Visible = True

        ElseIf Digit1 = 7 Then
            pbSegment1.Visible = True
            pbSegment2.Visible = False
            pbSegment3.Visible = True
            pbSegment4.Visible = False
            pbSegment5.Visible = False
            pbSegment6.Visible = True
            pbSegment7.Visible = False
        
        ElseIf Digit1 = 8 Then
            pbSegment1.Visible = True
            pbSegment2.Visible = True
            pbSegment3.Visible = True
            pbSegment4.Visible = True
            pbSegment5.Visible = True
            pbSegment6.Visible = True
            pbSegment7.Visible = True

        ElseIf Digit1 = 9 Then
            pbSegment1.Visible = True
            pbSegment2.Visible = True
            pbSegment3.Visible = True
            pbSegment4.Visible = True
            pbSegment5.Visible = False
            pbSegment6.Visible = True
            pbSegment7.Visible = True
        End If
        'This is how the digits will be displayed in the 7 segment display when the user clicks on the show digit button
    End Sub


    Private Sub btAddOne_Click(sender As Object, e As EventArgs) Handles btAddOne.Click
        Dim ShowDigit As Integer = txtDigitValue.Text
        Dim OneSec As Integer = txtOneSecs.Text
        Dim TenSec As Integer = txtTenSecs.Text
        Dim OneMin As Integer = txtOneMin.Text
        Dim TenMin As Integer = txtTenMins.Text

        If cbStopTimer.CheckState = CheckState.Checked Then

            If OneSec = txtStopOneSec.Text And TenSec = txtStopTenSecs.Text And OneMin = txtStopOneMin.Text And TenMin = txtStopTenMins.Text Then
                Timer1.Enabled = False
            End If
        End If
        'This is when the user inputs a digit in one or more of the textboxes in order for the timer to stop regarding that they click on the checkbox for it to be executed

        If ShowDigit >= 9 Then
            txtDigitValue.Text = 0
            OneSec = OneSec + 1
            txtOneSecs.Text = OneSec
        Else
            ShowDigit = ShowDigit + 1
            txtDigitValue.Text = ShowDigit
        End If

        If OneSec > 9 Then
            txtOneSecs.Text = 0
            TenSec = TenSec + 1
            txtTenSecs.Text = TenSec

        End If

        If TenSec >= 6 Then
            txtTenSecs.Text = 0
            OneMin = OneMin + 1
            txtOneMin.Text = OneMin

        End If

        If OneMin > 9 Then
            txtOneMin.Text = 0
            TenMin = TenMin + 1
            txtTenMins.Text = TenMin

        End If

        If TenMin >= 6 Then
            txtOneSecs.Text = 0
            txtTenSecs.Text = 0
            txtOneMin.Text = 0
            txtTenMins.Text = 0
        End If


        btShowDigit_Click(sender, e)
        btShowDigit2_Click(sender, e)
        btShowDigit3_Click(sender, e)
        btShowDigit4_Click(sender, e)
        btShowDigit5_Click(sender, e)
        'This is the execution of the timer where the values are added and then resets when it reaches a limit

    End Sub

    Private Sub btStop_Click(sender As Object, e As EventArgs) Handles btStop.Click
        End
    End Sub

    Private Sub btShowDigit2_Click(sender As Object, e As EventArgs) Handles btShowDigit2.Click
        Dim Digit As Integer = txtOneSecs.Text
        If Digit = 1 Then
            pbOneSec.Image = Image.FromFile("1.jpg")

        ElseIf Digit = 2 Then
            pbOneSec.Image = Image.FromFile("2.jpg")

        ElseIf Digit = 3 Then
            pbOneSec.Image = Image.FromFile("3.jpg")

        ElseIf Digit = 4 Then
            pbOneSec.Image = Image.FromFile("4.jpg")

        ElseIf Digit = 5 Then
            pbOneSec.Image = Image.FromFile("5.jpg")

        ElseIf Digit = 6 Then
            pbOneSec.Image = Image.FromFile("6.jpg")

        ElseIf Digit = 7 Then
            pbOneSec.Image = Image.FromFile("7.jpg")

        ElseIf Digit = 8 Then
            pbOneSec.Image = Image.FromFile("8.jpg")

        ElseIf Digit = 9 Then
            pbOneSec.Image = Image.FromFile("9.jpg")

        ElseIf Digit = 0 Then
            pbOneSec.Image = Image.FromFile("0.jpg")

        End If



    End Sub

    Private Sub btShowDigit3_Click(sender As Object, e As EventArgs) Handles btShowDigit3.Click
        Dim Digit As Integer = txtTenSecs.Text

        If Digit = 1 Then
            pbTenSecs.Image = Image.FromFile("1.jpg")

        ElseIf Digit = 2 Then
            pbTenSecs.Image = Image.FromFile("2.jpg")

        ElseIf Digit = 3 Then
            pbTenSecs.Image = Image.FromFile("3.jpg")

        ElseIf Digit = 4 Then
            pbTenSecs.Image = Image.FromFile("4.jpg")

        ElseIf Digit = 5 Then
            pbTenSecs.Image = Image.FromFile("5.jpg")

        ElseIf Digit = 6 Then
            pbTenSecs.Image = Image.FromFile("6.jpg")

        ElseIf Digit = 0 Then
            pbTenSecs.Image = Image.FromFile("0.jpg")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTheTime.Text = Format(DateTime.Now, "hh" & ":" & "mm" & ":" & "ss")
        btAddOne_Click(sender, e)
    End Sub

    Private Sub btStartTimer_Click(sender As Object, e As EventArgs) Handles btStartTimer.Click

        Timer1.Interval = 100
        Timer1.Enabled = True
    End Sub

    Private Sub btTimeNow_Click(sender As Object, e As EventArgs) Handles btTimeNow.Click
        txtTheTime.Text = txtTheTime.Text = Format(DateTime.Now, "hh" & ":" & "mm" & ":" & "ss")
    End Sub

    Private Sub btShowDigit4_Click(sender As Object, e As EventArgs) Handles btShowDigit4.Click
        Dim Digit As Integer = txtOneMin.Text

        If Digit = 1 Then
            pbOneMin.Image = Image.FromFile("1.jpg")

        ElseIf Digit = 2 Then
            pbOneMin.Image = Image.FromFile("2.jpg")

        ElseIf Digit = 3 Then
            pbOneMin.Image = Image.FromFile("3.jpg")

        ElseIf Digit = 4 Then
            pbOneMin.Image = Image.FromFile("4.jpg")

        ElseIf Digit = 5 Then
            pbOneMin.Image = Image.FromFile("5.jpg")

        ElseIf Digit = 6 Then
            pbOneMin.Image = Image.FromFile("6.jpg")

        ElseIf Digit = 7 Then
            pbOneMin.Image = Image.FromFile("7.jpg")

        ElseIf Digit = 8 Then
            pbOneMin.Image = Image.FromFile("8.jpg")

        ElseIf Digit = 9 Then
            pbOneMin.Image = Image.FromFile("9.jpg")

        ElseIf Digit = 0 Then
            pbOneMin.Image = Image.FromFile("0.jpg")

        End If
    End Sub

    Private Sub btShowDigit5_Click(sender As Object, e As EventArgs) Handles btShowDigit5.Click
        Dim Digit As Integer = txtTenMins.Text

        If Digit = 1 Then
            pbTenMins.Image = Image.FromFile("1.jpg")

        ElseIf Digit = 2 Then
            pbTenMins.Image = Image.FromFile("2.jpg")

        ElseIf Digit = 3 Then
            pbTenMins.Image = Image.FromFile("3.jpg")

        ElseIf Digit = 4 Then
            pbTenMins.Image = Image.FromFile("4.jpg")

        ElseIf Digit = 5 Then
            pbTenMins.Image = Image.FromFile("5.jpg")

        ElseIf Digit = 0 Then
            pbTenMins.Image = Image.FromFile("0.jpg")

        End If

    End Sub


    Private Sub cbTimeNow_CheckedChanged(sender As Object, e As EventArgs) Handles cbTimeNow.CheckedChanged
        Dim OneSecond As Integer
        Dim TenSeconds As Integer
        Dim OneMinute As Integer
        Dim TenMinutes As Integer
        Dim RealSecs As Integer
        Dim RealMins As Integer

        If cbTimeNow.CheckState = CheckState.Checked Then
            RealSecs = Format(DateTime.Now, "ss")
            RealMins = Format(DateTime.Now, "mm")
            OneSecond = RealSecs Mod 10
            TenSeconds = RealSecs \ 10
            OneMinute = RealMins Mod 10
            TenMinutes = RealMins \ 10
            txtTenMins.Text = TenMinutes
            txtOneMin.Text = OneMinute
            txtTenSecs.Text = TenSeconds
            txtOneSecs.Text = OneSecond
        Else
            Timer1.Enabled = True
        End If
        'This piece of code allows the user to tick the box in order to show the real time in the big digit display and timer display
    End Sub

End Class









