<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Match1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Match1))
        Me.progBarJobber = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.progBarFinisherOpponent = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.progBarPlayerFinisher = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.progBarPlayerHealth = New System.Windows.Forms.ProgressBar()
        Me.btnPunch = New System.Windows.Forms.Button()
        Me.btnSuplex = New System.Windows.Forms.Button()
        Me.btnPin = New System.Windows.Forms.Button()
        Me.btnFinisher = New System.Windows.Forms.Button()
        Me.lstDetails = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progBarJobber
        '
        Me.progBarJobber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.progBarJobber.Location = New System.Drawing.Point(321, 152)
        Me.progBarJobber.Name = "progBarJobber"
        Me.progBarJobber.Size = New System.Drawing.Size(610, 42)
        Me.progBarJobber.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.progBarFinisherOpponent)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.progBarJobber)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(938, 286)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'progBarFinisherOpponent
        '
        Me.progBarFinisherOpponent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.progBarFinisherOpponent.Location = New System.Drawing.Point(321, 223)
        Me.progBarFinisherOpponent.Name = "progBarFinisherOpponent"
        Me.progBarFinisherOpponent.Size = New System.Drawing.Size(610, 42)
        Me.progBarFinisherOpponent.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Finisher"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(423, 64)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = """I am going to flip you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "like an omellete!"""
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Patrick Celedio"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Health"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.lstName)
        Me.GroupBox2.Controls.Add(Me.progBarPlayerFinisher)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.progBarPlayerHealth)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 456)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(938, 286)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'progBarPlayerFinisher
        '
        Me.progBarPlayerFinisher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.progBarPlayerFinisher.Location = New System.Drawing.Point(321, 207)
        Me.progBarPlayerFinisher.Name = "progBarPlayerFinisher"
        Me.progBarPlayerFinisher.Size = New System.Drawing.Size(610, 42)
        Me.progBarPlayerFinisher.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(138, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 32)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Finisher"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(661, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = """Who is this!?"""
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(138, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 36)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Health"
        '
        'progBarPlayerHealth
        '
        Me.progBarPlayerHealth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.progBarPlayerHealth.Location = New System.Drawing.Point(321, 152)
        Me.progBarPlayerHealth.Name = "progBarPlayerHealth"
        Me.progBarPlayerHealth.Size = New System.Drawing.Size(610, 42)
        Me.progBarPlayerHealth.TabIndex = 1
        '
        'btnPunch
        '
        Me.btnPunch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPunch.Location = New System.Drawing.Point(14, 456)
        Me.btnPunch.Name = "btnPunch"
        Me.btnPunch.Size = New System.Drawing.Size(139, 121)
        Me.btnPunch.TabIndex = 5
        Me.btnPunch.Text = "Punch"
        Me.btnPunch.UseVisualStyleBackColor = True
        '
        'btnSuplex
        '
        Me.btnSuplex.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSuplex.Location = New System.Drawing.Point(189, 456)
        Me.btnSuplex.Name = "btnSuplex"
        Me.btnSuplex.Size = New System.Drawing.Size(139, 121)
        Me.btnSuplex.TabIndex = 6
        Me.btnSuplex.Text = "Suplex"
        Me.btnSuplex.UseVisualStyleBackColor = True
        '
        'btnPin
        '
        Me.btnPin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPin.Location = New System.Drawing.Point(14, 620)
        Me.btnPin.Name = "btnPin"
        Me.btnPin.Size = New System.Drawing.Size(139, 121)
        Me.btnPin.TabIndex = 7
        Me.btnPin.Text = "Pin"
        Me.btnPin.UseVisualStyleBackColor = True
        '
        'btnFinisher
        '
        Me.btnFinisher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFinisher.Location = New System.Drawing.Point(189, 620)
        Me.btnFinisher.Name = "btnFinisher"
        Me.btnFinisher.Size = New System.Drawing.Size(139, 121)
        Me.btnFinisher.TabIndex = 8
        Me.btnFinisher.Text = "Finisher"
        Me.btnFinisher.UseVisualStyleBackColor = True
        '
        'lstDetails
        '
        Me.lstDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstDetails.Font = New System.Drawing.Font("Cambria Math", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.ItemHeight = 89
        Me.lstDetails.Location = New System.Drawing.Point(14, 307)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(930, 93)
        Me.lstDetails.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(967, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 397)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lstName
        '
        Me.lstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstName.BackColor = System.Drawing.SystemColors.Control
        Me.lstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstName.Font = New System.Drawing.Font("Courier New", 27.75!)
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 39
        Me.lstName.Location = New System.Drawing.Point(17, 28)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(638, 78)
        Me.lstName.TabIndex = 10
        '
        'Match1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 755)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstDetails)
        Me.Controls.Add(Me.btnFinisher)
        Me.Controls.Add(Me.btnPin)
        Me.Controls.Add(Me.btnSuplex)
        Me.Controls.Add(Me.btnPunch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Match1"
        Me.Text = "Wrestling Simulator 2016"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents progBarJobber As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents progBarPlayerHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents btnPunch As System.Windows.Forms.Button
    Friend WithEvents btnSuplex As System.Windows.Forms.Button
    Friend WithEvents btnPin As System.Windows.Forms.Button
    Friend WithEvents btnFinisher As System.Windows.Forms.Button
    Friend WithEvents lstDetails As System.Windows.Forms.ListBox
    Friend WithEvents progBarFinisherOpponent As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents progBarPlayerFinisher As System.Windows.Forms.ProgressBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstName As System.Windows.Forms.ListBox
End Class
