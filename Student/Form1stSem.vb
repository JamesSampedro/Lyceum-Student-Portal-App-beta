Imports Eclair_Student_Portal.FormLogin
Imports System.Data.OleDb

Public Class Form1stSem
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Eclair_Student_PortalDataSet2.tblGrades' table. You can move, or remove it, as needed.
        Me.TblGradesTableAdapter.Fill(Me.Eclair_Student_PortalDataSet2.tblGrades)

        Dim conn As New OleDbConnection(cs)

        'Fill up the SalaryLoan DataGrid
        Dim data1stsem As String = "SELECT * FROM tblGrades WHERE StudentID=@StudentID AND Semester='1st'"
        Dim datafetch1stsem As New OleDbCommand(data1stsem, conn)
        'Uses the EmpID from the Login information to fetch user data
        datafetch1stsem.Parameters.AddWithValue("@StudentID", FetchStudID.SavedStudID)
        'Uses the query to fill data on the Datagrid
        Dim adapter1stsem As New OleDbDataAdapter(datafetch1stsem)
        Dim table1stsem As New DataTable()
        adapter1stsem.Fill(table1stsem)

        'Puts it on the datagrid using data source and adapter command
        dgv1stsem.DataSource = table1stsem.DefaultView

    End Sub

End Class
