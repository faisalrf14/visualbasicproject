<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewData))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP_Return = New System.Windows.Forms.DateTimePicker()
        Me.ReturnChecked = New System.Windows.Forms.CheckBox()
        Me.DTP_Departure = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CB_To = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_From = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReturnLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Passenger = New System.Windows.Forms.Button()
        Me.Age = New System.Windows.Forms.MaskedTextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Passenger = New System.Windows.Forms.MaskedTextBox()
        Me.MoreThanOne = New System.Windows.Forms.RadioButton()
        Me.OnePerson = New System.Windows.Forms.RadioButton()
        Me.PassengersList = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.DTP_Return)
        Me.GroupBox1.Controls.Add(Me.ReturnChecked)
        Me.GroupBox1.Controls.Add(Me.DTP_Departure)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CB_To)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CB_From)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ReturnLabel)
        Me.GroupBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(18, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 323)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Data"
        '
        'DTP_Return
        '
        Me.DTP_Return.Font = New System.Drawing.Font("Tempus Sans ITC", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Return.Location = New System.Drawing.Point(245, 255)
        Me.DTP_Return.Name = "DTP_Return"
        Me.DTP_Return.Size = New System.Drawing.Size(323, 32)
        Me.DTP_Return.TabIndex = 11
        Me.DTP_Return.Visible = False
        '
        'ReturnChecked
        '
        Me.ReturnChecked.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnChecked.ForeColor = System.Drawing.Color.Black
        Me.ReturnChecked.Location = New System.Drawing.Point(584, 182)
        Me.ReturnChecked.Name = "ReturnChecked"
        Me.ReturnChecked.Size = New System.Drawing.Size(115, 32)
        Me.ReturnChecked.TabIndex = 9
        Me.ReturnChecked.Text = "Return Trip?"
        Me.ReturnChecked.UseVisualStyleBackColor = True
        '
        'DTP_Departure
        '
        Me.DTP_Departure.Font = New System.Drawing.Font("Tempus Sans ITC", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Departure.Location = New System.Drawing.Point(245, 182)
        Me.DTP_Departure.Name = "DTP_Departure"
        Me.DTP_Departure.Size = New System.Drawing.Size(323, 32)
        Me.DTP_Departure.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImageKey = "calendar-512.png"
        Me.Label3.ImageList = Me.ImageList1
        Me.Label3.Location = New System.Drawing.Point(15, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 58)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "DEPARTURE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "img_568656.png")
        Me.ImageList1.Images.SetKeyName(1, "img_537596.png")
        Me.ImageList1.Images.SetKeyName(2, "calendar-512.png")
        Me.ImageList1.Images.SetKeyName(3, "airplane-landing.png")
        Me.ImageList1.Images.SetKeyName(4, "passenger_721985.png")
        Me.ImageList1.Images.SetKeyName(5, "submit-document.png")
        '
        'CB_To
        '
        Me.CB_To.Font = New System.Drawing.Font("Tempus Sans ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_To.FormattingEnabled = True
        Me.CB_To.Items.AddRange(New Object() {"Aceh", "Bali", "Lampung", "Manado", "Medan", "Jakarta", "Jawa Barat", "Jawa Tengah", "Jawa Timur", "Padang", "Palembang", "Papua", "Pekanbaru"})
        Me.CB_To.Location = New System.Drawing.Point(245, 111)
        Me.CB_To.Name = "CB_To"
        Me.CB_To.Size = New System.Drawing.Size(323, 32)
        Me.CB_To.TabIndex = 4
        Me.CB_To.Text = "SELECT"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.ImageKey = "airplane-landing.png"
        Me.Label2.ImageList = Me.ImageList1
        Me.Label2.Location = New System.Drawing.Point(15, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 58)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CB_From
        '
        Me.CB_From.Font = New System.Drawing.Font("Tempus Sans ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_From.FormattingEnabled = True
        Me.CB_From.Items.AddRange(New Object() {"Aceh", "Bali", "Lampung", "Manado", "Medan", "Jakarta", "Jawa Barat", "Jawa Tengah", "Jawa Timur", "Padang", "Palembang", "Papua", "Pekanbaru"})
        Me.CB_From.Location = New System.Drawing.Point(245, 42)
        Me.CB_From.Name = "CB_From"
        Me.CB_From.Size = New System.Drawing.Size(323, 32)
        Me.CB_From.TabIndex = 2
        Me.CB_From.Text = "SELECT"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.ImageKey = "img_537596.png"
        Me.Label1.ImageList = Me.ImageList1
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FROM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReturnLabel
        '
        Me.ReturnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnLabel.ForeColor = System.Drawing.Color.Black
        Me.ReturnLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReturnLabel.ImageKey = "calendar-512.png"
        Me.ReturnLabel.ImageList = Me.ImageList1
        Me.ReturnLabel.Location = New System.Drawing.Point(15, 243)
        Me.ReturnLabel.Name = "ReturnLabel"
        Me.ReturnLabel.Size = New System.Drawing.Size(252, 58)
        Me.ReturnLabel.TabIndex = 10
        Me.ReturnLabel.Text = "RETURN"
        Me.ReturnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ReturnLabel.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.ImageKey = "passenger_721985.png"
        Me.Label4.ImageList = Me.ImageList1
        Me.Label4.Location = New System.Drawing.Point(20, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 42)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PASSENGER(S)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 26)
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'Add_Passenger
        '
        Me.Add_Passenger.Enabled = False
        Me.Add_Passenger.Location = New System.Drawing.Point(613, 66)
        Me.Add_Passenger.Name = "Add_Passenger"
        Me.Add_Passenger.Size = New System.Drawing.Size(67, 78)
        Me.Add_Passenger.TabIndex = 13
        Me.Add_Passenger.Text = "Add"
        Me.Add_Passenger.UseVisualStyleBackColor = True
        '
        'Age
        '
        Me.Age.Enabled = False
        Me.Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age.Location = New System.Drawing.Point(110, 111)
        Me.Age.Mask = "00"
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(497, 30)
        Me.Age.TabIndex = 16
        '
        'Submit
        '
        Me.Submit.ImageIndex = 5
        Me.Submit.ImageList = Me.ImageList1
        Me.Submit.Location = New System.Drawing.Point(613, 261)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(67, 62)
        Me.Submit.TabIndex = 17
        Me.Submit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Add_Passenger)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Age)
        Me.GroupBox2.Controls.Add(Me.Reset)
        Me.GroupBox2.Controls.Add(Me.Passenger)
        Me.GroupBox2.Controls.Add(Me.MoreThanOne)
        Me.GroupBox2.Controls.Add(Me.OnePerson)
        Me.GroupBox2.Controls.Add(Me.Submit)
        Me.GroupBox2.Controls.Add(Me.PassengersList)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 326)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Passengers"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.ImageKey = "(none)"
        Me.Label6.Location = New System.Drawing.Point(6, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 31)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "AGE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.ImageKey = "(none)"
        Me.Label5.Location = New System.Drawing.Point(6, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 31)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "NAME"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(613, 165)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(67, 78)
        Me.Reset.TabIndex = 19
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Passenger
        '
        Me.Passenger.Enabled = False
        Me.Passenger.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passenger.Location = New System.Drawing.Point(110, 66)
        Me.Passenger.Mask = "??????????????????????????????"
        Me.Passenger.Name = "Passenger"
        Me.Passenger.Size = New System.Drawing.Size(497, 30)
        Me.Passenger.TabIndex = 21
        '
        'MoreThanOne
        '
        Me.MoreThanOne.AutoSize = True
        Me.MoreThanOne.Location = New System.Drawing.Point(406, 31)
        Me.MoreThanOne.Name = "MoreThanOne"
        Me.MoreThanOne.Size = New System.Drawing.Size(82, 17)
        Me.MoreThanOne.TabIndex = 20
        Me.MoreThanOne.TabStop = True
        Me.MoreThanOne.Text = "More than 1"
        Me.MoreThanOne.UseVisualStyleBackColor = True
        '
        'OnePerson
        '
        Me.OnePerson.AutoSize = True
        Me.OnePerson.Location = New System.Drawing.Point(313, 31)
        Me.OnePerson.Name = "OnePerson"
        Me.OnePerson.Size = New System.Drawing.Size(67, 17)
        Me.OnePerson.TabIndex = 19
        Me.OnePerson.TabStop = True
        Me.OnePerson.Text = "1 Person"
        Me.OnePerson.UseVisualStyleBackColor = True
        '
        'PassengersList
        '
        Me.PassengersList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengersList.FormattingEnabled = True
        Me.PassengersList.ItemHeight = 24
        Me.PassengersList.Location = New System.Drawing.Point(6, 151)
        Me.PassengersList.Name = "PassengersList"
        Me.PassengersList.Size = New System.Drawing.Size(601, 172)
        Me.PassengersList.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(758, 396)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Plum
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(750, 370)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Goldenrod
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(750, 370)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'NewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(781, 418)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "NewData"
        Me.Text = "Inserting New Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents CB_From As ComboBox
    Friend WithEvents DTP_Departure As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_To As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DTP_Return As DateTimePicker
    Friend WithEvents ReturnLabel As Label
    Friend WithEvents ReturnChecked As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Add_Passenger As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Age As MaskedTextBox
    Friend WithEvents Submit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MoreThanOne As RadioButton
    Friend WithEvents OnePerson As RadioButton
    Friend WithEvents PassengersList As ListBox
    Friend WithEvents Passenger As MaskedTextBox
    Friend WithEvents Reset As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
