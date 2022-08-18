<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.CheatFound = New System.Windows.Forms.ListBox()
        Me.CheatCount = New System.Windows.Forms.TextBox()
        Me.cheatnumberlabel = New System.Windows.Forms.Label()
        Me.startdetection = New System.Windows.Forms.Button()
        Me.pactify = New System.Windows.Forms.CheckBox()
        Me.minecraft = New System.Windows.Forms.CheckBox()
        Me.azlauncher = New System.Windows.Forms.CheckBox()
        Me.existant = New System.Windows.Forms.RadioButton()
        Me.personnalisé = New System.Windows.Forms.RadioButton()
        Me.LauncherType = New System.Windows.Forms.TextBox()
        Me.paladium = New System.Windows.Forms.CheckBox()
        Me.background = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.quit = New System.Windows.Forms.Button()
        CType(Me.background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheatFound
        '
        Me.CheatFound.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheatFound.FormattingEnabled = True
        Me.CheatFound.Location = New System.Drawing.Point(12, 52)
        Me.CheatFound.Name = "CheatFound"
        Me.CheatFound.Size = New System.Drawing.Size(731, 368)
        Me.CheatFound.TabIndex = 1
        '
        'CheatCount
        '
        Me.CheatCount.Enabled = False
        Me.CheatCount.Location = New System.Drawing.Point(626, 30)
        Me.CheatCount.Name = "CheatCount"
        Me.CheatCount.Size = New System.Drawing.Size(117, 20)
        Me.CheatCount.TabIndex = 2
        '
        'cheatnumberlabel
        '
        Me.cheatnumberlabel.AutoSize = True
        Me.cheatnumberlabel.Location = New System.Drawing.Point(521, 33)
        Me.cheatnumberlabel.Name = "cheatnumberlabel"
        Me.cheatnumberlabel.Size = New System.Drawing.Size(100, 13)
        Me.cheatnumberlabel.TabIndex = 4
        Me.cheatnumberlabel.Text = "Nombre de cheats :"
        '
        'startdetection
        '
        Me.startdetection.Location = New System.Drawing.Point(12, 428)
        Me.startdetection.Name = "startdetection"
        Me.startdetection.Size = New System.Drawing.Size(731, 21)
        Me.startdetection.TabIndex = 6
        Me.startdetection.Text = "Scanner l'ordinateur"
        Me.startdetection.UseVisualStyleBackColor = True
        '
        'pactify
        '
        Me.pactify.AutoSize = True
        Me.pactify.Location = New System.Drawing.Point(126, 7)
        Me.pactify.Name = "pactify"
        Me.pactify.Size = New System.Drawing.Size(58, 17)
        Me.pactify.TabIndex = 7
        Me.pactify.Text = "Pactify"
        Me.pactify.UseVisualStyleBackColor = True
        '
        'minecraft
        '
        Me.minecraft.AutoSize = True
        Me.minecraft.Location = New System.Drawing.Point(190, 7)
        Me.minecraft.Name = "minecraft"
        Me.minecraft.Size = New System.Drawing.Size(70, 17)
        Me.minecraft.TabIndex = 8
        Me.minecraft.Text = "Minecraft"
        Me.minecraft.UseVisualStyleBackColor = True
        '
        'azlauncher
        '
        Me.azlauncher.AutoSize = True
        Me.azlauncher.Location = New System.Drawing.Point(266, 7)
        Me.azlauncher.Name = "azlauncher"
        Me.azlauncher.Size = New System.Drawing.Size(85, 17)
        Me.azlauncher.TabIndex = 9
        Me.azlauncher.Text = "AZLauncher"
        Me.azlauncher.UseVisualStyleBackColor = True
        '
        'existant
        '
        Me.existant.AutoSize = True
        Me.existant.Location = New System.Drawing.Point(58, 7)
        Me.existant.Name = "existant"
        Me.existant.Size = New System.Drawing.Size(62, 17)
        Me.existant.TabIndex = 10
        Me.existant.TabStop = True
        Me.existant.Text = "Existant"
        Me.existant.UseVisualStyleBackColor = True
        '
        'personnalisé
        '
        Me.personnalisé.AutoSize = True
        Me.personnalisé.Location = New System.Drawing.Point(58, 33)
        Me.personnalisé.Name = "personnalisé"
        Me.personnalisé.Size = New System.Drawing.Size(85, 17)
        Me.personnalisé.TabIndex = 11
        Me.personnalisé.TabStop = True
        Me.personnalisé.Text = "Personnalisé"
        Me.personnalisé.UseVisualStyleBackColor = True
        '
        'LauncherType
        '
        Me.LauncherType.Location = New System.Drawing.Point(149, 30)
        Me.LauncherType.Name = "LauncherType"
        Me.LauncherType.Size = New System.Drawing.Size(117, 20)
        Me.LauncherType.TabIndex = 12
        '
        'paladium
        '
        Me.paladium.AutoSize = True
        Me.paladium.Location = New System.Drawing.Point(357, 7)
        Me.paladium.Name = "paladium"
        Me.paladium.Size = New System.Drawing.Size(69, 17)
        Me.paladium.TabIndex = 13
        Me.paladium.Text = "Paladium"
        Me.paladium.UseVisualStyleBackColor = True
        '
        'background
        '
        Me.background.BackColor = System.Drawing.Color.White
        Me.background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.background.Image = Global.FxCheatDetector.My.Resources.Resources.background
        Me.background.Location = New System.Drawing.Point(0, 0)
        Me.background.Name = "background"
        Me.background.Size = New System.Drawing.Size(755, 461)
        Me.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.background.TabIndex = 0
        Me.background.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.FxCheatDetector.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'quit
        '
        Me.quit.Location = New System.Drawing.Point(723, 4)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(20, 20)
        Me.quit.TabIndex = 15
        Me.quit.Text = "x"
        Me.quit.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.paladium)
        Me.Controls.Add(Me.LauncherType)
        Me.Controls.Add(Me.personnalisé)
        Me.Controls.Add(Me.existant)
        Me.Controls.Add(Me.azlauncher)
        Me.Controls.Add(Me.minecraft)
        Me.Controls.Add(Me.pactify)
        Me.Controls.Add(Me.startdetection)
        Me.Controls.Add(Me.cheatnumberlabel)
        Me.Controls.Add(Me.CheatCount)
        Me.Controls.Add(Me.CheatFound)
        Me.Controls.Add(Me.background)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "FxCheatDetector | By Λko.#0667 : Detector"
        CType(Me.background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents background As PictureBox
    Friend WithEvents CheatFound As ListBox
    Friend WithEvents CheatCount As TextBox
    Friend WithEvents cheatnumberlabel As Label
    Friend WithEvents startdetection As Button
    Friend WithEvents pactify As CheckBox
    Friend WithEvents minecraft As CheckBox
    Friend WithEvents azlauncher As CheckBox
    Friend WithEvents existant As RadioButton
    Friend WithEvents personnalisé As RadioButton
    Friend WithEvents LauncherType As TextBox
    Friend WithEvents paladium As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents quit As Button
End Class
