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

        If strColor = "" Then ' no color was selected
            ErrorProvider1.SetError(grpColors, "you must select colors")
            blnErrors = True
        End If

        If strTrim = "" Then ' no trim was selected
            ErrorProvider1.SetError(grpTrim, "you must select a trim color")
            blnErrors = True
        End If

        If strStartDate = "" Then ' no trim was selected
            ErrorProvider1.SetError(mclSellRange, "you must select a start date")
            blnErrors = True
        End If

        If Not IsNumeric(txtId.Text) Then 'id is non-numeric
            ErrorProvider1.SetError(txtId, "you must enter a numerical value")
            blnErrors = True
        End If

        If mskZip.Text = "" Then 'missing zip code
            ErrorProvider1.SetError(mskZip, "You must enter a zip code")
            blnErrors = True
        End If

        If blnErrors Then ' cant go foward some of the data is missing or bad
            Exit Sub 'early jump out of this procedure
        End If
        ' if the data is good
        strResult = "you have selected the following :" & vbCrLf
        strResult &= "Sale item: " & cboSaleItems.SelectedItem.ToString & vbCrLf
        strResult &= "Size: " & lstSizes.SelectedItem.ToString & vbCrLf
        strResult &= "Color: " & strColor & vbCrLf
        strResult &= "Trim : " & strTrim & vbCrLf
        strResult &= "Hats: " & vbCrLf
        For i = 0 To clbHats.Items.Count - 1
            If clbHats.GetItemCheckState(i) = CheckState.Checked Then ' this item was selected
                strResult &= "   " & clbHats.Items(i).ToString & vbCrLf
            End If
        Next
        strResult &= "Delivery Options: " & vbCrLf
        For i = 0 To arrChk.Length - 1
            If arrChk(i).Checked Then ' it was selected
                strResult &= "   " & arrChk(i).Text
            End If
        Next
        strResult &= "Approval date: " & FormatDateTime(dtmApproval.Value, DateFormat.ShortDate) & vbCrLf
        strResult &= " Sale Start date: " & strStartDate & vbCrLf
        strResult &= " Sale End Date: " & strEndDate & vbCrLf
        MessageBox.Show(strResult, "Your choices", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer
        For i = 0 To arrRedColor.Length - 1
            arrRedColor(i).Checked = False
        Next
        For i = 0 To arrRedTrim.Length - 1
            arrRedTrim(i).Checked = False
        Next
        For i = 0 To arrChk.Length - 1
            arrChk(i).Checked = False
        Next
        clbHats.ClearSelected() 'clears the highlighting of selections
        For i = 0 To clbHats.Items.Count - 1
            clbHats.SetItemCheckState(i, CheckState.Unchecked)
        Next
        lstSizes.SelectedIndex = -1
        cboSaleItems.SelectedIndex = -1
        strColor = " "
        strTrim = " "
        dtmApproval.Value = Today.Date
        mclSellRange.SelectionStart = Today
        mclSellRange.SelectionEnd = Today
        ErrorProvider1.Clear()
        txtId.Clear()
        mskZip.Clear()


    End Sub
End Class
