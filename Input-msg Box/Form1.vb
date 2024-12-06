Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        name = InputBox("Enter your name...", "Input Name")
        MsgBox("Welcome " & name, vbInformation, "Output")
    End Sub
End Class