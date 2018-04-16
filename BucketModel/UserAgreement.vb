'Authors:       Philip Ayre and Shannon Leakey
'Description:   User agreement that you must accept
'
Option Explicit On

Public Class UserAgreement

    '============================
    'Variable Declaration
    '============================
    '
    'For exiting the form
    Dim blnExit As System.Windows.Forms.DialogResult

    '============================
    'General form stuff
    '============================

    Private Sub LoadUserAgreement(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.CenterToParent()
    End Sub

    Private Sub CloseUserAgreement(sender As Object, e As EventArgs) Handles btnExit.Click
        blnExit = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If blnExit = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub CheckExit(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnExit <> Windows.Forms.DialogResult.Yes Then
            e.Cancel = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes
        End If
    End Sub

    Private Sub CheckAgree(sender As Object, e As EventArgs) Handles btnAgree.Click
        blnExit = vbYes
        Dim SecondForm As New LandUseForm
        SecondForm.Show()
        Me.Close()
    End Sub

End Class