Imports System.Data
Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblusername.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (txtusername.Text = "" Or txtpassword.Text = "") Then
            MessageBox.Show("Please Fill all data")
        Else
            conn = New SqlConnection("Data Source=desktop-hucj0n8\sqlexpress;Initial Catalog=login;Integrated Security=True")
            conn.Open()
            query = "select uname,pass from logintbl where uname='" & txtusername.Text & "' and pass='" & txtpassword.Text & "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            If (dr.Read = True) Then

                MessageBox.Show("login successful")

            Else
                MessageBox.Show("login failed")
            End If
        End If

        conn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtusername.Text = ""
        txtpassword.Text = ""

    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Me.Hide()
        SignUpForm.Show()

    End Sub
End Class
