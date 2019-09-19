Public Class frmChoices

    Private Sub LoadComboBoxChoices()
        cboSaleItems.Items.Add("Long sleeve shirt")
        cboSaleItems.Items.Add("Short sleeve shirt")
        cboSaleItems.Items.Add("Lightweight jacket")
    End Sub

    Private Sub frmChoices_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComboBoxChoices()
        LoadListBBoxChoices()
        LoadCheckedListBoxChoices()


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
End Class
