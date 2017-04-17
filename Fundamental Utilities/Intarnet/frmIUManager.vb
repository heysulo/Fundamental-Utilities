Public Class frmIUManager
    Public CI As String
    Public FN As String
    Public DES As String
    Public UN As String
    Public PS As String
    Public TM As Integer
    Public Ad As Boolean
    Private Sub TopOnMostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopOnMostToolStripMenuItem.Click
        If TopOnMostToolStripMenuItem.Checked = True Then
            TopOnMostToolStripMenuItem.Checked = False
            Me.TopMost = False
        Else
            TopOnMostToolStripMenuItem.Checked = True
            Me.TopMost = True
        End If
    End Sub

    Private Sub ShowOnTaskbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowOnTaskbarToolStripMenuItem.Click
        If ShowOnTaskbarToolStripMenuItem.Checked = True Then
            ShowOnTaskbarToolStripMenuItem.Checked = False
            Me.ShowInTaskbar = False
        Else
            ShowOnTaskbarToolStripMenuItem.Checked = True
            Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewItemToolStripMenuItem.Click
        frmNewUpload.Show()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        If ListBox1.SelectedItems.Count > 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
            MsgBox("Nothing is selected", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDownloadOptions.Show()
        frmDownloadOptions.PC = True
    End Sub

    Private Sub frmIUManager_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmIDManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub chkdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdown.Click
        If chkdown.Checked = True Then
            chkdown.Checked = False
            chkdown.Text = "Upload-OFF"
            tmrDownloader.Enabled = False
            chkdown.Image = My.Resources.LED_Red
        Else
            chkdown.Checked = True
            chkdown.Text = "Upload-ON"
            tmrDownloader.Enabled = True
            chkdown.Image = My.Resources.LED_Green
        End If
    End Sub

    Private Sub tmrDownloader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDownloader.Tick
        If bgDownloader.IsBusy = False Then
            If ListBox1.Items.Count > 0 Then
                TextBox1.Text = ListBox1.Items.Item(0)
                TextBox1.Text = TextBox1.Text.Replace(">>> to >>>", vbCrLf)
                DES = TextBox1.Lines(0)
                CI = TextBox1.Lines(1)
                FN = IO.Path.GetFileName(CI)
                lblStatus.Text = "Uploading " & FN
                bgDownloader.RunWorkerAsync()
                ListBox1.Items.RemoveAt(0)
            Else
                lblStatus.Text = "Ready"
            End If
        End If
    End Sub

    Private Sub bgDownloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgDownloader.DoWork
        On Error GoTo Errorhandler
        If My.Computer.FileSystem.FileExists(CI) = False Then
            MsgBox("File Unavailable. Plaese select a valid file", MsgBoxStyle.Critical)
            Exit Sub
        End If
        My.Computer.Network.UploadFile(CI, DES & "\" & FN, Nothing, Nothing, True, 300, True)
        Exit Sub
Errorhandler:
        MsgBox(ErrorToString, MsgBoxStyle.Critical)
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        ListBox1.Items.Clear()
    End Sub
End Class