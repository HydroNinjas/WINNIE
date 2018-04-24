<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Model
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Me.graSimRunoff = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnSelector = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMoorland = New System.Windows.Forms.TextBox()
        Me.txtArable = New System.Windows.Forms.TextBox()
        Me.txtGrassland = New System.Windows.Forms.TextBox()
        Me.txtForest = New System.Windows.Forms.TextBox()
        Me.txtBareRock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtScenario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.spnRain = New System.Windows.Forms.NumericUpDown()
        Me.spnEvap = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lnkGraph = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkSave = New System.Windows.Forms.CheckBox()
        Me.lnkHelp = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtLog = New System.Windows.Forms.RichTextBox()
        CType(Me.graSimRunoff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.spnRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnEvap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'graSimRunoff
        '
        Me.graSimRunoff.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.Title = "Simulated runoff (mm)"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ChartArea1.Name = "ChartArea1"
        Me.graSimRunoff.ChartAreas.Add(ChartArea1)
        Me.TableLayoutPanel1.SetColumnSpan(Me.graSimRunoff, 4)
        Me.graSimRunoff.Location = New System.Drawing.Point(0, 350)
        Me.graSimRunoff.Margin = New System.Windows.Forms.Padding(0)
        Me.graSimRunoff.Name = "graSimRunoff"
        Me.graSimRunoff.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.graSimRunoff.Size = New System.Drawing.Size(982, 353)
        Me.graSimRunoff.TabIndex = 5
        Me.graSimRunoff.Text = "ModelChart"
        '
        'btnSelector
        '
        Me.btnSelector.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.SetColumnSpan(Me.btnSelector, 2)
        Me.btnSelector.Location = New System.Drawing.Point(17, 269)
        Me.btnSelector.Name = "btnSelector"
        Me.btnSelector.Size = New System.Drawing.Size(150, 40)
        Me.btnSelector.TabIndex = 6
        Me.btnSelector.Text = "Scenario Selector"
        Me.btnSelector.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRun.Location = New System.Drawing.Point(17, 130)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(150, 38)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "Run Model"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(199, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox1, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(190, 344)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Land Use Controls"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtMoorland, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtArable, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtGrassland, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtForest, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtBareRock, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtScenario, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSelector, 0, 7)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(184, 323)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txtMoorland
        '
        Me.txtMoorland.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtMoorland.Enabled = False
        Me.txtMoorland.Location = New System.Drawing.Point(3, 195)
        Me.txtMoorland.Name = "txtMoorland"
        Me.txtMoorland.Size = New System.Drawing.Size(58, 22)
        Me.txtMoorland.TabIndex = 5
        Me.txtMoorland.Text = "MoorTxt"
        Me.txtMoorland.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtArable
        '
        Me.txtArable.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtArable.Enabled = False
        Me.txtArable.Location = New System.Drawing.Point(3, 163)
        Me.txtArable.Name = "txtArable"
        Me.txtArable.ReadOnly = True
        Me.txtArable.Size = New System.Drawing.Size(58, 22)
        Me.txtArable.TabIndex = 4
        Me.txtArable.Text = "ArableTxt"
        Me.txtArable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGrassland
        '
        Me.txtGrassland.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtGrassland.Enabled = False
        Me.txtGrassland.Location = New System.Drawing.Point(3, 131)
        Me.txtGrassland.Name = "txtGrassland"
        Me.txtGrassland.Size = New System.Drawing.Size(58, 22)
        Me.txtGrassland.TabIndex = 3
        Me.txtGrassland.Text = "GrassTxt"
        Me.txtGrassland.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtForest
        '
        Me.txtForest.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtForest.Enabled = False
        Me.txtForest.Location = New System.Drawing.Point(3, 99)
        Me.txtForest.Name = "txtForest"
        Me.txtForest.Size = New System.Drawing.Size(58, 22)
        Me.txtForest.TabIndex = 2
        Me.txtForest.Text = "ForestTxt"
        Me.txtForest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBareRock
        '
        Me.txtBareRock.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBareRock.Enabled = False
        Me.txtBareRock.Location = New System.Drawing.Point(3, 67)
        Me.txtBareRock.Name = "txtBareRock"
        Me.txtBareRock.Size = New System.Drawing.Size(58, 22)
        Me.txtBareRock.TabIndex = 1
        Me.txtBareRock.Text = "BareRTxt"
        Me.txtBareRock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "% Bare Rock"
        '
        'txtScenario
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtScenario, 2)
        Me.txtScenario.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtScenario.Enabled = False
        Me.txtScenario.Location = New System.Drawing.Point(3, 3)
        Me.txtScenario.Name = "txtScenario"
        Me.txtScenario.Size = New System.Drawing.Size(178, 22)
        Me.txtScenario.TabIndex = 0
        Me.txtScenario.Text = "TextBoxLUChoice"
        Me.txtScenario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "% Forest"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "% Grassland"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "% Arable"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "% Moorland"
        '
        'spnRain
        '
        Me.spnRain.Dock = System.Windows.Forms.DockStyle.Top
        Me.spnRain.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.spnRain.Location = New System.Drawing.Point(3, 3)
        Me.spnRain.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.spnRain.Name = "spnRain"
        Me.spnRain.Size = New System.Drawing.Size(58, 22)
        Me.spnRain.TabIndex = 0
        Me.spnRain.Tag = ""
        Me.spnRain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'spnEvap
        '
        Me.spnEvap.Dock = System.Windows.Forms.DockStyle.Top
        Me.spnEvap.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.spnEvap.Location = New System.Drawing.Point(3, 40)
        Me.spnEvap.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.spnEvap.Name = "spnEvap"
        Me.spnEvap.Size = New System.Drawing.Size(58, 22)
        Me.spnEvap.TabIndex = 1
        Me.spnEvap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(395, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(190, 133)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Climate Controls"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.spnRain, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.spnEvap, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lnkGraph, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(184, 112)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "% Rain Change"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "% Evap Change"
        '
        'lnkGraph
        '
        Me.lnkGraph.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkGraph.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.lnkGraph, 2)
        Me.lnkGraph.Location = New System.Drawing.Point(45, 84)
        Me.lnkGraph.Name = "lnkGraph"
        Me.lnkGraph.Size = New System.Drawing.Size(94, 17)
        Me.lnkGraph.TabIndex = 2
        Me.lnkGraph.TabStop = True
        Me.lnkGraph.Text = "View baseline"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(395, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox3, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(190, 204)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Model Controls"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnClear, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.btnRun, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.chkSave, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(184, 183)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Location = New System.Drawing.Point(17, 63)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 38)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Log"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkSave
        '
        Me.chkSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSave.AutoSize = True
        Me.chkSave.Location = New System.Drawing.Point(14, 14)
        Me.chkSave.Name = "chkSave"
        Me.chkSave.Size = New System.Drawing.Size(156, 21)
        Me.chkSave.TabIndex = 0
        Me.chkSave.Text = "Save output as CSV"
        Me.chkSave.UseVisualStyleBackColor = True
        '
        'lnkHelp
        '
        Me.lnkHelp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnkHelp.AutoSize = True
        Me.lnkHelp.Location = New System.Drawing.Point(57, 280)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(82, 17)
        Me.lnkHelp.TabIndex = 0
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Online Help"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WINNIE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Model Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.Image = Global.WINNIE.My.Resources.Resources.WINNIE_Logo_ScnSht
        Me.PictureBox1.InitialImage = Global.WINNIE.My.Resources.Resources.WINNIE_Logo_ScnSht
        Me.PictureBox1.Location = New System.Drawing.Point(45, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.PictureBox1, 3)
        Me.PictureBox1.Size = New System.Drawing.Size(105, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.graSimRunoff, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lnkHelp, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLog, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(982, 703)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtLog
        '
        Me.txtLog.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLog.BackColor = System.Drawing.Color.Black
        Me.txtLog.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.ForeColor = System.Drawing.Color.White
        Me.txtLog.Location = New System.Drawing.Point(614, 4)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.txtLog, 5)
        Me.txtLog.Size = New System.Drawing.Size(341, 342)
        Me.txtLog.TabIndex = 1
        Me.txtLog.Text = ""
        '
        'Model
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Model"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "WINNIE Model Dashboard"
        CType(Me.graSimRunoff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.spnRain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnEvap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents graSimRunoff As DataVisualization.Charting.Chart
    Friend WithEvents btnRun As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents spnRain As NumericUpDown
    Friend WithEvents spnEvap As NumericUpDown
    Friend WithEvents txtForest As TextBox
    Friend WithEvents txtGrassland As TextBox
    Friend WithEvents txtArable As TextBox
    Friend WithEvents txtScenario As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBareRock As TextBox
    Friend WithEvents txtMoorland As TextBox
    Friend WithEvents chkSave As CheckBox
    Friend WithEvents lnkHelp As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents btnSelector As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtLog As RichTextBox
    Friend WithEvents lnkGraph As LinkLabel
    Friend WithEvents btnClear As Button
End Class
