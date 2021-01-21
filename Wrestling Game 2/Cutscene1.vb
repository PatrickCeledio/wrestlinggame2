' Patrick Celedio
' COMP250
Option Strict On

Public Class Cutscene1

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ContractForm.Show()
    End Sub

    Private Sub Cutscene1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ContractForm.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        End If

        lstCutscene1.Items.Add("Welcome to my company, " & ContractForm.txtName.Text & ". ")
        lstCutscene1.Items.Add("You are " & ContractForm.txtAge.Text & " years old and your finishing move is the " & ContractForm.txtFinisherName.Text)
        lstCutscene1.Items.Add("Hmm... interesting. I've seen people come and go, but I sense high expectations from you!")
        lstCutscene1.Items.Add("Tonight you have your match against 'The Guy' Patrick Celedio! Good luck!")

    End Sub

    Private Sub txtOkay_Click(sender As Object, e As EventArgs) Handles txtOkay.Click
        Match1.Show()
        Me.Hide()
    End Sub
End Class