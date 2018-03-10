<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Me.gbproduct = New System.Windows.Forms.GroupBox()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbsubtotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.tbpo = New System.Windows.Forms.TextBox()
        Me.Code = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.lvPurchase = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvProd = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbproduct.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbproduct
        '
        Me.gbproduct.BackColor = System.Drawing.Color.Transparent
        Me.gbproduct.Controls.Add(Me.cboSupplier)
        Me.gbproduct.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbproduct.ForeColor = System.Drawing.Color.Black
        Me.gbproduct.Location = New System.Drawing.Point(30, 34)
        Me.gbproduct.Name = "gbproduct"
        Me.gbproduct.Size = New System.Drawing.Size(374, 84)
        Me.gbproduct.TabIndex = 2
        Me.gbproduct.TabStop = False
        Me.gbproduct.Text = "Select Supplier"
        '
        'cboSupplier
        '
        Me.cboSupplier.BackColor = System.Drawing.Color.Cornsilk
        Me.cboSupplier.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(25, 39)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(322, 26)
        Me.cboSupplier.TabIndex = 13
        Me.cboSupplier.Text = "Select ..."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbsubtotal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbtotal)
        Me.GroupBox1.Controls.Add(Me.tbpo)
        Me.GroupBox1.Controls.Add(Me.Code)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(421, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 84)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PO Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(243, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total"
        '
        'tbsubtotal
        '
        Me.tbsubtotal.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbsubtotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsubtotal.ForeColor = System.Drawing.Color.Black
        Me.tbsubtotal.Location = New System.Drawing.Point(137, 42)
        Me.tbsubtotal.Name = "tbsubtotal"
        Me.tbsubtotal.ReadOnly = True
        Me.tbsubtotal.Size = New System.Drawing.Size(103, 23)
        Me.tbsubtotal.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sub Total"
        '
        'tbtotal
        '
        Me.tbtotal.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbtotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtotal.ForeColor = System.Drawing.Color.Maroon
        Me.tbtotal.Location = New System.Drawing.Point(246, 42)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.ReadOnly = True
        Me.tbtotal.Size = New System.Drawing.Size(103, 23)
        Me.tbtotal.TabIndex = 4
        '
        'tbpo
        '
        Me.tbpo.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbpo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpo.Location = New System.Drawing.Point(28, 42)
        Me.tbpo.Name = "tbpo"
        Me.tbpo.ReadOnly = True
        Me.tbpo.Size = New System.Drawing.Size(103, 23)
        Me.tbpo.TabIndex = 3
        '
        'Code
        '
        Me.Code.AutoSize = True
        Me.Code.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code.Location = New System.Drawing.Point(25, 23)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(53, 16)
        Me.Code.TabIndex = 2
        Me.Code.Text = "PO No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product List"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Purchase List"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnPurchase)
        Me.Panel1.Location = New System.Drawing.Point(153, 448)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 61)
        Me.Panel1.TabIndex = 22
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(268, 14)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(142, 34)
        Me.btncancel.TabIndex = 20
        Me.btncancel.Text = "Cancel Transaction"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnPurchase
        '
        Me.btnPurchase.BackColor = System.Drawing.Color.White
        Me.btnPurchase.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.Location = New System.Drawing.Point(109, 14)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(142, 34)
        Me.btnPurchase.TabIndex = 17
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = False
        '
        'lvPurchase
        '
        Me.lvPurchase.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.lvPurchase.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPurchase.FullRowSelect = True
        Me.lvPurchase.GridLines = True
        Me.lvPurchase.Location = New System.Drawing.Point(421, 152)
        Me.lvPurchase.Name = "lvPurchase"
        Me.lvPurchase.Size = New System.Drawing.Size(374, 270)
        Me.lvPurchase.TabIndex = 23
        Me.lvPurchase.UseCompatibleStateImageBehavior = False
        Me.lvPurchase.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Code"
        Me.ColumnHeader11.Width = 79
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Name\Description"
        Me.ColumnHeader12.Width = 134
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Category"
        Me.ColumnHeader13.Width = 0
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Supplier"
        Me.ColumnHeader14.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Unit Cost"
        Me.ColumnHeader16.Width = 82
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Qty"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Subtotal"
        Me.ColumnHeader18.Width = 59
        '
        'lvProd
        '
        Me.lvProd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27})
        Me.lvProd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProd.FullRowSelect = True
        Me.lvProd.GridLines = True
        Me.lvProd.Location = New System.Drawing.Point(30, 152)
        Me.lvProd.Name = "lvProd"
        Me.lvProd.Size = New System.Drawing.Size(374, 270)
        Me.lvProd.TabIndex = 15
        Me.lvProd.UseCompatibleStateImageBehavior = False
        Me.lvProd.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Code"
        Me.ColumnHeader15.Width = 79
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Name\Description"
        Me.ColumnHeader19.Width = 141
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Category"
        Me.ColumnHeader20.Width = 0
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Supplier"
        Me.ColumnHeader21.Width = 0
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Unit Cost"
        Me.ColumnHeader22.Width = 100
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Unit Price"
        Me.ColumnHeader23.Width = 0
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Qty"
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "ROP"
        Me.ColumnHeader25.Width = 59
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "EOQ"
        Me.ColumnHeader26.Width = 59
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Annual Demand"
        Me.ColumnHeader27.Width = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Brown
        Me.Label7.Location = New System.Drawing.Point(180, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 14)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = " *Double Click on List to Enter QTY"
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(824, 531)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lvPurchase)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvProd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbproduct)
        Me.MaximizeBox = False
        Me.Name = "frmPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPurchaseOrder"
        Me.gbproduct.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbproduct As System.Windows.Forms.GroupBox
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbtotal As System.Windows.Forms.TextBox
    Friend WithEvents tbpo As System.Windows.Forms.TextBox
    Friend WithEvents Code As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents lvPurchase As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents lvProd As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
