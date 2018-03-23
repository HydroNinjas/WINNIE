<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Model
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.RandEChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ModelChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SpinRain = New System.Windows.Forms.NumericUpDown()
        Me.SpinEvap = New System.Windows.Forms.NumericUpDown()
        Me.ModelRun = New System.Windows.Forms.Button()
        Me.LandUseBtn = New System.Windows.Forms.Button()
        Me.ShowLU = New System.Windows.Forms.Button()
        Me.TextBoxLUChoice = New System.Windows.Forms.TextBox()
        Me.ArableTxt = New System.Windows.Forms.TextBox()
        Me.ForestTxt = New System.Windows.Forms.TextBox()
        Me.GrassTxt = New System.Windows.Forms.TextBox()
        Me.FCTxt = New System.Windows.Forms.TextBox()
        CType(Me.RandEChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RandEChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.RandEChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.RandEChart.Legends.Add(Legend1)
        Me.RandEChart.Location = New System.Drawing.Point(12, 12)
        Me.RandEChart.Name = "RandEChart"
        Me.RandEChart.Size = New System.Drawing.Size(253, 300)
        Me.RandEChart.TabIndex = 0
        Me.RandEChart.Text = "RandEChart"
        '
        'ModelChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.ModelChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ModelChart.Legends.Add(Legend2)
        Me.ModelChart.Location = New System.Drawing.Point(548, 12)
        Me.ModelChart.Name = "ModelChart"
        Me.ModelChart.Size = New System.Drawing.Size(220, 300)
        Me.ModelChart.TabIndex = 1
        Me.ModelChart.Text = "ModelChart"
        '
        'SpinRain
        '
        Me.SpinRain.Location = New System.Drawing.Point(427, 89)
        Me.SpinRain.Name = "SpinRain"
        Me.SpinRain.Size = New System.Drawing.Size(45, 22)
        Me.SpinRain.TabIndex = 2
        '
        'SpinEvap
        '
        Me.SpinEvap.Location = New System.Drawing.Point(427, 129)
        Me.SpinEvap.Name = "SpinEvap"
        Me.SpinEvap.Size = New System.Drawing.Size(45, 22)
        Me.SpinEvap.TabIndex = 3
        '
        'ModelRun
        '
        Me.ModelRun.Location = New System.Drawing.Point(388, 208)
        Me.ModelRun.Name = "ModelRun"
        Me.ModelRun.Size = New System.Drawing.Size(83, 42)
        Me.ModelRun.TabIndex = 4
        Me.ModelRun.Text = "ModelRun"
        Me.ModelRun.UseVisualStyleBackColor = True
        '
        'LandUseBtn
        '
        Me.LandUseBtn.Location = New System.Drawing.Point(314, 256)
        Me.LandUseBtn.Name = "LandUseBtn"
        Me.LandUseBtn.Size = New System.Drawing.Size(158, 38)
        Me.LandUseBtn.TabIndex = 5
        Me.LandUseBtn.Text = "LandUseBtn"
        Me.LandUseBtn.UseVisualStyleBackColor = True
        '
        'ShowLU
        '
        Me.ShowLU.Location = New System.Drawing.Point(314, 300)
        Me.ShowLU.Name = "ShowLU"
        Me.ShowLU.Size = New System.Drawing.Size(158, 38)
        Me.ShowLU.TabIndex = 6
        Me.ShowLU.Text = "ShowLU"
        Me.ShowLU.UseVisualStyleBackColor = True
        '
        'TextBoxLUChoice
        '
        Me.TextBoxLUChoice.Location = New System.Drawing.Point(83, 326)
        Me.TextBoxLUChoice.Name = "TextBoxLUChoice"
        Me.TextBoxLUChoice.Size = New System.Drawing.Size(70, 22)
        Me.TextBoxLUChoice.TabIndex = 7
        Me.TextBoxLUChoice.Text = "TextBoxLUChoice"
        '
        'ArableTxt
        '
        Me.ArableTxt.Location = New System.Drawing.Point(120, 354)
        Me.ArableTxt.Name = "ArableTxt"
        Me.ArableTxt.Size = New System.Drawing.Size(50, 22)
        Me.ArableTxt.TabIndex = 8
        Me.ArableTxt.Text = "ArableTxt"
        '
        'ForestTxt
        '
        Me.ForestTxt.Location = New System.Drawing.Point(120, 382)
        Me.ForestTxt.Name = "ForestTxt"
        Me.ForestTxt.Size = New System.Drawing.Size(50, 22)
        Me.ForestTxt.TabIndex = 9
        Me.ForestTxt.Text = "ForestTxt"
        '
        'GrassTxt
        '
        Me.GrassTxt.Location = New System.Drawing.Point(120, 416)
        Me.GrassTxt.Name = "GrassTxt"
        Me.GrassTxt.Size = New System.Drawing.Size(50, 22)
        Me.GrassTxt.TabIndex = 10
        Me.GrassTxt.Text = "GrassTxt"
        '
        'FCTxt
        '
        Me.FCTxt.Location = New System.Drawing.Point(735, 354)
        Me.FCTxt.Name = "FCTxt"
        Me.FCTxt.Size = New System.Drawing.Size(33, 22)
        Me.FCTxt.TabIndex = 11
        Me.FCTxt.Text = "FCTxt"
        '
        'Model
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FCTxt)
        Me.Controls.Add(Me.GrassTxt)
        Me.Controls.Add(Me.ForestTxt)
        Me.Controls.Add(Me.ArableTxt)
        Me.Controls.Add(Me.TextBoxLUChoice)
        Me.Controls.Add(Me.ShowLU)
        Me.Controls.Add(Me.LandUseBtn)
        Me.Controls.Add(Me.ModelRun)
        Me.Controls.Add(Me.SpinEvap)
        Me.Controls.Add(Me.SpinRain)
        Me.Controls.Add(Me.ModelChart)
        Me.Controls.Add(Me.RandEChart)
        Me.Name = "Model"
        Me.Text = "Model"
        CType(Me.RandEChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RandEChart As DataVisualization.Charting.Chart
    Friend WithEvents ModelChart As DataVisualization.Charting.Chart
    Friend WithEvents SpinRain As NumericUpDown
    Friend WithEvents SpinEvap As NumericUpDown
    Friend WithEvents ModelRun As Button
    Friend WithEvents LandUseBtn As Button
    Friend WithEvents ShowLU As Button
    Friend WithEvents TextBoxLUChoice As TextBox
    Friend WithEvents ArableTxt As TextBox
    Friend WithEvents ForestTxt As TextBox
    Friend WithEvents GrassTxt As TextBox
    Friend WithEvents FCTxt As TextBox
End Class
