<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblOMSYS = New System.Windows.Forms.Label()
        Me.lblOrderMgmtSys = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.linklblForgotPass = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblOMSYS
        '
        Me.lblOMSYS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOMSYS.AutoSize = True
        Me.lblOMSYS.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOMSYS.Location = New System.Drawing.Point(184, 88)
        Me.lblOMSYS.Name = "lblOMSYS"
        Me.lblOMSYS.Size = New System.Drawing.Size(315, 96)
        Me.lblOMSYS.TabIndex = 0
        Me.lblOMSYS.Text = "OMSYS"
        '
        'lblOrderMgmtSys
        '
        Me.lblOrderMgmtSys.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOrderMgmtSys.AutoSize = True
        Me.lblOrderMgmtSys.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderMgmtSys.Location = New System.Drawing.Point(231, 184)
        Me.lblOrderMgmtSys.Name = "lblOrderMgmtSys"
        Me.lblOrderMgmtSys.Size = New System.Drawing.Size(209, 19)
        Me.lblOrderMgmtSys.TabIndex = 1
        Me.lblOrderMgmtSys.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'lblLogin
        '
        Me.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(314, 236)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(60, 23)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(265, 290)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(160, 32)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(265, 350)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(160, 32)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogin.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(265, 403)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(160, 41)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(142, 295)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(113, 23)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(142, 355)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(108, 23)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password:"
        '
        'linklblForgotPass
        '
        Me.linklblForgotPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.linklblForgotPass.AutoSize = True
        Me.linklblForgotPass.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklblForgotPass.LinkColor = System.Drawing.Color.DarkCyan
        Me.linklblForgotPass.Location = New System.Drawing.Point(280, 489)
        Me.linklblForgotPass.Name = "linklblForgotPass"
        Me.linklblForgotPass.Size = New System.Drawing.Size(127, 19)
        Me.linklblForgotPass.TabIndex = 3
        Me.linklblForgotPass.TabStop = True
        Me.linklblForgotPass.Text = "Forgot Password?"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(679, 548)
        Me.Controls.Add(Me.linklblForgotPass)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblOrderMgmtSys)
        Me.Controls.Add(Me.lblOMSYS)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOMSYS As Label
    Friend WithEvents lblOrderMgmtSys As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents linklblForgotPass As LinkLabel
End Class
