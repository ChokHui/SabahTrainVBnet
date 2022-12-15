Imports System.Data.OleDb
Imports System.Data

Public Class Admin_Login
    Dim connection As New OleDbConnection(My.Settings.SabahTrainDatabase2000ConnectionString)

    Private Sub ButtonLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonLogin.Click
        If (connection.State = ConnectionState.Closed) Then
            connection.Open()
        End If

        Dim cmd As New OleDbCommand("SELECT count(*) from tbl_admin WHERE Username=? AND Password=?", connection)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBoxUsername.Text
        cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBoxPassword.Text
        Dim count = Convert.ToInt32(cmd.ExecuteScalar())

        If (count > 0) Then
            UN = TextBoxUsername.Text
            Admin_Welcome.Show()
            TextBoxUsername.Clear()
            TextBoxPassword.Clear()
            Me.Hide()
        Else
            MessageBox.Show("Login failed")
        End If

        'Dim reader1 As OleDbDataReader
        'reader1 = cmd.ExecuteReader
        'While reader1.Read
        '    If reader1(4) = TextBoxPassword.Text Then
        '        accessLevel = TextBoxPassword.Text
        '    End If
        'End While




    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Admin_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        Browse.Show()
        Me.Close()
    End Sub
End Class