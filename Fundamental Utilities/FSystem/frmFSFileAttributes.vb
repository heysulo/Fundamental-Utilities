Public Class frmFSFileAttributes
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
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo ERH
        Dim ATT As IO.FileInfo
        ATT = My.Computer.FileSystem.GetFileInfo(TextBox1.Text)
        ATT.Attributes = IO.FileAttributes.Normal
        If CheckBox1.Checked = True Then
            ATT.Attributes = ATT.Attributes + IO.FileAttributes.ReadOnly
        End If
        If CheckBox2.Checked = True Then
            ATT.Attributes = ATT.Attributes + IO.FileAttributes.Hidden
        End If
        If CheckBox3.Checked = True Then
            ATT.Attributes = ATT.Attributes + IO.FileAttributes.System
        End If
        MsgBox("New attributes for " & TextBox1.Text & vbCrLf & ATT.Attributes.ToString, MsgBoxStyle.Information, "Attributes Changed")
        Exit Sub
ERH:
        MsgBox(ErrorToString, MsgBoxStyle.Critical, "Error Occured")
    End Sub

    Private Sub frmFSFileAttributes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub
End Class