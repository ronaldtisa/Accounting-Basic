<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseMake
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CompanyName = New System.Windows.Forms.TextBox()
        Me.Currency_List = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Save_Detail_Button = New System.Windows.Forms.Button()
        Me.AutoDbName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Registration = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Telephone = New System.Windows.Forms.TextBox()
        Me.TextBox_Tax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Company Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(251, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your detail"
        '
        'CompanyName
        '
        Me.CompanyName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompanyName.Location = New System.Drawing.Point(12, 146)
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.Size = New System.Drawing.Size(635, 23)
        Me.CompanyName.TabIndex = 2
        '
        'Currency_List
        '
        Me.Currency_List.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Currency_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Currency_List.CheckOnClick = True
        Me.Currency_List.FormattingEnabled = True
        Me.Currency_List.Location = New System.Drawing.Point(13, 386)
        Me.Currency_List.Name = "Currency_List"
        Me.Currency_List.Size = New System.Drawing.Size(303, 146)
        Me.Currency_List.TabIndex = 6
        Me.Currency_List.ThreeDCheckBoxes = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Currency :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 568)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "This program Uses SQLITE for its database books."
        '
        'Save_Detail_Button
        '
        Me.Save_Detail_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Save_Detail_Button.Location = New System.Drawing.Point(560, 558)
        Me.Save_Detail_Button.Name = "Save_Detail_Button"
        Me.Save_Detail_Button.Size = New System.Drawing.Size(88, 35)
        Me.Save_Detail_Button.TabIndex = 7
        Me.Save_Detail_Button.Text = "Save Detail"
        Me.Save_Detail_Button.UseVisualStyleBackColor = True
        '
        'AutoDbName
        '
        Me.AutoDbName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AutoDbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AutoDbName.Location = New System.Drawing.Point(471, 82)
        Me.AutoDbName.Name = "AutoDbName"
        Me.AutoDbName.ReadOnly = True
        Me.AutoDbName.Size = New System.Drawing.Size(177, 23)
        Me.AutoDbName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(471, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID : Auto Generated"
        '
        'TextBox_Registration
        '
        Me.TextBox_Registration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Registration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Registration.Location = New System.Drawing.Point(12, 82)
        Me.TextBox_Registration.Name = "TextBox_Registration"
        Me.TextBox_Registration.Size = New System.Drawing.Size(370, 23)
        Me.TextBox_Registration.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(13, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Registration No. :"
        '
        'Address
        '
        Me.Address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Address.Location = New System.Drawing.Point(13, 216)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(635, 74)
        Me.Address.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(13, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Company Address :"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(13, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = " Company Telephone :"
        '
        'TextBox_Telephone
        '
        Me.TextBox_Telephone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Telephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Telephone.Location = New System.Drawing.Point(13, 330)
        Me.TextBox_Telephone.Name = "TextBox_Telephone"
        Me.TextBox_Telephone.Size = New System.Drawing.Size(226, 23)
        Me.TextBox_Telephone.TabIndex = 4
        '
        'TextBox_Tax
        '
        Me.TextBox_Tax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Tax.Location = New System.Drawing.Point(470, 330)
        Me.TextBox_Tax.Name = "TextBox_Tax"
        Me.TextBox_Tax.Size = New System.Drawing.Size(177, 23)
        Me.TextBox_Tax.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(471, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Tax Percentage :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(283, 568)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Use Tab key to navigate next text box"
        '
        'DatabaseMake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(671, 599)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AutoDbName)
        Me.Controls.Add(Me.Save_Detail_Button)
        Me.Controls.Add(Me.TextBox_Tax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Currency_List)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompanyName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Registration)
        Me.Controls.Add(Me.TextBox_Telephone)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DatabaseMake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CompanyName As TextBox
    Friend WithEvents Currency_List As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Save_Detail_Button As Button
    Friend WithEvents AutoDbName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Registration As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_Telephone As TextBox
    Friend WithEvents TextBox_Tax As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
