<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SpinRain = New System.Windows.Forms.NumericUpDown()
        Me.LblRain = New System.Windows.Forms.Label()
        Me.SpinEvap = New System.Windows.Forms.NumericUpDown()
        Me.LblEvap = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblQbar = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.Control
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(11, 65)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.Points.Add(DataPoint1)
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(383, 286)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.SystemColors.Control
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(590, 65)
        Me.Chart2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.Points.Add(DataPoint2)
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(383, 286)
        Me.Chart2.TabIndex = 9
        Me.Chart2.Text = "Chart2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 39)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(719, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 39)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Output"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(403, 306)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "RUN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SpinRain
        '
        Me.SpinRain.BackColor = System.Drawing.Color.DodgerBlue
        Me.SpinRain.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinRain.Location = New System.Drawing.Point(403, 89)
        Me.SpinRain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SpinRain.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.SpinRain.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.SpinRain.Name = "SpinRain"
        Me.SpinRain.Size = New System.Drawing.Size(77, 22)
        Me.SpinRain.TabIndex = 0
        '
        'LblRain
        '
        Me.LblRain.AutoSize = True
        Me.LblRain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRain.Location = New System.Drawing.Point(399, 70)
        Me.LblRain.Name = "LblRain"
        Me.LblRain.Size = New System.Drawing.Size(80, 17)
        Me.LblRain.TabIndex = 1
        Me.LblRain.Text = "+Rain (%)"
        '
        'SpinEvap
        '
        Me.SpinEvap.BackColor = System.Drawing.Color.DarkOrange
        Me.SpinEvap.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinEvap.Location = New System.Drawing.Point(403, 137)
        Me.SpinEvap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SpinEvap.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.SpinEvap.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.SpinEvap.Name = "SpinEvap"
        Me.SpinEvap.Size = New System.Drawing.Size(77, 22)
        Me.SpinEvap.TabIndex = 2
        '
        'LblEvap
        '
        Me.LblEvap.AutoSize = True
        Me.LblEvap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEvap.Location = New System.Drawing.Point(399, 118)
        Me.LblEvap.Name = "LblEvap"
        Me.LblEvap.Size = New System.Drawing.Size(83, 17)
        Me.LblEvap.TabIndex = 3
        Me.LblEvap.Text = "+Evap (%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(486, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Mean Q"
        '
        'LblQbar
        '
        Me.LblQbar.AutoSize = True
        Me.LblQbar.Location = New System.Drawing.Point(488, 244)
        Me.LblQbar.Name = "LblQbar"
        Me.LblQbar.Size = New System.Drawing.Size(28, 17)
        Me.LblQbar.TabIndex = 14
        Me.LblQbar.Text = "n/a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Land use"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Default", "1. Afforestation", "2. Buffer strip", "3. Soil erosion", "Custom scenario"})
        Me.ComboBox1.Location = New System.Drawing.Point(403, 186)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 24)
        Me.ComboBox1.TabIndex = 16
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(450, 282)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 21)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "save csv"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(370, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 22)
        Me.TextBox1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 360)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblQbar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblEvap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SpinEvap)
        Me.Controls.Add(Me.LblRain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SpinRain)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Bucket Model"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SpinRain As NumericUpDown
    Friend WithEvents LblRain As Label
    Friend WithEvents SpinEvap As NumericUpDown
    Friend WithEvents LblEvap As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblQbar As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents saveFileDialog1 As SaveFileDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
End Class
