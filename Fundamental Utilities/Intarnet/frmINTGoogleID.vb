Public Class frmINTGoogleID
    Dim Image As String
    Dim DITM As String
    Dim DLfile As String
    Dim DURL As String

    Private Sub frmINTGoogleID_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Downloads"
        Me.Width = 742
        BaloonNot.Visible = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub tmrSnapper_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSnapper.Tick
        If CheckBox1.Checked = True Then
            If My.Computer.Clipboard.ContainsText = True Then
                CaptureImage()
            End If
        End If
    End Sub
    Private Sub CaptureImage()
        Dim Imageurl As String
        Dim DLink As String
        Dim Imagename As String
        DLink = ""
        Imageurl = My.Computer.Clipboard.GetText
        If Imageurl.StartsWith("http://") Then
            If Imageurl.Contains("imgurl=") = True And Imageurl.Contains("imgrefurl=") = True Then
                GoTo Google
            End If
        Else
            Exit Sub
        End If
Google:
        Imageurl = Imageurl.Replace("?", vbCrLf)
        Brokenurl.Text = Imageurl.Replace("&", vbCrLf)
        For Each Ditems As String In Brokenurl.Lines
            Urlbreaker.Items.Add(Ditems)
        Next
        For Each Line As String In Urlbreaker.Items
            If Line.StartsWith("imgurl=") = True Then
                DLink = Line
                Exit For
            End If
        Next
        DLink = DLink.Replace("imgurl=", "")
        Imagename = My.Computer.FileSystem.GetName(DLink)
        If Imageurl <> "" Then
            Pendinglist.Items.Add(DLink)
        End If
        If CheckBox4.Checked = True Then
            BaloonNot.ShowBalloonTip(1000, "New D.load Item", Imagename & " added to the Pending list to be Downloaded !!!", ToolTipIcon.Info)
        End If
        GoTo Finalize
Ordinary:
        If Imageurl <> "" Then
            Pendinglist.Items.Add(Imageurl)
        End If
        Imagename = My.Computer.FileSystem.GetName(Imageurl)
        If CheckBox4.Checked = True Then
            BaloonNot.ShowBalloonTip(1000, "New D.load Item", Imagename & " added to the Pending list to be Downloaded !!!", ToolTipIcon.Info)
        End If
        GoTo Finalize
Finalize:
        My.Computer.Clipboard.Clear()
        Brokenurl.Text = ""
        Urlbreaker.Items.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            tmrSnapper.Enabled = True
        Else
            tmrSnapper.Enabled = False
        End If
    End Sub

    Private Sub tmrDownloader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDownloader.Tick
        If bgDownloader.IsBusy = False Then
            If Pendinglist.Items.Count > 0 Then
                Image = Pendinglist.Items.Item(0)
                Pendinglist.Items.RemoveAt(0)
                bgDownloader.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub bgDownloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgDownloader.DoWork
        On Error GoTo Errorhandler
        Dim Filename As String
        Dim file As System.IO.StreamWriter
        Filename = My.Computer.FileSystem.GetName(Image)
        DURL = Image
        If CheckBox2.Checked = True Then
            If My.Computer.FileSystem.DirectoryExists(TextBox2.Text) = False Then
                MkDir(TextBox2.Text)
            End If
            My.Computer.Network.DownloadFile(Image, TextBox2.Text & "\" & Filename, "", "", True, 300, True)
        Else
            If My.Computer.FileSystem.DirectoryExists(TextBox2.Text) = False Then
                MkDir(TextBox2.Text)
            End If
            My.Computer.Network.DownloadFile(Image, TextBox2.Text & "\" & Filename, "", "", False, 300, True)
        End If
        DLfile = TextBox2.Text & "\" & Filename
        file = My.Computer.FileSystem.OpenTextFileWriter(TextBox2.Text & "\Log.txt", True)
        file.WriteLine("√ ►► " & Filename & vbCrLf & "     Download Completed " & vbCrLf & "      " & Image & vbCrLf)
        file.Close()
        DITM = ""
        Exit Sub
Errorhandler:
        If CheckBox4.Checked = True Then
            BaloonNot.ShowBalloonTip(500, "Download Failed", Filename & " downloading failed : " & ErrorToString(), ToolTipIcon.Error)
        End If
        DITM = Image
        file = My.Computer.FileSystem.OpenTextFileWriter(TextBox2.Text & "\Log.txt", True)
        file.WriteLine("Х ►► " & Filename & vbCrLf & "     Download failed : " & ErrorToString() & vbCrLf & "      " & Image & vbCrLf)
        file.Close()
    End Sub

    Private Sub bgDownloader_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgDownloader.RunWorkerCompleted
        If DITM = "" Then
            If CheckBox3.Checked = True Then
                If Preview.Visible = False Then
                    Preview.Show()
                    Preview.PictureBox1.ImageLocation = DLfile
                    Preview.URD = DURL
                Else
                    Preview.Show()
                    Preview.PictureBox1.ImageLocation = DLfile
                    Preview.Timer2.Enabled = False
                    Preview.Timer2.Enabled = True
                    Preview.URD = DURL
                End If
            End If
        Else
            ListBox2.Items.Add(DITM)
        End If
        DITM = ""
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        tmrSnapper.Interval = NumericUpDown1.Value
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        PLOptions.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        NLOptions.Show()
    End Sub
End Class