﻿Public Class frmFSRenameFile
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo ERH
        My.Computer.FileSystem.RenameFile(TextBox1.Text, TextBox2.Text)
        MsgBox("File renamed successfully !!!", MsgBoxStyle.Information, "File Renamed")
        Me.Close()
        Exit Sub
ERH:
        MsgBox(ErrorToString, MsgBoxStyle.Critical, "Error Occured")
    End Sub
    Private Sub btnClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter
        btnClose.Image = My.Resources.BCL
    End Sub

    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        btnClose.Image = My.Resources.BSN
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmFSRenameFile_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub
End Class