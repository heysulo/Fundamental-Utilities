Public Class frmNotepad
    Dim TXTC As Boolean
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim MSGRSP As MsgBoxResult
        If TXTC = True Then
            MSGRSP = MsgBox("Don't You Want To Save the Changes you made in your Current Document ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "New Document")
            If MSGRSP = MsgBoxResult.No Then
                RichTextBox1.Text = ""
                TXTC = False
            ElseIf MSGRSP = MsgBoxResult.Yes Then
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If SaveFileDialog1.FileName.ToLower.EndsWith(".rtf") Then
                        RichTextBox1.SaveFile(SaveFileDialog1.FileName)
                    Else
                        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                    End If
                End If
            Else
                GoTo K
            End If
        Else
            RichTextBox1.Text = ""
            TXTC = False
        End If
K:
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1.FileName.ToLower.EndsWith("*.rtf") Then
                RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            Else
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            End If
            TXTC = False
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If SaveFileDialog1.FileName.ToLower.EndsWith(".rtf") Then
                RichTextBox1.SaveFile(SaveFileDialog1.FileName)
                My.Computer.Audio.Play(My.Resources.sfx_Ding, AudioPlayMode.Background)
            Else
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                My.Computer.Audio.Play(My.Resources.sfx_Ding, AudioPlayMode.Background)
            End If
            TXTC = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        If MsgBox("Are you sure that you want to all the content in the current document ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Clear All") = MsgBoxResult.Yes Then
            RichTextBox1.Text = ""
        End If
    End Sub

    Private Sub InsertTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertTimeToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & TimeString
    End Sub

    Private Sub InsertDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertDateToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text & DateString
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        If My.Computer.Clipboard.ContainsText = True Then
            RichTextBox1.Paste()
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordWrapToolStripMenuItem.Click
        If WordWrapToolStripMenuItem.Checked = True Then
            WordWrapToolStripMenuItem.Checked = False
            RichTextBox1.WordWrap = False
        Else
            WordWrapToolStripMenuItem.Checked = True
            RichTextBox1.WordWrap = True
        End If
    End Sub

    Private Sub frmNotepad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim MSGRSP As MsgBoxResult
        If TXTC = True Then
            MSGRSP = MsgBox("Don't You Want To Save the Changes you made in your Current Document ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "New Document")
            If MSGRSP = MsgBoxResult.No Then
                GoTo K
            ElseIf MSGRSP = MsgBoxResult.Yes Then
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If SaveFileDialog1.FileName.ToLower.EndsWith(".rtf") Then
                        RichTextBox1.SaveFile(SaveFileDialog1.FileName)
                    Else
                        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                    End If
                End If
            Else
                e.Cancel = True
                Exit Sub
            End If
        End If
K:
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        TXTC = True
    End Sub

    Private Sub ShowInTaskbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowInTaskbarToolStripMenuItem.Click
        If ShowInTaskbarToolStripMenuItem.Checked = True Then
            ShowInTaskbarToolStripMenuItem.Checked = False
            Me.ShowInTaskbar = False
        Else
            ShowInTaskbarToolStripMenuItem.Checked = True
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
End Class