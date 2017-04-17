Public Class frmFSCreatedirectoey

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
        My.Computer.FileSystem.CreateDirectory(TextBox1.Text)
        MsgBox("The directory " & TextBox1.Text & " has ben created", MsgBoxStyle.Information, "Folder Created")
        Process.Start(TextBox1.Text)
        Me.Close()
        Exit Sub
ERH:
        MsgBox("An error ocuured while processing the request !!!" & vbCrLf & vbCrLf & ErrorToString(), MsgBoxStyle.Critical, "Error Occured")
    End Sub

    Private Sub frmFSCreatedirectoey_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub
End Class