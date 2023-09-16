Public Class Form1
    Dim age As Int16
    Dim year As Int16

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        year = Convert.ToInt16(txtYear.Text)
        age = 2023 - year
        If age < 16 Then
            txtShow.Text = "age below 16"
            MsgBox("you are below 16 years old")

        ElseIf (age >= 16 And age < 25) Then
            txtShow.Text = "age between 16 and 25"
            MsgBox(age + " is between 16 and 25 ")

        Else
            txtShow.Text = "age above 25"
            MsgBox("you are an adult")

        End If

    End Sub
End Class
