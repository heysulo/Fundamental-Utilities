
Public Class frmMemoryOptimiser
    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button6.BackgroundImage = My.Resources.layerbutton_Hover
    End Sub
    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button1.BackgroundImage = My.Resources.layerbutton_Hover
    End Sub
    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button2.BackgroundImage = My.Resources.layerbutton_Hover
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim PRC As Process
        PRC = Diagnostics.Process.GetCurrentProcess
        Label3.Text = PRC.WorkingSet64 \ 1024 \ 1024 & " Mb of " & My.Computer.Info.TotalPhysicalMemory \ 1024 \ 1024 & " Mb"
        ProgressBar1.Maximum = My.Computer.Info.TotalPhysicalMemory \ 1024 \ 1024
        ProgressBar1.Value = PRC.WorkingSet64 \ 1024 \ 1024
    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub
    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub
    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Intergrator.RST = True
        Application.Restart()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Intergrator.MO = False
        Intergrator.ToolStripButton1.Image = My.Resources.LED_Red
        Intergrator.tmrMOptimizer.Enabled = False
        Me.Close()
    End Sub

    Private Sub frmMemoryOptimiser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "It appears to be that this application (Fundamental Utilities) is using more than " & Val(Intergrator.MWL) & "Mb on you memory.  This will slow down your computer. And restarting this application will solve this problem. But restarting this application will cause loss of unsaved data on this application. Or you may Switch off the 'Memory Optimizer' and continue working as usual."
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Intergrator.WindowState = FormWindowState.Normal
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Intergrator.RadioButton6.BackgroundImage = My.Resources.tab_Active
        Intergrator.Panel1.Controls.Clear()
        Intergrator.Panel1.Controls.Add(InterOptions.GetInstance())
        Me.Hide()

    End Sub
End Class