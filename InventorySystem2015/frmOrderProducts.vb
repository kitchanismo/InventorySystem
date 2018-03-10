Public Class frmOrderProducts

    Private Sub frmOrderProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connected()
        sql = " SELECT * FROM tblpendingproduct"
        LoadPendingProductwithPOno(lvProd)
    End Sub
End Class