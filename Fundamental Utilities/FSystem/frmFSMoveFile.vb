Public Class frmFSMoveFile
    Private Sub btnClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter
        btnClose.Image = My.Resources.BCL
    End Sub

    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        btnClose.Image = My.Resources.BSN
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FolderBrowserDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog2.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim DS As String
        DS = TextBox2.Text & "\" & IO.Path.GetFileName(TextBox1.Text)
        On Error GoTo ERH
RESTART:
        My.Computer.FileSystem.MoveFile(TextBox1.Text, DS, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
        MsgBox("File Moved !!!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        Exit Sub
ERH:
        If MsgBox("File Moving failed !!!" & vbCrLf & ErrorToString() & vbCrLf & vbCrLf & "Retry ???", MsgBoxStyle.Critical + MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
            GoTo RESTART
        End If
    End Sub

    Private Sub frmFSFileDirectory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
    End Sub

    Private Sub frmFSMoveDirectory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TopMost = False
    End Sub
End Class