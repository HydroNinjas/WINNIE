Imports ComponentModel = System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting
Public Module Globalvariables
    Public LUChoice As String
    Public ForestP As Double
    Public ArableP As Double
    Public GrasslandP As Double
    Public BareRockP As Double
    Public MoorlandP As Double
    Public Control As Boolean = False
End Module



Public Class LandUseForm

    Private Sub LandUse4Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse4Btn.CheckedChanged
        If (LandUse4Btn.Checked = True) Then
            Customsettings.Enabled = True
            LandImage.Hide()
            LUPie.Show()

        End If
    End Sub

    Private Sub LandUse3Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse3Btn.CheckedChanged
        If (LandUse3Btn.Checked = True) Then
            Customsettings.Enabled = False
            NumericUpDown1.Value = 20
            NumericUpDown2.Value = 20
            NumericUpDown3.Value = 10
            NumericUpDown4.Value = 30
            NumericUpDown5.Value = 20

            LandImage.Show()
            LandImage.Image = Image.FromFile("C:\Users\phili\Pictures\3.jpg")
            LUPie.Hide()
        End If
    End Sub

    Private Sub LandUse5Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse5Btn.CheckedChanged
        If (LandUse5Btn.Checked = True) Then
            Customsettings.Enabled = False
            NumericUpDown1.Value = 30
            NumericUpDown2.Value = 10
            NumericUpDown3.Value = 20
            NumericUpDown4.Value = 20
            NumericUpDown5.Value = 20

            LandImage.Show()
            LandImage.Image = Image.FromFile("C:\Users\phili\Pictures\3.jpg")
            LUPie.Hide()
        End If
    End Sub
    Private Sub LandUse2Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse2Btn.CheckedChanged
        If (LandUse2Btn.Checked = True) Then
            Customsettings.Enabled = False
            NumericUpDown1.Value = 20
            NumericUpDown2.Value = 20
            NumericUpDown3.Value = 10
            NumericUpDown4.Value = 30
            NumericUpDown5.Value = 20

            LandImage.Show()
            LandImage.Image = Image.FromFile("C:\Users\phili\Pictures\2.jpg")
            LUPie.Hide()
        End If
    End Sub

    Private Sub LandUse1Btn_CheckedChanged(sender As Object, e As EventArgs) Handles LandUse1Btn.CheckedChanged
        If (LandUse1Btn.Checked = True) Then
            Customsettings.Enabled = False
            NumericUpDown1.Value = 20
            NumericUpDown2.Value = 10
            NumericUpDown3.Value = 20
            NumericUpDown4.Value = 30
            NumericUpDown5.Value = 20

            LandImage.Show()
            LandImage.Image = Image.FromFile("C:\Users\phili\Pictures\1.jpg")
            LUPie.Hide()
        End If

    End Sub


    Private WithEvents Sectors As New ComponentModel.BindingList(Of SectorItem)

    Private Sub LandUseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = Color.LightSkyBlue
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.Size = New Size(800, 800)
        Me.CenterToParent()

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
        If LUChoice = "Custom" Then
            LandUse4Btn.Checked = True
            NumericUpDown1.Value = ForestP
            NumericUpDown2.Value = ArableP
            NumericUpDown3.Value = GrasslandP
            NumericUpDown4.Value = BareRockP
            NumericUpDown5.Value = MoorlandP
        ElseIf LUChoice = "Current" Then
            LandUse5Btn.Checked = True
        ElseIf LUChoice = "Change 1" Then
            LandUse1Btn.Checked = True
        ElseIf LUChoice = "Change 2" Then
            LandUse2Btn.Checked = True
        ElseIf LUChoice = "Change 3" Then
            LandUse3Btn.Checked = True


        End If
    End Sub

    ''' <summary>
    ''' </summary>
    ''' 
    Private Sub Sectors_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Sectors.ListChanged
        If e.ListChangedType = ComponentModel.ListChangedType.ItemChanged Then
            LUPie.Series("Pie1").Points.DataBind(Sectors, "", "Value", "Label=Name")
        End If

        TxtBoxTotal.Text = NumericUpDown1.Value + NumericUpDown2.Value + NumericUpDown3.Value + NumericUpDown4.Value + NumericUpDown5.Value

    End Sub

    ''' <summary>
    ''' </summary>
    Private Class SectorItem
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
        If NumericUpDown1.Value + NumericUpDown2.Value + NumericUpDown3.Value + NumericUpDown4.Value + NumericUpDown5.Value = 100 Then
            If (LandUse4Btn.Checked = True) Then
                LUChoice = "Custom"
            ElseIf (LandUse3Btn.Checked = True) Then
                LUChoice = "Change 3"
            ElseIf (LandUse2Btn.Checked = True) Then
                LUChoice = "Change 2"
            ElseIf (LandUse1Btn.Checked = True) Then
                LUChoice = "Change 1"
            ElseIf (LandUse5Btn.Checked = True) Then
                LUChoice = "Current"
            End If
            ForestP = NumericUpDown1.Value
            ArableP = NumericUpDown2.Value
            GrasslandP = NumericUpDown3.Value
            BareRockP = NumericUpDown4.Value
            MoorlandP = NumericUpDown5.Value
            Model.Show()
            Me.Close()
            Control = True

        Else MessageBox.Show(" Please enter a land combination that sums to 100%", "Error")
        End If

    End Sub

    Private Sub LFcancelBtn_Click(sender As Object, e As EventArgs) Handles LFcancelBtn.Click
        If Control = False Then
            MsgBox("To continue with the programme please select a option and click Ok")
        Else
            Me.Close()
        End If


    End Sub

End Class