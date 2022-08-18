<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pin))
        Me.identifyb = New System.Windows.Forms.Button()
        Me.identifyt = New System.Windows.Forms.Label()
        Me.progress = New System.Windows.Forms.ProgressBar()
        Me.suptb = New System.Windows.Forms.TextBox()
        Me.pin0 = New System.Windows.Forms.TextBox()
        Me.isconnected = New System.Windows.Forms.Label()
        Me.pin1 = New System.Windows.Forms.TextBox()
        Me.pin2 = New System.Windows.Forms.TextBox()
        Me.pin3 = New System.Windows.Forms.TextBox()
        Me.quit = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'identifyb
        '
        Me.identifyb.Location = New System.Drawing.Point(201, 13)
        Me.identifyb.Name = "identifyb"
        Me.identifyb.Size = New System.Drawing.Size(55, 20)
        Me.identifyb.TabIndex = 0
        Me.identifyb.Text = "Identify"
        Me.identifyb.UseVisualStyleBackColor = True
        '
        'identifyt
        '
        Me.identifyt.AutoSize = True
        Me.identifyt.Location = New System.Drawing.Point(12, 17)
        Me.identifyt.Name = "identifyt"
        Me.identifyt.Size = New System.Drawing.Size(53, 13)
        Me.identifyt.TabIndex = 1
        Me.identifyt.Text = "Code PIN"
        '
        'progress
        '
        Me.progress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progress.Location = New System.Drawing.Point(0, 44)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(288, 10)
        Me.progress.TabIndex = 2
        '
        'suptb
        '
        Me.suptb.Location = New System.Drawing.Point(71, 13)
        Me.suptb.Name = "suptb"
        Me.suptb.Size = New System.Drawing.Size(20, 20)
        Me.suptb.TabIndex = 3
        Me.suptb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pin0
        '
        Me.pin0.Location = New System.Drawing.Point(97, 13)
        Me.pin0.Name = "pin0"
        Me.pin0.Size = New System.Drawing.Size(20, 20)
        Me.pin0.TabIndex = 4
        Me.pin0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'isconnected
        '
        Me.isconnected.AutoSize = True
        Me.isconnected.Location = New System.Drawing.Point(-2, 0)
        Me.isconnected.Name = "isconnected"
        Me.isconnected.Size = New System.Drawing.Size(13, 13)
        Me.isconnected.TabIndex = 7
        Me.isconnected.Text = "?"
        '
        'pin1
        '
        Me.pin1.Location = New System.Drawing.Point(123, 13)
        Me.pin1.Name = "pin1"
        Me.pin1.Size = New System.Drawing.Size(20, 20)
        Me.pin1.TabIndex = 8
        Me.pin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pin2
        '
        Me.pin2.Location = New System.Drawing.Point(149, 13)
        Me.pin2.Name = "pin2"
        Me.pin2.Size = New System.Drawing.Size(20, 20)
        Me.pin2.TabIndex = 9
        Me.pin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pin3
        '
        Me.pin3.Location = New System.Drawing.Point(175, 13)
        Me.pin3.Name = "pin3"
        Me.pin3.Size = New System.Drawing.Size(20, 20)
        Me.pin3.TabIndex = 10
        Me.pin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'quit
        '
        Me.quit.Location = New System.Drawing.Point(261, 13)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(20, 20)
        Me.quit.TabIndex = 11
        Me.quit.Text = "x"
        Me.quit.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(277, 52)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(11, 2)
        Me.username.TabIndex = 12
        Me.username.Text = "username"
        '
        'pin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 54)
        Me.ControlBox = False
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.pin3)
        Me.Controls.Add(Me.pin2)
        Me.Controls.Add(Me.pin1)
        Me.Controls.Add(Me.isconnected)
        Me.Controls.Add(Me.pin0)
        Me.Controls.Add(Me.suptb)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.identifyt)
        Me.Controls.Add(Me.identifyb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "pin"
        Me.Text = "FxCheatDetector | By Λko.#0667 : Pin Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents identifyb As Button
    Friend WithEvents identifyt As Label
    Friend WithEvents progress As ProgressBar
    Friend WithEvents suptb As TextBox
    Friend WithEvents pin0 As TextBox
    Friend WithEvents isconnected As Label
    Friend WithEvents pin1 As TextBox
    Friend WithEvents pin2 As TextBox
    Friend WithEvents pin3 As TextBox
    Friend WithEvents quit As Button
    Friend WithEvents username As Label
End Class
