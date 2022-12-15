<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pay_ticket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pay_ticket))
        Me.Labeltotalticketprice = New System.Windows.Forms.Label()
        Me.LabelPsgPax = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxpayment = New System.Windows.Forms.ComboBox()
        Me.Buttoncancel = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Labelticketprice = New System.Windows.Forms.Label()
        Me.Labeltotalprice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labeltotalticketprice
        '
        Me.Labeltotalticketprice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Labeltotalticketprice.AutoSize = True
        Me.Labeltotalticketprice.BackColor = System.Drawing.Color.Transparent
        Me.Labeltotalticketprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltotalticketprice.ForeColor = System.Drawing.Color.DarkGreen
        Me.Labeltotalticketprice.Location = New System.Drawing.Point(321, 153)
        Me.Labeltotalticketprice.Name = "Labeltotalticketprice"
        Me.Labeltotalticketprice.Size = New System.Drawing.Size(342, 46)
        Me.Labeltotalticketprice.TabIndex = 0
        Me.Labeltotalticketprice.Text = "Total ticket price:"
        '
        'LabelPsgPax
        '
        Me.LabelPsgPax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelPsgPax.AutoSize = True
        Me.LabelPsgPax.BackColor = System.Drawing.Color.Transparent
        Me.LabelPsgPax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPsgPax.Location = New System.Drawing.Point(489, 218)
        Me.LabelPsgPax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPsgPax.Name = "LabelPsgPax"
        Me.LabelPsgPax.Size = New System.Drawing.Size(154, 24)
        Me.LabelPsgPax.TabIndex = 10
        Me.LabelPsgPax.Text = "PassengerPax"
        Me.LabelPsgPax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(300, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(343, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Please choose a payment method:"
        '
        'ComboBoxpayment
        '
        Me.ComboBoxpayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBoxpayment.FormattingEnabled = True
        Me.ComboBoxpayment.Items.AddRange(New Object() {"Boost", "Touch n Go", "M2U", "Credit/Debit card"})
        Me.ComboBoxpayment.Location = New System.Drawing.Point(382, 363)
        Me.ComboBoxpayment.Name = "ComboBoxpayment"
        Me.ComboBoxpayment.Size = New System.Drawing.Size(179, 21)
        Me.ComboBoxpayment.TabIndex = 14
        '
        'Buttoncancel
        '
        Me.Buttoncancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Buttoncancel.Location = New System.Drawing.Point(305, 418)
        Me.Buttoncancel.Name = "Buttoncancel"
        Me.Buttoncancel.Size = New System.Drawing.Size(75, 23)
        Me.Buttoncancel.TabIndex = 15
        Me.Buttoncancel.Text = "Cancel"
        Me.Buttoncancel.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(568, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Pay"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(427, 11)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(134, 134)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 17
        Me.PictureBoxLogo.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 29)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Passengers ="
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 29)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ticket price ="
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(389, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 29)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Total ="
        '
        'Labelticketprice
        '
        Me.Labelticketprice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Labelticketprice.AutoSize = True
        Me.Labelticketprice.BackColor = System.Drawing.Color.Transparent
        Me.Labelticketprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelticketprice.Location = New System.Drawing.Point(538, 249)
        Me.Labelticketprice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labelticketprice.Name = "Labelticketprice"
        Me.Labelticketprice.Size = New System.Drawing.Size(125, 24)
        Me.Labelticketprice.TabIndex = 21
        Me.Labelticketprice.Text = "TicketPrice"
        Me.Labelticketprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labeltotalprice
        '
        Me.Labeltotalprice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Labeltotalprice.AutoSize = True
        Me.Labeltotalprice.BackColor = System.Drawing.Color.Transparent
        Me.Labeltotalprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltotalprice.Location = New System.Drawing.Point(537, 276)
        Me.Labeltotalprice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labeltotalprice.Name = "Labeltotalprice"
        Me.Labeltotalprice.Size = New System.Drawing.Size(107, 24)
        Me.Labeltotalprice.TabIndex = 22
        Me.Labeltotalprice.Text = "totalprice"
        Me.Labeltotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(486, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 29)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "RM"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(486, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 29)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "RM"
        '
        'pay_ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.BackgroundImage = Global.SabahTrain_1_.My.Resources.Resources.Untitled_design__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(941, 524)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Labeltotalprice)
        Me.Controls.Add(Me.Labelticketprice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Buttoncancel)
        Me.Controls.Add(Me.ComboBoxpayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelPsgPax)
        Me.Controls.Add(Me.Labeltotalticketprice)
        Me.DoubleBuffered = True
        Me.Name = "pay_ticket"
        Me.Text = "print_ticket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labeltotalticketprice As System.Windows.Forms.Label
    Friend WithEvents LabelPsgPax As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxpayment As System.Windows.Forms.ComboBox
    Friend WithEvents Buttoncancel As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Labelticketprice As System.Windows.Forms.Label
    Friend WithEvents Labeltotalprice As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
