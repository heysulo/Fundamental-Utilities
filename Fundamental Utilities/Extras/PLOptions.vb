Public Class PLOptions

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For Each IT As String In ListBox1.Items
            If frmINTGoogleID.Pendinglist.Items.Contains(IT) = False Then
                frmINTGoogleID.Pendinglist.Items.Add(IT)
            End If
        Next
        ListBox1.Items.Clear()
        frmINTGoogleID.ListBox2.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmINTGoogleID.ListBox2.Items.Clear()
        For Each IT As String In ListBox1.Items
            If frmINTGoogleID.ListBox2.Items.Contains(IT) = False Then
                frmINTGoogleID.ListBox2.Items.Add(IT)
            End If
        Next
        Me.Close()
    End Sub

    Private Sub PLOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each IT As String In frmINTGoogleID.ListBox2.Items
            ListBox1.Items.Add(IT)
        Next
    End Sub
End Class