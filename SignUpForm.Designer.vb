<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnsignin = New System.Windows.Forms.Button()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsignin
        '
        Me.btnsignin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsignin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignin.Location = New System.Drawing.Point(395, 257)
        Me.btnsignin.Name = "btnsignin"
        Me.btnsignin.Size = New System.Drawing.Size(117, 38)
        Me.btnsignin.TabIndex = 11
        Me.btnsignin.Text = "Signin"
        Me.btnsignin.UseVisualStyleBackColor = False
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.Location = New System.Drawing.Point(267, 257)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(117, 38)
        Me.btnregister.TabIndex = 10
        Me.btnregister.Text = "Regsiter"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Password"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(148, 143)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(97, 24)
        Me.lblusername.TabIndex = 8
        Me.lblusername.Text = "Username"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(267, 195)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(245, 29)
        Me.txt_password.TabIndex = 7
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(267, 138)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(245, 29)
        Me.txt_username.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Niagara Solid", 70.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(424, 99)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Register Yourself"
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(725, 333)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsignin)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Name = "SignUpForm"
        Me.Text = "SignUpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsignin As Button
    Friend WithEvents btnregister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label2 As Label
End Class
