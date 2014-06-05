<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Documentation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Documentation))
        Me.StatusText_timer = New System.Windows.Forms.Timer(Me.components)
        Me.FrontPgaeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PagesIndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.PageTitle = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBack = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonForward = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTxtURL = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonStop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemNavPagesIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemNavHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemNavForward = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemNavBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemNav = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusText_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusText_timer
        '
        '
        'FrontPgaeToolStripMenuItem
        '
        Me.FrontPgaeToolStripMenuItem.Name = "FrontPgaeToolStripMenuItem"
        Me.FrontPgaeToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.FrontPgaeToolStripMenuItem.Text = "&Home"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(133, 6)
        '
        'ForwardToolStripMenuItem
        '
        Me.ForwardToolStripMenuItem.Name = "ForwardToolStripMenuItem"
        Me.ForwardToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ForwardToolStripMenuItem.Text = "&Forward"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ForwardToolStripMenuItem, Me.ToolStripSeparator1, Me.FrontPgaeToolStripMenuItem, Me.PagesIndexToolStripMenuItem, Me.ToolStripSeparator5, Me.RefreshToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 148)
        '
        'PagesIndexToolStripMenuItem
        '
        Me.PagesIndexToolStripMenuItem.Name = "PagesIndexToolStripMenuItem"
        Me.PagesIndexToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PagesIndexToolStripMenuItem.Text = "&Pages index"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(133, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.StopToolStripMenuItem.Text = "&Stop"
        '
        'WebBrowser
        '
        Me.WebBrowser.ContextMenuStrip = Me.ContextMenuStrip1
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser.Location = New System.Drawing.Point(0, 49)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.ScriptErrorsSuppressed = True
        Me.WebBrowser.Size = New System.Drawing.Size(844, 523)
        Me.WebBrowser.TabIndex = 7
        '
        'PageTitle
        '
        Me.PageTitle.Name = "PageTitle"
        Me.PageTitle.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBack, Me.ToolStripButtonForward, Me.ToolStripSeparator3, Me.ToolStripTxtURL, Me.ToolStripButton1, Me.ToolStripSeparator6, Me.ToolStripButtonHome, Me.ToolStripButtonRefresh, Me.ToolStripSeparator4, Me.ToolStripButtonStop, Me.ToolStripSeparator7, Me.PageTitle})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(844, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonBack
        '
        Me.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBack.Image = Global.LWAR.My.Resources.Resources._1371833687_go_previous
        Me.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBack.Name = "ToolStripButtonBack"
        Me.ToolStripButtonBack.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBack.Text = "Back"
        '
        'ToolStripButtonForward
        '
        Me.ToolStripButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonForward.Image = Global.LWAR.My.Resources.Resources._1371833067_go_next
        Me.ToolStripButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonForward.Name = "ToolStripButtonForward"
        Me.ToolStripButtonForward.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonForward.Text = "Forward"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTxtURL
        '
        Me.ToolStripTxtURL.Name = "ToolStripTxtURL"
        Me.ToolStripTxtURL.Size = New System.Drawing.Size(450, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonHome
        '
        Me.ToolStripButtonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonHome.Image = Global.LWAR.My.Resources.Resources._1371833355_go_home
        Me.ToolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonHome.Name = "ToolStripButtonHome"
        Me.ToolStripButtonHome.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonHome.Text = "Home"
        '
        'ToolStripButtonRefresh
        '
        Me.ToolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRefresh.Image = Global.LWAR.My.Resources.Resources._1371833577_view_refresh
        Me.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh"
        Me.ToolStripButtonRefresh.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonRefresh.Text = "Refresh"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonStop
        '
        Me.ToolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonStop.Image = Global.LWAR.My.Resources.Resources._1387140136_process_stop
        Me.ToolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonStop.Name = "ToolStripButtonStop"
        Me.ToolStripButtonStop.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonStop.Text = "Stop"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripMenuItemNavPagesIndex
        '
        Me.ToolStripMenuItemNavPagesIndex.Name = "ToolStripMenuItemNavPagesIndex"
        Me.ToolStripMenuItemNavPagesIndex.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItemNavPagesIndex.Text = "&Pages index"
        '
        'ToolStripMenuItemNavHome
        '
        Me.ToolStripMenuItemNavHome.Name = "ToolStripMenuItemNavHome"
        Me.ToolStripMenuItemNavHome.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItemNavHome.Text = "&Home"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(133, 6)
        '
        'ToolStripMenuItemNavForward
        '
        Me.ToolStripMenuItemNavForward.Name = "ToolStripMenuItemNavForward"
        Me.ToolStripMenuItemNavForward.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItemNavForward.Text = "&Forward"
        '
        'ToolStripMenuItemNavBack
        '
        Me.ToolStripMenuItemNavBack.Name = "ToolStripMenuItemNavBack"
        Me.ToolStripMenuItemNavBack.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItemNavBack.Text = "&Back"
        '
        'ToolStripMenuItemNav
        '
        Me.ToolStripMenuItemNav.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemNavBack, Me.ToolStripMenuItemNavForward, Me.ToolStripSeparator2, Me.ToolStripMenuItemNavHome, Me.ToolStripMenuItemNavPagesIndex})
        Me.ToolStripMenuItemNav.Name = "ToolStripMenuItemNav"
        Me.ToolStripMenuItemNav.Size = New System.Drawing.Size(77, 20)
        Me.ToolStripMenuItemNav.Text = "&Navigation"
        '
        'ToolStripMenuItemFileClose
        '
        Me.ToolStripMenuItemFileClose.Name = "ToolStripMenuItemFileClose"
        Me.ToolStripMenuItemFileClose.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItemFileClose.Text = "&Close"
        '
        'ToolStripMenuItemFile
        '
        Me.ToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFileClose})
        Me.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile"
        Me.ToolStripMenuItemFile.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItemFile.Text = "&File"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFile, Me.ToolStripMenuItemNav})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(844, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusText_label
        '
        Me.StatusText_label.Name = "StatusText_label"
        Me.StatusText_label.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ToolStripProgressBar1.Visible = False
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.StatusText_label})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 572)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(844, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Documentation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 594)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Name = "Documentation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentation"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusText_timer As System.Windows.Forms.Timer
    Friend WithEvents FrontPgaeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ForwardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PagesIndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents PageTitle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripMenuItemNavPagesIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemNavHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemNavForward As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemNavBack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemNav As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemFileClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusText_label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripButtonBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTxtURL As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class