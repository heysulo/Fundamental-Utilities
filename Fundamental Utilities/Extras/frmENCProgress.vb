Public Class frmENCProgress

    Private Sub frmENCProgress_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmTextEncrypter.ABT = True
    End Sub

    Private Sub frmENCProgress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmTextEncrypter.ABT = False
    End Sub
End Class