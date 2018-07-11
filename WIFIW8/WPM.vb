Public Class WPM
    Dim nowIndex As Integer = 0
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)

    Private Sub WPM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Private Sub WPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Count() > 2 Then
            If My.Application.CommandLineArgs(2) = "Maximized" Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Dim Size As String = Split(Split(My.Application.CommandLineArgs(2), ";")(0), ":")(1)
                Dim Loca As String = Split(Split(My.Application.CommandLineArgs(2), ";")(1), ":")(1)
                Me.Size = New Point(Convert.ToInt32(Split(Size, "x")(0)), Convert.ToInt32(Split(Size, "x")(1)))
                Me.Location = New Point(Convert.ToInt32(Split(Loca, "x")(0)), Convert.ToInt32(Split(Loca, "x")(1)))
            End If
        End If
        LoadList()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CardList.Hide()
        Timer1.Enabled = False
        If My.Application.CommandLineArgs.Count > 1 Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                If My.Application.CommandLineArgs(1) = ListBox1.Items(i) Then
                    ListBox1.SelectedIndex = i
                    MsgBox(wifipd(ListBox1.Text, CardList.ComboBox1.Text), 0 + 64, "Key(Press Ctrl+C to copy)")
                    Return
                End If
            Next
            MsgBox("Wi-Fi " + My.Application.CommandLineArgs(1) + " were not found", 0 + 16, "ERROR")
        End If
    End Sub
    Sub LoadList()
        ListBox1.Items.Clear()
        Dim wlist As String = wifilistprofiles(CardList.ComboBox1.Text)
        Dim dlist As String()
        dlist = Split(wlist, vbNewLine)
        For i = 0 To dlist.Length - 2
            ListBox1.Items.Add(dlist(i))
        Next
        If nowIndex < 0 Then
            nowIndex = 0
        ElseIf nowIndex > ListBox1.Items.Count() - 1 Then
        nowIndex = ListBox1.Items.Count() - 1
        End If
        ListBox1.SelectedIndex = nowIndex
    End Sub
    Sub LoadList(ByVal now As Integer)
        nowIndex = now
        LoadList()
    End Sub
    Private Sub Removeprof_Click(sender As Object, e As EventArgs) Handles Removeprof.Click
        removewifi(ListBox1.Text, CardList.ComboBox1.Text)
    End Sub

    Private Sub Showpd_Click(sender As Object, e As EventArgs) Handles Showpd.Click
        Dim Ps As Process

        Ps = System.Diagnostics.Process.GetCurrentProcess()
        If My.User.IsInRole(Microsoft.VisualBasic.ApplicationServices.BuiltInRole.Administrator) = False Then
            Dim WindowStyle As String
            If Me.WindowState = FormWindowState.Maximized Then
                WindowStyle = "Maximized"
            Else
                WindowStyle = "Size:" + Me.Size.Width.ToString() + "x" + Me.Size.Height.ToString() + ";Location:" + Me.Location.X.ToString() + "x" + Me.Location.Y.ToString()
            End If


            Dim start As New ProcessStartInfo
            Dim p As New Process
            start.WorkingDirectory = "%systemroot%\system32"
            start.Verb = "runas"
            start.FileName = Ps.MainModule.FileName

            start.Arguments = """" + CardList.ComboBox1.Text + """ """ + ListBox1.Text + """ """ + WindowStyle + """"
            Try
                p = Process.Start(start)
                End
            Catch
                MsgBox("Failed to get administrator privileges!", 0 + 64, "ERROR")
            End Try
        End If
        MsgBox(wifipd(ListBox1.Text, CardList.ComboBox1.Text), 0 + 64, ListBox1.Text & "-Key(Press Ctrl+C to copy)")
    End Sub

    Private Sub ShowProfileInfomationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowProfileInfomationToolStripMenuItem.Click
        showwifiinfo(ListBox1.Text, CardList.ComboBox1.Text)
    End Sub

    Private Sub MoveToTop_Click(sender As Object, e As EventArgs) Handles MoveToTop.Click
        SystemCmd("netsh wlan set profileorder name=""" & ListBox1.Text & """ interface=""" & CardList.ComboBox1.Text & """ priority=1")
        nowIndex = 0
        LoadList()
    End Sub

    Private Sub MoveUp_Click(sender As Object, e As EventArgs) Handles MoveUp.Click
        SystemCmd("netsh wlan set profileorder name=""" & ListBox1.Text & """ interface=""" & CardList.ComboBox1.Text & """ priority=" & ListBox1.SelectedIndex)
        nowIndex -= 1
        LoadList()
    End Sub

    Private Sub MoveDown_Click(sender As Object, e As EventArgs) Handles MoveDown.Click
        SystemCmd("netsh wlan set profileorder name=""" & ListBox1.Text & """ interface=""" & CardList.ComboBox1.Text & """ priority=" & ListBox1.SelectedIndex + 2)
        nowIndex += 1
        LoadList()
    End Sub

    Private Sub MoveTo_Click(sender As Object, e As EventArgs) Handles MoveTo.Click
        Choose_sequence.Show()
    End Sub

    Private Sub ExporttoXML_Click(sender As Object, e As EventArgs) Handles ExporttoXML.Click
        FolderBrowserDialog1.ShowDialog()
        Try
            Dim bk = SystemCmd("netsh wlan export profile folder=""" & FolderBrowserDialog1.SelectedPath & """ name=""" & ListBox1.Text & """ interface=""" & CardList.ComboBox1.Text & """")
            MsgBox(bk, 0 + 64, "Success")
        Catch
            MsgBox("Failed", 0 + 16, "Failed")
        End Try
    End Sub

    Private Sub ImportXML_Click(sender As Object, e As EventArgs) Handles ImportXML.Click
        Dim bk As String()
        Dim bd As String = ""
        OpenFileDialog1.ShowDialog()
        bk = Split(SystemCmd("netsh wlan add profile filename=""" & OpenFileDialog1.FileName & """ interface=""" & CardList.ComboBox1.Text & """"), vbNewLine)
        For i = 0 To bk.Length - 1
            bd &= bk(i) & vbNewLine
        Next
        MsgBox(bd, 0 + 64)
        Me.LoadList()
    End Sub

    Private Sub JToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JToolStripMenuItem.Click
        ConsoleRecode.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LoadList()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub
    Private Sub ListBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            mouse_event(&H2, 0, 0, 0, UIntPtr.Zero)
        End If
    End Sub
    Private Sub ListBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseUp
        For Each i In Showinfo.Items
            i.Font = New Font(Showinfo.Font.Name, 14.25, Showinfo.Font.Style)
        Next
        If e.Button = MouseButtons.Right Then
            mouse_event(&H4, 0, 0, 0, UIntPtr.Zero)
        End If
    End Sub

    Private Sub ButtonMU_Click(sender As Object, e As EventArgs) Handles ButtonMU.Click
        MoveUp_Click(sender, e)
    End Sub

    Private Sub ButtonMD_Click(sender As Object, e As EventArgs) Handles ButtonMD.Click
        MoveDown_Click(sender, e)
    End Sub

    Private Sub ButtonM2_Click(sender As Object, e As EventArgs) Handles ButtonM2.Click
        M2Menu.Show(Cursor.Position.X - (M2Menu.Size.Width / 2), Cursor.Position.Y - (M2Menu.Size.Height / 2))
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Removeprof_Click(sender, e)
    End Sub

    Private Sub ButtonINFO_Click(sender As Object, e As EventArgs) Handles ButtonINFO.Click
        ShowProfileInfomationToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ButtonPWD_Click(sender As Object, e As EventArgs) Handles ButtonPWD.Click
        Showpd_Click(sender, e)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        nowIndex = ListBox1.SelectedIndex
    End Sub

    Private Sub StripM2T_Click(sender As Object, e As EventArgs) Handles StripM2T.Click
        MoveToTop_Click(sender, e)
    End Sub

    Private Sub StripM2_Click(sender As Object, e As EventArgs) Handles StripM2.Click
        MoveTo_Click(sender, e)
    End Sub

    Private Sub ButtonXML_Click(sender As Object, e As EventArgs) Handles ButtonXML.Click
        XMLMenu.Show(Cursor.Position.X - (XMLMenu.Size.Width / 2), Cursor.Position.Y - (XMLMenu.Size.Height / 2))
    End Sub

    Private Sub StripExportXML_Click(sender As Object, e As EventArgs) Handles StripExportXML.Click
        ExporttoXML_Click(sender, e)
    End Sub

    Private Sub StripImportXML_Click(sender As Object, e As EventArgs) Handles StripImportXML.Click
        ImportXML_Click(sender, e)
    End Sub

    Private Sub WPM_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.Size.Width < 618 Then
            ButtonMU.Hide()
            ButtonMD.Hide()
            ButtonM2.Hide()
            ButtonDelete.Hide()
            ButtonXML.Hide()
            ButtonINFO.Hide()
            ButtonPWD.Hide()
            ButtonMENU.Show()
        Else
            ButtonMU.Show()
            ButtonMD.Show()
            ButtonM2.Show()
            ButtonDelete.Show()
            ButtonXML.Show()
            ButtonINFO.Show()
            ButtonPWD.Show()
            ButtonMENU.Hide()
        End If
    End Sub

    Private Sub ButtonMENU_Click(sender As Object, e As EventArgs) Handles ButtonMENU.Click
        For Each i In Showinfo.Items
            i.Font = New Font(Showinfo.Font.Name, 28, Showinfo.Font.Style)
        Next
        Showinfo.Show(Cursor.Position.X - (Showinfo.Size.Width / 2), Cursor.Position.Y - (Showinfo.Size.Height / 2))
    End Sub
End Class
