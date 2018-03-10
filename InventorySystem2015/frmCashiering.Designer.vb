<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashiering
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.lvProd = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvPurchase = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbwalkin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbor = New System.Windows.Forms.TextBox()
        Me.Code = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbchange = New System.Windows.Forms.TextBox()
        Me.tbnoitem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbcash = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.tbsearch)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(412, 84)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Code/Name"
        '
        'tbsearch
        '
        Me.tbsearch.BackColor = System.Drawing.Color.Cornsilk
        Me.tbsearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.Location = New System.Drawing.Point(21, 41)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(369, 23)
        Me.tbsearch.TabIndex = 16
        Me.tbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvProd
        '
        Me.lvProd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvProd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProd.FullRowSelect = True
        Me.lvProd.GridLines = True
        Me.lvProd.Location = New System.Drawing.Point(21, 122)
        Me.lvProd.Name = "lvProd"
        Me.lvProd.Size = New System.Drawing.Size(412, 288)
        Me.lvProd.TabIndex = 4
        Me.lvProd.UseCompatibleStateImageBehavior = False
        Me.lvProd.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name\Description"
        Me.ColumnHeader2.Width = 156
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Category"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Supplier"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit Cost"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Unit Price"
        Me.ColumnHeader6.Width = 87
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Qty"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ROP"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "EOQ"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Annual Demand"
        Me.ColumnHeader10.Width = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product List"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Purchase List"
        '
        'lvPurchase
        '
        Me.lvPurchase.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader13})
        Me.lvPurchase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPurchase.FullRowSelect = True
        Me.lvPurchase.GridLines = True
        Me.lvPurchase.Location = New System.Drawing.Point(447, 122)
        Me.lvPurchase.Name = "lvPurchase"
        Me.lvPurchase.Size = New System.Drawing.Size(421, 288)
        Me.lvPurchase.TabIndex = 24
        Me.lvPurchase.UseCompatibleStateImageBehavior = False
        Me.lvPurchase.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Code"
        Me.ColumnHeader11.Width = 96
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Name\Description"
        Me.ColumnHeader12.Width = 144
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Unit Price"
        Me.ColumnHeader16.Width = 82
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Qty Ordered"
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Subtotal"
        Me.ColumnHeader18.Width = 78
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "pqty"
        Me.ColumnHeader13.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tbwalkin)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbor)
        Me.GroupBox1.Controls.Add(Me.Code)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(450, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 84)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OR Details"
        '
        'tbwalkin
        '
        Me.tbwalkin.BackColor = System.Drawing.Color.Cornsilk
        Me.tbwalkin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbwalkin.ForeColor = System.Drawing.Color.Black
        Me.tbwalkin.Location = New System.Drawing.Point(155, 41)
        Me.tbwalkin.Name = "tbwalkin"
        Me.tbwalkin.Size = New System.Drawing.Size(240, 23)
        Me.tbwalkin.TabIndex = 6
        Me.tbwalkin.Text = "Walk-In"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(152, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Customer"
        '
        'tbor
        '
        Me.tbor.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbor.Location = New System.Drawing.Point(16, 41)
        Me.tbor.Name = "tbor"
        Me.tbor.ReadOnly = True
        Me.tbor.Size = New System.Drawing.Size(103, 23)
        Me.tbor.TabIndex = 3
        '
        'Code
        '
        Me.Code.AutoSize = True
        Me.Code.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code.Location = New System.Drawing.Point(13, 22)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(53, 16)
        Me.Code.TabIndex = 2
        Me.Code.Text = "OR No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total"
        '
        'tbtotal
        '
        Me.tbtotal.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbtotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtotal.ForeColor = System.Drawing.Color.Maroon
        Me.tbtotal.Location = New System.Drawing.Point(160, 41)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.ReadOnly = True
        Me.tbtotal.Size = New System.Drawing.Size(103, 23)
        Me.tbtotal.TabIndex = 4
        Me.tbtotal.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbchange)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbnoitem)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbtotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(447, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 84)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Change"
        '
        'tbchange
        '
        Me.tbchange.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbchange.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbchange.ForeColor = System.Drawing.Color.Maroon
        Me.tbchange.Location = New System.Drawing.Point(298, 41)
        Me.tbchange.Name = "tbchange"
        Me.tbchange.ReadOnly = True
        Me.tbchange.Size = New System.Drawing.Size(103, 23)
        Me.tbchange.TabIndex = 8
        Me.tbchange.Text = "0"
        '
        'tbnoitem
        '
        Me.tbnoitem.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbnoitem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnoitem.Location = New System.Drawing.Point(19, 41)
        Me.tbnoitem.Name = "tbnoitem"
        Me.tbnoitem.ReadOnly = True
        Me.tbnoitem.Size = New System.Drawing.Size(103, 23)
        Me.tbnoitem.TabIndex = 3
        Me.tbnoitem.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "No. of Items"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.tbcash)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(21, 416)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(412, 84)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Enter Cash"
        '
        'tbcash
        '
        Me.tbcash.BackColor = System.Drawing.Color.Cornsilk
        Me.tbcash.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcash.Location = New System.Drawing.Point(21, 24)
        Me.tbcash.Name = "tbcash"
        Me.tbcash.Size = New System.Drawing.Size(369, 46)
        Me.tbcash.TabIndex = 18
        Me.tbcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Brown
        Me.Label9.Location = New System.Drawing.Point(213, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 14)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "*Double Click on List to Enter QTY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(635, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 14)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "*Double Click on List to Return Item"
        '
        'frmCashiering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(890, 518)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lvProd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvPurchase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmCashiering"
        Me.Text = "frmCashiering"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents lvProd As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvPurchase As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbtotal As System.Windows.Forms.TextBox
    Friend WithEvents tbor As System.Windows.Forms.TextBox
    Friend WithEvents Code As System.Windows.Forms.Label
    Friend WithEvents tbwalkin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbchange As System.Windows.Forms.TextBox
    Friend WithEvents tbnoitem As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbcash As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
