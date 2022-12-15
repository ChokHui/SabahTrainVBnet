Imports System.Data.OleDb
Imports System.Data

Public Class Admin_Transaction
    Dim conn As New OleDbConnection(My.Settings.SabahTrainDatabase2000ConnectionString)

    Private Sub bind_data()
        Dim cmd1 As New OleDbCommand("SELECT * FROM tbl_transaction", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim tblTransaction As New DataTable
        tblTransaction.Clear()
        da.Fill(tblTransaction)
        DataGridView1.DataSource = tblTransaction
    End Sub

    Private Sub Tbl_transactionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Tbl_transactionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Admin_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bind_data()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)
        'Dim thisDate As Date
        'thisDate = Today
        DataGridView1.Rows(0).DefaultCellStyle.Format = "dd-MM-yyyy"
        'DataGridView1.Rows(e.RowIndex).Cells(dateTimColumnIndex).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        done_pay.ParticularTextBox.Text = selectedRow.Cells(1).Value.ToString
        done_pay.AmountTextBox.Text = selectedRow.Cells(2).Value.ToString
        done_pay.QuantityTextBox.Text = selectedRow.Cells(3).Value.ToString
    End Sub

    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        Admin_Welcome.Show()
        Me.Close()
    End Sub
End Class