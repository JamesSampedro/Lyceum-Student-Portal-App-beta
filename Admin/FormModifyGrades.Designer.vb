<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModifyGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModifyGrades))
        Me.dgvStudenttable = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Eclair_Student_PortalDataSet2 = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2()
        Me.dgvGradetable = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrelimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MidtermDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblGradesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btmEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtboxPrelim = New System.Windows.Forms.TextBox()
        Me.txtboxMidterm = New System.Windows.Forms.TextBox()
        Me.txtboxFinals = New System.Windows.Forms.TextBox()
        Me.lblFinals = New System.Windows.Forms.Label()
        Me.lblMidterm = New System.Windows.Forms.Label()
        Me.lblPrelim = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.txtboxStudentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TblStudentTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblStudentTableAdapter()
        Me.TblGradesTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblGradesTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxAverage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculateAvg = New System.Windows.Forms.Button()
        Me.txtboxGradeID = New System.Windows.Forms.TextBox()
        Me.lblGradeID = New System.Windows.Forms.Label()
        CType(Me.dgvStudenttable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eclair_Student_PortalDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGradetable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGradesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStudenttable
        '
        Me.dgvStudenttable.AutoGenerateColumns = False
        Me.dgvStudenttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudenttable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn})
        Me.dgvStudenttable.DataSource = Me.TblStudentBindingSource
        Me.dgvStudenttable.Location = New System.Drawing.Point(786, 40)
        Me.dgvStudenttable.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvStudenttable.Name = "dgvStudenttable"
        Me.dgvStudenttable.RowHeadersWidth = 51
        Me.dgvStudenttable.RowTemplate.Height = 24
        Me.dgvStudenttable.Size = New System.Drawing.Size(354, 424)
        Me.dgvStudenttable.TabIndex = 33
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
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
        'Eclair_Student_PortalDataSet2
        '
        Me.Eclair_Student_PortalDataSet2.DataSetName = "Eclair_Student_PortalDataSet2"
        Me.Eclair_Student_PortalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvGradetable
        '
        Me.dgvGradetable.AutoGenerateColumns = False
        Me.dgvGradetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGradetable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn1, Me.SemesterDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.PrelimDataGridViewTextBoxColumn, Me.MidtermDataGridViewTextBoxColumn, Me.Average, Me.FinalDataGridViewTextBoxColumn, Me.Column1})
        Me.dgvGradetable.DataSource = Me.TblGradesBindingSource
        Me.dgvGradetable.Location = New System.Drawing.Point(20, 159)
        Me.dgvGradetable.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvGradetable.Name = "dgvGradetable"
        Me.dgvGradetable.RowHeadersWidth = 51
        Me.dgvGradetable.RowTemplate.Height = 24
        Me.dgvGradetable.Size = New System.Drawing.Size(753, 305)
        Me.dgvGradetable.TabIndex = 32
        '
        'StudentIDDataGridViewTextBoxColumn1
        '
        Me.StudentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn1.Name = "StudentIDDataGridViewTextBoxColumn1"
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
        'Average
        '
        Me.Average.DataPropertyName = "Average"
        Me.Average.HeaderText = "Average"
        Me.Average.Name = "Average"
        '
        'FinalDataGridViewTextBoxColumn
        '
        Me.FinalDataGridViewTextBoxColumn.DataPropertyName = "Final"
        Me.FinalDataGridViewTextBoxColumn.HeaderText = "Final"
        Me.FinalDataGridViewTextBoxColumn.Name = "FinalDataGridViewTextBoxColumn"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "GradeID"
        Me.Column1.HeaderText = "GradeID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'TblGradesBindingSource
        '
        Me.TblGradesBindingSource.DataMember = "tblGrades"
        Me.TblGradesBindingSource.DataSource = Me.Eclair_Student_PortalDataSet2
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(661, 46)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 50)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btmEdit
        '
        Me.btmEdit.Location = New System.Drawing.Point(601, 46)
        Me.btmEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btmEdit.Name = "btmEdit"
        Me.btmEdit.Size = New System.Drawing.Size(56, 50)
        Me.btmEdit.TabIndex = 30
        Me.btmEdit.Text = "Edit"
        Me.btmEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(541, 46)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 50)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtboxPrelim
        '
        Me.txtboxPrelim.Location = New System.Drawing.Point(247, 20)
        Me.txtboxPrelim.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxPrelim.MaxLength = 3
        Me.txtboxPrelim.Name = "txtboxPrelim"
        Me.txtboxPrelim.Size = New System.Drawing.Size(117, 20)
        Me.txtboxPrelim.TabIndex = 27
        '
        'txtboxMidterm
        '
        Me.txtboxMidterm.Location = New System.Drawing.Point(247, 48)
        Me.txtboxMidterm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxMidterm.MaxLength = 3
        Me.txtboxMidterm.Name = "txtboxMidterm"
        Me.txtboxMidterm.Size = New System.Drawing.Size(117, 20)
        Me.txtboxMidterm.TabIndex = 26
        '
        'txtboxFinals
        '
        Me.txtboxFinals.Location = New System.Drawing.Point(247, 76)
        Me.txtboxFinals.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxFinals.MaxLength = 3
        Me.txtboxFinals.Name = "txtboxFinals"
        Me.txtboxFinals.Size = New System.Drawing.Size(117, 20)
        Me.txtboxFinals.TabIndex = 25
        '
        'lblFinals
        '
        Me.lblFinals.AutoSize = True
        Me.lblFinals.Location = New System.Drawing.Point(209, 83)
        Me.lblFinals.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFinals.Name = "lblFinals"
        Me.lblFinals.Size = New System.Drawing.Size(34, 13)
        Me.lblFinals.TabIndex = 21
        Me.lblFinals.Text = "Finals"
        '
        'lblMidterm
        '
        Me.lblMidterm.AutoSize = True
        Me.lblMidterm.Location = New System.Drawing.Point(199, 55)
        Me.lblMidterm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMidterm.Name = "lblMidterm"
        Me.lblMidterm.Size = New System.Drawing.Size(44, 13)
        Me.lblMidterm.TabIndex = 20
        Me.lblMidterm.Text = "Midterm"
        '
        'lblPrelim
        '
        Me.lblPrelim.AutoSize = True
        Me.lblPrelim.Location = New System.Drawing.Point(204, 23)
        Me.lblPrelim.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrelim.Name = "lblPrelim"
        Me.lblPrelim.Size = New System.Drawing.Size(35, 13)
        Me.lblPrelim.TabIndex = 19
        Me.lblPrelim.Text = "Prelim"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(14, 81)
        Me.lblSubject.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(43, 13)
        Me.lblSubject.TabIndex = 18
        Me.lblSubject.Text = "Subject"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(6, 49)
        Me.lblSemester.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(51, 13)
        Me.lblSemester.TabIndex = 17
        Me.lblSemester.Text = "Semester"
        '
        'cmbSemester
        '
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"1st", "2nd"})
        Me.cmbSemester.Location = New System.Drawing.Point(66, 46)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(116, 21)
        Me.cmbSemester.TabIndex = 34
        '
        'cmbSubject
        '
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Items.AddRange(New Object() {"Math", "Science", "English"})
        Me.cmbSubject.Location = New System.Drawing.Point(65, 73)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(116, 21)
        Me.cmbSubject.TabIndex = 35
        '
        'txtboxStudentID
        '
        Me.txtboxStudentID.Location = New System.Drawing.Point(65, 20)
        Me.txtboxStudentID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxStudentID.Name = "txtboxStudentID"
        Me.txtboxStudentID.ReadOnly = True
        Me.txtboxStudentID.Size = New System.Drawing.Size(117, 20)
        Me.txtboxStudentID.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Student ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(782, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Student List"
        '
        'TblStudentTableAdapter
        '
        Me.TblStudentTableAdapter.ClearBeforeFill = True
        '
        'TblGradesTableAdapter
        '
        Me.TblGradesTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Grade List"
        '
        'txtboxAverage
        '
        Me.txtboxAverage.Location = New System.Drawing.Point(384, 48)
        Me.txtboxAverage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxAverage.MaxLength = 5
        Me.txtboxAverage.Name = "txtboxAverage"
        Me.txtboxAverage.Size = New System.Drawing.Size(117, 20)
        Me.txtboxAverage.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Average"
        '
        'btnCalculateAvg
        '
        Me.btnCalculateAvg.Location = New System.Drawing.Point(384, 70)
        Me.btnCalculateAvg.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculateAvg.Name = "btnCalculateAvg"
        Me.btnCalculateAvg.Size = New System.Drawing.Size(117, 39)
        Me.btnCalculateAvg.TabIndex = 50
        Me.btnCalculateAvg.Text = "Calculate Average"
        Me.btnCalculateAvg.UseVisualStyleBackColor = True
        '
        'txtboxGradeID
        '
        Me.txtboxGradeID.Location = New System.Drawing.Point(175, 131)
        Me.txtboxGradeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxGradeID.Name = "txtboxGradeID"
        Me.txtboxGradeID.ReadOnly = True
        Me.txtboxGradeID.Size = New System.Drawing.Size(117, 20)
        Me.txtboxGradeID.TabIndex = 52
        '
        'lblGradeID
        '
        Me.lblGradeID.AutoSize = True
        Me.lblGradeID.Location = New System.Drawing.Point(113, 138)
        Me.lblGradeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGradeID.Name = "lblGradeID"
        Me.lblGradeID.Size = New System.Drawing.Size(50, 13)
        Me.lblGradeID.TabIndex = 51
        Me.lblGradeID.Text = "Grade ID"
        '
        'FormModifyGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1156, 475)
        Me.Controls.Add(Me.txtboxGradeID)
        Me.Controls.Add(Me.lblGradeID)
        Me.Controls.Add(Me.btnCalculateAvg)
        Me.Controls.Add(Me.txtboxAverage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtboxStudentID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.cmbSemester)
        Me.Controls.Add(Me.dgvStudenttable)
        Me.Controls.Add(Me.dgvGradetable)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btmEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtboxPrelim)
        Me.Controls.Add(Me.txtboxMidterm)
        Me.Controls.Add(Me.txtboxFinals)
        Me.Controls.Add(Me.lblFinals)
        Me.Controls.Add(Me.lblMidterm)
        Me.Controls.Add(Me.lblPrelim)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblSemester)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormModifyGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Grades"
        CType(Me.dgvStudenttable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eclair_Student_PortalDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGradetable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGradesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStudenttable As DataGridView
    Friend WithEvents dgvGradetable As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btmEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtboxPrelim As TextBox
    Friend WithEvents txtboxMidterm As TextBox
    Friend WithEvents txtboxFinals As TextBox
    Friend WithEvents lblFinals As Label
    Friend WithEvents lblMidterm As Label
    Friend WithEvents lblPrelim As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents txtboxStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Eclair_Student_PortalDataSet2 As Eclair_Student_PortalDataSet2
    Friend WithEvents TblStudentBindingSource As BindingSource
    Friend WithEvents TblStudentTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblStudentTableAdapter
    Friend WithEvents TblGradesBindingSource As BindingSource
    Friend WithEvents TblGradesTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblGradesTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxAverage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculateAvg As Button
    Friend WithEvents StudentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrelimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MidtermDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Average As DataGridViewTextBoxColumn
    Friend WithEvents FinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents txtboxGradeID As TextBox
    Friend WithEvents lblGradeID As Label
End Class
