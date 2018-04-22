Public Class John
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        vb_botz.Show()
    End Sub

    Function GetUserName() As String
        If TypeOf My.User.CurrentPrincipal Is
          Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String = CStr(TextBox1.Text)
        Dim botAnswer As String
        If CInt(TextBox1.Text.Length) > 0 Then
            ListBox1.Items.Add("Me: " + msg)
            Select Case msg
                Case "Hello"
                    botAnswer = "Hello " + GetUserName() + "!"
                Case "Hi"
                    botAnswer = "Hello " + GetUserName() + "!"
                Case "How are you?"
                    botAnswer = "Good enough to answer you by script wroted by my author))..."
                Case "How are you doing?"
                    botAnswer = "I am fine. Thanks, and you?"
                Case Else
                    botAnswer = "I need bigger word library"
            End Select
            ListBox1.Items.Add("John: " + botAnswer)
            TextBox1.Text = ""
        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class