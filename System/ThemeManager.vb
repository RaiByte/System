Module ThemeManager
    Public IsDarkMode As Boolean = False

    Public Sub ApplyTheme(form As Form)
        If IsDarkMode Then
            form.BackColor = Color.FromArgb(40, 40, 40)
            For Each ctrl As Control In form.Controls
                If TypeOf ctrl Is Label Then
                    ctrl.ForeColor = Color.White
                ElseIf TypeOf ctrl Is TextBox Then
                    ctrl.BackColor = Color.FromArgb(60, 60, 60)
                    ctrl.ForeColor = Color.White
                ElseIf TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.FromArgb(70, 70, 70)
                    ctrl.ForeColor = Color.White
                End If
            Next
        Else
            form.BackColor = Color.White
            For Each ctrl As Control In form.Controls
                If TypeOf ctrl Is Label Then
                    ctrl.ForeColor = Color.Black
                ElseIf TypeOf ctrl Is TextBox Then
                    ctrl.BackColor = Color.White
                    ctrl.ForeColor = Color.Black
                ElseIf TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.LightGray
                    ctrl.ForeColor = Color.Black
                End If
            Next
        End If
    End Sub
End Module
