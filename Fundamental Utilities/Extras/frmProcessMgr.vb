Public Class frmProcessMgr

    Private Sub PLS()
        lblStatus.Text = "Updaing Process List"
        ListView1.Items.Clear()
        Dim PL() As System.Diagnostics.Process
        PL = System.Diagnostics.Process.GetProcesses()
        If CheckBox1.Checked = True Then
            For Each PC As System.Diagnostics.Process In PL
                Application.DoEvents()
                ListView1.View = View.Details
                lblStatus.Text = "Recieving details of " & PC.ProcessName
                With ListView1.Items.Add(PC.ProcessName, 0)
                    On Error Resume Next
                    If (PC.PagedMemorySize64) \ 1024 = Nothing Then
                        .SubItems.Add("Not Available")
                    Else
                        .SubItems.Add((PC.WorkingSet64 \ 1024 \ 1024 & " Mb"))
                    End If
                    If PC.Responding = Nothing Then
                        .SubItems.Add("Not Available")
                    Else
                        .SubItems.Add(PC.Responding.ToString)
                    End If
                End With
            Next
        Else
            For Each PC As System.Diagnostics.Process In PL
                Application.DoEvents()
                ListView1.View = View.List
                lblStatus.Text = "New ID Recieved : " & PC.ProcessName
                ListView1.Items.Add(PC.ProcessName, 5)
            Next
        End If
        lblStatus.Text = "Ready"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PLS()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim BNS As String
        Dim FAI As Boolean
        Dim REP As String
        REP = Nothing
        BNS = Nothing
        FAI = False
        If ListView1.SelectedItems.Count <= 0 Then
            Exit Sub
        End If
        For Each ITM As Windows.Forms.ListViewItem In ListView1.SelectedItems
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim FREE As Long
        Dim USED As Long
        Dim TOTAL As Long
        Dim PFREE As Long
        Dim PUSED As Long
        Dim PTOTAL As Long
        FREE = My.Computer.Info.AvailablePhysicalMemory \ 1024 \ 1024
        TOTAL = My.Computer.Info.TotalPhysicalMemory \ 1024 \ 1024
        USED = TOTAL - FREE
        PFREE = My.Computer.Info.AvailableVirtualMemory \ 1024 \ 1024
        PTOTAL = My.Computer.Info.TotalVirtualMemory \ 1024 \ 1024
        PUSED = PTOTAL - PFREE
        lblPFree.Text = PFREE
        lblPUsed.Text = PUSED
        lblPTotal.Text = PTOTAL
        lblFree.Text = FREE & " Mb"
        lblUsed.Text = USED & " Mb"
        lblTotal.Text = TOTAL & " Mb"
        ProgressBar2.Maximum = PTOTAL
        ProgressBar2.Value = PUSED
        ProgressBar1.Maximum = TOTAL
        ProgressBar1.Value = USED
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        PLS()
    End Sub

    Private Sub frmProcessMgr_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmMCServicesAndProcesses.Visible = False Then
            Intergrator.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class