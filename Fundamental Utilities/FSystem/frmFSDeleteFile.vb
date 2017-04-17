Public Class frmFSDeleteFile
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
        On Error GoTo ERH
        Dim RC As Microsoft.VisualBasic.FileIO.RecycleOption
        If My.Computer.FileSystem.FileExists(TextBox1.Text) = False Then
            MsgBox("Selected file does not exists !!!", MsgBoxStyle.Exclamation, "file Unavailable")
            Exit Sub
        End If
        If RadioButton1.Checked = True Then
            RC = FileIO.RecycleOption.DeletePermanently
        Else
            RC = FileIO.RecycleOption.SendToRecycleBin
        End If
        If MsgBox("Are you sure that you want to delete " & TextBox1.Text, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Delete File") = MsgBoxResult.Yes Then
            My.Computer.FileSystem.DeleteFile(TextBox1.Text, FileIO.UIOption.OnlyErrorDialogs, RC, FileIO.UICancelOption.ThrowException)
            If My.Computer.FileSystem.FileExists(TextBox1.Text) = False Then
                MsgBox("Selected file deleted successfully !!!", MsgBoxStyle.Information, "Flie Removed")
                Me.Close()
                Exit Sub
            Else
                My.Computer.FileSystem.DeleteFile(TextBox1.Text, FileIO.UIOption.OnlyErrorDialogs, RC, FileIO.UICancelOption.ThrowException)
                If My.Computer.FileSystem.FileExists(TextBox1.Text) = False Then
                    MsgBox("Selected file deleted successfully !!!", MsgBoxStyle.Information, "File Removed")
                    Me.Close()
                    Exit Sub
                Else
                    MsgBox("Unable to delete the selected file !!!", MsgBoxStyle.Critical, "Fle Removing failed")
                End If
            End If
            Me.Close()
            Exit Sub
ERH:
            MsgBox(ErrorToString, MsgBoxStyle.Critical, "Error occured")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub frmFSDeleteFile_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Intergrator.WindowState = FormWindowState.Normal
    End Sub
End Class