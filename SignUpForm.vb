Imports System.Data
Imports System.Data.SqlClient

Public Class SignUpForm
    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click
        Me.Hide()
        LoginForm.Show()

    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        If (txt_username.Text = "" Or txt_password.Text = "") Then
            MessageBox.Show("Please Fill all data")
        Else
            conn = New SqlConnection("Data Source=desktop-hucj0n8\sqlexpress;Initial Catalog=login;Integrated Security=True")
            conn.Open()
            query = " insert into logintbl(uname,pass) values (  '" & txt_username.Text & "', '" & txt_password.Text & "')"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            MessageBox.Show("login successful")
            Me.Hide()
            LoginForm.Show()


        End If
        conn.Close()

    End Sub
End Class