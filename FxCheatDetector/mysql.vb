Imports MySql.Data.MySqlClient

Public Class mysql

    Dim mysqlip = "0.0.0.0" 'a changé
    Dim mysqlport = "0000" 'a changé
    Dim mysqluser = "fxcd" 'a changé si tu veux
    Dim mysqlpass = "1234567890" 'a changé (préférable)
    Dim mysqldatabase = "fxcddb" 'a changé si tu veux
    Dim connection As New MySqlConnection("datasource=" + mysqlip + ";port=" + mysqlport + ";username=" + mysqluser + ";password=" + mysqlpass + ";database=" + mysqldatabase)

    Private Sub showpasswd_CheckedChanged(sender As Object, e As EventArgs) Handles showpasswd.CheckedChanged

        If password.UseSystemPasswordChar = True Then

            ' show password
            password.UseSystemPasswordChar = False

        Else

            ' hide password
            password.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click

        Me.Close()

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click

        Dim command As New MySqlCommand("SELECT `id`, `pass` FROM `user` WHERE `id` = @username AND `pass` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = user.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If user.Text = "" Then

            MessageBox.Show("Utilisateur ou Mot de passe Invalide")

        Else

            If table.Rows.Count = 0 Then

                MessageBox.Show("Utilisateur ou Mot de passe Invalide")

            Else

                MessageBox.Show("Validé !")

            End If

        End If
    End Sub

    Private Sub mysql_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class