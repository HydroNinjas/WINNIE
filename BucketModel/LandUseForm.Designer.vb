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
        Me.btnCurrent = New System.Windows.Forms.RadioButton()
        Me.Customsettings = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.spnMoorland = New System.Windows.Forms.NumericUpDown()
        Me.spnBareRock = New System.Windows.Forms.NumericUpDown()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.spnGrassland = New System.Windows.Forms.NumericUpDown()
        Me.spnForest = New System.Windows.Forms.NumericUpDown()
        Me.spnArable = New System.Windows.Forms.NumericUpDown()
        Me.btnCustom = New System.Windows.Forms.RadioButton()
        Me.btnScenarioC = New System.Windows.Forms.RadioButton()
        Me.btnScenarioB = New System.Windows.Forms.RadioButton()
        Me.btnScenarioA = New System.Windows.Forms.RadioButton()
        Me.graProps = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.imgMap = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lnkHelp = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Customsettings.SuspendLayout()
        CType(Me.spnMoorland, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnBareRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnGrassland, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnForest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnArable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.graProps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Controls.Add(Me.btnCurrent)
        Me.GroupBox1.Controls.Add(Me.Customsettings)
        Me.GroupBox1.Controls.Add(Me.btnCustom)
        Me.GroupBox1.Controls.Add(Me.btnScenarioC)
        Me.GroupBox1.Controls.Add(Me.btnScenarioB)
        Me.GroupBox1.Controls.Add(Me.btnScenarioA)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox1, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(212, 358)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scenario"
        '
        'btnCurrent
        '
        Me.btnCurrent.AutoSize = True
        Me.btnCurrent.Location = New System.Drawing.Point(6, 21)
        Me.btnCurrent.Name = "btnCurrent"
        Me.btnCurrent.Size = New System.Drawing.Size(76, 21)
        Me.btnCurrent.TabIndex = 0
        Me.btnCurrent.TabStop = True
        Me.btnCurrent.Text = "Current"
        Me.btnCurrent.UseVisualStyleBackColor = True
        '
        'Customsettings
        '
        Me.Customsettings.Controls.Add(Me.Label6)
        Me.Customsettings.Controls.Add(Me.Label5)
        Me.Customsettings.Controls.Add(Me.Label4)
        Me.Customsettings.Controls.Add(Me.Label3)
        Me.Customsettings.Controls.Add(Me.Label2)
        Me.Customsettings.Controls.Add(Me.Label1)
        Me.Customsettings.Controls.Add(Me.spnMoorland)
        Me.Customsettings.Controls.Add(Me.spnBareRock)
        Me.Customsettings.Controls.Add(Me.txtTotal)
        Me.Customsettings.Controls.Add(Me.spnGrassland)
        Me.Customsettings.Controls.Add(Me.spnForest)
        Me.Customsettings.Controls.Add(Me.spnArable)
        Me.Customsettings.Location = New System.Drawing.Point(5, 154)
        Me.Customsettings.Name = "Customsettings"
        Me.Customsettings.Size = New System.Drawing.Size(202, 197)
        Me.Customsettings.TabIndex = 5
        Me.Customsettings.TabStop = False
        Me.Customsettings.Text = "Custom settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "% Moorland"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "% Bare Rock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "% Grassland"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "% Arable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "% Forest"
        '
        'spnMoorland
        '
        Me.spnMoorland.DecimalPlaces = 2
        Me.spnMoorland.Location = New System.Drawing.Point(6, 133)
        Me.spnMoorland.Name = "spnMoorland"
        Me.spnMoorland.Size = New System.Drawing.Size(70, 22)
        Me.spnMoorland.TabIndex = 4
        Me.spnMoorland.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnMoorland.Value = New Decimal(New Integer() {418, 0, 0, 131072})
        '
        'spnBareRock
        '
        Me.spnBareRock.DecimalPlaces = 2
        Me.spnBareRock.Location = New System.Drawing.Point(6, 21)
        Me.spnBareRock.Name = "spnBareRock"
        Me.spnBareRock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.spnBareRock.Size = New System.Drawing.Size(70, 22)
        Me.spnBareRock.TabIndex = 0
        Me.spnBareRock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnBareRock.Value = New Decimal(New Integer() {415, 0, 0, 131072})
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(52, 163)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(64, 22)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'spnGrassland
        '
        Me.spnGrassland.DecimalPlaces = 2
        Me.spnGrassland.Location = New System.Drawing.Point(6, 77)
        Me.spnGrassland.Name = "spnGrassland"
        Me.spnGrassland.Size = New System.Drawing.Size(70, 22)
        Me.spnGrassland.TabIndex = 2
        Me.spnGrassland.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnGrassland.Value = New Decimal(New Integer() {3773, 0, 0, 131072})
        '
        'spnForest
        '
        Me.spnForest.DecimalPlaces = 2
        Me.spnForest.Location = New System.Drawing.Point(6, 49)
        Me.spnForest.Name = "spnForest"
        Me.spnForest.Size = New System.Drawing.Size(70, 22)
        Me.spnForest.TabIndex = 1
        Me.spnForest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnForest.Value = New Decimal(New Integer() {1811, 0, 0, 131072})
        '
        'spnArable
        '
        Me.spnArable.DecimalPlaces = 2
        Me.spnArable.Location = New System.Drawing.Point(6, 105)
        Me.spnArable.Name = "spnArable"
        Me.spnArable.Size = New System.Drawing.Size(70, 22)
        Me.spnArable.TabIndex = 3
        Me.spnArable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnArable.Value = New Decimal(New Integer() {3583, 0, 0, 131072})
        '
        'btnCustom
        '
        Me.btnCustom.AutoSize = True
        Me.btnCustom.Location = New System.Drawing.Point(6, 129)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(76, 21)
        Me.btnCustom.TabIndex = 4
        Me.btnCustom.TabStop = True
        Me.btnCustom.Text = "Custom"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'btnScenarioC
        '
        Me.btnScenarioC.AutoSize = True
        Me.btnScenarioC.Location = New System.Drawing.Point(6, 102)
        Me.btnScenarioC.Name = "btnScenarioC"
        Me.btnScenarioC.Size = New System.Drawing.Size(38, 21)
        Me.btnScenarioC.TabIndex = 3
        Me.btnScenarioC.TabStop = True
        Me.btnScenarioC.Text = "C"
        Me.btnScenarioC.UseVisualStyleBackColor = True
        '
        'btnScenarioB
        '
        Me.btnScenarioB.AutoSize = True
        Me.btnScenarioB.Location = New System.Drawing.Point(6, 75)
        Me.btnScenarioB.Name = "btnScenarioB"
        Me.btnScenarioB.Size = New System.Drawing.Size(38, 21)
        Me.btnScenarioB.TabIndex = 2
        Me.btnScenarioB.TabStop = True
        Me.btnScenarioB.Text = "B"
        Me.btnScenarioB.UseVisualStyleBackColor = True
        '
        'btnScenarioA
        '
        Me.btnScenarioA.AutoSize = True
        Me.btnScenarioA.Location = New System.Drawing.Point(6, 48)
        Me.btnScenarioA.Name = "btnScenarioA"
        Me.btnScenarioA.Size = New System.Drawing.Size(38, 21)
        Me.btnScenarioA.TabIndex = 1
        Me.btnScenarioA.TabStop = True
        Me.btnScenarioA.Text = "A"
        Me.btnScenarioA.UseVisualStyleBackColor = True
        '
        'graProps
        '
        Me.graProps.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.graProps.ChartAreas.Add(ChartArea1)
        Me.graProps.Dock = System.Windows.Forms.DockStyle.Right
        Legend1.Name = "Legend1"
        Me.graProps.Legends.Add(Legend1)
        Me.graProps.Location = New System.Drawing.Point(717, 0)
        Me.graProps.Name = "graProps"
        Me.graProps.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.graProps.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(127, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(190, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))}
        Me.graProps.Size = New System.Drawing.Size(450, 753)
        Me.graProps.TabIndex = 2
        Me.graProps.Text = "LUPie"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Location = New System.Drawing.Point(175, 701)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.Location = New System.Drawing.Point(8, 701)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(150, 40)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'imgMap
        '
        Me.imgMap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgMap.Dock = System.Windows.Forms.DockStyle.Right
        Me.imgMap.Location = New System.Drawing.Point(1167, 0)
        Me.imgMap.Name = "imgMap"
        Me.imgMap.Size = New System.Drawing.Size(450, 753)
        Me.imgMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgMap.TabIndex = 1
        Me.imgMap.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lnkHelp, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.08522!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07102!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.12638!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.12638!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.12638!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.40779!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.056815!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(334, 753)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lnkHelp
        '
        Me.lnkHelp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkHelp.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lnkHelp, 2)
        Me.lnkHelp.Location = New System.Drawing.Point(126, 120)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(82, 17)
        Me.lnkHelp.TabIndex = 1
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Online Help"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label7, 2)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 34)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "WINNIE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Land Use Scenario Selector"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LandUseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1617, 753)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.graProps)
        Me.Controls.Add(Me.imgMap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LandUseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "WINNIE Land Use Scenario Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Customsettings.ResumeLayout(False)
        Me.Customsettings.PerformLayout()
        CType(Me.spnMoorland, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnBareRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnGrassland, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnForest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnArable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.graProps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCustom As RadioButton
    Friend WithEvents btnScenarioC As RadioButton
    Friend WithEvents btnScenarioB As RadioButton
    Friend WithEvents btnScenarioA As RadioButton
    Friend WithEvents spnGrassland As NumericUpDown
    Friend WithEvents spnArable As NumericUpDown
    Friend WithEvents spnForest As NumericUpDown
    Friend WithEvents Customsettings As GroupBox
    Friend WithEvents graProps As DataVisualization.Charting.Chart
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCurrent As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents spnMoorland As NumericUpDown
    Friend WithEvents spnBareRock As NumericUpDown
    Friend WithEvents imgMap As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents lnkHelp As LinkLabel
End Class
