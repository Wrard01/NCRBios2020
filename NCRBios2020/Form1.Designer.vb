<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LBDrive = New System.Windows.Forms.ListBox()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.create_bios = New System.Windows.Forms.Button()
        Me.closep = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Process1 = New System.Diagnostics.Process()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.delete_files = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBDrive
        '
        resources.ApplyResources(Me.LBDrive, "LBDrive")
        Me.LBDrive.FormattingEnabled = True
        Me.LBDrive.Name = "LBDrive"
        '
        'CBModel
        '
        resources.ApplyResources(Me.CBModel, "CBModel")
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Name = "CBModel"
        '
        'create_bios
        '
        resources.ApplyResources(Me.create_bios, "create_bios")
        Me.create_bios.Name = "create_bios"
        Me.create_bios.UseVisualStyleBackColor = True
        '
        'closep
        '
        resources.ApplyResources(Me.closep, "closep")
        Me.closep.Name = "closep"
        Me.closep.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Process1
        '
        Me.Process1.StartInfo.Arguments = "LBDrive.SelectedItem.ToString().Trim(""\"")"
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.FileName = "explorer"
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'refreshbtn
        '
        resources.ApplyResources(Me.refreshbtn, "refreshbtn")
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'delete_files
        '
        resources.ApplyResources(Me.delete_files, "delete_files")
        Me.delete_files.Name = "delete_files"
        Me.delete_files.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.delete_files)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.closep)
        Me.Controls.Add(Me.create_bios)
        Me.Controls.Add(Me.CBModel)
        Me.Controls.Add(Me.LBDrive)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBDrive As ListBox
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents create_bios As Button
    Friend WithEvents closep As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Process1 As Process
    Friend WithEvents Label1 As Label
    Friend WithEvents refreshbtn As Button
    Friend WithEvents delete_files As Button
    Friend WithEvents Button1 As Button
End Class
