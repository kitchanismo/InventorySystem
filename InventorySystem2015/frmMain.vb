Public Class frmMain

    Private Sub ProductMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductMaintenanceToolStripMenuItem.Click
        frmProdMaint.Show()
        ' frmProdMaint.TopMost = True
    End Sub

    Private Sub SupplierMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierMaintenanceToolStripMenuItem.Click
        frmSupplierMaint.Show()
        'frmSupplierMaint.TopMost = True
    End Sub

    Private Sub PurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
        frmPurchaseOrder.Show()
        'frmPurchaseOrder.TopMost = True
    End Sub

    Private Sub TimerDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDate.Tick
        lbldate.Text = Format(Now, "long date")
        Label3.Text = TimeOfDay
    End Sub

    Private Sub ReceiveOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveOrderToolStripMenuItem.Click
        frmReceiveOrder.Show()
    End Sub

    Private Sub CashieringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashieringToolStripMenuItem.Click
        frmCashiering.Show()
    End Sub

    Private Sub UserMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserMaintenanceToolStripMenuItem.Click
        frmUserMaintenance.Show()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        connected()
        sql = "SELECT * FROM tblUser WHERE uname = '" & tbuname.Text.ToUpper & "' AND upword = '" & tbpword.Text.ToUpper & "' "
        CommandDB()
        dr = cmd.ExecuteReader()
        'validation
        If tbuname.Text = "" Or tbpword.Text = "" Then
            MessageBox.Show("Please Fill-Up All The Fields!")
            Exit Sub
        End If
        'condition
        If (dr.Read() = True) Then
            'access
            MsgBox("ACCESS GRANTED!", MsgBoxStyle.Information)
            pnloginform.Visible = False
            tbpword.Text = ""
            Menu.Enabled = True
            Label2.Text = tbuname.Text
        Else
            'denied
            MsgBox("ACCESS DENIED!" & _
            vbCrLf & "Invalid Username/Password!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim i As Integer
        i = MsgBox("Logout?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            Menu.Enabled = False
            frmCashiering.Close()
            frmProdMaint.Close()
            frmPurchaseOrder.Close()
            frmReceiveOrder.Close()
            frmSupplierMaint.Close()
            frmUserMaintenance.Close()
            pnloginform.Visible = True
        End If
    End Sub

    Private Sub ROPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROPToolStripMenuItem.Click
        frmROP.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        frmProducts.Show()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderToolStripMenuItem.Click
        frmOrderProducts.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        frmSales.Show()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
