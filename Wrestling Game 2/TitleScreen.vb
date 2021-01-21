' Patrick Celedio
' COMP250
Option Strict On

Public Class TitleScreenForm

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        ' Title Screen
        ContractForm.Show() 'Goes straight to character creation

    End Sub

    Private Sub btnCloseTitle_Click(sender As Object, e As EventArgs) Handles btnCloseTitle.Click
        Me.Close()
    End Sub

    Private Sub TitleScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub
End Class
