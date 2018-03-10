Public Class frmROP

    Private Sub frmROP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connected()
        sql = " SELECT * FROM tblProduct WHERE pqty <= prop"
        LoadProduct(lvProd)
    End Sub
End Class