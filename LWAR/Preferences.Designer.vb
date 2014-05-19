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
        Me.btnPrefCancel = New System.Windows.Forms.Button()
        Me.btnPrefSave = New System.Windows.Forms.Button()
        Me.grpPrefIcon = New System.Windows.Forms.GroupBox()
        Me.chkBoxHideIconWhenShowLWAR = New System.Windows.Forms.CheckBox()
        Me.chkBoxIconShowOnStartup = New System.Windows.Forms.CheckBox()
        Me.grpPrefMain = New System.Windows.Forms.GroupBox()
        Me.chkBoxRememberStartContents = New System.Windows.Forms.CheckBox()
        Me.grpPrefIcon.SuspendLayout()
        Me.grpPrefMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrefCancel
        '
        Me.btnPrefCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrefCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrefCancel.Location = New System.Drawing.Point(313, 266)
        Me.btnPrefCancel.Name = "btnPrefCancel"
        Me.btnPrefCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnPrefCancel.TabIndex = 0
        Me.btnPrefCancel.Text = "Cancel"
        Me.btnPrefCancel.UseVisualStyleBackColor = True
        '
        'btnPrefSave
        '
        Me.btnPrefSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrefSave.Location = New System.Drawing.Point(232, 266)
        Me.btnPrefSave.Name = "btnPrefSave"
        Me.btnPrefSave.Size = New System.Drawing.Size(75, 23)
        Me.btnPrefSave.TabIndex = 1
        Me.btnPrefSave.Text = "Save"
        Me.btnPrefSave.UseVisualStyleBackColor = True
        '
        'grpPrefIcon
        '
        Me.grpPrefIcon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPrefIcon.Controls.Add(Me.chkBoxHideIconWhenShowLWAR)
        Me.grpPrefIcon.Controls.Add(Me.chkBoxIconShowOnStartup)
        Me.grpPrefIcon.Location = New System.Drawing.Point(12, 12)
        Me.grpPrefIcon.Name = "grpPrefIcon"
        Me.grpPrefIcon.Size = New System.Drawing.Size(376, 69)
        Me.grpPrefIcon.TabIndex = 2
        Me.grpPrefIcon.TabStop = False
        Me.grpPrefIcon.Text = "Icon"
        '
        'chkBoxHideIconWhenShowLWAR
        '
        Me.chkBoxHideIconWhenShowLWAR.AutoSize = True
        Me.chkBoxHideIconWhenShowLWAR.Location = New System.Drawing.Point(16, 43)
        Me.chkBoxHideIconWhenShowLWAR.Name = "chkBoxHideIconWhenShowLWAR"
        Me.chkBoxHideIconWhenShowLWAR.Size = New System.Drawing.Size(177, 17)
        Me.chkBoxHideIconWhenShowLWAR.TabIndex = 1
        Me.chkBoxHideIconWhenShowLWAR.Text = "Hide icon when showing LWAR"
        Me.chkBoxHideIconWhenShowLWAR.UseVisualStyleBackColor = True
        '
        'chkBoxIconShowOnStartup
        '
        Me.chkBoxIconShowOnStartup.AutoSize = True
        Me.chkBoxIconShowOnStartup.Location = New System.Drawing.Point(16, 19)
        Me.chkBoxIconShowOnStartup.Name = "chkBoxIconShowOnStartup"
        Me.chkBoxIconShowOnStartup.Size = New System.Drawing.Size(167, 17)
        Me.chkBoxIconShowOnStartup.TabIndex = 0
        Me.chkBoxIconShowOnStartup.Text = "Show icon on program startup"
        Me.chkBoxIconShowOnStartup.UseVisualStyleBackColor = True
        '
        'grpPrefMain
        '
        Me.grpPrefMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPrefMain.Controls.Add(Me.chkBoxRememberStartContents)
        Me.grpPrefMain.Location = New System.Drawing.Point(12, 87)
        Me.grpPrefMain.Name = "grpPrefMain"
        Me.grpPrefMain.Size = New System.Drawing.Size(376, 173)
        Me.grpPrefMain.TabIndex = 3
        Me.grpPrefMain.TabStop = False
        Me.grpPrefMain.Text = "Main Window"
        '
        'chkBoxRememberStartContents
        '
        Me.chkBoxRememberStartContents.AutoSize = True
        Me.chkBoxRememberStartContents.Location = New System.Drawing.Point(16, 20)
        Me.chkBoxRememberStartContents.Name = "chkBoxRememberStartContents"
        Me.chkBoxRememberStartContents.Size = New System.Drawing.Size(143, 17)
        Me.chkBoxRememberStartContents.TabIndex = 0
        Me.chkBoxRememberStartContents.Text = "Remember Starting fields"
        Me.chkBoxRememberStartContents.UseVisualStyleBackColor = True
        '
        'Preferences
        '
        Me.AcceptButton = Me.btnPrefSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnPrefCancel
        Me.ClientSize = New System.Drawing.Size(400, 301)
        Me.Controls.Add(Me.grpPrefMain)
        Me.Controls.Add(Me.grpPrefIcon)
        Me.Controls.Add(Me.btnPrefSave)
        Me.Controls.Add(Me.btnPrefCancel)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preferences"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        Me.TopMost = True
        Me.grpPrefIcon.ResumeLayout(False)
        Me.grpPrefIcon.PerformLayout()
        Me.grpPrefMain.ResumeLayout(False)
        Me.grpPrefMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrefCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrefSave As System.Windows.Forms.Button
    Friend WithEvents grpPrefIcon As System.Windows.Forms.GroupBox
    Friend WithEvents grpPrefMain As System.Windows.Forms.GroupBox
    Friend WithEvents chkBoxIconShowOnStartup As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxHideIconWhenShowLWAR As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxRememberStartContents As System.Windows.Forms.CheckBox
End Class
