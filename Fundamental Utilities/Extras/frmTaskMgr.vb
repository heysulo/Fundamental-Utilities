Public Class frmTaskMgr
    Dim SF As Form
    Dim VL As FormCollection
    Private Sub frmTaskMgr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each FRM As Form In Application.OpenForms
            With ListView1.Items.Add(FRM.Text, 0)
                .SubItems.Add(FRM.Name)
                .SubItems.Add(FRM.Visible)
                .SubItems.Add(FRM.TopMost)
            End With
        Next
        VLP()
    End Sub
    Private Sub VLP()
        VL = Nothing
        VL = Application.OpenForms
        SELECTIONCHANGED()
    End Sub

    Private Sub ListView1_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        Dim ID As Integer
        If ListView1.SelectedItems.Count <= 0 Then
            Exit Sub
        End If
        For Each ID In ListView1.SelectedIndices
            SF = VL.Item(ID)
        Next
        SELECTIONCHANGED()
    End Sub
    Private Sub SELECTIONCHANGED()
        If ListView1.SelectedItems.Count <= 0 Then
            Exit Sub
        End If
        lblTechName.Text = SF.Name
        lblTitle.Text = SF.Text
        TrackBar1.Value = SF.Opacity * 100
        chkShowinTaskbar.Checked = SF.ShowInTaskbar
        chkTopMost.Checked = SF.TopMost
        chkVisible.Checked = SF.Visible
        If SF.Name.ToLower = "frmTaskMgr".ToLower Then
            chkVisible.Enabled = False
            chkTopMost.Enabled = False
            chkShowinTaskbar.Enabled = False
            TrackBar1.Enabled = False
        Else
            chkVisible.Enabled = True
            chkTopMost.Enabled = True
            chkShowinTaskbar.Enabled = True
            TrackBar1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SF.Opacity = TrackBar1.Value / 100
        SF.ShowInTaskbar = chkShowinTaskbar.Checked
        SF.TopMost = chkTopMost.Checked
        SF.Visible = chkVisible.Checked
        REFRESHED()
    End Sub

    Private Sub TrackBar1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.MouseEnter
        Label4.Visible = True
    End Sub

    Private Sub TrackBar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.MouseLeave
        Label4.Visible = False
    End Sub

    Private Sub TrackBar1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseMove
        Label4.Text = TrackBar1.Value & "%"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SF.Close()
        REFRESHED()
    End Sub
    Public Sub REFRESHED()
        ListView1.Items.Clear()
        VL = Nothing
        For Each FRM As Form In Application.OpenForms
            With ListView1.Items.Add(FRM.Text, 0)
                .SubItems.Add(FRM.Name)
                .SubItems.Add(FRM.Visible)
                .SubItems.Add(FRM.TopMost)
            End With
        Next
        VLP()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim S As Integer = Nothing
        Dim W As Integer = Nothing
        For Each X As ListViewItem In ListView1.Items
            S = S + X.Text.Length
        Next
        For Each Y As Form In Application.OpenForms
            W = W + Y.Text.Length
        Next
        If S <> W Then
            REFRESHED()
        End If
    End Sub
End Class