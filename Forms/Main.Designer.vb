<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnManageStock = New System.Windows.Forms.Button()
        Me.lblWelcomeBack = New System.Windows.Forms.Label()
        Me.lblOrderMgmtSys = New System.Windows.Forms.Label()
        Me.lblOMSYS = New System.Windows.Forms.Label()
        Me.btnManageOrder = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnManageStock
        '
        Me.btnManageStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageStock.BackColor = System.Drawing.Color.DarkCyan
        Me.btnManageStock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageStock.ForeColor = System.Drawing.Color.White
        Me.btnManageStock.Location = New System.Drawing.Point(179, 292)
        Me.btnManageStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnManageStock.Name = "btnManageStock"
        Me.btnManageStock.Size = New System.Drawing.Size(177, 48)
        Me.btnManageStock.TabIndex = 1
        Me.btnManageStock.Text = "Manage Stocks"
        Me.btnManageStock.UseVisualStyleBackColor = False
        '
        'lblWelcomeBack
        '
        Me.lblWelcomeBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcomeBack.AutoSize = True
        Me.lblWelcomeBack.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeBack.Location = New System.Drawing.Point(203, 194)
        Me.lblWelcomeBack.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcomeBack.Name = "lblWelcomeBack"
        Me.lblWelcomeBack.Size = New System.Drawing.Size(125, 21)
        Me.lblWelcomeBack.TabIndex = 8
        Me.lblWelcomeBack.Text = "Welcome Back"
        '
        'lblOrderMgmtSys
        '
        Me.lblOrderMgmtSys.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOrderMgmtSys.AutoSize = True
        Me.lblOrderMgmtSys.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderMgmtSys.Location = New System.Drawing.Point(178, 146)
        Me.lblOrderMgmtSys.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrderMgmtSys.Name = "lblOrderMgmtSys"
        Me.lblOrderMgmtSys.Size = New System.Drawing.Size(172, 16)
        Me.lblOrderMgmtSys.TabIndex = 7
        Me.lblOrderMgmtSys.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'lblOMSYS
        '
        Me.lblOMSYS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOMSYS.AutoSize = True
        Me.lblOMSYS.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOMSYS.Location = New System.Drawing.Point(141, 69)
        Me.lblOMSYS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOMSYS.Name = "lblOMSYS"
        Me.lblOMSYS.Size = New System.Drawing.Size(250, 78)
        Me.lblOMSYS.TabIndex = 6
        Me.lblOMSYS.Text = "OMSYS"
        '
        'btnManageOrder
        '
        Me.btnManageOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageOrder.BackColor = System.Drawing.Color.DarkCyan
        Me.btnManageOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageOrder.ForeColor = System.Drawing.Color.White
        Me.btnManageOrder.Location = New System.Drawing.Point(179, 239)
        Me.btnManageOrder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnManageOrder.Name = "btnManageOrder"
        Me.btnManageOrder.Size = New System.Drawing.Size(177, 48)
        Me.btnManageOrder.TabIndex = 0
        Me.btnManageOrder.Text = "Manage Orders"
        Me.btnManageOrder.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogout.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(179, 345)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(177, 48)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(543, 438)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnManageOrder)
        Me.Controls.Add(Me.btnManageStock)
        Me.Controls.Add(Me.lblWelcomeBack)
        Me.Controls.Add(Me.lblOrderMgmtSys)
        Me.Controls.Add(Me.lblOMSYS)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManageStock As Button
    Friend WithEvents lblWelcomeBack As Label
    Friend WithEvents lblOrderMgmtSys As Label
    Friend WithEvents lblOMSYS As Label
    Friend WithEvents btnManageOrder As Button
    Friend WithEvents btnLogout As Button
End Class
