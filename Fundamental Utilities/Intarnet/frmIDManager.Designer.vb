<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIDManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIDManager))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowOnTaskbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopOnMostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorFundamentalUtilitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkdown = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTLeft = New System.Windows.Forms.Label()
        Me.txtDownloadAddress = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblDownloaded = New System.Windows.Forms.Label()
        Me.lblDFileSize = New System.Windows.Forms.Label()
        Me.pbDownloadProgress = New System.Windows.Forms.ProgressBar()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tmrDownloader = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.BackgroundImage = Global.Fundamental_Utilities.My.Resources.Resources.bg_Facebook
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblElapsedTime)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblProgress)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblTLeft)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDownloadAddress)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblStatus)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSpeed)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblDownloaded)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblDFileSize)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pbDownloadProgress)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancel)
        Me.SplitContainer1.Size = New System.Drawing.Size(824, 536)
        Me.SplitContainer1.SplitterDistance = 403
        Me.SplitContainer1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(824, 379)
        Me.ListBox1.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.BackgroundImage = Global.Fundamental_Utilities.My.Resources.Resources.bg_Header
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.CalculatorFundamentalUtilitiesToolStripMenuItem, Me.chkdown})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewItemToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_AddToList
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewItemToolStripMenuItem
        '
        Me.NewItemToolStripMenuItem.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_GoArrow
        Me.NewItemToolStripMenuItem.Name = "NewItemToolStripMenuItem"
        Me.NewItemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewItemToolStripMenuItem.Text = "New Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_Exiting
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearAllToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.EditToolStripMenuItem.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_AB
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_risky
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_Spanner
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowOnTaskbarToolStripMenuItem, Me.TopOnMostToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_alpha_CPU_16x16
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ShowOnTaskbarToolStripMenuItem
        '
        Me.ShowOnTaskbarToolStripMenuItem.Checked = True
        Me.ShowOnTaskbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowOnTaskbarToolStripMenuItem.Name = "ShowOnTaskbarToolStripMenuItem"
        Me.ShowOnTaskbarToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ShowOnTaskbarToolStripMenuItem.Text = "Show in Taskbar"
        '
        'TopOnMostToolStripMenuItem
        '
        Me.TopOnMostToolStripMenuItem.Name = "TopOnMostToolStripMenuItem"
        Me.TopOnMostToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TopOnMostToolStripMenuItem.Text = "Top on most"
        '
        'CalculatorFundamentalUtilitiesToolStripMenuItem
        '
        Me.CalculatorFundamentalUtilitiesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CalculatorFundamentalUtilitiesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CalculatorFundamentalUtilitiesToolStripMenuItem.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_Favorites
        Me.CalculatorFundamentalUtilitiesToolStripMenuItem.Name = "CalculatorFundamentalUtilitiesToolStripMenuItem"
        Me.CalculatorFundamentalUtilitiesToolStripMenuItem.Size = New System.Drawing.Size(306, 20)
        Me.CalculatorFundamentalUtilitiesToolStripMenuItem.Text = "Internet Download Manager - Fundamental Utilities"
        '
        'chkdown
        '
        Me.chkdown.Checked = True
        Me.chkdown.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkdown.ForeColor = System.Drawing.Color.Blue
        Me.chkdown.Image = Global.Fundamental_Utilities.My.Resources.Resources.LED_Green
        Me.chkdown.Name = "chkdown"
        Me.chkdown.Size = New System.Drawing.Size(118, 20)
        Me.chkdown.Text = "Download - ON"
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.AutoSize = True
        Me.lblElapsedTime.BackColor = System.Drawing.Color.Transparent
        Me.lblElapsedTime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElapsedTime.Location = New System.Drawing.Point(222, 92)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(28, 13)
        Me.lblElapsedTime.TabIndex = 26
        Me.lblElapsedTime.Text = "N\A"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Download Progress :"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.BackColor = System.Drawing.Color.Transparent
        Me.lblProgress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.Location = New System.Drawing.Point(144, 92)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(28, 13)
        Me.lblProgress.TabIndex = 24
        Me.lblProgress.Text = "N\A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Time Remaining :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Transfer Rate :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Downloaded :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "File Size :"
        '
        'lblTLeft
        '
        Me.lblTLeft.AutoSize = True
        Me.lblTLeft.BackColor = System.Drawing.Color.Transparent
        Me.lblTLeft.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTLeft.Location = New System.Drawing.Point(126, 72)
        Me.lblTLeft.Name = "lblTLeft"
        Me.lblTLeft.Size = New System.Drawing.Size(28, 13)
        Me.lblTLeft.TabIndex = 19
        Me.lblTLeft.Text = "N\A"
        '
        'txtDownloadAddress
        '
        Me.txtDownloadAddress.BackColor = System.Drawing.Color.White
        Me.txtDownloadAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDownloadAddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDownloadAddress.Location = New System.Drawing.Point(12, 9)
        Me.txtDownloadAddress.Name = "txtDownloadAddress"
        Me.txtDownloadAddress.ReadOnly = True
        Me.txtDownloadAddress.Size = New System.Drawing.Size(710, 14)
        Me.txtDownloadAddress.TabIndex = 18
        Me.txtDownloadAddress.Text = "Nothing"
        Me.txtDownloadAddress.WordWrap = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Blue
        Me.lblStatus.Location = New System.Drawing.Point(222, 26)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(57, 17)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Status"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblSpeed.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.Location = New System.Drawing.Point(126, 58)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(28, 13)
        Me.lblSpeed.TabIndex = 16
        Me.lblSpeed.Text = "N\A"
        '
        'lblDownloaded
        '
        Me.lblDownloaded.AutoSize = True
        Me.lblDownloaded.BackColor = System.Drawing.Color.Transparent
        Me.lblDownloaded.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloaded.Location = New System.Drawing.Point(126, 44)
        Me.lblDownloaded.Name = "lblDownloaded"
        Me.lblDownloaded.Size = New System.Drawing.Size(28, 13)
        Me.lblDownloaded.TabIndex = 15
        Me.lblDownloaded.Text = "N\A"
        '
        'lblDFileSize
        '
        Me.lblDFileSize.AutoSize = True
        Me.lblDFileSize.BackColor = System.Drawing.Color.Transparent
        Me.lblDFileSize.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDFileSize.Location = New System.Drawing.Point(126, 30)
        Me.lblDFileSize.Name = "lblDFileSize"
        Me.lblDFileSize.Size = New System.Drawing.Size(28, 13)
        Me.lblDFileSize.TabIndex = 14
        Me.lblDFileSize.Text = "N\A"
        '
        'pbDownloadProgress
        '
        Me.pbDownloadProgress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbDownloadProgress.Location = New System.Drawing.Point(0, 111)
        Me.pbDownloadProgress.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.pbDownloadProgress.Name = "pbDownloadProgress"
        Me.pbDownloadProgress.Size = New System.Drawing.Size(737, 18)
        Me.pbDownloadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbDownloadProgress.TabIndex = 11
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Enabled = False
        Me.btnCancel.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_deletesmall
        Me.btnCancel.Location = New System.Drawing.Point(737, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 129)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel Download"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'tmrDownloader
        '
        Me.tmrDownloader.Enabled = True
        Me.tmrDownloader.Interval = 500
        '
        'frmIDManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 536)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIDManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Internet Download Manager"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowOnTaskbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopOnMostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorFundamentalUtilitiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkdown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbDownloadProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTLeft As System.Windows.Forms.Label
    Friend WithEvents txtDownloadAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblDownloaded As System.Windows.Forms.Label
    Friend WithEvents lblDFileSize As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrDownloader As System.Windows.Forms.Timer
    Friend WithEvents lblElapsedTime As System.Windows.Forms.Label
End Class
