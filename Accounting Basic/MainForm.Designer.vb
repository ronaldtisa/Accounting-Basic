<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Inventory = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid_Main_Inventory = New System.Windows.Forms.DataGridView()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button_Delete_Item_Record = New System.Windows.Forms.Button()
        Me.Button_Add_Item_Form = New System.Windows.Forms.Button()
        Me.Button_Update_Item = New System.Windows.Forms.Button()
        Me.supplier = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGrid_Main_Supplier = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Supplier_add_supplier = New System.Windows.Forms.Button()
        Me.report = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2_registration_no = New System.Windows.Forms.TextBox()
        Me.TextBox1_mycompanyname = New System.Windows.Forms.TextBox()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Time_stat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Company_Main_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Registration_supplier_main = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.Inventory.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid_Main_Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.supplier.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid_Main_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.report.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Inventory)
        Me.TabControl1.Controls.Add(Me.supplier)
        Me.TabControl1.Controls.Add(Me.report)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(6, 5)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(934, 517)
        Me.TabControl1.TabIndex = 4
        '
        'Inventory
        '
        Me.Inventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Inventory.Controls.Add(Me.GroupBox1)
        Me.Inventory.Location = New System.Drawing.Point(4, 28)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Padding = New System.Windows.Forms.Padding(3)
        Me.Inventory.Size = New System.Drawing.Size(926, 485)
        Me.Inventory.TabIndex = 1
        Me.Inventory.Text = "Inventory Control"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.DataGrid_Main_Inventory)
        Me.GroupBox1.Controls.Add(Me.GroupBox14)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 479)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INVENTORY"
        '
        'DataGrid_Main_Inventory
        '
        Me.DataGrid_Main_Inventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid_Main_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_Main_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Main_Inventory.Location = New System.Drawing.Point(6, 84)
        Me.DataGrid_Main_Inventory.Name = "DataGrid_Main_Inventory"
        Me.DataGrid_Main_Inventory.RowTemplate.Height = 25
        Me.DataGrid_Main_Inventory.Size = New System.Drawing.Size(908, 389)
        Me.DataGrid_Main_Inventory.TabIndex = 0
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Button5)
        Me.GroupBox14.Controls.Add(Me.Button_Delete_Item_Record)
        Me.GroupBox14.Controls.Add(Me.Button_Add_Item_Form)
        Me.GroupBox14.Controls.Add(Me.Button_Update_Item)
        Me.GroupBox14.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox14.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(908, 57)
        Me.GroupBox14.TabIndex = 15
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Control"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Location = New System.Drawing.Point(795, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 34)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Refresh Record"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button_Delete_Item_Record
        '
        Me.Button_Delete_Item_Record.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Delete_Item_Record.Location = New System.Drawing.Point(257, 17)
        Me.Button_Delete_Item_Record.Name = "Button_Delete_Item_Record"
        Me.Button_Delete_Item_Record.Size = New System.Drawing.Size(107, 34)
        Me.Button_Delete_Item_Record.TabIndex = 7
        Me.Button_Delete_Item_Record.Text = "Delete Item Record"
        Me.Button_Delete_Item_Record.UseVisualStyleBackColor = False
        '
        'Button_Add_Item_Form
        '
        Me.Button_Add_Item_Form.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Add_Item_Form.Location = New System.Drawing.Point(6, 17)
        Me.Button_Add_Item_Form.Name = "Button_Add_Item_Form"
        Me.Button_Add_Item_Form.Size = New System.Drawing.Size(107, 34)
        Me.Button_Add_Item_Form.TabIndex = 2
        Me.Button_Add_Item_Form.Text = "Add Item Form"
        Me.Button_Add_Item_Form.UseVisualStyleBackColor = False
        '
        'Button_Update_Item
        '
        Me.Button_Update_Item.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Update_Item.Location = New System.Drawing.Point(137, 17)
        Me.Button_Update_Item.Name = "Button_Update_Item"
        Me.Button_Update_Item.Size = New System.Drawing.Size(105, 34)
        Me.Button_Update_Item.TabIndex = 6
        Me.Button_Update_Item.Text = "Update Item Detail"
        Me.Button_Update_Item.UseVisualStyleBackColor = False
        '
        'supplier
        '
        Me.supplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.supplier.Controls.Add(Me.GroupBox2)
        Me.supplier.Location = New System.Drawing.Point(4, 28)
        Me.supplier.Name = "supplier"
        Me.supplier.Padding = New System.Windows.Forms.Padding(3)
        Me.supplier.Size = New System.Drawing.Size(926, 485)
        Me.supplier.TabIndex = 2
        Me.supplier.Text = "Supplier Control"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.DataGrid_Main_Supplier)
        Me.GroupBox2.Controls.Add(Me.GroupBox13)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 479)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SUPPLIER"
        '
        'DataGrid_Main_Supplier
        '
        Me.DataGrid_Main_Supplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid_Main_Supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid_Main_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Main_Supplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column5, Me.Column7, Me.address})
        Me.DataGrid_Main_Supplier.Location = New System.Drawing.Point(6, 84)
        Me.DataGrid_Main_Supplier.Name = "DataGrid_Main_Supplier"
        Me.DataGrid_Main_Supplier.RowTemplate.Height = 25
        Me.DataGrid_Main_Supplier.Size = New System.Drawing.Size(911, 389)
        Me.DataGrid_Main_Supplier.TabIndex = 0
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Company_Id"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.FillWeight = 67.75491!
        Me.Column3.HeaderText = "Company ID"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "CompanyName"
        Me.Column5.FillWeight = 66.3998!
        Me.Column5.HeaderText = "Company Name"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "CompanyTelephone"
        Me.Column7.FillWeight = 66.3998!
        Me.Column7.HeaderText = "Telephone"
        Me.Column7.Name = "Column7"
        '
        'address
        '
        Me.address.DataPropertyName = "CompanyAddress"
        Me.address.FillWeight = 66.3998!
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Button6)
        Me.GroupBox13.Controls.Add(Me.Button3)
        Me.GroupBox13.Controls.Add(Me.Button1)
        Me.GroupBox13.Controls.Add(Me.Supplier_add_supplier)
        Me.GroupBox13.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox13.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(846, 57)
        Me.GroupBox13.TabIndex = 14
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Control"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.Location = New System.Drawing.Point(733, 17)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 34)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Refresh Record"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(256, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 34)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Delete Supplier Detail"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(137, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 34)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Update Supplier Detail"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Supplier_add_supplier
        '
        Me.Supplier_add_supplier.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Supplier_add_supplier.Location = New System.Drawing.Point(6, 17)
        Me.Supplier_add_supplier.Name = "Supplier_add_supplier"
        Me.Supplier_add_supplier.Size = New System.Drawing.Size(107, 34)
        Me.Supplier_add_supplier.TabIndex = 16
        Me.Supplier_add_supplier.Text = "Add Supplier"
        Me.Supplier_add_supplier.UseVisualStyleBackColor = False
        '
        'report
        '
        Me.report.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.report.Controls.Add(Me.GroupBox3)
        Me.report.Location = New System.Drawing.Point(4, 28)
        Me.report.Name = "report"
        Me.report.Padding = New System.Windows.Forms.Padding(3)
        Me.report.Size = New System.Drawing.Size(926, 485)
        Me.report.TabIndex = 3
        Me.report.Text = "Report Control"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(407, 476)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sales Report"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(36, 51)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 32)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Sales"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox12.Controls.Add(Me.Button2)
        Me.GroupBox12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox12.Location = New System.Drawing.Point(940, 426)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(242, 121)
        Me.GroupBox12.TabIndex = 5
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Admin"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(26, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 29)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Update My Company"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.TextBox4)
        Me.GroupBox10.Controls.Add(Me.Label9)
        Me.GroupBox10.Controls.Add(Me.TextBox3)
        Me.GroupBox10.Controls.Add(Me.Label8)
        Me.GroupBox10.Controls.Add(Me.Label1)
        Me.GroupBox10.Controls.Add(Me.TextBox2_registration_no)
        Me.GroupBox10.Controls.Add(Me.TextBox1_mycompanyname)
        Me.GroupBox10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox10.Location = New System.Drawing.Point(940, 56)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(242, 364)
        Me.GroupBox10.TabIndex = 4
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "My Account"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox4.Location = New System.Drawing.Point(6, 250)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(230, 25)
        Me.TextBox4.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(6, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Asset :"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(6, 193)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(230, 25)
        Me.TextBox3.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(6, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Supplier Credit Total :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Registration No :"
        '
        'TextBox2_registration_no
        '
        Me.TextBox2_registration_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2_registration_no.Enabled = False
        Me.TextBox2_registration_no.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2_registration_no.Location = New System.Drawing.Point(6, 131)
        Me.TextBox2_registration_no.Name = "TextBox2_registration_no"
        Me.TextBox2_registration_no.Size = New System.Drawing.Size(230, 25)
        Me.TextBox2_registration_no.TabIndex = 1
        '
        'TextBox1_mycompanyname
        '
        Me.TextBox1_mycompanyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1_mycompanyname.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1_mycompanyname.Enabled = False
        Me.TextBox1_mycompanyname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1_mycompanyname.Location = New System.Drawing.Point(6, 32)
        Me.TextBox1_mycompanyname.Multiline = True
        Me.TextBox1_mycompanyname.Name = "TextBox1_mycompanyname"
        Me.TextBox1_mycompanyname.ReadOnly = True
        Me.TextBox1_mycompanyname.Size = New System.Drawing.Size(230, 57)
        Me.TextBox1_mycompanyname.TabIndex = 0
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1184, 0)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1184, 25)
        Me.ToolStripContainer1.TabIndex = 5
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(208, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Time_stat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 548)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1184, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Time_stat
        '
        Me.Time_stat.BackColor = System.Drawing.Color.Transparent
        Me.Time_stat.Name = "Time_stat"
        Me.Time_stat.Size = New System.Drawing.Size(33, 17)
        Me.Time_stat.Text = "Time"
        '
        'Timer1
        '
        '
        'CompanyName
        '
        Me.CompanyName.DataPropertyName = "CompanyName"
        Me.CompanyName.HeaderText = "Company Name"
        Me.CompanyName.Name = "CompanyName"
        '
        'Company_Main_id
        '
        Me.Company_Main_id.DataPropertyName = "Company_Id"
        Me.Company_Main_id.HeaderText = "Company ID"
        Me.Company_Main_id.Name = "Company_Main_id"
        '
        'Registration_supplier_main
        '
        Me.Registration_supplier_main.DataPropertyName = "Registration"
        Me.Registration_supplier_main.HeaderText = "Registration No."
        Me.Registration_supplier_main.Name = "Registration_supplier_main"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(926, 485)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Point of Sales User"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(920, 479)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SUPPLIER"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(908, 389)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.Button10)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(846, 57)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Control"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button7.Location = New System.Drawing.Point(733, 17)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 34)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Refresh Record"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button8.Location = New System.Drawing.Point(256, 17)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 34)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Delete User Detail"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button9.Location = New System.Drawing.Point(137, 17)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(104, 34)
        Me.Button9.TabIndex = 17
        Me.Button9.Text = "Update User Detail"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button10.Location = New System.Drawing.Point(6, 17)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(107, 34)
        Me.Button10.TabIndex = 16
        Me.Button10.Text = "Add User"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Log_Id"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.FillWeight = 67.75491!
        Me.DataGridViewTextBoxColumn1.HeaderText = "LogIn ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CompanyName"
        Me.DataGridViewTextBoxColumn2.FillWeight = 66.3998!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1184, 570)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.TabControl1.ResumeLayout(False)
        Me.Inventory.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid_Main_Inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.supplier.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid_Main_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.report.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Inventory As TabPage
    Friend WithEvents supplier As TabPage
    Friend WithEvents report As TabPage
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2_registration_no As TextBox
    Friend WithEvents TextBox1_mycompanyname As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Time_stat As ToolStripStatusLabel
    Friend WithEvents CompanyName As DataGridViewTextBoxColumn
    Friend WithEvents Company_Main_id As DataGridViewTextBoxColumn
    Friend WithEvents Registration_supplier_main As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGrid_Main_Inventory As DataGridView
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents Button_Delete_Item_Record As Button
    Friend WithEvents Button_Add_Item_Form As Button
    Friend WithEvents Button_Update_Item As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGrid_Main_Supplier As DataGridView
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Supplier_add_supplier As Button
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Public Property Red As Color
End Class
