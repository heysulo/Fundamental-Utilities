Public Class frmMCComputerStatus

    Private Sub frmMCComputerStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim AA As String
        AA = Nothing
        AA = AA & "Battery Charge Status : " & System.Windows.Forms.SystemInformation.PowerStatus.BatteryChargeStatus.ToString & vbCrLf
        AA = AA & "Battery Full Lifetime : " & System.Windows.Forms.SystemInformation.PowerStatus.BatteryFullLifetime.ToString & vbCrLf
        AA = AA & "Battery Life Percent : " & System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent.ToString & vbCrLf
        AA = AA & "Battery Life Remaining : " & System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifeRemaining.ToString & vbCrLf
        AA = AA & "Power Line Status : " & System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus.ToString
        Label1.Text = AA
    End Sub
End Class