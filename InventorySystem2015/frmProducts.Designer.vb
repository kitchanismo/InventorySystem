<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Product List"
        '
        'lvProd
        '
        Me.lvProd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvProd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProd.FullRowSelect = True
        Me.lvProd.GridLines = True
        Me.lvProd.Location = New System.Drawing.Point(24, 43)
        Me.lvProd.Name = "lvProd"
        Me.lvProd.Size = New System.Drawing.Size(813, 500)
        Me.lvProd.TabIndex = 20
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
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(858, 566)
        Me.Controls.Add(Me.lvProd)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "frmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProducts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
End Class
