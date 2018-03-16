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
        Dim ChartArea19 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend19 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series19 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint19 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
        Dim ChartArea20 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend20 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series20 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint20 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
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
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEvap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.Control
        ChartArea19.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea19)
        Legend19.Enabled = False
        Legend19.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend19)
        Me.Chart1.Location = New System.Drawing.Point(12, 81)
        Me.Chart1.Name = "Chart1"
        Series19.ChartArea = "ChartArea1"
        Series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series19.Legend = "Legend1"
        Series19.Name = "Series1"
        Series19.Points.Add(DataPoint19)
        Me.Chart1.Series.Add(Series19)
        Me.Chart1.Size = New System.Drawing.Size(431, 357)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.SystemColors.Control
        ChartArea20.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea20)
        Legend20.Enabled = False
        Legend20.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend20)
        Me.Chart2.Location = New System.Drawing.Point(664, 81)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series20.ChartArea = "ChartArea1"
        Series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series20.Legend = "Legend1"
        Series20.Name = "Series1"
        Series20.Points.Add(DataPoint20)
        Me.Chart2.Series.Add(Series20)
        Me.Chart2.Size = New System.Drawing.Size(431, 357)
        Me.Chart2.TabIndex = 9
        Me.Chart2.Text = "Chart2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 46)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(809, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 46)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Output"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(453, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 78)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "RUN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SpinRain
        '
        Me.SpinRain.BackColor = System.Drawing.Color.DodgerBlue
        Me.SpinRain.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinRain.Location = New System.Drawing.Point(453, 111)
        Me.SpinRain.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.SpinRain.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.SpinRain.Name = "SpinRain"
        Me.SpinRain.Size = New System.Drawing.Size(87, 26)
        Me.SpinRain.TabIndex = 0
        '
        'LblRain
        '
        Me.LblRain.AutoSize = True
        Me.LblRain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRain.Location = New System.Drawing.Point(449, 88)
        Me.LblRain.Name = "LblRain"
        Me.LblRain.Size = New System.Drawing.Size(88, 20)
        Me.LblRain.TabIndex = 1
        Me.LblRain.Text = "+Rain (%)"
        '
        'SpinEvap
        '
        Me.SpinEvap.BackColor = System.Drawing.Color.DarkOrange
        Me.SpinEvap.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinEvap.Location = New System.Drawing.Point(453, 171)
        Me.SpinEvap.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.SpinEvap.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.SpinEvap.Name = "SpinEvap"
        Me.SpinEvap.Size = New System.Drawing.Size(87, 26)
        Me.SpinEvap.TabIndex = 2
        '
        'LblEvap
        '
        Me.LblEvap.AutoSize = True
        Me.LblEvap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEvap.Location = New System.Drawing.Point(449, 148)
        Me.LblEvap.Name = "LblEvap"
        Me.LblEvap.Size = New System.Drawing.Size(91, 20)
        Me.LblEvap.TabIndex = 3
        Me.LblEvap.Text = "+Evap (%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(547, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Mean Q"
        '
        'LblQbar
        '
        Me.LblQbar.AutoSize = True
        Me.LblQbar.Location = New System.Drawing.Point(549, 305)
        Me.LblQbar.Name = "LblQbar"
        Me.LblQbar.Size = New System.Drawing.Size(31, 20)
        Me.LblQbar.TabIndex = 14
        Me.LblQbar.Text = "n/a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(449, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Land use"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Default", "1. Afforestation", "2. Buffer strip", "3. Soil erosion", "Custom scenario"})
        Me.ComboBox1.Location = New System.Drawing.Point(453, 232)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(205, 28)
        Me.ComboBox1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 450)
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
End Class
