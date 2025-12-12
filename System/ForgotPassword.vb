Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Net

Public Class ForgotPassword
    ' Connection string from your code
    Dim conn As New MySqlConnection("Server=localhost; user id=root; password=06092004; database=IncidentReport")

    ' Shared variable to pass to Reset form
    Dim generatedOTP As String

    Private Sub OTPbtn_Click(sender As Object, e As EventArgs) Handles OTPbtn.Click
        Dim userEmail As String = txtEmail.Text

        If String.IsNullOrEmpty(userEmail) Then
            MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 1. Check if email exists
        If Not EmailExistsInDB(userEmail) Then
            MessageBox.Show("Email not registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 2. Generate OTP
        generatedOTP = New Random().Next(100000, 999999).ToString()

        ' 3. Send Email
        If SendOTPEmail(userEmail, generatedOTP) Then
            MessageBox.Show("OTP has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 4. Transition to Reset Form
            ' We pass both the Email and the OTP to the Reset form to verify later
            Dim frmReset As New Reset(userEmail, generatedOTP)
            frmReset.Show()
            Me.Hide()
        Else
            MessageBox.Show("Failed to send OTP email. Please check your internet connection or email settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function EmailExistsInDB(email As String) As Boolean
        Dim exists As Boolean = False
        Try
            conn.Open()
            ' Checking the Signup table as seen in LoginForm.vb logic
            Dim query As String = "SELECT * FROM Signup WHERE Email = @Email"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", email)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                exists = True
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return exists
    End Function

    Private Function SendOTPEmail(emailTo As String, otp As String) As Boolean
        Try
            Dim fromEmail As String = "incidentreport81@gmail.com" ' REPLACE THIS
            Dim fromPassword As String = "kmfb mshu tefb xblm" ' REPLACE THIS (Use App Password, not real password)

            Dim mail As New MailMessage()
            mail.From = New MailAddress(fromEmail)
            mail.To.Add(emailTo)
            mail.Subject = "Password Reset OTP"
            mail.Body = "Your OTP for password reset is: " & otp

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(fromEmail, fromPassword)

            smtp.Send(mail)
            Return True
        Catch ex As Exception
            MessageBox.Show("Mail Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Dim login As New LoginForm
        login.Show()
        Me.Close()
    End Sub
End Class
