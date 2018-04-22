Public Class vb_botz
    Private Sub LinkGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkGithub.LinkClicked
        Process.Start("https://github.com/loaderunldr/vb/")
    End Sub

    Private Sub LinkAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAbout.LinkClicked
        Me.Hide()
        About.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        John.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Crypto.Show()
    End Sub
End Class
