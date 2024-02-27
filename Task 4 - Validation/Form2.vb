Public Class Form2
    'Second part of Task 4 - Validation, Created by Dario Gerald'

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    'A simple algorithm that clears all the values that can have inputs'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTitle.Clear()
        txtSurname.Clear()
        txtTestOne.Clear()
        txtTestTwo.Clear()
        txtOut.Clear()
    End Sub
    'Similar to the Yes or No in the first form, this algorithm ensures that the answers are only what are the options.'
    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        If txtTitle.Text <> "Mr" And txtTitle.Text <> "Miss" And txtTitle.Text <> "Ms" And txtTitle.Text <> "Mrs" Then
            MsgBox("Your answer must be either Mr, Miss, Ms or Mrs. Make sure only the first letter is capitalised.")
        End If

        If Len(txtSurname.Text) >= 0 And Len(txtSurname.Text) >= 15 Then 'Uses the 'Len' function to calcualate the amount of charecters. Ensures it's between 0 and 15' 
            MsgBox("Surname must be from 0 to 15 charecters in length.") 'Message box that helps the user to input properly'
        End If

        'This is a quite complex algorithm to make sure that each of the boxes fit the criteria.'

        If Not IsNumeric(txtTestOne.Text) Or txtTestOne.Text < 0 Or txtTestOne.Text > 50 Then 'The parameters of this function is to make sure it is firstly numeric and lies between 0 and 50'
            MsgBox("Test One must be a number between 0 and 50.") 'Message box to assist the user'
            Exit Sub
        End If

        'Same process is repeated for the second test scores' 
        If Not IsNumeric(txtTestTwo.Text) Or txtTestTwo.Text < 0 Or txtTestTwo.Text > 50 Then
            MsgBox("Test Two must be a number between 0 and 50.")
            Exit Sub
        End If

        'Very similar process, just ensures that the final summation also aligns with the parameters'
        If Not IsNumeric(txtOut.Text) Or txtOut.Text < 0 Or txtOut.Text > 100 Then
            MsgBox("Total must be a number between 0 and 100.")
            Exit Sub
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtOut_TextChanged(sender As Object, e As EventArgs) Handles txtOut.TextChanged

    End Sub
End Class