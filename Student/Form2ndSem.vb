Imports Eclair_Student_Portal.FormLogin
Imports System.Data.OleDb

Public Class Form2ndSem
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub Form2ndSem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Eclair_Student_PortalDataSet2.tblGrades' table. You can move, or remove it, as needed.
        Me.TblGradesTableAdapter.Fill(Me.Eclair_Student_PortalDataSet2.tblGrades)

        Dim conn As New OleDbConnection(cs)

        'Fill up the SalaryLoan DataGrid
        Dim data2ndsem As String = "SELECT * FROM tblGrades WHERE StudentID=@StudentID AND Semester='2nd'"
        Dim datafetch2ndsem As New OleDbCommand(data2ndsem, conn)
        'Uses the EmpID from the Login information to fetch user data
        datafetch2ndsem.Parameters.AddWithValue("@StudentID", FetchStudID.SavedStudID)
        'Uses the query to fill data on the Datagrid
        Dim adapter2ndsem As New OleDbDataAdapter(datafetch2ndsem)
        Dim table2ndsem As New DataTable()
        adapter2ndsem.Fill(table2ndsem)

        'Puts it on the datagrid using data source and adapter command
        dgv2ndsem.DataSource = table2ndsem.DefaultView

    End Sub

End Class