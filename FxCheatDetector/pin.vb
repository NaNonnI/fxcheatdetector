Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class pin

    Dim mysqlip = "0.0.0.0" 'a changé
    Dim mysqlport = "0000" 'a changé
    Dim mysqluser = "fxcd" 'a changé si tu veux
    Dim mysqlpass = "1234567890" 'a changé (préférable)
    Dim mysqldatabase = "fxcddb" 'a changé si tu veux

    Dim connection As New MySqlConnection("datasource=" + mysqlip + ";port=" + mysqlport + ";username=" + mysqluser + ";password=" + mysqlpass + ";database=" + mysqldatabase)
    Dim ConnectionString As String = "server=" + mysqlip + ";port=" + mysqlport + ";uid=" + mysqluser + ";pwd=" + mysqlpass + ";database=" + mysqldatabase + ";charset=utf8mb4;SslMode=none"
    Dim conn As New MySqlConnection(ConnectionString)

    Private Sub identifyb_Click(sender As Object, e As EventArgs) Handles identifyb.Click
        If (conn.State = ConnectionState.Open) Then
            identifyb.Enabled = False
            identifyb.Text = "Identifing"

            Dim command As New MySqlCommand("SELECT `username`, `pin0`, `pin1`, `pin2`, `pin3` FROM `pins` WHERE  `username` = @username AND `pin0` = @pin0 AND `pin1` = @pin1 AND `pin2` = @pin2 AND `pin3` = @pin3", connection)

            command.Parameters.Add("@pin0", MySqlDbType.VarChar).Value = pin0.Text
            command.Parameters.Add("@pin1", MySqlDbType.VarChar).Value = pin1.Text
            command.Parameters.Add("@pin2", MySqlDbType.VarChar).Value = pin2.Text
            command.Parameters.Add("@pin3", MySqlDbType.VarChar).Value = pin3.Text

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                MessageBox.Show("Utilisateur ou Mot de passe Invalide")
                identifyb.Enabled = True
                identifyb.Text = "Identify"
                pin0.Text = ""
                pin1.Text = ""
                pin2.Text = ""
                pin3.Text = ""

                pin0.Enabled = True
                pin1.Enabled = True
                pin2.Enabled = True
                pin3.Enabled = True

                progress.Value = 15
            Else

                progress.Value = 100
                identifyb.Text = "Identified"
                username.Text = @username
                MessageBox.Show("Validé ! Vous vous faites vérifié par " + username.Text)
                ShowForm(New main)
                Me.Hide()

            End If

        End If

    End Sub

    Private Sub pin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State = ConnectionState.Closed) Then
            suptb.Enabled = False
            pin0.Enabled = False
            pin1.Enabled = False
            pin2.Enabled = False
            pin3.Enabled = False
            identifyb.Text = "Wait"
            identifyb.Enabled = False
            isconnected.Text = "❎"
            conn.Open()
            If (conn.State = ConnectionState.Open) Then
                isconnected.Text = "✅"
                progress.Value = 15
                identifyb.Enabled = False
                suptb.Enabled = False
                pin0.Enabled = True
                pin1.Enabled = False
                pin2.Enabled = False
                pin3.Enabled = False
                identifyb.Text = "Identify"
                Return
            End If
        End If
    End Sub
    Private Sub ShowForm(WhichForm As Form)
        With WhichForm
            .Show()
            .BringToFront()
        End With
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Shell("taskkill /f /im FxCheatDetector.exe")
    End Sub

    Private Sub pin0_TextChanged(sender As Object, e As EventArgs) Handles pin0.TextChanged
        pin0.Enabled = False
        pin1.Enabled = True
        pin1.Focus()
        progress.Value = 30
    End Sub

    Private Sub pin1_TextChanged(sender As Object, e As EventArgs) Handles pin1.TextChanged
        pin1.Enabled = False
        pin2.Enabled = True
        pin2.Focus()
        progress.Value = 45
    End Sub

    Private Sub pin2_TextChanged(sender As Object, e As EventArgs) Handles pin2.TextChanged
        pin2.Enabled = False
        pin3.Enabled = True
        pin3.Focus()
        progress.Value = 50
    End Sub

    Private Sub pin3_TextChanged(sender As Object, e As EventArgs) Handles pin3.TextChanged
        pin3.Enabled = False
        identifyb.Enabled = True
        identifyb.Focus()
        progress.Value = 65
    End Sub
End Class
