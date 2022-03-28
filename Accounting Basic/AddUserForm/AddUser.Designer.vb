<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.Button_adduser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.TextBox_fullname = New System.Windows.Forms.TextBox()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_adduser
        '
        Me.Button_adduser.Location = New System.Drawing.Point(448, 164)
        Me.Button_adduser.Name = "Button_adduser"
        Me.Button_adduser.Size = New System.Drawing.Size(75, 23)
        Me.Button_adduser.TabIndex = 0
        Me.Button_adduser.Text = "Add"
        Me.Button_adduser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password :"
        '
        'TextBox_username
        '
        Me.TextBox_username.Location = New System.Drawing.Point(95, 46)
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(428, 23)
        Me.TextBox_username.TabIndex = 4
        '
        'TextBox_fullname
        '
        Me.TextBox_fullname.Location = New System.Drawing.Point(95, 85)
        Me.TextBox_fullname.Name = "TextBox_fullname"
        Me.TextBox_fullname.Size = New System.Drawing.Size(428, 23)
        Me.TextBox_fullname.TabIndex = 5
        '
        'TextBox_password
        '
        Me.TextBox_password.Location = New System.Drawing.Point(95, 125)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.Size = New System.Drawing.Size(428, 23)
        Me.TextBox_password.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(214, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Add New Log In Detail"
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 199)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_password)
        Me.Controls.Add(Me.TextBox_fullname)
        Me.Controls.Add(Me.TextBox_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_adduser)
        Me.Name = "AddUser"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_adduser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents TextBox_fullname As TextBox
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents Label4 As Label
End Class
