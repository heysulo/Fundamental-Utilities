Public Class frmShredder
    Dim FL As ObjectModel.ReadOnlyCollection(Of String)
    Dim SFL As ObjectModel.ReadOnlyCollection(Of String)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If CheckBox1.Checked = True Then
            FL = My.Computer.FileSystem.GetDirectories(TextBox1.Text, FileIO.SearchOption.SearchAllSubDirectories)
            SFL = My.Computer.FileSystem.GetFiles(TextBox1.Text, FileIO.SearchOption.SearchAllSubDirectories)
        Else
            SFL = My.Computer.FileSystem.GetFiles(TextBox1.Text, FileIO.SearchOption.SearchTopLevelOnly)
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim X As Integer
        Dim Q As Integer
        Dim ERS As String
        ERS = ""
        On Error GoTo erh
        If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) = False Then
            My.Computer.Audio.Play(My.Resources.sfx_FeedDiscovered, AudioPlayMode.Background)
            MsgBox("The selected directory is missing !!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Cannot Continue")
            Exit Sub
        End If
        Label3.Text = "Data Retrived. Processing"
        If CheckBox1.Checked = True Then
            For Each Item As String In FL
                ListBox1.Items.Add(Item)
            Next
        End If
        X = 0
        If CheckBox1.Checked = True Then
            Do Until X = ListBox1.Items.Count
                X = X + 1
                ListBox2.Items.Add(ListBox1.Items.Item(ListBox1.Items.Count - X))
                My.Computer.FileSystem.GetDirectoryInfo(ListBox1.Items.Item(ListBox1.Items.Count - X)).Attributes = IO.FileAttributes.Normal
            Loop
            ListBox1.Items.Clear()
        End If
        For Each Item As String In SFL
            ListBox1.Items.Add(Item)
            My.Computer.FileSystem.GetFileInfo(Item).Attributes = IO.FileAttributes.Normal
        Next
        ProgressBar1.Maximum = ListBox1.Items.Count + ListBox2.Items.Count
        If CheckBox2.Checked = True Then
            ProgressBar1.Maximum = ProgressBar1.Maximum + ListBox1.Items.Count
        End If
        ProgressBar1.Value = 0
        If CheckBox2.Checked = True Then
            For Each JK As String In ListBox1.Items
                My.Computer.FileSystem.WriteAllBytes(JK, Nothing, False)
                ProgressBar1.Value = ProgressBar1.Value + 1
            Next
        End If
        For Each SS As String In ListBox1.Items
            My.Computer.FileSystem.RenameFile(SS, IO.Path.GetRandomFileName)
            ProgressBar1.Value = ProgressBar1.Value + 1
        Next
        If CheckBox1.Checked = True Then
            For Each S As String In ListBox2.Items
                My.Computer.FileSystem.RenameDirectory(S, IO.Path.GetFileNameWithoutExtension(IO.Path.GetRandomFileName))
                ProgressBar1.Value = ProgressBar1.Value + 1
            Next
        End If
        For Each DF As String In My.Computer.FileSystem.GetDirectories(TextBox1.Text, FileIO.SearchOption.SearchTopLevelOnly)
            My.Computer.FileSystem.DeleteDirectory(DF, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
        Next
        For Each AF As String In My.Computer.FileSystem.GetFiles(TextBox1.Text, FileIO.SearchOption.SearchTopLevelOnly)
            My.Computer.FileSystem.DeleteFile(AF, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
        Next
        If Q = 0 Then
            Label3.Text = "Shredding Completed without any Errors"
            MsgBox("Shredding Completed without any Errors", MsgBoxStyle.Information)
        Else
            Label3.Text = "Shredding Completed with " & Q & " Errors"
            MsgBox("Shredding Completed with " & Q & " Errors" & vbCrLf & "Error List :" & vbCrLf & ERS, MsgBoxStyle.Information)
        End If
        Exit Sub
erh:
        Q = Q + 1
        ERS = ERS & ErrorToString() & vbCrLf
        Resume Next
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) Then
            If MsgBox("This action will cause loss of all the Data in the Selected Directory Permonently (Recovering is also ineffective). This action cannot be Rolled back in any method. Are you sure that you want to proceed with this action", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "MASTER CAUTION !!!") = MsgBoxResult.Yes Then
                ListBox1.Items.Clear()
                ListBox2.Items.Clear()
                Label3.Text = "Shredding Started . . ."
                BackgroundWorker1.RunWorkerAsync()
            Else
                Label3.Text = "Operation Aborted by User"
            End If
        Else
            Label3.Text = "Target Unavailable"
            Beep()
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
        MsgBox("When you delete a file, it generally ends up in the Recycle Bin. In Windows, this Recycle Bin is simply a folder that collects files for deletion. Retrieving a file from the Recycle Bin is child's play and therefore many users regularly empty the Recycle Bin or delete their files without sending them to the Recycle Bin, in order to feel that the file has been securely deleted.", MsgBoxStyle.Information, "Help")
    End Sub

    Private Sub frmShredder_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmShredder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class