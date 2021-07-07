Imports System.Data.OleDb

Public Class FormModifyGrades
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub FormModifyGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Eclair_Student_PortalDataSet2.tblGrades' table. You can move, or remove it, as needed.
        Me.TblGradesTableAdapter.Fill(Me.Eclair_Student_PortalDataSet2.tblGrades)
        'TODO: This line of code loads data into the 'Eclair_Student_PortalDataSet2.tblStudent' table. You can move, or remove it, as needed.
        Me.TblStudentTableAdapter.Fill(Me.Eclair_Student_PortalDataSet2.tblStudent)

        Dim conn As New OleDbConnection(cs)
        dgvGradetable.DataSource = Nothing
        dgvGradetable.Refresh()

        Dim str As String = "SELECT * FROM tblGrades"
        Using cmd As New OleDb.OleDbCommand(str, conn)
            Using da As New OleDbDataAdapter(cmd)
                Using newtable As New DataTable
                    da.Fill(newtable)
                    dgvGradetable.DataSource = newtable
                End Using
            End Using
        End Using

        Dim str1 As String = "SELECT * FROM tblStudent"
        Using cmd1 As New OleDb.OleDbCommand(str1, conn)
            Using da1 As New OleDbDataAdapter(cmd1)
                Using newtable As New DataTable
                    da1.Fill(newtable)
                    dgvStudenttable.DataSource = newtable
                End Using
            End Using
        End Using

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim conn As New OleDbConnection(cs)
        Dim add As String = "INSERT INTO tblGrades ([Semester], [Subject], [Prelim], [Midterm], [Final], [Average], [StudentID]) VALUES (@Semester, @Subject, @Prelim, @Midterm, @Final, @Average, @StudentID)" 'database query

        If txtboxStudentID.Text = Nothing Or cmbSemester.Text = Nothing Or cmbSubject.Text = Nothing Or txtboxPrelim.Text = Nothing Or txtboxMidterm.Text = Nothing Or txtboxFinals.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()
            Dim cmd As New OleDbCommand(add, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("Semester", CType(cmbSemester.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Subject", CType(cmbSubject.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Prelim", CType(txtboxPrelim.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Midterm", CType(txtboxMidterm.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Final", CType(txtboxFinals.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Average", CType(txtboxAverage.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("StudentID", CType(txtboxStudentID.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Grades?", "Add Grade Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            FormModifyGrades_Load(e, e) 'Reloads the Form
            Refresh()
        End If

    End Sub

    Private Sub btmEdit_Click(sender As Object, e As EventArgs) Handles btmEdit.Click
        Dim conn As New OleDbConnection(cs)
        Dim edit As String = "UPDATE tblGrades SET [Semester]=@Semester, [Subject]=@Subject, [Prelim]=@Prelim, [Midterm]=@Midterm, [Final]=@Final, [Average]=@Average WHERE GradeID=@GradeID" 'database query

        conn.Open()
        Dim cmd As New OleDbCommand(edit, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@Semester", cmbSemester.Text)
        cmd.Parameters.AddWithValue("@Subject", cmbSubject.Text)
        cmd.Parameters.AddWithValue("@Prelim", txtboxPrelim.Text)
        cmd.Parameters.AddWithValue("@Midterm", txtboxMidterm.Text)
        cmd.Parameters.AddWithValue("@Final", txtboxFinals.Text)
        cmd.Parameters.AddWithValue("@Average", txtboxAverage.Text)
        cmd.Parameters.AddWithValue("@GradeID", txtboxGradeID.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Grades?", "Edit Grades Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormModifyGrades_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim conn As New OleDbConnection(cs)
        Dim delete As String = "DELETE FROM tblGrades WHERE StudentID=@StudentID AND Semester=@Semester AND Subject=@Subject" 'database query

        conn.Open()
        Dim cmd As New OleDbCommand(delete, conn)
        'Gives a parameter for database column name
        cmd.Parameters.Add(New OleDbParameter("StudentID", CType(txtboxStudentID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Semester", CType(cmbSemester.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Subject", CType(cmbSubject.Text, String)))
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Delete Grades?", "Delete Grades Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormModifyGrades_Load(e, e) 'Reloads the Form
        Refresh()
    End Sub

    Private Sub btnCalculateAvg_Click(sender As Object, e As EventArgs) Handles btnCalculateAvg.Click
        Dim prelim As Double
        Dim midterm As Double
        Dim final As Double
        Dim average As Double
        Dim result As Double
        Dim finalresult As Double

        Double.TryParse(txtboxPrelim.Text, prelim)
        Double.TryParse(txtboxMidterm.Text, midterm)
        Double.TryParse(txtboxFinals.Text, final)
        Double.TryParse(txtboxAverage.Text, average)

        result = ((prelim) + (midterm) + (final)) / 3
        finalresult = Math.Truncate(result * 100) / 100
        txtboxAverage.Text = finalresult

    End Sub

    Private Sub dgvStudenttable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudenttable.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = dgvStudenttable.CurrentRow.Index
        Me.txtboxStudentID.Text = dgvStudenttable.Item(0, i).Value
    End Sub

    Private Sub dgvGradetable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGradetable.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = dgvGradetable.CurrentRow.Index
        Me.txtboxStudentID.Text = dgvGradetable.Item(0, i).Value
        Me.cmbSemester.Text = dgvGradetable.Item(1, i).Value
        Me.cmbSubject.Text = dgvGradetable.Item(2, i).Value
        Me.txtboxPrelim.Text = dgvGradetable.Item(3, i).Value
        Me.txtboxMidterm.Text = dgvGradetable.Item(4, i).Value
        Me.txtboxFinals.Text = dgvGradetable.Item(5, i).Value
        Me.txtboxGradeID.Text = dgvGradetable.Item(7, i).Value

    End Sub

    Private Sub dgvGradetable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGradetable.CellContentClick

    End Sub

    Private Sub dgvStudenttable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudenttable.CellContentClick

    End Sub
End Class