Public Class frmReceiveOrder
    Dim pono, pcode, pname, odate, psupplier, remarks As String
    Dim backorderqty, excessqty, receiveqty, enterqty, qtyorder, puprice, peoq, prop, pannual, pucost As Integer
    Dim subtotal As Double
    Private Sub frmReceiveOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulatePO(cbopo)
    End Sub


   
    Private Sub cbopo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopo.SelectedIndexChanged
        PopulatePendingProduct(lvPending, cbopo.Text)
        cbopo.Enabled = False
    End Sub

    Private Sub lvPending_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvPending.MouseDoubleClick
        Try
            If cbopo.Text = "Select ..." Then
                Exit Sub
            End If
            'initialization
            With lvPending.SelectedItems(0)
                pcode = .SubItems(0).Text
                pname = .SubItems(1).Text
                psupplier = .SubItems(2).Text
                pucost = .SubItems(3).Text
                qtyorder = .SubItems(4).Text
                subtotal = .SubItems(5).Text
                odate = .SubItems(6).Text
            End With
            'enter qty
            enterqty = InputBox(pcode & vbNewLine & pname, "Enter Quantity Receive".ToUpper, qtyorder)
            subtotal = enterqty * pucost
            'if received items are back order / excess / OK
            If enterqty < qtyorder Then
                backorderqty = qtyorder - enterqty
                receiveqty = enterqty
                remarks = "With Back-Order of! " & backorderqty & " Items "
                MsgBox(remarks)
                UpdateProduct(receiveqty + GetProductQTy(pcode))
                UpdatePO(backorderqty, "pending", cbopo.Text)
            ElseIf enterqty > qtyorder Then
                excessqty = enterqty - qtyorder
                receiveqty = enterqty
                remarks = "Excess of " & excessqty & " Items"
                MsgBox(remarks)
                UpdateProduct(receiveqty + GetProductQTy(pcode))
                UpdatePO(receiveqty, remarks, cbopo.Text)
             ElseIf enterqty = qtyorder Then
                remarks = "OK"
                receiveqty = enterqty
                UpdateProduct(receiveqty + GetProductQTy(pcode))
                UpdatePO(0, "OK", cbopo.Text)
            End If
            '
            PopulatePendingProduct(lvPending, cbopo.Text)
            'add to lvReceived
            With lvreceive.Items.Add(pcode)
                .SubItems.Add(pname)
                .SubItems.Add(psupplier)
                .SubItems.Add(pucost)
                .SubItems.Add(receiveqty)
                .SubItems.Add(subtotal)
                .SubItems.Add(remarks)
            End With
        Catch i As Exception
            'MsgBox(i.ToString)
        End Try
    End Sub

    Public Sub UpdatePO(ByVal i As Integer, ByVal remarks As String, ByVal po As String)
        connected()
        sql = "UPDATE tblpendingProduct SET pqty = " & i & ", premarks = '" & remarks & "' WHERE pcode = '" & pcode & "' and pono = '" & po & "' and premarks = 'pending'"
        CommandDB()
        cmd.ExecuteNonQuery()
        LoadPendingProduct(lvPending)
    End Sub

    Public Sub UpdateProduct(ByVal i As Integer)
        connected()
        sql = "UPDATE tblProduct SET pqty = " & i & " WHERE pcode = '" & pcode & "'"
        CommandDB()
        cmd.ExecuteNonQuery()
    End Sub

    Function GetProductQTy(ByVal pcode As String) As Integer
        connected()
        Dim i As Integer
        sql = "SELECT * from tblproduct where pcode ='" & pcode & "'"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(6).ToString
            Loop
        End If
        Return i
    End Function

    Private Sub btnreceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreceive.Click
        Dim odate As Date = frmMain.lbldate.Text
        Dim lv
        Dim ctr As Integer
        Dim iloop As Integer
        If tbsi.Text = "" Then
            MsgBox("Enter Sales Invoice!")
            tbsi.SelectAll()
            tbsi.Focus()
            Exit Sub
        End If
        ctr = lvreceive.Items.Count()
        If Not lvreceive.Items.Count = 0 Then
            Do Until iloop = lvreceive.Items.Count
                lv = lvreceive.Items.Item(iloop)
                With lv
                    connected()
                    sql = "INSERT into tblreceiveproduct (rsino,rpono,rcode,rname,rsupplier,rucost,rqty,rsubtotal,rremarks,rdate) VALUES ('" & tbsi.Text & "','" & cbopo.Text & "','" & .subitems(0).Text.ToUpper & "','" & .subitems(1).Text.ToUpper & "','" & .subitems(2).Text.ToUpper & "'," & .subitems(3).Text.ToUpper & "," & .subitems(4).Text & "," & .subItems(5).Text & ",'" & .subItems(6).Text & "','" & odate & "')"
                    CommandDB()
                    cmd.ExecuteNonQuery()
                End With
                iloop = iloop + 1
                lv = Nothing
            Loop
            MsgBox("Successfully Received!")
            lvreceive.Items.Clear()
            tbsi.Text = ""
            cbopo.Enabled = True
            cbopo.Text = "Select ..."
            cbopo.Items.Remove(cbopo.SelectedItem)
        End If

    End Sub



    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        tbsi.Text = ""
        cbopo.Enabled = True
        cbopo.Text = "Select ..."
        cbopo.Items.Remove(cbopo.SelectedItem)
    End Sub
End Class