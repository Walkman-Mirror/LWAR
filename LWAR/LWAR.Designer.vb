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
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblCurrentPage = New System.Windows.Forms.Label()
        Me.GroupBoxStart = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectSiteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SourceCodeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForIpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutLWARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitLWARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectsSiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SourceCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutLWARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.GroupBoxStart.SuspendLayout()
        Me.NotificationContext.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBoxStart.Controls.Add(Me.Button1)
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
        'Button1
        '
        Me.Button1.Image = Global.LWAR.My.Resources.Resources._1387135471_edit_clear
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(376, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "&Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(376, 108)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 33)
        Me.btnBrowse.TabIndex = 11
        Me.btnBrowse.Text = "&Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFile.Location = New System.Drawing.Point(86, 108)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(284, 33)
        Me.txtFile.TabIndex = 7
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(6, 109)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(75, 16)
        Me.lblFile.TabIndex = 6
        Me.lblFile.Text = "&File to start:"
        '
        'txtDomain
        '
        Me.txtDomain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDomain.Location = New System.Drawing.Point(131, 82)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(320, 20)
        Me.txtDomain.TabIndex = 5
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomain.Location = New System.Drawing.Point(6, 83)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(119, 16)
        Me.lblDomain.TabIndex = 4
        Me.lblDomain.Text = "&Domain (Optional):"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(86, 56)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(365, 20)
        Me.txtPassword.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(6, 57)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(71, 16)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "&Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.Location = New System.Drawing.Point(86, 30)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(365, 20)
        Me.txtUsername.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(6, 31)
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
        Me.NotificationContext.Size = New System.Drawing.Size(168, 76)
        '
        'NotificationContextShowHide
        '
        Me.NotificationContextShowHide.Image = Global.LWAR.My.Resources.Resources.eye_hidden
        Me.NotificationContextShowHide.Name = "NotificationContextShowHide"
        Me.NotificationContextShowHide.Size = New System.Drawing.Size(167, 22)
        Me.NotificationContextShowHide.Text = "&Hide LWAR"
        '
        'NotificationContextPreferences
        '
        Me.NotificationContextPreferences.Image = Global.LWAR.My.Resources.Resources.Options
        Me.NotificationContextPreferences.Name = "NotificationContextPreferences"
        Me.NotificationContextPreferences.Size = New System.Drawing.Size(167, 22)
        Me.NotificationContextPreferences.Text = "Open Preferences"
        '
        'ToolStripSeparatorNotify1
        '
        Me.ToolStripSeparatorNotify1.Name = "ToolStripSeparatorNotify1"
        Me.ToolStripSeparatorNotify1.Size = New System.Drawing.Size(164, 6)
        '
        'NotificationContextQuit
        '
        Me.NotificationContextQuit.Image = Global.LWAR.My.Resources.Resources.Exit2
        Me.NotificationContextQuit.Name = "NotificationContextQuit"
        Me.NotificationContextQuit.Size = New System.Drawing.Size(167, 22)
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
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources.Options
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PreferencesToolStripMenuItem.Text = "&Preferences"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DocumentationToolStripMenuItem.Text = "&Documentation"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "&Check for updates"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'ToolsToolStripMenuItem1
        '
        Me.ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
        Me.ToolsToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem1.Text = "&Tools"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'DocumentationToolStripMenuItem1
        '
        Me.DocumentationToolStripMenuItem1.Name = "DocumentationToolStripMenuItem1"
        Me.DocumentationToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.DocumentationToolStripMenuItem1.Text = "&Documentation"
        '
        'ProjectSiteToolStripMenuItem1
        '
        Me.ProjectSiteToolStripMenuItem1.Name = "ProjectSiteToolStripMenuItem1"
        Me.ProjectSiteToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ProjectSiteToolStripMenuItem1.Text = "&Project site"
        '
        'SourceCodeToolStripMenuItem1
        '
        Me.SourceCodeToolStripMenuItem1.Name = "SourceCodeToolStripMenuItem1"
        Me.SourceCodeToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.SourceCodeToolStripMenuItem1.Text = "&Source code"
        '
        'CheckForIpdatesToolStripMenuItem
        '
        Me.CheckForIpdatesToolStripMenuItem.Name = "CheckForIpdatesToolStripMenuItem"
        Me.CheckForIpdatesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CheckForIpdatesToolStripMenuItem.Text = "&Check for updates"
        '
        'AboutLWARToolStripMenuItem1
        '
        Me.AboutLWARToolStripMenuItem1.Name = "AboutLWARToolStripMenuItem1"
        Me.AboutLWARToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.AboutLWARToolStripMenuItem1.Text = "&About LWAR"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(167, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(167, 6)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem2, Me.ToolsToolStripMenuItem2, Me.HelpToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem2
        '
        Me.FileToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitLWARToolStripMenuItem})
        Me.FileToolStripMenuItem2.Name = "FileToolStripMenuItem2"
        Me.FileToolStripMenuItem2.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem2.Text = "&File"
        '
        'QuitLWARToolStripMenuItem
        '
        Me.QuitLWARToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources._1387135890_system_log_out
        Me.QuitLWARToolStripMenuItem.Name = "QuitLWARToolStripMenuItem"
        Me.QuitLWARToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.QuitLWARToolStripMenuItem.Text = "&Quit LWAR"
        Me.QuitLWARToolStripMenuItem.ToolTipText = "Closes LWAR"
        '
        'ToolsToolStripMenuItem2
        '
        Me.ToolsToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem1})
        Me.ToolsToolStripMenuItem2.Name = "ToolsToolStripMenuItem2"
        Me.ToolsToolStripMenuItem2.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem2.Text = "&Tools"
        '
        'PreferencesToolStripMenuItem1
        '
        Me.PreferencesToolStripMenuItem1.Image = Global.LWAR.My.Resources.Resources._1371856288_preferences_system
        Me.PreferencesToolStripMenuItem1.Name = "PreferencesToolStripMenuItem1"
        Me.PreferencesToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.PreferencesToolStripMenuItem1.Text = "&Preferences"
        Me.PreferencesToolStripMenuItem1.ToolTipText = "Tweak LWAR to your needs"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubmitFeedbackToolStripMenuItem, Me.DocumentationToolStripMenuItem2, Me.ToolStripSeparator5, Me.ProjectsSiteToolStripMenuItem, Me.SourceCodeToolStripMenuItem, Me.ToolStripSeparator6, Me.CheckForUpdatesToolStripMenuItem1, Me.AboutLWARToolStripMenuItem})
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem2.Text = "&Help"
        '
        'SubmitFeedbackToolStripMenuItem
        '
        Me.SubmitFeedbackToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources._1398642052_emblem_favorite
        Me.SubmitFeedbackToolStripMenuItem.Name = "SubmitFeedbackToolStripMenuItem"
        Me.SubmitFeedbackToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SubmitFeedbackToolStripMenuItem.Text = "Submit &feedback"
        Me.SubmitFeedbackToolStripMenuItem.ToolTipText = "Submit issues, feedback and requests"
        '
        'DocumentationToolStripMenuItem2
        '
        Me.DocumentationToolStripMenuItem2.Image = Global.LWAR.My.Resources.Resources._1387141003_help_browser
        Me.DocumentationToolStripMenuItem2.Name = "DocumentationToolStripMenuItem2"
        Me.DocumentationToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.DocumentationToolStripMenuItem2.Text = "&Documentation"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(167, 6)
        '
        'ProjectsSiteToolStripMenuItem
        '
        Me.ProjectsSiteToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources._1371846583_internet_web_browser
        Me.ProjectsSiteToolStripMenuItem.Name = "ProjectsSiteToolStripMenuItem"
        Me.ProjectsSiteToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ProjectsSiteToolStripMenuItem.Text = "&Projects site"
        '
        'SourceCodeToolStripMenuItem
        '
        Me.SourceCodeToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources._1398638918_document_properties
        Me.SourceCodeToolStripMenuItem.Name = "SourceCodeToolStripMenuItem"
        Me.SourceCodeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SourceCodeToolStripMenuItem.Text = "&Source code"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(167, 6)
        '
        'CheckForUpdatesToolStripMenuItem1
        '
        Me.CheckForUpdatesToolStripMenuItem1.Image = Global.LWAR.My.Resources.Resources._1371833577_view_refresh
        Me.CheckForUpdatesToolStripMenuItem1.Name = "CheckForUpdatesToolStripMenuItem1"
        Me.CheckForUpdatesToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.CheckForUpdatesToolStripMenuItem1.Text = "&Check for updates"
        '
        'AboutLWARToolStripMenuItem
        '
        Me.AboutLWARToolStripMenuItem.Image = Global.LWAR.My.Resources.Resources._1387141003_help_browser
        Me.AboutLWARToolStripMenuItem.Name = "AboutLWARToolStripMenuItem"
        Me.AboutLWARToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutLWARToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutLWARToolStripMenuItem.Text = "&About LWAR"
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Image = Global.LWAR.My.Resources.Resources._1371833687_go_previous
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.Location = New System.Drawing.Point(386, 336)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 13
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.LWAR.My.Resources.Resources._1387135890_system_log_out
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCancel.Location = New System.Drawing.Point(467, 336)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
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
        Me.btnHide.TabIndex = 15
        Me.btnHide.Text = "&Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'imgLogo
        '
        Me.imgLogo.BackgroundImage = Global.LWAR.My.Resources.Resources._1400410566_application_pgp_signature
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBoxStart)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblCurrentPage)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.imgLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LWAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start - LWAR"
        Me.GroupBoxStart.ResumeLayout(False)
        Me.GroupBoxStart.PerformLayout()
        Me.NotificationContext.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProjectSiteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SourceCodeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckForIpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutLWARToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitLWARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProjectsSiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SourceCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckForUpdatesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutLWARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SubmitFeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
