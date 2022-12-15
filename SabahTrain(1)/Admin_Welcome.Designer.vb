<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Welcome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.ButtonRegisterAdmin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonAddTrain = New System.Windows.Forms.Button()
        Me.ButtonCustomerCare = New System.Windows.Forms.Button()
        Me.ButtonSalesReport = New System.Windows.Forms.Button()
        Me.LabelWelcomeUsername = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 256)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogout.Location = New System.Drawing.Point(359, 650)
        Me.ButtonLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(256, 47)
        Me.ButtonLogout.TabIndex = 1
        Me.ButtonLogout.Text = "Logout"
        Me.ButtonLogout.UseVisualStyleBackColor = True
        '
        'ButtonRegisterAdmin
        '
        Me.ButtonRegisterAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonRegisterAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegisterAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegisterAdmin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegisterAdmin.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonRegisterAdmin.Location = New System.Drawing.Point(359, 342)
        Me.ButtonRegisterAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonRegisterAdmin.Name = "ButtonRegisterAdmin"
        Me.ButtonRegisterAdmin.Size = New System.Drawing.Size(256, 47)
        Me.ButtonRegisterAdmin.TabIndex = 2
        Me.ButtonRegisterAdmin.Text = "Register Admin"
        Me.ButtonRegisterAdmin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ButtonAddTrain)
        Me.Panel1.Controls.Add(Me.ButtonCustomerCare)
        Me.Panel1.Controls.Add(Me.ButtonSalesReport)
        Me.Panel1.Controls.Add(Me.LabelWelcomeUsername)
        Me.Panel1.Controls.Add(Me.PictureBoxLogo)
        Me.Panel1.Controls.Add(Me.ButtonRegisterAdmin)
        Me.Panel1.Controls.Add(Me.ButtonLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(250, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 758)
        Me.Panel1.TabIndex = 3
        '
        'ButtonAddTrain
        '
        Me.ButtonAddTrain.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonAddTrain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddTrain.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddTrain.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonAddTrain.Location = New System.Drawing.Point(359, 420)
        Me.ButtonAddTrain.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAddTrain.Name = "ButtonAddTrain"
        Me.ButtonAddTrain.Size = New System.Drawing.Size(256, 47)
        Me.ButtonAddTrain.TabIndex = 7
        Me.ButtonAddTrain.Text = "Add Train"
        Me.ButtonAddTrain.UseVisualStyleBackColor = False
        '
        'ButtonCustomerCare
        '
        Me.ButtonCustomerCare.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonCustomerCare.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCustomerCare.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCustomerCare.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonCustomerCare.Location = New System.Drawing.Point(359, 575)
        Me.ButtonCustomerCare.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCustomerCare.Name = "ButtonCustomerCare"
        Me.ButtonCustomerCare.Size = New System.Drawing.Size(256, 47)
        Me.ButtonCustomerCare.TabIndex = 6
        Me.ButtonCustomerCare.Text = "Customer Care"
        Me.ButtonCustomerCare.UseVisualStyleBackColor = False
        '
        'ButtonSalesReport
        '
        Me.ButtonSalesReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonSalesReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalesReport.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalesReport.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonSalesReport.Location = New System.Drawing.Point(359, 497)
        Me.ButtonSalesReport.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSalesReport.Name = "ButtonSalesReport"
        Me.ButtonSalesReport.Size = New System.Drawing.Size(256, 47)
        Me.ButtonSalesReport.TabIndex = 5
        Me.ButtonSalesReport.Text = "Check Sales Report"
        Me.ButtonSalesReport.UseVisualStyleBackColor = False
        '
        'LabelWelcomeUsername
        '
        Me.LabelWelcomeUsername.AutoSize = True
        Me.LabelWelcomeUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabelWelcomeUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcomeUsername.Location = New System.Drawing.Point(492, 256)
        Me.LabelWelcomeUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelWelcomeUsername.Name = "LabelWelcomeUsername"
        Me.LabelWelcomeUsername.Size = New System.Drawing.Size(78, 44)
        Me.LabelWelcomeUsername.TabIndex = 4
        Me.LabelWelcomeUsername.Text = "UN"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(391, 44)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(179, 165)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 3
        Me.PictureBoxLogo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(577, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 44)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "UN"
        '
        'Admin_Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1403, 861)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin_Welcome"
        Me.Text = "Admin_Welcome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonLogout As System.Windows.Forms.Button
    Friend WithEvents ButtonRegisterAdmin As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LabelWelcomeUsername As System.Windows.Forms.Label
    Friend WithEvents ButtonCustomerCare As System.Windows.Forms.Button
    Friend WithEvents ButtonSalesReport As System.Windows.Forms.Button
    Friend WithEvents ButtonAddTrain As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
