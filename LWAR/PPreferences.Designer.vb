<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPreferences
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkBoxRememberStartContents = New System.Windows.Forms.CheckBox()
        Me.chkBoxHideIconWhenShowLWAR = New System.Windows.Forms.CheckBox()
        Me.chkBoxIconShowOnStartup = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAutoAssignUserName = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 439)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 29)
        Me.Button3.TabIndex = 74
        Me.Button3.Text = "&Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(237, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 29)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "&Apply"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 29)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "&Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tweak LWAR to your needs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Preferences"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LWAR.My.Resources.Resources._1400410566_application_pgp_signature
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'chkBoxRememberStartContents
        '
        Me.chkBoxRememberStartContents.AutoSize = True
        Me.chkBoxRememberStartContents.Location = New System.Drawing.Point(6, 65)
        Me.chkBoxRememberStartContents.Name = "chkBoxRememberStartContents"
        Me.chkBoxRememberStartContents.Size = New System.Drawing.Size(143, 17)
        Me.chkBoxRememberStartContents.TabIndex = 2
        Me.chkBoxRememberStartContents.Text = "Remember Starting fields"
        Me.chkBoxRememberStartContents.UseVisualStyleBackColor = True
        '
        'chkBoxHideIconWhenShowLWAR
        '
        Me.chkBoxHideIconWhenShowLWAR.AutoSize = True
        Me.chkBoxHideIconWhenShowLWAR.Location = New System.Drawing.Point(6, 42)
        Me.chkBoxHideIconWhenShowLWAR.Name = "chkBoxHideIconWhenShowLWAR"
        Me.chkBoxHideIconWhenShowLWAR.Size = New System.Drawing.Size(177, 17)
        Me.chkBoxHideIconWhenShowLWAR.TabIndex = 1
        Me.chkBoxHideIconWhenShowLWAR.Text = "Hide icon when showing LWAR"
        Me.chkBoxHideIconWhenShowLWAR.UseVisualStyleBackColor = True
        '
        'chkBoxIconShowOnStartup
        '
        Me.chkBoxIconShowOnStartup.AutoSize = True
        Me.chkBoxIconShowOnStartup.Location = New System.Drawing.Point(6, 19)
        Me.chkBoxIconShowOnStartup.Name = "chkBoxIconShowOnStartup"
        Me.chkBoxIconShowOnStartup.Size = New System.Drawing.Size(167, 17)
        Me.chkBoxIconShowOnStartup.TabIndex = 0
        Me.chkBoxIconShowOnStartup.Text = "Show icon on program startup"
        Me.chkBoxIconShowOnStartup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAutoAssignUserName)
        Me.GroupBox1.Controls.Add(Me.chkBoxRememberStartContents)
        Me.GroupBox1.Controls.Add(Me.chkBoxHideIconWhenShowLWAR)
        Me.GroupBox1.Controls.Add(Me.chkBoxIconShowOnStartup)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 327)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preferences"
        '
        'chkAutoAssignUserName
        '
        Me.chkAutoAssignUserName.AutoSize = True
        Me.chkAutoAssignUserName.Location = New System.Drawing.Point(6, 88)
        Me.chkAutoAssignUserName.Name = "chkAutoAssignUserName"
        Me.chkAutoAssignUserName.Size = New System.Drawing.Size(270, 17)
        Me.chkAutoAssignUserName.TabIndex = 3
        Me.chkAutoAssignUserName.Text = "Automatically fill the username field with current user"
        Me.chkAutoAssignUserName.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 100)
        Me.Panel1.TabIndex = 71
        '
        'PPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 480)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PPreferences"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkBoxRememberStartContents As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxHideIconWhenShowLWAR As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxIconShowOnStartup As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkAutoAssignUserName As System.Windows.Forms.CheckBox
End Class
