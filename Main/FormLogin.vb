Imports System.Data.OleDb
Public Class FormLogin
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Public Class FetchEmpID
        Public Shared SavedEmpID As String
    End Class

    Public Class FetchStudID
        Public Shared SavedStudID As String
    End Class

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim conn As New OleDbConnection(cs)
        Dim cmd As New OleDbCommand("SELECT * FROM tblLoginEmp WHERE EmployeeID=@EmployeeID And Password=@Password and UserType=@UserType", conn)

        FetchEmpID.SavedEmpID = txtboxLoginID.Text

        cmd.Parameters.Add("@EmployeeID", OleDbType.VarChar).Value = txtboxLoginID.Text
        cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = txtboxPassword.Text
        cmd.Parameters.Add("@UserType", OleDbType.VarChar).Value = cmbUserType.Text

        Dim submitlogin As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        submitlogin.Fill(table)

        If table.Rows.Count <= 0 Then
            MsgBox("Error Login. Please check Username or Password.", MsgBoxStyle.Exclamation)

        ElseIf cmbUserType.Text = "Admin" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            Me.Hide()
            FormAdminMenu.Show()

        End If

    End Sub

    Private Sub btnStudentLogin_Click(sender As Object, e As EventArgs) Handles btnStudentLogin.Click
        Dim conn As New OleDbConnection(cs)
        Dim cmd1 As New OleDbCommand("SELECT * FROM tblLoginStud WHERE StudentID=@StudentID And Password=@Password and UserType=@UserType", conn)

        FetchStudID.SavedStudID = txtboxLoginID.Text

        cmd1.Parameters.Add("@StudentID", OleDbType.VarChar).Value = txtboxLoginID.Text
        cmd1.Parameters.Add("@Password", OleDbType.VarChar).Value = txtboxPassword.Text
        cmd1.Parameters.Add("@UserType", OleDbType.VarChar).Value = cmbUserType.Text

        Dim submitlogin1 As New OleDbDataAdapter(cmd1)
        Dim table1 As New DataTable
        submitlogin1.Fill(table1)

        If table1.Rows.Count <= 0 Then
            MsgBox("Error Login. Please check Username or Password.", MsgBoxStyle.Exclamation)

        ElseIf cmbUserType.Text = "Student" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            Me.Hide()
            FormStudentMenu.Show()

        End If

    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserType.SelectedIndexChanged
        If cmbUserType.SelectedIndex = 0 Then
            btnAdminLogin.Enabled = True
            btnStudentLogin.Enabled = False

        ElseIf cmbUserType.SelectedIndex = 1 Then
            btnAdminLogin.Enabled = False
            btnStudentLogin.Enabled = True

        End If

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub labelEcStudPortal_Click(sender As Object, e As EventArgs) Handles labelEcStudPortal.Click

    End Sub
End Class