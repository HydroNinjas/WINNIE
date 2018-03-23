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
        Me.LandUse5Btn = New System.Windows.Forms.RadioButton()
        Me.Customsettings = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.TxtBoxTotal = New System.Windows.Forms.TextBox()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.LandUse4Btn = New System.Windows.Forms.RadioButton()
        Me.LandUse3Btn = New System.Windows.Forms.RadioButton()
        Me.LandUse2Btn = New System.Windows.Forms.RadioButton()
        Me.LandUse1Btn = New System.Windows.Forms.RadioButton()
        Me.LandImage = New System.Windows.Forms.PictureBox()
        Me.LUPie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LFcancelBtn = New System.Windows.Forms.Button()
        Me.LFokBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Customsettings.SuspendLayout()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LandImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUPie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LandUse5Btn)
        Me.GroupBox1.Controls.Add(Me.Customsettings)
        Me.GroupBox1.Controls.Add(Me.LandUse4Btn)
        Me.GroupBox1.Controls.Add(Me.LandUse3Btn)
        Me.GroupBox1.Controls.Add(Me.LandUse2Btn)
        Me.GroupBox1.Controls.Add(Me.LandUse1Btn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1617, 753)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Land Scenario"
        '
        'LandUse5Btn
        '
        Me.LandUse5Btn.AutoSize = True
        Me.LandUse5Btn.Location = New System.Drawing.Point(6, 21)
        Me.LandUse5Btn.Name = "LandUse5Btn"
        Me.LandUse5Btn.Size = New System.Drawing.Size(76, 21)
        Me.LandUse5Btn.TabIndex = 5
        Me.LandUse5Btn.TabStop = True
        Me.LandUse5Btn.Text = "Current"
        Me.LandUse5Btn.UseVisualStyleBackColor = True
        '
        'Customsettings
        '
        Me.Customsettings.Controls.Add(Me.Label6)
        Me.Customsettings.Controls.Add(Me.Label5)
        Me.Customsettings.Controls.Add(Me.Label4)
        Me.Customsettings.Controls.Add(Me.Label3)
        Me.Customsettings.Controls.Add(Me.Label2)
        Me.Customsettings.Controls.Add(Me.Label1)
        Me.Customsettings.Controls.Add(Me.NumericUpDown5)
        Me.Customsettings.Controls.Add(Me.NumericUpDown4)
        Me.Customsettings.Controls.Add(Me.TxtBoxTotal)
        Me.Customsettings.Controls.Add(Me.NumericUpDown3)
        Me.Customsettings.Controls.Add(Me.NumericUpDown1)
        Me.Customsettings.Controls.Add(Me.NumericUpDown2)
        Me.Customsettings.Location = New System.Drawing.Point(6, 156)
        Me.Customsettings.Name = "Customsettings"
        Me.Customsettings.Size = New System.Drawing.Size(411, 414)
        Me.Customsettings.TabIndex = 4
        Me.Customsettings.TabStop = False
        Me.Customsettings.Text = "Custom settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Moorland"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Bare Rock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Grassland"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Arable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Forest"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(6, 133)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(45, 22)
        Me.NumericUpDown5.TabIndex = 9
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(6, 21)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(45, 22)
        Me.NumericUpDown4.TabIndex = 8
        '
        'TxtBoxTotal
        '
        Me.TxtBoxTotal.Location = New System.Drawing.Point(52, 163)
        Me.TxtBoxTotal.Name = "TxtBoxTotal"
        Me.TxtBoxTotal.Size = New System.Drawing.Size(64, 22)
        Me.TxtBoxTotal.TabIndex = 7
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(6, 77)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(45, 22)
        Me.NumericUpDown3.TabIndex = 6
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 49)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(45, 22)
        Me.NumericUpDown1.TabIndex = 4
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(6, 105)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(45, 22)
        Me.NumericUpDown2.TabIndex = 5
        '
        'LandUse4Btn
        '
        Me.LandUse4Btn.AutoSize = True
        Me.LandUse4Btn.Location = New System.Drawing.Point(6, 129)
        Me.LandUse4Btn.Name = "LandUse4Btn"
        Me.LandUse4Btn.Size = New System.Drawing.Size(76, 21)
        Me.LandUse4Btn.TabIndex = 3
        Me.LandUse4Btn.TabStop = True
        Me.LandUse4Btn.Text = "Custom"
        Me.LandUse4Btn.UseVisualStyleBackColor = True
        '
        'LandUse3Btn
        '
        Me.LandUse3Btn.AutoSize = True
        Me.LandUse3Btn.Location = New System.Drawing.Point(6, 102)
        Me.LandUse3Btn.Name = "LandUse3Btn"
        Me.LandUse3Btn.Size = New System.Drawing.Size(90, 21)
        Me.LandUse3Btn.TabIndex = 2
        Me.LandUse3Btn.TabStop = True
        Me.LandUse3Btn.Text = "Change 3"
        Me.LandUse3Btn.UseVisualStyleBackColor = True
        '
        'LandUse2Btn
        '
        Me.LandUse2Btn.AutoSize = True
        Me.LandUse2Btn.Location = New System.Drawing.Point(6, 75)
        Me.LandUse2Btn.Name = "LandUse2Btn"
        Me.LandUse2Btn.Size = New System.Drawing.Size(90, 21)
        Me.LandUse2Btn.TabIndex = 1
        Me.LandUse2Btn.TabStop = True
        Me.LandUse2Btn.Text = "Change 2"
        Me.LandUse2Btn.UseVisualStyleBackColor = True
        '
        'LandUse1Btn
        '
        Me.LandUse1Btn.AutoSize = True
        Me.LandUse1Btn.Location = New System.Drawing.Point(6, 48)
        Me.LandUse1Btn.Name = "LandUse1Btn"
        Me.LandUse1Btn.Size = New System.Drawing.Size(90, 21)
        Me.LandUse1Btn.TabIndex = 0
        Me.LandUse1Btn.TabStop = True
        Me.LandUse1Btn.Text = "Change 1"
        Me.LandUse1Btn.UseVisualStyleBackColor = True
        '
        'LandImage
        '
        Me.LandImage.Dock = System.Windows.Forms.DockStyle.Right
        Me.LandImage.Location = New System.Drawing.Point(897, 0)
        Me.LandImage.Name = "LandImage"
        Me.LandImage.Size = New System.Drawing.Size(720, 753)
        Me.LandImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LandImage.TabIndex = 1
        Me.LandImage.TabStop = False
        '
        'LUPie
        '
        Me.LUPie.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.LUPie.ChartAreas.Add(ChartArea1)
        Me.LUPie.Dock = System.Windows.Forms.DockStyle.Right
        Legend1.Name = "Legend1"
        Me.LUPie.Legends.Add(Legend1)
        Me.LUPie.Location = New System.Drawing.Point(177, 0)
        Me.LUPie.Name = "LUPie"
        Me.LUPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.LUPie.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(127, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(190, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))}
        Me.LUPie.Size = New System.Drawing.Size(720, 753)
        Me.LUPie.TabIndex = 2
        Me.LUPie.Text = "LUPie"
        '
        'LFcancelBtn
        '
        Me.LFcancelBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LFcancelBtn.Location = New System.Drawing.Point(0, 711)
        Me.LFcancelBtn.Name = "LFcancelBtn"
        Me.LFcancelBtn.Size = New System.Drawing.Size(177, 42)
        Me.LFcancelBtn.TabIndex = 3
        Me.LFcancelBtn.Text = "LFcancelBtn"
        Me.LFcancelBtn.UseVisualStyleBackColor = True
        '
        'LFokBtn
        '
        Me.LFokBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LFokBtn.Location = New System.Drawing.Point(0, 669)
        Me.LFokBtn.Name = "LFokBtn"
        Me.LFokBtn.Size = New System.Drawing.Size(177, 42)
        Me.LFokBtn.TabIndex = 4
        Me.LFokBtn.Text = "LFokBtn"
        Me.LFokBtn.UseVisualStyleBackColor = True
        '
        'LandUseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1617, 753)
        Me.Controls.Add(Me.LFokBtn)
        Me.Controls.Add(Me.LFcancelBtn)
        Me.Controls.Add(Me.LUPie)
        Me.Controls.Add(Me.LandImage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LandUseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Land Use Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Customsettings.ResumeLayout(False)
        Me.Customsettings.PerformLayout()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LUPie As DataVisualization.Charting.Chart
    Friend WithEvents TxtBoxTotal As TextBox
    Friend WithEvents LFcancelBtn As Button
    Friend WithEvents LFokBtn As Button
    Friend WithEvents LandUse5Btn As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents LandImage As PictureBox
End Class
