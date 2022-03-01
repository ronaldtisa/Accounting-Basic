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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AutoDbName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Company Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(532, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "You did not have any Database. Enter your detail to make one."
        '
        'CompanyName
        '
        Me.CompanyName.Location = New System.Drawing.Point(12, 71)
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.Size = New System.Drawing.Size(502, 23)
        Me.CompanyName.TabIndex = 2
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"RM - Ringgit Malaysia"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 164)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(502, 112)
        Me.CheckedListBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Currency :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "This program Uses SQLITE for its database books."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AutoDbName
        '
        Me.AutoDbName.Location = New System.Drawing.Point(12, 120)
        Me.AutoDbName.Name = "AutoDbName"
        Me.AutoDbName.Size = New System.Drawing.Size(178, 23)
        Me.AutoDbName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Database will automatically named as below :"
        '
        'DatabaseMake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AutoDbName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.CompanyName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DatabaseMake"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CompanyName As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AutoDbName As TextBox
    Friend WithEvents Label5 As Label
End Class
