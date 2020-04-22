<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Validation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarValidation = New System.Windows.Forms.ProgressBar()
        Me.TimerValidation = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SENDING DATA......"
        '
        'BarValidation
        '
        Me.BarValidation.Location = New System.Drawing.Point(12, 45)
        Me.BarValidation.Name = "BarValidation"
        Me.BarValidation.Size = New System.Drawing.Size(516, 23)
        Me.BarValidation.TabIndex = 1
        '
        'TimerValidation
        '
        Me.TimerValidation.Interval = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 2
        '
        'ProgressValue
        '
        Me.ProgressValue.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressValue.Location = New System.Drawing.Point(427, 9)
        Me.ProgressValue.Name = "ProgressValue"
        Me.ProgressValue.Size = New System.Drawing.Size(101, 24)
        Me.ProgressValue.TabIndex = 3
        Me.ProgressValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Validation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 78)
        Me.Controls.Add(Me.ProgressValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BarValidation)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Validation"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BarValidation As ProgressBar
    Friend WithEvents TimerValidation As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressValue As Label
End Class
