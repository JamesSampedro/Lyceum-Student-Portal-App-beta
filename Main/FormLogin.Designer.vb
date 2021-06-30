<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.labelEcStudPortal = New System.Windows.Forms.Label()
        Me.labelLoginID = New System.Windows.Forms.Label()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.labelUserType = New System.Windows.Forms.Label()
        Me.txtboxLoginID = New System.Windows.Forms.TextBox()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.btnStudentLogin = New System.Windows.Forms.Button()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelEcStudPortal
        '
        Me.labelEcStudPortal.AutoSize = True
        Me.labelEcStudPortal.BackColor = System.Drawing.Color.Transparent
        Me.labelEcStudPortal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEcStudPortal.Location = New System.Drawing.Point(117, 158)
        Me.labelEcStudPortal.Name = "labelEcStudPortal"
        Me.labelEcStudPortal.Size = New System.Drawing.Size(235, 30)
        Me.labelEcStudPortal.TabIndex = 1
        Me.labelEcStudPortal.Text = "Lyceum Student Portal"
        '
        'labelLoginID
        '
        Me.labelLoginID.AutoSize = True
        Me.labelLoginID.BackColor = System.Drawing.Color.CadetBlue
        Me.labelLoginID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLoginID.Location = New System.Drawing.Point(73, 240)
        Me.labelLoginID.Name = "labelLoginID"
        Me.labelLoginID.Size = New System.Drawing.Size(59, 14)
        Me.labelLoginID.TabIndex = 2
        Me.labelLoginID.Text = "Login ID"
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.BackColor = System.Drawing.Color.CadetBlue
        Me.labelPassword.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPassword.Location = New System.Drawing.Point(63, 274)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(69, 14)
        Me.labelPassword.TabIndex = 3
        Me.labelPassword.Text = "Password"
        '
        'labelUserType
        '
        Me.labelUserType.AutoSize = True
        Me.labelUserType.BackColor = System.Drawing.Color.CadetBlue
        Me.labelUserType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUserType.Location = New System.Drawing.Point(63, 322)
        Me.labelUserType.Name = "labelUserType"
        Me.labelUserType.Size = New System.Drawing.Size(69, 14)
        Me.labelUserType.TabIndex = 4
        Me.labelUserType.Text = "User Type"
        '
        'txtboxLoginID
        '
        Me.txtboxLoginID.Location = New System.Drawing.Point(157, 235)
        Me.txtboxLoginID.Name = "txtboxLoginID"
        Me.txtboxLoginID.Size = New System.Drawing.Size(232, 20)
        Me.txtboxLoginID.TabIndex = 5
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Location = New System.Drawing.Point(157, 272)
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtboxPassword.Size = New System.Drawing.Size(232, 20)
        Me.txtboxPassword.TabIndex = 6
        '
        'cmbUserType
        '
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Admin", "Student"})
        Me.cmbUserType.Location = New System.Drawing.Point(157, 317)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(127, 21)
        Me.cmbUserType.TabIndex = 7
        '
        'btnStudentLogin
        '
        Me.btnStudentLogin.BackColor = System.Drawing.Color.PowderBlue
        Me.btnStudentLogin.Enabled = False
        Me.btnStudentLogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentLogin.Location = New System.Drawing.Point(283, 360)
        Me.btnStudentLogin.Name = "btnStudentLogin"
        Me.btnStudentLogin.Size = New System.Drawing.Size(106, 26)
        Me.btnStudentLogin.TabIndex = 8
        Me.btnStudentLogin.Text = "Student Login"
        Me.btnStudentLogin.UseVisualStyleBackColor = False
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.BackColor = System.Drawing.Color.LightBlue
        Me.btnAdminLogin.Enabled = False
        Me.btnAdminLogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLogin.Location = New System.Drawing.Point(157, 360)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(106, 26)
        Me.btnAdminLogin.TabIndex = 9
        Me.btnAdminLogin.Text = "Admin Login"
        Me.btnAdminLogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(148, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(463, 417)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.btnStudentLogin)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.txtboxPassword)
        Me.Controls.Add(Me.txtboxLoginID)
        Me.Controls.Add(Me.labelUserType)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.labelLoginID)
        Me.Controls.Add(Me.labelEcStudPortal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelEcStudPortal As Label
    Friend WithEvents labelLoginID As Label
    Friend WithEvents labelPassword As Label
    Friend WithEvents labelUserType As Label
    Friend WithEvents txtboxLoginID As TextBox
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents btnStudentLogin As Button
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
