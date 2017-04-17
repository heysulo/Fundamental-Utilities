Public Class frmMCIntTimeZones

    Private Sub frmMCIntTimeZones_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmMCIntTimeZones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TZ As Collections.ObjectModel.ReadOnlyCollection(Of System.TimeZoneInfo)
        TZ = System.TimeZoneInfo.GetSystemTimeZones
        For Each S As TimeZoneInfo In TZ
            ListBox1.Items.Add(S.Id)
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label5.Text = ListBox1.SelectedItem.ToString
        Label6.Text = TimeZoneInfo.FindSystemTimeZoneById(ListBox1.SelectedItem.ToString).ToString
        Label9.Text = TimeZoneInfo.FindSystemTimeZoneById(ListBox1.SelectedItem.ToString).SupportsDaylightSavingTime
        Label7.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Now, ListBox1.SelectedItem.ToString)
        TextBox1.Text = TimeZoneInfo.FindSystemTimeZoneById(ListBox1.SelectedItem.ToString).ToSerializedString
    End Sub
End Class