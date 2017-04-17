Public Class frmLicense

    Private Sub frmLicense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = Environment.UserName & vbCrLf & My.Computer.Name
        Label5.Text = "Free License"
        RichTextBox1.Rtf = My.Resources.EULA
    End Sub
End Class