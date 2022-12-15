Imports System.Data.OleDb
Imports System.Data

Public Class Add_Train
    Dim conn As New OleDbConnection(My.Settings.SabahTrainDatabase2000ConnectionString)

    Private Sub bind_data()
        Dim cmd1 As New OleDbCommand("SELECT * FROM tbl_train", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim tblTrain As New DataTable
        tblTrain.Clear()
        da.Fill(tblTrain)
        DataGridView1.DataSource = tblTrain
    End Sub

    'Private Sub Tbl_trainBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_trainBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.Tbl_trainBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.SabahTrainDatabase2000DataSet)

    'End Sub

    Private Sub Add_Train_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SabahTrainDatabase2000DataSet.tbl_train' table. You can move, or remove it, as needed.
        Me.Tbl_trainTableAdapter.Fill(Me.SabahTrainDatabase2000DataSet.tbl_train)

        bind_data()
    End Sub

    'Private Sub DateDepartDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerDateDepart.ValueChanged

    'End Sub

    'Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click

    'End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Dim strsql As String
        strsql = "INSERT INTO tbl_train([TrainNo],[Departure],[Arrival],[Price],[TimeDepart],[DateDepart]) VALUES (@TrainNo,@Departure,@Arrival,@Price,@TimeDepart,@DateDepart)"
        Dim cmd2 As New OleDbCommand(strsql, conn)
        cmd2.Parameters.AddWithValue("@TrainNo", TextBoxTrainNo.Text)
        cmd2.Parameters.AddWithValue("@Departure", TextBoxDeparture.Text)
        cmd2.Parameters.AddWithValue("@Arrival", TextBoxArrival.Text)
        cmd2.Parameters.AddWithValue("@Price", TextBoxPrice.Text)
        cmd2.Parameters.AddWithValue("@TimeDepart", TextBoxTimeDepart.Text)
        cmd2.Parameters.AddWithValue("@DateDepart", DateTimePickerDateDepart.Value)
        Browse.ComboBoxFrom.Items.Add(TextBoxDeparture.Text)
        MessageBox.Show("Train Successfully Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Open()
        cmd2.ExecuteNonQuery()
        conn.Close()
        bind_data()
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        TextBoxTrainNo.Text = ""
        TextBoxDeparture.Text = ""
        TextBoxArrival.Text = ""
        TextBoxPrice.Text = ""
        TextBoxTimeDepart.Text = ""
        DateTimePickerDateDepart.ResetText()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)
        TextBoxTrainNo.Text = selectedRow.Cells(0).Value.ToString
        TextBoxDeparture.Text = selectedRow.Cells(1).Value.ToString
        TextBoxArrival.Text = selectedRow.Cells(2).Value.ToString
        TextBoxPrice.Text = selectedRow.Cells(3).Value.ToString
        TextBoxTimeDepart.Text = selectedRow.Cells(4).Value.ToString
        'TextBoxTimeDepart.Text = selectedRow.Cells(3).Value.ToString
        DateTimePickerDateDepart.Value = selectedRow.Cells(5).Value.ToString()
    End Sub

    'Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
    'Dim cmd4 As New OleDbCommand("UPDATE tbl_admin SET AdminName=@TextBoxAdminName.Text, Username=@TextBoxUsername.Text, Password=@TextBoxPassword.Text , AccessLevel = @TextBoxAccessLevel.Text WHERE AdminID = @TextBoxAdminID.Text", conn)
    'conn.Open()
    ''cmd4.Parameters.AddWithValue("@AdminID", TextBoxAdminID.Text)
    'cmd4.Parameters.AddWithValue("@AdminName", TextBoxAdminName.Text)
    'cmd4.Parameters.AddWithValue("@Username", TextBoxUsername.Text)
    'cmd4.Parameters.AddWithValue("@Password", TextBoxPassword.Text)
    'cmd4.Parameters.AddWithValue("@AccessLevel", TextBoxAccessLevel.Text)
    'cmd4.ExecuteNonQuery()
    'conn.Close()
    'bind_data()
    'End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim cmd5 As New OleDbCommand("DELETE FROM tbl_train WHERE TrainNo=@TrainNo", conn)
        cmd5.Parameters.AddWithValue("@TrainNo", TextBoxTrainNo.Text)
        MessageBox.Show("Train Successfully Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Open()
        cmd5.ExecuteNonQuery()
        conn.Close()
        bind_data()
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        Try
            conn.Open()
            Dim cmd6 As New OleDbCommand("SELECT * FROM tbl_train WHERE TrainNo=@TrainNo OR Departure=@Departure OR Arrival=@Arrival OR Price=@Price OR TimeDepart=@TimeDepart", conn)
            cmd6.Parameters.AddWithValue("@TrainNo", TextBoxTrainNo.Text.Trim)
            cmd6.Parameters.AddWithValue("@Departure", TextBoxDeparture.Text)
            cmd6.Parameters.AddWithValue("@Arrival", TextBoxArrival.Text)
            cmd6.Parameters.AddWithValue("@Price", TextBoxPrice.Text)
            cmd6.Parameters.AddWithValue("@TimeDepart", TextBoxTimeDepart.Text)
            'cmd6.Parameters.AddWithValue("@DateDepart", DateTimePickerDateDepart.Value)
            Dim reader1 As OleDbDataReader
            reader1 = cmd6.ExecuteReader
            If reader1.Read() Then
                TextBoxTrainNo.Text = reader1("TrainNo").ToString
                TextBoxDeparture.Text = reader1("Departure").ToString
                TextBoxArrival.Text = reader1("Arrival").ToString
                TextBoxPrice.Text = reader1("Price").ToString
                TextBoxTimeDepart.Text = reader1("TimeDepart").ToString
                'DateTimePickerDateDepart.Value = reader1("DateDepart").Value.ToString
                bind_data()
            Else
                TextBoxTrainNo.Text = ""
                TextBoxDeparture.Text = ""
                TextBoxArrival.Text = ""
                TextBoxPrice.Text = ""
                TextBoxTimeDepart.Text = ""
                'DateTimePickerDateDepart.ResetText()
                MessageBox.Show("Data no found")
            End If
            conn.Close()
            'OR DateDepart=@DateDepart
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        Admin_Welcome.Show()
        Me.Close()
    End Sub

    Private Sub DateTimePickerDateDepart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerDateDepart.ValueChanged

    End Sub

    Private Sub TextBoxDeparture_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDeparture.TextChanged

    End Sub
End Class