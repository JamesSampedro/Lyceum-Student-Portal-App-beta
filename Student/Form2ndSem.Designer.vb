<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2ndSem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2ndSem))
        Me.label1stSem = New System.Windows.Forms.Label()
        Me.dgv2ndsem = New System.Windows.Forms.DataGridView()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrelimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MidtermDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblGradesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Eclair_Student_PortalDataSet2 = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2()
        Me.TblGrade2ndSemQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGrade_2nd_Sem_QueryTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblGrade_2nd_Sem_QueryTableAdapter()
        Me.TblGradesTableAdapter = New Eclair_Student_Portal.Eclair_Student_PortalDataSet2TableAdapters.tblGradesTableAdapter()
        CType(Me.dgv2ndsem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGradesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eclair_Student_PortalDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGrade2ndSemQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1stSem
        '
        Me.label1stSem.AutoSize = True
        Me.label1stSem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1stSem.Location = New System.Drawing.Point(20, 18)
        Me.label1stSem.Name = "label1stSem"
        Me.label1stSem.Size = New System.Drawing.Size(106, 21)
        Me.label1stSem.TabIndex = 7
        Me.label1stSem.Text = "2nd Semester"
        '
        'dgv2ndsem
        '
        Me.dgv2ndsem.AutoGenerateColumns = False
        Me.dgv2ndsem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2ndsem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SemesterDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.PrelimDataGridViewTextBoxColumn, Me.MidtermDataGridViewTextBoxColumn, Me.FinalDataGridViewTextBoxColumn, Me.Average})
        Me.dgv2ndsem.DataSource = Me.TblGradesBindingSource
        Me.dgv2ndsem.Location = New System.Drawing.Point(24, 51)
        Me.dgv2ndsem.Name = "dgv2ndsem"
        Me.dgv2ndsem.Size = New System.Drawing.Size(643, 353)
        Me.dgv2ndsem.TabIndex = 9
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
        'Average
        '
        Me.Average.DataPropertyName = "Average"
        Me.Average.HeaderText = "Average"
        Me.Average.Name = "Average"
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
        'TblGrade2ndSemQueryBindingSource
        '
        Me.TblGrade2ndSemQueryBindingSource.DataMember = "tblGrade 2nd Sem Query"
        Me.TblGrade2ndSemQueryBindingSource.DataSource = Me.Eclair_Student_PortalDataSet2
        '
        'TblGrade_2nd_Sem_QueryTableAdapter
        '
        Me.TblGrade_2nd_Sem_QueryTableAdapter.ClearBeforeFill = True
        '
        'TblGradesTableAdapter
        '
        Me.TblGradesTableAdapter.ClearBeforeFill = True
        '
        'Form2ndSem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(693, 435)
        Me.Controls.Add(Me.dgv2ndsem)
        Me.Controls.Add(Me.label1stSem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2ndSem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2nd Semester Grades"
        CType(Me.dgv2ndsem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGradesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eclair_Student_PortalDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGrade2ndSemQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1stSem As Label
    Friend WithEvents dgv2ndsem As DataGridView
    Friend WithEvents Eclair_Student_PortalDataSet2 As Eclair_Student_PortalDataSet2
    Friend WithEvents TblGrade2ndSemQueryBindingSource As BindingSource
    Friend WithEvents TblGrade_2nd_Sem_QueryTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblGrade_2nd_Sem_QueryTableAdapter
    Friend WithEvents TblGradesBindingSource As BindingSource
    Friend WithEvents TblGradesTableAdapter As Eclair_Student_PortalDataSet2TableAdapters.tblGradesTableAdapter
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrelimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MidtermDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Average As DataGridViewTextBoxColumn
End Class
