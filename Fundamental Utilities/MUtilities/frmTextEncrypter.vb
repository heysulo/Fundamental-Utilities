Public Class frmTextEncrypter
    Dim TXT As String
    Public ABT As Boolean

    Dim TXE As String
    Dim TXD As String
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1.FileName.ToLower.EndsWith("*.rtf") Then
                RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            Else
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            End If
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If SaveFileDialog1.FileName.ToLower.EndsWith(".rtf") Then
                RichTextBox1.SaveFile(SaveFileDialog1.FileName)
            Else
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
            End If
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

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        If MsgBox("Are you sure that you want to all the content in the current document ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Clear All") = MsgBoxResult.Yes Then
            RichTextBox1.Text = ""
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Text Encryper™ allows you to convert text in to numerical characters. And reconvert the numerical character in to the relevant text. The encrypted text is highly fragile and might cause the text to be unreadable if the if the file is modified manually", MsgBoxStyle.Information, "Help")
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Application.DoEvents()
        ABT = False
        Dim AA As String
        Dim PRT As String = RichTextBox1.Text
        Dim AR As String = RichTextBox1.Text.ToCharArray
        Dim RXT As String = ""
        Me.Hide()
        frmENCProgress.Show()
        For Each SS As String In AR
            Application.DoEvents()
            RXT = SS & RXT
        Next
        RichTextBox1.Text = RXT
        frmENCProgress.ProgressBar1.Value = 0
        frmENCProgress.ProgressBar1.Maximum = RichTextBox1.Text.Length
        TXE = ""
        TXT = RichTextBox1.Text.ToCharArray
        For Each S As String In TXT
            If ABT = True Then
                Me.Show()
                RichTextBox1.Text = Nothing
                RichTextBox1.ScrollBars = Windows.Forms.RichTextBoxScrollBars.None
                RichTextBox1.ScrollBars = Windows.Forms.RichTextBoxScrollBars.Both
                RichTextBox1.ResetText()
                RichTextBox1.Refresh()
                RichTextBox1.Text = PRT
                My.Computer.Audio.Play(My.Resources.sfx_FeedDiscovered, AudioPlayMode.Background)
                Exit Sub
            End If
            Application.DoEvents()
            AA = Asc(S)
            If Val(AA) < 100 Then
                AA = 0 & AA
            End If
            TXE = TXE & AA
            frmENCProgress.ProgressBar1.Value = frmENCProgress.ProgressBar1.Value + 1
        Next
        RichTextBox1.Text = Nothing
        RichTextBox1.ScrollBars = Windows.Forms.RichTextBoxScrollBars.None
        RichTextBox1.ScrollBars = Windows.Forms.RichTextBoxScrollBars.Both
        RichTextBox1.ResetText()
        RichTextBox1.Refresh()
        RichTextBox1.Text = TXE
        AA = ""
        TXE = ""
        TXT = ""
        RXT = ""
        Me.Show()
        frmENCProgress.Close()
        My.Computer.Audio.Play(My.Resources.sfx_Ding, AudioPlayMode.Background)
        AR = Nothing
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        TXD = ""
        ABT = False
        Dim PRT As String = RichTextBox1.Text
        On Error Resume Next
        Dim ST As String = ""
        Dim L As Long = Val(RichTextBox1.Text.Length) / 3
        Me.Hide()
        frmENCProgress.Show()
        frmENCProgress.ProgressBar1.Value = 0
        frmENCProgress.ProgressBar1.Maximum = L
        Dim X As Long = 0
        Dim NN As String
        Do Until X = L
            If ABT = True Then
                Me.Show()
                RichTextBox1.Text = Nothing
                RichTextBox1.ScrollBars = Windows.Forms.RichTextBoxScrollBars.None
                RichTextBox1.ScrollBars = Windows.Forms.RichTextBoxScrollBars.Both
                RichTextBox1.ResetText()
                RichTextBox1.Refresh()
                My.Computer.Audio.Play(My.Resources.sfx_FeedDiscovered, AudioPlayMode.Background)
                RichTextBox1.Text = PRT
                Exit Sub
            End If
            Application.DoEvents()
            RichTextBox1.SelectionStart = 0
            RichTextBox1.SelectionLength = 3
            RichTextBox1.Select()
            ST = Val(RichTextBox1.SelectedText)
            NN = Chr(ST)
            TXD = TXD & NN
            RichTextBox1.Text = RichTextBox1.Text.Remove(0, 3)
            X = X + 1
            frmENCProgress.ProgressBar1.Value = frmENCProgress.ProgressBar1.Value + 1
        Loop
        RichTextBox1.Text = TXD
        Dim AR As String = RichTextBox1.Text.ToCharArray
        Dim RXT As String = ""
        For Each SS As String In AR
            Application.DoEvents()
            RXT = SS & RXT
        Next
        RichTextBox1.Text = Nothing
        RichTextBox1.ScrollBars = Windows.Forms.RichTextBoxScrollBars.None
        RichTextBox1.ScrollBars = Windows.Forms.RichTextBoxScrollBars.Both
        RichTextBox1.ResetText()
        RichTextBox1.Refresh()
        RichTextBox1.Text = RXT
        ST = ""
        RXT = ""
        NN = ""
        AR = ""
        X = 0
        L = 0
        Me.Show()
        My.Computer.Audio.Play(My.Resources.sfx_Ding, AudioPlayMode.Background)
        frmENCProgress.Close()
    End Sub

    Private Sub frmTextEncrypter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class