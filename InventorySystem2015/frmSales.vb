Public Class frmSales


    Function ComputeCollumn(ByVal col As Integer) As Integer
        Dim sum = (From lvi In lvSales.Items _
        Let value = CInt(DirectCast(lvi, ListViewItem).SubItems(col).Text) _
        Select value).Sum
        Return sum
    End Function

    Private Sub dtto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtto.ValueChanged, dtfrom.ValueChanged
        PopulateSales(lvSales, dtfrom.Text, dtto.Text)
        tbtotal.Text = FormatNumber(ComputeCollumn(6))
    End Sub


    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class