Public Class Crypto
    Private Sub Encrypt_Click(sender As Object, e As EventArgs) Handles Encrypt.Click
        Dim mode As String = lblMode.Text
        Dim cesN As Integer = txtCeaser.Text
        Dim msg As String = txtMsg.Text

        ' ceaser number check
        If CInt(txtCeaser.Text) > 26 Then
            txtCeaser.Text = "26"
        ElseIf CInt(txtCeaser.Text) < 0 Then
            txtCeaser.Text = "0"
        End If

        ' encrypt and decrypt
        If mode = "ceasar" Then
            Dim cesRes As String = Ceasar_cipher(msg, cesN, True)
            txtEnc.Text = cesRes
        ElseIf mode = "ascii" Then
            txtEnc.Text = Asc(msg)
        ElseIf mode = "a1z26" Then

        Else
            MsgBox("Choose mode")
        End If

        ' Always in the end
        msg = ""
    End Sub

    Private Sub Decrypt_Click(sender As Object, e As EventArgs) Handles Decrypt.Click
        Dim mode As String = lblMode.Text
        Dim cesN As Integer = txtCeaser.Text
        Dim msg As String = txtMsg.Text

        ' ceaser number check
        If CInt(txtCeaser.Text) > 26 Then
            txtCeaser.Text = "26"
        ElseIf CInt(txtCeaser.Text) < 0 Then
            txtCeaser.Text = "0"
        End If

        ' encrypt and decrypt
        If mode = "ceasar" Then
            Dim cesRes As String = Ceasar_cipher(msg, cesN, False)
            txtEnc.Text = cesRes
        ElseIf mode = "ascii" Then

        ElseIf mode = "a1z26" Then

        Else
            MsgBox("Choose mode")
        End If

        ' Always in the end
        msg = ""
    End Sub


    Function Ceasar_cipher(ByVal text As String, ByVal N As Integer, ByVal crypt As Boolean)
        Dim result As String = ""

        For Each c As Char In text
            Dim x As Integer
            If crypt Then
                x = Asc(c) + N
            Else
                x = Asc(c) + 26 - N
            End If

            If Char.IsLower(c) Then
                If x > Asc("z") Then
                    x -= 26
                End If
                result += Chr(x)

            ElseIf Char.IsUpper(c) Then
                If x > Asc("Z") Then
                    x -= 26
                End If
                result += Chr(x)
            Else
                result += c
            End If
        Next

        Return result
    End Function

    Public Sub btnCeaserSet_Click(sender As Object, e As EventArgs) Handles btnCeaserSet.Click
        btnCeaserMin.Visible = True
        btnCeaserPlus.Visible = True
        txtCeaser.Visible = True
        lblMode.Text = "ceasar"
    End Sub

    Public Sub btnASCIISet_Click(sender As Object, e As EventArgs) Handles btnASCIISet.Click
        lblMode.Text = "DISABLED"
        btnCeaserMin.Visible = False
        btnCeaserPlus.Visible = False
        txtCeaser.Visible = False
    End Sub

    Private Sub btnA1Z26Set_Click(sender As Object, e As EventArgs) Handles btnA1Z26Set.Click
        lblMode.Text = "DISABLED"
        btnCeaserMin.Visible = False
        btnCeaserPlus.Visible = False
        txtCeaser.Visible = False
    End Sub

    Private Sub Crypto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCeaserMin.Visible = False
        btnCeaserPlus.Visible = False
        txtCeaser.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        vb_botz.Show()
    End Sub

    Private Sub btnCeaserMin_Click(sender As Object, e As EventArgs) Handles btnCeaserMin.Click
        Try
            Dim cesInt As Integer = txtCeaser.Text
            If cesInt = 0 Then

            Else
                cesInt = cesInt - 1
                txtCeaser.Text = cesInt
            End If
        Catch ex As Exception
            MsgBox("Must be number")
        End Try
    End Sub

    Private Sub btnCeaserPlus_Click(sender As Object, e As EventArgs) Handles btnCeaserPlus.Click
        Try
            Dim cesInt As Integer = txtCeaser.Text
            If cesInt = 26 Then

            Else
                cesInt = cesInt + 1
                txtCeaser.Text = cesInt
            End If
        Catch ex As Exception
            MsgBox("Must be number")
        End Try
    End Sub

    Private Sub setVal_Click(sender As Object, e As EventArgs) Handles setVal.Click
        txtMsg.Text = txtEnc.Text
    End Sub
End Class