﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StockMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_StockMaster))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblinc = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lblmax = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbounit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtdescription = New System.Windows.Forms.RichTextBox()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl_stockmaster = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_stockmaster.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(451, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 30)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(421, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Buscar :"
        '
        'lblinc
        '
        Me.lblinc.AutoSize = True
        Me.lblinc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblinc.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinc.ForeColor = System.Drawing.Color.White
        Me.lblinc.Location = New System.Drawing.Point(16, 257)
        Me.lblinc.Name = "lblinc"
        Me.lblinc.Size = New System.Drawing.Size(13, 16)
        Me.lblinc.TabIndex = 26
        Me.lblinc.Text = "1"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(474, 257)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(263, 20)
        Me.txtsearch.TabIndex = 13
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.Transparent
        Me.btnnew.ForeColor = System.Drawing.Color.Black
        Me.btnnew.Location = New System.Drawing.Point(339, 213)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(106, 30)
        Me.btnnew.TabIndex = 17
        Me.btnnew.Text = "Nuevo"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(38, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "de"
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.Transparent
        Me.btnlast.ForeColor = System.Drawing.Color.Black
        Me.btnlast.Location = New System.Drawing.Point(224, 251)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(39, 30)
        Me.btnlast.TabIndex = 22
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Location = New System.Drawing.Point(229, 213)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(106, 30)
        Me.btndelete.TabIndex = 18
        Me.btndelete.Text = "Eliminar"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Transparent
        Me.btnnext.ForeColor = System.Drawing.Color.Black
        Me.btnnext.Location = New System.Drawing.Point(176, 251)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(39, 30)
        Me.btnnext.TabIndex = 23
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnprev
        '
        Me.btnprev.BackColor = System.Drawing.Color.Transparent
        Me.btnprev.ForeColor = System.Drawing.Color.Black
        Me.btnprev.Location = New System.Drawing.Point(130, 251)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(39, 30)
        Me.btnprev.TabIndex = 24
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.Location = New System.Drawing.Point(120, 213)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(103, 30)
        Me.btnupdate.TabIndex = 19
        Me.btnupdate.Text = "Actualizar"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.Transparent
        Me.btnfirst.ForeColor = System.Drawing.Color.Black
        Me.btnfirst.Location = New System.Drawing.Point(85, 251)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(39, 30)
        Me.btnfirst.TabIndex = 25
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(8, 213)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(106, 30)
        Me.btnsave.TabIndex = 20
        Me.btnsave.Text = "Guardar"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(344, 55)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(142, 25)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lblmax
        '
        Me.lblmax.AutoSize = True
        Me.lblmax.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblmax.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmax.ForeColor = System.Drawing.Color.White
        Me.lblmax.Location = New System.Drawing.Point(65, 257)
        Me.lblmax.Name = "lblmax"
        Me.lblmax.Size = New System.Drawing.Size(13, 16)
        Me.lblmax.TabIndex = 27
        Me.lblmax.Text = "1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dtglist)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Location = New System.Drawing.Point(6, 287)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(735, 269)
        Me.Panel2.TabIndex = 16
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(0, 0)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.RowHeadersWidth = 51
        Me.dtglist.Size = New System.Drawing.Size(733, 267)
        Me.dtglist.TabIndex = 0
        '
        'txtitemid
        '
        Me.txtitemid.Enabled = False
        Me.txtitemid.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemid.Location = New System.Drawing.Point(112, 64)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Size = New System.Drawing.Size(251, 22)
        Me.txtitemid.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(23, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Codigo ::"
        '
        'cbounit
        '
        Me.cbounit.FormattingEnabled = True
        Me.cbounit.Items.AddRange(New Object() {"Piezas", "Kilos", "Libras"})
        Me.cbounit.Location = New System.Drawing.Point(608, 163)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.Size = New System.Drawing.Size(87, 23)
        Me.cbounit.TabIndex = 6
        Me.cbounit.Text = "Unidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(369, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Cantidad ::"
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(445, 164)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(153, 22)
        Me.txtqty.TabIndex = 4
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(111, 128)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(253, 62)
        Me.txtdescription.TabIndex = 3
        Me.txtdescription.Text = ""
        '
        'cbotype
        '
        Me.cbotype.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Location = New System.Drawing.Point(443, 92)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(252, 24)
        Me.cbotype.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(112, 92)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(252, 22)
        Me.txtname.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(369, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Precio ::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(369, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoria ::"
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(445, 129)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(250, 22)
        Me.txtprice.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion ::"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre ::"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(266, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nuevo Producto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_stockmaster
        '
        Me.pnl_stockmaster.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_stockmaster.Controls.Add(Me.txtitemid)
        Me.pnl_stockmaster.Controls.Add(Me.Label8)
        Me.pnl_stockmaster.Controls.Add(Me.cbounit)
        Me.pnl_stockmaster.Controls.Add(Me.Label7)
        Me.pnl_stockmaster.Controls.Add(Me.txtqty)
        Me.pnl_stockmaster.Controls.Add(Me.txtdescription)
        Me.pnl_stockmaster.Controls.Add(Me.cbotype)
        Me.pnl_stockmaster.Controls.Add(Me.txtname)
        Me.pnl_stockmaster.Controls.Add(Me.Label4)
        Me.pnl_stockmaster.Controls.Add(Me.Label3)
        Me.pnl_stockmaster.Controls.Add(Me.txtprice)
        Me.pnl_stockmaster.Controls.Add(Me.Label2)
        Me.pnl_stockmaster.Controls.Add(Me.Label1)
        Me.pnl_stockmaster.Controls.Add(Me.Label5)
        Me.pnl_stockmaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_stockmaster.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_stockmaster.Location = New System.Drawing.Point(0, 0)
        Me.pnl_stockmaster.Name = "pnl_stockmaster"
        Me.pnl_stockmaster.Size = New System.Drawing.Size(747, 287)
        Me.pnl_stockmaster.TabIndex = 14
        '
        'frm_StockMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(747, 581)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblinc)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblmax)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl_stockmaster)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_StockMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Inventario"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_stockmaster.ResumeLayout(False)
        Me.pnl_stockmaster.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblinc As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnnew As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnlast As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnprev As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnfirst As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lblmax As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtitemid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbounit As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents txtdescription As RichTextBox
    Friend WithEvents cbotype As ComboBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnl_stockmaster As Panel
    Friend WithEvents dtglist As DataGridView
End Class
