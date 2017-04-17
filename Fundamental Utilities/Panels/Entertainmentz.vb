Public Class Entertainmentz
    Private Shared panelInstance As Entertainmentz
    Public Shared Function GetInstance() As Entertainmentz
        If (panelInstance Is Nothing) Then
            panelInstance = New Entertainmentz
        End If
        Return panelInstance
    End Function

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        PictureBox2.Image = My.Resources.button_MPlayerHover
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.button_MPlayerNormal
    End Sub
    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.button_IViewerHover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.button_IViewerNormal
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmImageViewer.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmImageViewer.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmMediaPlayer.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmMediaPlayer.Show()
        End If
    End Sub
End Class
