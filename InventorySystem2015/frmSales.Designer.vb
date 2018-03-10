<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtto = New System.Windows.Forms.DateTimePicker()
        Me.Code = New System.Windows.Forms.Label()
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.lvSales = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbproduct.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbproduct
        '
        Me.gbproduct.BackColor = System.Drawing.Color.Transparent
        Me.gbproduct.Controls.Add(Me.Label1)
        Me.gbproduct.Controls.Add(Me.dtto)
        Me.gbproduct.Controls.Add(Me.Code)
        Me.gbproduct.Controls.Add(Me.dtfrom)
        Me.gbproduct.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbproduct.ForeColor = System.Drawing.Color.Black
        Me.gbproduct.Location = New System.Drawing.Point(12, 12)
        Me.gbproduct.Name = "gbproduct"
        Me.gbproduct.Size = New System.Drawing.Size(407, 96)
        Me.gbproduct.TabIndex = 34
        Me.gbproduct.TabStop = False
        Me.gbproduct.Text = "Search by Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "To:"
        '
        'dtto
        '
        Me.dtto.CalendarMonthBackground = System.Drawing.Color.Cornsilk
        Me.dtto.CalendarTitleForeColor = System.Drawing.Color.Cornsilk
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(219, 48)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(143, 23)
        Me.dtto.TabIndex = 4
        '
        'Code
        '
        Me.Code.AutoSize = True
        Me.Code.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code.Location = New System.Drawing.Point(33, 29)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(46, 16)
        Me.Code.TabIndex = 3
        Me.Code.Text = "From:"
        '
        'dtfrom
        '
        Me.dtfrom.CalendarMonthBackground = System.Drawing.Color.Cornsilk
        Me.dtfrom.CalendarTitleForeColor = System.Drawing.Color.Cornsilk
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(36, 48)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(143, 23)
        Me.dtfrom.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbtotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(440, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 96)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total"
        '
        'tbtotal
        '
        Me.tbtotal.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbtotal.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtotal.ForeColor = System.Drawing.Color.Maroon
        Me.tbtotal.Location = New System.Drawing.Point(20, 39)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.ReadOnly = True
        Me.tbtotal.Size = New System.Drawing.Size(323, 40)
        Me.tbtotal.TabIndex = 4
        '
        'lvSales
        '
        Me.lvSales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader13, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvSales.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSales.FullRowSelect = True
        Me.lvSales.GridLines = True
        Me.lvSales.Location = New System.Drawing.Point(12, 139)
        Me.lvSales.Name = "lvSales"
        Me.lvSales.Size = New System.Drawing.Size(792, 391)
        Me.lvSales.TabIndex = 36
        Me.lvSales.UseCompatibleStateImageBehavior = False
        Me.lvSales.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "OR No"
        Me.ColumnHeader12.Width = 94
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Code"
        Me.ColumnHeader16.Width = 82
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Name/Description"
        Me.ColumnHeader17.Width = 170
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Customer"
        Me.ColumnHeader18.Width = 108
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Unit Price"
        Me.ColumnHeader13.Width = 84
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Qty"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SubTotal"
        Me.ColumnHeader2.Width = 83
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cash"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Change"
        Me.ColumnHeader5.Width = 84
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Purchase Date"
        Me.ColumnHeader6.Width = 116
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Sales List"
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(816, 557)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lvSales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbproduct)
        Me.MaximizeBox = False
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSales"
        Me.gbproduct.ResumeLayout(False)
        Me.gbproduct.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbproduct As System.Windows.Forms.GroupBox
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Code As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbtotal As System.Windows.Forms.TextBox
    Friend WithEvents lvSales As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
