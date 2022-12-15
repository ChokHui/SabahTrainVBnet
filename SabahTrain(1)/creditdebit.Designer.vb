<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class creditdebit
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
        Me.Buttontouchngo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Buttontouchngo
        '
        Me.Buttontouchngo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Buttontouchngo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttontouchngo.Location = New System.Drawing.Point(301, 240)
        Me.Buttontouchngo.Name = "Buttontouchngo"
        Me.Buttontouchngo.Size = New System.Drawing.Size(215, 37)
        Me.Buttontouchngo.TabIndex = 1
        Me.Buttontouchngo.Text = "Proceed to payment"
        Me.Buttontouchngo.UseVisualStyleBackColor = True
        '
        'creditdebit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SabahTrain_1_.My.Resources.Resources.creditdebit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(815, 514)
        Me.Controls.Add(Me.Buttontouchngo)
        Me.Name = "creditdebit"
        Me.Text = "creditdebit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Buttontouchngo As System.Windows.Forms.Button
End Class
