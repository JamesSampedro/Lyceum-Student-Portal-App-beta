<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudentProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStudentProfile))
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.txtboxPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.txtboxLname = New System.Windows.Forms.TextBox()
        Me.txtboxFname = New System.Windows.Forms.TextBox()
        Me.btnEditPasword = New System.Windows.Forms.Button()
        Me.btnEditContact = New System.Windows.Forms.Button()
        Me.btnEditEmail = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblContactno = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Location = New System.Drawing.Point(72, 130)
        Me.txtboxPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxPassword.MaxLength = 9
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(127, 20)
        Me.txtboxPassword.TabIndex = 27
        '
        'txtboxPhoneNo
        '
        Me.txtboxPhoneNo.Location = New System.Drawing.Point(72, 105)
        Me.txtboxPhoneNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxPhoneNo.MaxLength = 9
        Me.txtboxPhoneNo.Name = "txtboxPhoneNo"
        Me.txtboxPhoneNo.Size = New System.Drawing.Size(127, 20)
        Me.txtboxPhoneNo.TabIndex = 26
        '
        'txtboxEmail
        '
        Me.txtboxEmail.Location = New System.Drawing.Point(72, 80)
        Me.txtboxEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(127, 20)
        Me.txtboxEmail.TabIndex = 25
        '
        'txtboxLname
        '
        Me.txtboxLname.Location = New System.Drawing.Point(72, 53)
        Me.txtboxLname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxLname.Name = "txtboxLname"
        Me.txtboxLname.ReadOnly = True
        Me.txtboxLname.Size = New System.Drawing.Size(127, 20)
        Me.txtboxLname.TabIndex = 24
        '
        'txtboxFname
        '
        Me.txtboxFname.Location = New System.Drawing.Point(72, 23)
        Me.txtboxFname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxFname.Name = "txtboxFname"
        Me.txtboxFname.ReadOnly = True
        Me.txtboxFname.Size = New System.Drawing.Size(127, 20)
        Me.txtboxFname.TabIndex = 23
        '
        'btnEditPasword
        '
        Me.btnEditPasword.Location = New System.Drawing.Point(212, 131)
        Me.btnEditPasword.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditPasword.Name = "btnEditPasword"
        Me.btnEditPasword.Size = New System.Drawing.Size(56, 19)
        Me.btnEditPasword.TabIndex = 21
        Me.btnEditPasword.Text = "Edit"
        Me.btnEditPasword.UseVisualStyleBackColor = True
        '
        'btnEditContact
        '
        Me.btnEditContact.Location = New System.Drawing.Point(212, 106)
        Me.btnEditContact.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditContact.Name = "btnEditContact"
        Me.btnEditContact.Size = New System.Drawing.Size(56, 19)
        Me.btnEditContact.TabIndex = 20
        Me.btnEditContact.Text = "Edit"
        Me.btnEditContact.UseVisualStyleBackColor = True
        '
        'btnEditEmail
        '
        Me.btnEditEmail.Location = New System.Drawing.Point(212, 80)
        Me.btnEditEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditEmail.Name = "btnEditEmail"
        Me.btnEditEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEditEmail.Size = New System.Drawing.Size(56, 19)
        Me.btnEditEmail.TabIndex = 19
        Me.btnEditEmail.Text = "Edit"
        Me.btnEditEmail.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(15, 137)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 18
        Me.lblPassword.Text = "Password"
        '
        'lblContactno
        '
        Me.lblContactno.AutoSize = True
        Me.lblContactno.Location = New System.Drawing.Point(7, 112)
        Me.lblContactno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContactno.Name = "lblContactno"
        Me.lblContactno.Size = New System.Drawing.Size(61, 13)
        Me.lblContactno.TabIndex = 17
        Me.lblContactno.Text = "Contact No"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(36, 87)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email"
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Location = New System.Drawing.Point(10, 60)
        Me.lblLastname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(58, 13)
        Me.lblLastname.TabIndex = 15
        Me.lblLastname.Text = "Last Name"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(11, 30)
        Me.lblFirstname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstname.TabIndex = 14
        Me.lblFirstname.Text = "First Name"
        '
        'FormStudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(289, 180)
        Me.Controls.Add(Me.txtboxPassword)
        Me.Controls.Add(Me.txtboxPhoneNo)
        Me.Controls.Add(Me.txtboxEmail)
        Me.Controls.Add(Me.txtboxLname)
        Me.Controls.Add(Me.txtboxFname)
        Me.Controls.Add(Me.btnEditPasword)
        Me.Controls.Add(Me.btnEditContact)
        Me.Controls.Add(Me.btnEditEmail)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblContactno)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastname)
        Me.Controls.Add(Me.lblFirstname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormStudentProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents txtboxPhoneNo As TextBox
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents txtboxLname As TextBox
    Friend WithEvents txtboxFname As TextBox
    Friend WithEvents btnEditPasword As Button
    Friend WithEvents btnEditContact As Button
    Friend WithEvents btnEditEmail As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblContactno As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblFirstname As Label
End Class
