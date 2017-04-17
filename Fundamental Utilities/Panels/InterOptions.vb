Public Class InterOptions
    Private Shared panelInstance As InterOptions
    Dim WD As String
    Public Shared Function GetInstance() As InterOptions
        If (panelInstance Is Nothing) Then
            panelInstance = New InterOptions
        End If
        Return panelInstance
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim PRC As Process
        PRC = Diagnostics.Process.GetCurrentProcess
        Label3.Text = PRC.WorkingSet64 \ 1024 \ 1024 & " Mb of " & My.Computer.Info.TotalPhysicalMemory \ 1024 \ 1024 & " Mb"
        ProgressBar1.Maximum = My.Computer.Info.TotalPhysicalMemory \ 1024 \ 1024
        ProgressBar1.Value = PRC.WorkingSet64 \ 1024 \ 1024
        lblPtime.Text = PRC.TotalProcessorTime.TotalSeconds & " seconds"
        Label6.Text = PRC.UserProcessorTime.TotalSeconds & " seconds"
        Label8.Text = PRC.Threads.Count
        Label10.Text = PRC.StartTime
        Label12.Text = IO.Path.GetFileName(PRC.MainModule.FileName)
        WD = PRC.MainModule.FileName
        WD = WD.Remove(WD.Length - Label12.Text.Length, Label12.Text.Length)
        Label14.Text = PRC.SessionId
        Label16.Text = PRC.PriorityClass.ToString
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        On Error Resume Next
        Process.Start(IO.Path.GetFullPath(WD))
    End Sub
    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button1.BackgroundImage = My.Resources.layerbutton_Hover
    End Sub
    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button2.BackgroundImage = My.Resources.layerbutton_Hover
    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
        Button6.BackgroundImage = My.Resources.layerbutton_Hover
    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub
    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub
    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Intergrator.RST = True
        frmRestarting.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmTaskMgr.Show()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Intergrator.MWL = NumericUpDown1.Value
        On Error Resume Next
        frmMemoryOptimiser.Close()
    End Sub

    Private Sub InterOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDown1.Value = Val(Intergrator.MWL)
    End Sub
End Class
