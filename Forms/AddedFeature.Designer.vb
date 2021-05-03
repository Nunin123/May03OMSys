<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddedFeature
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCheckStocks = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OMSysStocksDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysOrdersDBDataSet = New OMSys.OMSysOrdersDBDataSet()
        Me.OMSys_StocksDBTableAdapter = New OMSys.OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter()
        Me.lblMaterialName = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblStockList = New System.Windows.Forms.Label()
        CType(Me.dgvCheckStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCheckStocks
        '
        Me.dgvCheckStocks.AllowUserToAddRows = False
        Me.dgvCheckStocks.AllowUserToDeleteRows = False
        Me.dgvCheckStocks.AllowUserToResizeColumns = False
        Me.dgvCheckStocks.AllowUserToResizeRows = False
        Me.dgvCheckStocks.AutoGenerateColumns = False
        Me.dgvCheckStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvCheckStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCheckStocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCheckStocks.ColumnHeadersHeight = 29
        Me.dgvCheckStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCheckStocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MaterialNameDataGridViewTextBoxColumn, Me.Size, Me.Color, Me.StockDataGridViewTextBoxColumn})
        Me.dgvCheckStocks.DataSource = Me.OMSysStocksDBBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCheckStocks.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCheckStocks.EnableHeadersVisualStyles = False
        Me.dgvCheckStocks.Location = New System.Drawing.Point(13, 84)
        Me.dgvCheckStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCheckStocks.Name = "dgvCheckStocks"
        Me.dgvCheckStocks.ReadOnly = True
        Me.dgvCheckStocks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCheckStocks.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCheckStocks.RowHeadersVisible = False
        Me.dgvCheckStocks.RowHeadersWidth = 51
        Me.dgvCheckStocks.Size = New System.Drawing.Size(645, 318)
        Me.dgvCheckStocks.TabIndex = 214
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 90
        '
        'MaterialNameDataGridViewTextBoxColumn
        '
        Me.MaterialNameDataGridViewTextBoxColumn.DataPropertyName = "Material_Name"
        Me.MaterialNameDataGridViewTextBoxColumn.HeaderText = "Material Name"
        Me.MaterialNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaterialNameDataGridViewTextBoxColumn.Name = "MaterialNameDataGridViewTextBoxColumn"
        Me.MaterialNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaterialNameDataGridViewTextBoxColumn.Width = 125
        '
        'Size
        '
        Me.Size.DataPropertyName = "Size"
        Me.Size.HeaderText = "Size"
        Me.Size.MinimumWidth = 6
        Me.Size.Name = "Size"
        Me.Size.ReadOnly = True
        Me.Size.Width = 90
        '
        'Color
        '
        Me.Color.DataPropertyName = "Color"
        Me.Color.HeaderText = "Color"
        Me.Color.MinimumWidth = 6
        Me.Color.Name = "Color"
        Me.Color.ReadOnly = True
        Me.Color.Width = 90
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Width = 90
        '
        'OMSysStocksDBBindingSource
        '
        Me.OMSysStocksDBBindingSource.DataMember = "OMSys_StocksDB"
        Me.OMSysStocksDBBindingSource.DataSource = Me.OMSysOrdersDBDataSet
        '
        'OMSysOrdersDBDataSet
        '
        Me.OMSysOrdersDBDataSet.DataSetName = "OMSysOrdersDBDataSet"
        Me.OMSysOrdersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OMSys_StocksDBTableAdapter
        '
        Me.OMSys_StocksDBTableAdapter.ClearBeforeFill = True
        '
        'lblMaterialName
        '
        Me.lblMaterialName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMaterialName.AutoSize = True
        Me.lblMaterialName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterialName.Location = New System.Drawing.Point(666, 164)
        Me.lblMaterialName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaterialName.Name = "lblMaterialName"
        Me.lblMaterialName.Size = New System.Drawing.Size(120, 19)
        Me.lblMaterialName.TabIndex = 106
        Me.lblMaterialName.Text = "Material Name: "
        '
        'txt_ID
        '
        Me.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Material_Name", True))
        Me.txt_ID.Enabled = False
        Me.txt_ID.Location = New System.Drawing.Point(796, 164)
        Me.txt_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(111, 22)
        Me.txt_ID.TabIndex = 107
        '
        'lblStock
        '
        Me.lblStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(666, 194)
        Me.lblStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(50, 19)
        Me.lblStock.TabIndex = 110
        Me.lblStock.Text = "Stock:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OMSysStocksDBBindingSource, "Stock", True))
        Me.TextBox1.Location = New System.Drawing.Point(796, 194)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(47, 22)
        Me.TextBox1.TabIndex = 111
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(752, 276)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 42)
        Me.btnSave.TabIndex = 112
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblStockList
        '
        Me.lblStockList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStockList.AutoSize = True
        Me.lblStockList.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockList.Location = New System.Drawing.Point(11, 25)
        Me.lblStockList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStockList.Name = "lblStockList"
        Me.lblStockList.Size = New System.Drawing.Size(164, 40)
        Me.lblStockList.TabIndex = 215
        Me.lblStockList.Text = "Stock List"
        '
        'AddedFeature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(920, 423)
        Me.Controls.Add(Me.lblStockList)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lblMaterialName)
        Me.Controls.Add(Me.dgvCheckStocks)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddedFeature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Stocks"
        CType(Me.dgvCheckStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysStocksDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysOrdersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCheckStocks As DataGridView
    Friend WithEvents OMSysOrdersDBDataSet As OMSysOrdersDBDataSet
    Friend WithEvents OMSysStocksDBBindingSource As BindingSource
    Friend WithEvents OMSys_StocksDBTableAdapter As OMSysOrdersDBDataSetTableAdapters.OMSys_StocksDBTableAdapter
    Friend WithEvents lblMaterialName As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblStockList As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents Color As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
