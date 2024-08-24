<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ts_Transaction = New System.Windows.Forms.ToolStripButton()
        Me.ts_StockMaster = New System.Windows.Forms.ToolStripButton()
        Me.ts_Customer = New System.Windows.Forms.ToolStripButton()
        Me.ts_Suplier = New System.Windows.Forms.ToolStripButton()
        Me.ts_ManageUser = New System.Windows.Forms.ToolStripButton()
        Me.ts_Setting = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Login = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1028, 102)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema Inventario -  III BTP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Transaction, Me.ts_StockMaster, Me.ts_Customer, Me.ts_Suplier, Me.ts_ManageUser, Me.ts_Setting, Me.ToolStripSeparator1, Me.ts_Login, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 102)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1028, 52)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ts_Transaction
        '
        Me.ts_Transaction.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_Transaction.Image = Global.InventoryManagementSystem.My.Resources.Resources.transacciones
        Me.ts_Transaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Transaction.Name = "ts_Transaction"
        Me.ts_Transaction.Size = New System.Drawing.Size(104, 49)
        Me.ts_Transaction.Text = "TRANSACCIONES"
        Me.ts_Transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_StockMaster
        '
        Me.ts_StockMaster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_StockMaster.Image = Global.InventoryManagementSystem.My.Resources.Resources.productos
        Me.ts_StockMaster.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_StockMaster.Name = "ts_StockMaster"
        Me.ts_StockMaster.Size = New System.Drawing.Size(126, 49)
        Me.ts_StockMaster.Text = "ADMINISTRAR STOCK"
        Me.ts_StockMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Customer
        '
        Me.ts_Customer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_Customer.Image = Global.InventoryManagementSystem.My.Resources.Resources.clientes
        Me.ts_Customer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Customer.Name = "ts_Customer"
        Me.ts_Customer.Size = New System.Drawing.Size(61, 49)
        Me.ts_Customer.Text = "CLIENTES"
        Me.ts_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Suplier
        '
        Me.ts_Suplier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_Suplier.Image = Global.InventoryManagementSystem.My.Resources.Resources.proveedor
        Me.ts_Suplier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Suplier.Name = "ts_Suplier"
        Me.ts_Suplier.Size = New System.Drawing.Size(91, 49)
        Me.ts_Suplier.Text = "PROVEEDORES"
        Me.ts_Suplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_ManageUser
        '
        Me.ts_ManageUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_ManageUser.Image = Global.InventoryManagementSystem.My.Resources.Resources.user
        Me.ts_ManageUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_ManageUser.Name = "ts_ManageUser"
        Me.ts_ManageUser.Size = New System.Drawing.Size(66, 49)
        Me.ts_ManageUser.Text = "USUARIOS"
        Me.ts_ManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Setting
        '
        Me.ts_Setting.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_Setting.Image = Global.InventoryManagementSystem.My.Resources.Resources.categorias
        Me.ts_Setting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Setting.Name = "ts_Setting"
        Me.ts_Setting.Size = New System.Drawing.Size(80, 49)
        Me.ts_Setting.Text = "CATEGORIAS"
        Me.ts_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'ts_Login
        '
        Me.ts_Login.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_Login.Image = Global.InventoryManagementSystem.My.Resources.Resources.candado__2_
        Me.ts_Login.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Login.Name = "ts_Login"
        Me.ts_Login.Size = New System.Drawing.Size(94, 49)
        Me.ts_Login.Text = "INICIAR SESIÓN"
        Me.ts_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.InventoryManagementSystem.My.Resources.Resources.creditos
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(63, 49)
        Me.ToolStripButton1.Text = "CREDITOS"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.InventoryManagementSystem.My.Resources.Resources.logo_inventario
        Me.PictureBox2.ErrorImage = Global.InventoryManagementSystem.My.Resources.Resources.logo_inventario
        Me.PictureBox2.Image = Global.InventoryManagementSystem.My.Resources.Resources.logo_inventario
        Me.PictureBox2.InitialImage = Global.InventoryManagementSystem.My.Resources.Resources.logo_inventario
        Me.PictureBox2.Location = New System.Drawing.Point(23, 9)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 81)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ts_Transaction As ToolStripButton
    Friend WithEvents ts_StockMaster As ToolStripButton
    Friend WithEvents ts_Suplier As ToolStripButton
    Friend WithEvents ts_ManageUser As ToolStripButton
    Friend WithEvents ts_Setting As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ts_Login As ToolStripButton
    Friend WithEvents ts_Customer As ToolStripButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
