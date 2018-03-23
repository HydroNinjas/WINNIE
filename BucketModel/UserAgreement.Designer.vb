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
        Me.WinnieUserPicture = New System.Windows.Forms.PictureBox()
        Me.UserAgreeTxt = New System.Windows.Forms.RichTextBox()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.WinnieUserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AgreBtn
        '
        Me.AgreBtn.Location = New System.Drawing.Point(464, 311)
        Me.AgreBtn.Name = "AgreBtn"
        Me.AgreBtn.Size = New System.Drawing.Size(100, 30)
        Me.AgreBtn.TabIndex = 0
        Me.AgreBtn.Text = "AgreBtn"
        Me.AgreBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(570, 311)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(100, 30)
        Me.ExitBtn.TabIndex = 1
        Me.ExitBtn.Text = "ExitBtn"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'WinnieUserPicture
        '
        Me.WinnieUserPicture.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinnieUserPicture.Location = New System.Drawing.Point(0, 0)
        Me.WinnieUserPicture.Name = "WinnieUserPicture"
        Me.WinnieUserPicture.Size = New System.Drawing.Size(682, 72)
        Me.WinnieUserPicture.TabIndex = 2
        Me.WinnieUserPicture.TabStop = False
        '
        'UserAgreeTxt
        '
        Me.UserAgreeTxt.Location = New System.Drawing.Point(12, 95)
        Me.UserAgreeTxt.Name = "UserAgreeTxt"
        Me.UserAgreeTxt.Size = New System.Drawing.Size(658, 210)
        Me.UserAgreeTxt.TabIndex = 3
        Me.UserAgreeTxt.Text = ""
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Location = New System.Drawing.Point(12, 75)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(115, 17)
        Me.Title.TabIndex = 4
        Me.Title.Text = "User Agreement:"
        '
        'UserAgreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(682, 353)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.UserAgreeTxt)
        Me.Controls.Add(Me.WinnieUserPicture)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.AgreBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UserAgreement"
        Me.Text = "User Agreement"
        CType(Me.WinnieUserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AgreBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents WinnieUserPicture As PictureBox
    Friend WithEvents UserAgreeTxt As RichTextBox
    Friend WithEvents Title As Label
End Class
