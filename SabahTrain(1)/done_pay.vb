Imports System.Data.OleDb
Imports System.Data

Public Class done_pay
    Dim conn As New OleDbConnection(My.Settings.SabahTrainDatabase2000ConnectionString)

    Private Sub bind_data()
        Dim cmd1 As New OleDbCommand("SELECT * FROM tbl_transaction", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim tblTransaction As New DataTable
        tblTransaction.Clear()
        da.Fill(tblTransaction)
        Admin_Transaction.DataGridView1.DataSource = tblTransaction
    End Sub

    Private Sub done_pay_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SabahTrainDatabase2000DataSet.tbl_transaction' table. You can move, or remove it, as needed.
        Me.Tbl_transactionTableAdapter.Fill(Me.SabahTrainDatabase2000DataSet.tbl_transaction)

        bind_data()

        LabelDeparture.Text = origin
        LabelArrival.Text = arrival
        LabelTDeparture.Text = td
        LabelDDepature.Text = dd
        LabelPsgPax.Text = passengers
        Labeltotalprice.Text = totalprice


        'Me.Tbl_transactionBindingSource.AddNew()
        'ParticularTextBox.Text = "ticket payment"
        'AmountTextBox.Text = totalprice
        'QuantityTextBox.Text = passengers

        'Me.Validate()
        'Me.Tbl_transactionBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.SabahTrainDatabase2000DataSet)

        'Dim strsql As String
        'strsql = "INSERT INTO tbl_transaction([Particular],[Quantity],[Amount]) VALUES (@Particular,@Quantity,@Amount)"
        'Dim cmd2 As New OleDbCommand(strsql, conn)
        'Dim thisDate As Date
        'thisDate = Today
        ''DataGridView1.Rows(0).DefaultCellStyle.Format = "dd-MM-yyyy"
        'cmd2.Parameters.AddWithValue("@Particular", ParticularTextBox.Text)
        'cmd2.Parameters.AddWithValue("@Quantity", AmountTextBox.Text)
        'cmd2.Parameters.AddWithValue("@Amount", QuantityTextBox.Text)
        'conn.Open()
        'cmd2.ExecuteNonQuery()
        'conn.Close()
        'bind_data()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Browse.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()

    End Sub

    Private Sub Tbl_transactionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_transactionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_transactionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SabahTrainDatabase2000DataSet)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Tbl_transactionBindingSource.AddNew()
        ParticularTextBox.Text = "ticket payment"
        AmountTextBox.Text = totalprice
        QuantityTextBox.Text = passengers

        Me.Validate()
        Me.Tbl_transactionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SabahTrainDatabase2000DataSet)

        Dim strsql As String
        strsql = "INSERT INTO tbl_transaction([Particular],[Quantity],[Amount]) VALUES (@Particular,@Quantity,@Amount)"
        Dim cmd2 As New OleDbCommand(strsql, conn)
        Dim thisDate As Date
        thisDate = Today
        'DataGridView1.Rows(0).DefaultCellStyle.Format = "dd-MM-yyyy"
        cmd2.Parameters.AddWithValue("@Particular", ParticularTextBox.Text)
        cmd2.Parameters.AddWithValue("@Quantity", AmountTextBox.Text)
        cmd2.Parameters.AddWithValue("@Amount", QuantityTextBox.Text)
        conn.Open()
        cmd2.ExecuteNonQuery()
        conn.Close()
        bind_data()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class