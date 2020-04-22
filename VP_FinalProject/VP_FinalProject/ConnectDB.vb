Imports System.Data.OleDb
Module ConnectDB
    Public Connection As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader
    Public DT As DataTable

    Sub Conn()
        Try
            Connection = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=FlightTickets.accdb")
            Connection.Open()
        Catch ex As Exception
            MsgBox("Gagal")
        End Try
    End Sub
End Module


