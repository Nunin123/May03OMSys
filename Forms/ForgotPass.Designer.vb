<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPass
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
        Me.panelMasterKey = New System.Windows.Forms.Panel()
        Me.linklblAnotherWay = New System.Windows.Forms.LinkLabel()
        Me.btnEnterKey = New System.Windows.Forms.Button()
        Me.txtMasterKey = New System.Windows.Forms.TextBox()
        Me.lblToGetTheMasterKey = New System.Windows.Forms.Label()
        Me.lblMasterKey = New System.Windows.Forms.Label()
        Me.panelResetPass = New System.Windows.Forms.Panel()
        Me.btnSubmitNewPass = New System.Windows.Forms.Button()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblResetPass = New System.Windows.Forms.Label()
        Me.panelSecQuestion = New System.Windows.Forms.Panel()
        Me.lblSecQues = New System.Windows.Forms.Label()
        Me.txtSecQAnswer = New System.Windows.Forms.TextBox()
        Me.lblSecQuestion = New System.Windows.Forms.Label()
        Me.btnSubmitSecQA = New System.Windows.Forms.Button()
        Me.panelMasterKey.SuspendLayout()
        Me.panelResetPass.SuspendLayout()
        Me.panelSecQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMasterKey
        '
        Me.panelMasterKey.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelMasterKey.Controls.Add(Me.linklblAnotherWay)
        Me.panelMasterKey.Controls.Add(Me.btnEnterKey)
        Me.panelMasterKey.Controls.Add(Me.txtMasterKey)
        Me.panelMasterKey.Controls.Add(Me.lblToGetTheMasterKey)
        Me.panelMasterKey.Controls.Add(Me.lblMasterKey)
        Me.panelMasterKey.Location = New System.Drawing.Point(12, 12)
        Me.panelMasterKey.Name = "panelMasterKey"
        Me.panelMasterKey.Size = New System.Drawing.Size(534, 397)
        Me.panelMasterKey.TabIndex = 4
        '
        'linklblAnotherWay
        '
        Me.linklblAnotherWay.AutoSize = True
        Me.linklblAnotherWay.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklblAnotherWay.LinkColor = System.Drawing.Color.DarkCyan
        Me.linklblAnotherWay.Location = New System.Drawing.Point(199, 237)
        Me.linklblAnotherWay.Name = "linklblAnotherWay"
        Me.linklblAnotherWay.Size = New System.Drawing.Size(121, 19)
        Me.linklblAnotherWay.TabIndex = 9
        Me.linklblAnotherWay.TabStop = True
        Me.linklblAnotherWay.Text = "Try Another Way"
        '
        'btnEnterKey
        '
        Me.btnEnterKey.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEnterKey.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterKey.ForeColor = System.Drawing.Color.White
        Me.btnEnterKey.Location = New System.Drawing.Point(212, 183)
        Me.btnEnterKey.Name = "btnEnterKey"
        Me.btnEnterKey.Size = New System.Drawing.Size(90, 37)
        Me.btnEnterKey.TabIndex = 7
        Me.btnEnterKey.Text = "Enter"
        Me.btnEnterKey.UseVisualStyleBackColor = False
        '
        'txtMasterKey
        '
        Me.txtMasterKey.Location = New System.Drawing.Point(133, 125)
        Me.txtMasterKey.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMasterKey.Name = "txtMasterKey"
        Me.txtMasterKey.Size = New System.Drawing.Size(256, 28)
        Me.txtMasterKey.TabIndex = 6
        Me.txtMasterKey.UseSystemPasswordChar = True
        '
        'lblToGetTheMasterKey
        '
        Me.lblToGetTheMasterKey.AutoSize = True
        Me.lblToGetTheMasterKey.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToGetTheMasterKey.Location = New System.Drawing.Point(11, 340)
        Me.lblToGetTheMasterKey.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToGetTheMasterKey.Name = "lblToGetTheMasterKey"
        Me.lblToGetTheMasterKey.Size = New System.Drawing.Size(386, 19)
        Me.lblToGetTheMasterKey.TabIndex = 5
        Me.lblToGetTheMasterKey.Text = "*To get the master key, please contact the developers."
        Me.lblToGetTheMasterKey.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblMasterKey
        '
        Me.lblMasterKey.AutoSize = True
        Me.lblMasterKey.Location = New System.Drawing.Point(11, 37)
        Me.lblMasterKey.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMasterKey.Name = "lblMasterKey"
        Me.lblMasterKey.Size = New System.Drawing.Size(509, 21)
        Me.lblMasterKey.TabIndex = 4
        Me.lblMasterKey.Text = "Please enter the master key to reset your current password*:"
        Me.lblMasterKey.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'panelResetPass
        '
        Me.panelResetPass.Controls.Add(Me.btnSubmitNewPass)
        Me.panelResetPass.Controls.Add(Me.txtConfirmPass)
        Me.panelResetPass.Controls.Add(Me.txtNewPass)
        Me.panelResetPass.Controls.Add(Me.lblConfirmPass)
        Me.panelResetPass.Controls.Add(Me.lblNewPass)
        Me.panelResetPass.Controls.Add(Me.lblResetPass)
        Me.panelResetPass.Location = New System.Drawing.Point(12, 12)
        Me.panelResetPass.Name = "panelResetPass"
        Me.panelResetPass.Size = New System.Drawing.Size(534, 397)
        Me.panelResetPass.TabIndex = 8
        Me.panelResetPass.Visible = False
        '
        'btnSubmitNewPass
        '
        Me.btnSubmitNewPass.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSubmitNewPass.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitNewPass.ForeColor = System.Drawing.Color.White
        Me.btnSubmitNewPass.Location = New System.Drawing.Point(222, 259)
        Me.btnSubmitNewPass.Name = "btnSubmitNewPass"
        Me.btnSubmitNewPass.Size = New System.Drawing.Size(90, 39)
        Me.btnSubmitNewPass.TabIndex = 5
        Me.btnSubmitNewPass.Text = "Submit"
        Me.btnSubmitNewPass.UseVisualStyleBackColor = False
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(261, 182)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(220, 28)
        Me.txtConfirmPass.TabIndex = 4
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(261, 133)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(220, 28)
        Me.txtNewPass.TabIndex = 3
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Location = New System.Drawing.Point(47, 184)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(161, 21)
        Me.lblConfirmPass.TabIndex = 2
        Me.lblConfirmPass.Text = "Confirm Password:"
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Location = New System.Drawing.Point(47, 133)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(136, 21)
        Me.lblNewPass.TabIndex = 1
        Me.lblNewPass.Text = "New Password:"
        '
        'lblResetPass
        '
        Me.lblResetPass.AutoSize = True
        Me.lblResetPass.Location = New System.Drawing.Point(199, 47)
        Me.lblResetPass.Name = "lblResetPass"
        Me.lblResetPass.Size = New System.Drawing.Size(139, 21)
        Me.lblResetPass.TabIndex = 0
        Me.lblResetPass.Text = "Reset Password"
        Me.lblResetPass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'panelSecQuestion
        '
        Me.panelSecQuestion.Controls.Add(Me.lblSecQues)
        Me.panelSecQuestion.Controls.Add(Me.txtSecQAnswer)
        Me.panelSecQuestion.Controls.Add(Me.lblSecQuestion)
        Me.panelSecQuestion.Controls.Add(Me.btnSubmitSecQA)
        Me.panelSecQuestion.Location = New System.Drawing.Point(12, 12)
        Me.panelSecQuestion.Name = "panelSecQuestion"
        Me.panelSecQuestion.Size = New System.Drawing.Size(531, 397)
        Me.panelSecQuestion.TabIndex = 9
        Me.panelSecQuestion.Visible = False
        '
        'lblSecQues
        '
        Me.lblSecQues.AutoSize = True
        Me.lblSecQues.Location = New System.Drawing.Point(186, 37)
        Me.lblSecQues.Name = "lblSecQues"
        Me.lblSecQues.Size = New System.Drawing.Size(152, 21)
        Me.lblSecQues.TabIndex = 3
        Me.lblSecQues.Text = "Security Question"
        '
        'txtSecQAnswer
        '
        Me.txtSecQAnswer.Location = New System.Drawing.Point(133, 177)
        Me.txtSecQAnswer.Name = "txtSecQAnswer"
        Me.txtSecQAnswer.Size = New System.Drawing.Size(264, 28)
        Me.txtSecQAnswer.TabIndex = 2
        '
        'lblSecQuestion
        '
        Me.lblSecQuestion.AutoSize = True
        Me.lblSecQuestion.Location = New System.Drawing.Point(117, 128)
        Me.lblSecQuestion.Name = "lblSecQuestion"
        Me.lblSecQuestion.Size = New System.Drawing.Size(294, 21)
        Me.lblSecQuestion.TabIndex = 1
        Me.lblSecQuestion.Text = "What is the name of your first pet?"
        '
        'btnSubmitSecQA
        '
        Me.btnSubmitSecQA.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSubmitSecQA.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitSecQA.ForeColor = System.Drawing.Color.White
        Me.btnSubmitSecQA.Location = New System.Drawing.Point(218, 237)
        Me.btnSubmitSecQA.Name = "btnSubmitSecQA"
        Me.btnSubmitSecQA.Size = New System.Drawing.Size(90, 41)
        Me.btnSubmitSecQA.TabIndex = 0
        Me.btnSubmitSecQA.Text = "Submit"
        Me.btnSubmitSecQA.UseVisualStyleBackColor = False
        '
        'ForgotPass
        '
        Me.AcceptButton = Me.btnEnterKey
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(558, 421)
        Me.Controls.Add(Me.panelSecQuestion)
        Me.Controls.Add(Me.panelMasterKey)
        Me.Controls.Add(Me.panelResetPass)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ForgotPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password?"
        Me.panelMasterKey.ResumeLayout(False)
        Me.panelMasterKey.PerformLayout()
        Me.panelResetPass.ResumeLayout(False)
        Me.panelResetPass.PerformLayout()
        Me.panelSecQuestion.ResumeLayout(False)
        Me.panelSecQuestion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMasterKey As Panel
    Friend WithEvents panelResetPass As Panel
    Friend WithEvents btnEnterKey As Button
    Friend WithEvents txtMasterKey As TextBox
    Friend WithEvents lblToGetTheMasterKey As Label
    Friend WithEvents lblMasterKey As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents lblConfirmPass As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents btnSubmitNewPass As Button
    Friend WithEvents lblResetPass As Label
    Friend WithEvents linklblAnotherWay As LinkLabel
    Friend WithEvents panelSecQuestion As Panel
    Friend WithEvents txtSecQAnswer As TextBox
    Friend WithEvents lblSecQuestion As Label
    Friend WithEvents btnSubmitSecQA As Button
    Friend WithEvents lblSecQues As Label
End Class
