Imports System.Data.OleDb
Imports System.Data

Public Class Admin_ContactCustomer
    Dim conn As New OleDbConnection(My.Settings.SabahTrainDatabase2000ConnectionString)

    Private Sub bind_data()
        Dim cmd1 As New OleDbCommand("SELECT * FROM tbl_customerCare", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim tblCustomerCare As New DataTable
        tblCustomerCare.Clear()
        da.Fill(tblCustomerCare)
        DataGridView1.DataSource = tblCustomerCare
    End Sub

    Private Sub Admin_ContactCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bind_data()
    End Sub

    Private Sub ButtonRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemove.Click
        Dim cmd As New OleDbCommand("DELETE FROM tbl_customerCare WHERE CustomerName=@CustomerName AND emailAddress=@emailAddress AND complaintMessage=@complaintMessage", conn)
        cmd.Parameters.AddWithValue("@CustomerName", ContactCustomerService.TextBoxCustomerName.Text)
        cmd.Parameters.AddWithValue("@emailAddress", ContactCustomerService.TextBoxEmailAddress.Text)
        cmd.Parameters.AddWithValue("@complaintMessage", ContactCustomerService.TextBoxComplaintMessage.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        bind_data()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)
        ContactCustomerService.TextBoxCustomerName.Text = selectedRow.Cells(0).Value.ToString
        ContactCustomerService.TextBoxEmailAddress.Text = selectedRow.Cells(1).Value.ToString
        ContactCustomerService.TextBoxComplaintMessage.Text = selectedRow.Cells(2).Value.ToString
    End Sub

    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        Admin_Welcome.Show()
        Me.Close()
    End Sub
End Class