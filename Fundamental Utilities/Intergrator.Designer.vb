<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intergrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Intergrator))
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrMOptimizer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNetwork = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Image = Global.Fundamental_Utilities.My.Resources.Resources.close_normal
        Me.btnClose.Location = New System.Drawing.Point(846, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 19)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnClose, "Close")
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Image = Global.Fundamental_Utilities.My.Resources.Resources.minimize_normal
        Me.btnMinimize.Location = New System.Drawing.Point(821, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 19)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        '
        'RadioButton7
        '
        Me.RadioButton7.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton7.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton7.BackgroundImage = CType(resources.GetObject("RadioButton7.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton7.FlatAppearance.BorderSize = 0
        Me.RadioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.RadioButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RadioButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RadioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButton7.Location = New System.Drawing.Point(769, 58)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(120, 36)
        Me.RadioButton7.TabIndex = 17
        Me.RadioButton7.Text = "About"
        Me.RadioButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton7.UseVisualStyleBackColor = False
        '
        'RadioButton6
        '
        Me.RadioButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton6.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton6.BackgroundImage = CType(resources.GetObject("RadioButton6.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton6.FlatAppearance.BorderSize = 0
        Me.RadioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.RadioButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RadioButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RadioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(649, 58)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(120, 36)
        Me.RadioButton6.TabIndex = 16
        Me.RadioButton6.Text = "Options"
        Me.RadioButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton5.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton5.BackgroundImage = CType(resources.GetObject("RadioButton5.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton5.FlatAppearance.BorderSize = 0
        Me.RadioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.RadioButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RadioButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(529, 58)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(120, 36)
        Me.RadioButton5.TabIndex = 15
        Me.RadioButton5.Text = "Entertainment"
        Me.RadioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.BackgroundImage = CType(resources.GetObject("RadioButton4.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton4.FlatAppearance.BorderSize = 0
        Me.RadioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(409, 58)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(120, 36)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.Text = "Internet"
        Me.RadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.BackgroundImage = CType(resources.GetObject("RadioButton3.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton3.FlatAppearance.BorderSize = 0
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(289, 58)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(120, 36)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.Text = "My Computer"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.BackgroundImage = CType(resources.GetObject("RadioButton2.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(169, 58)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 36)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.Text = "File System"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.BackgroundImage = Global.Fundamental_Utilities.My.Resources.Resources.tab_Active
        Me.RadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(49, 58)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(120, 36)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Main Utilities"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(12, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 403)
        Me.Panel1.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Fundamental_Utilities.My.Resources.Resources.bg_TaskmgrNormal
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(726, -4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Task Manager"
        Me.ToolTip1.SetToolTip(Me.Button1, "Manage the currently running utilities and it's features")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tmrMOptimizer
        '
        Me.tmrMOptimizer.Enabled = True
        Me.tmrMOptimizer.Interval = 5000
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.ToolStripButton1.AutoSize = True
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.Checked = True
        Me.ToolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ToolStripButton1.FlatAppearance.BorderSize = 0
        Me.ToolStripButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = Global.Fundamental_Utilities.My.Resources.Resources.LED_Green
        Me.ToolStripButton1.Location = New System.Drawing.Point(769, 522)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(129, 28)
        Me.ToolStripButton1.TabIndex = 20
        Me.ToolStripButton1.Text = "Memeory Optimizer"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.ToolStripButton1, "Memory Optimizer limits the application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from using the Random Access Memory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Got" & _
                "o Options tab to set the Warning Level")
        Me.ToolStripButton1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_SandClock
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(9, 526)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "      Initializing"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label1, "Current time (of your computer)")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_Calender
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(118, 527)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "      Initializing"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label2, "Current date (of your computer)")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_reportcenter
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(318, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "      Initializing"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label3, "Power status of your computer")
        '
        'lblNetwork
        '
        Me.lblNetwork.BackColor = System.Drawing.Color.Transparent
        Me.lblNetwork.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetwork.ForeColor = System.Drawing.Color.White
        Me.lblNetwork.Image = Global.Fundamental_Utilities.My.Resources.Resources.ico_SandClock
        Me.lblNetwork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNetwork.Location = New System.Drawing.Point(535, 526)
        Me.lblNetwork.Name = "lblNetwork"
        Me.lblNetwork.Size = New System.Drawing.Size(172, 21)
        Me.lblNetwork.TabIndex = 24
        Me.lblNetwork.Text = "     Checking"
        Me.lblNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblNetwork, "Network availability")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Fundamental_Utilities.My.Resources.Resources.bg_TaskmgrNormal
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(633, -4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Virtual Monitor"
        Me.ToolTip1.SetToolTip(Me.Button2, "Show an Virtual Display of your monitor")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Help & Support"
        '
        'Intergrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Fundamental_Utilities.My.Resources.Resources.Intergrater3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 550)
        Me.Controls.Add(Me.lblNetwork)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStripButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadioButton7)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Intergrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fundamental Utilities"
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tmrMOptimizer As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNetwork As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
