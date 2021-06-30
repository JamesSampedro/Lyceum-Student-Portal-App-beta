<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdminMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminMenu))
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnModifyGrades = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.btnViewGrades = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Image = CType(resources.GetObject("btnAddStudent.Image"), System.Drawing.Image)
        Me.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddStudent.Location = New System.Drawing.Point(66, 46)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(115, 41)
        Me.btnAddStudent.TabIndex = 0
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnModifyGrades
        '
        Me.btnModifyGrades.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyGrades.Image = CType(resources.GetObject("btnModifyGrades.Image"), System.Drawing.Image)
        Me.btnModifyGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyGrades.Location = New System.Drawing.Point(219, 46)
        Me.btnModifyGrades.Name = "btnModifyGrades"
        Me.btnModifyGrades.Size = New System.Drawing.Size(127, 41)
        Me.btnModifyGrades.TabIndex = 1
        Me.btnModifyGrades.Text = "Modify Grades"
        Me.btnModifyGrades.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModifyGrades.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.Location = New System.Drawing.Point(318, 187)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(84, 32)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.Image = CType(resources.GetObject("btnAddAdmin.Image"), System.Drawing.Image)
        Me.btnAddAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAdmin.Location = New System.Drawing.Point(66, 106)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(115, 41)
        Me.btnAddAdmin.TabIndex = 3
        Me.btnAddAdmin.Text = "Add Admin"
        Me.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddAdmin.UseVisualStyleBackColor = True
        '
        'btnViewGrades
        '
        Me.btnViewGrades.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewGrades.Image = CType(resources.GetObject("btnViewGrades.Image"), System.Drawing.Image)
        Me.btnViewGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewGrades.Location = New System.Drawing.Point(219, 106)
        Me.btnViewGrades.Name = "btnViewGrades"
        Me.btnViewGrades.Size = New System.Drawing.Size(127, 41)
        Me.btnViewGrades.TabIndex = 4
        Me.btnViewGrades.Text = "View Grades"
        Me.btnViewGrades.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewGrades.UseVisualStyleBackColor = True
        '
        'FormAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(414, 232)
        Me.Controls.Add(Me.btnViewGrades)
        Me.Controls.Add(Me.btnAddAdmin)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnModifyGrades)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnModifyGrades As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAddAdmin As Button
    Friend WithEvents btnViewGrades As Button
End Class
