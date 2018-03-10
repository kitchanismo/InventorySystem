<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CashieringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ROPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.TimerDate = New System.Windows.Forms.Timer(Me.components)
        Me.pnloginform = New System.Windows.Forms.Panel()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.tbpword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbuname = New System.Windows.Forms.TextBox()
        Me.Code = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Menu.SuspendLayout()
        Me.pnloginform.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Menu.Enabled = False
        Me.Menu.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintenanceToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(839, 26)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductMaintenanceToolStripMenuItem, Me.SupplierMaintenanceToolStripMenuItem, Me.UserMaintenanceToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenances"
        '
        'ProductMaintenanceToolStripMenuItem
        '
        Me.ProductMaintenanceToolStripMenuItem.Name = "ProductMaintenanceToolStripMenuItem"
        Me.ProductMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ProductMaintenanceToolStripMenuItem.Text = "Product"
        '
        'SupplierMaintenanceToolStripMenuItem
        '
        Me.SupplierMaintenanceToolStripMenuItem.Name = "SupplierMaintenanceToolStripMenuItem"
        Me.SupplierMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SupplierMaintenanceToolStripMenuItem.Text = "Supplier"
        '
        'UserMaintenanceToolStripMenuItem
        '
        Me.UserMaintenanceToolStripMenuItem.Name = "UserMaintenanceToolStripMenuItem"
        Me.UserMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.UserMaintenanceToolStripMenuItem.Text = "User"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseOrderToolStripMenuItem, Me.ReceiveOrderToolStripMenuItem, Me.ToolStripSeparator1, Me.CashieringToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TransactionToolStripMenuItem.Text = "Transactions"
        '
        'PurchaseOrderToolStripMenuItem
        '
        Me.PurchaseOrderToolStripMenuItem.Name = "PurchaseOrderToolStripMenuItem"
        Me.PurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.PurchaseOrderToolStripMenuItem.Text = "Purchase Order"
        '
        'ReceiveOrderToolStripMenuItem
        '
        Me.ReceiveOrderToolStripMenuItem.Name = "ReceiveOrderToolStripMenuItem"
        Me.ReceiveOrderToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ReceiveOrderToolStripMenuItem.Text = "Receive Order"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(213, 6)
        '
        'CashieringToolStripMenuItem
        '
        Me.CashieringToolStripMenuItem.Name = "CashieringToolStripMenuItem"
        Me.CashieringToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CashieringToolStripMenuItem.Text = "Cashiering"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.ToolStripSeparator3, Me.ProductToolStripMenuItem, Me.OrderToolStripMenuItem, Me.ReceiveToolStripMenuItem, Me.ToolStripSeparator2, Me.ROPToolStripMenuItem, Me.BackOrderToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(83, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(179, 6)
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ProductToolStripMenuItem.Text = "Product "
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'ReceiveToolStripMenuItem
        '
        Me.ReceiveToolStripMenuItem.Name = "ReceiveToolStripMenuItem"
        Me.ReceiveToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ReceiveToolStripMenuItem.Text = "Receive"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(179, 6)
        '
        'ROPToolStripMenuItem
        '
        Me.ROPToolStripMenuItem.Name = "ROPToolStripMenuItem"
        Me.ROPToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ROPToolStripMenuItem.Text = "ROP "
        '
        'BackOrderToolStripMenuItem
        '
        Me.BackOrderToolStripMenuItem.Name = "BackOrderToolStripMenuItem"
        Me.BackOrderToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BackOrderToolStripMenuItem.Text = "Back-Order"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(76, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'lbldate
        '
        Me.lbldate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldate.Location = New System.Drawing.Point(15, 485)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(82, 25)
        Me.lbldate.TabIndex = 1
        Me.lbldate.Text = "Label1"
        '
        'TimerDate
        '
        Me.TimerDate.Enabled = True
        '
        'pnloginform
        '
        Me.pnloginform.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnloginform.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnloginform.Controls.Add(Me.btnlogin)
        Me.pnloginform.Controls.Add(Me.tbpword)
        Me.pnloginform.Controls.Add(Me.Label1)
        Me.pnloginform.Controls.Add(Me.tbuname)
        Me.pnloginform.Controls.Add(Me.Code)
        Me.pnloginform.Location = New System.Drawing.Point(-7, 26)
        Me.pnloginform.Name = "pnloginform"
        Me.pnloginform.Size = New System.Drawing.Size(869, 92)
        Me.pnloginform.TabIndex = 2
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnlogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(451, 39)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(76, 27)
        Me.btnlogin.TabIndex = 18
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'tbpword
        '
        Me.tbpword.BackColor = System.Drawing.Color.Cornsilk
        Me.tbpword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpword.Location = New System.Drawing.Point(240, 40)
        Me.tbpword.Name = "tbpword"
        Me.tbpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpword.Size = New System.Drawing.Size(189, 27)
        Me.tbpword.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password"
        '
        'tbuname
        '
        Me.tbuname.BackColor = System.Drawing.Color.Cornsilk
        Me.tbuname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbuname.Location = New System.Drawing.Point(26, 40)
        Me.tbuname.Name = "tbuname"
        Me.tbuname.Size = New System.Drawing.Size(189, 27)
        Me.tbuname.TabIndex = 3
        '
        'Code
        '
        Me.Code.AutoSize = True
        Me.Code.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code.Location = New System.Drawing.Point(24, 21)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(72, 16)
        Me.Code.TabIndex = 2
        Me.Code.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 519)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 438)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 45)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(839, 553)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnloginform)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Menu)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.pnloginform.ResumeLayout(False)
        Me.pnloginform.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiveOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CashieringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ROPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents TimerDate As System.Windows.Forms.Timer
    Friend WithEvents pnloginform As System.Windows.Forms.Panel
    Friend WithEvents tbpword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbuname As System.Windows.Forms.TextBox
    Friend WithEvents Code As System.Windows.Forms.Label
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
