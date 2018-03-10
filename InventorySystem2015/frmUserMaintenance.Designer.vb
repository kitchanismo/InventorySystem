<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserMaintenance
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
        Me.lvUser = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpass = New System.Windows.Forms.TextBox()
        Me.tbuname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbcpass = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnpass = New System.Windows.Forms.Label()
        Me.tbnpass = New System.Windows.Forms.TextBox()
        Me.Gbuser = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboposition = New System.Windows.Forms.ComboBox()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gbuser.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvUser
        '
        Me.lvUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3})
        Me.lvUser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvUser.FullRowSelect = True
        Me.lvUser.GridLines = True
        Me.lvUser.Location = New System.Drawing.Point(36, 182)
        Me.lvUser.Name = "lvUser"
        Me.lvUser.Size = New System.Drawing.Size(588, 180)
        Me.lvUser.TabIndex = 0
        Me.lvUser.UseCompatibleStateImageBehavior = False
        Me.lvUser.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 118
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "username"
        Me.ColumnHeader2.Width = 161
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "password"
        Me.ColumnHeader3.Width = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'tbpass
        '
        Me.tbpass.BackColor = System.Drawing.Color.Cornsilk
        Me.tbpass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpass.Location = New System.Drawing.Point(248, 85)
        Me.tbpass.Name = "tbpass"
        Me.tbpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpass.Size = New System.Drawing.Size(144, 23)
        Me.tbpass.TabIndex = 5
        '
        'tbuname
        '
        Me.tbuname.BackColor = System.Drawing.Color.Cornsilk
        Me.tbuname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbuname.Location = New System.Drawing.Point(24, 46)
        Me.tbuname.Multiline = True
        Me.tbuname.Name = "tbuname"
        Me.tbuname.Size = New System.Drawing.Size(197, 62)
        Me.tbuname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(415, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Confirm Password"
        '
        'tbcpass
        '
        Me.tbcpass.BackColor = System.Drawing.Color.Cornsilk
        Me.tbcpass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcpass.Location = New System.Drawing.Point(418, 46)
        Me.tbcpass.Name = "tbcpass"
        Me.tbcpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbcpass.Size = New System.Drawing.Size(144, 23)
        Me.tbcpass.TabIndex = 9
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(110, 400)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(97, 36)
        Me.btnadd.TabIndex = 11
        Me.btnadd.Text = "add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(225, 400)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(97, 36)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(339, 400)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(97, 36)
        Me.btndelete.TabIndex = 13
        Me.btndelete.Text = "delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(454, 400)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(97, 36)
        Me.btnrefresh.TabIndex = 14
        Me.btnrefresh.Text = "refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.Brown
        Me.lblid.Location = New System.Drawing.Point(645, 78)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(16, 16)
        Me.lblid.TabIndex = 15
        Me.lblid.Text = "0"
        Me.lblid.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(642, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "ID"
        Me.Label3.Visible = False
        '
        'lblnpass
        '
        Me.lblnpass.AutoSize = True
        Me.lblnpass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnpass.Location = New System.Drawing.Point(415, 69)
        Me.lblnpass.Name = "lblnpass"
        Me.lblnpass.Size = New System.Drawing.Size(103, 16)
        Me.lblnpass.TabIndex = 19
        Me.lblnpass.Text = "New Password"
        '
        'tbnpass
        '
        Me.tbnpass.BackColor = System.Drawing.Color.Cornsilk
        Me.tbnpass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnpass.Location = New System.Drawing.Point(418, 85)
        Me.tbnpass.Name = "tbnpass"
        Me.tbnpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbnpass.Size = New System.Drawing.Size(144, 23)
        Me.tbnpass.TabIndex = 18
        '
        'Gbuser
        '
        Me.Gbuser.Controls.Add(Me.Label5)
        Me.Gbuser.Controls.Add(Me.cboposition)
        Me.Gbuser.Controls.Add(Me.tbuname)
        Me.Gbuser.Controls.Add(Me.lblnpass)
        Me.Gbuser.Controls.Add(Me.tbpass)
        Me.Gbuser.Controls.Add(Me.tbnpass)
        Me.Gbuser.Controls.Add(Me.Label1)
        Me.Gbuser.Controls.Add(Me.Label2)
        Me.Gbuser.Controls.Add(Me.tbcpass)
        Me.Gbuser.Controls.Add(Me.Label4)
        Me.Gbuser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbuser.Location = New System.Drawing.Point(36, 30)
        Me.Gbuser.Name = "Gbuser"
        Me.Gbuser.Size = New System.Drawing.Size(588, 133)
        Me.Gbuser.TabIndex = 20
        Me.Gbuser.TabStop = False
        Me.Gbuser.Text = "User Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(245, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Position"
        '
        'cboposition
        '
        Me.cboposition.BackColor = System.Drawing.Color.Cornsilk
        Me.cboposition.FormattingEnabled = True
        Me.cboposition.Items.AddRange(New Object() {"Cashier", "Stockman", "Admin", "SalesMan"})
        Me.cboposition.Location = New System.Drawing.Point(248, 45)
        Me.cboposition.Name = "cboposition"
        Me.cboposition.Size = New System.Drawing.Size(144, 24)
        Me.cboposition.TabIndex = 20
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Position"
        Me.ColumnHeader4.Width = 121
        '
        'frmUserMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(661, 454)
        Me.Controls.Add(Me.Gbuser)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lvUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblid)
        Me.MaximizeBox = False
        Me.Name = "frmUserMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserMaintenance"
        Me.Gbuser.ResumeLayout(False)
        Me.Gbuser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvUser As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbpass As System.Windows.Forms.TextBox
    Friend WithEvents tbuname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbcpass As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblnpass As System.Windows.Forms.Label
    Friend WithEvents tbnpass As System.Windows.Forms.TextBox
    Friend WithEvents Gbuser As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboposition As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
