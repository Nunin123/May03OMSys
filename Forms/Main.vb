Public Class frmMain
    Private Sub btnManageOrder_Click(sender As Object, e As EventArgs) Handles btnManageOrder.Click
        Dim ManageOrder As New frmMainScreen
        ManageOrder.Show()
        Close()
    End Sub

    Private Sub btnManageStock_Click(sender As Object, e As EventArgs) Handles btnManageStock.Click
        Dim ManageStocks As New frmMainScreen2
        ManageStocks.Show()

        For Each row As DataGridViewRow In ManageStocks.dgvStocks.Rows
            If row.Cells(3).Style.BackColor = Drawing.Color.Red Then
                MessageBox.Show("Some stocks are running out. It's time to replenish!", "Availability of Stocks", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Next
        Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim LoginForm As New frmLogin

        Dim choice As DialogResult = MessageBox.Show("Are you sure want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If choice = DialogResult.Yes Then
            LoginForm.Show()
            Close()
        End If
    End Sub
End Class