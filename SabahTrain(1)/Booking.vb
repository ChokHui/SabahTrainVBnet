Public Class Booking

  
    Private Sub ButtonPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrevious.Click
        Browse.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConfirm.Click
        pay_ticket.Show()

        Me.Hide()
    End Sub



    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelDeparture.Text = origin
        LabelArrival.Text = arrival
        LabelTDeparture.Text = td
        LabelDDepature.Text = dd
        LabelPsgPax.Text = passengers

    End Sub

End Class