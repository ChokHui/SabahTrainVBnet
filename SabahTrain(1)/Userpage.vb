Public Class Userpage

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Browse.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ContactCustomerService.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Train_schedule.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ticketprices.Show()
        Me.Hide()

    End Sub

    Private Sub Userpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdmin.Click
        Admin_Login.Show()
        Me.Hide()
    End Sub
End Class