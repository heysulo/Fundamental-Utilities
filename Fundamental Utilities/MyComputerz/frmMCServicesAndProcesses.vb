Imports System.ServiceProcess

Public Class frmMCServicesAndProcesses
    Private SC As ServiceController
    Private CTRL As New System.Collections.Generic.SortedList(Of String, ServiceController)
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

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        BN()
    End Sub
    Private Sub BN()
        Dim strName As String
        Try
            If ListView1.SelectedItems.Count = 1 Then
                strName = ListView1.SelectedItems(0).SubItems(0).Text
                SC = CTRL.Item(strName)
                With SC
                    lblSTS.Text = "Service " & .DisplayName & " Selected."
                    If .Status = ServiceControllerStatus.Stopped Then
                        cmdStart.Enabled = True
                    End If
                    If .CanStop AndAlso (Not .Status = ServiceControllerStatus.Stopped) Then
                        cmdStop.Enabled = True
                    End If
                    cmdPause.Enabled = (.CanPauseAndContinue AndAlso (Not .Status = ServiceControllerStatus.Paused))
                    If .Status = ServiceControllerStatus.Paused Then
                        cmdResume.Enabled = True
                    End If
                End With
            End If
        Catch exp As Exception
            MsgBox("Cannot update UI.", MsgBoxStyle.OkOnly, Me.Text)
        End Try
        ToolStripProgressBar1.Value = 0
    End Sub
    Private Sub EN()
        Dim services As ServiceController() = ServiceController.GetServices()
        lblSTS.Text = "Refeshing Services."
        Try
            Me.ListView1.Items.Clear()
            If CTRL IsNot Nothing Then
                CTRL = New Generic.SortedList(Of String, ServiceController)
            End If
            For Each OBJ As ServiceController In services
                With ListView1.Items.Add(OBJ.DisplayName, 3)
                    .SubItems.Add(OBJ.ServiceName())
                    .SubItems.Add(OBJ.Status.ToString())
                    .SubItems.Add(OBJ.ServiceType.ToString())
                    .SubItems.Add(OBJ.CanShutdown())
                    .SubItems.Add(OBJ.CanPauseAndContinue())
                End With
                CTRL.Add(OBJ.DisplayName, OBJ)
            Next
        Catch exp As Exception
            MsgBox("Unable Enumerate the services.", MsgBoxStyle.Critical)
            lblSTS.Text = "Enumirating Services Failed."
        Finally
            lblSTS.Text = "Enumirating Services Successed."
        End Try
        cmdPause.Enabled = False
        cmdResume.Enabled = False
        cmdStart.Enabled = False
        cmdStop.Enabled = False
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        EN()
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        Try
            SC.Start()
            RFS()
        Catch exp As Exception
            MsgBox("Unabled to start service.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub cmdPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPause.Click
        Try
            SC.Pause()
            RFS()
        Catch exp As Exception
            MsgBox("Unabled to Pause service.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub cmdResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResume.Click
        Try
            SC.Continue()
            RFS()
        Catch exp As Exception
            MsgBox("Unabled to Resume service.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        Try
            SC.Stop()
            RFS()
        Catch exp As Exception
            MsgBox("Unabled to  start service.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
    Private Sub RFS()
        Dim X As Integer = 0
        Try
            ToolStripStatusLabel1.Text = "Checking Service Status . . "
            Dim item As ListViewItem
            For Each item In ListView1.Items
                SC = CTRL.Item(item.Text)
                SC.Refresh()
                item.SubItems(2).Text = SC.Status.ToString()
            Next item
            Do Until X >= 100
                If X >= 100 Then
                    ToolStripProgressBar1.Value = 0
                    GoTo KM
                End If
                X = X + 1
                ToolStripProgressBar1.Value = ToolStripProgressBar1.Value + 1
                Application.DoEvents()
                System.Threading.Thread.Sleep(25)
            Loop
KM:
            ToolStripProgressBar1.Value = 0
            EN()
        Catch exp As Exception
            MessageBox.Show(exp.Message, exp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ToolStripStatusLabel1.Text = "Ready"
        End Try
    End Sub

    Private Sub frmMCServicesAndProcesses_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmProcessMgr.Visible = False Then
            Intergrator.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub frmMCServicesAndProcesses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EN()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub PLS()
        lblStatus.Text = "Updating Processes List"
        ListView2.Visible = False
        ProgressBar1.Visible = True
        Label1.Visible = True
        Dim PL() As System.Diagnostics.Process
        PL = System.Diagnostics.Process.GetProcesses()
        ProgressBar1.Maximum = PL.Length
        ListView2.Items.Clear()
        For Each PC As System.Diagnostics.Process In PL
            Application.DoEvents()
            With ListView2.Items.Add(PC.ProcessName, 0)
                On Error Resume Next
                lblStatus.Text = "Please wait !!! Retriving details of " & PC.ProcessName
                If PC.PriorityClass.ToString = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.PriorityClass.ToString)
                End If
                If (PC.PeakVirtualMemorySize64) \ 1024 = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add((PC.PeakVirtualMemorySize64) \ 1024 & " K")
                End If
                If PC.HandleCount = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.HandleCount)
                End If
                If PC.Id = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.Id)
                End If
                If PC.Modules.Count = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.Modules.Count)
                End If
                If PC.MainWindowTitle.Length = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.MainWindowTitle)
                End If
                If PC.Responding = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.Responding)
                End If
                If PC.Threads.Count = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.Threads.Count)
                End If
                If PC.BasePriority = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.BasePriority)
                End If
                If PC.EnableRaisingEvents = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.EnableRaisingEvents)
                End If
                If PC.MainModule.FileName = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.MainModule.FileName)
                End If
                If PC.MainModule.FileVersionInfo.CompanyName = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.MainModule.FileVersionInfo.CompanyName)
                End If
                If PC.MainModule.FileVersionInfo.FileVersion = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.MainModule.FileVersionInfo.FileVersion)
                End If
                If PC.MainModule.FileVersionInfo.ProductName = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.MainModule.FileVersionInfo.ProductName)
                End If
                If PC.SessionId = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.SessionId)
                End If
                If PC.StartTime = Nothing Then
                    .SubItems.Add("Not Available")
                Else
                    .SubItems.Add(PC.StartTime)
                End If
            End With
            ProgressBar1.Value = ProgressBar1.Value + 1
        Next
        ListView2.Visible = True
        Label1.Visible = False
        lblStatus.Text = "Ready"
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        PLS()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim BNS As String
        Dim FAI As Boolean
        Dim REP As String
        REP = Nothing
        BNS = Nothing
        FAI = False
        If ListView2.SelectedItems.Count <= 0 Then
            Exit Sub
        End If
        For Each ITM As Windows.Forms.ListViewItem In ListView2.SelectedItems
            On Error GoTo ERRH
            BNS = ITM.Text
            Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName(BNS)
            For Each proc As System.Diagnostics.Process In pList
                Dim resp As MsgBoxResult
                resp = MsgBox("WARNING: Terminating a process can cause undesired" & vbCrLf & "results including loss of data and system instability. The" & vbCrLf & "process will not be given the chance to save its state or " & vbCrLf & "data before it is terminated." & vbCrLf & vbCrLf & "Are you sure that you want to terminate the process :" & vbCrLf & proc.ProcessName, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "ToolBox Warning")
                If resp = MsgBoxResult.Yes Then
                    proc.Kill()
                    If FAI = False Then
                        REP = REP & BNS & ": Terminated" & vbCrLf
                    End If
                Else
                    Exit Sub
                End If
            Next
        Next
        GoTo CLEAN
ERRH:
        MsgBox("Error Occured while terminating " & BNS & vbCrLf & vbCrLf & ErrorToString(), MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, "Error Occured")
        REP = REP & BNS & ": " & ErrorToString() & vbCrLf
        Resume Next
CLEAN:
        MsgBox(REP, MsgBoxStyle.Information, "Task Completed")
        PLS()
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            PLS()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmProcessMgr.Show()
    End Sub
End Class