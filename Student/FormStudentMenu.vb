Public Class FormStudentMenu
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.ActiveControl = Nothing
        FormStudentProfile.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.ActiveControl = Nothing
        FormLogin.Show()
        FormLogin.txtboxLoginID.Clear()
        FormLogin.txtboxPassword.Clear()
        FormLogin.cmbUserType.SelectedIndex = -1
        Me.Close()
    End Sub

    Private Sub btn1stSem_Click(sender As Object, e As EventArgs) Handles btn1stSem.Click
        Me.ActiveControl = Nothing
        Form1stSem.Show()
    End Sub

    Private Sub btn2ndSem_Click(sender As Object, e As EventArgs) Handles btn2ndSem.Click
        Me.ActiveControl = Nothing
        Form2ndSem.Show()
    End Sub

End Class