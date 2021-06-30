Imports System.Data.OleDb

Public Class FormAddAdmin
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub FormAddAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Eclair_Student_PortalDataSet2.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.Eclair_Student_PortalDataSet2.tblEmployee)
        'TODO: This line of code loads data into the 'Eclair_Student_PortalDataSet2.tblLoginEmp' table. You can move, or remove it, as needed.
        Me.TblLoginEmpTableAdapter.Fill(Me.Eclair_Student_PortalDataSet2.tblLoginEmp)

        Dim conn As New OleDbConnection(cs)
        dgvEmployeelist.DataSource = Nothing
        dgvEmployeelist.Refresh()

        Dim str As String = "SELECT * FROM tblEmployee"
        Using cmd As New OleDb.OleDbCommand(str, conn)
            Using da As New OleDbDataAdapter(cmd)
                Using newtable As New DataTable
                    da.Fill(newtable)
                    dgvEmployeelist.DataSource = newtable
                End Using
            End Using
        End Using

        Dim str1 As String = "SELECT * FROM tblLoginEmp"
        Using cmd1 As New OleDb.OleDbCommand(str1, conn)
            Using da1 As New OleDbDataAdapter(cmd1)
                Using newtable As New DataTable
                    da1.Fill(newtable)
                    dgvEmpLogin.DataSource = newtable
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Dim conn As New OleDbConnection(cs)
        Dim add As String = "INSERT INTO tblEmployee ([Fname], [Lname], [Email], [PhoneNo]) VALUES (@Fname, @Lname, @Email, @PhoneNo)" 'database query

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
            MessageBox.Show("Add Employee?", "Add Employee Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            FormAddAdmin_Load(e, e) 'Reloads the Form
            Refresh()
        End If

    End Sub

    Private Sub btnEditEmp_Click(sender As Object, e As EventArgs) Handles btnEditEmp.Click
        Dim conn As New OleDbConnection(cs)
        Dim edit As String = "UPDATE tblEmployee SET [Fname]=@Fname, [Lname]=@Lname, [Email]=@Email, [PhoneNo]=@PhoneNo WHERE EmployeeID=@EmployeeID" 'database query

        conn.Open()
        Dim cmd As New OleDbCommand(edit, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@Fname", txtboxFname.Text)
        cmd.Parameters.AddWithValue("@Lname", txtboxLname.Text)
        cmd.Parameters.AddWithValue("@Email", txtboxEmail.Text)
        cmd.Parameters.AddWithValue("@PhoneNo", txtboxPhoneNo.Text)
        cmd.Parameters.AddWithValue("@EmployeeID", txtboxEmployeeID.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Employee?", "Edit Employee Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormAddAdmin_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub btnDeleteEmp_Click(sender As Object, e As EventArgs) Handles btnDeleteEmp.Click
        Dim conn As New OleDbConnection(cs)
        Dim delete As String = "DELETE FROM tblEmployee WHERE EmployeeID=@EmployeeID" 'database query

        conn.Open()
        Dim cmd As New OleDbCommand(delete, conn)
        'Gives a parameter for database column name
        cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(txtboxEmployeeID.Text, String)))
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Delete Employee?", "Delete Employee Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormAddAdmin_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub dgvEmployeelist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeelist.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = dgvEmployeelist.CurrentRow.Index
        Me.txtboxEmployeeID.Text = dgvEmployeelist.Item(0, i).Value
        Me.txtboxFname.Text = dgvEmployeelist.Item(1, i).Value
        Me.txtboxLname.Text = dgvEmployeelist.Item(2, i).Value
        Me.txtboxEmail.Text = dgvEmployeelist.Item(3, i).Value
        Me.txtboxPhoneNo.Text = dgvEmployeelist.Item(4, i).Value

    End Sub

    Private Sub btnAddLogin_Click(sender As Object, e As EventArgs) Handles btnAddLogin.Click
        Dim conn As New OleDbConnection(cs)
        Dim add As String = "INSERT INTO tblLoginEmp ([EmployeeID], [Password], [UserType]) VALUES (@EmployeeID, @Password, @UserType)" 'database query

        If txtboxFname.Text = Nothing Or txtboxLname.Text = Nothing Or txtboxEmail.Text = Nothing Or txtboxEmail.Text = Nothing Or txtboxPhoneNo.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()
            Dim cmd As New OleDbCommand(add, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(txtboxEmployeeID.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(txtboxPassword.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("UserType", CType(cmbUserType.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Employee Login?", "Add Employee Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            FormAddAdmin_Load(e, e) 'Reloads the Form
            Refresh()
        End If

    End Sub

    Private Sub btnEditLogin_Click(sender As Object, e As EventArgs) Handles btnEditLogin.Click
        Dim conn As New OleDbConnection(cs)
        Dim edit As String = "UPDATE tblLoginEmp SET [Password]=@Password, [UserType]=@UserType WHERE EmployeeID=@EmployeeID" 'database query

        conn.Open()
        Dim cmd As New OleDbCommand(edit, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@Password", txtboxPassword.Text)
        cmd.Parameters.AddWithValue("@UserType", cmbUserType.Text)
        cmd.Parameters.AddWithValue("@EmployeeID", txtboxEmployeeID.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Employee Login?", "Edit Employee Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormAddAdmin_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub btnDeleteLogin_Click(sender As Object, e As EventArgs) Handles btnDeleteLogin.Click
        Dim conn As New OleDbConnection(cs)
        Dim delete As String = "DELETE FROM tblLoginEmp WHERE EmployeeID=@EmployeeID" 'database query

        conn.Open()
        Dim cmd As New OleDbCommand(delete, conn)
        'Gives a parameter for database column name
        cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(txtboxEmployeeID.Text, String)))
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Delete Employee?", "Delete Employee Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormAddAdmin_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub dgvEmpLogin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpLogin.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = dgvEmpLogin.CurrentRow.Index
        Me.txtboxEmployeeID.Text = dgvEmpLogin.Item(0, i).Value
        Me.txtboxPassword.Text = dgvEmpLogin.Item(1, i).Value
        Me.cmbUserType.Text = dgvEmpLogin.Item(2, i).Value
    End Sub
End Class