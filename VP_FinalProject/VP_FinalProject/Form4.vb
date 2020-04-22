Public Class Validation
    Dim fromValidation As String
    Dim toValidation As String
    Dim derpartureValidation As Date
    Dim returnValidation As Date
    Dim passengersValidation As Integer
    Dim orderId As Integer
    Private Sub Validation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Conn()
    End Sub
    Private Sub TimerValidation_Tick(sender As Object, e As EventArgs) Handles TimerValidation.Tick
        fromValidation = NewData.CB_From.Text
        toValidation = NewData.CB_To.Text
        derpartureValidation = NewData.DTP_Departure.Value
        returnValidation = NewData.DTP_Return.Value
        passengersValidation = NewData.PassengersList.Items.Count


        BarValidation.Increment(1)
        ProgressValue.Text = BarValidation.Value & "%"
        If BarValidation.Value = 40 Then
            If fromValidation = "" Or toValidation = "" Or passengersValidation = 0 Then
                TimerValidation.Stop()
                MsgBox("Fullfill all data!")
                BarValidation.Value = 0
                Me.Hide()
                NewData.Enabled = True
            End If
        ElseIf BarValidation.Value = 70 Then
            If fromValidation = toValidation Then
                TimerValidation.Stop()
                MsgBox("Select another place. Can't be in the same place!")
                BarValidation.Value = 0
                Me.Hide()
                NewData.Enabled = True
            End If
        ElseIf BarValidation.Value = 100 Then
            If fromValidation <> toValidation And fromValidation <> "" And toValidation <> "" And passengersValidation <> 0 Then
                TimerValidation.Stop()
                Randomize()
                orderId = CInt(Int((1000 * Rnd()) + 1))
                CMD = New OleDb.OleDbCommand("SELECT * FROM order WHERE OrderId = " & orderId, Connection)
                DR = CMD.ExecuteReader
                DR.Read()
                While DR.HasRows
                    orderId = Int((1000 * Rnd()) + 1)
                End While
                CMD = New OleDb.OleDbCommand("INSERT INTO Order VALUES('" & orderId & "', '" & fromValidation & "', '" & toValidation & "', '" & derpartureValidation & "', '" & returnValidation & "')")
                CMD.ExecuteNonQuery()
                MsgBox("Your Data has been submitted!")
                Me.Hide()
                BarValidation.Value = 0
                NewData.Hide()
            End If
        End If

    End Sub


End Class