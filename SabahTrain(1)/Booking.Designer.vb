<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking))
        Me.LabelDeparture = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelArrival = New System.Windows.Forms.Label()
        Me.LabelTDeparture = New System.Windows.Forms.Label()
        Me.LabelTArrive = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelDDepature = New System.Windows.Forms.Label()
        Me.LabelDArrive = New System.Windows.Forms.Label()
        Me.LabelPsgPax = New System.Windows.Forms.Label()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDeparture
        '
        Me.LabelDeparture.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelDeparture.AutoSize = True
        Me.LabelDeparture.BackColor = System.Drawing.Color.Transparent
        Me.LabelDeparture.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeparture.Location = New System.Drawing.Point(283, 147)
        Me.LabelDeparture.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDeparture.Name = "LabelDeparture"
        Me.LabelDeparture.Size = New System.Drawing.Size(150, 32)
        Me.LabelDeparture.TabIndex = 0
        Me.LabelDeparture.Text = "Departure"
        Me.LabelDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(417, 11)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(134, 134)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(453, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 75)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "→"
        '
        'LabelArrival
        '
        Me.LabelArrival.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelArrival.AutoSize = True
        Me.LabelArrival.BackColor = System.Drawing.Color.Transparent
        Me.LabelArrival.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArrival.Location = New System.Drawing.Point(549, 147)
        Me.LabelArrival.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelArrival.Name = "LabelArrival"
        Me.LabelArrival.Size = New System.Drawing.Size(103, 32)
        Me.LabelArrival.TabIndex = 3
        Me.LabelArrival.Text = "Arrival"
        Me.LabelArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTDeparture
        '
        Me.LabelTDeparture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTDeparture.AutoSize = True
        Me.LabelTDeparture.BackColor = System.Drawing.Color.Transparent
        Me.LabelTDeparture.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTDeparture.Location = New System.Drawing.Point(499, 274)
        Me.LabelTDeparture.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTDeparture.Name = "LabelTDeparture"
        Me.LabelTDeparture.Size = New System.Drawing.Size(154, 24)
        Me.LabelTDeparture.TabIndex = 4
        Me.LabelTDeparture.Text = "TimeDepature"
        Me.LabelTDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTArrive
        '
        Me.LabelTArrive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTArrive.AutoSize = True
        Me.LabelTArrive.BackColor = System.Drawing.Color.Transparent
        Me.LabelTArrive.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTArrive.Location = New System.Drawing.Point(423, 212)
        Me.LabelTArrive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTArrive.Name = "LabelTArrive"
        Me.LabelTArrive.Size = New System.Drawing.Size(253, 32)
        Me.LabelTArrive.TabIndex = 5
        Me.LabelTArrive.Text = "Time of Departure"
        Me.LabelTArrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPrice
        '
        Me.LabelPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrice.Location = New System.Drawing.Point(772, 212)
        Me.LabelPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(171, 32)
        Me.LabelPrice.TabIndex = 6
        Me.LabelPrice.Text = "Passengers"
        Me.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDDepature
        '
        Me.LabelDDepature.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelDDepature.AutoSize = True
        Me.LabelDDepature.BackColor = System.Drawing.Color.Transparent
        Me.LabelDDepature.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDDepature.Location = New System.Drawing.Point(36, 274)
        Me.LabelDDepature.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDDepature.Name = "LabelDDepature"
        Me.LabelDDepature.Size = New System.Drawing.Size(151, 24)
        Me.LabelDDepature.TabIndex = 7
        Me.LabelDDepature.Text = "DateDepature"
        Me.LabelDDepature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDArrive
        '
        Me.LabelDArrive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelDArrive.AutoSize = True
        Me.LabelDArrive.BackColor = System.Drawing.Color.Transparent
        Me.LabelDArrive.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDArrive.Location = New System.Drawing.Point(70, 212)
        Me.LabelDArrive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDArrive.Name = "LabelDArrive"
        Me.LabelDArrive.Size = New System.Drawing.Size(251, 32)
        Me.LabelDArrive.TabIndex = 8
        Me.LabelDArrive.Text = "Date of Departure"
        Me.LabelDArrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPsgPax
        '
        Me.LabelPsgPax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelPsgPax.AutoSize = True
        Me.LabelPsgPax.BackColor = System.Drawing.Color.Transparent
        Me.LabelPsgPax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPsgPax.Location = New System.Drawing.Point(838, 274)
        Me.LabelPsgPax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPsgPax.Name = "LabelPsgPax"
        Me.LabelPsgPax.Size = New System.Drawing.Size(154, 24)
        Me.LabelPsgPax.TabIndex = 9
        Me.LabelPsgPax.Text = "PassengerPax"
        Me.LabelPsgPax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonConfirm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConfirm.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonConfirm.Location = New System.Drawing.Point(577, 393)
        Me.ButtonConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(260, 59)
        Me.ButtonConfirm.TabIndex = 11
        Me.ButtonConfirm.Text = "Confirm"
        Me.ButtonConfirm.UseVisualStyleBackColor = False
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonPrevious.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrevious.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonPrevious.Location = New System.Drawing.Point(198, 393)
        Me.ButtonPrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(260, 59)
        Me.ButtonPrevious.TabIndex = 12
        Me.ButtonPrevious.Text = "Back To Previous"
        Me.ButtonPrevious.UseVisualStyleBackColor = False
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.LabelPsgPax)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.LabelTDeparture)
        Me.Controls.Add(Me.LabelTArrive)
        Me.Controls.Add(Me.LabelDeparture)
        Me.Controls.Add(Me.LabelDDepature)
        Me.Controls.Add(Me.LabelDArrive)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelArrival)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDeparture As System.Windows.Forms.Label
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelArrival As System.Windows.Forms.Label
    Friend WithEvents LabelTDeparture As System.Windows.Forms.Label
    Friend WithEvents LabelTArrive As System.Windows.Forms.Label
    Friend WithEvents LabelPrice As System.Windows.Forms.Label
    Friend WithEvents LabelDDepature As System.Windows.Forms.Label
    Friend WithEvents LabelDArrive As System.Windows.Forms.Label
    Friend WithEvents LabelPsgPax As System.Windows.Forms.Label
    Friend WithEvents ButtonConfirm As System.Windows.Forms.Button
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
End Class
