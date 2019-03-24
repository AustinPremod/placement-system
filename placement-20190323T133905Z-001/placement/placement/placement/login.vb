Imports System.Net.Mail
Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        user = TextBox1.Text
        Dim pass As String
        pass = TextBox2.Text
        If user = "user1" And pass = "pass1" Then
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()
            search.Show()
        ElseIf user = "USER1" And pass = "PASS1" Then
            MsgBox("CAPS ON!!!!!.")
        Else : MsgBox("Login Unsuccessful. Please try again.")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Mail As New MailMessage
        Mail.Subject = "test email"
        Mail.To.Add("placementsystem123@gmail.com") 'input email id of the resever
        Mail.From = New MailAddress("placementsystem123@gmail.com") 'input your email 
        Mail.Body = "YOUR USERNAME IS : user1 AND YOUR PASSWORD IS : pass1"

        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("placementsystem123", "password") 'input your email and password 

        SMTP.Send(Mail)
    End Sub
End Class


