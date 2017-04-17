Public Class MainUtilities
    Private Shared panelInstance As MainUtilities
    Public Shared Function GetInstance() As MainUtilities
        If (panelInstance Is Nothing) Then
            panelInstance = New MainUtilities
        End If
        Return panelInstance
    End Function
    Private Sub MainUtilities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashNotepad.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashNotepad.Show()
        End If
        
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button1.BackgroundImage = My.Resources.layerbutton_Hover
        Label1.Text = "Notepad is a basic text-editing program and it's most commonly used to view or edit text files. A text file is a file type typically identified by the .txt file name extension"
        picIcon.Image = My.Resources.ico_Notepad
        picIcon.SetBounds(157, 161, 206, 157)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashCalculator.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashCalculator.Show()
        End If
        
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button2.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_Calculator
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "You can use Calculator to perform simple calculations such as addition, subtraction, multiplication, and division. Calculator also offers the advanced capabilities of retrieving trigonometric and logarithm values"
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button3.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_Analyser
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "Activity Tracker™ allows you to detect activities made on a specific director. Such as Delete, Create, Rename and Modify on the selected directory"
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button4.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_encrypt
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "Text Encryper™ allows you to convert text in to numerical characters. And reconvert the numerical character in to the relevant text. The encrypted text is highly fragile and might cause the text to be unreadable if the if the file is modified manually"
    End Sub

    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button5.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_Camera
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "You can use Screen Capturer tool to capture a screen shot, or snip, of any object on your screen, and save it into your computer automatically. Fast enough to capture 1 screen shots per second. And may cause some trouble while using with applications like Adobe Photoshop"
    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button6.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_Alarm
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "You can use alarm clock to set important messages, which you should be notified at a specific time."
    End Sub

    Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button7.BackgroundImage = My.Resources.layerbutton_Hover
        picIcon.Image = My.Resources.ico_Shredder
        picIcon.SetBounds(157, 161, 206, 157)
        Label1.Text = "When you delete a file, it generally ends up in the Recycle Bin. In Windows, this Recycle Bin is simply a folder that collects files for deletion. Retrieving a file from the Recycle Bin is child's play and therefore many users regularly empty the Recycle Bin or delete their files without sending them to the Recycle Bin, in order to feel that the file has been securely deleted."
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashActivityAnalyser.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashActivityAnalyser.Show()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashTextEncrypter.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashTextEncrypter.Show()
        End If
       
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashScreenCapturer.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashScreenCapturer.Show()
        End If
        
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashAlarmclock.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashAlarmclock.Show()
        End If
       
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Intergrator.WindowState = FormWindowState.Minimized
        If Intergrator.WindowState = FormWindowState.Minimized Then
            SplashShredder.Show()
        Else
            Intergrator.WindowState = FormWindowState.Minimized
            SplashShredder.Show()
        End If
       
    End Sub
End Class
