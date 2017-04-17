Public Class frmNewUpload

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = My.Computer.Clipboard.GetText
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            If My.Computer.FileSystem.FileExists(TextBox2.Text) = True Then
                frmIUManager.ListBox1.Items.Add(TextBox1.Text & ">>> to >>>" & TextBox2.Text)
            Else
                MsgBox("Please select the file you wish to upload", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Please enter the Destination URL", MsgBoxStyle.Information)
        End If
    End Sub
End Class