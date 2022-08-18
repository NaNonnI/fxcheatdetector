<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mysql
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.login = New System.Windows.Forms.Button()
        Me.showpasswd = New System.Windows.Forms.CheckBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.user = New System.Windows.Forms.TextBox()
        Me.cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(120, 64)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(80, 23)
        Me.login.TabIndex = 0
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = True
        '
        'showpasswd
        '
        Me.showpasswd.AutoSize = True
        Me.showpasswd.Location = New System.Drawing.Point(12, 68)
        Me.showpasswd.Name = "showpasswd"
        Me.showpasswd.Size = New System.Drawing.Size(102, 17)
        Me.showpasswd.TabIndex = 1
        Me.showpasswd.Text = "Show Password"
        Me.showpasswd.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(12, 38)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(274, 20)
        Me.password.TabIndex = 2
        Me.password.UseSystemPasswordChar = True
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(12, 12)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(274, 20)
        Me.user.TabIndex = 3
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(206, 64)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(80, 23)
        Me.cancel.TabIndex = 4
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'mysql
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 96)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.showpasswd)
        Me.Controls.Add(Me.login)
        Me.Name = "mysql"
        Me.Text = "mysql"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login As Button
    Friend WithEvents showpasswd As CheckBox
    Friend WithEvents password As TextBox
    Friend WithEvents user As TextBox
    Friend WithEvents cancel As Button
End Class
