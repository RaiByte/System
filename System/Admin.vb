Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Admin
    Private incidentReportDataTable As DataTable
    Private incidentReportAdapter As MySqlDataAdapter
    Private Shared ReadOnly CONNECTION_STRING As String = "Server=localhost; user id=root; password=06092004; database=IncidentReport"


    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIncidentReportsData()
    End Sub

    Private Sub LoadIncidentReportsData()
        Try

            incidentReportAdapter = New MySqlDataAdapter("SELECT * FROM incident_reports", CONNECTION_STRING)
            incidentReportDataTable = New DataTable()


            Dim commandBuilder As New MySqlCommandBuilder(incidentReportAdapter)


            incidentReportAdapter.Fill(incidentReportDataTable)
            AdminTB.DataSource = incidentReportDataTable

        Catch ex As Exception
            MessageBox.Show($"Error loading Incident Reports data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub dgvIncidentReports_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdminTB.CellContentClick



        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

            Dim incidentId As Integer = AdminTB.Rows(e.RowIndex).Cells("Incident_id").Value
            MessageBox.Show($"Clicked row with Incident ID: {incidentId}", "Cell Clicked")
        End If
    End Sub



    Private Sub Usersbtn_Click(sender As Object, e As EventArgs) Handles Usersbtn.Click
        Dim userForm As New UsersTable()
        userForm.Show()
        Me.Close()
    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        If incidentReportDataTable Is Nothing Then
            MessageBox.Show("No incident reports data loaded.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        AdminTB.EndEdit()


        Dim changesTable As DataTable = incidentReportDataTable.GetChanges()

        If changesTable Is Nothing Then

            MessageBox.Show("You haven't made any updates to save.", "No Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try

            Dim rowsUpdated As Integer = incidentReportAdapter.Update(incidentReportDataTable)

            MessageBox.Show($"{rowsUpdated} rows updated successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)


            incidentReportDataTable.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show($"Error saving changes: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            incidentReportDataTable.RejectChanges()
        End Try
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click

        If AdminTB.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a report to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim rowIndex As Integer = AdminTB.SelectedRows(0).Index

        Dim incidentId As Integer = CInt(AdminTB.Rows(rowIndex).Cells("Incident_id").Value)


        Dim confirmResult As DialogResult = MessageBox.Show(
            $"Are you sure you want to delete Incident ID: {incidentId}?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(CONNECTION_STRING)
                    Dim query As String = "DELETE FROM incident_reports WHERE Incident_id = @id"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@id", incidentId)
                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Report successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadIncidentReportsData()

            Catch ex As Exception
                MessageBox.Show($"Error deleting report: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
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
        LoadIncidentReportsData()
        MessageBox.Show("Report data has been refreshed.", "Data Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class