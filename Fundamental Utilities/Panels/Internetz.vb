Public Class Internetz
    Private Shared panelInstance As Internetz

    Public Shared Function GetInstance() As Internetz
        If (panelInstance Is Nothing) Then
            panelInstance = New Internetz
        End If
        Return panelInstance
    End Function

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        PictureBox1.Image = My.Resources.button_FileDownloaderHover
    End Sub
    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        PictureBox2.Image = My.Resources.button_FileUploadHover
    End Sub
    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        PictureBox3.Image = My.Resources.button_WebBrowserHover
    End Sub
    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        PictureBox4.Image = My.Resources.button_GIDHover
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.button_FileDownloaderNormal
    End Sub
    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.button_FileUploadNormal
    End Sub
    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.button_WebBrowserNormal
    End Sub
    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.button_GIDNormal
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmIDManager.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmIDManager.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmIUManager.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmIUManager.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashFUWebBrowser.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashFUWebBrowser.Show()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashGoogleID.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashGoogleID.Show()
        End If
    End Sub
End Class
