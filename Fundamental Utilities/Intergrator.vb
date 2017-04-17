Public Class Intergrator
    Public MO As Boolean
    Public RST As Boolean
    Public STP As Boolean
    Public MWL As Integer
#Region " Global Variables "
    Dim Point As New System.Drawing.Point()
    Dim X, Y As Integer
#End Region

#Region " GUI "

    Private Sub Intergrator_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If RST = True Then
            frmRestarting.Show()
        End If
    End Sub
    Private Sub Form_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Location.Y < 50 Then
            If e.Button = MouseButtons.Left Then
                Point = Control.MousePosition
                Point.X = Point.X - (X)
                Point.Y = Point.Y - (Y)
                Me.Location = Point
            End If
        End If

    End Sub

    Private Sub Form_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub
#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        For Each FRM As Form In Application.OpenForms
            FRM.Hide()
        Next
        My.Computer.Audio.Play(My.Resources.sfx_Logoff, AudioPlayMode.Background)
        ExitingFU.Show()
    End Sub

    Private Sub btnClose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter
        btnClose.Image = My.Resources.close_hover
    End Sub

    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        btnClose.Image = My.Resources.close_normal
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMinimize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseEnter
        btnMinimize.Image = My.Resources.minimize_hover
    End Sub

    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.Image = My.Resources.minimize_normal
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
            RadioButton1.BackgroundImage = My.Resources.tab_Active
            Panel1.Controls.Clear()
            Panel1.Controls.Add(MainUtilities.GetInstance())
        Else
            RadioButton1.BackgroundImage = My.Resources.tab_Normal
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
            RadioButton2.BackgroundImage = My.Resources.tab_Active
            Panel1.Controls.Clear()
            Panel1.Controls.Add(FileSyztem.GetInstance())
        Else
            RadioButton2.BackgroundImage = My.Resources.tab_Normal
        End If

    End Sub

    Private Sub RadioButton2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.MouseEnter
        If RadioButton2.Checked = False Then
            RadioButton2.BackgroundImage = My.Resources.tab_Hover
        End If
    End Sub

    Private Sub RadioButton2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.MouseLeave
        If RadioButton2.Checked = True Then
            RadioButton2.BackgroundImage = My.Resources.tab_Active
        Else
            RadioButton2.BackgroundImage = My.Resources.tab_Normal
        End If
    End Sub

    Private Sub RadioButton1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.MouseEnter
        If RadioButton1.Checked = False Then
            RadioButton1.BackgroundImage = My.Resources.tab_Hover
        End If
    End Sub

    Private Sub RadioButton1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.MouseLeave
        If RadioButton1.Checked = True Then
            RadioButton1.BackgroundImage = My.Resources.tab_Active
        Else
            RadioButton1.BackgroundImage = My.Resources.tab_Normal
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
            RadioButton3.BackgroundImage = My.Resources.tab_Active
            Panel1.Controls.Clear()
            Panel1.Controls.Add(MyComputerz.GetInstance())
        Else
            RadioButton3.BackgroundImage = My.Resources.tab_Normal
        End If

    End Sub

    Private Sub RadioButton3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.MouseEnter
        If RadioButton3.Checked = False Then
            RadioButton3.BackgroundImage = My.Resources.tab_Hover
        End If
    End Sub

    Private Sub RadioButton3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.MouseLeave
        If RadioButton3.Checked = True Then
            RadioButton3.BackgroundImage = My.Resources.tab_Active
        Else
            RadioButton3.BackgroundImage = My.Resources.tab_Normal
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
            RadioButton4.BackgroundImage = My.Resources.tab_Active
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Internetz.GetInstance())
        Else
            RadioButton4.BackgroundImage = My.Resources.tab_Normal
        End If

    End Sub

    Private Sub RadioButton4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.MouseEnter
        If RadioButton4.Checked = False Then
            RadioButton4.BackgroundImage = My.Resources.tab_Hover
        End If
    End Sub

    Private Sub RadioButton4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.MouseLeave
        If RadioButton4.Checked = True Then
            RadioButton4.BackgroundImage = My.Resources.tab_Active
        Else
            RadioButton4.BackgroundImage = My.Resources.tab_Normal
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
            RadioButton5.BackgroundImage = My.Resources.tab_Active
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Entertainmentz.GetInstance())
        Else
            RadioButton5.BackgroundImage = My.Resources.tab_Normal
        End If

    End Sub

    Private Sub RadioButton5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.MouseEnter
        If RadioButton5.Checked = False Then
            RadioButton5.BackgroundImage = My.Resources.tab_Hover
        End If
    End Sub

    Private Sub RadioButton5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.MouseLeave
        If RadioButton5.Checked = True Then
            RadioButton5.BackgroundImage = My.Resources.tab_Active
        Else
            RadioButton5.BackgroundImage = My.Resources.tab_Normal
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
            RadioButton6.BackgroundImage = My.Resources.tab_Active
            Panel1.Controls.Clear()
            Panel1.Controls.Add(InterOptions.GetInstance())
        Else
            RadioButton6.BackgroundImage = My.Resources.tab_Normal
        End If

    End Sub

    Private Sub RadioButton6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.MouseEnter
        If RadioButton6.Checked = False Then
            RadioButton6.BackgroundImage = My.Resources.tab_Hover
        End If
    End Sub

    Private Sub RadioButton6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.MouseLeave
        If RadioButton6.Checked = True Then
            RadioButton6.BackgroundImage = My.Resources.tab_Active
        Else
            RadioButton6.BackgroundImage = My.Resources.tab_Normal
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
            RadioButton7.BackgroundImage = My.Resources.tab_Active
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Aboutz.GetInstance())
        Else
            RadioButton7.BackgroundImage = My.Resources.tab_Normal
        End If
    End Sub

    Private Sub RadioButton7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton7.MouseEnter
        If RadioButton7.Checked = False Then
            RadioButton7.BackgroundImage = My.Resources.tab_Hover
        End If
    End Sub

    Private Sub RadioButton7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton7.MouseLeave
        If RadioButton7.Checked = True Then
            RadioButton7.BackgroundImage = My.Resources.tab_Active
        Else
            RadioButton7.BackgroundImage = My.Resources.tab_Normal
        End If
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = My.Resources.bg_TaskmgrHover
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.bg_TaskmgrNormal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmTaskMgr.Show()
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackgroundImage = My.Resources.bg_TaskmgrHover
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.bg_TaskmgrNormal
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MO = True Then
            MO = False
            ToolStripButton1.Image = My.Resources.LED_Red
            tmrMOptimizer.Enabled = False
            MsgBox("While using Virtual Monitor the Memory Optimzer will be turned off and will automatically activated when the gadget is closed !!!", MsgBoxStyle.Information, "Memory Optimzer")
        End If
        frmVirtualMonitor.Show()
    End Sub
    Private Sub Intergrator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.sfx_Logon, AudioPlayMode.Background)
        STP = True
        MWL = 100
        MO = True
    End Sub

    Private Sub tmrMOptimizer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMOptimizer.Tick
        Dim PRC As Process
        PRC = Diagnostics.Process.GetCurrentProcess
        If PRC.WorkingSet64 \ 1024 \ 1024 > Val(MWL) Then
            If frmMemoryOptimiser.Visible = False Then
                frmMemoryOptimiser.Show()
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.CheckedChanged
        If MO = True Then
            MO = False
            ToolStripButton1.Image = My.Resources.LED_Red
            tmrMOptimizer.Enabled = False
            If STP = True Then
                MsgBox("Memory Optimizer deactivated !!!", MsgBoxStyle.Information, "Memory Optimizer")
            End If
        Else
            MO = True
            tmrMOptimizer.Enabled = True
            ToolStripButton1.Image = My.Resources.LED_Green
            If STP = True Then
                MsgBox("Memory Optimizer activated !!!", MsgBoxStyle.Information, "Memory Optimizer")
            End If
        End If
        STP = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = "      " & Now.ToLongTimeString
        Label2.Text = "      " & Now.ToLongDateString
        Dim BI As PowerStatus
        BI = System.Windows.Forms.SystemInformation.PowerStatus
        If BI.BatteryChargeStatus = BatteryChargeStatus.Charging Then
            Label3.Text = "      Battery : Charging"
            Label3.Image = My.Resources.ico_BatteryCharging
        ElseIf BI.BatteryChargeStatus = BatteryChargeStatus.Critical Then
            Label3.Text = "      Battery : Critical"
            Label3.Image = My.Resources.ico_BatteryLow
        ElseIf BI.BatteryChargeStatus = BatteryChargeStatus.High Then
            Label3.Text = "      Battery : High"
            Label3.Image = My.Resources.ico_BatteryFull
        ElseIf BI.BatteryChargeStatus = BatteryChargeStatus.Low Then
            Label3.Image = My.Resources.ico_BatteryNormal
            Label3.Text = "      Battery : Low"
        ElseIf BI.BatteryChargeStatus = BatteryChargeStatus.NoSystemBattery Then
            Label3.Text = "      Battery : No Battery"
            Label3.Image = My.Resources.ico_Plug
        ElseIf BI.BatteryChargeStatus = BatteryChargeStatus.Unknown Then
            Label3.Image = My.Resources.ico_risky
            Label3.Text = "      Battery : Unknown"
        End If
        If My.Computer.Network.IsAvailable = True Then
            lblNetwork.Text = "      Connected"
            lblNetwork.Image = My.Resources.ico_SingnalFull
        Else
            lblNetwork.Text = "      Not connected"
            lblNetwork.Image = My.Resources.ico_SingnalNone
        End If
    End Sub
End Class