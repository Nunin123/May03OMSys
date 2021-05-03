Public Class AddedFeature
    Private Sub AddedFeature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysOrdersDBDataSet.OMSys_StocksDB' table. You can move, or remove it, as needed.
        Me.OMSys_StocksDBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_StocksDB)
        dgv_styleRow()
    End Sub

    Sub dgv_styleRow()
        For i As Integer = 0 To dgvCheckStocks.RowCount - 1
            If i Mod 2 = 0 Then
                dgvCheckStocks.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.White
            Else
                dgvCheckStocks.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.LightGray
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            OMSysStocksDBBindingSource.EndEdit()
            OMSys_StocksDBTableAdapter.Update(OMSysOrdersDBDataSet)
            MessageBox.Show("Stock saved!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Me.Refresh()
        End Try
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCheckStocks.CellFormatting
        For Each row As DataGridViewRow In dgvCheckStocks.Rows
            If Convert.ToString(row.Cells(4).Value) <= 10 Then
                row.Cells(4).Style.BackColor = Drawing.Color.Red
            Else
                row.Cells(4).Style.BackColor = Drawing.Color.LightGreen
                dgv_styleRow()
            End If
        Next
    End Sub
End Class