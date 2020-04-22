<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BarLogin = New System.Windows.Forms.ProgressBar()
        Me.PasswordLogin = New System.Windows.Forms.MaskedTextBox()
        Me.UsernameLogin = New System.Windows.Forms.MaskedTextBox()
        Me.TimerLogin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Snow
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(33, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 284)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.Snow
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(461, 43)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(164, 36)
        Me.Username.TabIndex = 1
        Me.Username.Text = "USERNAME"
        Me.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PASSWORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LoginButton.ImageKey = "door-login-icon--1.png"
        Me.LoginButton.ImageList = Me.ImageList1
        Me.LoginButton.Location = New System.Drawing.Point(466, 237)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(147, 51)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.Text = "LOGIN"
        Me.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "door-login-icon--1.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Controls.Add(Me.BarLogin)
        Me.GroupBox1.Controls.Add(Me.Username)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PasswordLogin)
        Me.GroupBox1.Controls.Add(Me.UsernameLogin)
        Me.GroupBox1.Controls.Add(Me.LoginButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 353)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LoginForm"
        '
        'BarLogin
        '
        Me.BarLogin.Location = New System.Drawing.Point(0, 339)
        Me.BarLogin.Name = "BarLogin"
        Me.BarLogin.Size = New System.Drawing.Size(755, 14)
        Me.BarLogin.TabIndex = 8
        Me.BarLogin.Visible = False
        '
        'PasswordLogin
        '
        Me.PasswordLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLogin.Location = New System.Drawing.Point(372, 190)
        Me.PasswordLogin.Name = "PasswordLogin"
        Me.PasswordLogin.Size = New System.Drawing.Size(341, 29)
        Me.PasswordLogin.TabIndex = 7
        '
        'UsernameLogin
        '
        Me.UsernameLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLogin.Location = New System.Drawing.Point(372, 96)
        Me.UsernameLogin.Name = "UsernameLogin"
        Me.UsernameLogin.Size = New System.Drawing.Size(341, 29)
        Me.UsernameLogin.TabIndex = 6
        '
        'TimerLogin
        '
        Me.TimerLogin.Interval = 25
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(779, 377)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PasswordLogin As MaskedTextBox
    Friend WithEvents UsernameLogin As MaskedTextBox
    Friend WithEvents BarLogin As ProgressBar
    Friend WithEvents TimerLogin As Timer
End Class
