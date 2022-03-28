<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateSupplierView
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_add_supplier_companyregistration = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox_Supplier_add_cash = New System.Windows.Forms.TextBox()
        Me.TextBox_add_supplier_companyname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_add_supplier_address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_add_supplier_telephone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_supplier_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtbx_supplier_update = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGV_Supplier_Update = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.DGV_Supplier_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 515)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.TextBox_add_supplier_companyregistration)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox_Supplier_add_cash)
        Me.GroupBox1.Controls.Add(Me.TextBox_add_supplier_companyname)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox_add_supplier_address)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox_add_supplier_telephone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_supplier_ID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(599, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 515)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Detail"
        '
        'TextBox_add_supplier_companyregistration
        '
        Me.TextBox_add_supplier_companyregistration.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_add_supplier_companyregistration.Location = New System.Drawing.Point(137, 77)
        Me.TextBox_add_supplier_companyregistration.Name = "TextBox_add_supplier_companyregistration"
        Me.TextBox_add_supplier_companyregistration.Size = New System.Drawing.Size(341, 25)
        Me.TextBox_add_supplier_companyregistration.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(137, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 25)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox_Supplier_add_cash
        '
        Me.TextBox_Supplier_add_cash.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_Supplier_add_cash.Location = New System.Drawing.Point(137, 252)
        Me.TextBox_Supplier_add_cash.Name = "TextBox_Supplier_add_cash"
        Me.TextBox_Supplier_add_cash.Size = New System.Drawing.Size(278, 25)
        Me.TextBox_Supplier_add_cash.TabIndex = 32
        '
        'TextBox_add_supplier_companyname
        '
        Me.TextBox_add_supplier_companyname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_add_supplier_companyname.Location = New System.Drawing.Point(137, 108)
        Me.TextBox_add_supplier_companyname.Multiline = True
        Me.TextBox_add_supplier_companyname.Name = "TextBox_add_supplier_companyname"
        Me.TextBox_add_supplier_companyname.Size = New System.Drawing.Size(341, 48)
        Me.TextBox_add_supplier_companyname.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Credit  : "
        '
        'TextBox_add_supplier_address
        '
        Me.TextBox_add_supplier_address.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_add_supplier_address.Location = New System.Drawing.Point(137, 162)
        Me.TextBox_add_supplier_address.Multiline = True
        Me.TextBox_add_supplier_address.Name = "TextBox_add_supplier_address"
        Me.TextBox_add_supplier_address.Size = New System.Drawing.Size(341, 50)
        Me.TextBox_add_supplier_address.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Company ID :"
        '
        'TextBox_add_supplier_telephone
        '
        Me.TextBox_add_supplier_telephone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_add_supplier_telephone.Location = New System.Drawing.Point(137, 218)
        Me.TextBox_add_supplier_telephone.Name = "TextBox_add_supplier_telephone"
        Me.TextBox_add_supplier_telephone.Size = New System.Drawing.Size(278, 25)
        Me.TextBox_add_supplier_telephone.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Telephone :"
        '
        'TextBox_supplier_ID
        '
        Me.TextBox_supplier_ID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_supplier_ID.Location = New System.Drawing.Point(137, 46)
        Me.TextBox_supplier_ID.Name = "TextBox_supplier_ID"
        Me.TextBox_supplier_ID.Size = New System.Drawing.Size(341, 25)
        Me.TextBox_supplier_ID.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 15)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Company Registration :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Company Name :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.GroupBox11)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.DGV_Supplier_Update)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(598, 528)
        Me.Panel4.TabIndex = 10
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtbx_supplier_update)
        Me.GroupBox11.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(432, 55)
        Me.GroupBox11.TabIndex = 16
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Search by Item Name"
        '
        'txtbx_supplier_update
        '
        Me.txtbx_supplier_update.Location = New System.Drawing.Point(6, 22)
        Me.txtbx_supplier_update.Name = "txtbx_supplier_update"
        Me.txtbx_supplier_update.Size = New System.Drawing.Size(420, 23)
        Me.txtbx_supplier_update.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Update Supplier"
        '
        'DGV_Supplier_Update
        '
        Me.DGV_Supplier_Update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Supplier_Update.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2})
        Me.DGV_Supplier_Update.Location = New System.Drawing.Point(3, 82)
        Me.DGV_Supplier_Update.Name = "DGV_Supplier_Update"
        Me.DGV_Supplier_Update.RowTemplate.Height = 25
        Me.DGV_Supplier_Update.Size = New System.Drawing.Size(590, 430)
        Me.DGV_Supplier_Update.TabIndex = 13
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "buttonColumn"
        Me.Column2.HeaderText = "Update"
        Me.Column2.Name = "Column2"
        '
        'UpdateSupplierView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 515)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UpdateSupplierView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateSupplierView"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.DGV_Supplier_Update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents txtbx_supplier_update As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DGV_Supplier_Update As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox_add_supplier_companyregistration As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox_Supplier_add_cash As TextBox
    Friend WithEvents TextBox_add_supplier_companyname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_add_supplier_address As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_add_supplier_telephone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_supplier_ID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
End Class
