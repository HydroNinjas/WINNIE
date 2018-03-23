Public Class UserAgreement
    Private Sub UserAgreement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.CenterToParent()
    End Sub

    Dim ExitYN As System.Windows.Forms.DialogResult

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click

        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub UserAgreement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If ExitYN <> Windows.Forms.DialogResult.Yes Then
            e.Cancel = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes
        End If
    End Sub


    Private Sub AgreBtn_Click(sender As Object, e As EventArgs) Handles AgreBtn.Click

        ExitYN = MsgBox("Are you sure?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then

            Dim SecondForm As New Model
            SecondForm.Show()
            Me.Close()
        Else
        End If
    End Sub

End Class