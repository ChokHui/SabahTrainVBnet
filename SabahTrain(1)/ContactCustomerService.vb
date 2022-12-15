Imports System.Data.OleDb
Imports System.Data

Public Class ContactCustomerService
    Dim conn As New OleDbConnection(My.Settings.SabahTrainDatabase2000ConnectionString)

    Private Sub bind_data()
        Dim cmd1 As New OleDbCommand("SELECT * FROM tbl_customerCare", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim tblCustomerCare As New DataTable
        tblCustomerCare.Clear()
        da.Fill(tblCustomerCare)
        Admin_ContactCustomer.DataGridView1.DataSource = tblCustomerCare
    End Sub

    Private Sub Tbl_customerCareBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_customerCareBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_customerCareBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SabahTrainDatabase2000DataSet)

    End Sub

    Private Sub ContactCustomerService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SabahTrainDatabase2000DataSet.tbl_customerCare' table. You can move, or remove it, as needed.
        Me.Tbl_customerCareTableAdapter.Fill(Me.SabahTrainDatabase2000DataSet.tbl_customerCare)

        bind_data()
    End Sub

    Private Sub EmailAddressLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubmit.Click
        Dim strsql As String
        strsql = "INSERT INTO tbl_customerCare([CustomerName],[emailAddress],[complaintMessage]) VALUES (@CustomerName,@emailAddress,@complaintMessage)"
        Dim cmd2 As New OleDbCommand(strsql, conn)
        cmd2.Parameters.AddWithValue("@CustomerName", TextBoxCustomerName.Text)
        cmd2.Parameters.AddWithValue("@emailAddress", TextBoxEmailAddress.Text)
        cmd2.Parameters.AddWithValue("@complaintMessage", TextBoxComplaintMessage.Text)


        If TextBoxCustomerName.Text = "" Or TextBoxEmailAddress.Text = "" Or TextBoxComplaintMessage.Text = "" Then
            MsgBox("A Field is Missing")
            Exit Sub 'To avoid saving, escape the procedure
        Else
            conn.Open()
            MessageBox.Show("Message Sent!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxCustomerName.Clear()
            TextBoxEmailAddress.Clear()
            TextBoxComplaintMessage.Text = ""
            cmd2.ExecuteNonQuery()
            conn.Close()
            bind_data()
        End If

    End Sub

    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        Userpage.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxComplaintMessage.Text = ""
        TextBoxCustomerName.Text = ""
        TextBoxEmailAddress.Text = ""

    End Sub
End Class