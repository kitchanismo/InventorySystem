<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdMaint
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
        Me.gbproduct = New System.Windows.Forms.GroupBox()
        Me.btnaddsupplier = New System.Windows.Forms.Button()
        Me.tbqty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbucost = New System.Windows.Forms.TextBox()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbuprice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbocategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbcode = New System.Windows.Forms.TextBox()
        Me.Code = New System.Windows.Forms.Label()
        Me.gbother = New System.Windows.Forms.GroupBox()
        Me.tblt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbannual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbeoq = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbrop = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.gbproduct.SuspendLayout()
        Me.gbother.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvProd
        '
        Me.lvProd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvProd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProd.FullRowSelect = True
        Me.lvProd.GridLines = True
        Me.lvProd.Location = New System.Drawing.Point(13, 206)
        Me.lvProd.Name = "lvProd"
        Me.lvProd.Size = New System.Drawing.Size(813, 223)
        Me.lvProd.TabIndex = 0
        Me.lvProd.UseCompatibleStateImageBehavior = False
        Me.lvProd.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name\Description"
        Me.ColumnHeader2.Width = 156
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Category"
        Me.ColumnHeader3.Width = 106
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Supplier"
        Me.ColumnHeader4.Width = 94
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit Cost"
        Me.ColumnHeader5.Width = 75
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
        Me.ColumnHeader8.Width = 59
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "EOQ"
        Me.ColumnHeader9.Width = 59
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Annual Demand"
        Me.ColumnHeader10.Width = 147
        '
        'gbproduct
        '
        Me.gbproduct.BackColor = System.Drawing.Color.Transparent
        Me.gbproduct.Controls.Add(Me.btnaddsupplier)
        Me.gbproduct.Controls.Add(Me.tbqty)
        Me.gbproduct.Controls.Add(Me.Label9)
        Me.gbproduct.Controls.Add(Me.tbucost)
        Me.gbproduct.Controls.Add(Me.cboSupplier)
        Me.gbproduct.Controls.Add(Me.Label5)
        Me.gbproduct.Controls.Add(Me.Label4)
        Me.gbproduct.Controls.Add(Me.tbuprice)
        Me.gbproduct.Controls.Add(Me.Label3)
        Me.gbproduct.Controls.Add(Me.cbocategory)
        Me.gbproduct.Controls.Add(Me.Label1)
        Me.gbproduct.Controls.Add(Me.tbname)
        Me.gbproduct.Controls.Add(Me.Label2)
        Me.gbproduct.Controls.Add(Me.tbcode)
        Me.gbproduct.Controls.Add(Me.Code)
        Me.gbproduct.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbproduct.Location = New System.Drawing.Point(13, 14)
        Me.gbproduct.Name = "gbproduct"
        Me.gbproduct.Size = New System.Drawing.Size(465, 180)
        Me.gbproduct.TabIndex = 1
        Me.gbproduct.TabStop = False
        Me.gbproduct.Text = "Product Details"
        '
        'btnaddsupplier
        '
        Me.btnaddsupplier.BackColor = System.Drawing.Color.White
        Me.btnaddsupplier.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddsupplier.Location = New System.Drawing.Point(405, 87)
        Me.btnaddsupplier.Name = "btnaddsupplier"
        Me.btnaddsupplier.Size = New System.Drawing.Size(43, 24)
        Me.btnaddsupplier.TabIndex = 22
        Me.btnaddsupplier.Text = "..."
        Me.btnaddsupplier.UseVisualStyleBackColor = False
        '
        'tbqty
        '
        Me.tbqty.BackColor = System.Drawing.Color.Cornsilk
        Me.tbqty.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbqty.Location = New System.Drawing.Point(373, 140)
        Me.tbqty.Name = "tbqty"
        Me.tbqty.Size = New System.Drawing.Size(75, 23)
        Me.tbqty.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(370, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Quantity"
        '
        'tbucost
        '
        Me.tbucost.BackColor = System.Drawing.Color.Cornsilk
        Me.tbucost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbucost.Location = New System.Drawing.Point(215, 140)
        Me.tbucost.Name = "tbucost"
        Me.tbucost.Size = New System.Drawing.Size(75, 23)
        Me.tbucost.TabIndex = 15
        '
        'cboSupplier
        '
        Me.cboSupplier.BackColor = System.Drawing.Color.Cornsilk
        Me.cboSupplier.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(215, 87)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(184, 24)
        Me.cboSupplier.TabIndex = 12
        Me.cboSupplier.Text = "Select ..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(212, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(291, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Unit Price"
        '
        'tbuprice
        '
        Me.tbuprice.BackColor = System.Drawing.Color.Cornsilk
        Me.tbuprice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbuprice.Location = New System.Drawing.Point(294, 140)
        Me.tbuprice.Name = "tbuprice"
        Me.tbuprice.Size = New System.Drawing.Size(75, 23)
        Me.tbuprice.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Unit Cost"
        '
        'cbocategory
        '
        Me.cbocategory.BackColor = System.Drawing.Color.Cornsilk
        Me.cbocategory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocategory.FormattingEnabled = True
        Me.cbocategory.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbocategory.Location = New System.Drawing.Point(215, 38)
        Me.cbocategory.Name = "cbocategory"
        Me.cbocategory.Size = New System.Drawing.Size(233, 24)
        Me.cbocategory.TabIndex = 6
        Me.cbocategory.Text = "Select ..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Category"
        '
        'tbname
        '
        Me.tbname.BackColor = System.Drawing.Color.Cornsilk
        Me.tbname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbname.Location = New System.Drawing.Point(16, 86)
        Me.tbname.Multiline = True
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(189, 77)
        Me.tbname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name/Description"
        '
        'tbcode
        '
        Me.tbcode.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbcode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcode.Location = New System.Drawing.Point(16, 39)
        Me.tbcode.Name = "tbcode"
        Me.tbcode.ReadOnly = True
        Me.tbcode.Size = New System.Drawing.Size(189, 23)
        Me.tbcode.TabIndex = 1
        '
        'Code
        '
        Me.Code.AutoSize = True
        Me.Code.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code.Location = New System.Drawing.Point(13, 20)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(41, 16)
        Me.Code.TabIndex = 0
        Me.Code.Text = "Code"
        '
        'gbother
        '
        Me.gbother.BackColor = System.Drawing.Color.Transparent
        Me.gbother.Controls.Add(Me.tblt)
        Me.gbother.Controls.Add(Me.Label10)
        Me.gbother.Controls.Add(Me.tbannual)
        Me.gbother.Controls.Add(Me.Label8)
        Me.gbother.Controls.Add(Me.tbeoq)
        Me.gbother.Controls.Add(Me.Label7)
        Me.gbother.Controls.Add(Me.Label6)
        Me.gbother.Controls.Add(Me.tbrop)
        Me.gbother.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbother.Location = New System.Drawing.Point(484, 14)
        Me.gbother.Name = "gbother"
        Me.gbother.Size = New System.Drawing.Size(342, 123)
        Me.gbother.TabIndex = 2
        Me.gbother.TabStop = False
        Me.gbother.Text = "Enter AD to Compute EOQ/ROP"
        '
        'tblt
        '
        Me.tblt.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tblt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblt.Location = New System.Drawing.Point(17, 86)
        Me.tblt.Name = "tblt"
        Me.tblt.ReadOnly = True
        Me.tblt.Size = New System.Drawing.Size(75, 23)
        Me.tblt.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Lead Time"
        '
        'tbannual
        '
        Me.tbannual.BackColor = System.Drawing.Color.Cornsilk
        Me.tbannual.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbannual.Location = New System.Drawing.Point(17, 37)
        Me.tbannual.MaxLength = 10
        Me.tbannual.Name = "tbannual"
        Me.tbannual.Size = New System.Drawing.Size(308, 23)
        Me.tbannual.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Annual Demand"
        '
        'tbeoq
        '
        Me.tbeoq.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbeoq.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbeoq.Location = New System.Drawing.Point(135, 86)
        Me.tbeoq.Name = "tbeoq"
        Me.tbeoq.ReadOnly = True
        Me.tbeoq.Size = New System.Drawing.Size(75, 23)
        Me.tbeoq.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(132, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "EOQ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(247, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ROP"
        '
        'tbrop
        '
        Me.tbrop.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbrop.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbrop.Location = New System.Drawing.Point(250, 86)
        Me.tbrop.Name = "tbrop"
        Me.tbrop.ReadOnly = True
        Me.tbrop.Size = New System.Drawing.Size(75, 23)
        Me.tbrop.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.tbsearch)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(484, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 65)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Code/Name/Category/Supplier"
        '
        'tbsearch
        '
        Me.tbsearch.BackColor = System.Drawing.Color.Cornsilk
        Me.tbsearch.Location = New System.Drawing.Point(17, 25)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(308, 23)
        Me.tbsearch.TabIndex = 16
        Me.tbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.btnrefresh)
        Me.Panel1.Controls.Add(Me.btnupdate)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Location = New System.Drawing.Point(157, 443)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 70)
        Me.Panel1.TabIndex = 21
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
        'frmProdMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(840, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbother)
        Me.Controls.Add(Me.gbproduct)
        Me.Controls.Add(Me.lvProd)
        Me.MaximizeBox = False
        Me.Name = "frmProdMaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProdMaint"
        Me.gbproduct.ResumeLayout(False)
        Me.gbproduct.PerformLayout()
        Me.gbother.ResumeLayout(False)
        Me.gbother.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvProd As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbproduct As System.Windows.Forms.GroupBox
    Friend WithEvents tbucost As System.Windows.Forms.TextBox
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbuprice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbocategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbcode As System.Windows.Forms.TextBox
    Friend WithEvents Code As System.Windows.Forms.Label
    Friend WithEvents gbother As System.Windows.Forms.GroupBox
    Friend WithEvents tbannual As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbeoq As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbrop As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbqty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents tblt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnaddsupplier As System.Windows.Forms.Button
End Class
