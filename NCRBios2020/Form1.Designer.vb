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
        Me.LBDrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LBDrive.FormattingEnabled = True
        Me.LBDrive.ItemHeight = 20
        Me.LBDrive.Location = New System.Drawing.Point(34, 174)
        Me.LBDrive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LBDrive.Name = "LBDrive"
        Me.LBDrive.Size = New System.Drawing.Size(99, 84)
        Me.LBDrive.TabIndex = 1
        '
        'CBModel
        '
        Me.CBModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(203, 174)
        Me.CBModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(183, 28)
        Me.CBModel.TabIndex = 2
        '
        'create_bios
        '
        Me.create_bios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create_bios.Location = New System.Drawing.Point(283, 341)
        Me.create_bios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.create_bios.Name = "create_bios"
        Me.create_bios.Size = New System.Drawing.Size(84, 50)
        Me.create_bios.TabIndex = 3
        Me.create_bios.Text = "&Set bios"
        Me.create_bios.UseVisualStyleBackColor = True
        '
        'closep
        '
        Me.closep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closep.Location = New System.Drawing.Point(397, 341)
        Me.closep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.closep.Name = "closep"
        Me.closep.Size = New System.Drawing.Size(84, 50)
        Me.closep.TabIndex = 4
        Me.closep.Text = "&Close"
        Me.closep.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NCR Bios Creator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(197, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Drive"
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "......"
        '
        'refreshbtn
        '
        Me.refreshbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshbtn.Location = New System.Drawing.Point(397, 174)
        Me.refreshbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(84, 50)
        Me.refreshbtn.TabIndex = 9
        Me.refreshbtn.Text = "&Refresh"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'delete_files
        '
        Me.delete_files.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_files.Location = New System.Drawing.Point(34, 341)
        Me.delete_files.Margin = New System.Windows.Forms.Padding(4)
        Me.delete_files.Name = "delete_files"
        Me.delete_files.Size = New System.Drawing.Size(100, 50)
        Me.delete_files.TabIndex = 10
        Me.delete_files.Text = "&Delete Files"
        Me.delete_files.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(172, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Explorer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 411)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "NCR BIOS BY Mel "
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
