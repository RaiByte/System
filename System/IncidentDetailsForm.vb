Imports MySql.Data.MySqlClient
Imports System.Data

Public Class IncidentDetailsForm
    Private Shared ReadOnly CONNECTION_STRING As String = "Server=localhost; user id=root; password=06092004; database=IncidentReport"

    Private ReadOnly _incidentId As Integer

    ' 1. Constructor: This allows the Admin form to pass the ID to this form
    Public Sub New(ByVal incidentId As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        _incidentId = incidentId
    End Sub

    Private Sub IncidentDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"Incident Details for ID: #{_incidentId}"
        LoadIncidentDetails()
    End Sub

    Private Sub LoadIncidentDetails()
        Try
            Using connection As New MySqlConnection(CONNECTION_STRING)
                ' Query joins incident_reports (I) with Signup (S) to get the reporter's username
                Dim query As String = "SELECT 
                                        I.Incident_id, 
                                        I.IncidentType, 
                                        I.Description, 
                                        I.Location, 
                                        I.DateAndTime,
                                        I.How,
                                        I.Who,
                                        S.Username 
                                      FROM incident_reports I 
                                      JOIN Signup S ON I.user_id = S.user_id 
                                      WHERE I.Incident_id = @id"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", _incidentId)
                    connection.Open()

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the assumed UI controls with data
                            IncidentIdLbl.Text = reader("Incident_id").ToString()
                            ReporterNameTxt.Text = reader("Username").ToString()
                            LocationTxt.Text = reader("Location").ToString()
                            IncidentTypeTxt.Text = reader("IncidentType").ToString()
                            howtxt.Text = reader("How").ToString()
                            whotxt.Text = reader("Who").ToString()

                            ' Format the DateTime for better display
                            Dim incidentDate As DateTime = reader.GetDateTime("DateAndTime")
                            DateReportedTxt.Text = incidentDate.ToString("yyyy-MM-dd hh:mm:ss tt")

                            DescriptionTxt.Text = reader("Description").ToString()
                        Else
                            MessageBox.Show("Incident report not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading incident details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Me.Close()
    End Sub

    Private Sub IncidentIdLbl_Click(sender As Object, e As EventArgs) Handles IncidentIdLbl.Click

    End Sub

    Private Sub Descriptionlbl_Click(sender As Object, e As EventArgs) Handles Descriptionlbl.Click

    End Sub
End Class