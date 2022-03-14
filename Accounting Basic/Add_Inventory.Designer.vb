<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Inventory
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxItemId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AddItem_ComboBox_Company_list = New System.Windows.Forms.ComboBox()
        Me.TextBox_Total_Unit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxTelephone = New System.Windows.Forms.TextBox()
        Me.TextBox_Unit_Price = New System.Windows.Forms.TextBox()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.TextBox_ItemName = New System.Windows.Forms.TextBox()
        Me.TextBox_ItemCode = New System.Windows.Forms.TextBox()
        Me.TextBoxtax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(568, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxtax)
        Me.GroupBox1.Controls.Add(Me.TextBoxItemId)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.AddItem_ComboBox_Company_list)
        Me.GroupBox1.Controls.Add(Me.TextBox_Total_Unit)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelephone)
        Me.GroupBox1.Controls.Add(Me.TextBox_Unit_Price)
        Me.GroupBox1.Controls.Add(Me.TextBox_Address)
        Me.GroupBox1.Controls.Add(Me.TextBox_ItemName)
        Me.GroupBox1.Controls.Add(Me.TextBox_ItemCode)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 318)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter New Item Details"
        '
        'TextBoxItemId
        '
        Me.TextBoxItemId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxItemId.Location = New System.Drawing.Point(568, 41)
        Me.TextBoxItemId.Name = "TextBoxItemId"
        Me.TextBoxItemId.Size = New System.Drawing.Size(152, 25)
        Me.TextBoxItemId.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(509, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Item ID :"
        '
        'AddItem_ComboBox_Company_list
        '
        Me.AddItem_ComboBox_Company_list.FormattingEnabled = True
        Me.AddItem_ComboBox_Company_list.Location = New System.Drawing.Point(151, 103)
        Me.AddItem_ComboBox_Company_list.Name = "AddItem_ComboBox_Company_list"
        Me.AddItem_ComboBox_Company_list.Size = New System.Drawing.Size(352, 25)
        Me.AddItem_ComboBox_Company_list.TabIndex = 18
        '
        'TextBox_Total_Unit
        '
        Me.TextBox_Total_Unit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_Total_Unit.Location = New System.Drawing.Point(473, 260)
        Me.TextBox_Total_Unit.Name = "TextBox_Total_Unit"
        Me.TextBox_Total_Unit.Size = New System.Drawing.Size(247, 25)
        Me.TextBox_Total_Unit.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(391, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total Unit : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(509, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Company ID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(391, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Unit Price :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Telephone :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Company Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Item Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Item Code :"
        '
        'TextBoxID
        '
        Me.TextBoxID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxID.Location = New System.Drawing.Point(591, 103)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(129, 25)
        Me.TextBoxID.TabIndex = 8
        '
        'TextBoxTelephone
        '
        Me.TextBoxTelephone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxTelephone.Location = New System.Drawing.Point(151, 229)
        Me.TextBoxTelephone.Name = "TextBoxTelephone"
        Me.TextBoxTelephone.Size = New System.Drawing.Size(206, 25)
        Me.TextBoxTelephone.TabIndex = 7
        '
        'TextBox_Unit_Price
        '
        Me.TextBox_Unit_Price.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_Unit_Price.Location = New System.Drawing.Point(473, 229)
        Me.TextBox_Unit_Price.Name = "TextBox_Unit_Price"
        Me.TextBox_Unit_Price.Size = New System.Drawing.Size(247, 25)
        Me.TextBox_Unit_Price.TabIndex = 6
        '
        'TextBox_Address
        '
        Me.TextBox_Address.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_Address.Location = New System.Drawing.Point(151, 134)
        Me.TextBox_Address.Multiline = True
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.Size = New System.Drawing.Size(569, 89)
        Me.TextBox_Address.TabIndex = 4
        '
        'TextBox_ItemName
        '
        Me.TextBox_ItemName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_ItemName.Location = New System.Drawing.Point(151, 72)
        Me.TextBox_ItemName.Name = "TextBox_ItemName"
        Me.TextBox_ItemName.Size = New System.Drawing.Size(569, 25)
        Me.TextBox_ItemName.TabIndex = 2
        '
        'TextBox_ItemCode
        '
        Me.TextBox_ItemCode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_ItemCode.Location = New System.Drawing.Point(151, 41)
        Me.TextBox_ItemCode.Name = "TextBox_ItemCode"
        Me.TextBox_ItemCode.Size = New System.Drawing.Size(352, 25)
        Me.TextBox_ItemCode.TabIndex = 1
        '
        'TextBoxtax
        '
        Me.TextBoxtax.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxtax.Location = New System.Drawing.Point(151, 260)
        Me.TextBoxtax.Name = "TextBoxtax"
        Me.TextBoxtax.Size = New System.Drawing.Size(206, 25)
        Me.TextBoxtax.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 263)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Tax % :"
        '
        'Add_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 320)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Add_Inventory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_Total_Unit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxTelephone As TextBox
    Friend WithEvents TextBox_Unit_Price As TextBox
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents TextBox_ItemName As TextBox
    Friend WithEvents TextBox_ItemCode As TextBox
    Friend WithEvents AddItem_ComboBox_Company_list As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxItemId As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxtax As TextBox
End Class
