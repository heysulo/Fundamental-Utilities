﻿Public NotInheritable Class SplashFUWebBrowser

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashFUWebBrowser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        frmINTWebBroweser.Show()
        Me.Close()
    End Sub
End Class
