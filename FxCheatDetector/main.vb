Option Strict On
Imports System.IO
Public Class main
    Dim i As Integer = 0
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        existant.Checked = True
        pactify.Checked = False
        minecraft.Checked = False
        azlauncher.Checked = False
        paladium.Checked = False
        LauncherType.Enabled = False
    End Sub
    Private Sub existant_CheckedChanged(sender As Object, e As EventArgs) Handles existant.CheckedChanged
        If existant.Checked = True Then
            pactify.Enabled = True
            minecraft.Enabled = True
            paladium.Enabled = True
            azlauncher.Enabled = True
            personnalisé.Enabled = True
            existant.Enabled = False
            LauncherType.Enabled = False
            If Directory.Exists(appdata + "\.pactify") = False Then
                pactify.Checked = False
                pactify.Enabled = False
            End If

            If Directory.Exists(appdata + "\.minecraft") = False Then
                minecraft.Checked = False
                minecraft.Enabled = False
            End If

            If Directory.Exists(appdata + "\.azlauncher") = False Then
                azlauncher.Checked = False
                azlauncher.Enabled = False
            End If

            If Directory.Exists(appdata + "\.paladium") = False Then
                paladium.Checked = False
                paladium.Enabled = False
            End If
        End If
    End Sub
    Private Sub personnalisé_CheckedChanged(sender As Object, e As EventArgs) Handles existant.CheckedChanged
        If personnalisé.Checked = True Then
            pactify.Enabled = False
            minecraft.Enabled = False
            azlauncher.Enabled = False
            paladium.Enabled = False
            personnalisé.Enabled = False
            pactify.Checked = False
            minecraft.Checked = False
            azlauncher.Checked = False
            paladium.Checked = False
            existant.Enabled = True
            LauncherType.Enabled = True
        End If
    End Sub
    Private Sub startdetection_Click(sender As Object, e As EventArgs) Handles startdetection.Click
        i = 0
        CheatFound.Items.Clear()
        If personnalisé.Checked = True Then
            If LauncherType.Enabled = True Then
                If Directory.Exists(appdata + "\." + LauncherType.Text + "\") = True Then
                    Dim Folder As New IO.DirectoryInfo(appdata + "\." + LauncherType.Text + "\")

                    For Each File As IO.FileInfo In Folder.GetFiles("*Xray*", IO.SearchOption.AllDirectories)
                        CheatFound.Items.Add(File.FullName)
                        i = i + 1
                        CheatCount.Text = Convert.ToString(i)
                    Next
                Else
                    MsgBox("''" + LauncherType.Text + "''" + " n'est pas installé sur l'ordinateur." + "              (" + appdata + "\." + LauncherType.Text + "\)")
                End If
            End If
        End If
        If pactify.Checked = True Then
            If Directory.Exists(appdata + "\.pactify\") = True Then
                Dim Folder As New IO.DirectoryInfo(appdata + "\.pactify\")

                For Each File As IO.FileInfo In Folder.GetFiles("*Xray*", IO.SearchOption.AllDirectories)
                    CheatFound.Items.Add(File.FullName)
                    i = i + 1
                    CheatCount.Text = Convert.ToString(i)
                Next
            Else
                MsgBox("Pactify n'est pas installé sur l'ordinateur. (Comment tu as réussi a activé ce bouton ?!)")
            End If
        End If
        If minecraft.Checked = True Then
            If Directory.Exists(appdata + "\.minecraft\") = True Then
                Dim Folder As New IO.DirectoryInfo(appdata + "\.minecraft\")

                For Each File As IO.FileInfo In Folder.GetFiles("*Xray*", IO.SearchOption.AllDirectories)
                    CheatFound.Items.Add(File.FullName)
                    i = i + 1
                    CheatCount.Text = Convert.ToString(i)
                Next
            Else
                MsgBox("Minecraft n'est pas installé sur l'ordinateur. (Comment tu as réussi a activé ce bouton ?!)")
            End If
        End If
        If azlauncher.Checked = True Then
            If Directory.Exists(appdata + "\.azlauncher\") = True Then
                Dim Folder As New IO.DirectoryInfo(appdata + "\.azlauncher\")

                For Each File As IO.FileInfo In Folder.GetFiles("*Xray*", IO.SearchOption.AllDirectories)
                    CheatFound.Items.Add(File.FullName)
                    i = i + 1
                    CheatCount.Text = Convert.ToString(i)
                Next
            Else
                MsgBox("AZLauncher n'est pas installé sur l'ordinateur. (Comment tu as réussi a activé ce bouton ?!)")
            End If
        End If
        If paladium.Checked = True Then
            If Directory.Exists(appdata + "\.paladium\") = True Then
                Dim Folder As New IO.DirectoryInfo(appdata + "\.paladium\")

                For Each File As IO.FileInfo In Folder.GetFiles("*Xray*", IO.SearchOption.AllDirectories)
                    CheatFound.Items.Add(File.FullName)
                    i = i + 1
                    CheatCount.Text = Convert.ToString(i)
                Next
            Else
                MsgBox("Paladium n'est pas installé sur l'ordinateur. (Comment tu as réussi a activé ce bouton ?!)")
            End If
        End If
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Shell("taskkill /f /im FxCheatDetector.exe")
    End Sub
End Class

' JUSTE DES TRUCS INUTILISER OU SIMPLEMENT POUR ME RAPPELLER

'If paladium.Enabled = True Then
'If Directory.Exists(appdata + "\.paladium\") = True Then
'Dim Folder As New IO.DirectoryInfo(appdata + "\.paladium\")
'
'For Each File As IO.FileInfo In Folder.GetFiles("*Xray*", IO.SearchOption.AllDirectories)
'CheatFound.Items.Add(File.FullName)
'i = i + 1
'CheatCount.Text = Convert.ToString(i)
'Next
'Else
'MsgBox("Paladium n'est pas installé sur l'ordinateur.")
'End If
'End If

'i = 0
'CheatFound.Items.Clear()
'Dim Folder As New IO.DirectoryInfo("C:\Users\anton\AppData\Roaming\." + LauncherType.Text)

'For Each File As IO.FileInfo In Folder.GetFiles("*Xray*", IO.SearchOption.AllDirectories)
'CheatFound.Items.Add(File.FullName)
'i = i + 1
'CheatCount.Text = Convert.ToString(i)
'Next

'If azlauncher.Enabled = True Then
'If Directory.Exists(appdata + "\.azlauncher\") = True Then
'Dim Folder As New IO.DirectoryInfo(appdata + "\.azlauncher\")

'For Each File As IO.FileInfo In Folder.GetFiles("*Xray*", IO.SearchOption.AllDirectories)
'CheatFound.Items.Add(File.FullName)
'i = i + 1
'CheatCount.Text = Convert.ToString(i)
'Next
'Else
'MsgBox("AZLauncher n'est pas installé sur l'ordinateur.")
'End If
'End If

'Private Sub paladium_CheckedChanged(sender As Object, e As EventArgs) Handles paladium.CheckedChanged
'If paladium.Enabled = True Then
'If Directory.Exists(appdata + "\.paladium") = False Then
'paladium.Checked = False
'paladium.Enabled = False
'MsgBox("Paladium n'est pas installé sur l'ordinateur.")
'End If
'End If
'End Sub

'paladium