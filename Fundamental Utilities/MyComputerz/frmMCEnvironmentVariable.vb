Public Class frmMCEnvironmentVariable

    Private Sub frmMCEnvironmentVariable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim X As System.Collections.Hashtable
        X = Environment.GetEnvironmentVariables
        For Each S As DictionaryEntry In X
            With ListView1.Items.Add(S.Key)
                .SubItems.Add(S.Value())
            End With
        Next
    End Sub
End Class