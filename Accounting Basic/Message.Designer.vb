<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message
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
        Me.ContinueMessage = New System.Windows.Forms.Button()
        Me.CancelMessage = New System.Windows.Forms.Button()
        Me.MessageText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ContinueMessage
        '
        Me.ContinueMessage.Location = New System.Drawing.Point(276, 114)
        Me.ContinueMessage.Name = "ContinueMessage"
        Me.ContinueMessage.Size = New System.Drawing.Size(75, 23)
        Me.ContinueMessage.TabIndex = 0
        Me.ContinueMessage.Text = "Continue"
        Me.ContinueMessage.UseVisualStyleBackColor = True
        '
        'CancelMessage
        '
        Me.CancelMessage.Location = New System.Drawing.Point(357, 114)
        Me.CancelMessage.Name = "CancelMessage"
        Me.CancelMessage.Size = New System.Drawing.Size(75, 23)
        Me.CancelMessage.TabIndex = 1
        Me.CancelMessage.Text = "Cancel"
        Me.CancelMessage.UseVisualStyleBackColor = True
        '
        'MessageText
        '
        Me.MessageText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageText.Location = New System.Drawing.Point(4, 12)
        Me.MessageText.Multiline = True
        Me.MessageText.Name = "MessageText"
        Me.MessageText.Size = New System.Drawing.Size(428, 96)
        Me.MessageText.TabIndex = 2
        '
        'Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 140)
        Me.Controls.Add(Me.MessageText)
        Me.Controls.Add(Me.CancelMessage)
        Me.Controls.Add(Me.ContinueMessage)
        Me.Name = "Message"
        Me.Text = "Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContinueMessage As Button
    Friend WithEvents CancelMessage As Button
    Friend WithEvents MessageText As TextBox
End Class
