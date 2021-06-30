Imports System.Data.OleDb

Public Class FormAddStudent
    Dim connection As New Connection
    Dim cs As String = connection.connectionString

    Private Sub FormAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Eclair_Student_PortalDataSet2.tblStudent' table. You can move, or remove it, as needed.
        Me.TblStudentTableAdapter.Fill(Me.Eclair_Student_PortalDataSet2.tblStudent)

        Dim conn As New OleDbConnection(cs)
        dgvStudentlist.DataSource = Nothing
        dgvStudentlist.Refresh()

        Dim str As String = "SELECT * FROM tblStudent"
        Using cmd As New OleDb.OleDbCommand(str, conn)
            Using da As New OleDbDataAdapter(cmd)
                Using newtable As New DataTable
                    da.Fill(newtable)
                    dgvStudentlist.DataSource = newtable
                End Using
            End Using
        End Using

        Dim str1 As String = "SELECT * FROM tblLoginStud"
        Using cmd1 As New OleDb.OleDbCommand(str1, conn)
            Using da1 As New OleDbDataAdapter(cmd1)
                Using newtable As New DataTable
                    da1.Fill(newtable)
                    dgvStudLogin.DataSource = newtable
                End Using
            End Using
        End Using

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        Dim conn As New OleDbConnection(cs)
        Dim add As String = "INSERT INTO tblStudent ([Fname], [Lname], [Email], [PhoneNo]) VALUES (@Fname, @Lname, @Email, @PhoneNo)" 'database query

        If txtboxFname.Text = Nothing Or txtboxLname.Text = Nothing Or txtboxEmail.Text = Nothing Or txtboxEmail.Text = Nothing Or txtboxPhoneNo.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()
            Dim cmd As New OleDbCommand(add, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("Fname", CType(txtboxFname.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Lname", CType(txtboxLname.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Email", CType(txtboxEmail.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PhoneNo", CType(txtboxPhoneNo.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Student?", "Add Student Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            FormAddStudent_Load(e, e) 'Reloads the Form
            Refresh()
        End If

    End Sub

    Private Sub btnEditStud_Click(sender As Object, e As EventArgs) Handles btnEditStud.Click
        Dim conn As New OleDbConnection(cs)
        Dim edit As String = "UPDATE tblStudent SET [Fname]=@Fname, [Lname]=@Lname, [Email]=@Email, [PhoneNo]=@PhoneNo WHERE StudentID=@StudentID" 'database query

        conn.Open()
        Dim cmd As New OleDbCommand(edit, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@Fname", txtboxFname.Text)
        cmd.Parameters.AddWithValue("@Lname", txtboxLname.Text)
        cmd.Parameters.AddWithValue("@Email", txtboxEmail.Text)
        cmd.Parameters.AddWithValue("@PhoneNo", txtboxPhoneNo.Text)
        cmd.Parameters.AddWithValue("@StudentID", txtboxStudentID.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Student?", "Edit Student Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormAddStudent_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub btnDeleteStud_Click(sender As Object, e As EventArgs) Handles btnDeleteStud.Click
        Dim conn As New OleDbConnection(cs)
        Dim delete As String = "DELETE FROM tblStudent WHERE StudentID=@StudentID" 'database query

        conn.Open()
            Dim cmd As New OleDbCommand(delete, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("StudentID", CType(txtboxStudentID.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Delete Student?", "Delete Student Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            FormAddStudent_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub dgvStudentlist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudentlist.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = dgvStudentlist.CurrentRow.Index
        Me.txtboxStudentID.Text = dgvStudentlist.Item(0, i).Value
        Me.txtboxFname.Text = dgvStudentlist.Item(1, i).Value
        Me.txtboxLname.Text = dgvStudentlist.Item(2, i).Value
        Me.txtboxEmail.Text = dgvStudentlist.Item(3, i).Value
        Me.txtboxPhoneNo.Text = dgvStudentlist.Item(4, i).Value

    End Sub

    Private Sub btnAddLogin_Click(sender As Object, e As EventArgs) Handles btnAddLogin.Click
        Dim conn As New OleDbConnection(cs)
        Dim add As String = "INSERT INTO tblLoginStud ([StudentID], [Password], [UserType]) VALUES (@StudentID, @Password, @UserType)" 'database query

        If txtboxFname.Text = Nothing Or txtboxLname.Text = Nothing Or txtboxEmail.Text = Nothing Or txtboxEmail.Text = Nothing Or txtboxPhoneNo.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()
            Dim cmd As New OleDbCommand(add, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("StudentID", CType(txtboxStudentID.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(txtboxPassword.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("UserType", CType(cmbUserType.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Student Login?", "Add Student Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            FormAddStudent_Load(e, e) 'Reloads the Form
            Refresh()
        End If

    End Sub

    Private Sub btnEditLogin_Click(sender As Object, e As EventArgs) Handles btnEditLogin.Click
        Dim conn As New OleDbConnection(cs)
        Dim edit As String = "UPDATE tblLoginStud SET [Password]=@Password, [UserType]=@UserType WHERE StudentID=@StudentID" 'database query

        conn.Open()
        Dim cmd As New OleDbCommand(edit, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@Password", txtboxPassword.Text)
        cmd.Parameters.AddWithValue("@UserType", cmbUserType.Text)
        cmd.Parameters.AddWithValue("@StudentID", txtboxStudentID.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Student Login?", "Edit Student Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormAddStudent_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub btnDeleteLogin_Click(sender As Object, e As EventArgs) Handles btnDeleteLogin.Click
        Dim conn As New OleDbConnection(cs)
        Dim delete As String = "DELETE FROM tblLoginStud WHERE StudentID=@StudentID" 'database query

        conn.Open()
        Dim cmd As New OleDbCommand(delete, conn)
        'Gives a parameter for database column name
        cmd.Parameters.Add(New OleDbParameter("StudentID", CType(txtboxStudentID.Text, String)))
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Delete Student?", "Delete Student Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormAddStudent_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub dgvStudLogin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudLogin.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = dgvStudLogin.CurrentRow.Index
        Me.txtboxStudentID.Text = dgvStudLogin.Item(0, i).Value
        Me.txtboxPassword.Text = dgvStudLogin.Item(1, i).Value
        Me.cmbUserType.Text = dgvStudLogin.Item(2, i).Value
    End Sub
End Class