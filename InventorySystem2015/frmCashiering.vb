Public Class frmCashiering
    Dim pcode, pname, pcategory, psupplier As String
    Dim qty, pqty, qtyorder, enterqty, puprice, peoq, prop, pannual, pucost As Integer
    Dim subtotal, total As Double
    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        If tbsearch.Text = "" Then
            PopulateProduct(lvProd)
            Exit Sub
        End If
        SearchProduct(lvProd, tbsearch)
    End Sub

    Private Sub frmCashiering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateProduct(lvProd)
        GenerateORno(tbor)
    End Sub
 
    Private Sub lvProd_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvProd.MouseDoubleClick
        Try
            'initialization
            With lvProd.SelectedItems(0)
                pcode = .SubItems(0).Text
                pname = .SubItems(1).Text
                pcategory = .SubItems(2).Text
                psupplier = .SubItems(3).Text
                pucost = .SubItems(4).Text
                puprice = .SubItems(5).Text
                pqty = .SubItems(6).Text
                prop = .SubItems(7).Text
                peoq = .SubItems(8).Text
                pannual = .SubItems(9).Text
            End With
            'enter qty order
            enterqty = InputBox(pcode & vbNewLine & pname, "Enter Quantity".ToUpper)
            'item qty ordered  > item qty stock 
            If enterqty > pqty Then
                MsgBox("There is no enough number of Item!", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            'subtract qty stock to qty ordered
            qty = pqty - enterqty
            'update qty stock
            UpdateQty(qty)
            '
            PopulateProduct(lvProd)
            'compute total/subtotal
            subtotal = enterqty * puprice
            'add to lvPurchase
            With lvPurchase.Items.Add(pcode)
                .SubItems.Add(pname)
                .SubItems.Add(puprice)
                .SubItems.Add(enterqty)
                .SubItems.Add(subtotal)
                .SubItems.Add(qty)
            End With
            'compute no of item purchased
            tbtotal.Text = ComputeCollumn(4)
            tbnoitem.Text = ComputeCollumn(3)
        Catch
        End Try
    End Sub

    Private Sub lvPurchase_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvPurchase.MouseDoubleClick
        'intitialize
        With lvPurchase.SelectedItems(0)
            pcode = .SubItems(0).Text
            qtyorder = .SubItems(3).Text
            qty = .SubItems(5).Text
        End With
        'add qty ordered to qty stock
        pqty = qtyorder + qty
        'update qty in products
        UpdateQty(pqty)
        'refresh list
        PopulateProduct(lvProd)
        'remove selected items
        lvPurchase.Items.RemoveAt(lvPurchase.SelectedIndices(0))
        'compute total
        tbtotal.Text = ComputeCollumn(4)
        'compute noOfItem
        tbnoitem.Text = ComputeCollumn(3)
    End Sub


    Private Sub tbcash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbcash.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbcash.ForeColor = Color.Red Then
                MsgBox("Insufficient!", MsgBoxStyle.Critical)
                tbcash.ForeColor = Color.Red
                Exit Sub
            End If
            e.SuppressKeyPress = True
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
                        sql = "INSERT into tblsales (sorno,scode,sname,cname,suprice,sqty,stotal,scash,schange,sdate) VALUES ('" & tbor.Text & "','" & .subitems(0).Text.ToUpper & "','" & .subitems(1).Text.ToUpper & "','" & tbwalkin.Text.ToUpper & "'," & .subitems(2).Text.ToUpper & "," & .subitems(3).Text & "," & .subitems(4).Text & "," & tbcash.Text & "," & tbchange.Text & ",'" & odate & "')"
                        CommandDB()
                        cmd.ExecuteNonQuery()
                    End With
                    iloop = iloop + 1
                    lv = Nothing
                Loop
                MsgBox("Successfully Purchased!")
                ResetTransaction()
            End If
        End If
    End Sub

    Private Sub tbcash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcash.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbcash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcash.TextChanged
        Dim x As Integer = 0
        If lvPurchase.Items.Count = 0 Then
            tbcash.ForeColor = Color.Black
            Exit Sub
        End If
        x = Val(tbcash.Text) - Val(tbtotal.Text)
        If x >= 0 Then
            tbcash.ForeColor = Color.Green
            tbchange.Text = x
        Else
            tbcash.ForeColor = Color.Red
            tbchange.Text = "0"
            Exit Sub
        End If
    End Sub

    Public Sub UpdateQty(ByVal qty As Integer)
        connected()
        sql = "UPDATE tblproduct SET pqty = " & qty & " WHERE pcode = '" & pcode & "'"
        CommandDB()
        cmd.ExecuteNonQuery()
    End Sub

    Function ComputeCollumn(ByVal col As Integer) As Integer
        Dim sum = (From lvi In lvPurchase.Items _
        Let value = CInt(DirectCast(lvi, ListViewItem).SubItems(col).Text) _
        Select value).Sum
        Return sum
    End Function


    Public Sub ResetTransaction()
        GenerateORno(tbor)
        tbtotal.Text = 0
        tbchange.Text = 0
        tbcash.Text = ""
        tbcash.ForeColor = Color.Red
        tbnoitem.Text = 0
        lvPurchase.Items.Clear()
    End Sub
End Class