Public Class CardList

    Private Sub CardList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Environ("systemroot") & "\system32\netsh.exe") Then
        Else
            MsgBox("System lack of" & Environ("systemroot") & "\system32\netsh.exe", 0 + 16, "Error")
            End
        End If

        Dim WLANlist As String = WLAN()
        Dim WDList As String()
        WDList = Split(WLANlist, vbNewLine)
        For i = 0 To WDList.Length - 2
            ComboBox1.Items.Add(WDList(i))
        Next
        ComboBox1.SelectedIndex = 0

        If My.Application.CommandLineArgs.Count > 0 Then
            For i As Integer = 0 To ComboBox1.Items.Count - 1
                If My.Application.CommandLineArgs(0) = ComboBox1.Items(i) Then
                    ComboBox1.SelectedIndex = i
                    WPM.Show()
                    Return
                End If
            Next
            MsgBox("Wireless Card " + My.Application.CommandLineArgs(0) + " were not found", 0 + 16, "ERROR")
            Return
        ElseIf WLAMQuantity() = 1 Then
            WPM.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WPM.Show()
        Me.Hide()
    End Sub
End Class