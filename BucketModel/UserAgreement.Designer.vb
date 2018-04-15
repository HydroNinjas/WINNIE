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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAgreement))
        Me.btnAgree = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.UserAgreeTxt = New System.Windows.Forms.RichTextBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.WinnieUserPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.WinnieUserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgree
        '
        Me.btnAgree.Location = New System.Drawing.Point(522, 384)
        Me.btnAgree.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgree.Name = "btnAgree"
        Me.btnAgree.Size = New System.Drawing.Size(112, 38)
        Me.btnAgree.TabIndex = 0
        Me.btnAgree.Text = "Agree"
        Me.btnAgree.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(641, 384)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 38)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'UserAgreeTxt
        '
        Me.UserAgreeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserAgreeTxt.Location = New System.Drawing.Point(14, 153)
        Me.UserAgreeTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UserAgreeTxt.Name = "UserAgreeTxt"
        Me.UserAgreeTxt.ReadOnly = True
        Me.UserAgreeTxt.Size = New System.Drawing.Size(740, 222)
        Me.UserAgreeTxt.TabIndex = 3
        Me.UserAgreeTxt.Text = resources.GetString("UserAgreeTxt.Text")
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Location = New System.Drawing.Point(12, 129)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(130, 20)
        Me.Title.TabIndex = 4
        Me.Title.Text = "User Agreement:"
        '
        'WinnieUserPicture
        '
        Me.WinnieUserPicture.Image = Global.WINNIE.My.Resources.Resources.banner
        Me.WinnieUserPicture.Location = New System.Drawing.Point(0, 0)
        Me.WinnieUserPicture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WinnieUserPicture.Name = "WinnieUserPicture"
        Me.WinnieUserPicture.Size = New System.Drawing.Size(397, 125)
        Me.WinnieUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WinnieUserPicture.TabIndex = 2
        Me.WinnieUserPicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WINNIE.My.Resources.Resources.banner
        Me.PictureBox1.Location = New System.Drawing.Point(390, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(376, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'UserAgreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(767, 436)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.UserAgreeTxt)
        Me.Controls.Add(Me.WinnieUserPicture)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAgree)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "UserAgreement"
        Me.Text = "User Agreement"
        CType(Me.WinnieUserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgree As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents UserAgreeTxt As RichTextBox
    Friend WithEvents Title As Label
    Friend WithEvents WinnieUserPicture As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
