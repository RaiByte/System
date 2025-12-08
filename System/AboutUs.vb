Public Class AboutUs

    Private Sub hmbtn_Click(sender As Object, e As EventArgs) Handles hmbtn.Click
        Dim homePage As New HomePage
        homePage.Show()
        Me.Close()
    End Sub

    Private Sub Profbtn_Click(sender As Object, e As EventArgs) Handles Profbtn.Click
        Dim profilePage As New Profile()
        profilePage.userID = userID
        profilePage.Show()
        Me.Hide()
    End Sub

    Private Sub Contactbtnn_Click(sender As Object, e As EventArgs) Handles Contactbtnn.Click
        Dim contactPage As New Contacts
        contactPage.Show()
        Me.Close()
    End Sub
End Class