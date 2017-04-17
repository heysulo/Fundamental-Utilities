Public Class frmDownloadOptions
    Public PC As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) = True Then
            frmIDManager.DES = TextBox1.Text
            If CheckBox1.Checked = True Then
                frmIDManager.Ad = True
                frmIDManager.UN = TextBox2.Text
                frmIDManager.PS = TextBox3.Text
                frmIDManager.TM = NumericUpDown1.Value
            Else
                frmIDManager.Ad = False
            End If
            PC = True
            Me.Close()
        End If
    End Sub

    Private Sub frmDownloadOptions_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If PC = False Then
            e.Cancel = True
            MsgBox("Please Configure the settings and press *Apply*", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub frmDownloadOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = frmIDManager.DES
        PC = False
        If frmIDManager.Ad = True Then
            CheckBox1.Checked = True
            TextBox2.Text = frmIDManager.UN
            TextBox3.Text = frmIDManager.PS
            NumericUpDown1.Value = frmIDManager.TM
        Else
            CheckBox1.Checked = False
        End If
    End Sub
End Class