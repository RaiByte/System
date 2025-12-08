Public Class Contacts

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

    Private Sub Aboutbtn_Click(sender As Object, e As EventArgs) Handles Aboutbtn.Click
        Dim aboutPage As New AboutUs
        aboutPage.Show()
        Me.Close()
    End Sub
End Class