Imports System.Data.OleDb
Imports System.Data

Public Class Admin_Welcome
    Dim conn As New OleDbConnection(My.Settings.SabahTrainDatabase2000ConnectionString)

    Private Sub bind_data()
        Dim cmd1 As New OleDbCommand("SELECT * FROM tbl_admin", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim tblAdmin As New DataTable
        tblAdmin.Clear()
        da.Fill(tblAdmin)
        Admin_Database.DataGridView1.DataSource = tblAdmin
    End Sub

    Private Sub ButtonLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonLogout.Click
        Admin_Login.Show()
        Me.Close()
    End Sub

    Private Sub Admin_Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelWelcomeUsername.Text = UN

        bind_data()

        Label2.Text = accessLevel

    End Sub

    Private Sub LabelWelcomeUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelWelcomeUsername.Click

    End Sub

    Private Sub ButtonRegisterAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegisterAdmin.Click
        Admin_Database.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonSalesReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalesReport.Click
        Admin_Transaction.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonCustomerCare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCustomerCare.Click
        Admin_ContactCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ButtonAddTrain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddTrain.Click
        Add_Train.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class