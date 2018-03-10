<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiveOrder
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbsi = New System.Windows.Forms.TextBox()
        Me.lvPending = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnreceive = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbproduct = New System.Windows.Forms.GroupBox()
        Me.cbopo = New System.Windows.Forms.ComboBox()
        Me.lvreceive = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbproduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tbsi)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(417, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 84)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter Sales Invoice"
        '
        'tbsi
        '
        Me.tbsi.BackColor = System.Drawing.Color.Cornsilk
        Me.tbsi.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsi.Location = New System.Drawing.Point(31, 35)
        Me.tbsi.Name = "tbsi"
        Me.tbsi.Size = New System.Drawing.Size(340, 27)
        Me.tbsi.TabIndex = 3
        Me.tbsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvPending
        '
        Me.lvPending.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader1, Me.ColumnHeader3})
        Me.lvPending.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPending.FullRowSelect = True
        Me.lvPending.GridLines = True
        Me.lvPending.Location = New System.Drawing.Point(21, 123)
        Me.lvPending.Name = "lvPending"
        Me.lvPending.Size = New System.Drawing.Size(382, 319)
        Me.lvPending.TabIndex = 25
        Me.lvPending.UseCompatibleStateImageBehavior = False
        Me.lvPending.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Code"
        Me.ColumnHeader11.Width = 79
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Name\Description"
        Me.ColumnHeader12.Width = 154
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Supplier"
        Me.ColumnHeader14.Width = 145
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Unit Cost"
        Me.ColumnHeader16.Width = 92
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Qty Ordered"
        Me.ColumnHeader17.Width = 112
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Subtotal"
        Me.ColumnHeader18.Width = 95
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ordered Date"
        Me.ColumnHeader1.Width = 102
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Remarks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Pending List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Receive List"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnreceive)
        Me.Panel1.Location = New System.Drawing.Point(140, 456)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 61)
        Me.Panel1.TabIndex = 29
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(280, 14)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(142, 34)
        Me.btncancel.TabIndex = 20
        Me.btncancel.Text = "Cancel Transaction"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnreceive
        '
        Me.btnreceive.BackColor = System.Drawing.Color.White
        Me.btnreceive.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreceive.Location = New System.Drawing.Point(121, 14)
        Me.btnreceive.Name = "btnreceive"
        Me.btnreceive.Size = New System.Drawing.Size(142, 34)
        Me.btnreceive.TabIndex = 17
        Me.btnreceive.Text = "Save"
        Me.btnreceive.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Brown
        Me.Label7.Location = New System.Drawing.Point(182, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 14)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = " *Double Click on List to Enter QTY"
        '
        'gbproduct
        '
        Me.gbproduct.BackColor = System.Drawing.Color.Transparent
        Me.gbproduct.Controls.Add(Me.cbopo)
        Me.gbproduct.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbproduct.ForeColor = System.Drawing.Color.Black
        Me.gbproduct.Location = New System.Drawing.Point(17, 8)
        Me.gbproduct.Name = "gbproduct"
        Me.gbproduct.Size = New System.Drawing.Size(386, 84)
        Me.gbproduct.TabIndex = 33
        Me.gbproduct.TabStop = False
        Me.gbproduct.Text = "Select PO Number"
        '
        'cbopo
        '
        Me.cbopo.BackColor = System.Drawing.Color.Cornsilk
        Me.cbopo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopo.FormattingEnabled = True
        Me.cbopo.Location = New System.Drawing.Point(25, 34)
        Me.cbopo.Name = "cbopo"
        Me.cbopo.Size = New System.Drawing.Size(322, 26)
        Me.cbopo.TabIndex = 13
        Me.cbopo.Text = "Select ..."
        '
        'lvreceive
        '
        Me.lvreceive.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader4, Me.ColumnHeader15})
        Me.lvreceive.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvreceive.FullRowSelect = True
        Me.lvreceive.GridLines = True
        Me.lvreceive.Location = New System.Drawing.Point(420, 123)
        Me.lvreceive.Name = "lvreceive"
        Me.lvreceive.Size = New System.Drawing.Size(395, 319)
        Me.lvreceive.TabIndex = 35
        Me.lvreceive.UseCompatibleStateImageBehavior = False
        Me.lvreceive.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Code"
        Me.ColumnHeader5.Width = 79
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name\Description"
        Me.ColumnHeader6.Width = 147
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Supplier"
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Unit Cost"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Qty Received"
        Me.ColumnHeader10.Width = 31
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sub Total"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Remarks"
        Me.ColumnHeader15.Width = 85
        '
        'frmReceiveOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(824, 531)
        Me.Controls.Add(Me.lvreceive)
        Me.Controls.Add(Me.gbproduct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvPending)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmReceiveOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReceiveOrder"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gbproduct.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbsi As System.Windows.Forms.TextBox
    Friend WithEvents lvPending As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnreceive As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbproduct As System.Windows.Forms.GroupBox
    Friend WithEvents cbopo As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvreceive As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
