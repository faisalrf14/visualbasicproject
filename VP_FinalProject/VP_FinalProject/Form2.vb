Public Class NewData
    Dim ManyPassengers As Boolean
    Public PassengerName(1000) As String
    Public PassengerAge(1000) As Integer
    Dim index As Integer

    Private Function passengerValidation(ByVal x As String)
        If x = "one" Then
            passengerValidation = "False"
        ElseIf x = "many" Then
            passengerValidation = "True"
        End If
    End Function
    Private Sub ReturnChecked_CheckedChanged(sender As Object, e As EventArgs) Handles ReturnChecked.CheckedChanged
        ReturnLabel.Visible = True
        DTP_Return.Visible = True
        If Not ReturnChecked.Checked Then
            ReturnLabel.Visible = False
            DTP_Return.Visible = False
        End If
    End Sub

    Private Sub Add_Passenger_Click(sender As Object, e As EventArgs) Handles Add_Passenger.Click
        If Passenger.Text = "" Or Age.Text = "" Then
            MsgBox("Complete Your Name and Age")
        ElseIf Passenger.Text <> "" Or Age.Text <> "" Then
            PassengersList.Items.Add("Name : " & Passenger.Text & ". Age : " & Age.Text)
            PassengerName(index) = Passenger.Text
            PassengerAge(index) = Age.Text
            index += 1
            Passenger.Text = ""
            Age.Text = ""
        End If

        If ManyPassengers = False And PassengersList.Items.Count > 0 Then
            Add_Passenger.Enabled = False
            Age.Enabled = False
            Passenger.Enabled = False
        End If

    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        PassengersList.Items.RemoveAt(PassengersList.SelectedIndex())
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Validation.Show()
        Validation.TimerValidation.Start()
        Me.Enabled = False
    End Sub
    Private Sub OnePerson_CheckedChanged(sender As Object, e As EventArgs) Handles OnePerson.CheckedChanged
        ManyPassengers = passengerValidation("one")
        Passenger.Enabled = True
        Age.Enabled = True
        Add_Passenger.Enabled = True
        MoreThanOne.Enabled = False
    End Sub

    Private Sub MoreThanOne_CheckedChanged(sender As Object, e As EventArgs) Handles MoreThanOne.CheckedChanged
        ManyPassengers = passengerValidation("many")
        Passenger.Enabled = True
        Age.Enabled = True
        Add_Passenger.Enabled = True
        OnePerson.Enabled = False
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        For a As Integer = 0 To a < 1000
            PassengerName(a) = ""
            PassengerAge(a) = 0
        Next
        index = 0
        OnePerson.Checked = False
        MoreThanOne.Checked = False
        Add_Passenger.Enabled = False
        Age.Enabled = False
        Passenger.Enabled = False
        OnePerson.Enabled = True
        MoreThanOne.Enabled = True
        PassengersList.Items.Clear()
    End Sub

    Private Sub NewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class