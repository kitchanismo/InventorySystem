Public Class frmProdMaint

    Private Sub frmProdMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateProduct(lvProd)
        ClearFields()
        EnableFields(False)
        PopulateCBOSupplier(cboSupplier)
        PopulateCBOCategory(cbocategory)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ClearFields()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        AddProduct()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        UpdateProduct()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DeleteProduct()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        PopulateProduct(lvProd)
        PopulateCBOSupplier(cboSupplier)
    End Sub
    Private Sub lvProd_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvProd.MouseClick
        With lvProd.SelectedItems(0)
            tbcode.Text = .SubItems(0).Text
            tbname.Text = .SubItems(1).Text
            cbocategory.Text = .SubItems(2).Text
            cboSupplier.Text = .SubItems(3).Text
            tbucost.Text = .SubItems(4).Text
            tbuprice.Text = .SubItems(5).Text
            tbqty.Text = .SubItems(6).Text
            tbrop.Text = .SubItems(7).Text
            tbeoq.Text = .SubItems(8).Text
            tbannual.Text = .SubItems(9).Text
        End With
        EnableFields(True)
       
        LT = GetLeadTime(cboSupplier.Text)
        tblt.Text = LT
    End Sub

    Public Sub AddProduct()
        If btnadd.Text.ToLower = "add" Then
            btnadd.Text = "Save"
            btnupdate.Text = "Cancel"
            btndelete.Visible = False
            btnclear.Visible = False
            btnrefresh.Visible = False
            EnableFields(True)
            ClearFields()
            GenerateProdCode(tbcode)
        Else
            'validation
            If tbname.Text = "" Or cbocategory.Text = "" Or cboSupplier.Text = "" Or tbucost.Text.ToLower = "" Or tbuprice.Text.ToLower = "" Or tbqty.Text.ToLower = "" Or tbucost.Text = "" Or tbrop.Text = "" Or tbeoq.Text = "" Or tbannual.Text = "" Then
                MsgBox("fill-up all the fields!", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf DoesExist(tbname.Text.ToLower, "tblProduct", "pname") Then
                MsgBox("Product Name " & tbname.Text.ToUpper & " Exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            'execute add query
            connected()
            sql = "INSERT INTO tblProduct (pcode, pname, pcategory, psupplier, pucost, puprice, pqty, prop, peoq, pannual) VALUES ('" & tbcode.Text.ToUpper & "','" & tbname.Text.ToUpper & "','" & cbocategory.Text.ToUpper & "','" & cboSupplier.Text.ToUpper & "'," & tbucost.Text & "," & tbuprice.Text & "," & tbqty.Text & "," & tbrop.Text & "," & tbeoq.Text & "," & tbannual.Text & ")"
            CommandDB()
            dr = cmd.ExecuteReader()
            MsgBox("added!", MsgBoxStyle.Information)
            PopulateProduct(lvProd)
            ClearFields()
            GenerateProdCode(tbcode)
        End If
    End Sub
    Public Sub UpdateProduct()
        If btnupdate.Text.ToLower = "cancel" Then
            btnadd.Text = "Add"
            btnupdate.Text = "Update"
            btndelete.Visible = True
            btnclear.Visible = True
            btnrefresh.Visible = True
            ClearFields()
            EnableFields(False)
        Else
            'validation
            If tbcode.Text = "0" Then
                MsgBox("Select From List!", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf tbname.Text = "" Or cbocategory.Text = "" Or cboSupplier.Text = "" Or tbucost.Text.ToLower = "" Or tbuprice.Text.ToLower = "" Or tbqty.Text.ToLower = "" Or tbucost.Text = "" Or tbrop.Text = "" Or tbeoq.Text = "" Or tbannual.Text = "" Then
                MsgBox("fill-up all the fields!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            'execute update query
            connected()
            sql = "UPDATE tblProduct SET pname = '" & tbname.Text.ToUpper & "', pcategory = '" & cbocategory.Text.ToUpper & "', psupplier = '" & cboSupplier.Text.ToUpper & "', pucost = " & tbucost.Text & ", puprice = " & tbuprice.Text & ", prop = " & tbrop.Text & ", peoq = " & tbeoq.Text & ", pannual = " & tbannual.Text & ", pqty = " & tbqty.Text & " WHERE pcode = '" & tbcode.Text & "'"
            CommandDB()
            cmd.ExecuteNonQuery()
            MsgBox("Updated!", MsgBoxStyle.Information)
            PopulateProduct(lvProd)
            ClearFields()
        End If
    End Sub
    Public Sub DeleteProduct()
        connected()
        Dim i As Integer
        sql = "DELETE FROM tblProduct WHERE pcode = '" & tbcode.Text & "'"
        'validattion
        If tbcode.Text = "0" Then
            MsgBox("Select from user list!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        CommandDB()
        i = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            'execute delete query
            cmd.ExecuteNonQuery()
            MsgBox("deleted!", MsgBoxStyle.Information)
            PopulateProduct(lvProd)
            ClearFields()
        End If
    End Sub

    Public Sub ClearFields()
        tbcode.Text = 0
        tbname.Text = ""
        cbocategory.Text = ""
        cboSupplier.Text = "Select ..."
        tbqty.Text = ""
        tbucost.Text = ""
        tbuprice.Text = ""
        tbrop.Text = ""
        tbeoq.Text = ""
        tbannual.Text = ""
        tblt.Text = ""
    End Sub

    Public Sub EnableFields(ByVal x As Boolean)
        gbproduct.Enabled = x
        gbother.Enabled = x
    End Sub

    Private Sub tbqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbqty.KeyPress, tbucost.KeyPress, tbuprice.KeyPress, tbrop.KeyPress, tbeoq.KeyPress, tbannual.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboSupplier_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cboSupplier.MouseClick
        PopulateCBOSupplier(cboSupplier)
    End Sub

   
    Private Sub cboSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSupplier.SelectedIndexChanged
        LT = GetLeadTime(cboSupplier.Text)
        tblt.Text = LT
    End Sub

    Private Sub tbannual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbannual.TextChanged
        Dim eoq, rop As Integer
        Try
            eoq = FormatNumber((Val(tbucost.Text) * 2 * Val(tbannual.Text)) / Val(tbuprice.Text)) ^ (1 / 2)
            rop = FormatNumber(Val(eoq) / Val(LT))
        Catch
        End Try
        tbeoq.Text = eoq
        tbrop.Text = rop
    End Sub

    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        SearchProduct(lvProd, tbsearch)
    End Sub


    Private Sub btnaddsupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddsupplier.Click
        frmSupplierMaint.Show()
    End Sub

End Class