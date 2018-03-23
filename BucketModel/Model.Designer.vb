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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Me.ModelChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LandUseBtn = New System.Windows.Forms.Button()
        Me.ShowLU = New System.Windows.Forms.Button()
        Me.ModelRun = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SpinRain = New System.Windows.Forms.NumericUpDown()
        Me.SpinEvap = New System.Windows.Forms.NumericUpDown()
        Me.ForestTxt = New System.Windows.Forms.TextBox()
        Me.GrassTxt = New System.Windows.Forms.TextBox()
        Me.ArableTxt = New System.Windows.Forms.TextBox()
        Me.TextBoxLUChoice = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.WebsiteBtn = New System.Windows.Forms.Button()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ModelChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModelChart
        '
        Me.ModelChart.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.ModelChart.ChartAreas.Add(ChartArea3)
        Me.ModelChart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ModelChart.Location = New System.Drawing.Point(0, 269)
        Me.ModelChart.Margin = New System.Windows.Forms.Padding(30)
        Me.ModelChart.Name = "ModelChart"
        Me.ModelChart.Size = New System.Drawing.Size(982, 398)
        Me.ModelChart.TabIndex = 1
        Me.ModelChart.Text = "ModelChart"
        '
        'LandUseBtn
        '
        Me.LandUseBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LandUseBtn.Location = New System.Drawing.Point(3, 143)
        Me.LandUseBtn.Name = "LandUseBtn"
        Me.LandUseBtn.Size = New System.Drawing.Size(185, 45)
        Me.LandUseBtn.TabIndex = 5
        Me.LandUseBtn.Text = "LandUseBtn"
        Me.LandUseBtn.UseVisualStyleBackColor = True
        '
        'ShowLU
        '
        Me.ShowLU.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ShowLU.Location = New System.Drawing.Point(3, 188)
        Me.ShowLU.Name = "ShowLU"
        Me.ShowLU.Size = New System.Drawing.Size(185, 45)
        Me.ShowLU.TabIndex = 6
        Me.ShowLU.Text = "ShowLU"
        Me.ShowLU.UseVisualStyleBackColor = True
        '
        'ModelRun
        '
        Me.ModelRun.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModelRun.Location = New System.Drawing.Point(3, 18)
        Me.ModelRun.Name = "ModelRun"
        Me.ModelRun.Size = New System.Drawing.Size(174, 52)
        Me.ModelRun.TabIndex = 4
        Me.ModelRun.Text = "ModelRun"
        Me.ModelRun.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LandUseBtn)
        Me.GroupBox1.Controls.Add(Me.ShowLU)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(217, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 236)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Land Controls"
        '
        'SpinRain
        '
        Me.SpinRain.Dock = System.Windows.Forms.DockStyle.Top
        Me.SpinRain.Location = New System.Drawing.Point(3, 40)
        Me.SpinRain.Name = "SpinRain"
        Me.SpinRain.Size = New System.Drawing.Size(178, 22)
        Me.SpinRain.TabIndex = 2
        '
        'SpinEvap
        '
        Me.SpinEvap.Dock = System.Windows.Forms.DockStyle.Top
        Me.SpinEvap.Location = New System.Drawing.Point(3, 18)
        Me.SpinEvap.Name = "SpinEvap"
        Me.SpinEvap.Size = New System.Drawing.Size(178, 22)
        Me.SpinEvap.TabIndex = 3
        '
        'ForestTxt
        '
        Me.ForestTxt.Location = New System.Drawing.Point(3, 31)
        Me.ForestTxt.Name = "ForestTxt"
        Me.ForestTxt.Size = New System.Drawing.Size(179, 22)
        Me.ForestTxt.TabIndex = 9
        Me.ForestTxt.Text = "ForestTxt"
        '
        'GrassTxt
        '
        Me.GrassTxt.Location = New System.Drawing.Point(3, 87)
        Me.GrassTxt.Name = "GrassTxt"
        Me.GrassTxt.Size = New System.Drawing.Size(179, 22)
        Me.GrassTxt.TabIndex = 7
        Me.GrassTxt.Text = "GrassTxt"
        '
        'ArableTxt
        '
        Me.ArableTxt.Location = New System.Drawing.Point(3, 59)
        Me.ArableTxt.Name = "ArableTxt"
        Me.ArableTxt.Size = New System.Drawing.Size(179, 22)
        Me.ArableTxt.TabIndex = 8
        Me.ArableTxt.Text = "ArableTxt"
        '
        'TextBoxLUChoice
        '
        Me.TextBoxLUChoice.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxLUChoice.Name = "TextBoxLUChoice"
        Me.TextBoxLUChoice.Size = New System.Drawing.Size(179, 22)
        Me.TextBoxLUChoice.TabIndex = 10
        Me.TextBoxLUChoice.Text = "TextBoxLUChoice"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SpinRain)
        Me.GroupBox2.Controls.Add(Me.SpinEvap)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 236)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Climate Controls"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxLUChoice)
        Me.FlowLayoutPanel1.Controls.Add(Me.ForestTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.ArableTxt)
        Me.FlowLayoutPanel1.Controls.Add(Me.GrassTxt)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(185, 119)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.WebsiteBtn)
        Me.GroupBox3.Controls.Add(Me.HelpBtn)
        Me.GroupBox3.Controls.Add(Me.ModelRun)
        Me.GroupBox3.Location = New System.Drawing.Point(414, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(180, 236)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Model Controls"
        '
        'WebsiteBtn
        '
        Me.WebsiteBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.WebsiteBtn.Location = New System.Drawing.Point(3, 122)
        Me.WebsiteBtn.Name = "WebsiteBtn"
        Me.WebsiteBtn.Size = New System.Drawing.Size(174, 52)
        Me.WebsiteBtn.TabIndex = 13
        Me.WebsiteBtn.Text = "Website"
        Me.WebsiteBtn.UseVisualStyleBackColor = True
        '
        'HelpBtn
        '
        Me.HelpBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.HelpBtn.Location = New System.Drawing.Point(3, 70)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(174, 52)
        Me.HelpBtn.TabIndex = 12
        Me.HelpBtn.Text = "Help"
        Me.HelpBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(600, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 269)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Model
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(982, 667)
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
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents WebsiteBtn As Button
    Friend WithEvents HelpBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
