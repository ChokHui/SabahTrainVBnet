Public Class Browse

    Const putatan = 0.4
    Const kinarut = 0.85
    Const kawang = 1.25
    Const papar = 1.85
    Const kimanis = 2.7
    Const bongawan = 3.2
    Const membakut = 3.75
    Const beaufort = 4.8
    Const saliwangan = 5.6
    Const halogilat = 5.9
    Const rayoh = 6.4
    Const pangi = 6.9
    Const tenom = 7.5

    Private Sub ButtonBookNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBookNow.Click
        origin = ComboBoxFrom.Text
        arrival = ComboBoxTo.Text
        td = ComboBoxtTime.Text
        dd = DateTimePicker1.Text
        passengers = NumericUpDownpassenger.Text

        Select Case arrival

            Case "Putatan"
                ticketprice = 0.4
                totalprice = 0.4 * passengers

            Case "Kinarut"
                ticketprice = 0.85
                totalprice = 0.85 * passengers

            Case "Kawang"
                ticketprice = 1.25
                totalprice = 1.25 * passengers

            Case "Papar"
                ticketprice = 1.85
                totalprice = 1.85 * passengers

            Case "Kimanis"
                ticketprice = 2.7
                totalprice = 2.7 * passengers

            Case "Bongawan"
                ticketprice = 3.2
                totalprice = 3.2 * passengers

            Case "Membakut"
                ticketprice = 3.75
                totalprice = 3.75 * passengers

            Case "Beaufort"
                ticketprice = 4.8
                totalprice = 4.8 * passengers

            Case "Saliwangan"
                ticketprice = 5.6
                totalprice = 5.6 * passengers

            Case "Halogilat"
                ticketprice = 5.9
                totalprice = 5.9 * passengers

            Case "Rayoh"
                ticketprice = 6.4
                totalprice = 6.4 * passengers

            Case "Pangi"
                ticketprice = 6.9
                totalprice = 6.9 * passengers

            Case "Tenom"
                ticketprice = 7.5
                totalprice = 7.5 * passengers


        End Select

        Booking.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAdmin.Click
        Admin_Login.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContactCustomerService.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Train_schedule.Show()

    End Sub


    Private Sub ComboBoxTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTo.SelectedIndexChanged

    End Sub

    Private Sub Browse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBoxFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxFrom.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Userpage.Show()
        Me.Hide()

    End Sub
End Class




