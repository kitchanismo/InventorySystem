Public Class frmPurchaseOrder
    Dim pcode, pname, pcategory, psupplier As String
    Dim enterqty, puprice, peoq, prop, pannual, pucost As Integer
    Dim subtotal As Double
    Private Sub frmPurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateCBOSupplierROP(cboSupplier)
    End Sub

    Private Sub cboSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSupplier.SelectedIndexChanged
        PopulateROP(lvProd, cboSupplier)
        GeneratePOno(tbpo)
        cboSupplier.Enabled = False
    End Sub

    Private Sub lvProd_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvProd.MouseDoubleClick

        Try
            If cboSupplier.Text = "Select ..." Then
                Exit Sub
            End If
            'initialization
            With lvProd.SelectedItems(0)
                pcode = .SubItems(0).Text
                pname = .SubItems(1).Text
                pcategory = .SubItems(2).Text
                psupplier = .SubItems(3).Text
                pucost = .SubItems(4).Text
                puprice = .SubItems(5).Text
                enterqty = .SubItems(6).Text
                prop = .SubItems(7).Text
                peoq = .SubItems(8).Text
                pannual = .SubItems(9).Text
            End With
            'enter qty / compute subtotal and total
            enterqty = InputBox(pcode & vbNewLine & pname, "Enter Quantity".ToUpper, peoq)
            subtotal += (enterqty * pucost)
            tbtotal.Text = subtotal
            tbsubtotal.Text = enterqty * pucost
            'add to lvPurchase
            With lvPurchase.Items.Add(pcode)
                .SubItems.Add(pname)
                .SubItems.Add("none")
                .SubItems.Add("none")
                .SubItems.Add(pucost)
                .SubItems.Add(enterqty)
                .SubItems.Add(tbsubtotal.Text)
            End With
            'remove product in lvprod
            lvProd.Items.RemoveAt(lvProd.SelectedIndices(0))
        Catch
        End Try
    End Sub
    

    Private Sub btnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click
        Dim remarks As String = "PENDING"
        Dim odate As Date = frmMain.lbldate.Text
        Dim lv
        Dim ctr As Integer
        Dim iloop As Integer
        ctr = lvPurchase.Items.Count()
        If Not lvPurchase.Items.Count = 0 Then
            Do Until iloop = lvPurchase.Items.Count
                lv = lvPurchase.Items.Item(iloop)
                With lv
                    connected()
                    sql = "INSERT into tblPendingProduct (pono,pcode ,pname, psupplier ,pucost,pqty,psubtotal,podate,premarks) VALUES ('" & tbpo.Text.ToUpper & "','" & .subitems(0).Text.ToUpper & "','" & .subitems(1).Text.ToUpper & "','" & cboSupplier.Text.ToUpper & "'," & .subitems(4).Text & "," & .SubItems(5).Text & "," & .SubItems(6).Text & ",'" & odate & "','" & remarks & "')"
                    CommandDB()
                    cmd.ExecuteNonQuery()
                End With
                iloop = iloop + 1
                lv = Nothing
            Loop
            MsgBox("Successfully Purchased!")
            cboSupplier.Items.Remove(cboSupplier.SelectedItem)
            Dim i As Integer = MsgBox("Do you want to create another PO?", MsgBoxStyle.YesNo)
            If i = MsgBoxResult.Yes Then
                ResetTransaction()
            Else
                Me.Close()
            End If
        End If

    End Sub



    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        ResetTransaction()
    End Sub

    Public Sub ResetTransaction()
        lvPurchase.Items.Clear()
        lvProd.Items.Clear()
        tbpo.Text = ""
        tbtotal.Text = ""
        tbsubtotal.Text = ""
        subtotal = 0
        cboSupplier.Text = "Select ..."
        cboSupplier.Enabled = True
    End Sub

    Private Sub lvProd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvProd.SelectedIndexChanged

    End Sub
End Class