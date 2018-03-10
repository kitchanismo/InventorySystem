Module modqueries
    Public sql As String
    Public LT As Integer
    'View Products
    Public Sub PopulateProduct(ByVal lv As ListView)
        connected()
        With lv
            .Items.Clear()
            Sql = " SELECT * FROM tblProduct"
            LoadProduct(lv)
        End With
    End Sub
    'View sales report
    Public Sub PopulateSales(ByVal lv As ListView, ByVal fromdate As String, ByVal todate As String)
        connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblsales where sdate >=  '" & fromdate & "'   AND sdate <= ' " & todate & "'  order by sdate"
            LoadSales(lv)
        End With
    End Sub
    Public Sub PopulateUser(ByVal lv As ListView)
        connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblUser"
            LoadUser(lv)
        End With
    End Sub
    'View Supplier
    Public Sub PopulateSupplier(ByVal lv As ListView)
        connected()
        With lv
            .Items.Clear()
            Sql = " SELECT * FROM tblSupplier"
            LoadSupplier(lv)
        End With
    End Sub
    Public Sub PopulatePO(ByVal cbo As ComboBox)
        connected()
        With cbo
            .Items.Clear()
            sql = "SELECT  distinct pono FROM tblpendingproduct where premarks = 'pending'"
            CommandDB()
            cbo.Items.Clear()
            dr = cmd.ExecuteReader()
            While (dr.Read())
                With cbo.Items.Add(dr("pono"))
                End With
            End While
        End With
    End Sub


    Public Sub PopulatePendingProduct(ByVal lv As ListView, ByVal str As String)
        connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblpendingproduct where pono = '" & str & "' and premarks = 'pending'"
            LoadPendingProduct(lv)
        End With
    End Sub
    '
    Public Sub PopulateROP(ByVal lv As ListView, ByVal tb As ComboBox)
        connected()
        Dim key As String = "'" & tb.Text & "'"
        Sql = " SELECT * FROM tblProduct WHERE psupplier = " & key & " and pqty <= prop"
        LoadProduct(lv)
    End Sub
    'search product code, name, category, supplier
    Public Sub SearchProduct(ByVal lv As ListView, ByVal tb As TextBox)
        connected()
        If tb.Text = "" Then
            Exit Sub
        End If
        Dim key As String = "'" & tb.Text & "%'"
        sql = " SELECT * FROM tblProduct WHERE pcode LIKE " & key & " OR pname LIKE " & key & " OR pcategory LIKE " & key & " OR psupplier LIKE " & key & " "
        LoadProduct(lv)
    End Sub
  
    'Automatic generate a product code
    Public Sub GenerateProdCode(ByVal tb As TextBox)
        connected()
        Dim str As String = ""
        Sql = "SELECT Max(pcode) FROM tblProduct"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                str = dr.Item(0).ToString.Substring(5) + 1
            Loop
        End If
        tb.Text = "PROD-" & str
    End Sub
    'Automatic generate a PO code
    Public Sub GeneratePOno(ByVal tb As TextBox)
        connected()
        Dim str As String = ""
        Sql = "SELECT Max(pono) FROM tblpendingproduct"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                str = dr.Item(0).ToString.Substring(3) + 1
            Loop
        End If
        tb.Text = "PO-" & str
    End Sub
    Public Sub GenerateORno(ByVal tb As TextBox)
        connected()
        Dim str As String = ""
        sql = "SELECT Max(sorno) FROM tblsales"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                str = dr.Item(0).ToString.Substring(3) + 1
            Loop
        End If
        tb.Text = "OR-" & str
    End Sub
    'condition for product code exist
    Public Function DoesExist(ByVal str As String, ByVal tbl As String, ByVal field As String)
        connected()
        Sql = "Select COUNT(*) FROM " & tbl & " WHERE " & field & " = '" & str & "'"
        CommandDB()
        Dim rows As Integer = cmd.ExecuteScalar()
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'get leadtime from supplier
    Function GetLeadTime(ByVal str As String) As String
        connected()
        Dim s As String
        sql = "SELECT * from tblSupplier where sname ='" & str & "'"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                s = dr.Item(4).ToString
            Loop
        End If
        Return s
    End Function

    Public Sub PopulateCBOSupplierROP(ByVal cbo As ComboBox)
        connected()
        Sql = " SELECT distinct psupplier FROM tblProduct where pqty <= prop"
        CommandDB()
        cbo.Items.Clear()
        dr = cmd.ExecuteReader()
        While (dr.Read())
            With cbo.Items.Add(dr("psupplier"))
            End With
        End While
    End Sub
    Public Sub PopulateCBOSupplier(ByVal cbo As ComboBox)
        connected()
        Sql = " SELECT distinct sname FROM tblSupplier"
        CommandDB()
        cbo.Items.Clear()
        dr = cmd.ExecuteReader()
        While (dr.Read())
            With cbo.Items.Add(dr("sname"))
            End With
        End While
    End Sub
    Public Sub PopulateCBOCategory(ByVal cbo As ComboBox)
        connected()
        Sql = " SELECT distinct pcategory FROM tblProduct"
        CommandDB()
        cbo.Items.Clear()
        dr = cmd.ExecuteReader()
        While (dr.Read())
            With cbo.Items.Add(dr("pcategory"))
            End With
        End While
    End Sub

End Module
