Public Class frmActivityAnalyser
    Dim REN As Integer
    Dim CRT As Integer
    Dim DEL As Integer
    Dim CHE As Integer

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            FileSystemWatcher1.Path = TextBox1.Text
        End If
    End Sub

    Private Sub FileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        If chkModify.Checked = True Then
            RichTextBox1.Text = RichTextBox1.Text & Now & "      " & e.ChangeType.ToString & "  -  " & e.FullPath & vbCrLf
        End If
        CHE = CHE + 1
        lblStatus.Text = "Created :" & CRT & "    Renamed: " & REN & "    Deleted: " & DEL & "    Modified: " & CHE & "    Total Events: " & CHE + REN + DEL + CRT
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        If chkCreate.Checked = True Then
            RichTextBox1.Text = RichTextBox1.Text & Now & "      " & e.ChangeType.ToString & "  -  " & e.FullPath & vbCrLf
        End If
        CRT = CRT + 1
        lblStatus.Text = "Created :" & CRT & "    Renamed: " & REN & "    Deleted: " & DEL & "    Modified: " & CHE & "    Total Events: " & CHE + REN + DEL + CRT
    End Sub

    Private Sub FileSystemWatcher1_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        If chkDelete.Checked = True Then
            RichTextBox1.Text = RichTextBox1.Text & Now & "      " & e.ChangeType.ToString & "  -  " & e.FullPath & vbCrLf
        End If
        lblStatus.Text = "Created :" & CRT & "    Renamed: " & REN & "    Deleted: " & DEL & "    Modified: " & CHE & "    Total Events: " & CHE + REN + DEL + CRT
        DEL = DEL + 1
    End Sub

    Private Sub FileSystemWatcher1_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        If chkRename.Checked = True Then
            RichTextBox1.Text = RichTextBox1.Text & Now & "      " & e.ChangeType.ToString & "  -  " & e.OldFullPath & " As " & e.Name & vbCrLf
        End If
        lblStatus.Text = "Created :" & CRT & "    Renamed: " & REN & "    Deleted: " & DEL & "    Modified: " & CHE & "    Total Events: " & CHE + REN + DEL + CRT
        REN = REN + 1
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            FileSystemWatcher1.IncludeSubdirectories = True
        Else
            FileSystemWatcher1.IncludeSubdirectories = False
        End If
    End Sub

    Private Sub frmActivityAnalyser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmActivityAnalyser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CHE = 0
        REN = 0
        DEL = 0
        CRT = 0
    End Sub

    Private Sub ResetCountersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetCountersToolStripMenuItem.Click
        CHE = 0
        REN = 0
        DEL = 0
        CRT = 0
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        If MsgBox("Are you sure that you want to Clear the log ???", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Clear log") = MsgBoxResult.Yes Then
            RichTextBox1.Text = Nothing
        End If
    End Sub

    Private Sub frmActivityAnalyser_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        SplitContainer1.SplitterDistance = 90
    End Sub

    Private Sub frmActivityAnalyser_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        SplitContainer1.SplitterDistance = 90
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("This Utility will moniter all the actions done in the given path. Such as : Create, Delete, Rename and Change", MsgBoxStyle.Information, "Help")
    End Sub
End Class