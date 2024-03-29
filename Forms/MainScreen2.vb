﻿
Public Class frmMainScreen2
    Dim yes As Boolean = False

    Sub dgv_styleRow()
        For i As Integer = 0 To dgvStocks.RowCount - 1
            If i Mod 2 = 0 Then
                dgvStocks.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.White
            Else
                dgvStocks.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.LightGray
            End If
        Next
    End Sub
    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OMSys_StocksDBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_StocksDB)
        dgv_styleRow()

        date_added.Enabled = False
        txt_StockName.Enabled = False
        txt_Stock.Enabled = False
        txt_Color.Enabled = False
        txt_OriginalPrice.Enabled = False
        txt_SellingPrice.Enabled = False
        cmb_Size.Enabled = False
    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        date_added.Checked = False
        OMSysStocksDBBindingSource.AddNew()
        cmb_Size.SelectedIndex = 0
        dgv_styleRow()
        date_added.Enabled = True
        txt_StockName.Enabled = True
        txt_Stock.Enabled = True
        txt_Color.Enabled = True
        txt_OriginalPrice.Enabled = True
        txt_SellingPrice.Enabled = True
        cmb_Size.Enabled = True
    End Sub
    Private Sub btnDeleteOrder_Click_1(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this stock?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            Try
                OMSysStocksDBBindingSource.RemoveCurrent()
                OMSysStocksDBBindingSource.EndEdit()
                OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
                dgv_styleRow()
            Catch ex As Exception

            End Try

        End If
        OMSysStocksDBBindingSource.MoveLast()
    End Sub

    Private Sub btnUpdateOrder_Click_1(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        If txt_StockName.Text = "" Or txt_Stock.Text = "" Or txt_SellingPrice.Text = "" Or txt_OriginalPrice.Text = "" Then
            MessageBox.Show("Please fill the required field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                OMSysStocksDBBindingSource.EndEdit()
                OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
                MessageBox.Show("Stock saved!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv_styleRow()

                date_added.Enabled = False
                txt_StockName.Enabled = False
                txt_Stock.Enabled = False
                txt_Color.Enabled = False
                txt_OriginalPrice.Enabled = False
                txt_SellingPrice.Enabled = False
                cmb_Size.Enabled = False
            Catch ex As Exception
                'MessageBox.Show("Database error, the application will restart to save the changes.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Application.Restart()
                ' Puwede yung code above pero pwede rin to, ikaw mamili kung ano mas maganda pag nag e-error
                Me.Refresh()
            End Try
        End If

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call doNothing()
            Exit Sub
        Else
            OMSysStocksDBBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSearch.Text & "')" &
                "OR (Material_Name LIKE '" & txtSearch.Text & "')" & "OR (Size LIKE '" & txtSearch.Text & "')" &
                "OR (Color LIKE '" & txtSearch.Text & "')"

            If OMSysStocksDBBindingSource.Count <> 0 Then
                With dgvStocks
                    .DataSource = OMSysStocksDBBindingSource
                End With
                dgv_styleRow()
            Else
                MessageBox.Show("Nothing found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'OMSys_OrdersV2DBBindingSource = Nothing
                Call displayAll()
            End If
        End If
    End Sub
    Private Sub doNothing()

    End Sub
    Private Sub displayAll()
        txtSearch.Text = ""

        Me.OMSys_StocksDBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_StocksDB)
        Me.OMSysStocksDBBindingSource.RemoveFilter()
        dgv_styleRow()
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Call displayAll()
    End Sub

    Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvStocks.DataSourceChanged
        dgv_styleRow()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStocks.CellClick
        date_added.Enabled = True
        txt_StockName.Enabled = True
        txt_Stock.Enabled = True
        txt_Color.Enabled = True
        txt_OriginalPrice.Enabled = True
        txt_SellingPrice.Enabled = True
        cmb_Size.Enabled = True
    End Sub
    Private Sub frmMainScreen2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub

    Private Sub txt_Stock_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Stock.KeyDown
        If Char.IsDigit(Chr(e.KeyValue)) Or e.KeyData = Keys.Delete Or e.KeyData = Keys.Left Or
            e.KeyData = Keys.Right Or e.KeyData = Keys.Back Then
            e.SuppressKeyPress = False
        Else
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_SellingPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SellingPrice.KeyDown
        If Char.IsDigit(Chr(e.KeyValue)) Or e.KeyData = Keys.Delete Or e.KeyData = Keys.Left Or
            e.KeyData = Keys.Right Or e.KeyData = Keys.Back Then
            e.SuppressKeyPress = False
        Else
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_OriginalPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_OriginalPrice.KeyDown
        If Char.IsDigit(Chr(e.KeyValue)) Or e.KeyData = Keys.Delete Or e.KeyData = Keys.Left Or
            e.KeyData = Keys.Right Or e.KeyData = Keys.Back Then
            e.SuppressKeyPress = False
        Else
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dgvStocks_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvStocks.CellFormatting
        For Each row As DataGridViewRow In dgvStocks.Rows
            If Convert.ToString(row.Cells(3).Value) = "" Then
                dgv_styleRow()
            ElseIf Convert.ToString(row.Cells(3).Value) <= 10 Then
                row.Cells(3).Style.BackColor = Drawing.Color.Red
            Else
                row.Cells(3).Style.BackColor = Drawing.Color.LightGreen
                dgv_styleRow()
            End If
        Next
    End Sub
End Class