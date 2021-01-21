' Patrick Celedio
' COMP250
Option Strict On

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ContractForm.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        End If

        lstCutscene1.Items.Add("Impressive match, " & ContractForm.txtName.Text & "! ")
        lstCutscene1.Items.Add("I see you as a wrestler that will have a long career in this company!")
        lstCutscene1.Items.Add("Remember, I sense high expectations from you!")

    End Sub

    Private Sub txtOkay_Click(sender As Object, e As EventArgs) Handles txtOkay.Click
        Me.Hide()
        About.Show()
    End Sub
End Class