Imports MySql.Data.MySqlClient
Imports System.Data

Public Class UsersTable

    Private Shared ReadOnly CONNECTION_STRING As String = "Server=localhost; user id=root; password=06092004; database=IncidentReport"

    Private userDataTable As DataTable
    Private userDataAdapter As MySqlDataAdapter

    Private Sub UsersTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsersData()
    End Sub

    Private Sub LoadUsersData()
        Try
            userDataAdapter = New MySqlDataAdapter("SELECT * FROM Signup", CONNECTION_STRING)
            userDataTable = New DataTable()

            Dim commandBuilder As New MySqlCommandBuilder(userDataAdapter)

            userDataAdapter.Fill(userDataTable)
            UserTB.DataSource = userDataTable

            If UserTB.Columns.Contains("user_id") Then
                UserTB.Columns("user_id").Visible = False
            End If

            ' --- START REVISIONS: Enforce Read-Only ---

            ' 1. Make all columns read-only by default
            For Each column As DataGridViewColumn In UserTB.Columns
                column.ReadOnly = True
            Next

            ' 2. Explicitly re-enable Account_Type for editing
            If UserTB.Columns.Contains("Account_Type") Then
                UserTB.Columns("Account_Type").ReadOnly = False
                UserTB.Columns("Account_Type").HeaderText = "Account Type (Editable)"
            End If

            ' --- END REVISIONS ---

        Catch ex As Exception
            MessageBox.Show($"Error loading Users data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        If userDataTable Is Nothing Then
            MessageBox.Show("No user data loaded.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        UserTB.EndEdit() ' CRITICAL: Ensures changes are pushed to the DataTable

        Dim changesTable As DataTable = userDataTable.GetChanges()

        If changesTable Is Nothing Then
            MessageBox.Show("You haven't made any updates to save.", "No Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' This works because the Adapter loads data from a single table (Signup)
            Dim rowsUpdated As Integer = userDataAdapter.Update(userDataTable)

            MessageBox.Show($"{rowsUpdated} user records updated successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            userDataTable.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show($"Error saving user changes: {ex.Message}" & vbCrLf & "Ensure unique constraints (like Username/Email) are not violated.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            userDataTable.RejectChanges()
        End Try
    End Sub


    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click

        If UserTB.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim rowIndex As Integer = UserTB.SelectedRows(0).Index
        Dim userName As String = UserTB.Rows(rowIndex).Cells("Username").Value.ToString()
        Dim userId As Integer = CInt(UserTB.Rows(rowIndex).Cells("user_id").Value)

        ' WARN: This delete command only targets the Signup table.
        ' If the database relies on CASCADE DELETE to also remove the corresponding
        ' records in the User_Profile and Incident_Reports tables, this is fine.
        ' Otherwise, you will need a transactional delete (like in UpdateProfile.vb)
        Dim confirmResult As DialogResult = MessageBox.Show(
            $"Are you sure you want to delete user: {userName} (ID: {userId})?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(CONNECTION_STRING)
                    Dim query As String = "DELETE FROM Signup WHERE user_id = @id"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@id", userId)
                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show($"User {userName} successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadUsersData()

            Catch ex As Exception
                MessageBox.Show($"Error deleting user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub UserTB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserTB.CellContentClick

    End Sub

    Private Sub Usersbtn_Click(sender As Object, e As EventArgs) Handles Usersbtn.Click
        Dim adminPage As New Admin
        adminPage.Show()
        Me.Close()
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

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        If Not userDataTable Is Nothing Then
            userDataTable.Clear()
        End If

        LoadUsersData()
        MessageBox.Show("Report data has been refreshed.", "Data Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UpdateProfbtn_Click(sender As Object, e As EventArgs) Handles UpdateProfbtn.Click
        Dim update As New UpdateProfile()
        update.Show()
        Me.Close()
    End Sub
End Class