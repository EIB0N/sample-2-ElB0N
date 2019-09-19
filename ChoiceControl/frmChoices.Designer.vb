<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoices
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSaleItems = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSizes = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbHats = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Combo Box - Sale Items"
        '
        'cboSaleItems
        '
        Me.cboSaleItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSaleItems.FormattingEnabled = True
        Me.cboSaleItems.Location = New System.Drawing.Point(39, 74)
        Me.cboSaleItems.Name = "cboSaleItems"
        Me.cboSaleItems.Size = New System.Drawing.Size(121, 21)
        Me.cboSaleItems.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "List Box - Sizes"
        '
        'lstSizes
        '
        Me.lstSizes.FormattingEnabled = True
        Me.lstSizes.Location = New System.Drawing.Point(40, 161)
        Me.lstSizes.Name = "lstSizes"
        Me.lstSizes.Size = New System.Drawing.Size(119, 82)
        Me.lstSizes.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Checked List Box - Hats"
        '
        'clbHats
        '
        Me.clbHats.CheckOnClick = True
        Me.clbHats.FormattingEnabled = True
        Me.clbHats.Location = New System.Drawing.Point(38, 299)
        Me.clbHats.Name = "clbHats"
        Me.clbHats.Size = New System.Drawing.Size(116, 94)
        Me.clbHats.TabIndex = 5
        '
        'frmChoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 690)
        Me.Controls.Add(Me.clbHats)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstSizes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSaleItems)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChoices"
        Me.Text = "Controls That Provide Choices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboSaleItems As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSizes As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clbHats As CheckedListBox
End Class
