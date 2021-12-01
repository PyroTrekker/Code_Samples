<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnOpenFrmRegister = New System.Windows.Forms.Button()
        Me.gpbLogin = New System.Windows.Forms.GroupBox()
        Me.gpbRegister = New System.Windows.Forms.GroupBox()
        Me.gpbLogin.SuspendLayout()
        Me.gpbRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(6, 25)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 17)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(6, 67)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(94, 18)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(94, 60)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(119, 108)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnOpenFrmRegister
        '
        Me.btnOpenFrmRegister.Location = New System.Drawing.Point(119, 38)
        Me.btnOpenFrmRegister.Name = "btnOpenFrmRegister"
        Me.btnOpenFrmRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFrmRegister.TabIndex = 5
        Me.btnOpenFrmRegister.Text = "Register"
        Me.btnOpenFrmRegister.UseVisualStyleBackColor = True
        '
        'gpbLogin
        '
        Me.gpbLogin.Controls.Add(Me.txtUsername)
        Me.gpbLogin.Controls.Add(Me.txtPassword)
        Me.gpbLogin.Controls.Add(Me.btnLogin)
        Me.gpbLogin.Controls.Add(Me.lblUsername)
        Me.gpbLogin.Controls.Add(Me.lblPassword)
        Me.gpbLogin.Location = New System.Drawing.Point(12, 12)
        Me.gpbLogin.Name = "gpbLogin"
        Me.gpbLogin.Size = New System.Drawing.Size(200, 137)
        Me.gpbLogin.TabIndex = 6
        Me.gpbLogin.TabStop = False
        Me.gpbLogin.Text = "Login Here"
        '
        'gpbRegister
        '
        Me.gpbRegister.Controls.Add(Me.btnOpenFrmRegister)
        Me.gpbRegister.Enabled = False
        Me.gpbRegister.Location = New System.Drawing.Point(12, 155)
        Me.gpbRegister.Name = "gpbRegister"
        Me.gpbRegister.Size = New System.Drawing.Size(200, 66)
        Me.gpbRegister.TabIndex = 7
        Me.gpbRegister.TabStop = False
        Me.gpbRegister.Text = "Or Click Here to register"
        Me.gpbRegister.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 236)
        Me.Controls.Add(Me.gpbRegister)
        Me.Controls.Add(Me.gpbLogin)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.gpbLogin.ResumeLayout(False)
        Me.gpbLogin.PerformLayout()
        Me.gpbRegister.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnOpenFrmRegister As System.Windows.Forms.Button
    Friend WithEvents gpbLogin As System.Windows.Forms.GroupBox
    Friend WithEvents gpbRegister As System.Windows.Forms.GroupBox
End Class
