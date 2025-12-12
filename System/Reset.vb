Imports MySql.Data.MySqlClient

Public Class Reset
    Dim conn As New MySqlConnection("Server=localhost; user id=root; password=06092004; database=IncidentReport")

    Dim targetEmail As String
    Dim sentOTP As String

    ' Custom Constructor to accept Email and OTP from the previous form
    Public Sub New(email As String, otp As String)
        InitializeComponent() ' Required to load the form design
        targetEmail = email
        sentOTP = otp
    End Sub

    Private Sub OTPbtn_Click(sender As Object, e As EventArgs) Handles OTPbtn.Click
        ' Username2txtbox is the OTP text box based on Designer file
        Dim enteredOTP As String = Username2txtbox.Text
        ' TextBox1 is the New Password text box based on Designer file
        Dim newPassword As String = passbx.Text

        ' 1. Verify OTP
        If enteredOTP <> sentOTP Then
            MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 2. Validate Password
        If String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 3. Update Password in Database
        Try
            conn.Open()
            Dim query As String = "UPDATE Signup SET Password = @Password WHERE Email = @Email"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Password", newPassword)
            cmd.Parameters.AddWithValue("@Email", targetEmail)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Password successfully reset! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim login As New LoginForm()
                login.Show()
                Me.Close()
            Else
                MessageBox.Show("Error updating password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Clear fields on load
        Username2txtbox.Clear()
        passbx.Clear()
    End Sub

    Private Sub PasswordCB2_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordCB2.CheckedChanged
        If PasswordCB2.Checked = True Then
            passbx.UseSystemPasswordChar = False
        Else
            passbx.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Dim forgot As New ForgotPassword
        forgot.Show()
        Me.Close()
    End Sub
End Class