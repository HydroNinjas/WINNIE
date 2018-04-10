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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxLUChoice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BareRTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ForestTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrassTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ArableTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MoorTxt = New System.Windows.Forms.TextBox()
        Me.SpinRain = New System.Windows.Forms.NumericUpDown()
        Me.SpinEvap = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChckCSV = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.QBARTxt = New System.Windows.Forms.TextBox()
        Me.QBARoldTxt = New System.Windows.Forms.TextBox()
        Me.MaxoldTxt = New System.Windows.Forms.TextBox()
        Me.MaxTxt = New System.Windows.Forms.TextBox()
        CType(Me.ModelChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModelChart
        '
        Me.ModelChart.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.ModelChart.ChartAreas.Add(ChartArea1)
        Me.ModelChart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ModelChart.Location = New System.Drawing.Point(0, 353)
        Me.ModelChart.Margin = New System.Windows.Forms.Padding(30)
        Me.ModelChart.Name = "ModelChart"
        Me.ModelChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.ModelChart.Size = New System.Drawing.Size(982, 350)
        Me.ModelChart.TabIndex = 1
        Me.ModelChart.Text = "ModelChart"
        '
        'LandUseBtn
        '
        Me.LandUseBtn.Location = New System.Drawing.Point(3, 273)
        Me.LandUseBtn.Name = "LandUseBtn"
        Me.LandUseBtn.Size = New System.Drawing.Size(150, 40)
        Me.LandUseBtn.TabIndex = 5
        Me.LandUseBtn.Text = "Scenario Selector"
        Me.LandUseBtn.UseVisualStyleBackColor = True
        '
        'ModelRun
        '
        Me.ModelRun.Location = New System.Drawing.Point(3, 30)
        Me.ModelRun.Name = "ModelRun"
        Me.ModelRun.Size = New System.Drawing.Size(150, 40)
        Me.ModelRun.TabIndex = 4
        Me.ModelRun.Text = "Run Model"
        Me.ModelRun.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(202, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 337)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Land Controls"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxLUChoice)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.BareRTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.ForestTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.GrassTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.ArableTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.MoorTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.LandUseBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(182, 316)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Scenario "
        '
        'TextBoxLUChoice
        '
        Me.TextBoxLUChoice.Enabled = False
        Me.TextBoxLUChoice.Location = New System.Drawing.Point(3, 20)
        Me.TextBoxLUChoice.Name = "TextBoxLUChoice"
        Me.TextBoxLUChoice.Size = New System.Drawing.Size(126, 22)
        Me.TextBoxLUChoice.TabIndex = 10
        Me.TextBoxLUChoice.Text = "TextBoxLUChoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Barerock %"
        '
        'BareRTxt
        '
        Me.BareRTxt.Enabled = False
        Me.BareRTxt.Location = New System.Drawing.Point(3, 65)
        Me.BareRTxt.Name = "BareRTxt"
        Me.BareRTxt.Size = New System.Drawing.Size(126, 22)
        Me.BareRTxt.TabIndex = 11
        Me.BareRTxt.Text = "TextBox1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Forest %"
        '
        'ForestTxt
        '
        Me.ForestTxt.Enabled = False
        Me.ForestTxt.Location = New System.Drawing.Point(3, 110)
        Me.ForestTxt.Name = "ForestTxt"
        Me.ForestTxt.Size = New System.Drawing.Size(126, 22)
        Me.ForestTxt.TabIndex = 9
        Me.ForestTxt.Text = "ForestTxt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Grassland %"
        '
        'GrassTxt
        '
        Me.GrassTxt.Enabled = False
        Me.GrassTxt.Location = New System.Drawing.Point(3, 155)
        Me.GrassTxt.Name = "GrassTxt"
        Me.GrassTxt.Size = New System.Drawing.Size(126, 22)
        Me.GrassTxt.TabIndex = 7
        Me.GrassTxt.Text = "GrassTxt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Arable %"
        '
        'ArableTxt
        '
        Me.ArableTxt.Enabled = False
        Me.ArableTxt.Location = New System.Drawing.Point(3, 200)
        Me.ArableTxt.Name = "ArableTxt"
        Me.ArableTxt.ReadOnly = True
        Me.ArableTxt.Size = New System.Drawing.Size(126, 22)
        Me.ArableTxt.TabIndex = 8
        Me.ArableTxt.Text = "ArableTxt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Moorland %"
        '
        'MoorTxt
        '
        Me.MoorTxt.Enabled = False
        Me.MoorTxt.Location = New System.Drawing.Point(3, 245)
        Me.MoorTxt.Name = "MoorTxt"
        Me.MoorTxt.Size = New System.Drawing.Size(126, 22)
        Me.MoorTxt.TabIndex = 12
        Me.MoorTxt.Text = "TextBox2"
        '
        'SpinRain
        '
        Me.SpinRain.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinRain.Location = New System.Drawing.Point(3, 20)
        Me.SpinRain.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.SpinRain.Name = "SpinRain"
        Me.SpinRain.Size = New System.Drawing.Size(138, 22)
        Me.SpinRain.TabIndex = 2
        Me.SpinRain.Tag = ""
        '
        'SpinEvap
        '
        Me.SpinEvap.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinEvap.Location = New System.Drawing.Point(3, 65)
        Me.SpinEvap.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.SpinEvap.Name = "SpinEvap"
        Me.SpinEvap.Size = New System.Drawing.Size(138, 22)
        Me.SpinEvap.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanel3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 125)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Climate Controls"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel3.Controls.Add(Me.SpinRain)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel3.Controls.Add(Me.SpinEvap)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(178, 104)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Rain Change %"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Evap Change %"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox3.Location = New System.Drawing.Point(396, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(183, 99)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Model Controls"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.ChckCSV)
        Me.FlowLayoutPanel2.Controls.Add(Me.ModelRun)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(177, 78)
        Me.FlowLayoutPanel2.TabIndex = 16
        '
        'ChckCSV
        '
        Me.ChckCSV.AutoSize = True
        Me.ChckCSV.Location = New System.Drawing.Point(3, 3)
        Me.ChckCSV.Name = "ChckCSV"
        Me.ChckCSV.Size = New System.Drawing.Size(156, 21)
        Me.ChckCSV.TabIndex = 14
        Me.ChckCSV.Text = "Save output as CSV"
        Me.ChckCSV.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(747, 173)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(672, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "For help please click the link below:"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WINNIE.My.Resources.Resources.WINNIE_Logo_ScnSht
        Me.PictureBox1.InitialImage = Global.WINNIE.My.Resources.Resources.WINNIE_Logo_ScnSht
        Me.PictureBox1.Location = New System.Drawing.Point(733, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'QBARTxt
        '
        Me.QBARTxt.Location = New System.Drawing.Point(461, 120)
        Me.QBARTxt.Name = "QBARTxt"
        Me.QBARTxt.Size = New System.Drawing.Size(115, 22)
        Me.QBARTxt.TabIndex = 18
        '
        'QBARoldTxt
        '
        Me.QBARoldTxt.Location = New System.Drawing.Point(461, 148)
        Me.QBARoldTxt.Name = "QBARoldTxt"
        Me.QBARoldTxt.Size = New System.Drawing.Size(115, 22)
        Me.QBARoldTxt.TabIndex = 19
        '
        'MaxoldTxt
        '
        Me.MaxoldTxt.Location = New System.Drawing.Point(461, 213)
        Me.MaxoldTxt.Name = "MaxoldTxt"
        Me.MaxoldTxt.Size = New System.Drawing.Size(115, 22)
        Me.MaxoldTxt.TabIndex = 21
        '
        'MaxTxt
        '
        Me.MaxTxt.Location = New System.Drawing.Point(461, 185)
        Me.MaxTxt.Name = "MaxTxt"
        Me.MaxTxt.Size = New System.Drawing.Size(115, 22)
        Me.MaxTxt.TabIndex = 20
        '
        'Model
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.MaxoldTxt)
        Me.Controls.Add(Me.MaxTxt)
        Me.Controls.Add(Me.QBARoldTxt)
        Me.Controls.Add(Me.QBARTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ModelChart)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Model"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Model Dashboard"
        CType(Me.ModelChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BareRTxt As TextBox
    Friend WithEvents MoorTxt As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
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
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents QBARTxt As TextBox
    Friend WithEvents QBARoldTxt As TextBox
    Friend WithEvents MaxoldTxt As TextBox
    Friend WithEvents MaxTxt As TextBox
End Class
