Public Class MyComputerz
    Private Shared panelInstance As MyComputerz
    Public Shared Function GetInstance() As MyComputerz
        If (panelInstance Is Nothing) Then
            panelInstance = New MyComputerz
        End If
        Return panelInstance
    End Function

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button1.BackgroundImage = My.Resources.layerbutton_Hover
        Label1.Text = "Change you computer's power state." & vbCrLf & "Hibernation is a power-saving state designed primarily for laptops. Hibernation puts your open documents and programs on your hard disk, and then turns off your computer. Of all the power-saving states in Windows, hibernation uses the least amount of power." & vbCrLf & "Sleep is a power-saving state that allows a computer to quickly resume full-power operation (typically within several seconds) when you want to start working again."
        picIcon.Image = My.Resources.ico_SessionLogout
        picIcon.SetBounds(157, 161, 206, 157)
    End Sub
    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button2.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_cpu3d
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "You can use this utility to view services that are running on your computer. (A process is a file, such as an executable file ending with a file name extension of .exe, that the computer uses to directly start a program or to start other services.)"
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button3.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_powerpreferences
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "Display the current power status of you computer"
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button4.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.logo_registry
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "Set or Return the values of the Windows Regitry. ( Administrator Privilidges Required )"
    End Sub

    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button5.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_Registry
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "Retrive the current values of your computer's Environment Variable"
    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button6.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_Clockbig
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "Check out the time on different Timezones on the world, Depends on your system clock, so the times might be inaccurate if your system clock is wrong"
    End Sub

    Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button7.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_Chart
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "View a fully detailed report about your computer. Like the computer name, processor, virtual memory, Operating System, User Name, User Group"
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        Button7.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmMCPowerState.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmMCPowerState.Show()
        End If
     
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashServicesandProcesses.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashServicesandProcesses.Show()
        End If
       
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            frmMCIntTimeZones.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            frmMCIntTimeZones.Show()
        End If
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmMCComputerStatus.Show()
      
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmMCEnvironmentVariable.Show()
      
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmMCRegistry.Show()
      
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Application.DoEvents()
        frmMCReport.Show()
    End Sub
End Class
