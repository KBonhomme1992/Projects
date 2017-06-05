Option Explicit On

Imports System.IO
Imports System.Configuration


Public Class Form1


    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click

        'Variable Declaration
        Dim SiteName, IPAddVar, WorkingFolder, ipString
        Dim IPAddVarlist As New List(Of String)
        Dim IPAddVarArray()
        Dim DBug As Boolean = False

        'Set the name of the site as selected in the CmbBox
        SiteName = ComboBoxSite.SelectedItem

        IPAddVar = Nothing

        'Set the Debug parameter to Local machine name
        If SiteName = "_Debug" Then IPAddVar = "\\" & Environment.MachineName & "\"

        'if nothing is selected in the Combobox, exit sub and ask user to choose a site.
        If ComboBoxSite.SelectedItem = Nothing Then
            MsgBox("No site selected. Please choose a site in the drop-down menu")
            Exit Sub
        End If

        'If the site used is not "_Debug", append do variable ipstring
        If Not IPAddVar = "\\" & Environment.MachineName & "\" Then
            ipstring = ConfigurationSettings.AppSettings.Get(SiteName)
        Else ipstring = "\\" & Environment.MachineName & "\"
        End If

        'Split the string of IP address inside the array "IPAddVarArray"
        IPAddVarArray = Split(ipstring, ("-"))

        'Use the array to append data to a list "IPAddVarList"
        For x = 0 To UBound(IPAddVarArray)
            IPAddVarlist.Add(IPAddVarArray(x))
        Next






        'Set the Debug if the checkbox is checked
        If Me.CheckBox1.Checked Then
            DBug = True
        Else DBug = False
        End If


        'Set the working folder and create the folders if needed.
        WorkingFolder = CreatePath(DBug)


        Call Movefile(IPAddVarlist, WorkingFolder, DBug)




    End Sub

    Sub Movefile(IPAddVar, WorkingFolder, Dbug)
        Dim PclPathRemote = "C$\Cortex\PCL\"
        Dim PclPathLocal = "C:\Cortex\PCL\"
        Dim Counter = 0, Splited, SimpleIPArr, SimpleIP

        'MSG if Debug mode is activated
        If Dbug Then MsgBox(IPAddVar.count & " Path(s) to look in")

        'For every items in the List
        For x = 1 To IPAddVar.count

            'Extract the server's IP Address
            SimpleIPArr = Split(IPAddVar.item(x - 1), "\")
            SimpleIP = SimpleIPArr(2)


            'If the server ping, continue
            If My.Computer.Network.Ping(SimpleIP) Then



                'If the directory of the item(X) in the list exist
                If Directory.Exists((IPAddVar.item(x - 1) & PclPathRemote)) Then

                    'MSG if Debug mode is activated
                    If Dbug Then MsgBox("For Path: " & IPAddVar.item(x - 1) & PclPathRemote)


                    'For each files in the path of the item (X)
                    For Each file In My.Computer.FileSystem.GetFiles((IPAddVar.item(x - 1) & PclPathRemote).ToString, FileIO.SearchOption.SearchTopLevelOnly, "*.pcl")

                        Try
                            'Split the directory tree to get the filename
                            splited = Split(file, "\")

                            'If the extension of the file is ".pcl"
                            If Path.GetExtension(file) = ".pcl" Then

                                'Move the file to Local 
                                My.Computer.FileSystem.MoveFile(file, WorkingFolder & "\" & splited(6), True)

                                'MSG if Debug mode is activated
                                If Dbug Then MsgBox("File: " & file & vbNewLine _
                                                    & "Move to folder" & vbNewLine _
                                                    & WorkingFolder & vbNewLine _
                                                    & "and the name of the file is" & vbNewLine _
                                                    & splited(6))

                                'Count the amount of files that were moved
                                Counter = Counter + 1

                                'MSG if Debug mode is activated
                                If Dbug Then MsgBox("Counter + 1")

                            End If

                        Catch ex As Exception
                            'Throw exception message if needed
                            MsgBox(ex.Message, vbCritical)
                        End Try


                    Next

                    'MSG if the path does not exist / is not reachable
                Else MsgBox("The path: " & vbNewLine & IPAddVar.item(x - 1) & PclPathRemote & vbNewLine _
                                        & "Does Not exist or the path is unavailable", vbCritical)
                    Exit Sub
                End If

                'The server does not ping
            Else MsgBox("The Server " & SimpleIP & " does not Respond." & vbNewLine _
                    & "The server will be ignored", vbCritical)

            End If

        Next


        'Tells how many files moved if > 0. Else, say no file found
        If Counter > 0 Then
            MsgBox(Counter & " file(s) were moved")
            Process.Start("explorer.exe", "/select," + "C:\Cortex\Pcl\")
        Else MsgBox("No File(s) found")
        End If


    End Sub

    Function CreatePath(Dbug)
        Dim PclPathRemote = "C$\Cortex\PCL\"
        Dim PclPathLocal = "C:\Cortex\PCL\"
        Dim WorkingFolder = Nothing

        'If the directory C:\Cortex\PCL\ exists
        If Directory.Exists(PclPathLocal) Then


            'MSG if Debug mode is activated
            If Dbug Then MsgBox("Path: " & vbNewLine _
                                & PclPathLocal & " Exists")

            'Create the directory for the year if it does not exist
            If Not Directory.Exists(PclPathLocal & Year(Now())) Then
                Directory.CreateDirectory(PclPathLocal & Year(Now()))

                'MSG if Debug mode is activated
                If Dbug Then MsgBox("the directory " & vbNewLine _
                                     & PclPathLocal & Year(Now()) & vbNewLine _
                                     & "does not exist. Creating...")
            End If


            'Create the directory for the month if it does not exist
            If Not Directory.Exists(PclPathLocal & Year(Now()) & "\" & Month(Now())) Then
                Directory.CreateDirectory(PclPathLocal & Year(Now()) & "\" & Month(Now()))

                'MSG if Debug mode is activated
                If Dbug Then MsgBox("the directory " & vbNewLine _
                     & PclPathLocal & Year(Now()) & "\" & Month(Now()) & vbNewLine _
                     & "does not exist. Creating...")
            End If


            'Create the directory for the day
            If Not Directory.Exists(PclPathLocal & Year(Now()) & "\" & Month(Now()) & "\" & DateAndTime.Day(Now())) Then
                Directory.CreateDirectory(PclPathLocal & Year(Now()) & "\" & Month(Now()) & "\" & DateAndTime.Day(Now()))

                'MSG if Debug mode is activated
                If Dbug Then MsgBox("the directory " & vbNewLine _
                     & PclPathLocal & Year(Now()) & "\" & Month(Now()) & "\" & DateAndTime.Day(Now()) & vbNewLine _
                       & "does not exist. Creating...")
            End If

            'Set the working folder to the "Today" folder
            WorkingFolder = PclPathLocal & Year(Now()) & "\" & Month(Now()) & "\" & DateAndTime.Day(Now())

            CreatePath = WorkingFolder

            'Return the working folder "Today" folder
            Return CreatePath
        Else
            'The local Path (C:\Cortex\PCL\ does not exists. Cannot copy to this folder), Exit the sub and return nothing
            MsgBox(PclPathLocal & " does not exist.")
            Return Nothing
            Exit Function

        End If

        'The whole path exists already, return it.
        WorkingFolder = PclPathLocal & Year(Now()) & "\" & Month(Now()) & "\" & DateAndTime.Day(Now())
        Return WorkingFolder

        'Reset the variable if we have to do more than 1 center at once.
        CreatePath = Nothing

    End Function

End Class