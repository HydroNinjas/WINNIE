'Authors:       Philip Ayre and Shannon Leakey, Ninja Developments
'Description:   User agreement that you must accept
'
' List of abbrevations:
' str equals string 
' dbl equals double  
' bln equals boolean
' Prop equals proportion
' srs equals series
' gra equals graph
' btn equals button
' txt equals text
' spn equals spinner
' img equals image
' msg equals message
' obs equals observed 
' sim equals simulation
' FC equals field capacity
' dte equals date
' hrs equals hours
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