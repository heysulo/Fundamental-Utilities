Public Class frmINTWebBroweser

    Private Sub frmINTWebBroweser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmINTWebBroweser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmINTWebBroweser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtURL.Width = ToolStrip1.Width - 300
        WebBrowser1.GoHome()
    End Sub

    Private Sub frmINTWebBroweser_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        txtURL.Width = ToolStrip1.Width - 300
    End Sub

    Private Sub frmINTWebBroweser_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        txtURL.Width = ToolStrip1.Width - 300
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        WebBrowser1.Navigate(txtURL.Text)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub txtURL_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtURL.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(txtURL.Text)
        End If
    End Sub

    Private Sub WebBrowser1_StatusTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebBrowser1.StatusTextChanged
        lblStatus.Text = WebBrowser1.StatusText
        If lblStatus.Text = Nothing Then
            lblStatus.Text = "Done"
        End If
    End Sub

    Private Sub GoBackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBackToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub GoForwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoForwardToolStripMenuItem.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub GoHomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoHomeToolStripMenuItem.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        WebBrowser1.GoSearch()
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        prgIMG.Image = My.Resources.ico_Check
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        prgIMG.Image = My.Resources.Animation_GreenLoader
        lblStatus.Text = e.Url.AbsoluteUri
        ToolStripProgressBar1.Visible = True
    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        On Error Resume Next
        ToolStripProgressBar1.Maximum = e.MaximumProgress
        ToolStripProgressBar1.Value = e.CurrentProgress
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            WebBrowser1.Navigate(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        WebBrowser1.ShowSaveAsDialog()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        WebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        WebBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        WebBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        WebBrowser1.ShowPropertiesDialog()
    End Sub
    Private Sub ShowInTaskbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowInTaskbarToolStripMenuItem.Click
        If ShowInTaskbarToolStripMenuItem.Checked = True Then
            ShowInTaskbarToolStripMenuItem.Checked = False
            Me.ShowInTaskbar = False
        Else
            ShowInTaskbarToolStripMenuItem.Checked = True
            Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub TopOnMostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopOnMostToolStripMenuItem.Click
        If TopOnMostToolStripMenuItem.Checked = True Then
            TopOnMostToolStripMenuItem.Checked = False
            Me.TopMost = False
        Else
            TopOnMostToolStripMenuItem.Checked = True
            Me.TopMost = True
        End If
    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullScreenToolStripMenuItem.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class