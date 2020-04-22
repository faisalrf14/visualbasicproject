Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Conn()
        PasswordLogin.PasswordChar = "*"
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameLogin.Text = "" Or PasswordLogin.Text = "" Then
            MsgBox("Username & Password Required")
        Else
            TimerLogin.Start()
        End If
    End Sub
    Private Sub TimerLogin_Tick(sender As Object, e As EventArgs) Handles TimerLogin.Tick
        CMD = New OleDb.OleDbCommand("SELECT * FROM Login WHERE Username = '" & UsernameLogin.Text & "' AND Password = '" & PasswordLogin.Text & "'", Connection)
        DR = CMD.ExecuteReader
        DR.Read()
        BarLogin.Visible = True
        BarLogin.Increment(1)
        If BarLogin.Value = 50 Then
            If Not DR.HasRows Then
                TimerLogin.Stop()
                BarLogin.Value = 0
                BarLogin.Visible = False
                MsgBox("FAILED")
            End If
        ElseIf BarLogin.Value = 100 Then
            If DR.HasRows Then
                TimerLogin.Stop()
                BarLogin.Value = 0
                MDIParent1.LoginToolStripMenuItem.Visible = False
                Editing.Show()
                Me.Hide()
            End If
        End If

    End Sub


End Class