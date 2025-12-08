Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class Profile
    Dim conn As New MySqlConnection("Server=localhost; user id=root; password=06092004; database=IncidentReport")
    Public userID As Integer

    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Greetingslbl.Text = "Hi, " & LoggedInFirstName
        LoadProfile()
        LNametxtbox.ReadOnly = True
        Addresstxtbox.ReadOnly = True
        Numbertxtbox.ReadOnly = True
        Emailtxtbox.ReadOnly = True
        FNametxtbox.ReadOnly = True
        Middletextbox.ReadOnly = True

        GunaSave.Enabled = False
    End Sub


    'SAVE PARA SA UPDATE
    Private Sub GunaSave_Click(sender As Object, e As EventArgs) Handles GunaSave.Click
        Dim checkQuery As String = "SELECT * FROM User_Profile WHERE user_id=@id"
        Dim exists As Boolean = False

        Try
            conn.Open()

            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@id", userID)

            Dim r = checkCmd.ExecuteReader()
            exists = r.HasRows
            r.Close()

            Dim query As String

            If exists = False Then
                query = "INSERT INTO User_Profile 
                    (user_id, LastName, First_Name, Middle_Initial, Address, Contact_Number, Email)
                    VALUES (@id, @ln, @fn, @mn, @addr, @contact, @mail)"
            Else
                query = "UPDATE User_Profile
                  SET LastName=@ln, First_Name=@fn, Middle_Initial=@mn,
                  Address=@addr, Contact_Number=@contact, Email=@mail
                  WHERE user_id=@id"

            End If

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", userID)
            cmd.Parameters.AddWithValue("@ln", LNametxtbox.Text)
            cmd.Parameters.AddWithValue("@fn", FNametxtbox.Text)
            cmd.Parameters.AddWithValue("@mn", Middletextbox.Text)
            cmd.Parameters.AddWithValue("@addr", Addresstxtbox.Text)
            cmd.Parameters.AddWithValue("@contact", Numbertxtbox.Text)
            cmd.Parameters.AddWithValue("@mail", Emailtxtbox.Text)

            cmd.ExecuteNonQuery()

            ' Update Signup table
            Dim updateSignup As String = "UPDATE Signup 
                SET LastName=@ln, First_Name=@fn, Middle_Initial=@mn, Email=@mail 
                 WHERE user_id=@id"


            Dim cmd2 As New MySqlCommand(updateSignup, conn)
            cmd2.Parameters.AddWithValue("@id", userID)
            cmd2.Parameters.AddWithValue("@ln", LNametxtbox.Text)
            cmd2.Parameters.AddWithValue("@fn", FNametxtbox.Text)
            cmd2.Parameters.AddWithValue("@mn", Middletextbox.Text)
            cmd2.Parameters.AddWithValue("@mail", Emailtxtbox.Text)
            cmd2.ExecuteNonQuery()

            MsgBox("Profile saved!")

        Catch ex As Exception
            MsgBox("Error saving profile: " & ex.Message)
        Finally
            conn.Close()
        End Try

        'READ
        LNametxtbox.ReadOnly = True
        FNametxtbox.ReadOnly = True
        Middletextbox.ReadOnly = True
        Addresstxtbox.ReadOnly = True
        Numbertxtbox.ReadOnly = True
        Emailtxtbox.ReadOnly = True

        GunaSave.Enabled = False
    End Sub


    Private Sub LoadProfile()

        Try
            conn.Open()

            ' Load from User_Profile first
            Dim query1 As String = "SELECT LastName, First_Name, Middle_Initial,
                                Address, Contact_Number, Email
                                FROM User_Profile WHERE user_id=@id"

            Dim cmd1 As New MySqlCommand(query1, conn)
            cmd1.Parameters.AddWithValue("@id", userID)

            Dim r1 = cmd1.ExecuteReader()

            If r1.Read() Then
                ' Found → use it
                LNametxtbox.Text = r1("LastName").ToString()
                FNametxtbox.Text = r1("First_Name").ToString()
                Middletextbox.Text = r1("Middle_Initial").ToString()

                Addresstxtbox.Text = r1("Address").ToString()
                Numbertxtbox.Text = r1("Contact_Number").ToString()
                Emailtxtbox.Text = r1("Email").ToString()

                r1.Close()
                conn.Close()
                Exit Sub
            End If

            r1.Close()
            conn.Close()

            ' If not found → load from Signup
            conn.Open()

            Dim query2 As String = "SELECT LastName, First_Name, Middle_Initial, Email 
                                FROM Signup WHERE user_id=@id"

            Dim cmd2 As New MySqlCommand(query2, conn)
            cmd2.Parameters.AddWithValue("@id", userID)

            Dim r2 = cmd2.ExecuteReader()

            If r2.Read() Then
                LNametxtbox.Text = r2("LastName").ToString()
                FNametxtbox.Text = r2("First_Name").ToString()
                Middletextbox.Text = r2("Middle_Initial").ToString()
                Emailtxtbox.Text = r2("Email").ToString()
            End If

            r2.Close()

        Catch ex As Exception
            MsgBox("Error loading profile: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub



    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim homePage As New HomePage
        homePage.Show()
        Me.Close()
    End Sub

    Private Sub GunaUpdate_Click(sender As Object, e As EventArgs) Handles GunaUpdate.Click

        LNametxtbox.ReadOnly = False
        Addresstxtbox.ReadOnly = False
        Numbertxtbox.ReadOnly = False
        Emailtxtbox.ReadOnly = False
        FNametxtbox.ReadOnly = False
        Middletextbox.ReadOnly = False

        GunaSave.Enabled = True
    End Sub

    Private Sub LogOutbtn_Click(sender As Object, e As EventArgs) Handles LogOutbtn.Click
        Dim confirm = MessageBox.Show("Are you sure u want to log out?", "Confrim Log out", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)
        If confirm = DialogResult.No Then
            Exit Sub
        End If

        Dim login As New LoginForm()
        login.Show()
        Me.Close()
    End Sub

    Private Sub Contactbtn_Click(sender As Object, e As EventArgs) Handles Contactbtn.Click
        Dim contactPage As New Contacts
        contactPage.Show()
        Me.Close()
    End Sub

    Private Sub Aboutbtn_Click(sender As Object, e As EventArgs) Handles Aboutbtn.Click
        Dim aboutPage As New AboutUs
        aboutPage.Show()
        Me.Close()
    End Sub

    Private Sub FullNtxtbox_TextChanged(sender As Object, e As EventArgs) Handles LNametxtbox.TextChanged

    End Sub

    Private Sub Numbertxtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Numbertxtbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub FNametxtbox_TextChanged(sender As Object, e As EventArgs) Handles FNametxtbox.TextChanged

    End Sub

    Private Sub Middletextbox_TextChanged(sender As Object, e As EventArgs) Handles Middletextbox.TextChanged

    End Sub
End Class