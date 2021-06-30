Imports System.Data.OleDb

Public Class FormViewStudentGrades
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub FormViewStudentGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Eclair_Student_PortalDataSet2.tblStudent' table. You can move, or remove it, as needed.
        Me.TblStudentTableAdapter.Fill(Me.Eclair_Student_PortalDataSet2.tblStudent)
        'TODO: This line of code loads data into the 'Eclair_Student_PortalDataSet2.tblGrades' table. You can move, or remove it, as needed.
        Me.TblGradesTableAdapter.Fill(Me.Eclair_Student_PortalDataSet2.tblGrades)



    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudentList.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = dgvStudentList.CurrentRow.Index
        Me.txtboxStudentID.Text = dgvStudentList.Item(0, i).Value
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim conn As New OleDbConnection(cs)

        Dim data1stsem As String = "SELECT * FROM tblGrades WHERE StudentID=@StudentID AND Semester='1st'"
        Dim datafetch1stsem As New OleDbCommand(data1stsem, conn)
        datafetch1stsem.Parameters.AddWithValue("@StudentID", txtboxStudentID.Text)
        Dim adapter1stsem As New OleDbDataAdapter(datafetch1stsem)
        Dim table1stsem As New DataTable()
        adapter1stsem.Fill(table1stsem)

        dgv2ndSem.DataSource = table1stsem.DefaultView

        Dim data2ndsem As String = "SELECT * FROM tblGrades WHERE StudentID=@StudentID AND Semester='2nd'"
        Dim datafetch2ndsem As New OleDbCommand(data2ndsem, conn)
        datafetch2ndsem.Parameters.AddWithValue("@StudentID", txtboxStudentID.Text)
        Dim adapter2ndsem As New OleDbDataAdapter(datafetch2ndsem)
        Dim table2ndsem As New DataTable()
        adapter2ndsem.Fill(table2ndsem)

        dgv2ndSem.DataSource = table2ndsem.DefaultView
    End Sub

End Class