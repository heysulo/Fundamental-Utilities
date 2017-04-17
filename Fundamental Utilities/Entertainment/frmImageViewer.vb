Public Class frmImageViewer
    Dim FL As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Flist As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FL = FolderBrowserDialog1.SelectedPath
            ListBox1.Items.Clear()
            Flist = My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath, FileIO.SearchOption.SearchTopLevelOnly)
            For Each proc As String In Flist
                ListBox1.Items.Add(IO.Path.GetFileName(proc))
            Next
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim IMG As Image
        On Error Resume Next
        IMG = Image.FromFile(FL & "\" & ListBox1.SelectedItem.ToString)
        If IMG.Height > PictureBox2.Height Then
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        Else
            If IMG.Width > PictureBox2.Width Then
                PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            Else
                PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
            End If
        End If
        PictureBox2.ImageLocation = FL & "\" & ListBox1.SelectedItem.ToString
        Me.Text = "Image Viewer " & FL & "\" & ListBox1.SelectedItem.ToString
        Label8.Text = PictureBox2.Image.PhysicalDimension.ToString
        Label9.Text = PictureBox2.Image.PixelFormat.ToString
        Label9.Text = Label9.Text.Replace("Format", "")
        Label10.Text = PictureBox2.Image.RawFormat.ToString
        Label10.Text = Label10.Text.Replace("ImageFormat", "")
        Label11.Text = PictureBox2.Image.Height
        Label12.Text = PictureBox2.Image.Width
    End Sub

    Private Sub frmImageViewer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub
End Class