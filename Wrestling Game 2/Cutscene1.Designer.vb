<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cutscene1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cutscene1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstCutscene1 = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtOkay = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(413, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 390)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lstCutscene1
        '
        Me.lstCutscene1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstCutscene1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCutscene1.FormattingEnabled = True
        Me.lstCutscene1.HorizontalScrollbar = True
        Me.lstCutscene1.ItemHeight = 22
        Me.lstCutscene1.Location = New System.Drawing.Point(202, 428)
        Me.lstCutscene1.Name = "lstCutscene1"
        Me.lstCutscene1.Size = New System.Drawing.Size(760, 158)
        Me.lstCutscene1.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 601)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 41)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtOkay
        '
        Me.txtOkay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOkay.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOkay.Location = New System.Drawing.Point(968, 428)
        Me.txtOkay.Name = "txtOkay"
        Me.txtOkay.Size = New System.Drawing.Size(102, 158)
        Me.txtOkay.TabIndex = 3
        Me.txtOkay.Text = "I'm Ready!"
        Me.txtOkay.UseVisualStyleBackColor = True
        '
        'Cutscene1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 654)
        Me.Controls.Add(Me.txtOkay)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstCutscene1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Cutscene1"
        Me.ShowInTaskbar = False
        Me.Text = "Cutscene1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstCutscene1 As System.Windows.Forms.ListBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtOkay As System.Windows.Forms.Button
End Class
