Option Strict On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim st As String = txtInput.Text
        ' 1 pass algorithm
        Dim result As String = " "
        For i As Integer = st.Length - 1 To 0 Step -1
            result& = st.Chars(i)

        Next

        txtOutput.Text = "Not implemented yet!"
    End Sub
End Class
