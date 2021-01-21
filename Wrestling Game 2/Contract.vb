' Patrick Celedio
' COMP250
Option Strict On

Public Class ContractForm

    Private Sub ContractForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TitleScreenForm.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        TitleScreenForm.Show()
    End Sub


    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click

        Try
            Dim Name As String = txtName.Text
            Dim Age As Integer = CInt(txtAge.Text)
            Dim FinisherName As String = txtFinisherName.Text


            Me.Hide()
            Cutscene1.Show()

        Catch ex As Exception
            MessageBox.Show("Please enter only an integer number as your age.")
            txtAge.Clear()
            txtAge.Focus()
        End Try

    End Sub
End Class