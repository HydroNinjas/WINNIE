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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Model))
        Me.ModelChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LandUseBtn = New System.Windows.Forms.Button()
        Me.ShowLU = New System.Windows.Forms.Button()
        Me.ModelRun = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBoxLUChoice = New System.Windows.Forms.TextBox()
        Me.ForestTxt = New System.Windows.Forms.TextBox()
        Me.ArableTxt = New System.Windows.Forms.TextBox()
        Me.GrassTxt = New System.Windows.Forms.TextBox()
        Me.BareRTxt = New System.Windows.Forms.TextBox()
        Me.MoorTxt = New System.Windows.Forms.TextBox()
        Me.SpinRain = New System.Windows.Forms.NumericUpDown()
        Me.SpinEvap = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChckCSV = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ModelChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModelChart
        '
        Me.ModelChart.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.ModelChart.ChartAreas.Add(ChartArea2)
        Me.ModelChart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ModelChart.Location = New System.Drawing.Point(0, 320)
        Me.ModelChart.Margin = New System.Windows.Forms.Padding(30)
        Me.ModelChart.Name = "ModelChart"
        Me.ModelChart.Size = New System.Drawing.Size(982, 383)
        Me.ModelChart.TabIndex = 1
        Me.ModelChart.Text = "ModelChart"
        '
        'LandUseBtn
        '
        Me.LandUseBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LandUseBtn.Location = New System.Drawing.Point(3, 217)
        Me.LandUseBtn.Name = "LandUseBtn"
        Me.LandUseBtn.Size = New System.Drawing.Size(150, 40)
        Me.LandUseBtn.TabIndex = 5
        Me.LandUseBtn.Text = "LandUseBtn"
        Me.LandUseBtn.UseVisualStyleBackColor = True
        '
        'ShowLU
        '
        Me.ShowLU.Location = New System.Drawing.Point(3, 171)
        Me.ShowLU.Name = "ShowLU"
        Me.ShowLU.Size = New System.Drawing.Size(150, 40)
        Me.ShowLU.TabIndex = 6
        Me.ShowLU.Text = "ShowLU"
        Me.ShowLU.UseVisualStyleBackColor = True
        '
        'ModelRun
        '
        Me.ModelRun.Location = New System.Drawing.Point(3, 30)
        Me.ModelRun.Name = "ModelRun"
        Me.ModelRun.Size = New System.Drawing.Size(150, 40)
        Me.ModelRun.TabIndex = 4
        Me.ModelRun.Text = "ModelRun"
        Me.ModelRun.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(202, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 288)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Land Controls"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxLUChoice)
        Me.FlowLayoutPanel1.Controls.Add(Me.BareRTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.ForestTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.GrassTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.ArableTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.MoorTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowLU)
        Me.FlowLayoutPanel1.Controls.Add(Me.LandUseBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(185, 267)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'TextBoxLUChoice
        '
        Me.TextBoxLUChoice.Enabled = False
        Me.TextBoxLUChoice.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxLUChoice.Name = "TextBoxLUChoice"
        Me.TextBoxLUChoice.Size = New System.Drawing.Size(150, 22)
        Me.TextBoxLUChoice.TabIndex = 10
        Me.TextBoxLUChoice.Text = "TextBoxLUChoice"
        '
        'ForestTxt
        '
        Me.ForestTxt.Enabled = False
        Me.ForestTxt.Location = New System.Drawing.Point(3, 59)
        Me.ForestTxt.Name = "ForestTxt"
        Me.ForestTxt.Size = New System.Drawing.Size(150, 22)
        Me.ForestTxt.TabIndex = 9
        Me.ForestTxt.Text = "ForestTxt"
        '
        'ArableTxt
        '
        Me.ArableTxt.Enabled = False
        Me.ArableTxt.Location = New System.Drawing.Point(3, 115)
        Me.ArableTxt.Name = "ArableTxt"
        Me.ArableTxt.Size = New System.Drawing.Size(150, 22)
        Me.ArableTxt.TabIndex = 8
        Me.ArableTxt.Text = "ArableTxt"
        '
        'GrassTxt
        '
        Me.GrassTxt.Enabled = False
        Me.GrassTxt.Location = New System.Drawing.Point(3, 87)
        Me.GrassTxt.Name = "GrassTxt"
        Me.GrassTxt.Size = New System.Drawing.Size(150, 22)
        Me.GrassTxt.TabIndex = 7
        Me.GrassTxt.Text = "GrassTxt"
        '
        'BareRTxt
        '
        Me.BareRTxt.Enabled = False
        Me.BareRTxt.Location = New System.Drawing.Point(3, 31)
        Me.BareRTxt.Name = "BareRTxt"
        Me.BareRTxt.Size = New System.Drawing.Size(150, 22)
        Me.BareRTxt.TabIndex = 11
        Me.BareRTxt.Text = "TextBox1"
        '
        'MoorTxt
        '
        Me.MoorTxt.Enabled = False
        Me.MoorTxt.Location = New System.Drawing.Point(3, 143)
        Me.MoorTxt.Name = "MoorTxt"
        Me.MoorTxt.Size = New System.Drawing.Size(150, 22)
        Me.MoorTxt.TabIndex = 12
        Me.MoorTxt.Text = "TextBox2"
        '
        'SpinRain
        '
        Me.SpinRain.Dock = System.Windows.Forms.DockStyle.Top
        Me.SpinRain.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinRain.Location = New System.Drawing.Point(3, 40)
        Me.SpinRain.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.SpinRain.Name = "SpinRain"
        Me.SpinRain.Size = New System.Drawing.Size(178, 22)
        Me.SpinRain.TabIndex = 2
        '
        'SpinEvap
        '
        Me.SpinEvap.Dock = System.Windows.Forms.DockStyle.Top
        Me.SpinEvap.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinEvap.Location = New System.Drawing.Point(3, 18)
        Me.SpinEvap.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.SpinEvap.Name = "SpinEvap"
        Me.SpinEvap.Size = New System.Drawing.Size(178, 22)
        Me.SpinEvap.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SpinRain)
        Me.GroupBox2.Controls.Add(Me.SpinEvap)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 288)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Climate Controls"
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
        Me.ChckCSV.Size = New System.Drawing.Size(89, 21)
        Me.ChckCSV.TabIndex = 14
        Me.ChckCSV.Text = "SaveCSV"
        Me.ChckCSV.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(585, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(582, 273)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(582, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "For help please click the link below:"
        '
        'Model
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(982, 703)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ModelChart As DataVisualization.Charting.Chart
    Friend WithEvents LandUseBtn As Button
    Friend WithEvents ShowLU As Button
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
End Class
