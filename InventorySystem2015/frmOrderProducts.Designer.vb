<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderProducts
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
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvProd
        '
        Me.lvProd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader27, Me.ColumnHeader15, Me.ColumnHeader19, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader1})
        Me.lvProd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProd.FullRowSelect = True
        Me.lvProd.GridLines = True
        Me.lvProd.Location = New System.Drawing.Point(23, 47)
        Me.lvProd.Name = "lvProd"
        Me.lvProd.Size = New System.Drawing.Size(813, 507)
        Me.lvProd.TabIndex = 21
        Me.lvProd.UseCompatibleStateImageBehavior = False
        Me.lvProd.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "PO Number"
        Me.ColumnHeader27.Width = 87
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Code"
        Me.ColumnHeader15.Width = 79
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Name\Description"
        Me.ColumnHeader19.Width = 161
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Supplier"
        Me.ColumnHeader21.Width = 83
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Unit Cost"
        Me.ColumnHeader22.Width = 90
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Qty"
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "SubTotal"
        Me.ColumnHeader25.Width = 76
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "PO Date"
        Me.ColumnHeader26.Width = 70
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Remarks"
        Me.ColumnHeader1.Width = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Ordered List"
        '
        'frmOrderProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(858, 566)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvProd)
        Me.MaximizeBox = False
        Me.Name = "frmOrderProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOrderProducts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvProd As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
