Public Class HomePage
    Dim panelExpanded As Boolean = False
    Dim maxHeight As Integer = 80
    Dim minHeight As Integer = 60
    'GRADIANT BUTTONS
    Private Sub Fire_Click(sender As Object, e As EventArgs) Handles Fire.Click
        Dim reportPage As New Report()
        reportPage.IncidentType = "Fire"
        reportPage.Show()
        Me.Hide()
    End Sub

    Private Sub Traffic_Click(sender As Object, e As EventArgs) Handles Traffic.Click
        Dim reportPage As New Report()
        reportPage.IncidentType = "Traffic Accident"
        reportPage.Show()
        Me.Hide()
    End Sub

    Private Sub Medical_Click(sender As Object, e As EventArgs) Handles Medical.Click
        Dim reportPage As New Report()
        reportPage.IncidentType = "Medical Emergencies"
        reportPage.Show()
        Me.Hide()
    End Sub

    Private Sub Landslide_Click(sender As Object, e As EventArgs) Handles Landslide.Click
        Dim reportPage As New Report()
        reportPage.IncidentType = "Landslide Incident"
        reportPage.Show()
        Me.Hide()
    End Sub

    Private Sub Earthquake_Click(sender As Object, e As EventArgs) Handles Earthquake.Click
        Dim reportPage As New Report()
        reportPage.IncidentType = "Earthquake"
        reportPage.Show()
        Me.Hide()
    End Sub

    Private Sub Flood_Click(sender As Object, e As EventArgs) Handles Flood.Click
        Dim reportPage As New Report()
        reportPage.IncidentType = "Flood"
        reportPage.Show()
        Me.Hide()
    End Sub

    Private Sub Profilebtn_Click(sender As Object, e As EventArgs) Handles Profilebtn.Click
        Dim profilePage As New Profile()
        profilePage.userID = userID
        profilePage.Show()
        Me.Hide()
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
End Class