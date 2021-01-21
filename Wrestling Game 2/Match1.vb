' Patrick Celedio
' COMP250
Option Strict On

Public Class Match1

    Dim Chance As New Random

    Private Sub Match1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Cutscene1.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        End If

        ' Opponents Health Bar
        progBarJobber.Increment(1)
        progBarJobber.Value = 100

        ' Player health bar
        progBarPlayerHealth.Increment(1)
        progBarPlayerHealth.Value = 100

        ' Details at match start
        lstDetails.Items.Add("Patrick Celedio has " & progBarJobber.Value & "health!" & " You have " & progBarPlayerHealth.Value & " health!")
        lstDetails.TopIndex = lstDetails.Items.Count - 1

        ' Name plate
        lstName.Items.Add(ContractForm.txtName.Text)

    End Sub
    Private Sub btnPunch_Click(sender As Object, e As EventArgs) Handles btnPunch.Click

        ' If player health is low, the computer will go for the pin
        If progBarPlayerHealth.Value = 0 Then
            ' 1 in 5 chance of losing
            If Chance.Next(5) = 1 Then
                ' This code allows the opponent to counter and try to pin you
                lstDetails.Items.Add("Patrick Celedio countered your strike and is going for the pin!")
                lstDetails.Items.Add("1, 2, ...3!!!.. You lost the match...")
                lstDetails.TopIndex = lstDetails.Items.Count - 1

                ' This code will reset everything on this form
                lstDetails.Items.Clear()
                progBarJobber.Value = 100
                progBarPlayerHealth.Value = 100
                progBarFinisherOpponent.Value = 0
                progBarPlayerFinisher.Value = 0

                ' 1 in 5 chance of a dramatic kick out
            ElseIf Chance.Next(5) = 3 Then
                lstDetails.Items.Add("Patrick Celedio countered your strike and is going for the pin!")
                lstDetails.Items.Add("Wow! Kick out at 2.9!!!!")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                progBarPlayerHealth.Value += 20
            Else
                ' 4 in 5 chance of kicking out of the pin
                lstDetails.Items.Add("Patrick Celedio countered your strike and is going for the pin!")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                lstDetails.Items.Add("...1")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                lstDetails.Items.Add("Kickout at 1. Match goes on")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                progBarPlayerHealth.Value += 30
            End If
        End If

        If progBarJobber.Value = 0 Then
            ' Match can only end with a pin!
            lstDetails.Items.Add("You should go for the pin!")
            lstDetails.TopIndex = lstDetails.Items.Count - 1
        Else
            ' One in ten chance of being countered
            If Chance.Next(5) = 1 Then
                lstDetails.Items.Add("Patrick Celedio countered your punch and striked back hurting you by .5 points!")
                lstDetails.TopIndex = lstDetails.Items.Count - 1 ' Updates the listbox 
                progBarFinisherOpponent.Value += 10 ' Counters add momentum to opponents finisher bar
                progBarPlayerHealth.Value -= 5 ' Player takes damage
            ElseIf progBarFinisherOpponent.Value = 100 Then

                ' If opponent's finisher is ready, then 1 in 5 chance of hitting
                If Chance.Next(5) = 3 Then
                    lstDetails.Items.Add("Patrick Celedio countered your punch and did his finisher on you, the omelette suplex! You lose 3 points!")
                    progBarPlayerHealth.Value -= 30
                    progBarFinisherOpponent.Value = 0
                Else
                    lstDetails.Items.Add("Patrick Celedio countered your punch and tried to do his finisher on you, but failed..")
                    progBarFinisherOpponent.Value = 0
                End If
            Else
                ' Nine in to ten chance of hitting opponent
                lstDetails.Items.Add("You hurt Patrick Celedio by 1 point!")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                If progBarJobber.Value < 9 Then
                    progBarJobber.Value = 0
                Else
                    ' Error handling, if progress is already at 100
                    progBarJobber.Value -= 10
                    If progBarPlayerFinisher.Value = 100 Then
                        progBarPlayerFinisher.Value += 0
                    ElseIf progBarPlayerFinisher.Value > 96 Then
                        progBarPlayerFinisher.Value = 100
                    Else
                        progBarPlayerFinisher.Value += 5
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnSuplex_Click(sender As Object, e As EventArgs) Handles btnSuplex.Click


        If progBarPlayerHealth.Value = 0 Then
            If Chance.Next(3) = 1 Then

                lstDetails.Items.Add("Patrick Celedio countered your grapple move and is going for the pin!")
                lstDetails.Items.Add("1, 2, ...3!!!.. You lost the match...")
                lstDetails.TopIndex = lstDetails.Items.Count - 1

                ' This code will reset everything on this form
                lstDetails.Items.Clear()
                progBarJobber.Value = 100
                progBarPlayerHealth.Value = 100
                progBarFinisherOpponent.Value = 0
                progBarPlayerFinisher.Value = 0

            ElseIf Chance.Next(3) = 3 Then

                lstDetails.Items.Add("Patrick Celedio countered your grapple move and is going for the pin!")
                lstDetails.Items.Add("Wow! Kick out at 2.9!!!!")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                progBarPlayerHealth.Value += 20

            Else

                lstDetails.Items.Add("Patrick Celedio countered your grapple move and is going for the pin!")
                lstDetails.Items.Add("Kickout at 1. Match goes on")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                progBarPlayerHealth.Value += 30

            End If
        End If



        If progBarJobber.Value = 0 Then

            lstDetails.Items.Add("You should go for the pin!")
            lstDetails.TopIndex = lstDetails.Items.Count - 1

        Else
            If Chance.Next(6) = 1 Then

                lstDetails.Items.Add("Patrick Celedio countered your grapple move and striked back hurting you by 1.5 points!")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                progBarFinisherOpponent.Value += 10
                progBarPlayerHealth.Value -= 15

            ElseIf progBarFinisherOpponent.Value = 100 Then
                If Chance.Next(6) = 3 Then

                    lstDetails.Items.Add("Patrick Celedio countered your grapple move and did his finisher on you, the omelette suplex! You lose 3 points!")
                    lstDetails.TopIndex = lstDetails.Items.Count - 1
                    progBarPlayerHealth.Value -= 30
                    progBarFinisherOpponent.Value = 0

                Else

                    lstDetails.Items.Add("Patrick Celedio countered your grapple move and tried to do his finisher on you, but failed..")
                    lstDetails.TopIndex = lstDetails.Items.Count - 1
                    progBarFinisherOpponent.Value = 0

                End If
            Else
                lstDetails.Items.Add("You hurt Patrick Celedio by 2 points!")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                If progBarJobber.Value < 19 Then
                    progBarJobber.Value = 0
                Else
                    ' Error handling, if progress bar is already at 100
                    progBarJobber.Value -= 20
                    If progBarPlayerFinisher.Value = 100 Then
                        progBarPlayerFinisher.Value += 0
                    ElseIf progBarPlayerFinisher.Value > 81 Then
                        progBarPlayerFinisher.Value = 100
                    Else
                        progBarPlayerFinisher.Value += 20
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnFinisher_Click(sender As Object, e As EventArgs) Handles btnFinisher.Click

        If progBarPlayerHealth.Value = 0 Then
            If Chance.Next(5) = 1 Then
                lstDetails.Items.Add("Patrick Celedio countered " & ContractForm.txtFinisherName.Text & " is going for the pin!")
                lstDetails.Items.Add("1, 2, .............3!!!.. You lost the match...")
                lstDetails.TopIndex = lstDetails.Items.Count - 1

                ' This code will reset everything on this form
                lstDetails.Items.Clear()
                progBarJobber.Value = 100
                progBarPlayerHealth.Value = 100
                progBarFinisherOpponent.Value = 0
                progBarPlayerFinisher.Value = 0

            ElseIf Chance.Next(5) = 3 Then

                lstDetails.Items.Add("Patrick Celedio countered " & ContractForm.txtFinisherName.Text & " is going for the pin!")
                lstDetails.Items.Add("Wow! Kick out at 2.9!!!!")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                progBarPlayerHealth.Value += 10
                progBarPlayerFinisher.Value = 0

            Else

                lstDetails.Items.Add("Patrick Celedio countered " & ContractForm.txtFinisherName.Text & " is going for the pin!")
                lstDetails.Items.Add("Kickout at 1. Match goes on")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
                progBarPlayerHealth.Value += 10
                progBarPlayerFinisher.Value = 0

            End If
        End If

        If progBarJobber.Value = 0 Then
            lstDetails.Items.Add("You should go for the pin!")
            lstDetails.TopIndex = lstDetails.Items.Count - 1
        Else
            If progBarPlayerFinisher.Value = 100 Then
                If Chance.Next(3) = 1 Then

                    lstDetails.Items.Add("Patrick Celedio countered the " & ContractForm.txtFinisherName.Text & " and inflicted damage on you by 3 points!")
                    lstDetails.TopIndex = lstDetails.Items.Count - 1
                    progBarFinisherOpponent.Value += 30
                    progBarPlayerHealth.Value -= 30
                    progBarPlayerFinisher.Value = 0

                Else
                    lstDetails.Items.Add("You hurt Patrick Celedio by 6 points!")
                    lstDetails.TopIndex = lstDetails.Items.Count - 1
                    progBarPlayerFinisher.Value = 0
                    If progBarJobber.Value < 50 Then
                        progBarJobber.Value = 0
                    ElseIf progBarJobber.Value < 59 Then
                        progBarJobber.Value = 0
                        progBarPlayerFinisher.Value = 0
                    End If
                End If
            Else
                lstDetails.Items.Add("You do not have enough excitement to do your finisher!")
                lstDetails.TopIndex = lstDetails.Items.Count - 1
            End If
        End If

    End Sub

    Private Sub btnPin_Click(sender As Object, e As EventArgs) Handles btnPin.Click

        If progBarJobber.Value = 0 Then
            If Chance.Next(3) = 1 Then
                MessageBox.Show(ContractForm.txtName.Text & " is going for the pin! 1, 2, .................3!!!.." & ContractForm.txtName.Text & " won the match!")

                'Resets the progress bars and list box after winning 
                lstDetails.Items.Clear()
                progBarJobber.Value = 100
                progBarPlayerHealth.Value = 100
                progBarFinisherOpponent.Value = 0
                progBarPlayerFinisher.Value = 0

                'Shows next form
                Me.Hide()
                Form2.Show()

            ElseIf Chance.Next(3) = 2 Then

                MessageBox.Show(ContractForm.txtName.Text & " is going for the pin! Wow! Kick out at 2.9!!!!")
                progBarJobber.Value += 20

            ElseIf Chance.Next(3) = 3 Then

                MessageBox.Show("Patrick Celedio countered " & ContractForm.txtFinisherName.Text & " is going for the pin! Kickout at 1. Match goes on.")
                progBarJobber.Value += 30
            End If

        ElseIf progBarJobber.Value > 0 Then
            ' Cannot pin opponent when they still have health
            MessageBox.Show("Patrick is too conscious to be pinned!")
        End If
    End Sub
End Class