Public Class adminDatabaseTest

    Private Sub Tbl_adminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_adminBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_adminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SabahTrainDatabase2000DataSet)

    End Sub

    Private Sub adminDatabaseTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SabahTrainDatabase2000DataSet.tbl_admin' table. You can move, or remove it, as needed.
        Me.Tbl_adminTableAdapter.Fill(Me.SabahTrainDatabase2000DataSet.tbl_admin)

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Me.Validate()
        Me.Tbl_adminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SabahTrainDatabase2000DataSet)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class