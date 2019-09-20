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
        Me.redRed = New System.Windows.Forms.RadioButton()
        Me.redBlue = New System.Windows.Forms.RadioButton()
        Me.redGreen = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.redBlack = New System.Windows.Forms.RadioButton()
        Me.redSilver = New System.Windows.Forms.RadioButton()
        Me.redGold = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkResidential = New System.Windows.Forms.CheckBox()
        Me.chkSaturday = New System.Windows.Forms.CheckBox()
        Me.chkExpress = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtmApproval = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskZip = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        'redRed
        '
        Me.redRed.AutoSize = True
        Me.redRed.Location = New System.Drawing.Point(6, 28)
        Me.redRed.Name = "redRed"
        Me.redRed.Size = New System.Drawing.Size(45, 17)
        Me.redRed.TabIndex = 7
        Me.redRed.TabStop = True
        Me.redRed.Text = "Red"
        Me.redRed.UseVisualStyleBackColor = True
        '
        'redBlue
        '
        Me.redBlue.AutoSize = True
        Me.redBlue.Location = New System.Drawing.Point(6, 52)
        Me.redBlue.Name = "redBlue"
        Me.redBlue.Size = New System.Drawing.Size(46, 17)
        Me.redBlue.TabIndex = 8
        Me.redBlue.TabStop = True
        Me.redBlue.Text = "Blue"
        Me.redBlue.UseVisualStyleBackColor = True
        '
        'redGreen
        '
        Me.redGreen.AutoSize = True
        Me.redGreen.Location = New System.Drawing.Point(6, 75)
        Me.redGreen.Name = "redGreen"
        Me.redGreen.Size = New System.Drawing.Size(54, 17)
        Me.redGreen.TabIndex = 9
        Me.redGreen.TabStop = True
        Me.redGreen.Text = "Green"
        Me.redGreen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.redGreen)
        Me.GroupBox1.Controls.Add(Me.redBlue)
        Me.GroupBox1.Controls.Add(Me.redRed)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 128)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Radio Buttons - Color"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.redBlack)
        Me.GroupBox2.Controls.Add(Me.redSilver)
        Me.GroupBox2.Controls.Add(Me.redGold)
        Me.GroupBox2.Location = New System.Drawing.Point(201, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 124)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "More Radio Buttons - Trim"
        '
        'redBlack
        '
        Me.redBlack.AutoSize = True
        Me.redBlack.Location = New System.Drawing.Point(18, 78)
        Me.redBlack.Name = "redBlack"
        Me.redBlack.Size = New System.Drawing.Size(52, 17)
        Me.redBlack.TabIndex = 2
        Me.redBlack.TabStop = True
        Me.redBlack.Text = "Black"
        Me.redBlack.UseVisualStyleBackColor = True
        '
        'redSilver
        '
        Me.redSilver.AutoSize = True
        Me.redSilver.Location = New System.Drawing.Point(18, 55)
        Me.redSilver.Name = "redSilver"
        Me.redSilver.Size = New System.Drawing.Size(51, 17)
        Me.redSilver.TabIndex = 1
        Me.redSilver.TabStop = True
        Me.redSilver.Text = "Silver"
        Me.redSilver.UseVisualStyleBackColor = True
        '
        'redGold
        '
        Me.redGold.AutoSize = True
        Me.redGold.Location = New System.Drawing.Point(18, 31)
        Me.redGold.Name = "redGold"
        Me.redGold.Size = New System.Drawing.Size(47, 17)
        Me.redGold.TabIndex = 0
        Me.redGold.TabStop = True
        Me.redGold.Text = "Gold"
        Me.redGold.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkResidential)
        Me.GroupBox3.Controls.Add(Me.chkSaturday)
        Me.GroupBox3.Controls.Add(Me.chkExpress)
        Me.GroupBox3.Location = New System.Drawing.Point(201, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(165, 119)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Check Boxes - Delivery"
        '
        'chkResidential
        '
        Me.chkResidential.AutoSize = True
        Me.chkResidential.Location = New System.Drawing.Point(16, 68)
        Me.chkResidential.Name = "chkResidential"
        Me.chkResidential.Size = New System.Drawing.Size(119, 17)
        Me.chkResidential.TabIndex = 2
        Me.chkResidential.Text = "Residential Address"
        Me.chkResidential.UseVisualStyleBackColor = True
        '
        'chkSaturday
        '
        Me.chkSaturday.AutoSize = True
        Me.chkSaturday.Location = New System.Drawing.Point(16, 45)
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Size = New System.Drawing.Size(109, 17)
        Me.chkSaturday.TabIndex = 1
        Me.chkSaturday.Text = "Saturday Delivery"
        Me.chkSaturday.UseVisualStyleBackColor = True
        '
        'chkExpress
        '
        Me.chkExpress.AutoSize = True
        Me.chkExpress.Location = New System.Drawing.Point(16, 22)
        Me.chkExpress.Name = "chkExpress"
        Me.chkExpress.Size = New System.Drawing.Size(104, 17)
        Me.chkExpress.TabIndex = 0
        Me.chkExpress.Text = "Express Delivery"
        Me.chkExpress.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Date , Time Picker - Approval Date"
        '
        'dtmApproval
        '
        Me.dtmApproval.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmApproval.Location = New System.Drawing.Point(394, 56)
        Me.dtmApproval.Name = "dtmApproval"
        Me.dtmApproval.Size = New System.Drawing.Size(200, 20)
        Me.dtmApproval.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(391, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Month Calander - Sale Date range"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(394, 114)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(395, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "TextBox - Manager Id number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(393, 313)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(390, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "MaskedTextBox- Store Zip Code"
        '
        'mskZip
        '
        Me.mskZip.Location = New System.Drawing.Point(397, 367)
        Me.mskZip.Mask = "00000-9999"
        Me.mskZip.Name = "mskZip"
        Me.mskZip.Size = New System.Drawing.Size(162, 20)
        Me.mskZip.TabIndex = 20
        '
        'frmChoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 690)
        Me.Controls.Add(Me.mskZip)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtmApproval)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.clbHats)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstSizes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSaleItems)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmChoices"
        Me.Text = "Controls That Provide Choices"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboSaleItems As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSizes As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clbHats As CheckedListBox
    Friend WithEvents redRed As RadioButton
    Friend WithEvents redBlue As RadioButton
    Friend WithEvents redGreen As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents redBlack As RadioButton
    Friend WithEvents redSilver As RadioButton
    Friend WithEvents redGold As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkResidential As CheckBox
    Friend WithEvents chkSaturday As CheckBox
    Friend WithEvents chkExpress As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtmApproval As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mskZip As MaskedTextBox
End Class
