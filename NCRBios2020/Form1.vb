Imports System.IO
Imports System.IO.StreamReader
Imports System.Diagnostics.Process
Imports System


Public Class Form1
    Public usbd As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetModel()
        Detect()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles create_bios.Click

        Try
            If usbd >= 1 Then

                MakeUsb()

            Else
                MsgBox("No Usb drive detected", vbOK, "Insert Blank USB Drive")

            End If

        Catch ex As Exception
            MsgBox("Unexpected Error no usb conected, or write protected drive, select model / drive and try again", vbOK)
        End Try

    End Sub
    Sub MakeUsb()
        Dim mdl As String
        Dim drv As String
        drv = LBDrive.SelectedItem.ToString
        drv = drv.TrimEnd("\")
        mdl = CBModel.SelectedItem.ToString
        Dim scopy As String
        scopy = "xcopy *.* " + drv + "/Y"
        Label1.Text = "Bios Created in USB Drive " + drv + " For Terminal NCR " + mdl
        'Label5.Text = " For Terminal NCR " + mdl
        Call Shell("cmd.exe /c  cd .\" + CBModel.SelectedItem.ToString + "&&" + "syslinux.exe -sfma " + drv + "&&" + scopy, 0)

    End Sub
    Sub DeleteFiles()
        Dim drv As String
        drv = LBDrive.SelectedItem.ToString
        'drv = drv.TrimEnd("\")
        Dim cad1 As String
        cad1 = "Remove-Item " + drv + "*.* -Force"
        Shell("powershell.exe " + cad1, 0)
        Label1.Text = "Files delected from Drive " + drv
        'Label5.Text = "Drive " + drv
    End Sub



    Sub Detect()

        Dim allDrives = DriveInfo.GetDrives
        LBDrive.Items.Clear()


        Try
            For Each tp In allDrives


                If tp.DriveType = 2 Then
                    usbd = usbd + 1

                    LBDrive.Items.Add(tp.Name)

                End If
            Next
            LBDrive.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("No Usb drive detected", vbOK, "Connect a USB Drive")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles closep.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles refresh.Click
        Label1.Text = "......."
        'Label5.Text = "......."
        LBDrive.Items.Clear()
        Detect()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delete_files.Click

        DeleteFiles()
    End Sub

    Sub GetModel()


        Try
            Const Path As String = "models.txt"
            If FileLen(Path) Then
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

End Class