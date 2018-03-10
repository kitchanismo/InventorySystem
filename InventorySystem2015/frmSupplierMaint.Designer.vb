<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierMaint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lvSupplier = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbSupplier = New System.Windows.Forms.GroupBox()
        Me.tblt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbaddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbcontact = New System.Windows.Forms.TextBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.Code = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.gbSupplier.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvSupplier
        '
        Me.lvSupplier.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lvSupplier.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSupplier.FullRowSelect = True
        Me.lvSupplier.GridLines = True
        Me.lvSupplier.Location = New System.Drawing.Point(15, 177)
        Me.lvSupplier.Name = "lvSupplier"
        Me.lvSupplier.Size = New System.Drawing.Size(642, 147)
        Me.lvSupplier.TabIndex = 1
        Me.lvSupplier.UseCompatibleStateImageBehavior = False
        Me.lvSupplier.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 117
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Address"
        Me.ColumnHeader3.Width = 199
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Contact"
        Me.ColumnHeader4.Width = 108
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Lead Time"
        Me.ColumnHeader6.Width = 87
        '
        'gbSupplier
        '
        Me.gbSupplier.BackColor = System.Drawing.Color.Transparent
        Me.gbSupplier.Controls.Add(Me.tblt)
        Me.gbSupplier.Controls.Add(Me.Label9)
        Me.gbSupplier.Controls.Add(Me.tbaddress)
        Me.gbSupplier.Controls.Add(Me.Label5)
        Me.gbSupplier.Controls.Add(Me.Label1)
        Me.gbSupplier.Controls.Add(Me.tbcontact)
        Me.gbSupplier.Controls.Add(Me.tbname)
        Me.gbSupplier.Controls.Add(Me.Label2)
        Me.gbSupplier.Controls.Add(Me.tbid)
        Me.gbSupplier.Controls.Add(Me.Code)
        Me.gbSupplier.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSupplier.Location = New System.Drawing.Point(15, 16)
        Me.gbSupplier.Name = "gbSupplier"
        Me.gbSupplier.Size = New System.Drawing.Size(642, 143)
        Me.gbSupplier.TabIndex = 2
        Me.gbSupplier.TabStop = False
        Me.gbSupplier.Text = "Supplier Details"
        '
        'tblt
        '
        Me.tblt.BackColor = System.Drawing.Color.Cornsilk
        Me.tblt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblt.Location = New System.Drawing.Point(226, 93)
        Me.tblt.Name = "tblt"
        Me.tblt.Size = New System.Drawing.Size(189, 23)
        Me.tblt.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(223, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Lead Time"
        '
        'tbaddress
        '
        Me.tbaddress.BackColor = System.Drawing.Color.Cornsilk
        Me.tbaddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbaddress.Location = New System.Drawing.Point(436, 44)
        Me.tbaddress.Multiline = True
        Me.tbaddress.Name = "tbaddress"
        Me.tbaddress.Size = New System.Drawing.Size(189, 77)
        Me.tbaddress.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Contact"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(433, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Address"
        '
        'tbcontact
        '
        Me.tbcontact.BackColor = System.Drawing.Color.Cornsilk
        Me.tbcontact.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcontact.Location = New System.Drawing.Point(226, 44)
        Me.tbcontact.Name = "tbcontact"
        Me.tbcontact.Size = New System.Drawing.Size(189, 23)
        Me.tbcontact.TabIndex = 8
        '
        'tbname
        '
        Me.tbname.BackColor = System.Drawing.Color.Cornsilk
        Me.tbname.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbname.Location = New System.Drawing.Point(16, 93)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(189, 23)
        Me.tbname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'tbid
        '
        Me.tbid.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbid.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbid.Location = New System.Drawing.Point(16, 44)
        Me.tbid.Name = "tbid"
        Me.tbid.ReadOnly = True
        Me.tbid.Size = New System.Drawing.Size(189, 23)
        Me.tbid.TabIndex = 1
        '
        'Code
        '
        Me.Code.AutoSize = True
        Me.Code.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code.Location = New System.Drawing.Point(13, 24)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(22, 16)
        Me.Code.TabIndex = 0
        Me.Code.Text = "ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.btnrefresh)
        Me.Panel1.Controls.Add(Me.btnupdate)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Location = New System.Drawing.Point(68, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 70)
        Me.Panel1.TabIndex = 22
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.White
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(434, 17)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(76, 34)
        Me.btnrefresh.TabIndex = 21
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.White
        Me.btnupdate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(149, 17)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(76, 34)
        Me.btnupdate.TabIndex = 18
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.White
        Me.btnclear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(339, 17)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(76, 34)
        Me.btnclear.TabIndex = 20
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.White
        Me.btnadd.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(55, 17)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(76, 34)
        Me.btnadd.TabIndex = 17
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.White
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(244, 17)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(76, 34)
        Me.btndelete.TabIndex = 19
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'frmSupplierMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(673, 418)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbSupplier)
        Me.Controls.Add(Me.lvSupplier)
        Me.Name = "frmSupplierMaint"
        Me.Text = "frmSupplierMaint"
        Me.gbSupplier.ResumeLayout(False)
        Me.gbSupplier.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvSupplier As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbSupplier As System.Windows.Forms.GroupBox
    Friend WithEvents tblt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents Code As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
End Class
