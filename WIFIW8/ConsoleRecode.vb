Public Class ConsoleRecode
    Private Const EM_GETLINECOUNT = &HBA
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'TextBox1.SelectionColor = Color.Red


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Do While SendMessage(Me.TextBox1.Handle, EM_GETLINECOUNT, 0, 0) > 1000
            TextBox1.ReadOnly = False
            TextBox1.ReadOnly = False
            TextBox1.SelectionStart = 0
            TextBox1.SelectionLength = TextBox1.GetFirstCharIndexFromLine(1)
            TextBox1.SelectedText = ""
        Loop
        TextBox1.ReadOnly = True
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.ScrollToCaret()
    End Sub
End Class