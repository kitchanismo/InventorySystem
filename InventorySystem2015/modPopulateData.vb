Imports System.Data.SqlClient

Module modPopulateData
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public con As New SqlConnection
    'Public cmd As OleDb.OleDbCommand
    'Public dr As OleDb.OleDbDataReader
    'Public con As New OleDb.OleDbConnection 
    Public Sub connected()
        With con
            If .State = ConnectionState.Open Then .Close()
            '.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Inventory.mdb;"
            .ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\dbInvSys.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            .Open()
        End With
    End Sub
    'cmd use
    Sub CommandDB()
        'cmd = New OleDb.OleDbCommand(sql, con)
        cmd = New SqlCommand(sql, con)
    End Sub
    'Load a supplier
    Sub LoadUser(ByVal lv As ListView)
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("uid"))
                .SubItems.Add(dr("uname"))
                .SubItems.Add(dr("uposition"))
                .SubItems.Add(dr("upword"))
            End With
        End While
    End Sub
    Sub LoadSupplier(ByVal lv As ListView)
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("sid"))
                .SubItems.Add(dr("sname"))
                .SubItems.Add(dr("saddress"))
                .SubItems.Add(dr("scontact"))
                .SubItems.Add(dr("slt"))
            End With
        End While
    End Sub
    'Load a products
    Sub LoadProduct(ByVal lv As ListView)
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("pcode"))
                .SubItems.Add(dr("pname"))
                .SubItems.Add(dr("pcategory"))
                .SubItems.Add(dr("psupplier"))
                .SubItems.Add(dr("pucost"))
                .SubItems.Add(dr("puprice"))
                .SubItems.Add(dr("pqty"))
                .SubItems.Add(dr("prop"))
                .SubItems.Add(dr("peoq"))
                .SubItems.Add(dr("pannual"))
            End With
        End While
    End Sub
    'Load a products
    Sub LoadPendingProduct(ByVal lv As ListView)
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("pcode"))
                .SubItems.Add(dr("pname"))
                .SubItems.Add(dr("psupplier"))
                .SubItems.Add(dr("pucost"))
                .SubItems.Add(dr("pqty"))
                .SubItems.Add(dr("psubtotal"))
                .SubItems.Add(dr("podate"))
                .SubItems.Add(dr("premarks"))
            End With
        End While
    End Sub
    'Load a pendin products
    Sub LoadPendingProductwithPOno(ByVal lv As ListView)
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("pono"))
                .SubItems.Add(dr("pcode"))
                .SubItems.Add(dr("pname"))
                .SubItems.Add(dr("psupplier"))
                .SubItems.Add(dr("pucost"))
                .SubItems.Add(dr("pqty"))
                .SubItems.Add(dr("psubtotal"))
                .SubItems.Add(dr("podate"))
                .SubItems.Add(dr("premarks"))
            End With
        End While
    End Sub
    'Load a pendin products
    Sub LoadSales(ByVal lv As ListView)
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("sorno"))
                .SubItems.Add(dr("scode"))
                .SubItems.Add(dr("sname"))
                .SubItems.Add(dr("cname"))
                .SubItems.Add(dr("suprice"))
                .SubItems.Add(dr("sqty"))
                .SubItems.Add(dr("stotal"))
                .SubItems.Add(dr("scash"))
                .SubItems.Add(dr("schange"))
                .SubItems.Add(dr("sdate"))
            End With
        End While
    End Sub

End Module

