<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewStudentGrades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViewStudentGrades))
        Me.dgv1stSem = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrelimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MidtermDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AverageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblGradesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Eclair_Student_PortalDataSet2 = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2()
        Me.TblGradesTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblGradesTableAdapter()
        Me.dgvStudentList = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStudentTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblStudentTableAdapter()
        Me.txtboxStudentID = New System.Windows.Forms.TextBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.label1stSem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv2ndSem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv1stSem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGradesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eclair_Student_PortalDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2ndSem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1stSem
        '
        Me.dgv1stSem.AutoGenerateColumns = False
        Me.dgv1stSem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1stSem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.PrelimDataGridViewTextBoxColumn, Me.MidtermDataGridViewTextBoxColumn, Me.FinalDataGridViewTextBoxColumn, Me.AverageDataGridViewTextBoxColumn})
        Me.dgv1stSem.DataSource = Me.TblGradesBindingSource
        Me.dgv1stSem.Location = New System.Drawing.Point(12, 123)
        Me.dgv1stSem.Name = "dgv1stSem"
        Me.dgv1stSem.Size = New System.Drawing.Size(744, 172)
        Me.dgv1stSem.TabIndex = 0
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'PrelimDataGridViewTextBoxColumn
        '
        Me.PrelimDataGridViewTextBoxColumn.DataPropertyName = "Prelim"
        Me.PrelimDataGridViewTextBoxColumn.HeaderText = "Prelim"
        Me.PrelimDataGridViewTextBoxColumn.Name = "PrelimDataGridViewTextBoxColumn"
        '
        'MidtermDataGridViewTextBoxColumn
        '
        Me.MidtermDataGridViewTextBoxColumn.DataPropertyName = "Midterm"
        Me.MidtermDataGridViewTextBoxColumn.HeaderText = "Midterm"
        Me.MidtermDataGridViewTextBoxColumn.Name = "MidtermDataGridViewTextBoxColumn"
        '
        'FinalDataGridViewTextBoxColumn
        '
        Me.FinalDataGridViewTextBoxColumn.DataPropertyName = "Final"
        Me.FinalDataGridViewTextBoxColumn.HeaderText = "Final"
        Me.FinalDataGridViewTextBoxColumn.Name = "FinalDataGridViewTextBoxColumn"
        '
        'AverageDataGridViewTextBoxColumn
        '
        Me.AverageDataGridViewTextBoxColumn.DataPropertyName = "Average"
        Me.AverageDataGridViewTextBoxColumn.HeaderText = "Average"
        Me.AverageDataGridViewTextBoxColumn.Name = "AverageDataGridViewTextBoxColumn"
        '
        'TblGradesBindingSource
        '
        Me.TblGradesBindingSource.DataMember = "tblGrades"
        Me.TblGradesBindingSource.DataSource = Me.Eclair_Student_PortalDataSet2
        '
        'Eclair_Student_PortalDataSet2
        '
        Me.Eclair_Student_PortalDataSet2.DataSetName = "Eclair_Student_PortalDataSet2"
        Me.Eclair_Student_PortalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGradesTableAdapter
        '
        Me.TblGradesTableAdapter.ClearBeforeFill = True
        '
        'dgvStudentList
        '
        Me.dgvStudentList.AutoGenerateColumns = False
        Me.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn1, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn})
        Me.dgvStudentList.DataSource = Me.TblStudentBindingSource
        Me.dgvStudentList.Location = New System.Drawing.Point(793, 40)
        Me.dgvStudentList.Name = "dgvStudentList"
        Me.dgvStudentList.Size = New System.Drawing.Size(344, 464)
        Me.dgvStudentList.TabIndex = 1
        '
        'StudentIDDataGridViewTextBoxColumn1
        '
        Me.StudentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn1.Name = "StudentIDDataGridViewTextBoxColumn1"
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'TblStudentBindingSource
        '
        Me.TblStudentBindingSource.DataMember = "tblStudent"
        Me.TblStudentBindingSource.DataSource = Me.Eclair_Student_PortalDataSet2
        '
        'TblStudentTableAdapter
        '
        Me.TblStudentTableAdapter.ClearBeforeFill = True
        '
        'txtboxStudentID
        '
        Me.txtboxStudentID.Location = New System.Drawing.Point(221, 46)
        Me.txtboxStudentID.Name = "txtboxStudentID"
        Me.txtboxStudentID.Size = New System.Drawing.Size(135, 20)
        Me.txtboxStudentID.TabIndex = 2
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(373, 36)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(166, 38)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'label1stSem
        '
        Me.label1stSem.AutoSize = True
        Me.label1stSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label1stSem.Location = New System.Drawing.Point(12, 98)
        Me.label1stSem.Name = "label1stSem"
        Me.label1stSem.Size = New System.Drawing.Size(108, 18)
        Me.label1stSem.TabIndex = 4
        Me.label1stSem.Text = "1st Semester"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "2nd Semester"
        '
        'dgv2ndSem
        '
        Me.dgv2ndSem.AutoGenerateColumns = False
        Me.dgv2ndSem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2ndSem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgv2ndSem.DataSource = Me.TblGradesBindingSource
        Me.dgv2ndSem.Location = New System.Drawing.Point(12, 332)
        Me.dgv2ndSem.Name = "dgv2ndSem"
        Me.dgv2ndSem.Size = New System.Drawing.Size(744, 172)
        Me.dgv2ndSem.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Semester"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Semester"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Prelim"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Prelim"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Midterm"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Midterm"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Final"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Final"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Average"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Average"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(789, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Student List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(142, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Student ID"
        '
        'FormViewStudentGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1152, 516)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv2ndSem)
        Me.Controls.Add(Me.label1stSem)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtboxStudentID)
        Me.Controls.Add(Me.dgvStudentList)
        Me.Controls.Add(Me.dgv1stSem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormViewStudentGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Grades"
        CType(Me.dgv1stSem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGradesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eclair_Student_PortalDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2ndSem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1stSem As DataGridView
    Friend WithEvents Eclair_Student_PortalDataSet2 As Eclair_Student_PortalDataSet2
    Friend WithEvents TblGradesBindingSource As BindingSource
    Friend WithEvents TblGradesTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblGradesTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrelimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MidtermDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AverageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvStudentList As DataGridView
    Friend WithEvents TblStudentBindingSource As BindingSource
    Friend WithEvents TblStudentTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblStudentTableAdapter
    Friend WithEvents txtboxStudentID As TextBox
    Friend WithEvents btnView As Button
    Friend WithEvents StudentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents label1stSem As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv2ndSem As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
