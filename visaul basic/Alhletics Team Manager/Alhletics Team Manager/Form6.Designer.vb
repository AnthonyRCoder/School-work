<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.lstMessage = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMessage
        '
        Me.lstMessage.FormattingEnabled = True
        Me.lstMessage.Location = New System.Drawing.Point(12, 30)
        Me.lstMessage.Name = "lstMessage"
        Me.lstMessage.Size = New System.Drawing.Size(257, 277)
        Me.lstMessage.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(275, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "click here"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 330)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstMessage)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMessage As ListBox
    Friend WithEvents Button1 As Button
End Class
