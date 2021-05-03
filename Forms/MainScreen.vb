Imports System.Data.OleDb
Public Class frmMainScreen
    Sub dgv_styleRow()
        For i As Integer = 0 To OMSys_OrdersV2DBDataGridView.RowCount - 1
            If i Mod 2 = 0 Then
                OMSys_OrdersV2DBDataGridView.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.White
            Else
                OMSys_OrdersV2DBDataGridView.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.LightGray
            End If
        Next
    End Sub
    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysOrdersDBDataSet.OMSys_OrdersV2DB' table. You can move, or remove it, as needed.
        Me.OMSys_OrdersV2DBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersV2DB)

        Dim myFNames = From n In OMSysOrdersDBDataSet.OMSys_OrdersV2DB Select n.Customer_FirstName

        txt_FirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_FirstName.AutoCompleteSource = AutoCompleteSource.CustomSource

        txt_FirstName.AutoCompleteCustomSource.AddRange(myFNames.ToArray())

        Dim myLNames = From n In OMSysOrdersDBDataSet.OMSys_OrdersV2DB Select n.Customer_LastName

        txt_LastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_LastName.AutoCompleteSource = AutoCompleteSource.CustomSource

        txt_LastName.AutoCompleteCustomSource.AddRange(myLNames.ToArray())

        dgv_styleRow()

        cmb_Status.Enabled = False
        txt_ProductName.Enabled = False
        txt_FirstName.Enabled = False
        txt_MiddleName.Enabled = False
        txt_LastName.Enabled = False
        txt_Quantity.Enabled = False
        txtPrice.Enabled = False
        txt_Address.Enabled = False
        txt_ContactNumber.Enabled = False
        txtNote.Enabled = False
        dtpAdded.Enabled = False
        dtpDelivered.Enabled = False
    End Sub
    Private Sub doNothing()

    End Sub
    Private Sub displayAll()
        txtSearch.Text = ""

        Me.OMSys_OrdersV2DBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersV2DB)
        Me.OMSys_OrdersV2DBBindingSource.RemoveFilter()
        dgv_styleRow()
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Call displayAll()
    End Sub
    Private Sub OMSys_OrdersV2DBDataGridView_DataSourceChanged(sender As Object, e As EventArgs) Handles OMSys_OrdersV2DBDataGridView.DataSourceChanged
        dgv_styleRow()
    End Sub
    Private Sub btnAddOrder1_Click_1(sender As Object, e As EventArgs) Handles btnAddOrder1.Click
        OMSys_OrdersV2DBBindingSource.AddNew()
        cmb_Status.SelectedIndex = 0
        dgv_styleRow()
        cmb_Status.Enabled = True
        txt_ProductName.Enabled = True
        txt_FirstName.Enabled = True
        txt_MiddleName.Enabled = True
        txt_LastName.Enabled = True
        txt_Quantity.Enabled = True
        txtPrice.Enabled = True
        txt_Address.Enabled = True
        txt_ContactNumber.Enabled = True
        txtNote.Enabled = True
        dtpAdded.Enabled = True
        dtpDelivered.Enabled = True
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt_ProductName.Text = "" Or txt_Quantity.Text = "" Or txt_LastName.Text = "" Or
            txt_FirstName.Text = "" Or txt_Address.Text = "" Or txt_ContactNumber.Text = "" Then

            MessageBox.Show("Please fill the required field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                OMSys_OrdersV2DBBindingSource.EndEdit()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                MessageBox.Show("Order saved!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_styleRow()
                cmb_Status.Enabled = False
                txt_ProductName.Enabled = False
                txt_FirstName.Enabled = False
                txt_MiddleName.Enabled = False
                txt_LastName.Enabled = False
                txt_Quantity.Enabled = False
                txtPrice.Enabled = False
                txt_Address.Enabled = False
                txt_ContactNumber.Enabled = False
                txtNote.Enabled = False
                dtpAdded.Enabled = False
                dtpDelivered.Enabled = False
            Catch ex As Exception
                ' MessageBox.Show("Database error, the application will restart to save the changes.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Application.Restart()
                ' Puwede yung code above pero pwede rin to, ikaw mamili kung ano mas maganda pag nag e-error
                Me.Refresh()
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then
            Try
                OMSys_OrdersV2DBBindingSource.RemoveCurrent()
                OMSys_OrdersV2DBBindingSource.EndEdit()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                dgv_styleRow()
            Catch ex As Exception

            End Try
        End If
        OMSys_OrdersV2DBBindingSource.MoveLast()

    End Sub
    Private Sub txt_Quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_Quantity.TextChanged
        Dim total, price, quantity As Decimal

        price = Val(txtPrice.Text)
        quantity = Val(txt_Quantity.Text)

        total = price * quantity
        txt_TotalPrice.Text = total
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call doNothing()
            Exit Sub
        Else
            OMSys_OrdersV2DBBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSearch.Text & "')" &
                "OR (Customer_FirstName LIKE '" & txtSearch.Text & "') OR (Product_Name LIKE '" & txtSearch.Text & "')" &
                "OR (Address LIKE '" & txtSearch.Text & "') OR (Status LIKE '" & txtSearch.Text & "')" &
                "OR (Customer_MiddleName LIKE '" & txtSearch.Text & "') OR (Customer_LastName LIKE '" & txtSearch.Text & "')"

            If OMSys_OrdersV2DBBindingSource.Count <> 0 Then
                With OMSys_OrdersV2DBDataGridView
                    .DataSource = OMSys_OrdersV2DBBindingSource
                End With
                dgv_styleRow()
            Else
                MessageBox.Show("Nothing found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'OMSys_OrdersV2DBBindingSource = Nothing
                Call displayAll()
            End If
        End If
    End Sub

    Private Sub OMSys_OrdersV2DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles OMSys_OrdersV2DBDataGridView.CellClick

        cmb_Status.Enabled = True
        txt_ProductName.Enabled = True
        txt_FirstName.Enabled = True
        txt_MiddleName.Enabled = True
        txt_LastName.Enabled = True
        txt_Quantity.Enabled = True
        txtPrice.Enabled = True
        txt_Address.Enabled = True
        txt_ContactNumber.Enabled = True
        txtNote.Enabled = True
        dtpAdded.Enabled = True
        dtpDelivered.Enabled = True
    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to clear all the fields?", "Clear Fields", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            txt_ProductName.Text = ""
            txt_FirstName.Text = ""
            txt_MiddleName.Text = ""
            txt_LastName.Text = ""
            txt_Quantity.Text = ""
            txtPrice.Text = ""
            txt_Address.Text = ""
            txt_ContactNumber.Text = ""
            txtNote.Text = ""
        End If
    End Sub

    Private Sub frmMainScreen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub
    Private Sub txtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrice.KeyDown

        If Char.IsDigit(Chr(e.KeyValue)) Or e.KeyData = Keys.Delete Or e.KeyData = Keys.Left Or
            e.KeyData = Keys.Right Or e.KeyData = Keys.Back Then
            e.SuppressKeyPress = False
        Else
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub txt_Quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Quantity.KeyDown
        If Char.IsDigit(Chr(e.KeyValue)) Or e.KeyData = Keys.Delete Or e.KeyData = Keys.Left Or
            e.KeyData = Keys.Right Or e.KeyData = Keys.Back Then
            e.SuppressKeyPress = False
        Else
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_ContactNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ContactNumber.KeyDown
        If Char.IsDigit(Chr(e.KeyValue)) Or e.KeyData = Keys.Delete Or e.KeyData = Keys.Left Or
            e.KeyData = Keys.Right Or e.KeyData = Keys.Back Then
            e.SuppressKeyPress = False
        Else
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim editStock As New AddedFeature

        editStock.Show()
    End Sub

    Private Sub OMSys_OrdersV2DBDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles OMSys_OrdersV2DBDataGridView.CellFormatting
        dgv_styleRow()
    End Sub
End Class