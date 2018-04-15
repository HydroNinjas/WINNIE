'Authors:       Philip Ayre and Shannon Leakey, Ninja Developments
'Description:   Land use selector with interactive map and pie chart,
'               and link to main GUI form
'
Option Explicit On

Imports ComponentModel = System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO

Public Module Globalvariables
    '
    'For the chosen scenario
    Public strScenario As String
    '
    'For the land use proportions (couldn't this just be an array, Philipe???)
    Public dblPropBareRock As Double
    Public dblPropForest As Double
    Public dblPropGrassland As Double
    Public dblPropArable As Double
    Public dblPropMoorland As Double
    '
    'To track whether you've actually chosen something
    Public blnChosen As Boolean = False
End Module

Public Class LandUseForm

    '============================
    'Constant Declaration
    '============================
    '
    'The link to the interactive map
    Private Const strMapURL As String = "https://hydroninjas.github.io/land_use"

    '============================
    'Variable Declaration
    '============================
    '
    'For when you want to exit
    Dim blnExit As System.Windows.Forms.DialogResult

    '============================
    'General form stuff
    '============================

    Private Sub OpenLandUseForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        'For the pie chart data
        Dim srsProps As New Series("Pie1") With {
            .ChartType = SeriesChartType.Pie,
            .CustomProperties = "PieLabelStyle=Disabled"
        }
        '
        'Making the form pretty
        Me.BackColor = Color.LightSkyBlue
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.Size = New Size(600, 500)
        Me.CenterToParent()
        '
        'Setting up the pie chart
        graProps.Series.Clear()
        graProps.Series.Insert(0, srsProps)

        '
        'Adding data to the pie chart
        Sectors.Add(New SectorItem(spnForest, "Forest"))
        Sectors.Add(New SectorItem(spnArable, "Arable"))
        Sectors.Add(New SectorItem(spnGrassland, "Grassland"))
        Sectors.Add(New SectorItem(spnBareRock, "Bare Rock"))
        Sectors.Add(New SectorItem(spnMoorland, "Moorland"))
        Sectors.ResetItem(0)
        '
        'Is it the first time opening the form?
        If blnChosen = False Then
            btnCurrent.Checked = True
        End If
        '
        'If not, set things to be what was picked last
        If strScenario = "Custom" Then
            btnCustom.Checked = True
            spnForest.Value = dblPropForest
            spnArable.Value = dblPropArable
            spnGrassland.Value = dblPropGrassland
            spnBareRock.Value = dblPropBareRock
            spnMoorland.Value = dblPropMoorland
        ElseIf strScenario = "Current" Then
            btnCurrent.Checked = True
        ElseIf strScenario = "A" Then
            btnScenarioA.Checked = True
        ElseIf strScenario = "B" Then
            btnScenarioB.Checked = True
        ElseIf strScenario = "C" Then
            btnScenarioC.Checked = True
        End If
    End Sub

    Private Sub CheckOK(sender As Object, e As EventArgs) Handles btnOK.Click
        If spnForest.Value + spnArable.Value + spnGrassland.Value + spnBareRock.Value + spnMoorland.Value = 100 Then
            '
            'If it's all good, then set those values into the global variables
            If (btnCurrent.Checked = True) Then
                strScenario = "Current"
            ElseIf (btnScenarioA.Checked = True) Then
                strScenario = "A"
            ElseIf (btnScenarioB.Checked = True) Then
                strScenario = "B"
            ElseIf (btnScenarioC.Checked = True) Then
                strScenario = "C"
            ElseIf (btnCustom.Checked = True) Then
                strScenario = "Custom"
            End If
            dblPropForest = spnForest.Value
            dblPropArable = spnArable.Value
            dblPropGrassland = spnGrassland.Value
            dblPropBareRock = spnBareRock.Value
            dblPropMoorland = spnMoorland.Value
            '
            'And change the text in the other form
            Model.txtForest.Text = String.Format("{0:n2}", dblPropForest)
            Model.txtArable.Text = String.Format("{0:n2}", dblPropArable)
            Model.txtGrassland.Text = String.Format("{0:n2}", dblPropGrassland)
            Model.txtBareRock.Text = String.Format("{0:n2}", dblPropBareRock)
            Model.txtMoorland.Text = String.Format("{0:n2}", dblPropMoorland)
            Model.txtScenario.Text = "Scenario: " & strScenario
            '
            'Now close the model
            blnExit = vbYes
            Model.Show()
            Me.Close()
            blnChosen = True
            '
            'Otherwise throw up an error
        Else MessageBox.Show("Please enter a land combination that sums to 100%", "Error")
        End If
    End Sub

    Private Sub CheckCancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        If blnChosen = False Then
            MsgBox("To continue with the programme please select an option and click OK")
        Else
            '
            'The variables are not shared with the other form
            blnExit = vbYes
            Model.Show()
            Me.Close()
        End If

    End Sub

    Private Sub CloseLandUseForm(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '
        'If it's the first time opening the form, you'll exit the whole program
        If blnChosen = False And blnExit <> Windows.Forms.DialogResult.Yes Then
            e.Cancel = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes
        End If
    End Sub

    Private Sub OpenMap(sender As Object, e As EventArgs) Handles imgMap.Click
        '
        'Clicking the map takes you to the website where you can zoom in even more
        Process.Start(strMapURL)
    End Sub

    '============================
    'Radio button controls
    '============================

    Private Sub SelectCurrent(sender As Object, e As EventArgs) Handles btnCurrent.CheckedChanged
        If (btnCurrent.Checked = True) Then
            '
            'Disable custom spinners
            Customsettings.Enabled = False
            spnBareRock.Value = 4.15
            spnForest.Value = 18.11
            spnGrassland.Value = 37.73
            spnArable.Value = 35.83
            spnMoorland.Value = 4.18
            '
            'Adjust graphics
            graProps.Hide()
            imgMap.Show()
            imgMap.Image = My.Resources.HSD_LUCurrent
        End If
    End Sub

    Private Sub SelectA(sender As Object, e As EventArgs) Handles btnScenarioA.CheckedChanged
        If (btnScenarioA.Checked = True) Then
            '
            'Disable custom spinners
            Customsettings.Enabled = False
            spnBareRock.Value = 3.35
            spnForest.Value = 7.39
            spnGrassland.Value = 26.71
            spnArable.Value = 59.93
            spnMoorland.Value = 2.62
            '
            'Adjust graphics
            graProps.Hide()
            imgMap.Show()
            imgMap.Image = My.Resources.HSD_LUScenario1
        End If
    End Sub

    Private Sub SelectB(sender As Object, e As EventArgs) Handles btnScenarioB.CheckedChanged
        If (btnScenarioB.Checked = True) Then
            '
            'Disable custom spinners
            Customsettings.Enabled = False
            spnBareRock.Value = 3.71
            spnForest.Value = 24.15
            spnGrassland.Value = 34.58
            spnArable.Value = 33.45
            spnMoorland.Value = 4.11
            '
            'Adjust graphics
            graProps.Hide()
            imgMap.Show()
            imgMap.Image = My.Resources.HSD_LUScenario2
        End If
    End Sub

    Private Sub SelectC(sender As Object, e As EventArgs) Handles btnScenarioC.CheckedChanged
        If (btnScenarioC.Checked = True) Then
            '
            'Disable custom spinners
            Customsettings.Enabled = False
            spnBareRock.Value = 2.94
            spnForest.Value = 36.23
            spnGrassland.Value = 29.16
            spnArable.Value = 28.05
            spnMoorland.Value = 3.62
            '
            'Adjust graphics
            graProps.Hide()
            imgMap.Show()
            imgMap.Image = My.Resources.HSD_LUScenario3
        End If
    End Sub

    Private Sub SelectCustom(sender As Object, e As EventArgs) Handles btnCustom.CheckedChanged
        If (btnCustom.Checked = True) Then
            '
            'Enable custom spinners
            Customsettings.Enabled = True
            spnBareRock.Value = Math.Round(spnBareRock.Value, 0)
            spnForest.Value = Math.Round(spnForest.Value, 0)
            spnGrassland.Value = Math.Round(spnGrassland.Value, 0)
            spnArable.Value = Math.Round(spnArable.Value, 0)
            spnMoorland.Value = Math.Round(spnMoorland.Value, 0)
            '
            'Adjust graphics
            imgMap.Hide()
            graProps.Show()
        End If
    End Sub

    '============================
    'Pie chart magic
    '============================

    Private WithEvents Sectors As New ComponentModel.BindingList(Of SectorItem)

    Private Sub UpdatePie(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Sectors.ListChanged
        '
        'Update pie chart
        If e.ListChangedType = ComponentModel.ListChangedType.ItemChanged Then
            graProps.Series("Pie1").Points.DataBind(Sectors, "", "Value", "Label=Name")
        End If
        '
        'Update the total
        txtTotal.Text = spnForest.Value + spnArable.Value + spnGrassland.Value + spnBareRock.Value + spnMoorland.Value
        If txtTotal.Text <> 100 Then
            txtTotal.BackColor = Color.OrangeRed
        Else
            txtTotal.BackColor = Color.White
        End If


    End Sub

    Private Class SectorItem
        '
        'Magic pie chart stuff, "copied and disguised" (Quinn, 2018)
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

End Class