Public Class frmMediaPlayer
    
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            axWMP.URL = OpenFileDialog1.FileName
            ToolStripTextBox1.Text = OpenFileDialog1.SafeFileName
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        axWMP.fullScreen = True
    End Sub

    Private Sub axWMP_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles axWMP.Enter

    End Sub

    Private Sub axWMP_MediaChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_MediaChangeEvent) Handles axWMP.MediaChange
        NotifyIcon1.ShowBalloonTip(100, axWMP.status & vbCrLf & axWMP.currentMedia.name, axWMP.status & vbCrLf & axWMP.currentMedia.name & vbCrLf & "Duration : " & axWMP.currentMedia.durationString, ToolTipIcon.Info)
    End Sub

    Private Sub frmMediaPlayer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NotifyIcon1.Visible = False
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmMediaPlayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class