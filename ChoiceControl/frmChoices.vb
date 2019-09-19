Public Class frmChoices

    Private Sub LoadComboBoxChoices()
        cboSaleItems.Items.Add("Long sleeve shirt")
        cboSaleItems.Items.Add("Short sleeve shirt")
        cboSaleItems.Items.Add("Lightweight jacket")
    End Sub

    Private Sub frmChoices_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComboBoxChoices()

    End Sub
End Class
