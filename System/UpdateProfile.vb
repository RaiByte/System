Imports MySql.Data.MySqlClient
Imports System.Data

Public Class UpdateProfile
    Private Shared ReadOnly CONNECTION_STRING As String = "Server=localhost; user id=root; password=06092004; database=IncidentReport"

    Private profileDataTable As DataTable
    Private profileDataAdapter As MySqlDataAdapter
    Private Sub UpdateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsersData()
    End Sub

    Private Sub LoadUsersData()
        Try

            Dim query As String = "SELECT P.*, S.Username, S.Account_Type FROM User_Profile P JOIN Signup S ON P.user_id = S.user_id"

            profileDataAdapter = New MySqlDataAdapter(query, CONNECTION_STRING)
            profileDataTable = New DataTable()

            profileDataAdapter.Fill(profileDataTable)

            UpdateTB.DataSource = profileDataTable

            For Each column As DataGridViewColumn In UpdateTB.Columns
                column.ReadOnly = True
            Next

            If UpdateTB.Columns.Contains("ProfileID") Then
                UpdateTB.Columns("ProfileID").Visible = False
            End If
            If UpdateTB.Columns.Contains("user_id") Then
                UpdateTB.Columns("user_id").Visible = False
            End If

            If UpdateTB.Columns.Contains("Account_Type") Then
                UpdateTB.Columns("Account_Type").ReadOnly = False
                UpdateTB.Columns("Account_Type").HeaderText = "Account Type (Editable)"
            End If

        Catch ex As Exception
            MessageBox.Show($"Error loading User Profile data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        If profileDataTable Is Nothing Then
            MessageBox.Show("No user data loaded.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        UpdateTB.EndEdit()

        Dim changesTable As DataTable = profileDataTable.GetChanges(DataRowState.Modified)

        If changesTable Is Nothing OrElse changesTable.Rows.Count = 0 Then
            MessageBox.Show("You haven't made any updates to save.", "No Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim totalRowsUpdated As Integer = 0

        Try
            Using connection As New MySqlConnection(CONNECTION_STRING)
                connection.Open()

                For Each row As DataRow In changesTable.Rows

                    Dim newAccountType As String = row("Account_Type", DataRowVersion.Current).ToString()


                    Dim userId As Integer = CInt(row("user_id", DataRowVersion.Original))

                    Dim query As String = "UPDATE Signup SET Account_Type = @type WHERE user_id = @id"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@type", newAccountType)
                        command.Parameters.AddWithValue("@id", userId)
                        totalRowsUpdated += command.ExecuteNonQuery()
                    End Using
                Next
            End Using

            profileDataTable.AcceptChanges()

            MessageBox.Show($"{totalRowsUpdated} user records updated successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"Error saving user changes: {ex.Message}" & vbCrLf & "The update failed. Data reverted.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            profileDataTable.RejectChanges()
        End Try
    End Sub


    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        If UpdateTB.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user profile to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim rowIndex As Integer = UpdateTB.SelectedRows(0).Index
        Dim userName As String = UpdateTB.Rows(rowIndex).Cells("Username").Value.ToString()
        Dim userId As Integer = CInt(UpdateTB.Rows(rowIndex).Cells("user_id").Value)

        Dim confirmResult As DialogResult = MessageBox.Show(
            $"Are you sure you want to delete profile and account for user: {userName} (ID: {userId})?" & vbCrLf & "This action is irreversible.",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(CONNECTION_STRING)
                    connection.Open()

                    Using transaction As MySqlTransaction = connection.BeginTransaction()

                        Dim queryProfile As String = "DELETE FROM User_Profile WHERE user_id = @id"
                        Using commandProfile As New MySqlCommand(queryProfile, connection, transaction)
                            commandProfile.Parameters.AddWithValue("@id", userId)
                            commandProfile.ExecuteNonQuery()
                        End Using

                        Dim querySignup As String = "DELETE FROM Signup WHERE user_id = @id"
                        Using commandSignup As New MySqlCommand(querySignup, connection, transaction)
                            commandSignup.Parameters.AddWithValue("@id", userId)
                            commandSignup.ExecuteNonQuery()
                        End Using

                        transaction.Commit()

                        MessageBox.Show($"User {userName} and associated profile successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End Using
                End Using

                LoadUsersData()
                If confirmResult = DialogResult.Yes Then
                    Try
                        Using connection As New MySqlConnection(CONNECTION_STRING)
                            connection.Open()


                            Using transaction As MySqlTransaction = connection.BeginTransaction()
                                transaction.Commit()

                                MessageBox.Show($"User {userName} and associated profile successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            End Using
                        End Using

                        LoadUsersData()

                    Catch ex As Exception
                    End Try
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting user: {ex.Message}" & vbCrLf & "The transaction was rolled back.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub UpdateProfbtn_Click(sender As Object, e As EventArgs) Handles Signupbtn.Click
        Dim user As New UsersTable()
        user.Show()
        Me.Close()
    End Sub

    Private Sub Usersbtn_Click(sender As Object, e As EventArgs) Handles Usersbtn.Click
        Dim adminPage As New Admin()
        adminPage.Show()
        Me.Close()
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        If Not profileDataTable Is Nothing Then
            profileDataTable.Clear()
        End If
        LoadUsersData()
        MessageBox.Show("Profile data has been refreshed.", "Data Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class