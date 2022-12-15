<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browse))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonAdmin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelFrom = New System.Windows.Forms.Label()
        Me.LabelTo = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.ComboBoxFrom = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTo = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonBookNow = New System.Windows.Forms.Button()
        Me.ComboBoxtTime = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownpassenger = New System.Windows.Forms.NumericUpDown()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownpassenger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button1.Location = New System.Drawing.Point(128, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Contact Customer Service"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonAdmin
        '
        Me.ButtonAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdmin.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonAdmin.Location = New System.Drawing.Point(874, 2)
        Me.ButtonAdmin.Name = "ButtonAdmin"
        Me.ButtonAdmin.Size = New System.Drawing.Size(53, 28)
        Me.ButtonAdmin.TabIndex = 14
        Me.ButtonAdmin.Text = "Admin"
        Me.ButtonAdmin.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button2.Location = New System.Drawing.Point(10, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Train schedule"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(406, 34)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(134, 134)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelFrom
        '
        Me.LabelFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFrom.AutoSize = True
        Me.LabelFrom.BackColor = System.Drawing.Color.Transparent
        Me.LabelFrom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFrom.Location = New System.Drawing.Point(200, 152)
        Me.LabelFrom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFrom.Name = "LabelFrom"
        Me.LabelFrom.Size = New System.Drawing.Size(66, 22)
        Me.LabelFrom.TabIndex = 2
        Me.LabelFrom.Text = "FROM"
        '
        'LabelTo
        '
        Me.LabelTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTo.AutoSize = True
        Me.LabelTo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTo.Location = New System.Drawing.Point(671, 152)
        Me.LabelTo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTo.Name = "LabelTo"
        Me.LabelTo.Size = New System.Drawing.Size(37, 22)
        Me.LabelTo.TabIndex = 3
        Me.LabelTo.Text = "TO"
        '
        'LabelDate
        '
        Me.LabelDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelDate.AutoSize = True
        Me.LabelDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(200, 236)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(63, 22)
        Me.LabelDate.TabIndex = 4
        Me.LabelDate.Text = "DATE"
        '
        'ComboBoxFrom
        '
        Me.ComboBoxFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxFrom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxFrom.FormattingEnabled = True
        Me.ComboBoxFrom.Items.AddRange(New Object() {"Tanjung Aru"})
        Me.ComboBoxFrom.Location = New System.Drawing.Point(81, 181)
        Me.ComboBoxFrom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxFrom.Name = "ComboBoxFrom"
        Me.ComboBoxFrom.Size = New System.Drawing.Size(337, 26)
        Me.ComboBoxFrom.TabIndex = 6
        '
        'ComboBoxTo
        '
        Me.ComboBoxTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBoxTo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxTo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTo.FormattingEnabled = True
        Me.ComboBoxTo.Items.AddRange(New Object() {"Putatan", "Kinarut", "Kawang", "Papar", "Kimanis", "Bongawan", "Membakut", "Beaufort", "Saliwangan", "Halogilat", "Rayoh", "Pangi", "Tenom"})
        Me.ComboBoxTo.Location = New System.Drawing.Point(521, 181)
        Me.ComboBoxTo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxTo.Name = "ComboBoxTo"
        Me.ComboBoxTo.Size = New System.Drawing.Size(337, 26)
        Me.ComboBoxTo.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 271)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(337, 26)
        Me.DateTimePicker1.TabIndex = 9
        '
        'ButtonBookNow
        '
        Me.ButtonBookNow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonBookNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonBookNow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBookNow.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBookNow.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonBookNow.Location = New System.Drawing.Point(341, 491)
        Me.ButtonBookNow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonBookNow.Name = "ButtonBookNow"
        Me.ButtonBookNow.Size = New System.Drawing.Size(260, 59)
        Me.ButtonBookNow.TabIndex = 10
        Me.ButtonBookNow.Text = "Book Now"
        Me.ButtonBookNow.UseVisualStyleBackColor = False
        '
        'ComboBoxtTime
        '
        Me.ComboBoxtTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBoxtTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxtTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxtTime.FormattingEnabled = True
        Me.ComboBoxtTime.Items.AddRange(New Object() {"8:26", "8:54", "9:11", "9:51", "11:31", "11:48", "11:59", "12:16", "12:31", "12:41", "12:54", "13:10", "13:23"})
        Me.ComboBoxtTime.Location = New System.Drawing.Point(521, 271)
        Me.ComboBoxtTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxtTime.Name = "ComboBoxtTime"
        Me.ComboBoxtTime.Size = New System.Drawing.Size(337, 26)
        Me.ComboBoxtTime.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(655, 236)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "TIME"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(519, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "*Please refer to the train schedule and pick the time accordingly."
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 31)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Passengers"
        '
        'NumericUpDownpassenger
        '
        Me.NumericUpDownpassenger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDownpassenger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownpassenger.Location = New System.Drawing.Point(362, 424)
        Me.NumericUpDownpassenger.Name = "NumericUpDownpassenger"
        Me.NumericUpDownpassenger.Size = New System.Drawing.Size(228, 22)
        Me.NumericUpDownpassenger.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button3.Location = New System.Drawing.Point(341, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 28)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "User page"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Browse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(937, 605)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.NumericUpDownpassenger)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonBookNow)
        Me.Controls.Add(Me.ComboBoxtTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBoxTo)
        Me.Controls.Add(Me.ComboBoxFrom)
        Me.Controls.Add(Me.ButtonAdmin)
        Me.Controls.Add(Me.LabelFrom)
        Me.Controls.Add(Me.LabelTo)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LabelDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Browse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownpassenger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAdmin As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LabelFrom As System.Windows.Forms.Label
    Friend WithEvents LabelTo As System.Windows.Forms.Label
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents ComboBoxFrom As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTo As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonBookNow As System.Windows.Forms.Button
    Friend WithEvents ComboBoxtTime As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownpassenger As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
