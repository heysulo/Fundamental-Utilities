Public Class Aboutz
    Private Shared panelInstance As Aboutz
    

    Public Shared Function GetInstance() As Aboutz
        If (panelInstance Is Nothing) Then
            panelInstance = New Aboutz
        End If
        Return panelInstance
    End Function

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackgroundImage = My.Resources.layerbutton_Hover
        My.Computer.Audio.Play(My.Resources.sfx_Navigation, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmLicense.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmTermsofUse.Show()

    End Sub
End Class
