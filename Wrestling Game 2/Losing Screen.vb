'Patrick Celedio
'COMP 155
Option Strict On

Public Class Losing_Screen

    Private Sub Losing_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ContractForm.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        End If

        ' Losing dialogue
        lstCutscene1.Items.Add("Better luck next time, " & ContractForm.txtName.Text & "! ")
        lstCutscene1.Items.Add("How about next week, I'll schedule you a rematch?")
        lstCutscene1.Items.Add("Use your loss as momentum to come back!")
    End Sub

    Private Sub txtOkay_Click(sender As Object, e As EventArgs) Handles txtOkay.Click
        ' This code hides the current form and brings back the match form
        Me.Hide()
        Match1.Show()
    End Sub
End Class