Public Class frmScreenCapturer
    Dim OKS As String
    Private Sub ShowOnTaskbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowOnTaskbarToolStripMenuItem.Click
        If ShowOnTaskbarToolStripMenuItem.Checked = True Then
            ShowOnTaskbarToolStripMenuItem.Checked = False
            Me.ShowInTaskbar = False
        Else
            ShowOnTaskbarToolStripMenuItem.Checked = True
            Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub TopOnMostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopOnMostToolStripMenuItem.Click
        If TopOnMostToolStripMenuItem.Checked = True Then
            TopOnMostToolStripMenuItem.Checked = False
            Me.TopMost = False
        Else
            TopOnMostToolStripMenuItem.Checked = True
            Me.TopMost = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("You can use Screen Capturer tool to capture a screen shot, or snip, of any object on your screen, and save it into your computer automatically. Fast enough to capture 1 screen shots per second. And may cause some trouble while using with applications like Adobe Photoshop", MsgBoxStyle.Information, "Help")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Image = My.Resources.ico_SwitchOn
            Label1.Text = ">>> Autoretrive : ON"
            Timer1.Enabled = True
        Else
            CheckBox1.Image = My.Resources.ico_Switchoff
            Label1.Text = ">>> Autoretrive : OFF"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OKS = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error GoTo ERR
        Dim NNT As String
        If My.Computer.Clipboard.ContainsImage() Then
            Dim grabpicture As System.Drawing.Image
            grabpicture = My.Computer.Clipboard.GetImage()
            PictureBox1.Image = grabpicture
            Label84.Visible = False
            My.Computer.Audio.Play(My.Resources.sfx_Photoflash, AudioPlayMode.Background)
            My.Computer.Clipboard.Clear()
            NNT = DateAndTime.Now
            NNT = NNT.Replace("/", "-")
            NNT = NNT.Replace(":", "-")
            PictureBox1.Image.Save(OKS & "\FU Captured at " & NNT & ".jpeg", Imaging.ImageFormat.Jpeg)
        End If
        Exit Sub
ERR:
        MsgBox(ErrorToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error Occured")
    End Sub

    Private Sub frmScreenCapturer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = Windows.Forms.FormWindowState.Normal
    End Sub

    Private Sub frmScreenCapturer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OKS = My.Computer.FileSystem.SpecialDirectories.Desktop
    End Sub
    
End Class