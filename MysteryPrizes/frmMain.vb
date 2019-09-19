Public Class frmMain
    Private intResult As Integer
    Private sngWinnings As Single
    Private rndVal As New Random

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lblForfit.Visible = False
        timSpin.Start()
    End Sub

    Private Sub timSpin_Tick(sender As Object, e As EventArgs) Handles timSpin.Tick
        lblResult.Text = rndVal.Next(500)
        lblResult.Refresh()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timSpin.Stop()
        If lblResult.Text <> "" Then
            CalculateWinnings()
        End If
    End Sub
    Private Sub CalculateWinnings()
        Dim intSpinVal As Integer
        Dim intPrizeNum As Integer
        Dim sngPrizeVal As Single
        Dim strImage As String
        intSpinVal = CInt(lblResult.Text) ' converts the label contents to an integer

        Select Case intSpinVal
            Case Is < 100
                intPrizeNum = 1
                sngPrizeVal = 2
                strImage = "soulja-boy-console-e1544199003402.jpg"
                picPrize.SizeMode = PictureBoxSizeMode.StretchImage

                picWOW.Visible = False

            Case Is < 200
                intPrizeNum = 2
                sngPrizeVal = 1
                strImage = "download.jpg"
                picPrize.SizeMode = PictureBoxSizeMode.StretchImage

                picWOW.Visible = False



            Case Is < 300
                intPrizeNum = 3
                sngPrizeVal = 1000
                strImage = "golden-kappa-png-Free-Png-Images.png"
                picPrize.SizeMode = PictureBoxSizeMode.StretchImage

                picWOW.Visible = True

            Case Else ' for anything other value not in a case statement
                intPrizeNum = 4
                sngPrizeVal = 0
                strImage = "2EiDBoG.png"
                picPrize.SizeMode = PictureBoxSizeMode.StretchImage
                lblForfit.Visible = True
                picWOW.Visible = False
        End Select

        lblPrizeVal.Text = FormatCurrency(sngPrizeVal)

        If intSpinVal < 300 Then ' a winner
            sngWinnings += sngPrizeVal
        Else
            sngWinnings = 0 ' wipe out the accumulated winnings
        End If
        lblWinnings.Text = FormatCurrency(sngWinnings)
        picPrize.Load("Resources\" & strImage)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim intResult As Integer
        intResult = MessageBox.Show(" You will lose your winnings if you quit now. Do you want to quit? ", "Warning!", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
        If intResult = DialogResult.No Then ' user does not want to quit
            Exit Sub ' early jump out to the end of the procedurel
        End If
        'end the program
        Application.Exit()
    End Sub
End Class
