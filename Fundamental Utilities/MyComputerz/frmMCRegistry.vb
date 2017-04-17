Public Class frmMCRegistry

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo erh
        TextBox2.Text = My.Computer.Registry.GetValue(TextBox1.Text, TextBox3.Text, Nothing)
        Exit Sub
        MsgBox("Task Completed", MsgBoxStyle.Information)
erh:
        MsgBox(ErrorToString, MsgBoxStyle.Critical)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo erh
        My.Computer.Registry.SetValue(TextBox6.Text, TextBox4.Text, TextBox5.Text)
        Exit Sub
erh:
        MsgBox(ErrorToString, MsgBoxStyle.Critical)
    End Sub
End Class