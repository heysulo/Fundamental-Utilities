Public Class FileSyztem
    Private Shared panelInstance As FileSyztem
    Public Shared Function GetInstance() As FileSyztem
        If (panelInstance Is Nothing) Then
            panelInstance = New FileSyztem
        End If
        Return panelInstance
    End Function

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button4.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        Button5.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        Button6.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        Button7.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        Button7.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseEnter
        Button8.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        Button8.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseEnter
        Button9.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseLeave
        Button9.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseEnter
        Button10.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseLeave
        Button10.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseEnter
        Button11.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseLeave
        Button11.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSCreatedirectoey.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSCreatedirectoey.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSDeleteDirectory.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSDeleteDirectory.Show()
        End If
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSRenameDirectory.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSRenameDirectory.Show()
        End If
        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSDirectoryAttributes.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSDirectoryAttributes.Show()
        End If
        
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmCopyDirectory.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmCopyDirectory.Show()
        End If
        
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSMoveDirectory.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSMoveDirectory.Show()
        End If
        
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSDeleteFile.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSDeleteFile.Show()
        End If
        
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSRenameFile.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSRenameFile.Show()
        End If
        
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSFileAttributes.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSFileAttributes.Show()
        End If
        
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSCopyFile.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSCopyFile.Show()
        End If
        
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmFSMoveFile.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmFSMoveFile.Show()
        End If
        
    End Sub
End Class
