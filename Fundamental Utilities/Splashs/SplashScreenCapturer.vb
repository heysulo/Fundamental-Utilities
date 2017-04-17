Public NotInheritable Class SplashScreenCapturer

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreenCapturer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide()
        Timer1.Enabled = False
        MsgBox("Default saving location set to your desktop !!! Change it with he 'Saving Location' button", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Default Saving Location")
        frmScreenCapturer.Show()
        Me.Close()
    End Sub

  
End Class
