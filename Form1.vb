Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClickThis.Click
        If lblHelloWorld.Text <> "" Then
            lblHelloWorld.Text = ""
        Else
            lblHelloWorld.Text = "Hello World!"
        End If
    End Sub
End Class


