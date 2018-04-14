Imports ComponentModel = System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO



Public Module Globalvariables

    ' these need to be shared with the other form

    Public LUChoice As String
    Public ForestP As Double
    Public ArableP As Double
    Public GrasslandP As Double
    Public BareRockP As Double
    Public MoorlandP As Double
    Public Control As Boolean = False

End Module



Public Class LandUseForm

    Dim ExitYN As System.Windows.Forms.DialogResult         ' for when you press the exit button

    Private Sub LandUse4Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse4Btn.CheckedChanged

        ' custom land use

        If (LandUse4Btn.Checked = True) Then
            Customsettings.Enabled = True       ' activate the spinners!
            LandImage.Hide()                    ' there is no map
            LUPie.Show()                        ' so display the pie chart

        End If

    End Sub

    Private Sub LandUse3Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse3Btn.CheckedChanged

        ' Land Use Scenario 3

        If (LandUse3Btn.Checked = True) Then

            Customsettings.Enabled = False      ' disable the spinners
            NumericUpDown4.Value = 2.94
            NumericUpDown1.Value = 36.23
            NumericUpDown3.Value = 29.16
            NumericUpDown2.Value = 28.05
            NumericUpDown5.Value = 3.62
            LUPie.Hide()                        ' get rid of the pie chart and put in the beautiful map
            LandImage.Show()
            LandImage.Image = My.Resources.HSD_LUScenario3

        End If
    End Sub

    Private Sub LandUse5Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse5Btn.CheckedChanged

        ' Current Land Use Scenario

        If (LandUse5Btn.Checked = True) Then

            Customsettings.Enabled = False
            NumericUpDown4.Value = 35.83
            NumericUpDown1.Value = 4.15
            NumericUpDown3.Value = 37.73
            NumericUpDown2.Value = 18.11
            NumericUpDown5.Value = 4.18
            LUPie.Hide()
            LandImage.Show()
            LandImage.Image = My.Resources.HSD_LUCurrent

        End If
    End Sub

    Private Sub LandUse2Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse2Btn.CheckedChanged

        ' Land use scenario 2

        If (LandUse2Btn.Checked = True) Then
            Customsettings.Enabled = False
            NumericUpDown4.Value = 3.71
            NumericUpDown1.Value = 24.15
            NumericUpDown3.Value = 34.58
            NumericUpDown2.Value = 33.45
            NumericUpDown5.Value = 4.11
            LUPie.Hide()
            LandImage.Show()
            LandImage.Image = My.Resources.HSD_LUScenario2

        End If
    End Sub

    Private Sub LandUse1Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse1Btn.CheckedChanged

        ' Land Use Scenario 1

        If (LandUse1Btn.Checked = True) Then
            Customsettings.Enabled = False
            NumericUpDown4.Value = 3.35
            NumericUpDown1.Value = 7.39
            NumericUpDown3.Value = 26.71
            NumericUpDown2.Value = 59.93
            NumericUpDown5.Value = 2.62
            LUPie.Hide()
            LandImage.Show()
            LandImage.Image = My.Resources.HSD_LUScenario1

        End If

    End Sub

    Private WithEvents Sectors As New ComponentModel.BindingList(Of SectorItem)

    Private Sub LandUseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' making the form pretty

        Me.BackColor = Color.LightSkyBlue
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.Size = New Size(600, 500)
        Me.CenterToParent()

        ' setting up the pie chart

        Dim PieSeries1 As New Series("Pie1") With {
            .ChartType = SeriesChartType.Pie,
            .CustomProperties = "PieLabelStyle=Disabled"
        }

        LUPie.Series.Clear()
        LUPie.Series.Insert(0, PieSeries1)

        Sectors.Add(New SectorItem(NumericUpDown1, "Forest"))
        Sectors.Add(New SectorItem(NumericUpDown2, "Arable"))
        Sectors.Add(New SectorItem(NumericUpDown3, "Grassland"))
        Sectors.Add(New SectorItem(NumericUpDown4, "Bare Rock"))
        Sectors.Add(New SectorItem(NumericUpDown5, "Moorland"))

        Sectors.ResetItem(0)

        ' if it's the first time opening the form, then the current land use will be picked

        If Control = False Then
            LandUse5Btn.Checked = True
        End If

        ' otherwise it's set to the land use that was picked last

        If LUChoice = "Custom" Then
            LandUse4Btn.Checked = True
            NumericUpDown1.Value = ForestP
            NumericUpDown2.Value = ArableP
            NumericUpDown3.Value = GrasslandP
            NumericUpDown4.Value = BareRockP
            NumericUpDown5.Value = MoorlandP
        ElseIf LUChoice = "Current" Then
            LandUse5Btn.Checked = True
        ElseIf LUChoice = "A" Then
            LandUse1Btn.Checked = True
        ElseIf LUChoice = "B" Then
            LandUse2Btn.Checked = True
        ElseIf LUChoice = "C" Then
            LandUse3Btn.Checked = True
        End If

    End Sub

    Private Sub Sectors_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Sectors.ListChanged

        ' automatic updating of the pie chart

        If e.ListChangedType = ComponentModel.ListChangedType.ItemChanged Then
            LUPie.Series("Pie1").Points.DataBind(Sectors, "", "Value", "Label=Name")
        End If

        TxtBoxTotal.Text = NumericUpDown1.Value + NumericUpDown2.Value + NumericUpDown3.Value + NumericUpDown4.Value + NumericUpDown5.Value

    End Sub

    Private Class SectorItem

        ' more automatic updating of the pie chart, "copied and disguised" (Quinn, 2018)

        Implements System.ComponentModel.INotifyPropertyChanged
        Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Public Sub New(ByVal tb As NumericUpDown, ByVal Name As String)
            Me._Name = Name
            Double.TryParse(tb.Text, _Value)
            tb.DataBindings.Add("Text", Me, "Value", True, DataSourceUpdateMode.OnPropertyChanged)
        End Sub

        Private Sub NotifyPropertyChanged(ByVal info As String)
            RaiseEvent PropertyChanged(Me, New ComponentModel.PropertyChangedEventArgs(info))
        End Sub

        Private _Name As String
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)

                Dim notify As Boolean = Not String.Equals(_Name, value)
                _Name = value
                If notify Then NotifyPropertyChanged("Name")
            End Set
        End Property

        Private _Value As Double
        Public Property Value() As Double
            Get
                Return _Value
            End Get
            Set(ByVal value As Double)
                Dim notify As Boolean = (_Value <> value)
                _Value = value
                If notify Then NotifyPropertyChanged("Value")
            End Set
        End Property
    End Class

    Private Sub LFokBtn_Click(sender As Object, e As EventArgs) Handles LFokBtn.Click

        ' catching you out if you try to get a total percentage that isn't 100

        If NumericUpDown1.Value + NumericUpDown2.Value + NumericUpDown3.Value + NumericUpDown4.Value + NumericUpDown5.Value = 100 Then

            ' if it's all good, then set those values into the global variables

            If (LandUse4Btn.Checked = True) Then
                LUChoice = "Custom"
            ElseIf (LandUse3Btn.Checked = True) Then
                LUChoice = "C"
            ElseIf (LandUse2Btn.Checked = True) Then
                LUChoice = "B"
            ElseIf (LandUse1Btn.Checked = True) Then
                LUChoice = "A"
            ElseIf (LandUse5Btn.Checked = True) Then
                LUChoice = "Current"
            End If

            ForestP = NumericUpDown1.Value
            ArableP = NumericUpDown2.Value
            GrasslandP = NumericUpDown3.Value
            BareRockP = NumericUpDown4.Value
            MoorlandP = NumericUpDown5.Value

            Model.ForestTxt.Text = ForestP
            Model.ArableTxt.Text = ArableP
            Model.GrassTxt.Text = GrasslandP
            Model.BareRTxt.Text = BareRockP
            Model.MoorTxt.Text = MoorlandP
            Model.TextBoxLUChoice.Text = LUChoice

            ExitYN = vbYes ' Philipe, what is going on here? Why is there an if statement asking if this is true below? SL
            If ExitYN = vbYes Then

                Model.Show()
                Me.Close()
                Control = True
            Else
            End If

        Else MessageBox.Show(" Please enter a land combination that sums to 100%", "Error")

        End If

    End Sub

    Private Sub LFcancelBtn_Click(sender As Object, e As EventArgs) Handles LFcancelBtn.Click

        ' if it's the first time you've opened this form, you need to select a land use!

        If Control = False Then
            MsgBox("To continue with the programme please select an option and click OK")
        Else
            ExitYN = vbYes 'Again Philipe, I do not understand this? SL
            If ExitYN = vbYes Then
                Model.Show()
                Me.Close()
            Else
            End If
        End If

    End Sub

    Private Sub Model_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' are you sure you want to exit?????

        If Control = False And ExitYN <> Windows.Forms.DialogResult.Yes Then
            e.Cancel = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes
        End If

    End Sub

End Class