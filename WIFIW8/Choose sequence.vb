Public Class Choose_sequence

    Private Sub Choose_sequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Prio.Items.Clear()
        For i = 1 To WPM.ListBox1.Items.Count
            Prio.Items.Add(i.ToString)
        Next
        Prio.SelectedIndex = WPM.ListBox1.SelectedIndex
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If Prio.SelectedIndex <> WPM.ListBox1.SelectedIndex Then
            SystemCmd("netsh wlan set profileorder name=""" & WPM.ListBox1.Text & """ interface=""" & CardList.ComboBox1.Text & """ priority=" & Prio.Text)
        End If
        WPM.LoadList(Prio.SelectedIndex)
        Me.Close()
    End Sub
End Class