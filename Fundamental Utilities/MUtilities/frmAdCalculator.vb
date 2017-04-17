Public Class frmAdCalculator
    Dim GNL As String
    Dim CNP As Boolean

    Private Sub ShowOnTaskbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowOnTaskbarToolStripMenuItem.Click
        If ShowOnTaskbarToolStripMenuItem.Checked = True Then
            ShowOnTaskbarToolStripMenuItem.Checked = False
            Me.ShowInTaskbar = False
        Else
            ShowOnTaskbarToolStripMenuItem.Checked = True
            Me.ShowInTaskbar = True
        End If
    End Sub

    Private Sub TopOnMostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopOnMostToolStripMenuItem.Click
        If TopOnMostToolStripMenuItem.Checked = True Then
            TopOnMostToolStripMenuItem.Checked = False
            Me.TopMost = False
        Else
            TopOnMostToolStripMenuItem.Checked = True
            Me.TopMost = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        TextBox1.Text = Nothing 
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = My.Resources.layerbutton_Hover
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button4.BackgroundImage = My.Resources.layerbutton_Hover
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackgroundImage = My.Resources.layerbutton_Normal
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error GoTo ERR
        If CNP = False Then
            Dim SDM As MsgBoxResult
            SDM = MsgBox("The formular on the input box apperars to be wrong and the utility may not be programmed to respond correctly in these situations !!!. Do you still want to continue ???" & vbCrLf & vbCrLf & "please check if these letters exists in you formular by any mistakes :" & vbCrLf & TextBox3.Text, Microsoft.VisualBasic.MsgBoxStyle.YesNoCancel + Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Warning : Syntax Error !!!")
            If SDM = MsgBoxResult.Yes Then
                GoTo CON
            Else
                Exit Sub
            End If
        End If
CON:
        GNL = vbCrLf
        Dim CMD2 As String = TextBox1.Text.ToLower
        Dim CH1 As Double
        Dim CH2 As Double
        Dim FN As Integer = 1
        Dim Afunction As String = ""
        TextBox1.Text = CMD2
        TextBox1.Text = TextBox1.Text.Replace("+", vbCrLf & "+" & vbCrLf)
        TextBox1.Text = TextBox1.Text.Replace("-", vbCrLf & "-" & vbCrLf)
        TextBox1.Text = TextBox1.Text.Replace("*", vbCrLf & "*" & vbCrLf)
        TextBox1.Text = TextBox1.Text.Replace("/", vbCrLf & "/" & vbCrLf)
        TextBox1.Text = TextBox1.Text.Replace("\", vbCrLf & "\" & vbCrLf)
        TextBox1.Text = TextBox1.Text.Replace("^", vbCrLf & "^" & vbCrLf)
        TextBox1.Text = TextBox1.Text.Replace("x", vbCrLf & "x" & vbCrLf)
        TextBox1.Text = TextBox1.Text.Replace("X", vbCrLf & "x" & vbCrLf)
        Dim tempArray() As String
        tempArray = TextBox1.Lines
        For Each VALUE As String In tempArray
            If FN = 1 Then
                If VALUE.StartsWith("cos") Then
                    VALUE = VALUE.Remove(0, 3)
                    CH1 = Math.Cos(Math.PI / 180 * Val(VALUE))
                ElseIf VALUE.StartsWith("sin") Then
                    VALUE = VALUE.Remove(0, 3)
                    CH1 = Math.Sin(Math.PI / 180 * Val(VALUE))
                ElseIf VALUE.StartsWith("tan") Then
                    VALUE = VALUE.Remove(0, 3)
                    CH1 = Math.Tan(Math.PI / 180 * Val(VALUE))
                ElseIf VALUE.StartsWith("sqrt") Then
                    VALUE = VALUE.Remove(0, 4)
                    CH1 = Math.Sqrt(VALUE)
                ElseIf VALUE.StartsWith("acos") Then
                    VALUE = VALUE.Remove(0, 4)
                    CH1 = Math.Acos(VALUE)
                    CH1 = CH1 * 180
                    CH1 = CH1 / Math.PI
                ElseIf VALUE.StartsWith("asin") Then
                    VALUE = VALUE.Remove(0, 4)
                    CH1 = Math.Asin(VALUE)
                    CH1 = CH1 * 180
                    CH1 = CH1 / Math.PI
                ElseIf VALUE.StartsWith("atan") Then
                    VALUE = VALUE.Remove(0, 4)
                    CH1 = Math.Atan(VALUE)
                    CH1 = CH1 * 180
                    CH1 = CH1 / Math.PI
                ElseIf VALUE.StartsWith("ln") Then
                    VALUE = VALUE.Remove(0, 2)
                    CH1 = Math.Log(VALUE)
                ElseIf VALUE.StartsWith("log") Then
                    VALUE = VALUE.Remove(0, 3)
                    CH1 = Math.Log10(VALUE)
                Else
                    CH1 = Val(VALUE)
                End If
            End If
            If FN Mod 2 = 0 Then
                Afunction = VALUE
            Else
                If VALUE.StartsWith("cos") Then
                    VALUE = VALUE.Remove(0, 3)
                    CH2 = Math.Cos(Math.PI / 180 * Val(VALUE))
                ElseIf VALUE.StartsWith("sin") Then
                    VALUE = VALUE.Remove(0, 3)
                    CH2 = Math.Sin(Math.PI / 180 * Val(VALUE))
                ElseIf VALUE.StartsWith("tan") Then
                    VALUE = VALUE.Remove(0, 3)
                    CH2 = Math.Tan(Math.PI / 180 * Val(VALUE))
                ElseIf VALUE.StartsWith("sqrt") Then
                    VALUE = VALUE.Remove(0, 4)
                    CH2 = Math.Sqrt(VALUE)
                ElseIf VALUE.StartsWith("acos") Then
                    VALUE = VALUE.Remove(0, 4)
                    CH2 = Math.Acos(VALUE)
                    CH2 = CH2 * 180
                    CH2 = CH2 / Math.PI
                ElseIf VALUE.StartsWith("asin") Then
                    VALUE = VALUE.Remove(0, 4)
                    CH2 = Math.Asin(VALUE)
                    CH2 = CH2 * 180
                    CH2 = CH2 / Math.PI
                ElseIf VALUE.StartsWith("atan") Then
                    VALUE = VALUE.Remove(0, 4)
                    CH2 = Math.Atan(VALUE)
                    CH2 = CH2 * 180
                    CH2 = CH2 / Math.PI
                ElseIf VALUE.StartsWith("ln") Then
                    VALUE = VALUE.Remove(0, 2)
                    CH2 = Math.Log(VALUE)
                ElseIf VALUE.StartsWith("pi") Then
                    CH2 = Math.PI
                ElseIf VALUE.StartsWith("e") Then
                    CH2 = Math.E
                Else
                    CH2 = Val(VALUE)
                End If
            End If
            If FN > 2 Then
                If FN Mod 2 = 1 Then
                    If FN > 2 Then
                        Select Case Afunction
                            Case "+"
                                CH1 = CH1 + CH2
                            Case "-"
                                CH1 = CH1 - CH2
                            Case "*"
                                CH1 = CH1 * CH2
                            Case "/"
                                CH1 = CH1 / CH2
                            Case "\"
                                CH1 = CH1 \ CH2
                            Case "^"
                                CH1 = CH1 ^ CH2
                            Case "x"
                                CH1 = CH1 * CH2
                        End Select
                    End If
                End If
            End If
            FN = FN + 1
        Next
        TextBox2.Text = "Input :" & GNL & CMD2 & GNL & GNL & "Output :" & GNL & CH1 & GNL & GNL
        TextBox1.Text = ""
        GoTo ED
ERR:
        MsgBox("Error Occured While Calculating" & vbCrLf & ErrorToString(), MsgBoxStyle.Critical)
ED:
        CMD2 = Nothing
        CH1 = Nothing
        FN = Nothing
        Afunction = Nothing
        tempArray = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCalchelp.Show()
    End Sub

    Private Sub frmAdCalculator_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Intergrator.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmAdCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmCalchelp.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        frmCalchelp.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox3.Text = TextBox1.Text.ToLower
        TextBox3.Text = TextBox3.Text.Replace("+", "")
        TextBox3.Text = TextBox3.Text.Replace("-", "")
        TextBox3.Text = TextBox3.Text.Replace("*", "")
        TextBox3.Text = TextBox3.Text.Replace("x", "")
        TextBox3.Text = TextBox3.Text.Replace("/", "")
        TextBox3.Text = TextBox3.Text.Replace("\", "")
        TextBox3.Text = TextBox3.Text.Replace("asin", "")
        TextBox3.Text = TextBox3.Text.Replace("acos", "")
        TextBox3.Text = TextBox3.Text.Replace("atan", "")
        TextBox3.Text = TextBox3.Text.Replace("sin", "")
        TextBox3.Text = TextBox3.Text.Replace("cos", "")
        TextBox3.Text = TextBox3.Text.Replace("tan", "")
        TextBox3.Text = TextBox3.Text.Replace("log", "")
        TextBox3.Text = TextBox3.Text.Replace("ln", "")
        TextBox3.Text = TextBox3.Text.Replace("pi", "")
        TextBox3.Text = TextBox3.Text.Replace("e", "")
        TextBox3.Text = TextBox3.Text.Replace("^", "")
        TextBox3.Text = TextBox3.Text.Replace("1", "")
        TextBox3.Text = TextBox3.Text.Replace("2", "")
        TextBox3.Text = TextBox3.Text.Replace("3", "")
        TextBox3.Text = TextBox3.Text.Replace("4", "")
        TextBox3.Text = TextBox3.Text.Replace("5", "")
        TextBox3.Text = TextBox3.Text.Replace("6", "")
        TextBox3.Text = TextBox3.Text.Replace("7", "")
        TextBox3.Text = TextBox3.Text.Replace("8", "")
        TextBox3.Text = TextBox3.Text.Replace("9", "")
        TextBox3.Text = TextBox3.Text.Replace("0", "")
        TextBox3.Text = TextBox3.Text.Replace(".", "")
        If TextBox3.Text = "" Then
            PictureBox1.Image = My.Resources.ico_Check
            CNP = True
        Else
            PictureBox1.Image = My.Resources.ico_Critical
            CNP = False
        End If

    End Sub
End Class