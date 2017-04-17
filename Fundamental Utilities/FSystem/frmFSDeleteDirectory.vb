Public Class frmFSDeleteDirectory
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
        If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) = False Then
            MsgBox("Selected Directory does not exists !!!", MsgBoxStyle.Exclamation, "Directory Unavailable")
            Exit Sub
        End If
        If RadioButton1.Checked = True Then
            RC = FileIO.RecycleOption.DeletePermanently
        Else
            RC = FileIO.RecycleOption.SendToRecycleBin
        End If
        If MsgBox("Are you sure that you want to delete " & TextBox1.Text & " and all it's contents ???", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Delete Directory") = MsgBoxResult.Yes Then
            My.Computer.FileSystem.DeleteDirectory(TextBox1.Text, FileIO.UIOption.OnlyErrorDialogs, RC, FileIO.UICancelOption.ThrowException)
            If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) = False Then
                MsgBox("Selected Directory deleted successfully !!!", MsgBoxStyle.Information, "Directory Removed")
                Me.Close()
                Exit Sub
            Else
                My.Computer.FileSystem.DeleteDirectory(TextBox1.Text, FileIO.UIOption.OnlyErrorDialogs, RC, FileIO.UICancelOption.ThrowException)
                If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) = False Then
                    MsgBox("Selected Directory deleted successfully !!!", MsgBoxStyle.Information, "Directory Removed")
                    Me.Close()
                    Exit Sub
                Else
                    MsgBox("Unable to delete the selected Directory!", MsgBoxStyle.Critical, "Directory Removing failed")
                End If
            End If
            Me.Close()
            Exit Sub
ERH:
            MsgBox(ErrorToString, MsgBoxStyle.Critical, "Error occured")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub frmFSDeleteDirectory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Intergrator.WindowState = FormWindowState.Normal
    End Sub
End Class