Public Class frmSupplierMaint

    Private Sub frmSupplierMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateSupplier(lvSupplier)
        EnableFields(False)
    End Sub


   
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        AddSupplier()
    End Sub


    Public Sub EnableFields(ByVal x As Boolean)
        gbSupplier.Enabled = x
    End Sub
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        UpdateSupplier()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DeleteSupplier()
    End Sub

    Private Sub tblt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tblt.KeyPress, tbcontact.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        PopulateSupplier(lvSupplier)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ClearFields()
    End Sub

    Private Sub lvSupplier_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvSupplier.MouseClick
        With lvSupplier.SelectedItems(0)
            tbid.Text = .SubItems(0).Text
            tbname.Text = .SubItems(1).Text
            tbaddress.Text = .SubItems(2).Text
            tbcontact.Text = .SubItems(3).Text
            tblt.Text = .SubItems(4).Text
        End With
        EnableFields(True)
    End Sub


    Public Sub AddSupplier()
        If btnadd.Text.ToLower = "add" Then
            btnadd.Text = "Save"
            btnupdate.Text = "Cancel"
            btndelete.Visible = False
            btnclear.Visible = False
            btnrefresh.Visible = False
            EnableFields(True)
            ClearFields()
        Else
            'validation
            If tbname.Text = "" Or tbaddress.Text = "" Or tbcontact.Text = "" Or tblt.Text.ToLower = "" Then
                MsgBox("fill-up all the fields!", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf DoesExist(tbname.Text.ToLower, "tblSupplier", "sname") Then
                MsgBox("Supplier Name " & tbname.Text.ToUpper & " Exist!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            'execute add query
            connected()
            sql = "INSERT INTO tblSupplier (sname, saddress, scontact, slt) VALUES ('" & tbname.Text.ToUpper & "','" & tbaddress.Text.ToUpper & "','" & tbcontact.Text.ToUpper & "'," & tblt.Text.ToUpper & ")"
            CommandDB()
            dr = cmd.ExecuteReader()
            MsgBox("added!", MsgBoxStyle.Information)
            PopulateSupplier(lvSupplier)
            ClearFields()
        End If
    End Sub

    Public Sub UpdateSupplier()
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
            If tbid.Text = "0" Then
                MsgBox("Select From List!", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf tbname.Text = "" Or tbaddress.Text = "" Or tbcontact.Text = "" Or tblt.Text.ToLower = "" Then
                MsgBox("fill-up all the fields!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            'execute update query
            connected()
            sql = "UPDATE tblSupplier SET sname = '" & tbname.Text.ToUpper & "', saddress = '" & tbaddress.Text.ToUpper & "', scontact = '" & tbcontact.Text.ToUpper & "', slt = " & tblt.Text & "  where sid = " & tbid.Text & ""
            CommandDB()
            cmd.ExecuteNonQuery()
            MsgBox("Updated!", MsgBoxStyle.Information)
            PopulateSupplier(lvSupplier)
            ClearFields()
        End If
    End Sub

    Public Sub DeleteSupplier()
        connected()
        Dim i As Integer
        sql = "DELETE FROM tblSupplier WHERE sid = " & tbid.Text & ""
        'validattion
        If tbid.Text = "0" Then
            MsgBox("Select from user list!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        CommandDB()
        i = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            'execute delete query
            cmd.ExecuteNonQuery()
            MsgBox("deleted!", MsgBoxStyle.Information)
            PopulateSupplier(lvSupplier)
            ClearFields()
        End If
    End Sub

    Public Sub ClearFields()
        tbid.Text = 0
        tbname.Text = ""
        tbaddress.Text = ""
        tbcontact.Text = ""
        tblt.Text = ""
    End Sub

End Class