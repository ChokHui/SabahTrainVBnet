<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Database
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
    Friend WithEvents SabahTrainDatabase2000DataSet As SabahTrain_1_.SabahTrainDatabase2000DataSet
    Friend WithEvents Tbl_adminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_adminTableAdapter As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_adminTableAdapter
    Friend WithEvents TableAdapterManager As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_adminBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_adminBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBoxAdminName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAccessLevel As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents TextBoxAdminID As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents AdminIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdminNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

    ''NOTE: The following procedure is required by the Windows Form Designer
    ''It can be modified using the Windows Form Designer.  
    ''Do not modify it using the code editor.
    '<System.Diagnostics.DebuggerStepThrough()> _
    'Private Sub InitializeComponent()
    '    Me.components = New System.ComponentModel.Container()
    '    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Database))
    '    Dim AdminIDLabel As System.Windows.Forms.Label
    '    Dim AdminNameLabel As System.Windows.Forms.Label
    '    Dim UsernameLabel As System.Windows.Forms.Label
    '    Dim PasswordLabel As System.Windows.Forms.Label
    '    Dim AccessLevelLabel As System.Windows.Forms.Label
    '    Me.SabahTrainDatabase2000DataSet1 = New SabahTrain_1_.SabahTrainDatabase2000DataSet()
    '    Me.Tbl_adminBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    '    Me.Tbl_adminTableAdapter1 = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_adminTableAdapter()
    '    Me.TableAdapterManager1 = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager()
    '    Me.Tbl_adminBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
    '    Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
    '    Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
    '    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    '    Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
    '    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    '    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    '    Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
    '    Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
    '    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    '    Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
    '    Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
    '    Me.Tbl_adminBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
    '    Me.AdminIDTextBox = New System.Windows.Forms.TextBox()
    '    Me.AdminNameTextBox = New System.Windows.Forms.TextBox()
    '    Me.UsernameTextBox = New System.Windows.Forms.TextBox()
    '    Me.PasswordTextBox = New System.Windows.Forms.TextBox()
    '    Me.AccessLevelTextBox = New System.Windows.Forms.TextBox()
    '    Me.ButtonRegisterAdmin = New System.Windows.Forms.Button()
    '    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    '    AdminIDLabel = New System.Windows.Forms.Label()
    '    AdminNameLabel = New System.Windows.Forms.Label()
    '    UsernameLabel = New System.Windows.Forms.Label()
    '    PasswordLabel = New System.Windows.Forms.Label()
    '    AccessLevelLabel = New System.Windows.Forms.Label()
    '    CType(Me.SabahTrainDatabase2000DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.Tbl_adminBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    '    CType(Me.Tbl_adminBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
    '    Me.Tbl_adminBindingSource1BindingNavigator.SuspendLayout()
    '    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    '    Me.SuspendLayout()
    '    '
    '    'SabahTrainDatabase2000DataSet1
    '    '
    '    Me.SabahTrainDatabase2000DataSet1.DataSetName = "SabahTrainDatabase2000DataSet"
    '    Me.SabahTrainDatabase2000DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '    '
    '    'Tbl_adminBindingSource1
    '    '
    '    Me.Tbl_adminBindingSource1.DataMember = "tbl_admin"
    '    Me.Tbl_adminBindingSource1.DataSource = Me.SabahTrainDatabase2000DataSet1
    '    '
    '    'Tbl_adminTableAdapter1
    '    '
    '    Me.Tbl_adminTableAdapter1.ClearBeforeFill = True
    '    '
    '    'TableAdapterManager1
    '    '
    '    Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
    '    Me.TableAdapterManager1.tbl_adminTableAdapter = Me.Tbl_adminTableAdapter1
    '    Me.TableAdapterManager1.tbl_customerCareTableAdapter = Nothing
    '    Me.TableAdapterManager1.tbl_trainTableAdapter = Nothing
    '    Me.TableAdapterManager1.tbl_transactionTableAdapter = Nothing
    '    Me.TableAdapterManager1.UpdateOrder = SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
    '    '
    '    'Tbl_adminBindingSource1BindingNavigator
    '    '
    '    Me.Tbl_adminBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
    '    Me.Tbl_adminBindingSource1BindingNavigator.BindingSource = Me.Tbl_adminBindingSource1
    '    Me.Tbl_adminBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
    '    Me.Tbl_adminBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
    '    Me.Tbl_adminBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.Tbl_adminBindingSource1BindingNavigatorSaveItem})
    '    Me.Tbl_adminBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
    '    Me.Tbl_adminBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
    '    Me.Tbl_adminBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
    '    Me.Tbl_adminBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
    '    Me.Tbl_adminBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
    '    Me.Tbl_adminBindingSource1BindingNavigator.Name = "Tbl_adminBindingSource1BindingNavigator"
    '    Me.Tbl_adminBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
    '    Me.Tbl_adminBindingSource1BindingNavigator.Size = New System.Drawing.Size(1425, 27)
    '    Me.Tbl_adminBindingSource1BindingNavigator.TabIndex = 0
    '    Me.Tbl_adminBindingSource1BindingNavigator.Text = "BindingNavigator1"
    '    '
    '    'ToolStripButton1
    '    '
    '    Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    '    Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
    '    Me.ToolStripButton1.Name = "BindingNavigatorMoveFirstItem"
    '    Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
    '    Me.ToolStripButton1.Size = New System.Drawing.Size(23, 24)
    '    Me.ToolStripButton1.Text = "Move first"
    '    '
    '    'ToolStripButton2
    '    '
    '    Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    '    Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
    '    Me.ToolStripButton2.Name = "BindingNavigatorMovePreviousItem"
    '    Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
    '    Me.ToolStripButton2.Size = New System.Drawing.Size(23, 24)
    '    Me.ToolStripButton2.Text = "Move previous"
    '    '
    '    'ToolStripSeparator1
    '    '
    '    Me.ToolStripSeparator1.Name = "BindingNavigatorSeparator"
    '    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
    '    '
    '    'ToolStripTextBox1
    '    '
    '    Me.ToolStripTextBox1.AccessibleName = "Position"
    '    Me.ToolStripTextBox1.AutoSize = False
    '    Me.ToolStripTextBox1.Name = "BindingNavigatorPositionItem"
    '    Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 27)
    '    Me.ToolStripTextBox1.Text = "0"
    '    Me.ToolStripTextBox1.ToolTipText = "Current position"
    '    '
    '    'ToolStripLabel1
    '    '
    '    Me.ToolStripLabel1.Name = "BindingNavigatorCountItem"
    '    Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 24)
    '    Me.ToolStripLabel1.Text = "of {0}"
    '    Me.ToolStripLabel1.ToolTipText = "Total number of items"
    '    '
    '    'ToolStripSeparator2
    '    '
    '    Me.ToolStripSeparator2.Name = "BindingNavigatorSeparator"
    '    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
    '    '
    '    'ToolStripButton3
    '    '
    '    Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    '    Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
    '    Me.ToolStripButton3.Name = "BindingNavigatorMoveNextItem"
    '    Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
    '    Me.ToolStripButton3.Size = New System.Drawing.Size(23, 24)
    '    Me.ToolStripButton3.Text = "Move next"
    '    '
    '    'ToolStripButton4
    '    '
    '    Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    '    Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
    '    Me.ToolStripButton4.Name = "BindingNavigatorMoveLastItem"
    '    Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
    '    Me.ToolStripButton4.Size = New System.Drawing.Size(23, 24)
    '    Me.ToolStripButton4.Text = "Move last"
    '    '
    '    'ToolStripSeparator3
    '    '
    '    Me.ToolStripSeparator3.Name = "BindingNavigatorSeparator"
    '    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
    '    '
    '    'ToolStripButton5
    '    '
    '    Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    '    Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
    '    Me.ToolStripButton5.Name = "BindingNavigatorAddNewItem"
    '    Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
    '    Me.ToolStripButton5.Size = New System.Drawing.Size(23, 24)
    '    Me.ToolStripButton5.Text = "Add new"
    '    '
    '    'ToolStripButton6
    '    '
    '    Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    '    Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
    '    Me.ToolStripButton6.Name = "BindingNavigatorDeleteItem"
    '    Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
    '    Me.ToolStripButton6.Size = New System.Drawing.Size(23, 24)
    '    Me.ToolStripButton6.Text = "Delete"
    '    '
    '    'Tbl_adminBindingSource1BindingNavigatorSaveItem
    '    '
    '    Me.Tbl_adminBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    '    Me.Tbl_adminBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_adminBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
    '    Me.Tbl_adminBindingSource1BindingNavigatorSaveItem.Name = "Tbl_adminBindingSource1BindingNavigatorSaveItem"
    '    Me.Tbl_adminBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
    '    Me.Tbl_adminBindingSource1BindingNavigatorSaveItem.Text = "Save Data"
    '    '
    '    'AdminIDLabel
    '    '
    '    AdminIDLabel.AutoSize = True
    '    AdminIDLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    AdminIDLabel.Location = New System.Drawing.Point(81, 283)
    '    AdminIDLabel.Name = "AdminIDLabel"
    '    AdminIDLabel.Size = New System.Drawing.Size(126, 28)
    '    AdminIDLabel.TabIndex = 1
    '    AdminIDLabel.Text = "Admin ID:"
    '    '
    '    'AdminIDTextBox
    '    '
    '    Me.AdminIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource1, "AdminID", True))
    '    Me.AdminIDTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    Me.AdminIDTextBox.Location = New System.Drawing.Point(77, 340)
    '    Me.AdminIDTextBox.Name = "AdminIDTextBox"
    '    Me.AdminIDTextBox.Size = New System.Drawing.Size(177, 34)
    '    Me.AdminIDTextBox.TabIndex = 2
    '    '
    '    'AdminNameLabel
    '    '
    '    AdminNameLabel.AutoSize = True
    '    AdminNameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    AdminNameLabel.Location = New System.Drawing.Point(320, 283)
    '    AdminNameLabel.Name = "AdminNameLabel"
    '    AdminNameLabel.Size = New System.Drawing.Size(167, 28)
    '    AdminNameLabel.TabIndex = 3
    '    AdminNameLabel.Text = "Admin Name:"
    '    '
    '    'AdminNameTextBox
    '    '
    '    Me.AdminNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource1, "AdminName", True))
    '    Me.AdminNameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    Me.AdminNameTextBox.Location = New System.Drawing.Point(325, 340)
    '    Me.AdminNameTextBox.Name = "AdminNameTextBox"
    '    Me.AdminNameTextBox.Size = New System.Drawing.Size(227, 34)
    '    Me.AdminNameTextBox.TabIndex = 4
    '    '
    '    'UsernameLabel
    '    '
    '    UsernameLabel.AutoSize = True
    '    UsernameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    UsernameLabel.Location = New System.Drawing.Point(613, 283)
    '    UsernameLabel.Name = "UsernameLabel"
    '    UsernameLabel.Size = New System.Drawing.Size(139, 28)
    '    UsernameLabel.TabIndex = 5
    '    UsernameLabel.Text = "Username:"
    '    '
    '    'UsernameTextBox
    '    '
    '    Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource1, "Username", True))
    '    Me.UsernameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    Me.UsernameTextBox.Location = New System.Drawing.Point(618, 340)
    '    Me.UsernameTextBox.Name = "UsernameTextBox"
    '    Me.UsernameTextBox.Size = New System.Drawing.Size(227, 34)
    '    Me.UsernameTextBox.TabIndex = 6
    '    '
    '    'PasswordLabel
    '    '
    '    PasswordLabel.AutoSize = True
    '    PasswordLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    PasswordLabel.Location = New System.Drawing.Point(907, 283)
    '    PasswordLabel.Name = "PasswordLabel"
    '    PasswordLabel.Size = New System.Drawing.Size(136, 28)
    '    PasswordLabel.TabIndex = 7
    '    PasswordLabel.Text = "Password:"
    '    '
    '    'PasswordTextBox
    '    '
    '    Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource1, "Password", True))
    '    Me.PasswordTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    Me.PasswordTextBox.Location = New System.Drawing.Point(912, 340)
    '    Me.PasswordTextBox.Name = "PasswordTextBox"
    '    Me.PasswordTextBox.Size = New System.Drawing.Size(227, 34)
    '    Me.PasswordTextBox.TabIndex = 8
    '    '
    '    'AccessLevelLabel
    '    '
    '    AccessLevelLabel.AutoSize = True
    '    AccessLevelLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    AccessLevelLabel.Location = New System.Drawing.Point(1186, 283)
    '    AccessLevelLabel.Name = "AccessLevelLabel"
    '    AccessLevelLabel.Size = New System.Drawing.Size(173, 28)
    '    AccessLevelLabel.TabIndex = 9
    '    AccessLevelLabel.Text = "Access Level:"
    '    '
    '    'AccessLevelTextBox
    '    '
    '    Me.AccessLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource1, "AccessLevel", True))
    '    Me.AccessLevelTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    Me.AccessLevelTextBox.Location = New System.Drawing.Point(1200, 340)
    '    Me.AccessLevelTextBox.Name = "AccessLevelTextBox"
    '    Me.AccessLevelTextBox.Size = New System.Drawing.Size(177, 34)
    '    Me.AccessLevelTextBox.TabIndex = 10
    '    '
    '    'ButtonRegisterAdmin
    '    '
    '    Me.ButtonRegisterAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
    '    Me.ButtonRegisterAdmin.Cursor = System.Windows.Forms.Cursors.Hand
    '    Me.ButtonRegisterAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    '    Me.ButtonRegisterAdmin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    Me.ButtonRegisterAdmin.ForeColor = System.Drawing.SystemColors.Control
    '    Me.ButtonRegisterAdmin.Location = New System.Drawing.Point(77, 405)
    '    Me.ButtonRegisterAdmin.Margin = New System.Windows.Forms.Padding(4)
    '    Me.ButtonRegisterAdmin.Name = "ButtonRegisterAdmin"
    '    Me.ButtonRegisterAdmin.Size = New System.Drawing.Size(177, 47)
    '    Me.ButtonRegisterAdmin.TabIndex = 11
    '    Me.ButtonRegisterAdmin.Text = "Search"
    '    Me.ButtonRegisterAdmin.UseVisualStyleBackColor = False
    '    '
    '    'PictureBox1
    '    '
    '    Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
    '    Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
    '    Me.PictureBox1.Location = New System.Drawing.Point(632, 64)
    '    Me.PictureBox1.Name = "PictureBox1"
    '    Me.PictureBox1.Size = New System.Drawing.Size(179, 165)
    '    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    '    Me.PictureBox1.TabIndex = 12
    '    Me.PictureBox1.TabStop = False
    '    '
    '    'Admin_Database
    '    '
    '    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    '    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    '    Me.ClientSize = New System.Drawing.Size(1425, 769)
    '    Me.Controls.Add(Me.PictureBox1)
    '    Me.Controls.Add(Me.ButtonRegisterAdmin)
    '    Me.Controls.Add(AdminIDLabel)
    '    Me.Controls.Add(Me.AdminIDTextBox)
    '    Me.Controls.Add(AdminNameLabel)
    '    Me.Controls.Add(Me.AdminNameTextBox)
    '    Me.Controls.Add(UsernameLabel)
    '    Me.Controls.Add(Me.UsernameTextBox)
    '    Me.Controls.Add(PasswordLabel)
    '    Me.Controls.Add(Me.PasswordTextBox)
    '    Me.Controls.Add(AccessLevelLabel)
    '    Me.Controls.Add(Me.AccessLevelTextBox)
    '    Me.Controls.Add(Me.Tbl_adminBindingSource1BindingNavigator)
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    Me.Name = "Admin_Database"
    '    CType(Me.SabahTrainDatabase2000DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.Tbl_adminBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    '    CType(Me.Tbl_adminBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
    '    Me.Tbl_adminBindingSource1BindingNavigator.ResumeLayout(False)
    '    Me.Tbl_adminBindingSource1BindingNavigator.PerformLayout()
    '    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    '    Me.ResumeLayout(False)
    '    Me.PerformLayout()

    'End Sub
    'Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    'Friend WithEvents SabahTrainDatabase2000DataSet As SabahTrain_1_.SabahTrainDatabase2000DataSet
    'Friend WithEvents Tbl_adminBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents Tbl_adminTableAdapter As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_adminTableAdapter
    'Friend WithEvents TableAdapterManager As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager
    'Friend WithEvents Tbl_adminBindingNavigator As System.Windows.Forms.BindingNavigator
    'Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    'Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    'Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents Tbl_adminBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents TextBoxAdminID As System.Windows.Forms.TextBox
    'Friend WithEvents TextBoxAdminName As System.Windows.Forms.TextBox
    'Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    'Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    'Friend WithEvents TextBoxAccessLevel As System.Windows.Forms.TextBox
    'Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    'Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    'Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    'Friend WithEvents ButtonClear As System.Windows.Forms.Button
    'Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    'Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    'Friend WithEvents SabahTrainDatabase2000DataSet1 As SabahTrain_1_.SabahTrainDatabase2000DataSet
    'Friend WithEvents Tbl_adminBindingSource1 As System.Windows.Forms.BindingSource
    'Friend WithEvents Tbl_adminTableAdapter1 As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_adminTableAdapter
    'Friend WithEvents TableAdapterManager1 As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager
    'Friend WithEvents Tbl_adminBindingSource1BindingNavigator As System.Windows.Forms.BindingNavigator
    'Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    'Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    'Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    'Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    'Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    'Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    'Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    'Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    'Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents Tbl_adminBindingSource1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents AdminIDTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents AdminNameTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents AccessLevelTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents ButtonRegisterAdmin As System.Windows.Forms.Button
    'Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
