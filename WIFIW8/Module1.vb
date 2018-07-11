Imports System.Text
Imports System.IO
Module Module1

    Public Function SystemCmd(ByVal Command As String) As String
        'Command = "python -c print(""""""你好"""""",""""""你好"""""".encode(""""""utf8""""""))"
        'Command = "ping g.cn"
        Dim process As New System.Diagnostics.Process()
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardInput = True
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.StandardOutputEncoding = Encoding.UTF8
        process.StartInfo.StandardErrorEncoding = Encoding.UTF8

        process.Start()

        process.StandardInput.WriteLine("chcp 65001")
        'I'v been tried servial ways, still can't sand utf8 command

        'Try #1 , not work at all
        'Dim utf8Writer = New StreamWriter(process.StandardInput.BaseStream, Encoding.UTF8)
        'utf8Writer.Write(Command)

        'Try #2 , not work either
        'Dim buffer = System.Text.Encoding.UTF8.GetBytes(Command)
        'process.StandardInput.BaseStream.Write(buffer, 0, buffer.Length)

        'Try #3 it works
        Dim tmpFile = "tmpargs.bat"
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(tmpFile, False, New UTF8Encoding(False))
        file.WriteLine(Command)
        file.Close()
        process.StandardInput.WriteLine(tmpFile)


        process.StandardInput.WriteLine("exit")
        process.WaitForExit()
        Dim Result = process.StandardOutput.ReadToEnd()
        Dim Str As String()
        Dim opt As String = ""
        Str = Split(Result, vbNewLine)


        For i = 9 To Str.Length - 4
            If Str(i) <> "" Then
                opt &= Str(i) & vbNewLine
            End If
        Next
        Dim inp As String = "> " & Split(Str(8), ">", 2)(1)
        ConsoleRecode.TextBox1.SelectionColor = Color.Red
        If inp(inp.Length - 1) <> vbLf Then
            inp &= vbNewLine
        End If
        ConsoleRecode.TextBox1.AppendText(inp)

        ConsoleRecode.TextBox1.SelectionColor = Color.Green
        ConsoleRecode.TextBox1.AppendText(opt)
        Result = "a" & vbNewLine & "a" & vbNewLine & "a" & vbNewLine & "a" & vbNewLine & opt & "a" & vbNewLine & "a" & vbNewLine
        System.IO.File.Delete(tmpFile)
        Return opt
    End Function
    Public Function wifilistprofiles(ByVal myinterface As String) As String
        Dim Str, db As String()
        Dim wlist As String = ""
        Dim start As Integer = 0
        Dim changeline As SByte = 0
        Str = Split(SystemCmd("netsh wlan show profiles interface=""" & myinterface & """"), vbNewLine)

        For i = 0 To Str.Length - 1
            If Str(i) = "User profiles" Then
                start = i
            End If
        Next


        For i = start + 2 To Str.Length - 1
            db = Split(Str(i), ": ")
            If db(0) = "    All User Profile     " Then


                wlist &= db(1) & vbNewLine
            End If
        Next
        Return wlist
    End Function
    Public Function WLAMQuantity() As Integer
        Return WLAMQuantity(SystemCmd("netsh wlan show interface"))
    End Function
    Public Function WLAMQuantity(ByVal Qstr As String) As Integer
        Dim Strs = Split(Qstr, vbNewLine)
        For Each Str As String In Strs
            If Str.StartsWith("There is ") And Str.EndsWith(" interface on the system: ") Then
                Return Convert.ToInt64(Split(Split(Str, "There is ")(1), " interface on the system: ")(0))
            End If
        Next

    End Function
    Public Function WLAN() As String
        Dim Str, db As String()
        Dim list As String = ""

        Dim count As Integer
        Dim ocmdresult = SystemCmd("netsh wlan show interface")
        Str = Split(ocmdresult, vbNewLine)
        Dim Qua As Integer = WLAMQuantity(ocmdresult)
        For i = 0 To Str.Length - 1
            If Str(i).StartsWith("    Name") Then
                count += 1
                db = Split(Str(i), ": ")
                Try
                    list &= db(1) & vbNewLine
                Catch
                    MsgBox("No Wireless network card", 0 + 16, "Error")
                End Try
            End If
            If count = Qua Then Exit For
        Next
        Return list
    End Function
    Public Function wifipd(ByVal mySSID As String, ByVal myinterface As String) As String
        Dim inputvalue As String()
        Dim returnvalue As String = ""
        Dim commandLine As String = "netsh wlan show profile name=""" & mySSID & """ interface=""" & myinterface & """ key=clear" & vbNewLine
        inputvalue = Split(SystemCmd(commandLine), vbNewLine)

        For i As Integer = 0 To inputvalue.Length - 1

            If inputvalue(i).StartsWith("    Key Content") Then
                Return Split(inputvalue(i), " :", 2)(1)
            End If

        Next
        Return ""
    End Function
    Public Sub showwifiinfo(ByVal mySSID As String, ByVal myinterface As String)
        Dim Str As String()
        Dim info As String = ""
        Str = Split(SystemCmd("netsh wlan show profile name=""" & mySSID & """ interface=""" & myinterface & """ key=clear"), vbNewLine)
        For i = 0 To Str.Length - 1
            info &= Str(i) & vbNewLine
        Next
        MsgBox(info)
    End Sub
    Public Sub removewifi(ByVal mySSID As String, ByVal myinterface As String)
        SystemCmd("netsh wlan delete profile name=""" & mySSID & """ interface=""" & myinterface & """")
        WPM.LoadList()
    End Sub
    Public Sub Movetop(ByVal mySSID As String, ByVal myinterface As String)
        SystemCmd("netsh wlan set profileorder name=""" & mySSID & """ interface=""" & myinterface & """ priority=1")
        WPM.LoadList()
        'SystemCmd("netsh wlan export profile folder=""" & Environ("TEMP") & """ name=""" & mySSID & """ interface=""" & myinterface & """")
        'SystemCmd("netsh wlan delete profile name=""" & mySSID & """ interface=""" & myinterface & """")
        'SystemCmd("netsh wlan add profile filename=""" & Environ("TEMP") & "\" & myinterface & "-" & mySSID & ".xml"" interface=""" & myinterface & """")
    End Sub
End Module
