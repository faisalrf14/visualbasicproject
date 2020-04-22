<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editing
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editing))
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("England")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aceh")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bali")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bandung")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lampung")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manado")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Medan")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jakarta")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Padang")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Palembang")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Papua")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pekanbaru")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Semarang")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Surabaya")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Indonesia", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25, TreeNode26, TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode31, TreeNode32, TreeNode33, TreeNode34, TreeNode35})
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Singapura")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chicago")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Los Angeles")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Miami")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("New York")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("USA", New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode39, TreeNode40, TreeNode41})
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP_Return = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Derparture = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OrderIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DerpartureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassengerAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightTicketsDataSet = New VP_FinalProject.FlightTicketsDataSet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AddDestination = New System.Windows.Forms.Button()
        Me.DestinationTree = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OrderTableAdapter = New VP_FinalProject.FlightTicketsDataSetTableAdapters.OrderTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightTicketsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.ImageKey = "img_537596.png"
        Me.Label1.ImageList = Me.ImageList1
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 56)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FROM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "airplane-landing.png")
        Me.ImageList1.Images.SetKeyName(1, "calendar-512.png")
        Me.ImageList1.Images.SetKeyName(2, "img_537596.png")
        Me.ImageList1.Images.SetKeyName(3, "Logout-512.png")
        Me.ImageList1.Images.SetKeyName(4, "passenger_721985.png")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.ImageKey = "airplane-landing.png"
        Me.Label2.ImageList = Me.ImageList1
        Me.Label2.Location = New System.Drawing.Point(6, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 58)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImageKey = "calendar-512.png"
        Me.Label3.ImageList = Me.ImageList1
        Me.Label3.Location = New System.Drawing.Point(6, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 58)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DERPARTURE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTP_Return)
        Me.GroupBox1.Controls.Add(Me.DTP_Derparture)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 414)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editing"
        '
        'DTP_Return
        '
        Me.DTP_Return.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Return.Location = New System.Drawing.Point(232, 283)
        Me.DTP_Return.Name = "DTP_Return"
        Me.DTP_Return.Size = New System.Drawing.Size(322, 30)
        Me.DTP_Return.TabIndex = 17
        '
        'DTP_Derparture
        '
        Me.DTP_Derparture.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Derparture.Location = New System.Drawing.Point(232, 207)
        Me.DTP_Derparture.Name = "DTP_Derparture"
        Me.DTP_Derparture.Size = New System.Drawing.Size(322, 30)
        Me.DTP_Derparture.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(232, 37)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(322, 35)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(232, 123)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(322, 35)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(232, 353)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(322, 35)
        Me.TextBox5.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.ImageKey = "passenger_721985.png"
        Me.Label5.ImageList = Me.ImageList1
        Me.Label5.Location = New System.Drawing.Point(6, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 58)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PASSENGER(S)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.ImageKey = "calendar-512.png"
        Me.Label4.ImageList = Me.ImageList1
        Me.Label4.Location = New System.Drawing.Point(6, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 58)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "RETURN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(792, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(566, 414)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Database"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIdDataGridViewTextBoxColumn, Me.FromDataGridViewTextBoxColumn, Me.ToDataGridViewTextBoxColumn, Me.DerpartureDataGridViewTextBoxColumn, Me.ReturnDataGridViewTextBoxColumn, Me.PassengerAmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 379)
        Me.DataGridView1.TabIndex = 0
        '
        'OrderIdDataGridViewTextBoxColumn
        '
        Me.OrderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId"
        Me.OrderIdDataGridViewTextBoxColumn.HeaderText = "OrderId"
        Me.OrderIdDataGridViewTextBoxColumn.Name = "OrderIdDataGridViewTextBoxColumn"
        Me.OrderIdDataGridViewTextBoxColumn.Visible = False
        '
        'FromDataGridViewTextBoxColumn
        '
        Me.FromDataGridViewTextBoxColumn.DataPropertyName = "From"
        Me.FromDataGridViewTextBoxColumn.HeaderText = "From"
        Me.FromDataGridViewTextBoxColumn.Name = "FromDataGridViewTextBoxColumn"
        '
        'ToDataGridViewTextBoxColumn
        '
        Me.ToDataGridViewTextBoxColumn.DataPropertyName = "To"
        Me.ToDataGridViewTextBoxColumn.HeaderText = "To"
        Me.ToDataGridViewTextBoxColumn.Name = "ToDataGridViewTextBoxColumn"
        '
        'DerpartureDataGridViewTextBoxColumn
        '
        Me.DerpartureDataGridViewTextBoxColumn.DataPropertyName = "Derparture"
        Me.DerpartureDataGridViewTextBoxColumn.HeaderText = "Derparture"
        Me.DerpartureDataGridViewTextBoxColumn.Name = "DerpartureDataGridViewTextBoxColumn"
        '
        'ReturnDataGridViewTextBoxColumn
        '
        Me.ReturnDataGridViewTextBoxColumn.DataPropertyName = "Return"
        Me.ReturnDataGridViewTextBoxColumn.HeaderText = "Return"
        Me.ReturnDataGridViewTextBoxColumn.Name = "ReturnDataGridViewTextBoxColumn"
        '
        'PassengerAmountDataGridViewTextBoxColumn
        '
        Me.PassengerAmountDataGridViewTextBoxColumn.DataPropertyName = "PassengerAmount"
        Me.PassengerAmountDataGridViewTextBoxColumn.HeaderText = "PassengerAmount"
        Me.PassengerAmountDataGridViewTextBoxColumn.Name = "PassengerAmountDataGridViewTextBoxColumn"
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.FlightTicketsDataSet
        '
        'FlightTicketsDataSet
        '
        Me.FlightTicketsDataSet.DataSetName = "FlightTicketsDataSet"
        Me.FlightTicketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AddDestination)
        Me.GroupBox3.Controls.Add(Me.DestinationTree)
        Me.GroupBox3.Location = New System.Drawing.Point(601, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 411)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Destinations"
        '
        'AddDestination
        '
        Me.AddDestination.Location = New System.Drawing.Point(6, 366)
        Me.AddDestination.Name = "AddDestination"
        Me.AddDestination.Size = New System.Drawing.Size(150, 31)
        Me.AddDestination.TabIndex = 1
        Me.AddDestination.Text = "Add Destination"
        Me.AddDestination.UseVisualStyleBackColor = True
        '
        'DestinationTree
        '
        Me.DestinationTree.Location = New System.Drawing.Point(6, 22)
        Me.DestinationTree.Name = "DestinationTree"
        TreeNode22.Name = "Node27"
        TreeNode22.Text = "England"
        TreeNode23.Name = "Node1"
        TreeNode23.Text = "Aceh"
        TreeNode24.Name = "Node4"
        TreeNode24.Text = "Bali"
        TreeNode25.Name = "Node5"
        TreeNode25.Text = "Bandung"
        TreeNode26.Name = "Node6"
        TreeNode26.Text = "Lampung"
        TreeNode27.Name = "Node7"
        TreeNode27.Text = "Manado"
        TreeNode28.Name = "Node9"
        TreeNode28.Text = "Medan"
        TreeNode29.Name = "Node8"
        TreeNode29.Text = "Jakarta"
        TreeNode30.Name = "Node12"
        TreeNode30.Text = "Padang"
        TreeNode31.Name = "Node16"
        TreeNode31.Text = "Palembang"
        TreeNode32.Name = "Node17"
        TreeNode32.Text = "Papua"
        TreeNode33.Name = "Node18"
        TreeNode33.Text = "Pekanbaru"
        TreeNode34.Name = "Node11"
        TreeNode34.Text = "Semarang"
        TreeNode35.Name = "Node10"
        TreeNode35.Text = "Surabaya"
        TreeNode36.Name = "Node0"
        TreeNode36.Text = "Indonesia"
        TreeNode37.Name = "Node20"
        TreeNode37.Text = "Singapura"
        TreeNode38.Name = "Node26"
        TreeNode38.Text = "Chicago"
        TreeNode39.Name = "Node23"
        TreeNode39.Text = "Los Angeles"
        TreeNode40.Name = "Node24"
        TreeNode40.Text = "Miami"
        TreeNode41.Name = "Node22"
        TreeNode41.Text = "New York"
        TreeNode42.Name = "Node21"
        TreeNode42.Text = "USA"
        Me.DestinationTree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode36, TreeNode37, TreeNode42})
        Me.DestinationTree.Size = New System.Drawing.Size(150, 338)
        Me.DestinationTree.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageKey = "Logout-512.png"
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(1522, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'Editing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 441)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Editing"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightTicketsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DTP_Return As DateTimePicker
    Friend WithEvents DTP_Derparture As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DestinationTree As TreeView
    Friend WithEvents AddDestination As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FlightTicketsDataSet As FlightTicketsDataSet
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As FlightTicketsDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents OrderIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DerpartureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassengerAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
