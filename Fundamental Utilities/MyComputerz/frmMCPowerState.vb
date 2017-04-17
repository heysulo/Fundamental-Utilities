Public Class frmMCPowerState

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FS As Boolean
        Dim RS As Boolean
        If CheckBox1.Checked = True Then
            FS = True
        Else
            FS = False
        End If
        If CheckBox2.Checked = True Then
            RS = True
        Else
            RS = False
        End If
        If RadioButton1.Checked = True Then
            Application.SetSuspendState(PowerState.Hibernate, FS, RS)
        Else
            Application.SetSuspendState(PowerState.Suspend, FS, RS)
        End If
    End Sub
    Private Sub frmMCPowerState_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
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
End Class