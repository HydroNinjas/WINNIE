<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandUseForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LandUse1Btn = New System.Windows.Forms.RadioButton()
        Me.LandUse2Btn = New System.Windows.Forms.RadioButton()
        Me.LandUse3Btn = New System.Windows.Forms.RadioButton()
        Me.LandUse4Btn = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Customsettings = New System.Windows.Forms.GroupBox()
        Me.LandImage = New System.Windows.Forms.PictureBox()
        Me.LUPie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TxtBoxTotal = New System.Windows.Forms.TextBox()
        Me.LFcancelBtn = New System.Windows.Forms.Button()
        Me.LFokBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customsettings.SuspendLayout()
        CType(Me.LandImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUPie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Customsettings)
        Me.GroupBox1.Controls.Add(Me.LandUse4Btn)
        Me.GroupBox1.Controls.Add(Me.LandUse3Btn)
        Me.GroupBox1.Controls.Add(Me.LandUse2Btn)
        Me.GroupBox1.Controls.Add(Me.LandUse1Btn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Land Scenario"
        '
        'LandUse1Btn
        '
        Me.LandUse1Btn.AutoSize = True
        Me.LandUse1Btn.Location = New System.Drawing.Point(6, 21)
        Me.LandUse1Btn.Name = "LandUse1Btn"
        Me.LandUse1Btn.Size = New System.Drawing.Size(115, 21)
        Me.LandUse1Btn.TabIndex = 0
        Me.LandUse1Btn.TabStop = True
        Me.LandUse1Btn.Text = "LandUse1Btn"
        Me.LandUse1Btn.UseVisualStyleBackColor = True
        '
        'LandUse2Btn
        '
        Me.LandUse2Btn.AutoSize = True
        Me.LandUse2Btn.Location = New System.Drawing.Point(6, 48)
        Me.LandUse2Btn.Name = "LandUse2Btn"
        Me.LandUse2Btn.Size = New System.Drawing.Size(115, 21)
        Me.LandUse2Btn.TabIndex = 1
        Me.LandUse2Btn.TabStop = True
        Me.LandUse2Btn.Text = "LandUse2Btn"
        Me.LandUse2Btn.UseVisualStyleBackColor = True
        '
        'LandUse3Btn
        '
        Me.LandUse3Btn.AutoSize = True
        Me.LandUse3Btn.Location = New System.Drawing.Point(6, 75)
        Me.LandUse3Btn.Name = "LandUse3Btn"
        Me.LandUse3Btn.Size = New System.Drawing.Size(115, 21)
        Me.LandUse3Btn.TabIndex = 2
        Me.LandUse3Btn.TabStop = True
        Me.LandUse3Btn.Text = "LandUse3Btn"
        Me.LandUse3Btn.UseVisualStyleBackColor = True
        '
        'LandUse4Btn
        '
        Me.LandUse4Btn.AutoSize = True
        Me.LandUse4Btn.Location = New System.Drawing.Point(6, 102)
        Me.LandUse4Btn.Name = "LandUse4Btn"
        Me.LandUse4Btn.Size = New System.Drawing.Size(115, 21)
        Me.LandUse4Btn.TabIndex = 3
        Me.LandUse4Btn.TabStop = True
        Me.LandUse4Btn.Text = "LandUse4Btn"
        Me.LandUse4Btn.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(15, 33)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(35, 22)
        Me.NumericUpDown1.TabIndex = 4
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(56, 33)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(35, 22)
        Me.NumericUpDown2.TabIndex = 5
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(97, 33)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(35, 22)
        Me.NumericUpDown3.TabIndex = 6
        '
        'Customsettings
        '
        Me.Customsettings.Controls.Add(Me.TxtBoxTotal)
        Me.Customsettings.Controls.Add(Me.NumericUpDown3)
        Me.Customsettings.Controls.Add(Me.NumericUpDown1)
        Me.Customsettings.Controls.Add(Me.NumericUpDown2)
        Me.Customsettings.Location = New System.Drawing.Point(23, 142)
        Me.Customsettings.Name = "Customsettings"
        Me.Customsettings.Size = New System.Drawing.Size(141, 107)
        Me.Customsettings.TabIndex = 4
        Me.Customsettings.TabStop = False
        Me.Customsettings.Text = "Customsettings"
        '
        'LandImage
        '
        Me.LandImage.Location = New System.Drawing.Point(240, 7)
        Me.LandImage.Name = "LandImage"
        Me.LandImage.Size = New System.Drawing.Size(540, 397)
        Me.LandImage.TabIndex = 1
        Me.LandImage.TabStop = False
        '
        'LUPie
        '
        ChartArea1.Name = "ChartArea1"
        Me.LUPie.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.LUPie.Legends.Add(Legend1)
        Me.LUPie.Location = New System.Drawing.Point(221, 176)
        Me.LUPie.Name = "LUPie"
        Me.LUPie.Size = New System.Drawing.Size(217, 175)
        Me.LUPie.TabIndex = 2
        Me.LUPie.Text = "LUPie"
        '
        'TxtBoxTotal
        '
        Me.TxtBoxTotal.Location = New System.Drawing.Point(67, 72)
        Me.TxtBoxTotal.Name = "TxtBoxTotal"
        Me.TxtBoxTotal.Size = New System.Drawing.Size(64, 22)
        Me.TxtBoxTotal.TabIndex = 7
        '
        'LFcancelBtn
        '
        Me.LFcancelBtn.Location = New System.Drawing.Point(43, 371)
        Me.LFcancelBtn.Name = "LFcancelBtn"
        Me.LFcancelBtn.Size = New System.Drawing.Size(133, 42)
        Me.LFcancelBtn.TabIndex = 3
        Me.LFcancelBtn.Text = "LFcancelBtn"
        Me.LFcancelBtn.UseVisualStyleBackColor = True
        '
        'LFokBtn
        '
        Me.LFokBtn.Location = New System.Drawing.Point(43, 323)
        Me.LFokBtn.Name = "LFokBtn"
        Me.LFokBtn.Size = New System.Drawing.Size(133, 42)
        Me.LFokBtn.TabIndex = 4
        Me.LFokBtn.Text = "LFokBtn"
        Me.LFokBtn.UseVisualStyleBackColor = True
        '
        'LandUseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LFokBtn)
        Me.Controls.Add(Me.LFcancelBtn)
        Me.Controls.Add(Me.LUPie)
        Me.Controls.Add(Me.LandImage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LandUseForm"
        Me.Text = "LandUseForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customsettings.ResumeLayout(False)
        Me.Customsettings.PerformLayout()
        CType(Me.LandImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUPie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LandUse4Btn As RadioButton
    Friend WithEvents LandUse3Btn As RadioButton
    Friend WithEvents LandUse2Btn As RadioButton
    Friend WithEvents LandUse1Btn As RadioButton
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Customsettings As GroupBox
    Friend WithEvents LandImage As PictureBox
    Friend WithEvents LUPie As DataVisualization.Charting.Chart
    Friend WithEvents TxtBoxTotal As TextBox
    Friend WithEvents LFcancelBtn As Button
    Friend WithEvents LFokBtn As Button
End Class
