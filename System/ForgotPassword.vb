Imports MySql.Data.MySqlClient
Public Class ForgotPassword
    Dim conn As New MySqlConnection("Server=localhost; user id=root; password=06092004; database=IncidentReport")

    Private Sub OTPbtn_Click(sender As Object, e As EventArgs) Handles OTPbtn.Click
        Dim userEmail As String = txtEmail.Text

        ' 1. Check if email exists (Database function placeholder)
        If Not EmailExistsInDB(userEmail) Then
            MessageBox.Show("Email not registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 2. Generate and Store OTP (Database/Helper function placeholder)
        Dim generatedOTP As String = GenerateAndStoreOTP(userEmail)

        ' 3. Send Email (Email function placeholder)
        If SendOTPEmail(userEmail, generatedOTP) Then
            MessageBox.Show("OTP has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 4. Transition to Reset Form
            Dim frmReset As New Reset(userEmail) ' Pass the email to the next form
            frmReset.Show()
            Me.Hide()
        Else
            MessageBox.Show("Failed to send OTP email. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class