Public Class frmUserMaintenance

    Private Sub frmUserMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateUser(lvUser)
        EnableFields(False)
    End Sub

#Region "Methods"
  
    Public Sub AddUser()
        If btnadd.Text.ToLower = "add" Then
            btnadd.Text = "save"
            btnupdate.Text = "cancel"
            btndelete.Visible = False
            btnrefresh.Visible = False
            tbnpass.Visible = False
            lblnpass.Visible = False
            EnableFields(True)
            ClearFields()
            tbuname.Focus()
        Else
            'validation
            If tbuname.Text = "" Or tbpass.Text = "" Or tbcpass.Text.ToLower = "" Or cboposition.Text.ToLower = "" Then
                MsgBox("fill-up all the fields!", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf DoesExist(tbuname.Text.ToLower, "tblUser", "uname") Then
                MsgBox("username " & tbuname.Text.ToUpper & " exist!", MsgBoxStyle.Exclamation)
                tbuname.Focus()
                tbuname.SelectAll()
                Exit Sub
            ElseIf tbpass.Text.ToLower <> tbcpass.Text.ToLower Then
                MsgBox("password not match!", MsgBoxStyle.Exclamation)
                tbcpass.Focus()
                tbcpass.SelectAll()
                Exit Sub
            End If
            connected()
            sql = "INSERT INTO tblUser (uname, upword, uposition) VALUES ('" & tbuname.Text & "','" & tbpass.Text.ToLower & "','" & cboposition.Text.ToLower & "')"
            CommandDB()
            dr = cmd.ExecuteReader()
            MsgBox("added!", MsgBoxStyle.Information)
            PopulateUser(lvUser)
            ClearFields()
        End If
    End Sub

    Public Sub UpdateUser()
        If btnupdate.Text.ToLower = "cancel" Then
            btnadd.Text = "add"
            btnupdate.Text = "update"
            btndelete.Visible = True
            btnrefresh.Visible = True
            ClearFields()
            EnableFields(False)
        Else
            'validation
            If tbuname.Text.ToLower = "" Or tbpass.Text.ToLower = "" Or tbcpass.Text.ToLower = "" Or tbnpass.Text.ToLower = "" Or cboposition.Text.ToLower = "" Then
                MsgBox("fill-up all the fields!", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf tbpass.Text.ToLower <> tbcpass.Text.ToLower Then
                MsgBox("password not match!", MsgBoxStyle.Exclamation)
                tbcpass.Focus()
                tbcpass.SelectAll()
                Exit Sub
            End If
            'execute update query
            connected()
            sql = "UPDATE tblUser SET uname = '" & tbuname.Text.ToLower & "', upword = '" & tbnpass.Text.ToLower & "', uposition = '" & cboposition.Text.ToLower & "'" & _
                " WHERE uid = " & lblid.Text & ""
            CommandDB()
            cmd.ExecuteNonQuery()
            MsgBox("updated!", MsgBoxStyle.Information)
            PopulateUser(lvUser)
            ClearFields()
        End If
    End Sub

    Public Sub DeleteUser()
        connected()
        Dim i As Integer
        sql = "DELETE FROM tblUser WHERE uid = " & lblid.Text & ""
        'validattion
        If lblid.Text = "0" Then
            MsgBox("select from user list!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        CommandDB()
        i = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            'execute delete query
            cmd.ExecuteNonQuery()
            MsgBox("deleted!", MsgBoxStyle.Information)
            PopulateUser(lvUser)
            ClearFields()
        End If
    End Sub

    Public Sub ClearFields()
        lblid.Text = "0"
        tbpass.Text = ""
        tbuname.Text = ""
        tbcpass.Text = ""
        tbnpass.Text = ""
        cboposition.Text = ""
    End Sub

    Public Sub EnableFields(ByVal x As Boolean)
        Gbuser.Enabled = x
    End Sub
#End Region

#Region "MouseClick"
    Private Sub lvUser_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvUser.MouseClick
        With lvUser.SelectedItems(0)
            lblid.Text = .SubItems(0).Text
            tbuname.Text = .SubItems(1).Text
            cboposition.Text = .SubItems(2).Text
            tbpass.Text = .SubItems(3).Text
        End With
        EnableFields(True)
        tbpass.Enabled = False
        tbnpass.Visible = True
        lblnpass.Visible = True
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        AddUser()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        UpdateUser()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        DeleteUser()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        PopulateUser(lvUser)
        ClearFields()
    End Sub
#End Region

End Class