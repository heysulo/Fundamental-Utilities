Public Class frmAlarm

    Dim HH As String
    Dim MM As String
    Dim SS As String
    Dim CT As String
    Dim AT As String
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If NumericUpDown1.Value < 10 Then
            HH = "0" & NumericUpDown1.Value
        Else
            HH = NumericUpDown1.Value
        End If
        If NumericUpDown2.Value < 10 Then
            MM = "0" & NumericUpDown2.Value
        Else
            MM = NumericUpDown2.Value
        End If
        If NumericUpDown3.Value < 10 Then
            SS = "0" & NumericUpDown3.Value
        Else
            SS = NumericUpDown3.Value
        End If
        Timer2.Enabled = True
        CT = TimeString
        AT = HH & ":" & MM & ":" & SS
        Button1.Enabled = False
        NumericUpDown1.Enabled = False
        NumericUpDown2.Enabled = False
        NumericUpDown3.Enabled = False
        TextBox4.Enabled = False
        Label54.Text = "Alarm Clock is SET to " & AT
        My.Computer.Audio.Play(My.Resources.sfx_Ding, AudioPlayMode.Background)
        PictureBox1.Image = My.Resources.ico_SwitchOn
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer2.Enabled = False
        PictureBox1.Image = My.Resources.ico_Switchoff
        Button1.Enabled = True
        Button1.Enabled = True
        NumericUpDown1.Enabled = True
        NumericUpDown2.Enabled = True
        NumericUpDown3.Enabled = True
        TextBox4.Enabled = True
        Label54.Text = "Alarm Canceled"
        My.Computer.Audio.Play(My.Resources.sfx_FeedDiscovered, AudioPlayMode.Background)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        Dim CT As String
        Dim AT As String
        CT = TimeString
        AT = HH & ":" & MM & ":" & SS
        If CT = AT Then
            ALARMRING()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label46.Text = TimeString
        Label47.Text = DateString
    End Sub

    Private Sub ALARMRING()
        My.Computer.Audio.Play(My.Resources.loop_KKid, AudioPlayMode.BackgroundLoop)
        Label54.Text = "Alarm Clock Disabled"
        Timer2.Enabled = False
        MsgBox("The Time is " & TimeString & " and Your Message was: " & TextBox4.Text, MsgBoxStyle.Information)
        My.Computer.Audio.Stop()
        PictureBox1.Image = My.Resources.ico_Switchoff
        Button1.Enabled = True
        NumericUpDown1.Enabled = True
        NumericUpDown2.Enabled = True
        NumericUpDown3.Enabled = True
        TextBox4.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TopOnMostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopOnMostToolStripMenuItem.Click
        If TopOnMostToolStripMenuItem.Checked = True Then
            TopOnMostToolStripMenuItem.Checked = False
            Me.TopMost = False
        Else
            TopOnMostToolStripMenuItem.Checked = True
            Me.TopMost = True
        End If
    End Sub

    Private Sub ShowOnTaskbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowOnTaskbarToolStripMenuItem.Click
        If ShowOnTaskbarToolStripMenuItem.Checked = True Then
            ShowOnTaskbarToolStripMenuItem.Checked = False
            Me.ShowInTaskbar = False
        Else
            ShowOnTaskbarToolStripMenuItem.Checked = True
            Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub frmAlarm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("You can use alarm clock to set important messages, which you should be notified at a specific time.", MsgBoxStyle.Information, "Help")
    End Sub
End Class