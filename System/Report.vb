Imports MySql.Data.MySqlClient

Public Class Report
    Public IncidentType As String

    Dim conn As New MySqlConnection("Server=localhost; user id=root; password=06092004; database=IncidentReport")
    Private Sub Backbtn_Click(sender As Object, e As EventArgs)
        Dim homePage As New HomePage()
        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub Submitbtn_Click(sender As Object, e As EventArgs)

        If String.IsNullOrWhiteSpace(locationtxtbox.Text) Then
            MsgBox("Please enter the location before submitting the report.")
            Exit Sub
        End If

        Dim query As String = "INSERT INTO incident_reports 
                           (User_id, IncidentType, Location, DateAndTime, How, Description, Who)
                           VALUES 
                           (@user, @type, @loc, NOW(),@how, @desc, @who)"

        Try
            conn.Open()

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", userID)
            cmd.Parameters.AddWithValue("@type", Incidenttxtbox.Text)
            cmd.Parameters.AddWithValue("@loc", locationtxtbox.Text)
            cmd.Parameters.AddWithValue("@how", Howtxtbox.Text)
            cmd.Parameters.AddWithValue("@desc", Descriptiontxtbox.Text)
            cmd.Parameters.AddWithValue("@who", Whotxtbox.Text)

            cmd.ExecuteNonQuery()

            MsgBox("Incident Report Submitted Successfully!")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Incidenttxtbox.Text = IncidentType
        Incidenttxtbox.ReadOnly = True
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click


        If String.IsNullOrWhiteSpace(locationtxtbox.Text) Then
            MsgBox("Please enter the location before submitting the report.")
            Exit Sub
        End If

        Dim query As String = "INSERT INTO incident_reports 
                           (User_id, IncidentType, Location, DateAndTime, How, Description, Who)
                           VALUES 
                           (@user, @type, @loc, NOW(),@how, @desc, @who)"

        Try
            conn.Open()

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", userID)
            cmd.Parameters.AddWithValue("@type", Incidenttxtbox.Text)
            cmd.Parameters.AddWithValue("@loc", locationtxtbox.Text)
            cmd.Parameters.AddWithValue("@how", Howtxtbox.Text)
            cmd.Parameters.AddWithValue("@desc", Descriptiontxtbox.Text)
            cmd.Parameters.AddWithValue("@who", Whotxtbox.Text)

            cmd.ExecuteNonQuery()

            MsgBox("Incident Report Submitted Successfully!")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Dim homePage As New HomePage()
        homePage.Show()
        Me.Hide()
    End Sub


    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim homePage As New HomePage()
        homePage.Show()
        Me.Hide()
    End Sub
End Class