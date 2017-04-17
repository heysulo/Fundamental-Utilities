Public Class frmVirtualMonitor
    Public Shared Image As Image
    Public MS As Boolean
#Region " Global Variables "
    Dim Point As New System.Drawing.Point()
    Dim X, Y As Integer
#End Region

#Region " GUI "

    Private Sub frmVirtualMonitor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MS = True Then
            Intergrator.MO = True
            Intergrator.tmrMOptimizer.Enabled = True
            Intergrator.ToolStripButton1.Image = My.Resources.LED_Green
        End If
    End Sub
    Private Sub Form_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Location.Y < 50 Then
            If e.Button = MouseButtons.Left Then
                Point = Control.MousePosition
                Point.X = Point.X - (X)
                Point.Y = Point.Y - (Y)
                Me.Location = Point
            End If
        End If

    End Sub

    Private Sub Form_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub
#End Region
    Shared Function GetDesktopImage(Optional ByVal Width As Integer = 0, Optional ByVal Height As Integer = 0, Optional ByVal ShowCursor As Boolean = True) As Image
        Dim DesktopBitmap As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(DesktopBitmap)
        g.CopyFromScreen(0, 0, 0, 0, New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), CopyPixelOperation.SourceCopy)
        If ShowCursor Then Cursors.Default.Draw(g, New Rectangle(Cursor.Position, New Size(32, 32)))
        DesktopBitmap = DesktopBitmap.GetThumbnailImage(320, 240, Nothing, IntPtr.Zero)
        g.Dispose()
        If Width = 0 And Height = 0 Then
            Image = DesktopBitmap
            Return DesktopBitmap
        Else
            Dim ScaledBitmap As Image = DesktopBitmap.GetThumbnailImage(Width, Height, Nothing, IntPtr.Zero)
            DesktopBitmap.Dispose()
            Image = ScaledBitmap
            Return ScaledBitmap
        End If
        DesktopBitmap.Dispose()
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GetDesktopImage()
        PictureBox1.Image = Image
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources.BCL
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.BSN
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub frmVirtualMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class