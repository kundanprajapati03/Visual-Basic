Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, a, res As Integer
        Dim table, title, msg As String
        a = TextBox1.Text()
        msg = "table of" & a & " is: "
        title = "table of " & a
        For i = 1 To 10
            res = a * i
            table = table & a & " * " & i & " = " & res & vbCrLf
        Next i
        MsgBox(msg & vbCrLf & table, vbOKOnly, title)

    End Sub
End Class
