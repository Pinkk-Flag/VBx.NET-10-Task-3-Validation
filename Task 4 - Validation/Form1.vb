Public Class Form1

    'Task 4 - Validation, created by Dario Gerald on 21/08/23'
    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtValidate_TextChanged(sender As Object, e As EventArgs)

    End Sub
    'This is the main section for validation, when the user clicks it, it checks each of the algorithms.'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        'First, it ensures that the two numbers are neumeric, not other value such as strings'
        If IsNumeric(txtOne.Text) And IsNumeric(txtTwo.Text) = True Then
            'Once it is true, then it adds both values'
            txtTotal.Text = Val(txtOne.Text) + Val(txtTwo.Text)
        Else
            'If these algorithms aren't all correct, then it will display the message to help the user'
            MsgBox("Please enter a valid number")
        End If 'Ends the algorithm'

        'This algorithm makes sure that the postcode is correct, based on Victorian postcodes'
        If Val(txtPostcode.Text) <= 2999 Or Val(txtPostcode.Text) > 3999 Then
            'If the above algorithm isn't true, it'll display this to help them'
            MsgBox("Illegal postcode. Please try again. Ensure that it fits with the Victorian Standard.")
        End If

        If txtAnswer.Text <> "Yes" And txtAnswer.Text <> "No" Then
            MsgBox("You answer must be Yes or No") 'Simple algorithm that ensures that the answer is anything aside from "Yes" and "No"'
        End If


    End Sub

    Private Sub txtPostcode_TextChanged(sender As Object, e As EventArgs) Handles txtPostcode.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form2.Show() 'Simple function that helps the user navigate to the next section of the program'
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
