Imports System.IO
Imports System.IO.StreamReader
Imports System.Diagnostics.Process
Imports System


Public Class Form1
    Public usbd As Integer



    Sub Detect()

        Dim allDrives = DriveInfo.GetDrives
        LBDrive.Items.Clear()


        Try
            For Each tp In allDrives


                If tp.DriveType = 2 Then
                    usbd = +1

                    LBDrive.Items.Add(tp.Name)

                End If
            Next
            LBDrive.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Inser a USB Drive", vbOK, "Missing USB Drive")
            wait(3000)
            'Detect()
        End Try


    End Sub

    Sub GetModel()

        

        Try
            Const Path As String = "models.txt"
            If File.Exists(Path) Then
                Dim lector = New StreamReader(Path)
                CBModel.Items.Clear()
                Do Until lector.EndOfStream = True
                    CBModel.Items.Add(lector.ReadLine)

                Loop
                CBModel.SelectedIndex = 0
            End If

        Catch ex As Exception
            MsgBox("Missing models.txt file", MsgBoxStyle.Critical, "Missing File")
            Me.Close()

        End Try

    End Sub

    Sub MakeUsb()

        Dim mdl As String
        Dim drv As String
        drv = LBDrive.SelectedItem.ToString
        drv = drv.TrimEnd("\")
        Process.Start(drv)
        mdl = CBModel.SelectedItem.ToString
        Dim scopy As String
        scopy = "xcopy *.* " + drv + "/Y"
        Label1.Text = "Tranfering Files"
        wait(5000)
        Label1.Text = "Creating USB Bios"
        'Label5.Text = " For Terminal NCR " + mdl
        Call Shell("cmd.exe /c  cd .\" + CBModel.SelectedItem.ToString + "&&" + "syslinux.exe -sfma " + drv + "&&" + scopy, 0)
        wait(5000)
        Label1.Text = "Bios For NCR  " + mdl + " Has Been Created in USB Drive  " + drv
    End Sub

    Sub CleanUsb()


        Dim drv As String
        drv = LBDrive.SelectedItem.ToString
        'drv = drv.TrimEnd("\")
        'Dim cad1 As String
        'cad1 = "Remove-Item " + drv + "*.* -Force"
        'Shell("powershell.exe " + cad1, 0)
        'Label1.Text = "Files delected from Drive " + drv




        Dim unit As New DirectoryInfo(drv)
        For Each f In unit.GetFiles()
            My.Computer.FileSystem.DeleteFile(f.FullName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Label1.Text = "Deleting File  " + f.Name
            wait(1000)

        Next
        wait(3000)
        Label1.Text = "USB Drive  " + drv.Trim("\") + " Ready To Use"

    End Sub

    Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetModel()
        Detect()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles create_bios.Click



        If usbd >= 1 Then
            Try

                wait(1000)
                MakeUsb()

            Catch ex As Exception
                MsgBox("Inser a USB drive and click Refresh", MsgBoxStyle.OkOnly, "Unspected Error")
            End Try


        Else
            'Shell("taskkill /f /im explorer.exe")
            MsgBox("Insert Blank USB Drive", MsgBoxStyle.OkOnly, "No Usb drive detected")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles closep.Click, MyBase.Leave
        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        Label1.Text = "......."
        'Label5.Text = "......."
        LBDrive.Items.Clear()
        Detect()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delete_files.Click

        CleanUsb()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(LBDrive.SelectedItem.ToString().Trim("\"))

    End Sub



End Class