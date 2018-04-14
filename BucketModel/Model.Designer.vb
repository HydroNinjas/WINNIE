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
        Me.ModelChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LandUseBtn = New System.Windows.Forms.Button()
        Me.ModelRun = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MoorTxt = New System.Windows.Forms.TextBox()
        Me.ArableTxt = New System.Windows.Forms.TextBox()
        Me.GrassTxt = New System.Windows.Forms.TextBox()
        Me.ForestTxt = New System.Windows.Forms.TextBox()
        Me.BareRTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxLUChoice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SpinRain = New System.Windows.Forms.NumericUpDown()
        Me.SpinEvap = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LnkGraph = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.ChckCSV = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtCompare = New System.Windows.Forms.RichTextBox()
        CType(Me.ModelChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ModelChart
        '
        Me.ModelChart.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.Title = "Simulated runoff (mm)"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ChartArea1.Name = "ChartArea1"
        Me.ModelChart.ChartAreas.Add(ChartArea1)
        Me.TableLayoutPanel1.SetColumnSpan(Me.ModelChart, 4)
        Me.ModelChart.Location = New System.Drawing.Point(0, 435)
        Me.ModelChart.Margin = New System.Windows.Forms.Padding(0)
        Me.ModelChart.Name = "ModelChart"
        Me.ModelChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.ModelChart.Size = New System.Drawing.Size(1105, 444)
        Me.ModelChart.TabIndex = 1
        Me.ModelChart.Text = "ModelChart"
        '
        'LandUseBtn
        '
        Me.LandUseBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.SetColumnSpan(Me.LandUseBtn, 2)
        Me.LandUseBtn.Location = New System.Drawing.Point(20, 335)
        Me.LandUseBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LandUseBtn.Name = "LandUseBtn"
        Me.LandUseBtn.Size = New System.Drawing.Size(169, 50)
        Me.LandUseBtn.TabIndex = 5
        Me.LandUseBtn.Text = "Scenario Selector"
        Me.LandUseBtn.UseVisualStyleBackColor = True
        '
        'ModelRun
        '
        Me.ModelRun.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ModelRun.Location = New System.Drawing.Point(20, 160)
        Me.ModelRun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ModelRun.Name = "ModelRun"
        Me.ModelRun.Size = New System.Drawing.Size(169, 48)
        Me.ModelRun.TabIndex = 4
        Me.ModelRun.Text = "Run Model"
        Me.ModelRun.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(224, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox1, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(215, 427)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Land Controls"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MoorTxt, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.ArableTxt, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.GrassTxt, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ForestTxt, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BareRTxt, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxLUChoice, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.LandUseBtn, 0, 7)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 23)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(209, 400)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'MoorTxt
        '
        Me.MoorTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.MoorTxt.Enabled = False
        Me.MoorTxt.Location = New System.Drawing.Point(3, 244)
        Me.MoorTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MoorTxt.Name = "MoorTxt"
        Me.MoorTxt.Size = New System.Drawing.Size(67, 26)
        Me.MoorTxt.TabIndex = 12
        Me.MoorTxt.Text = "MoorTxt"
        Me.MoorTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ArableTxt
        '
        Me.ArableTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArableTxt.Enabled = False
        Me.ArableTxt.Location = New System.Drawing.Point(3, 204)
        Me.ArableTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ArableTxt.Name = "ArableTxt"
        Me.ArableTxt.ReadOnly = True
        Me.ArableTxt.Size = New System.Drawing.Size(67, 26)
        Me.ArableTxt.TabIndex = 8
        Me.ArableTxt.Text = "ArableTxt"
        Me.ArableTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrassTxt
        '
        Me.GrassTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrassTxt.Enabled = False
        Me.GrassTxt.Location = New System.Drawing.Point(3, 164)
        Me.GrassTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrassTxt.Name = "GrassTxt"
        Me.GrassTxt.Size = New System.Drawing.Size(67, 26)
        Me.GrassTxt.TabIndex = 7
        Me.GrassTxt.Text = "GrassTxt"
        Me.GrassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ForestTxt
        '
        Me.ForestTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.ForestTxt.Enabled = False
        Me.ForestTxt.Location = New System.Drawing.Point(3, 124)
        Me.ForestTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ForestTxt.Name = "ForestTxt"
        Me.ForestTxt.Size = New System.Drawing.Size(67, 26)
        Me.ForestTxt.TabIndex = 9
        Me.ForestTxt.Text = "ForestTxt"
        Me.ForestTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BareRTxt
        '
        Me.BareRTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.BareRTxt.Enabled = False
        Me.BareRTxt.Location = New System.Drawing.Point(3, 84)
        Me.BareRTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BareRTxt.Name = "BareRTxt"
        Me.BareRTxt.Size = New System.Drawing.Size(67, 26)
        Me.BareRTxt.TabIndex = 11
        Me.BareRTxt.Text = "BareRTxt"
        Me.BareRTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "% Bare Rock"
        '
        'TextBoxLUChoice
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBoxLUChoice, 2)
        Me.TextBoxLUChoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxLUChoice.Enabled = False
        Me.TextBoxLUChoice.Location = New System.Drawing.Point(3, 4)
        Me.TextBoxLUChoice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxLUChoice.Name = "TextBoxLUChoice"
        Me.TextBoxLUChoice.Size = New System.Drawing.Size(203, 26)
        Me.TextBoxLUChoice.TabIndex = 10
        Me.TextBoxLUChoice.Text = "TextBoxLUChoice"
        Me.TextBoxLUChoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "% Forest"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "% Grassland"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "% Arable"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "% Moorland"
        '
        'SpinRain
        '
        Me.SpinRain.Dock = System.Windows.Forms.DockStyle.Top
        Me.SpinRain.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinRain.Location = New System.Drawing.Point(3, 4)
        Me.SpinRain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SpinRain.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.SpinRain.Name = "SpinRain"
        Me.SpinRain.Size = New System.Drawing.Size(67, 26)
        Me.SpinRain.TabIndex = 2
        Me.SpinRain.Tag = ""
        Me.SpinRain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SpinEvap
        '
        Me.SpinEvap.Dock = System.Windows.Forms.DockStyle.Top
        Me.SpinEvap.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinEvap.Location = New System.Drawing.Point(3, 50)
        Me.SpinEvap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SpinEvap.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.SpinEvap.Name = "SpinEvap"
        Me.SpinEvap.Size = New System.Drawing.Size(67, 26)
        Me.SpinEvap.TabIndex = 3
        Me.SpinEvap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(445, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(215, 166)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Climate Controls"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.SpinRain, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.SpinEvap, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LnkGraph, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(209, 139)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'LnkGraph
        '
        Me.LnkGraph.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LnkGraph.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.LnkGraph, 2)
        Me.LnkGraph.Location = New System.Drawing.Point(51, 105)
        Me.LnkGraph.Name = "LnkGraph"
        Me.LnkGraph.Size = New System.Drawing.Size(106, 20)
        Me.LnkGraph.TabIndex = 6
        Me.LnkGraph.TabStop = True
        Me.LnkGraph.Text = "View baseline"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "% Rain Change"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(76, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "% Evap Change"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(445, 178)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox3, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(215, 253)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Model Controls"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.BtnClear, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ChckCSV, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ModelRun, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(209, 226)
        Me.TableLayoutPanel4.TabIndex = 17
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnClear.Location = New System.Drawing.Point(20, 78)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(169, 48)
        Me.BtnClear.TabIndex = 15
        Me.BtnClear.Text = "Clear Log"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'ChckCSV
        '
        Me.ChckCSV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChckCSV.AutoSize = True
        Me.ChckCSV.Location = New System.Drawing.Point(15, 18)
        Me.ChckCSV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChckCSV.Name = "ChckCSV"
        Me.ChckCSV.Size = New System.Drawing.Size(179, 24)
        Me.ChckCSV.TabIndex = 14
        Me.ChckCSV.Text = "Save output as CSV"
        Me.ChckCSV.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(65, 348)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 20)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Online Help"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 40)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "WINNIE version 3.1.4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Model Dashboard"
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
        Me.PictureBox1.Location = New System.Drawing.Point(57, 81)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.PictureBox1, 3)
        Me.PictureBox1.Size = New System.Drawing.Size(107, 176)
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
        Me.TableLayoutPanel1.Controls.Add(Me.ModelChart, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCompare, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1105, 879)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'TxtCompare
        '
        Me.TxtCompare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCompare.BackColor = System.Drawing.Color.Black
        Me.TxtCompare.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompare.ForeColor = System.Drawing.Color.White
        Me.TxtCompare.Location = New System.Drawing.Point(692, 4)
        Me.TxtCompare.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCompare.Name = "TxtCompare"
        Me.TxtCompare.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.TxtCompare, 5)
        Me.TxtCompare.Size = New System.Drawing.Size(383, 427)
        Me.TxtCompare.TabIndex = 23
        Me.TxtCompare.Text = ""
        '
        'Model
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1105, 879)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Model"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Model Dashboard"
        CType(Me.ModelChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ModelChart As DataVisualization.Charting.Chart
    Friend WithEvents ModelRun As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SpinRain As NumericUpDown
    Friend WithEvents SpinEvap As NumericUpDown
    Friend WithEvents ForestTxt As TextBox
    Friend WithEvents GrassTxt As TextBox
    Friend WithEvents ArableTxt As TextBox
    Friend WithEvents TextBoxLUChoice As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BareRTxt As TextBox
    Friend WithEvents MoorTxt As TextBox
    Friend WithEvents ChckCSV As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents LandUseBtn As Button
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
    Friend WithEvents TxtCompare As RichTextBox
    Friend WithEvents LnkGraph As LinkLabel
    Friend WithEvents BtnClear As Button
End Class
