Public Class frmLab2

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        Dim dblSumsale As Double
        Dim dblComAcer As Double
        Dim dblComHP As Double
        Dim dblSumCommision As Double
        Dim dblSaleAcer As Double
        Dim dblSaleHP As Double

        dblSaleAcer = Val(txtAcer.Text)
        dblSaleHP = Val(txtHP.Text)
        dblSumsale = dblSaleAcer + dblSaleHP
        dblComAcer = Val(txtAcer.Text) * 0.05
        dblComHP = Val(txtHP.Text) * 0.1
        dblSumCommision = dblComAcer + dblComHP

        lblSumsale.Text = dblSumsale
        lblComAcer.Text = dblComAcer
        lblComHP.Text = dblComHP
        lblSumCommision.Text = dblSumCommision
    End Sub
End Class