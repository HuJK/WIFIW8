Module Module1

    Public Function SystemCmd(ByVal Command As String) As String
        Dim process As New System.Diagnostics.Process()
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardInput = True
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.Start()
        process.StandardInput.WriteLine(Command)
        process.StandardInput.WriteLine("exit")
        Dim Result As String = process.StandardOutput.ReadToEnd()
        process.Close()

        Dim Str As String()
        Dim inp As String = Split(Result, vbNewLine)(3)
        Dim opt As String = ""
        Str = Split(Result, vbNewLine)
        For i = 4 To Str.Length - 3
            opt &= Str(i) & vbNewLine
        Next

        ConsoleRecode.TextBox1.SelectionColor = Color.Red
        ConsoleRecode.TextBox1.AppendText(inp & vbNewLine)

        ConsoleRecode.TextBox1.SelectionColor = Color.Green
        ConsoleRecode.TextBox1.AppendText(opt)
        Return Result
    End Function
    Public Function wifilistprofiles(ByVal myinterface As String) As String
        Dim Str, db As String()
        Dim wlist As String = ""
        Dim start As Integer = 0
        Dim changeline As SByte = 0
        Str = Split(SystemCmd("netsh wlan show profiles interface=""" & myinterface & """"), vbNewLine)
        Do
            start += 1
            If Str(start) = "" Then
                changeline += 1
            End If
        Loop Until changeline = 4
        For i = start + 3 To Str.Length - 5
            db = Split(Str(i), ": ")
            Try
                wlist &= db(1) & vbNewLine
            Catch
                Return ""
            End Try
        Next
        Return wlist
    End Function
    Public Function WLAMQuantity() As Integer
        Dim Str As String()
        Dim Qua As Integer = 0
        Str = Split(SystemCmd("netsh wlan show profiles"), vbNewLine)
        For i = 0 To Str.Length - 2
            If Str(i) = "" Then Qua += 1
        Next
        Qua -= 3
        Qua /= 3
        Return Qua
    End Function
    Public Function WLAN() As String
        Dim Str, db As String()
        Dim list As String = ""
        Dim Qua As Integer = WLAMQuantity()
        Dim count As Integer
        Str = Split(SystemCmd("netsh wlan show interface"), vbNewLine)
        For i = 5 To Str.Length - 2
            If Str(i) = "" Then
                count += 1
                db = Split(Str(i + 1), ": ")
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
        Dim counter As Integer
        For i As Integer = 0 To inputvalue.Length
            'Dim L5 As String = 
            If (Strings.Left(inputvalue(i), 5) = "-----") AndAlso (counter <= 3) Then
                counter += 1
            ElseIf counter >= 3
                returnvalue = inputvalue(i + 3)
                Exit For
            End If

        Next
        Try
            If (Split(returnvalue, "   :", 2)(1).Length > 4) Then
                Return Split(returnvalue, "   :", 2)(1)
            Else
                Return ""
            End If
        Catch
            Return ""
        End Try
    End Function
    Public Sub showwifiinfo(ByVal mySSID As String, ByVal myinterface As String)
        Dim Str As String()
        Dim info As String = ""
        Str = Split(SystemCmd("netsh wlan show profile name=""" & mySSID & """ interface=""" & myinterface & """ key=clear"), vbNewLine)
        For i = 10 To Str.Length - 4
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
