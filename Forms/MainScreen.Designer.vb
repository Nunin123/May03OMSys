<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.RichTextBox()
        Me.OMSys_OrdersV2DBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysOrdersDBDataSet = New OMSys.OMSysOrdersDBDataSet()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmb_Status = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpDelivered = New System.Windows.Forms.DateTimePicker()
        Me.lbl_DateDelivered = New System.Windows.Forms.Label()
        Me.txt_ContactNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAsterisk7 = New System.Windows.Forms.Label()
        Me.lblAsterisk6 = New System.Windows.Forms.Label()
        Me.lblAsterisk8 = New System.Windows.Forms.Label()
        Me.lblAsterisk5 = New System.Windows.Forms.Label()
        Me.lblAsterisk4 = New System.Windows.Forms.Label()
        Me.lblAsterisk3 = New System.Windows.Forms.Label()
        Me.lblAsterisk2 = New System.Windows.Forms.Label()
        Me.lblAsterisk1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnAddOrder1 = New System.Windows.Forms.Button()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_TotalPrice = New System.Windows.Forms.TextBox()
        Me.lbl_TotalPrice = New System.Windows.Forms.Label()
        Me.txt_Quantity = New System.Windows.Forms.TextBox()
        Me.lbl_Quantity = New System.Windows.Forms.Label()
        Me.txt_LastName = New System.Windows.Forms.TextBox()
        Me.txt_MiddleName = New System.Windows.Forms.TextBox()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.lbl_LastName = New System.Windows.Forms.Label()
        Me.lbl_MiddleName = New System.Windows.Forms.Label()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.txt_ProductName = New System.Windows.Forms.TextBox()
        Me.lbl_ProductName = New System.Windows.Forms.Label()
        Me.dtpAdded = New System.Windows.Forms.DateTimePicker()
        Me.lbl_DateAdded = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lbl_OrderID = New System.Windows.Forms.Label()
        Me.lblSearchFor = New System.Windows.Forms.Label()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.OMSys_OrdersV2DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Added = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Delivered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblOrderMgmtSys = New System.Windows.Forms.Label()
        Me.lblOMSYS = New System.Windows.Forms.Label()
        Me.lblOrderList = New System.Windows.Forms.Label()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager()
        Me.OmSys_OrdersDBTableAdapter1 = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter()
        Me.OMSysStocksDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmSysOrdersDBDataSet1 = New OMSys.OMSysOrdersDBDataSet()
        Me.OMSys_OrdersV2DBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersV2DBTableAdapter()
        Me.OMSys_OrdersDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter()
        Me.OMSys_OrdersDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSys_StocksDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter()
        Me.btnVerify = New System.Windows.Forms.Button()
        CType(Me.OMSys_OrdersV2DBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersV2DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmSysOrdersDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClearFields
        '
        Me.btnClearFields.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearFields.BackColor = System.Drawing.Color.DarkCyan
        Me.btnClearFields.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFields.ForeColor = System.Drawing.Color.White
        Me.btnClearFields.Location = New System.Drawing.Point(849, 770)
        Me.btnClearFields.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(99, 42)
        Me.btnClearFields.TabIndex = 18
        Me.btnClearFields.Text = "Clear Fields"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(408, 589)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 229
        Me.Label6.Text = "Price:"
        '
        'txtNote
        '
        Me.txtNote.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Notes", True))
        Me.txtNote.Location = New System.Drawing.Point(951, 544)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(249, 95)
        Me.txtNote.TabIndex = 15
        Me.txtNote.Text = ""
        '
        'OMSys_OrdersV2DBBindingSource
        '
        Me.OMSys_OrdersV2DBBindingSource.DataMember = "OMSys_OrdersV2DB"
        Me.OMSys_OrdersV2DBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSysOrdersDBDataSet
        '
        Me.OMSysOrdersDBDataSet.DataSetName = "OMSysOrdersDBDataSet"
        Me.OMSysOrdersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblNotes
        '
        Me.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(831, 548)
        Me.lblNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(46, 19)
        Me.lblNotes.TabIndex = 228
        Me.lblNotes.Text = "Note:"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.DarkCyan
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(1089, 770)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 42)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(831, 670)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(54, 19)
        Me.lblStatus.TabIndex = 227
        Me.lblStatus.Text = "Status:"
        '
        'cmb_Status
        '
        Me.cmb_Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Status", True))
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Items.AddRange(New Object() {"PENDING", "PAID", "COMPLETED", "CANCELLED"})
        Me.cmb_Status.Location = New System.Drawing.Point(951, 664)
        Me.cmb_Status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(150, 25)
        Me.cmb_Status.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(969, 770)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 42)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dtpDelivered
        '
        Me.dtpDelivered.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpDelivered.Checked = False
        Me.dtpDelivered.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Date_Delivered", True))
        Me.dtpDelivered.Location = New System.Drawing.Point(951, 711)
        Me.dtpDelivered.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDelivered.Name = "dtpDelivered"
        Me.dtpDelivered.ShowCheckBox = True
        Me.dtpDelivered.Size = New System.Drawing.Size(249, 23)
        Me.dtpDelivered.TabIndex = 17
        '
        'lbl_DateDelivered
        '
        Me.lbl_DateDelivered.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_DateDelivered.AutoSize = True
        Me.lbl_DateDelivered.Location = New System.Drawing.Point(831, 715)
        Me.lbl_DateDelivered.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_DateDelivered.Name = "lbl_DateDelivered"
        Me.lbl_DateDelivered.Size = New System.Drawing.Size(116, 19)
        Me.lbl_DateDelivered.TabIndex = 226
        Me.lbl_DateDelivered.Text = "Date Delivered:"
        '
        'txt_ContactNumber
        '
        Me.txt_ContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ContactNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Contact_Number", True))
        Me.txt_ContactNumber.Location = New System.Drawing.Point(551, 754)
        Me.txt_ContactNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ContactNumber.Name = "txt_ContactNumber"
        Me.txt_ContactNumber.Size = New System.Drawing.Size(226, 23)
        Me.txt_ContactNumber.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(408, 760)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 19)
        Me.Label5.TabIndex = 225
        Me.Label5.Text = "Contact Number:"
        '
        'lblAsterisk7
        '
        Me.lblAsterisk7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk7.AutoSize = True
        Me.lblAsterisk7.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk7.Location = New System.Drawing.Point(532, 758)
        Me.lblAsterisk7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk7.Name = "lblAsterisk7"
        Me.lblAsterisk7.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk7.TabIndex = 237
        Me.lblAsterisk7.Text = "*"
        '
        'lblAsterisk6
        '
        Me.lblAsterisk6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk6.AutoSize = True
        Me.lblAsterisk6.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk6.Location = New System.Drawing.Point(468, 715)
        Me.lblAsterisk6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk6.Name = "lblAsterisk6"
        Me.lblAsterisk6.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk6.TabIndex = 236
        Me.lblAsterisk6.Text = "*"
        '
        'lblAsterisk8
        '
        Me.lblAsterisk8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk8.AutoSize = True
        Me.lblAsterisk8.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk8.Location = New System.Drawing.Point(881, 668)
        Me.lblAsterisk8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk8.Name = "lblAsterisk8"
        Me.lblAsterisk8.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk8.TabIndex = 235
        Me.lblAsterisk8.Text = "*"
        '
        'lblAsterisk5
        '
        Me.lblAsterisk5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk5.AutoSize = True
        Me.lblAsterisk5.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk5.Location = New System.Drawing.Point(478, 625)
        Me.lblAsterisk5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk5.Name = "lblAsterisk5"
        Me.lblAsterisk5.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk5.TabIndex = 234
        Me.lblAsterisk5.Text = "*"
        '
        'lblAsterisk4
        '
        Me.lblAsterisk4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk4.AutoSize = True
        Me.lblAsterisk4.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk4.Location = New System.Drawing.Point(104, 715)
        Me.lblAsterisk4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk4.Name = "lblAsterisk4"
        Me.lblAsterisk4.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk4.TabIndex = 233
        Me.lblAsterisk4.Text = "*"
        '
        'lblAsterisk3
        '
        Me.lblAsterisk3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk3.AutoSize = True
        Me.lblAsterisk3.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk3.Location = New System.Drawing.Point(102, 624)
        Me.lblAsterisk3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk3.Name = "lblAsterisk3"
        Me.lblAsterisk3.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk3.TabIndex = 232
        Me.lblAsterisk3.Text = "*"
        '
        'lblAsterisk2
        '
        Me.lblAsterisk2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk2.AutoSize = True
        Me.lblAsterisk2.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk2.Location = New System.Drawing.Point(516, 548)
        Me.lblAsterisk2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk2.Name = "lblAsterisk2"
        Me.lblAsterisk2.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk2.TabIndex = 231
        Me.lblAsterisk2.Text = "*"
        '
        'lblAsterisk1
        '
        Me.lblAsterisk1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAsterisk1.AutoSize = True
        Me.lblAsterisk1.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisk1.Location = New System.Drawing.Point(90, 548)
        Me.lblAsterisk1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisk1.Name = "lblAsterisk1"
        Me.lblAsterisk1.Size = New System.Drawing.Size(15, 19)
        Me.lblAsterisk1.TabIndex = 230
        Me.lblAsterisk1.Text = "*"
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Price", True))
        Me.txtPrice.Location = New System.Drawing.Point(550, 585)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(149, 23)
        Me.txtPrice.TabIndex = 10
        '
        'btnAddOrder1
        '
        Me.btnAddOrder1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddOrder1.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAddOrder1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder1.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder1.Location = New System.Drawing.Point(1415, 51)
        Me.btnAddOrder1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddOrder1.Name = "btnAddOrder1"
        Me.btnAddOrder1.Size = New System.Drawing.Size(112, 42)
        Me.btnAddOrder1.TabIndex = 3
        Me.btnAddOrder1.Text = "New Order"
        Me.btnAddOrder1.UseVisualStyleBackColor = False
        '
        'txt_Address
        '
        Me.txt_Address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Address", True))
        Me.txt_Address.Location = New System.Drawing.Point(550, 711)
        Me.txt_Address.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(226, 23)
        Me.txt_Address.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(408, 715)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 224
        Me.Label4.Text = "Address:"
        '
        'txt_TotalPrice
        '
        Me.txt_TotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_TotalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Total_Price", True))
        Me.txt_TotalPrice.Enabled = False
        Me.txt_TotalPrice.Location = New System.Drawing.Point(550, 666)
        Me.txt_TotalPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_TotalPrice.Name = "txt_TotalPrice"
        Me.txt_TotalPrice.Size = New System.Drawing.Size(149, 23)
        Me.txt_TotalPrice.TabIndex = 12
        '
        'lbl_TotalPrice
        '
        Me.lbl_TotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_TotalPrice.AutoSize = True
        Me.lbl_TotalPrice.Location = New System.Drawing.Point(408, 670)
        Me.lbl_TotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_TotalPrice.Name = "lbl_TotalPrice"
        Me.lbl_TotalPrice.Size = New System.Drawing.Size(82, 19)
        Me.lbl_TotalPrice.TabIndex = 223
        Me.lbl_TotalPrice.Text = "Total Price:"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Quantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Quantity", True))
        Me.txt_Quantity.Location = New System.Drawing.Point(550, 622)
        Me.txt_Quantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(149, 23)
        Me.txt_Quantity.TabIndex = 11
        '
        'lbl_Quantity
        '
        Me.lbl_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Quantity.AutoSize = True
        Me.lbl_Quantity.Location = New System.Drawing.Point(408, 628)
        Me.lbl_Quantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Quantity.Name = "lbl_Quantity"
        Me.lbl_Quantity.Size = New System.Drawing.Size(74, 19)
        Me.lbl_Quantity.TabIndex = 222
        Me.lbl_Quantity.Text = "Quantity:"
        '
        'txt_LastName
        '
        Me.txt_LastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_LastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_LastName", True))
        Me.txt_LastName.Location = New System.Drawing.Point(130, 711)
        Me.txt_LastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(184, 23)
        Me.txt_LastName.TabIndex = 8
        '
        'txt_MiddleName
        '
        Me.txt_MiddleName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_MiddleName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_MiddleName", True))
        Me.txt_MiddleName.Location = New System.Drawing.Point(130, 666)
        Me.txt_MiddleName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_MiddleName.Name = "txt_MiddleName"
        Me.txt_MiddleName.Size = New System.Drawing.Size(184, 23)
        Me.txt_MiddleName.TabIndex = 7
        '
        'txt_FirstName
        '
        Me.txt_FirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_FirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Customer_FirstName", True))
        Me.txt_FirstName.Location = New System.Drawing.Point(130, 622)
        Me.txt_FirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(184, 23)
        Me.txt_FirstName.TabIndex = 6
        '
        'lbl_LastName
        '
        Me.lbl_LastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_LastName.AutoSize = True
        Me.lbl_LastName.Location = New System.Drawing.Point(24, 716)
        Me.lbl_LastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_LastName.Name = "lbl_LastName"
        Me.lbl_LastName.Size = New System.Drawing.Size(85, 19)
        Me.lbl_LastName.TabIndex = 221
        Me.lbl_LastName.Text = "Last Name:"
        '
        'lbl_MiddleName
        '
        Me.lbl_MiddleName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_MiddleName.AutoSize = True
        Me.lbl_MiddleName.Location = New System.Drawing.Point(24, 670)
        Me.lbl_MiddleName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_MiddleName.Name = "lbl_MiddleName"
        Me.lbl_MiddleName.Size = New System.Drawing.Size(107, 19)
        Me.lbl_MiddleName.TabIndex = 220
        Me.lbl_MiddleName.Text = "Middle Name:"
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Location = New System.Drawing.Point(24, 628)
        Me.lbl_FirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(83, 19)
        Me.lbl_FirstName.TabIndex = 219
        Me.lbl_FirstName.Text = "First Name:"
        '
        'txt_ProductName
        '
        Me.txt_ProductName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Product_Name", True))
        Me.txt_ProductName.Location = New System.Drawing.Point(550, 548)
        Me.txt_ProductName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ProductName.Name = "txt_ProductName"
        Me.txt_ProductName.Size = New System.Drawing.Size(226, 23)
        Me.txt_ProductName.TabIndex = 9
        '
        'lbl_ProductName
        '
        Me.lbl_ProductName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ProductName.AutoSize = True
        Me.lbl_ProductName.Location = New System.Drawing.Point(408, 549)
        Me.lbl_ProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ProductName.Name = "lbl_ProductName"
        Me.lbl_ProductName.Size = New System.Drawing.Size(113, 19)
        Me.lbl_ProductName.TabIndex = 218
        Me.lbl_ProductName.Text = "Product Name:"
        '
        'dtpAdded
        '
        Me.dtpAdded.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpAdded.Checked = False
        Me.dtpAdded.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "Date_Added", True))
        Me.dtpAdded.Location = New System.Drawing.Point(130, 585)
        Me.dtpAdded.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpAdded.Name = "dtpAdded"
        Me.dtpAdded.ShowCheckBox = True
        Me.dtpAdded.Size = New System.Drawing.Size(249, 23)
        Me.dtpAdded.TabIndex = 5
        '
        'lbl_DateAdded
        '
        Me.lbl_DateAdded.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_DateAdded.AutoSize = True
        Me.lbl_DateAdded.Location = New System.Drawing.Point(24, 589)
        Me.lbl_DateAdded.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_DateAdded.Name = "lbl_DateAdded"
        Me.lbl_DateAdded.Size = New System.Drawing.Size(99, 19)
        Me.lbl_DateAdded.TabIndex = 217
        Me.lbl_DateAdded.Text = "Date Added:"
        '
        'txt_ID
        '
        Me.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSys_OrdersV2DBBindingSource, "ID", True))
        Me.txt_ID.Enabled = False
        Me.txt_ID.Location = New System.Drawing.Point(130, 548)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(112, 23)
        Me.txt_ID.TabIndex = 4
        '
        'lbl_OrderID
        '
        Me.lbl_OrderID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_OrderID.AutoSize = True
        Me.lbl_OrderID.Location = New System.Drawing.Point(24, 549)
        Me.lbl_OrderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_OrderID.Name = "lbl_OrderID"
        Me.lbl_OrderID.Size = New System.Drawing.Size(69, 19)
        Me.lbl_OrderID.TabIndex = 216
        Me.lbl_OrderID.Text = "Order ID:"
        '
        'lblSearchFor
        '
        Me.lblSearchFor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSearchFor.AutoSize = True
        Me.lblSearchFor.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchFor.Location = New System.Drawing.Point(260, 50)
        Me.lblSearchFor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearchFor.Name = "lblSearchFor"
        Me.lblSearchFor.Size = New System.Drawing.Size(252, 13)
        Me.lblSearchFor.TabIndex = 215
        Me.lblSearchFor.Text = "(ID, Customer Name, Product Name, Address or Status)"
        '
        'btnViewAll
        '
        Me.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewAll.BackColor = System.Drawing.Color.DarkCyan
        Me.btnViewAll.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.Location = New System.Drawing.Point(665, 50)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(112, 42)
        Me.btnViewAll.TabIndex = 2
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(530, 50)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 42)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'OMSys_OrdersV2DBDataGridView
        '
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToAddRows = False
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToDeleteRows = False
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToResizeColumns = False
        Me.OMSys_OrdersV2DBDataGridView.AllowUserToResizeRows = False
        Me.OMSys_OrdersV2DBDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OMSys_OrdersV2DBDataGridView.AutoGenerateColumns = False
        Me.OMSys_OrdersV2DBDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersHeight = 29
        Me.OMSys_OrdersV2DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.OMSys_OrdersV2DBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Date_Added, Me.Customer_FirstName, Me.Customer_MiddleName, Me.Customer_LastName, Me.DataGridViewTextBoxColumn3, Me.Price, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Date_Delivered})
        Me.OMSys_OrdersV2DBDataGridView.DataSource = Me.OMSys_OrdersV2DBBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OMSys_OrdersV2DBDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.OMSys_OrdersV2DBDataGridView.EnableHeadersVisualStyles = False
        Me.OMSys_OrdersV2DBDataGridView.Location = New System.Drawing.Point(12, 111)
        Me.OMSys_OrdersV2DBDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OMSys_OrdersV2DBDataGridView.Name = "OMSys_OrdersV2DBDataGridView"
        Me.OMSys_OrdersV2DBDataGridView.ReadOnly = True
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersVisible = False
        Me.OMSys_OrdersV2DBDataGridView.RowHeadersWidth = 51
        Me.OMSys_OrdersV2DBDataGridView.Size = New System.Drawing.Size(1514, 405)
        Me.OMSys_OrdersV2DBDataGridView.TabIndex = 214
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Order ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'Date_Added
        '
        Me.Date_Added.DataPropertyName = "Date_Added"
        DataGridViewCellStyle2.Format = "D"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Date_Added.DefaultCellStyle = DataGridViewCellStyle2
        Me.Date_Added.HeaderText = "Date Added"
        Me.Date_Added.MinimumWidth = 6
        Me.Date_Added.Name = "Date_Added"
        Me.Date_Added.ReadOnly = True
        Me.Date_Added.Width = 150
        '
        'Customer_FirstName
        '
        Me.Customer_FirstName.DataPropertyName = "Customer_FirstName"
        Me.Customer_FirstName.HeaderText = "First Name"
        Me.Customer_FirstName.MinimumWidth = 6
        Me.Customer_FirstName.Name = "Customer_FirstName"
        Me.Customer_FirstName.ReadOnly = True
        Me.Customer_FirstName.Width = 125
        '
        'Customer_MiddleName
        '
        Me.Customer_MiddleName.DataPropertyName = "Customer_MiddleName"
        Me.Customer_MiddleName.HeaderText = "Middle Name"
        Me.Customer_MiddleName.MinimumWidth = 6
        Me.Customer_MiddleName.Name = "Customer_MiddleName"
        Me.Customer_MiddleName.ReadOnly = True
        Me.Customer_MiddleName.Width = 125
        '
        'Customer_LastName
        '
        Me.Customer_LastName.DataPropertyName = "Customer_LastName"
        Me.Customer_LastName.HeaderText = "Last Name"
        Me.Customer_LastName.MinimumWidth = 6
        Me.Customer_LastName.Name = "Customer_LastName"
        Me.Customer_LastName.ReadOnly = True
        Me.Customer_LastName.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle3
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total_Price"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Price"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Contact_Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 145
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'Date_Delivered
        '
        Me.Date_Delivered.DataPropertyName = "Date_Delivered"
        DataGridViewCellStyle5.Format = "D"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Date_Delivered.DefaultCellStyle = DataGridViewCellStyle5
        Me.Date_Delivered.HeaderText = "Date Delivered"
        Me.Date_Delivered.MinimumWidth = 6
        Me.Date_Delivered.Name = "Date_Delivered"
        Me.Date_Delivered.ReadOnly = True
        Me.Date_Delivered.Width = 150
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.Location = New System.Drawing.Point(262, 64)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(245, 23)
        Me.txtSearch.TabIndex = 0
        '
        'lblOrderMgmtSys
        '
        Me.lblOrderMgmtSys.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOrderMgmtSys.AutoSize = True
        Me.lblOrderMgmtSys.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderMgmtSys.Location = New System.Drawing.Point(1262, 735)
        Me.lblOrderMgmtSys.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderMgmtSys.Name = "lblOrderMgmtSys"
        Me.lblOrderMgmtSys.Size = New System.Drawing.Size(209, 19)
        Me.lblOrderMgmtSys.TabIndex = 213
        Me.lblOrderMgmtSys.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'lblOMSYS
        '
        Me.lblOMSYS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOMSYS.AutoSize = True
        Me.lblOMSYS.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOMSYS.Location = New System.Drawing.Point(1216, 625)
        Me.lblOMSYS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOMSYS.Name = "lblOMSYS"
        Me.lblOMSYS.Size = New System.Drawing.Size(315, 96)
        Me.lblOMSYS.TabIndex = 212
        Me.lblOMSYS.Text = "OMSYS"
        '
        'lblOrderList
        '
        Me.lblOrderList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOrderList.AutoSize = True
        Me.lblOrderList.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderList.Location = New System.Drawing.Point(2, 35)
        Me.lblOrderList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderList.Name = "lblOrderList"
        Me.lblOrderList.Size = New System.Drawing.Size(237, 58)
        Me.lblOrderList.TabIndex = 191
        Me.lblOrderList.Text = "Order List"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(2228, 179)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(112, 42)
        Me.btnAddOrder.TabIndex = 194
        Me.btnAddOrder.Text = "New Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.OMSys_OrdersDBTableAdapter = Me.OmSys_OrdersDBTableAdapter1
        Me.TableAdapterManager1.OMSys_OrdersV2DBTableAdapter = Nothing
        Me.TableAdapterManager1.OMSys_StocksDBTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OmSys_OrdersDBTableAdapter1
        '
        Me.OmSys_OrdersDBTableAdapter1.ClearBeforeFill = True
        '
        'OMSysStocksDBBindingSource
        '
        Me.OMSysStocksDBBindingSource.DataMember = "OMSys_StocksDB"
        Me.OMSysStocksDBBindingSource.DataSource = Me.OmSysOrdersDBDataSet1
        '
        'OmSysOrdersDBDataSet1
        '
        Me.OmSysOrdersDBDataSet1.DataSetName = "OMSysOrdersDBDataSet"
        Me.OmSysOrdersDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OMSys_OrdersV2DBTableAdapter
        '
        Me.OMSys_OrdersV2DBTableAdapter.ClearBeforeFill = True
        '
        'OMSys_OrdersDBTableAdapter
        '
        Me.OMSys_OrdersDBTableAdapter.ClearBeforeFill = True
        '
        'OMSys_OrdersDBBindingSource
        '
        Me.OMSys_OrdersDBBindingSource.DataMember = "OMSys_OrdersDB"
        Me.OMSys_OrdersDBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OMSys_OrdersDBTableAdapter = Me.OMSys_OrdersDBTableAdapter
        Me.TableAdapterManager.OMSys_OrdersV2DBTableAdapter = Nothing
        Me.TableAdapterManager.OMSys_StocksDBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OMSys.OMSysOrdersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "OMSys_OrdersDB"
        Me.BindingSource1.DataSource = Me.OmSysOrdersDBDataSet1
        '
        'OMSys_StocksDBTableAdapter
        '
        Me.OMSys_StocksDBTableAdapter.ClearBeforeFill = True
        '
        'btnVerify
        '
        Me.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerify.BackColor = System.Drawing.Color.DarkCyan
        Me.btnVerify.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.ForeColor = System.Drawing.Color.White
        Me.btnVerify.Location = New System.Drawing.Point(707, 619)
        Me.btnVerify.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(70, 28)
        Me.btnVerify.TabIndex = 238
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = False
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1544, 838)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnClearFields)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmb_Status)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpDelivered)
        Me.Controls.Add(Me.lbl_DateDelivered)
        Me.Controls.Add(Me.txt_ContactNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAsterisk7)
        Me.Controls.Add(Me.lblAsterisk6)
        Me.Controls.Add(Me.lblAsterisk8)
        Me.Controls.Add(Me.lblAsterisk5)
        Me.Controls.Add(Me.lblAsterisk4)
        Me.Controls.Add(Me.lblAsterisk3)
        Me.Controls.Add(Me.lblAsterisk2)
        Me.Controls.Add(Me.lblAsterisk1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnAddOrder1)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_TotalPrice)
        Me.Controls.Add(Me.lbl_TotalPrice)
        Me.Controls.Add(Me.txt_Quantity)
        Me.Controls.Add(Me.lbl_Quantity)
        Me.Controls.Add(Me.txt_LastName)
        Me.Controls.Add(Me.txt_MiddleName)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.lbl_LastName)
        Me.Controls.Add(Me.lbl_MiddleName)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.txt_ProductName)
        Me.Controls.Add(Me.lbl_ProductName)
        Me.Controls.Add(Me.dtpAdded)
        Me.Controls.Add(Me.lbl_DateAdded)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lbl_OrderID)
        Me.Controls.Add(Me.lblSearchFor)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.OMSys_OrdersV2DBDataGridView)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblOrderMgmtSys)
        Me.Controls.Add(Me.lblOMSYS)
        Me.Controls.Add(Me.lblOrderList)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OMSys"
        CType(Me.OMSys_OrdersV2DBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSys_OrdersV2DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmSysOrdersDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSys_OrdersDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager1 As OMSysOrdersDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OmSys_OrdersDBTableAdapter1 As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter
    Friend WithEvents OMSysStocksDBBindingSource As BindingSource
    Friend WithEvents OmSysOrdersDBDataSet1 As OMSysOrdersDBDataSet
    Friend WithEvents OMSys_OrdersV2DBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersV2DBTableAdapter
    Friend WithEvents OMSys_OrdersDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_OrdersDBTableAdapter
    Friend WithEvents OMSys_OrdersDBBindingSource As BindingSource
    Friend WithEvents OMSysOrdersDBDataSet As OMSysOrdersDBDataSet
    Friend WithEvents TableAdapterManager As OMSysOrdersDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents OMSys_StocksDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter
    Friend WithEvents btnClearFields As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNote As RichTextBox
    Friend WithEvents OMSys_OrdersV2DBBindingSource As BindingSource
    Friend WithEvents lblNotes As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmb_Status As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpDelivered As DateTimePicker
    Friend WithEvents lbl_DateDelivered As Label
    Friend WithEvents txt_ContactNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAsterisk7 As Label
    Friend WithEvents lblAsterisk6 As Label
    Friend WithEvents lblAsterisk8 As Label
    Friend WithEvents lblAsterisk5 As Label
    Friend WithEvents lblAsterisk4 As Label
    Friend WithEvents lblAsterisk3 As Label
    Friend WithEvents lblAsterisk2 As Label
    Friend WithEvents lblAsterisk1 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnAddOrder1 As Button
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_TotalPrice As TextBox
    Friend WithEvents lbl_TotalPrice As Label
    Friend WithEvents txt_Quantity As TextBox
    Friend WithEvents lbl_Quantity As Label
    Friend WithEvents txt_LastName As TextBox
    Friend WithEvents txt_MiddleName As TextBox
    Friend WithEvents txt_FirstName As TextBox
    Friend WithEvents lbl_LastName As Label
    Friend WithEvents lbl_MiddleName As Label
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents txt_ProductName As TextBox
    Friend WithEvents lbl_ProductName As Label
    Friend WithEvents dtpAdded As DateTimePicker
    Friend WithEvents lbl_DateAdded As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents lbl_OrderID As Label
    Friend WithEvents lblSearchFor As Label
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents OMSys_OrdersV2DBDataGridView As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblOrderMgmtSys As Label
    Friend WithEvents lblOMSYS As Label
    Friend WithEvents lblOrderList As Label
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Date_Added As DataGridViewTextBoxColumn
    Friend WithEvents Customer_FirstName As DataGridViewTextBoxColumn
    Friend WithEvents Customer_MiddleName As DataGridViewTextBoxColumn
    Friend WithEvents Customer_LastName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Date_Delivered As DataGridViewTextBoxColumn
    Friend WithEvents btnVerify As Button
End Class
