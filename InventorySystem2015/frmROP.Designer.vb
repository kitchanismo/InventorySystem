<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmROP
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
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Re-Order Point List"
        '
        'lvProd
        '
        Me.lvProd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27})
        Me.lvProd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProd.FullRowSelect = True
        Me.lvProd.GridLines = True
        Me.lvProd.Location = New System.Drawing.Point(22, 44)
        Me.lvProd.Name = "lvProd"
        Me.lvProd.Size = New System.Drawing.Size(813, 499)
        Me.lvProd.TabIndex = 18
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
        Me.ColumnHeader19.Width = 135
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Category"
        Me.ColumnHeader20.Width = 182
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Supplier"
        Me.ColumnHeader21.Width = 206
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Unit Cost"
        Me.ColumnHeader22.Width = 144
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Unit Price"
        Me.ColumnHeader23.Width = 130
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
        Me.ColumnHeader26.Width = 68
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Annual Demand"
        Me.ColumnHeader27.Width = 87
        '
        'frmROP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(858, 566)
        Me.Controls.Add(Me.lvProd)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "frmROP"
        Me.Text = "frmROP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
End Class
