<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferences
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preferences))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblSubtext = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.chkRememberStartContents = New System.Windows.Forms.CheckBox()
        Me.chkIconHideOnShowLWAR = New System.Windows.Forms.CheckBox()
        Me.chkIconShowOnStartup = New System.Windows.Forms.CheckBox()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.chkLogging = New System.Windows.Forms.CheckBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.chkBetaUpdateChannel = New System.Windows.Forms.CheckBox()
        Me.chkAutoAssignUsername = New System.Windows.Forms.CheckBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(237, 302)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 29)
        Me.btnSave.TabIndex = 73
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(349, 302)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(106, 29)
        Me.btnCancel.TabIndex = 70
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblSubtext
        '
        Me.lblSubtext.AutoSize = True
        Me.lblSubtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtext.Location = New System.Drawing.Point(124, 38)
        Me.lblSubtext.Name = "lblSubtext"
        Me.lblSubtext.Size = New System.Drawing.Size(193, 18)
        Me.lblSubtext.TabIndex = 2
        Me.lblSubtext.Text = "Tweak LWAR to your needs"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(124, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(144, 29)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Preferences"
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.LWAR.My.Resources.Resources._1400410566_application_pgp_signature
        Me.imgLogo.Location = New System.Drawing.Point(3, 3)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(115, 94)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'chkRememberStartContents
        '
        Me.chkRememberStartContents.AutoSize = True
        Me.chkRememberStartContents.Location = New System.Drawing.Point(6, 65)
        Me.chkRememberStartContents.Name = "chkRememberStartContents"
        Me.chkRememberStartContents.Size = New System.Drawing.Size(143, 17)
        Me.chkRememberStartContents.TabIndex = 2
        Me.chkRememberStartContents.Text = "Remember Starting fields"
        Me.chkRememberStartContents.UseVisualStyleBackColor = True
        '
        'chkIconHideOnShowLWAR
        '
        Me.chkIconHideOnShowLWAR.AutoSize = True
        Me.chkIconHideOnShowLWAR.Location = New System.Drawing.Point(6, 42)
        Me.chkIconHideOnShowLWAR.Name = "chkIconHideOnShowLWAR"
        Me.chkIconHideOnShowLWAR.Size = New System.Drawing.Size(177, 17)
        Me.chkIconHideOnShowLWAR.TabIndex = 1
        Me.chkIconHideOnShowLWAR.Text = "Hide icon when showing LWAR"
        Me.chkIconHideOnShowLWAR.UseVisualStyleBackColor = True
        '
        'chkIconShowOnStartup
        '
        Me.chkIconShowOnStartup.AutoSize = True
        Me.chkIconShowOnStartup.Location = New System.Drawing.Point(6, 19)
        Me.chkIconShowOnStartup.Name = "chkIconShowOnStartup"
        Me.chkIconShowOnStartup.Size = New System.Drawing.Size(167, 17)
        Me.chkIconShowOnStartup.TabIndex = 0
        Me.chkIconShowOnStartup.Text = "Show icon on program startup"
        Me.chkIconShowOnStartup.UseVisualStyleBackColor = True
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.chkLogging)
        Me.grpMain.Controls.Add(Me.chkShowPassword)
        Me.grpMain.Controls.Add(Me.chkBetaUpdateChannel)
        Me.grpMain.Controls.Add(Me.chkAutoAssignUsername)
        Me.grpMain.Controls.Add(Me.chkRememberStartContents)
        Me.grpMain.Controls.Add(Me.chkIconHideOnShowLWAR)
        Me.grpMain.Controls.Add(Me.chkIconShowOnStartup)
        Me.grpMain.Location = New System.Drawing.Point(12, 106)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(443, 190)
        Me.grpMain.TabIndex = 72
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "Preferences"
        '
        'chkLogging
        '
        Me.chkLogging.AutoSize = True
        Me.chkLogging.Location = New System.Drawing.Point(6, 157)
        Me.chkLogging.Name = "chkLogging"
        Me.chkLogging.Size = New System.Drawing.Size(144, 17)
        Me.chkLogging.TabIndex = 6
        Me.chkLogging.Text = "Enable logging to text file"
        Me.chkLogging.UseVisualStyleBackColor = True
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(6, 134)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPassword.TabIndex = 5
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'chkBetaUpdateChannel
        '
        Me.chkBetaUpdateChannel.AutoSize = True
        Me.chkBetaUpdateChannel.Location = New System.Drawing.Point(6, 111)
        Me.chkBetaUpdateChannel.Name = "chkBetaUpdateChannel"
        Me.chkBetaUpdateChannel.Size = New System.Drawing.Size(146, 17)
        Me.chkBetaUpdateChannel.TabIndex = 4
        Me.chkBetaUpdateChannel.Text = "Join beta update channel"
        Me.chkBetaUpdateChannel.UseVisualStyleBackColor = True
        '
        'chkAutoAssignUsername
        '
        Me.chkAutoAssignUsername.AutoSize = True
        Me.chkAutoAssignUsername.Location = New System.Drawing.Point(6, 88)
        Me.chkAutoAssignUsername.Name = "chkAutoAssignUsername"
        Me.chkAutoAssignUsername.Size = New System.Drawing.Size(270, 17)
        Me.chkAutoAssignUsername.TabIndex = 3
        Me.chkAutoAssignUsername.Text = "Automatically fill the username field with current user"
        Me.chkAutoAssignUsername.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.White
        Me.pnlTop.Controls.Add(Me.lblSubtext)
        Me.pnlTop.Controls.Add(Me.lblHeader)
        Me.pnlTop.Controls.Add(Me.imgLogo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(467, 100)
        Me.pnlTop.TabIndex = 71
        '
        'Preferences
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(467, 343)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preferences"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblSubtext As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents chkRememberStartContents As System.Windows.Forms.CheckBox
    Friend WithEvents chkIconHideOnShowLWAR As System.Windows.Forms.CheckBox
    Friend WithEvents chkIconShowOnStartup As System.Windows.Forms.CheckBox
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents chkAutoAssignUsername As System.Windows.Forms.CheckBox
    Friend WithEvents chkBetaUpdateChannel As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents chkLogging As System.Windows.Forms.CheckBox
End Class
