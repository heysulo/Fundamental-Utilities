Public Class frmNewDownload

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = My.Computer.Clipboard.GetText
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmIDManager.ListBox1.Items.Add(TextBox1.Text)
        Me.Close()
        frmIDManager.WindowState = FormWindowState.Normal
    End Sub
End Class