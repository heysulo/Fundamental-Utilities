Public Class NLOptions

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmINTGoogleID.Pendinglist.Items.Clear()
        For Each IT As String In ListBox1.Items
            If frmINTGoogleID.Pendinglist.Items.Contains(IT) = False Then
                frmINTGoogleID.Pendinglist.Items.Add(IT)
            End If
        Next
        Me.Close()
    End Sub
End Class