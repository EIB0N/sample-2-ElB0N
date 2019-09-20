Public Class frmChoices
    Private arrRedColor(2) As RadioButton 'array of 3 RadioButton objects
    Private arrRedTrim(2) As RadioButton
    Private arrChk(2) As CheckBox
    Private strColor As String 'holds color choices
    Private strTrim As String 'to hold the trim choice
    Private strStartDate As String
    Private strEndDate As String

    Private Sub LoadComboBoxChoices()
        cboSaleItems.Items.Add("Long sleeve shirt")
        cboSaleItems.Items.Add("Short sleeve shirt")
        cboSaleItems.Items.Add("Lightweight jacket")
    End Sub

    Private Sub frmChoices_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComboBoxChoices()
        LoadListBBoxChoices()
        LoadCheckedListBoxChoices()
        'load the control arrays
        arrRedColor(0) = redRed
        arrRedColor(1) = redBlue
        arrRedColor(2) = redGreen
        arrRedTrim(0) = redGold
        arrRedTrim(1) = redSilver
        arrRedTrim(2) = redBlack
        arrChk(0) = chkExpress
        arrChk(1) = chkSaturday
        arrChk(2) = chkResidential

    End Sub

    Private Sub LoadListBBoxChoices()
        lstSizes.Items.Add("Small")
        lstSizes.Items.Add("Medium")
        lstSizes.Items.Add("Large")
        lstSizes.Items.Add("XL")
        lstSizes.Items.Add("XXL")

    End Sub

    Private Sub LoadCheckedListBoxChoices()
        clbHats.Items.Add("Baseball Hat")
        clbHats.Items.Add("CowBoy Hat")
        clbHats.Items.Add("Tennis Hat")
        clbHats.Items.Add("Golf Hat")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() ' end the program
    End Sub

    Private Sub redColors_CheckedChanged(sender As Object, e As EventArgs) Handles redRed.CheckedChanged, redBlue.CheckedChanged, redGreen.CheckedChanged
        ' we have wired in all of the 3 color radio button to this single event procedure.

        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)
        If rad.Checked Then ' only if the radio button is being turned on
            strColor = rad.Text
        End If

    End Sub

    Private Sub redTrim_CheckedChanged(sender As Object, e As EventArgs) Handles redBlack.CheckedChanged, redGold.CheckedChanged, redSilver.CheckedChanged

        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)
        If rad.Checked Then
            strTrim = rad.Text
        End If

    End Sub

    Private Sub mclSellRange_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mclSellRange.DateSelected
        ' capture the start and end date of the selected date range
        strStartDate = FormatDateTime(e.Start.ToString, DateFormat.ShortDate)
        strEndDate = FormatDateTime(e.End.ToString, DateFormat.ShortDate)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim strResult As String
        Dim i As Integer
        Dim blnErrors As Boolean
        ErrorProvider1.Clear() ' clear any previous error message
        'validate selection in the combo, listbox and radio buttons.
        If cboSaleItems.SelectedIndex = -1 Then ' no selection was made
            ErrorProvider1.SetError(cboSaleItems, "You must Select a Sale item")
            blnErrors = True

        End If
        If lstSizes.SelectedIndex = -1 Then ' no selection was made
            ErrorProvider1.SetError(lstSizes, "you must select a size")
            blnErrors = True
        End If
    End Sub
End Class
