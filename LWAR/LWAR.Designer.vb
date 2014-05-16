<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LWAR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LWAR))
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitLWARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SourcecodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutLWARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblCurrentPage = New System.Windows.Forms.Label()
        Me.GroupBoxStart = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.txtDomain = New System.Windows.Forms.TextBox()
        Me.lblDomain = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotificationContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotificationContextShowHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextPreferences = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparatorNotify1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificationContextQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialogBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.MainMenuStrip.SuspendLayout()
        Me.GroupBoxStart.SuspendLayout()
        Me.NotificationContext.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(554, 24)
        Me.MainMenuStrip.TabIndex = 0
        Me.MainMenuStrip.Text = "MainMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitLWARToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'QuitLWARToolStripMenuItem
        '
        Me.QuitLWARToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources.Exit2
        Me.QuitLWARToolStripMenuItem.Name = "QuitLWARToolStripMenuItem"
        Me.QuitLWARToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.QuitLWARToolStripMenuItem.Text = "&Quit LWAR"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources.Options
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PreferencesToolStripMenuItem.Text = "&Preferences"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem, Me.ToolStripSeparator2, Me.ProjectsiteToolStripMenuItem, Me.SourcecodeToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckForUpdatesToolStripMenuItem, Me.AboutLWARToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources.Help
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DocumentationToolStripMenuItem.Text = "&Documentation"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(176, 6)
        '
        'ProjectsiteToolStripMenuItem
        '
        Me.ProjectsiteToolStripMenuItem.Name = "ProjectsiteToolStripMenuItem"
        Me.ProjectsiteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ProjectsiteToolStripMenuItem.Text = "Project &site"
        '
        'SourcecodeToolStripMenuItem
        '
        Me.SourcecodeToolStripMenuItem.Name = "SourcecodeToolStripMenuItem"
        Me.SourcecodeToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SourcecodeToolStripMenuItem.Text = "Source &code"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(176, 6)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources.external_link
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "&Check for updates"
        '
        'AboutLWARToolStripMenuItem
        '
        Me.AboutLWARToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources.Info
        Me.AboutLWARToolStripMenuItem.Name = "AboutLWARToolStripMenuItem"
        Me.AboutLWARToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AboutLWARToolStripMenuItem.Text = "&About LWAR"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(107, 27)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(163, 55)
        Me.lblProduct.TabIndex = 2
        Me.lblProduct.Text = "LWAR"
        '
        'lblCurrentPage
        '
        Me.lblCurrentPage.AutoSize = True
        Me.lblCurrentPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPage.Location = New System.Drawing.Point(112, 87)
        Me.lblCurrentPage.Name = "lblCurrentPage"
        Me.lblCurrentPage.Size = New System.Drawing.Size(62, 29)
        Me.lblCurrentPage.TabIndex = 3
        Me.lblCurrentPage.Text = "Start"
        '
        'GroupBoxStart
        '
        Me.GroupBoxStart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxStart.Controls.Add(Me.btnBrowse)
        Me.GroupBoxStart.Controls.Add(Me.txtFile)
        Me.GroupBoxStart.Controls.Add(Me.lblFile)
        Me.GroupBoxStart.Controls.Add(Me.txtDomain)
        Me.GroupBoxStart.Controls.Add(Me.lblDomain)
        Me.GroupBoxStart.Controls.Add(Me.txtPassword)
        Me.GroupBoxStart.Controls.Add(Me.lblPassword)
        Me.GroupBoxStart.Controls.Add(Me.txtUsername)
        Me.GroupBoxStart.Controls.Add(Me.lblUsername)
        Me.GroupBoxStart.Location = New System.Drawing.Point(47, 131)
        Me.GroupBoxStart.Name = "GroupBoxStart"
        Me.GroupBoxStart.Size = New System.Drawing.Size(457, 187)
        Me.GroupBoxStart.TabIndex = 7
        Me.GroupBoxStart.TabStop = False
        Me.GroupBoxStart.Text = "Start"
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(376, 134)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 11
        Me.btnBrowse.Text = "&Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFile.Location = New System.Drawing.Point(86, 136)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(284, 33)
        Me.txtFile.TabIndex = 7
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(6, 137)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(75, 16)
        Me.lblFile.TabIndex = 6
        Me.lblFile.Text = "&File to start:"
        '
        'txtDomain
        '
        Me.txtDomain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDomain.Location = New System.Drawing.Point(131, 110)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(320, 20)
        Me.txtDomain.TabIndex = 5
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomain.Location = New System.Drawing.Point(6, 111)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(119, 16)
        Me.lblDomain.TabIndex = 4
        Me.lblDomain.Text = "&Domain (Optional):"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(86, 84)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(365, 20)
        Me.txtPassword.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(6, 85)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(71, 16)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "&Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.Location = New System.Drawing.Point(86, 58)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(365, 20)
        Me.txtUsername.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(6, 59)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(74, 16)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "&Username:"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon.BalloonTipText = "LWAR"
        Me.NotifyIcon.BalloonTipTitle = "LWAR"
        Me.NotifyIcon.ContextMenuStrip = Me.NotificationContext
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "LWAR"
        '
        'NotificationContext
        '
        Me.NotificationContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotificationContextShowHide, Me.NotificationContextPreferences, Me.ToolStripSeparatorNotify1, Me.NotificationContextQuit})
        Me.NotificationContext.Name = "NotificationContextMenuStrip"
        Me.NotificationContext.Size = New System.Drawing.Size(177, 98)
        '
        'NotificationContextShowHide
        '
        Me.NotificationContextShowHide.Image = Global.LWAR.My.Resources.Resources.eye_hidden
        Me.NotificationContextShowHide.Name = "NotificationContextShowHide"
        Me.NotificationContextShowHide.Size = New System.Drawing.Size(176, 22)
        Me.NotificationContextShowHide.Text = "Hide LWAR"
        '
        'NotificationContextPreferences
        '
        Me.NotificationContextPreferences.Image = Global.LWAR.My.Resources.Resources.Options
        Me.NotificationContextPreferences.Name = "NotificationContextPreferences"
        Me.NotificationContextPreferences.Size = New System.Drawing.Size(176, 22)
        Me.NotificationContextPreferences.Text = "Open Preferences"
        '
        'ToolStripSeparatorNotify1
        '
        Me.ToolStripSeparatorNotify1.Name = "ToolStripSeparatorNotify1"
        Me.ToolStripSeparatorNotify1.Size = New System.Drawing.Size(173, 6)
        '
        'NotificationContextQuit
        '
        Me.NotificationContextQuit.Image = Global.LWAR.My.Resources.Resources.Exit2
        Me.NotificationContextQuit.Name = "NotificationContextQuit"
        Me.NotificationContextQuit.Size = New System.Drawing.Size(176, 22)
        Me.NotificationContextQuit.Text = "Quit LWAR"
        '
        'OpenFileDialogBrowse
        '
        Me.OpenFileDialogBrowse.DefaultExt = "exe"
        Me.OpenFileDialogBrowse.Filter = "Executable files (*.exe, *.bat, *.com, *.vbs, *.mmc, *.js, *.cpl)|*.exe; *.bat; *" & _
    ".com; *.vbs; *.mmc; *.js; *.cpl|All files|*.*"
        Me.OpenFileDialogBrowse.InitialDirectory = "%systemroot%\system32"
        Me.OpenFileDialogBrowse.ReadOnlyChecked = True
        Me.OpenFileDialogBrowse.RestoreDirectory = True
        Me.OpenFileDialogBrowse.ShowHelp = True
        Me.OpenFileDialogBrowse.SupportMultiDottedExtensions = True
        Me.OpenFileDialogBrowse.Title = "Select a file to start"
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Image = Global.LWAR.My.Resources.Resources.go_right_d
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.Location = New System.Drawing.Point(386, 336)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.LWAR.My.Resources.Resources.Exit2
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCancel.Location = New System.Drawing.Point(467, 336)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "    &Quit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHide.Image = Global.LWAR.My.Resources.Resources.eye_hidden
        Me.btnHide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHide.Location = New System.Drawing.Point(12, 336)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 8
        Me.btnHide.Text = "&Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'imgLogo
        '
        Me.imgLogo.BackgroundImage = Global.LWAR.My.Resources.Resources._2014_05_14_204202
        Me.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgLogo.Location = New System.Drawing.Point(12, 27)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(89, 98)
        Me.imgLogo.TabIndex = 1
        Me.imgLogo.TabStop = False
        '
        'LWAR
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(554, 371)
        Me.Controls.Add(Me.GroupBoxStart)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblCurrentPage)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LWAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start - LWAR"
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.GroupBoxStart.ResumeLayout(False)
        Me.GroupBoxStart.PerformLayout()
        Me.NotificationContext.ResumeLayout(False)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitLWARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutLWARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProjectsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SourcecodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents lblCurrentPage As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents GroupBoxStart As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents txtDomain As System.Windows.Forms.TextBox
    Friend WithEvents lblDomain As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents OpenFileDialogBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NotificationContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NotificationContextShowHide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparatorNotify1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NotificationContextQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextPreferences As System.Windows.Forms.ToolStripMenuItem

End Class
