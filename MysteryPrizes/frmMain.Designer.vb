<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.picPrize = New System.Windows.Forms.PictureBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblForfit = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblWinnings = New System.Windows.Forms.Label()
        Me.lblPrizeVal = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.timSpin = New System.Windows.Forms.Timer(Me.components)
        Me.picWOW = New System.Windows.Forms.PictureBox()
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWOW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPrize
        '
        Me.picPrize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPrize.Image = Global.MysteryPrizes.My.Resources.Resources.soulja_boy_console_e1544199003402
        Me.picPrize.Location = New System.Drawing.Point(233, 100)
        Me.picPrize.Name = "picPrize"
        Me.picPrize.Size = New System.Drawing.Size(642, 510)
        Me.picPrize.TabIndex = 21
        Me.picPrize.TabStop = False
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(838, 616)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(156, 32)
        Me.btnQuit.TabIndex = 20
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(30, 520)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(156, 32)
        Me.btnStop.TabIndex = 19
        Me.btnStop.Text = "Stop The Spin"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(30, 468)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(156, 32)
        Me.btnStart.TabIndex = 18
        Me.btnStart.Text = "Start The Spin"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblForfit
        '
        Me.lblForfit.AutoSize = True
        Me.lblForfit.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForfit.ForeColor = System.Drawing.Color.Crimson
        Me.lblForfit.Location = New System.Drawing.Point(25, 367)
        Me.lblForfit.Name = "lblForfit"
        Me.lblForfit.Size = New System.Drawing.Size(107, 29)
        Me.lblForfit.TabIndex = 17
        Me.lblForfit.Text = "You Lose!"
        Me.lblForfit.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(20, 291)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Winnings "
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(20, 222)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(60, 13)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Prize Value"
        '
        'lblWinnings
        '
        Me.lblWinnings.BackColor = System.Drawing.Color.GhostWhite
        Me.lblWinnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWinnings.Location = New System.Drawing.Point(23, 304)
        Me.lblWinnings.Name = "lblWinnings"
        Me.lblWinnings.Size = New System.Drawing.Size(163, 34)
        Me.lblWinnings.TabIndex = 14
        Me.lblWinnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrizeVal
        '
        Me.lblPrizeVal.BackColor = System.Drawing.Color.GhostWhite
        Me.lblPrizeVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrizeVal.Location = New System.Drawing.Point(23, 235)
        Me.lblPrizeVal.Name = "lblPrizeVal"
        Me.lblPrizeVal.Size = New System.Drawing.Size(163, 34)
        Me.lblPrizeVal.TabIndex = 13
        Me.lblPrizeVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(23, 165)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(163, 34)
        Me.lblResult.TabIndex = 12
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Coral
        Me.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.label1.Location = New System.Drawing.Point(48, 4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(722, 93)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Enterprise Gallery - Spin to Win"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timSpin
        '
        '
        'picWOW
        '
        Me.picWOW.BackColor = System.Drawing.Color.Goldenrod
        Me.picWOW.Image = Global.MysteryPrizes.My.Resources.Resources.pogchamp_png_and_pogchamp_transparent_clipart_free_download_pogchamp_png_260_260
        Me.picWOW.Location = New System.Drawing.Point(141, 360)
        Me.picWOW.Name = "picWOW"
        Me.picWOW.Size = New System.Drawing.Size(76, 92)
        Me.picWOW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWOW.TabIndex = 22
        Me.picWOW.TabStop = False
        Me.picWOW.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1026, 681)
        Me.Controls.Add(Me.picWOW)
        Me.Controls.Add(Me.picPrize)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblForfit)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.lblWinnings)
        Me.Controls.Add(Me.lblPrizeVal)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWOW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents picPrize As PictureBox
    Private WithEvents btnQuit As Button
    Private WithEvents btnStop As Button
    Private WithEvents btnStart As Button
    Private WithEvents lblForfit As Label
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents lblWinnings As Label
    Private WithEvents lblPrizeVal As Label
    Private WithEvents lblResult As Label
    Private WithEvents label1 As Label
    Private WithEvents timSpin As Timer
    Public WithEvents picWOW As PictureBox
End Class
