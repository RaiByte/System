Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Signup
    Dim conn As New MySqlConnection("Server=localhost; user id=root; password=06092004; database=IncidentReport")

    Private Sub Singup_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        LoggedInUsername = Usernametxtbox.Text
        LoggedInFirstName = FirstNametxtbox.Text

        'CHECK REQUIRED FIELDS
        Dim boxes() As TextBox = {Lnametxtbox, FirstNametxtbox, MiddleInitialtxtbox, Emailtxtbox, Usernametxtbox, Passwordtxtbox}

        For Each tb As TextBox In boxes
            If String.IsNullOrWhiteSpace(tb.Text) Then
                MessageBox.Show("Please fill up all fields!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Focus()
                Exit Sub
            End If
        Next

        Try
            conn.Open()

            ' CHECK IF USERNAME ALREADY EXISTS
            Dim checkQuery As String = "SELECT COUNT(*) FROM Signup WHERE Username=@Username"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@Username", Usernametxtbox.Text)

            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Failed: The username '" & Usernametxtbox.Text & "' is already existing.",
                                "Duplicate Username",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)

                Usernametxtbox.Clear()
                Usernametxtbox.Focus()
                conn.Close()
                Exit Sub
            End If

            'INSERT DATA
            Dim query As String = "INSERT INTO Signup (LastName, First_Name, Middle_Initial, Email, Username, Password, Account_Type) 
                           VALUES (@LastName, @First_Name, @Middle_Initial, @Email, @Username, @Password, @Type)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@LastName", Lnametxtbox.Text)
            cmd.Parameters.AddWithValue("@First_Name", FirstNametxtbox.Text)
            cmd.Parameters.AddWithValue("@Middle_Initial", MiddleInitialtxtbox.Text)
            cmd.Parameters.AddWithValue("@Email", Emailtxtbox.Text)
            cmd.Parameters.AddWithValue("@Username", Usernametxtbox.Text)
            cmd.Parameters.AddWithValue("@Password", Passwordtxtbox.Text)
            cmd.Parameters.AddWithValue("@Type", "User")

            cmd.ExecuteNonQuery()

            MessageBox.Show("Account created successfully!", "Success")

            conn.Close()

            Dim loginPage As New LoginForm()
            loginPage.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim loginPage As New LoginForm()
        loginPage.Show()
        Me.Hide()
    End Sub

    Private Sub Passwordtxtbox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PasswordCB_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordCB.CheckedChanged
        If PasswordCB.Checked = True Then
            Passwordtxtbox.UseSystemPasswordChar = False
        Else
            Passwordtxtbox.UseSystemPasswordChar = True
        End If
    End Sub
End Class
