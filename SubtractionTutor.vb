Public Class SubtractionTutor
    Dim num1, num2, temp As Integer
    Dim randomX As New Random
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        num1 = randomX.Next(10, 100)
        num2 = randomX.Next(10, 100)
        If num1 < num2 Then
            temp = num1
            num1 = num2
            num2 = temp
        End If
        num1Label.Text = CStr(num1)
        num2Label.Text = CStr(num2)
    End Sub
    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        keyLabel.Text = ""
        resultLabel.Text = ""
        userAnsTextBox.Text = ""
        num1 = randomX.Next(10, 100)
        num2 = randomX.Next(10, 100)
        If num1 < num2 Then
            temp = num1
            num1 = num2
            num2 = temp
        End If
        num1Label.Text = CStr(num1)
        num2Label.Text = CStr(num2)
    End Sub
    Private Sub verifyButton_Click(sender As Object, e As EventArgs) Handles verifyButton.Click
        Dim userAns, key As Integer
        userAns = CInt(userAnsTextBox.Text)
        key = num1 - num2
        keyLabel.Text = CStr(key)
        If key = userAns Then
            resultLabel.Text = "Correct"
        Else
            resultLabel.Text = "Incorrect"
        End If
    End Sub
End Class
