Public Class Preview
    Public URD As String
    Dim TP As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = TP / 100
        If TP = 100 Then
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
        TP = TP + 2
    End Sub

    Private Sub Preview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TP = 0
        Me.SetBounds(My.Computer.Screen.WorkingArea.Width - Me.Width, My.Computer.Screen.WorkingArea.Height - Me.Height, Me.Width, Me.Height)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer3.Enabled = True
        Timer2.Enabled = False

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Opacity = TP / 100
        If TP <= 0 Then
            Timer3.Enabled = False
            Me.Close()
        End If
        TP = TP - 2
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        frmINTGoogleID.Pendinglist.Items.Add(URD)
        My.Computer.FileSystem.DeleteFile(PictureBox1.ImageLocation, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Timer3.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        System.Diagnostics.Process.Start(PictureBox1.ImageLocation)
    End Sub
End Class