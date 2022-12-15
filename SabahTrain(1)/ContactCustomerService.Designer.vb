<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactCustomerService
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
        Me.components = New System.ComponentModel.Container()
        Dim LabelCustomerName As System.Windows.Forms.Label
        Dim LabelEmailAddress As System.Windows.Forms.Label
        Dim LabelComplaintMessage As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactCustomerService))
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.SabahTrainDatabase2000DataSet = New SabahTrain_1_.SabahTrainDatabase2000DataSet()
        Me.Tbl_customerCareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_customerCareTableAdapter = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_customerCareTableAdapter()
        Me.TableAdapterManager = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager()
        Me.Tbl_customerCareBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_customerCareBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TextBoxCustomerName = New System.Windows.Forms.TextBox()
        Me.TextBoxEmailAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxComplaintMessage = New System.Windows.Forms.TextBox()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        LabelCustomerName = New System.Windows.Forms.Label()
        LabelEmailAddress = New System.Windows.Forms.Label()
        LabelComplaintMessage = New System.Windows.Forms.Label()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_customerCareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_customerCareBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_customerCareBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCustomerName
        '
        LabelCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top
        LabelCustomerName.AutoSize = True
        LabelCustomerName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelCustomerName.Location = New System.Drawing.Point(1217, 292)
        LabelCustomerName.Name = "LabelCustomerName"
        LabelCustomerName.Size = New System.Drawing.Size(87, 28)
        LabelCustomerName.TabIndex = 13
        LabelCustomerName.Text = "Name:"
        '
        'LabelEmailAddress
        '
        LabelEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        LabelEmailAddress.AutoSize = True
        LabelEmailAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelEmailAddress.Location = New System.Drawing.Point(1217, 401)
        LabelEmailAddress.Name = "LabelEmailAddress"
        LabelEmailAddress.Size = New System.Drawing.Size(197, 28)
        LabelEmailAddress.TabIndex = 15
        LabelEmailAddress.Text = "E-mail Address:"
        AddHandler LabelEmailAddress.Click, AddressOf Me.EmailAddressLabel_Click
        '
        'LabelComplaintMessage
        '
        LabelComplaintMessage.Anchor = System.Windows.Forms.AnchorStyles.Top
        LabelComplaintMessage.AutoSize = True
        LabelComplaintMessage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelComplaintMessage.Location = New System.Drawing.Point(53, 249)
        LabelComplaintMessage.Name = "LabelComplaintMessage"
        LabelComplaintMessage.Size = New System.Drawing.Size(408, 28)
        LabelComplaintMessage.TabIndex = 17
        LabelComplaintMessage.Text = "Please enter your message here..."
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(655, 45)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(179, 165)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 12
        Me.PictureBoxLogo.TabStop = False
        '
        'SabahTrainDatabase2000DataSet
        '
        Me.SabahTrainDatabase2000DataSet.DataSetName = "SabahTrainDatabase2000DataSet"
        Me.SabahTrainDatabase2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_customerCareBindingSource
        '
        Me.Tbl_customerCareBindingSource.DataMember = "tbl_customerCare"
        Me.Tbl_customerCareBindingSource.DataSource = Me.SabahTrainDatabase2000DataSet
        '
        'Tbl_customerCareTableAdapter
        '
        Me.Tbl_customerCareTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_adminTableAdapter = Nothing
        Me.TableAdapterManager.tbl_customerCareTableAdapter = Me.Tbl_customerCareTableAdapter
        Me.TableAdapterManager.tbl_trainTableAdapter = Nothing
        Me.TableAdapterManager.tbl_transactionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_customerCareBindingNavigator
        '
        Me.Tbl_customerCareBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_customerCareBindingNavigator.BindingSource = Me.Tbl_customerCareBindingSource
        Me.Tbl_customerCareBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_customerCareBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_customerCareBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_customerCareBindingNavigatorSaveItem})
        Me.Tbl_customerCareBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_customerCareBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_customerCareBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_customerCareBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_customerCareBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_customerCareBindingNavigator.Name = "Tbl_customerCareBindingNavigator"
        Me.Tbl_customerCareBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_customerCareBindingNavigator.Size = New System.Drawing.Size(1353, 27)
        Me.Tbl_customerCareBindingNavigator.TabIndex = 13
        Me.Tbl_customerCareBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Tbl_customerCareBindingNavigatorSaveItem
        '
        Me.Tbl_customerCareBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_customerCareBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_customerCareBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_customerCareBindingNavigatorSaveItem.Name = "Tbl_customerCareBindingNavigatorSaveItem"
        Me.Tbl_customerCareBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Tbl_customerCareBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxCustomerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_customerCareBindingSource, "CustomerName", True))
        Me.TextBoxCustomerName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(1222, 332)
        Me.TextBoxCustomerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(419, 34)
        Me.TextBoxCustomerName.TabIndex = 14
        '
        'TextBoxEmailAddress
        '
        Me.TextBoxEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxEmailAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_customerCareBindingSource, "emailAddress", True))
        Me.TextBoxEmailAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmailAddress.Location = New System.Drawing.Point(1222, 446)
        Me.TextBoxEmailAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxEmailAddress.Name = "TextBoxEmailAddress"
        Me.TextBoxEmailAddress.Size = New System.Drawing.Size(419, 34)
        Me.TextBoxEmailAddress.TabIndex = 16
        '
        'TextBoxComplaintMessage
        '
        Me.TextBoxComplaintMessage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxComplaintMessage.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_customerCareBindingSource, "complaintMessage", True))
        Me.TextBoxComplaintMessage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxComplaintMessage.Location = New System.Drawing.Point(58, 292)
        Me.TextBoxComplaintMessage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxComplaintMessage.Multiline = True
        Me.TextBoxComplaintMessage.Name = "TextBoxComplaintMessage"
        Me.TextBoxComplaintMessage.Size = New System.Drawing.Size(1087, 486)
        Me.TextBoxComplaintMessage.TabIndex = 18
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonSubmit.AutoSize = True
        Me.ButtonSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSubmit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubmit.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonSubmit.Location = New System.Drawing.Point(1322, 569)
        Me.ButtonSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(227, 39)
        Me.ButtonSubmit.TabIndex = 19
        Me.ButtonSubmit.Text = "Submit"
        Me.ButtonSubmit.UseVisualStyleBackColor = False
        '
        'ButtonBack
        '
        Me.ButtonBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonBack.BackColor = System.Drawing.Color.LightGray
        Me.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBack.Location = New System.Drawing.Point(1322, 720)
        Me.ButtonBack.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(227, 39)
        Me.ButtonBack.TabIndex = 20
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1322, 644)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 39)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Clear form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContactCustomerService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1353, 747)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(LabelCustomerName)
        Me.Controls.Add(Me.TextBoxCustomerName)
        Me.Controls.Add(LabelEmailAddress)
        Me.Controls.Add(Me.TextBoxEmailAddress)
        Me.Controls.Add(LabelComplaintMessage)
        Me.Controls.Add(Me.TextBoxComplaintMessage)
        Me.Controls.Add(Me.Tbl_customerCareBindingNavigator)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ContactCustomerService"
        Me.Text = "ContactCustomerService"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_customerCareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_customerCareBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_customerCareBindingNavigator.ResumeLayout(False)
        Me.Tbl_customerCareBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents SabahTrainDatabase2000DataSet As SabahTrain_1_.SabahTrainDatabase2000DataSet
    Friend WithEvents Tbl_customerCareBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_customerCareTableAdapter As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_customerCareTableAdapter
    Friend WithEvents TableAdapterManager As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_customerCareBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_customerCareBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBoxCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxComplaintMessage As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
