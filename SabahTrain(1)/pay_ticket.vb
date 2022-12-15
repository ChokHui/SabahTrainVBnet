Public Class pay_ticket

    Private Sub pay_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelPsgPax.Text = passengers
        Labelticketprice.Text = Convert.ToString(ticketprice)
        Labeltotalprice.Text = totalprice


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttoncancel.Click
        Browse.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        done_pay.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxpayment.SelectedIndexChanged
        If ComboBoxpayment.Text = "Boost" Then
            boost.Show()
        ElseIf ComboBoxpayment.Text = "Touch n Go" Then
            touchngo.Show()
        ElseIf ComboBoxpayment.Text = "M2U" Then
            M2U.Show()
        ElseIf ComboBoxpayment.Text = "Credit/Debit card" Then
            creditdebit.Show()

        End If
        Me.Hide()



    End Sub

    Private Sub Labeltotalprice_Click(sender As Object, e As EventArgs) Handles Labeltotalprice.Click

    End Sub

    Private Sub Labelticketprice_Click(sender As Object, e As EventArgs) Handles Labelticketprice.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show(ticketprice)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
