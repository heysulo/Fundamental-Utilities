Public Class frmMCReport

    Private Sub frmMCReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TSI As String
        TSI = ""
        Beep()
        TSI = TSI & "Fundamental Utilities System Information Report" & vbCrLf & vbCrLf
        TSI = TSI & "Date :" & DateString & vbCrLf
        TSI = TSI & "Time :" & TimeString & vbCrLf & vbCrLf & vbCrLf
        TSI = TSI & "Computer Name : " & My.Computer.Name & vbCrLf
        TSI = TSI & "Number of Processors : " & Environment.ProcessorCount & vbCrLf
        TSI = TSI & "System Directory : " & Environment.SystemDirectory & vbCrLf
        TSI = TSI & "Operating System : " & My.Computer.Info.OSFullName & vbCrLf
        TSI = TSI & "OS Version : " & My.Computer.Info.OSVersion & vbCrLf
        TSI = TSI & "OS Platform : " & My.Computer.Info.OSPlatform & vbCrLf
        TSI = TSI & "Installed UI Culture : " & My.Computer.Info.InstalledUICulture.ToString & vbCrLf
        TSI = TSI & "UserName : " & Windows.Forms.SystemInformation.UserName & vbCrLf
        TSI = TSI & "Is User Authenticated : " & My.User.IsAuthenticated & vbCrLf
        TSI = TSI & "Number of Drives : " & My.Computer.FileSystem.Drives.Count & vbCrLf
        TSI = TSI & "Total Physical Memory : " & My.Computer.Info.TotalPhysicalMemory & vbCrLf
        TSI = TSI & "Total Virtual Memory : " & My.Computer.Info.TotalVirtualMemory & vbCrLf
        TSI = TSI & "Mouse Wheel Exits : " & My.Computer.Mouse.WheelExists & vbCrLf
        TSI = TSI & "Connected to Network : " & My.Computer.Network.IsAvailable & vbCrLf
        TSI = TSI & "Screen Working Area : " & My.Computer.Screen.WorkingArea.ToString & vbCrLf
        TSI = TSI & "Screen Bit Per Pixel : " & My.Computer.Screen.BitsPerPixel & vbCrLf
        TSI = TSI & "Clock, Tick Count : " & My.Computer.Clock.TickCount & vbCrLf
        TSI = TSI & "Boot Mode" & " : " & Windows.Forms.SystemInformation.BootMode & vbCrLf
        TSI = TSI & "Debug Version Installed" & " : " & Windows.Forms.SystemInformation.DebugOS & vbCrLf
        TSI = TSI & "High Contrast Mode" & " : " & Windows.Forms.SystemInformation.HighContrast & vbCrLf
        TSI = TSI & "Is Keyboard Preferred" & " : " & Windows.Forms.SystemInformation.IsKeyboardPreferred & vbCrLf
        TSI = TSI & "ListBox Smooth Scrolling Enabled " & " : " & Windows.Forms.SystemInformation.IsListBoxSmoothScrollingEnabled & vbCrLf
        TSI = TSI & "Menu Animation Enabled " & " : " & Windows.Forms.SystemInformation.IsMenuAnimationEnabled & vbCrLf
        TSI = TSI & "Menu Fade Enabled " & " : " & Windows.Forms.SystemInformation.IsMenuFadeEnabled & vbCrLf
        TSI = TSI & "Minimize & Restore Animation Enabled " & " : " & Windows.Forms.SystemInformation.IsMinimizeRestoreAnimationEnabled & vbCrLf
        TSI = TSI & "Selection Fade Enabled " & " : " & Windows.Forms.SystemInformation.IsSelectionFadeEnabled & vbCrLf
        TSI = TSI & "SnapToDefaultEnabled" & " : " & Windows.Forms.SystemInformation.IsSnapToDefaultEnabled & vbCrLf
        TSI = TSI & "TitleBar Gradient Enabled" & " : " & Windows.Forms.SystemInformation.IsTitleBarGradientEnabled & vbCrLf
        TSI = TSI & "ToolTip Animation Enabled" & " : " & Windows.Forms.SystemInformation.IsToolTipAnimationEnabled & vbCrLf
        TSI = TSI & "Keyboard Delay" & " : " & Windows.Forms.SystemInformation.KeyboardDelay & vbCrLf
        TSI = TSI & "Keyboard Speed" & " : " & Windows.Forms.SystemInformation.KeyboardSpeed & vbCrLf
        TSI = TSI & "Numcer of Moniters" & " : " & Windows.Forms.SystemInformation.MonitorCount & vbCrLf
        TSI = TSI & "Mouse Buttons" & " : " & Windows.Forms.SystemInformation.MouseButtons & vbCrLf
        TSI = TSI & "Mouse Buttons Swapped" & " : " & Windows.Forms.SystemInformation.MouseButtonsSwapped & vbCrLf
        TSI = TSI & "Mouse Speed" & " : " & Windows.Forms.SystemInformation.MouseSpeed & vbCrLf
        TSI = TSI & "Mouse Wheel Present" & " : " & Windows.Forms.SystemInformation.MouseWheelPresent & vbCrLf
        TSI = TSI & "Mouse Wheel Scroll Lines" & " : " & Windows.Forms.SystemInformation.MouseWheelScrollLines & vbCrLf
        TSI = TSI & "Microsoft Pen Computing Enabled" & " : " & Windows.Forms.SystemInformation.PenWindows & vbCrLf
        TSI = TSI & "Power Line Status" & " : " & Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus & vbCrLf
        TSI = TSI & "User Domain Name" & " : " & Windows.Forms.SystemInformation.UserDomainName & vbCrLf
        TSI = TSI & "User Interactive Mode" & " : " & Windows.Forms.SystemInformation.UserInteractive & vbCrLf
        RichTextBox1.Text = TSI
    End Sub
End Class