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
        Me.LUPie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LFcancelBtn = New System.Windows.Forms.Button()
        Me.LFokBtn = New System.Windows.Forms.Button()
        Me.LandImage = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Customsettings.SuspendLayout()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUPie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LandImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Controls.Add(Me.LandUse5Btn)
        Me.GroupBox1.Controls.Add(Me.Customsettings)
        Me.GroupBox1.Controls.Add(Me.LandUse4Btn)
        Me.GroupBox1.Controls.Add(Me.LandUse3Btn)
        Me.GroupBox1.Controls.Add(Me.LandUse2Btn)
        Me.GroupBox1.Controls.Add(Me.LandUse1Btn)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 211)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox1, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(239, 447)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scenario"
        '
        'LandUse5Btn
        '
        Me.LandUse5Btn.AutoSize = True
        Me.LandUse5Btn.Location = New System.Drawing.Point(7, 26)
        Me.LandUse5Btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LandUse5Btn.Name = "LandUse5Btn"
        Me.LandUse5Btn.Size = New System.Drawing.Size(87, 24)
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
        Me.Customsettings.Location = New System.Drawing.Point(6, 193)
        Me.Customsettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Customsettings.Name = "Customsettings"
        Me.Customsettings.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Customsettings.Size = New System.Drawing.Size(227, 246)
        Me.Customsettings.TabIndex = 4
        Me.Customsettings.TabStop = False
        Me.Customsettings.Text = "Custom settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "% Moorland"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "% Bare Rock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "% Grassland"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "% Arable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "% Forest"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.DecimalPlaces = 2
        Me.NumericUpDown5.Location = New System.Drawing.Point(7, 166)
        Me.NumericUpDown5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(79, 26)
        Me.NumericUpDown5.TabIndex = 9
        Me.NumericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.DecimalPlaces = 2
        Me.NumericUpDown4.Location = New System.Drawing.Point(7, 26)
        Me.NumericUpDown4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(79, 26)
        Me.NumericUpDown4.TabIndex = 8
        Me.NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtBoxTotal
        '
        Me.TxtBoxTotal.Location = New System.Drawing.Point(58, 204)
        Me.TxtBoxTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtBoxTotal.Name = "TxtBoxTotal"
        Me.TxtBoxTotal.Size = New System.Drawing.Size(72, 26)
        Me.TxtBoxTotal.TabIndex = 7
        Me.TxtBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.DecimalPlaces = 2
        Me.NumericUpDown3.Location = New System.Drawing.Point(7, 96)
        Me.NumericUpDown3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(79, 26)
        Me.NumericUpDown3.TabIndex = 6
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Location = New System.Drawing.Point(7, 61)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(79, 26)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Location = New System.Drawing.Point(7, 131)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(79, 26)
        Me.NumericUpDown2.TabIndex = 5
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LandUse4Btn
        '
        Me.LandUse4Btn.AutoSize = True
        Me.LandUse4Btn.Location = New System.Drawing.Point(7, 161)
        Me.LandUse4Btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LandUse4Btn.Name = "LandUse4Btn"
        Me.LandUse4Btn.Size = New System.Drawing.Size(89, 24)
        Me.LandUse4Btn.TabIndex = 3
        Me.LandUse4Btn.TabStop = True
        Me.LandUse4Btn.Text = "Custom"
        Me.LandUse4Btn.UseVisualStyleBackColor = True
        '
        'LandUse3Btn
        '
        Me.LandUse3Btn.AutoSize = True
        Me.LandUse3Btn.Location = New System.Drawing.Point(7, 128)
        Me.LandUse3Btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LandUse3Btn.Name = "LandUse3Btn"
        Me.LandUse3Btn.Size = New System.Drawing.Size(45, 24)
        Me.LandUse3Btn.TabIndex = 2
        Me.LandUse3Btn.TabStop = True
        Me.LandUse3Btn.Text = "C"
        Me.LandUse3Btn.UseVisualStyleBackColor = True
        '
        'LandUse2Btn
        '
        Me.LandUse2Btn.AutoSize = True
        Me.LandUse2Btn.Location = New System.Drawing.Point(7, 94)
        Me.LandUse2Btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LandUse2Btn.Name = "LandUse2Btn"
        Me.LandUse2Btn.Size = New System.Drawing.Size(45, 24)
        Me.LandUse2Btn.TabIndex = 1
        Me.LandUse2Btn.TabStop = True
        Me.LandUse2Btn.Text = "B"
        Me.LandUse2Btn.UseVisualStyleBackColor = True
        '
        'LandUse1Btn
        '
        Me.LandUse1Btn.AutoSize = True
        Me.LandUse1Btn.Location = New System.Drawing.Point(7, 60)
        Me.LandUse1Btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LandUse1Btn.Name = "LandUse1Btn"
        Me.LandUse1Btn.Size = New System.Drawing.Size(45, 24)
        Me.LandUse1Btn.TabIndex = 0
        Me.LandUse1Btn.TabStop = True
        Me.LandUse1Btn.Text = "A"
        Me.LandUse1Btn.UseVisualStyleBackColor = True
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
        Me.LUPie.Location = New System.Drawing.Point(807, 0)
        Me.LUPie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LUPie.Name = "LUPie"
        Me.LUPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.LUPie.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(127, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(190, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))}
        Me.LUPie.Size = New System.Drawing.Size(506, 941)
        Me.LUPie.TabIndex = 2
        Me.LUPie.Text = "LUPie"
        '
        'LFcancelBtn
        '
        Me.LFcancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LFcancelBtn.Location = New System.Drawing.Point(197, 876)
        Me.LFcancelBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LFcancelBtn.Name = "LFcancelBtn"
        Me.LFcancelBtn.Size = New System.Drawing.Size(169, 50)
        Me.LFcancelBtn.TabIndex = 3
        Me.LFcancelBtn.Text = "Cancel"
        Me.LFcancelBtn.UseVisualStyleBackColor = True
        '
        'LFokBtn
        '
        Me.LFokBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LFokBtn.Location = New System.Drawing.Point(9, 876)
        Me.LFokBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LFokBtn.Name = "LFokBtn"
        Me.LFokBtn.Size = New System.Drawing.Size(169, 50)
        Me.LFokBtn.TabIndex = 4
        Me.LFokBtn.Text = "OK"
        Me.LFokBtn.UseVisualStyleBackColor = True
        '
        'LandImage
        '
        Me.LandImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LandImage.Dock = System.Windows.Forms.DockStyle.Right
        Me.LandImage.Location = New System.Drawing.Point(1313, 0)
        Me.LandImage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LandImage.Name = "LandImage"
        Me.LandImage.Size = New System.Drawing.Size(506, 941)
        Me.LandImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LandImage.TabIndex = 1
        Me.LandImage.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LFokBtn, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LFcancelBtn, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.08522!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07102!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.12638!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.12638!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.12638!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.40779!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.056815!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(376, 941)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.LinkLabel1, 2)
        Me.LinkLabel1.Location = New System.Drawing.Point(142, 150)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 20)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Online Help"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label7, 2)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 40)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "WINNIE version 3.1.4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Land Use Selector"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LandUseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1819, 941)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LUPie)
        Me.Controls.Add(Me.LandImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        CType(Me.LUPie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LandImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
