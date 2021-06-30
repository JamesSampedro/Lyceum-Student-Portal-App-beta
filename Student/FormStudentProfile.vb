Imports Eclair_Student_Portal.FormLogin
Imports System.Data.OleDb

Public Class FormStudentProfile
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub FormStudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection(cs)
        Dim SelectDataStudent As String = "SELECT tblStudent.Fname, tblStudent.Lname, tblStudent.Email, tblStudent.PhoneNo
                                            FROM tblStudent
                                            INNER JOIN tblLoginStud ON tblStudent.StudentID = tblLoginStud.StudentID
                                            WHERE tblStudent.StudentID=@StudentID"

        Dim cmdfetch As New OleDbCommand(SelectDataStudent, conn) 'To use the query SelectDataStudent, then, conn to connect to database

        conn.Open() 'Connection Open

        cmdfetch.Parameters.AddWithValue("@StudentID", FetchStudID.SavedStudID)
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        While reader.Read() 'Automatic User data fetch rule
            'textbox.Text += reader("column name from database").ToString() <- to output to string
            txtboxFname.Text += reader("Fname").ToString()
            txtboxLname.Text += reader("Lname").ToString()
            txtboxEmail.Text += reader("Email").ToString()
            txtboxPhoneNo.Text += reader("PhoneNo").ToString()
        End While

        conn.Close()
    End Sub

    Private Sub btnEditEmail_Click(sender As Object, e As EventArgs) Handles btnEditEmail.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE tblStudent SET [Email]=@Email WHERE StudentID=@StudentID" 'database query
        'Password is inside [] because its a default entity within the language

        conn.Open() 'Connection Open

        Dim cmd As New OleDbCommand(update, conn)
        cmd.Parameters.AddWithValue("@Email", txtboxEmail.Text) 'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@StudentID", FetchStudID.SavedStudID)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Email?", "Email Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        conn.Close()

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormStudentProfile_Load(e, e) 'Reloads the Form
        Refresh()
    End Sub

    Private Sub btnEditContact_Click(sender As Object, e As EventArgs) Handles btnEditContact.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE tblStudent SET [PhoneNo]=@PhoneNo WHERE StudentID=@StudentID" 'database query
        'Password is inside [] because its a default entity within the language

        conn.Open() 'Connection Open

        Dim cmd As New OleDbCommand(update, conn)
        cmd.Parameters.AddWithValue("@PhoneNo", txtboxPhoneNo.Text) 'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@StudentID", FetchStudID.SavedStudID)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Contact#?", "Contact# Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        conn.Close()

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormStudentProfile_Load(e, e) 'Reloads the Form
        Refresh()
    End Sub

    Private Sub btnEditPasword_Click(sender As Object, e As EventArgs) Handles btnEditPasword.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE tblLoginStud SET [Password]=@Password WHERE StudentID=@StudentID" 'database query
        'Password is inside [] because its a default entity within the language

        conn.Open() 'Connection Open

        Dim cmd As New OleDbCommand(update, conn)
        cmd.Parameters.AddWithValue("@Password", txtboxPassword.Text) 'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@StudentID", FetchStudID.SavedStudID)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Password?", "Password Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        conn.Close()

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormStudentProfile_Load(e, e) 'Reloads the Form
        Refresh()
    End Sub

End Class