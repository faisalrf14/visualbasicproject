Public Class Editing
    Private Sub AddDestination_Click(sender As Object, e As EventArgs) Handles AddDestination.Click
        Dim Destination As String
        Destination = InputBox("Enter The Destination")
        If Destination = "" Then
            MsgBox("Fill Your Destination")
        Else
            If DestinationTree.SelectedNode Is Nothing Then
                DestinationTree.Nodes.Add(Destination, Destination)
            Else
                DestinationTree.SelectedNode.Nodes.Add(Destination, Destination)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.LoginToolStripMenuItem.Visible = True
    End Sub

    Private Sub Editing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightTicketsDataSet.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.FlightTicketsDataSet.Order)

        Call showData()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next

        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        DTP_Derparture.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        DTP_Return.Value = DataGridView1.Rows(e.RowIndex).Cells(4).Value


    End Sub

    Sub showData()
        Call Conn()
        DA = New OleDb.OleDbDataAdapter("SELECT * From [Order]", Connection)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub


End Class