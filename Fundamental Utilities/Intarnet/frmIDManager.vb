Imports Microsoft.Win32
Public Class frmIDManager
    Dim Dbusy As Boolean
    Public CI As String
    Public FN As String
    Public DES As String
    Public UN As String
    Public PS As String
    Public TM As Integer
    Public Ad As Boolean
    Dim TFile As Integer
    Dim DFile As Integer
    Dim Source As Uri
    Dim Downloadz As New Net.WebClient
    Dim Trimer As IntPtr
    Dim DLSpeed As Integer
    Dim CBytes As Long
    Dim PBytes As Long
    Dim IniTime As Long
    Dim elapsedTime As TimeSpan
    Dim DLStarted As Boolean = False

    Sub Setup()
        Try
            AddHandler Downloadz.DownloadProgressChanged, AddressOf getDownloadProgress
            AddHandler Downloadz.DownloadFileCompleted, AddressOf downloadHasEnded
            AddHandler SystemEvents.TimerElapsed, AddressOf downloadUpdating
        Catch exc As Exception
            MsgBox(exc.Message, MsgBoxStyle.Critical, "Error Occured in Seting up Event Handlers")
        End Try
    End Sub

    Sub downloadUpdating(ByVal sender As Object, ByVal e As Microsoft.Win32.TimerElapsedEventArgs)
        Dim TLeft As Integer
        Dim DSP As Integer
        lblStatus.Text = "Downloading..."
        Try
            elapsedTime = TimeSpan.FromTicks((Now.Ticks - IniTime))
            lblElapsedTime.Text = "Elapsed Time: " & String.Format("{0:00}:{1:00}:{2:00}", elapsedTime.TotalHours, elapsedTime.Minutes, elapsedTime.Seconds)
            DLSpeed = (CBytes - PBytes)
            lblSpeed.Text = DLSpeed \ 1024 & " KB/s"
            DSP = DLSpeed \ 1024
            PBytes = CBytes
            TLeft = TFile - DFile
            TLeft = TLeft / DSP
            lblTLeft.Text = TLeft & " second(s)"
        Catch exc As Exception

        End Try

    End Sub
    Sub doDownload()

        Try
            Downloadz.DownloadFileAsync(Source, DES & "\" & FN)
            lblStatus.Text = "Downloading..."
            DLStarted = True
            btnCancel.Enabled = True
        Catch exc As Exception
            DLStarted = False
            MsgBox(exc.Message, MsgBoxStyle.Critical, "Error Occured in Downloading")
        End Try

    End Sub
    Sub downloadHasEnded(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim file As System.IO.StreamWriter
        Try
            If e.Cancelled Then
                lblStatus.Text = "Canceled by the user"
            Else
                lblStatus.Text = "Download Completed"
            End If
            btnCancel.Enabled = False
            If Trimer.ToInt32 > 0 Then
                SystemEvents.KillTimer(Trimer)
                Trimer = Nothing
            End If
        Catch exc As Exception
            MsgBox(exc.Message, MsgBoxStyle.Critical, "Error Occured in finalizing the download")
        End Try
        file = My.Computer.FileSystem.OpenTextFileWriter(DES & "\Log.txt", True)
        file.WriteLine("√ ►► " & FN & vbCrLf & "      " & CI & vbCrLf)
        file.Close()
    End Sub
    Sub getDownloadProgress(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Try
            pbDownloadProgress.Value = e.ProgressPercentage
            TFile = e.TotalBytesToReceive \ 1024
            DFile = e.BytesReceived \ 1024
            lblProgress.Text = e.ProgressPercentage.ToString & "%"
            lblDownloaded.Text = e.BytesReceived \ 1024 & " KB"
            lblDFileSize.Text = e.TotalBytesToReceive \ 1000 & " KB"
            CBytes = e.BytesReceived
        Catch exc As Exception

        End Try

    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            If Trimer.ToInt32 > 0 Then
                SystemEvents.KillTimer(Trimer)
                Trimer = Nothing
            End If
            Downloadz.CancelAsync()
        Catch exc As Exception
            MsgBox(exc.Message, MsgBoxStyle.Critical, "Error Occured at canceling the download request")
        End Try

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

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        If ListBox1.SelectedItems.Count > 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
            MsgBox("Nothing is selected", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmIDManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DES = My.Computer.FileSystem.SpecialDirectories.Desktop
        frmDownloadOptions.Show()
        Try
            setup()
        Catch exc As Exception
            MsgBox(exc.Message, MsgBoxStyle.Critical, "Error Occured at initializing Event Handlers")
        End Try

    End Sub

    Private Sub chkdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdown.Click
        If chkdown.Checked = True Then
            chkdown.Checked = False
            chkdown.Text = "Download-OFF"
            tmrDownloader.Enabled = False
            chkdown.Image = My.Resources.LED_Red
        Else
            chkdown.Checked = True
            chkdown.Text = "Download-ON"
            tmrDownloader.Enabled = True
            chkdown.Image = My.Resources.LED_Green
        End If
    End Sub

    Private Sub tmrDownloader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDownloader.Tick
        If My.Computer.Network.IsAvailable = False Then
            lblStatus.Text = "Network Connections are Unavailable"
            Exit Sub
        End If
        If Downloadz.IsBusy = False Then
            If ListBox1.Items.Count > 0 Then
                CI = ListBox1.Items.Item(0)
                ListBox1.Items.RemoveAt(0)
                FN = IO.Path.GetFileName(CI)
                txtDownloadAddress.Text = CI
                Try
                    Source = New Uri(txtDownloadAddress.Text)
                    Trimer = SystemEvents.CreateTimer((1000))
                    doDownload()
                    IniTime = Now.Ticks
                    CBytes = 0
                    PBytes = 0
                    DLSpeed = 0
                    pbDownloadProgress.Value = 0
                    lblStatus.Text = "Connecting..."
                Catch exc As Exception
                    MsgBox(exc.Message, MsgBoxStyle.Critical, "Error Occured at Initializing the Download")
                End Try
            Else
                lblStatus.Text = "Ready"
            End If
        End If
    End Sub


    Private Sub NewItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewItemToolStripMenuItem.Click
        frmNewDownload.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        frmDownloadOptions.Show()
        frmDownloadOptions.PC = True
    End Sub

    Private Sub frmIDManager_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub
End Class