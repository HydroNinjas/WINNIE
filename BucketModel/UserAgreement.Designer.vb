<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAgreement
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
        Me.AgreBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AgreBtn
        '
        Me.AgreBtn.Location = New System.Drawing.Point(131, 57)
        Me.AgreBtn.Name = "AgreBtn"
        Me.AgreBtn.Size = New System.Drawing.Size(187, 124)
        Me.AgreBtn.TabIndex = 0
        Me.AgreBtn.Text = "AgreBtn"
        Me.AgreBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(307, 163)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(187, 124)
        Me.ExitBtn.TabIndex = 1
        Me.ExitBtn.Text = "ExitBtn"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'UserAgreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.AgreBtn)
        Me.Name = "UserAgreement"
        Me.Text = "UserAgreement"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AgreBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
