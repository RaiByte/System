Imports MySql.Data.MySqlClient

Public Class LoginForm

    Dim conn As New MySqlConnection("Server=localhost;User Id=root;Password=06092004;Database=IncidentReport;")

    Private Sub Linklogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linklogin.LinkClicked
        Dim signupPage As New Signup()
        signupPage.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If Username2txtbox.Text = "" Or passwordtxtbox.Text = "" Then
            MessageBox.Show("Please enter username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()


            Dim query As String = "SELECT user_id, First_Name, Username, Account_Type FROM Signup WHERE Username=@Username AND Password=@Password"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", Username2txtbox.Text)
            cmd.Parameters.AddWithValue("@Password", passwordtxtbox.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                userID = reader("user_id")
                LoggedInUsername = reader("Username").ToString()
                LoggedInFirstName = reader("First_Name")


                Dim accountType As String = reader("Account_Type").ToString()

                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                reader.Close()
                conn.Close()


                If accountType.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
                    Dim adminPage As New Admin()
                    adminPage.Show()
                ElseIf accountType.Equals("User", StringComparison.OrdinalIgnoreCase) Then
                    Dim homePage As New HomePage()
                    homePage.Show()
                Else
                    Dim homePage As New HomePage()
                    homePage.Show()
                End If

                Me.Hide()
            Else
                reader.Close()
                MessageBox.Show("Account does not exist. Please check your username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As MySqlException
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PasswordCB2_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordCB2.CheckedChanged
        If PasswordCB2.Checked = True Then
            passwordtxtbox.UseSystemPasswordChar = False
        Else
            passwordtxtbox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Forgotpsswrdlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim forgot As New ForgotPassword
        forgot.Show()
        Me.Close()
    End Sub
End Class