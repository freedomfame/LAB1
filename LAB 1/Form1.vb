Public Class frmMyFirstFrom

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblSalary.Text = Val(txtSalary.Text) * 12
        lblTax.Text = Val(lblSalary.Text) * 5 / 100
        lblTotal.Text = Val(lblSalary.Text) - Val(lblTax.Text)
    End Sub
End Class
