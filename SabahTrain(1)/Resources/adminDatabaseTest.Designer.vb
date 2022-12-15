<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDatabaseTest
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
        Dim AdminIDLabel As System.Windows.Forms.Label
        Dim AdminNameLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim AccessLevelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDatabaseTest))
        Me.SabahTrainDatabase2000DataSet = New SabahTrain_1_.SabahTrainDatabase2000DataSet()
        Me.Tbl_adminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_adminTableAdapter = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_adminTableAdapter()
        Me.TableAdapterManager = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager()
        Me.Tbl_adminBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdminIDTextBox = New System.Windows.Forms.TextBox()
        Me.AdminNameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AccessLevelTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_adminBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        AdminIDLabel = New System.Windows.Forms.Label()
        AdminNameLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        AccessLevelLabel = New System.Windows.Forms.Label()
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_adminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_adminBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_adminBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SabahTrainDatabase2000DataSet
        '
        Me.SabahTrainDatabase2000DataSet.DataSetName = "SabahTrainDatabase2000DataSet"
        Me.SabahTrainDatabase2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_adminBindingSource
        '
        Me.Tbl_adminBindingSource.DataMember = "tbl_admin"
        Me.Tbl_adminBindingSource.DataSource = Me.SabahTrainDatabase2000DataSet
        '
        'Tbl_adminTableAdapter
        '
        Me.Tbl_adminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_adminTableAdapter = Me.Tbl_adminTableAdapter
        Me.TableAdapterManager.tbl_customerCareTableAdapter = Nothing
        Me.TableAdapterManager.tbl_trainTableAdapter = Nothing
        Me.TableAdapterManager.tbl_transactionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_adminBindingNavigator
        '
        Me.Tbl_adminBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_adminBindingNavigator.BindingSource = Me.Tbl_adminBindingSource
        Me.Tbl_adminBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_adminBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_adminBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_adminBindingNavigatorSaveItem})
        Me.Tbl_adminBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_adminBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_adminBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_adminBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_adminBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_adminBindingNavigator.Name = "Tbl_adminBindingNavigator"
        Me.Tbl_adminBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_adminBindingNavigator.Size = New System.Drawing.Size(1409, 27)
        Me.Tbl_adminBindingNavigator.TabIndex = 0
        Me.Tbl_adminBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'AdminIDLabel
        '
        AdminIDLabel.AutoSize = True
        AdminIDLabel.Location = New System.Drawing.Point(45, 86)
        AdminIDLabel.Name = "AdminIDLabel"
        AdminIDLabel.Size = New System.Drawing.Size(68, 17)
        AdminIDLabel.TabIndex = 1
        AdminIDLabel.Text = "Admin ID:"
        '
        'AdminIDTextBox
        '
        Me.AdminIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "AdminID", True))
        Me.AdminIDTextBox.Location = New System.Drawing.Point(146, 83)
        Me.AdminIDTextBox.Name = "AdminIDTextBox"
        Me.AdminIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AdminIDTextBox.TabIndex = 2
        '
        'AdminNameLabel
        '
        AdminNameLabel.AutoSize = True
        AdminNameLabel.Location = New System.Drawing.Point(45, 114)
        AdminNameLabel.Name = "AdminNameLabel"
        AdminNameLabel.Size = New System.Drawing.Size(92, 17)
        AdminNameLabel.TabIndex = 3
        AdminNameLabel.Text = "Admin Name:"
        '
        'AdminNameTextBox
        '
        Me.AdminNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "AdminName", True))
        Me.AdminNameTextBox.Location = New System.Drawing.Point(146, 111)
        Me.AdminNameTextBox.Name = "AdminNameTextBox"
        Me.AdminNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AdminNameTextBox.TabIndex = 4
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(45, 142)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(77, 17)
        UsernameLabel.TabIndex = 5
        UsernameLabel.Text = "Username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(146, 139)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox.TabIndex = 6
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(45, 170)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(73, 17)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(146, 167)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PasswordTextBox.TabIndex = 8
        '
        'AccessLevelLabel
        '
        AccessLevelLabel.AutoSize = True
        AccessLevelLabel.Location = New System.Drawing.Point(45, 198)
        AccessLevelLabel.Name = "AccessLevelLabel"
        AccessLevelLabel.Size = New System.Drawing.Size(95, 17)
        AccessLevelLabel.TabIndex = 9
        AccessLevelLabel.Text = "Access Level:"
        '
        'AccessLevelTextBox
        '
        Me.AccessLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "AccessLevel", True))
        Me.AccessLevelTextBox.Location = New System.Drawing.Point(146, 195)
        Me.AccessLevelTextBox.Name = "AccessLevelTextBox"
        Me.AccessLevelTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AccessLevelTextBox.TabIndex = 10
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
        'Tbl_adminBindingNavigatorSaveItem
        '
        Me.Tbl_adminBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_adminBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_adminBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_adminBindingNavigatorSaveItem.Name = "Tbl_adminBindingNavigatorSaveItem"
        Me.Tbl_adminBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Tbl_adminBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(61, 302)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "add new"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'adminDatabaseTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1409, 732)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(AdminIDLabel)
        Me.Controls.Add(Me.AdminIDTextBox)
        Me.Controls.Add(AdminNameLabel)
        Me.Controls.Add(Me.AdminNameTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(AccessLevelLabel)
        Me.Controls.Add(Me.AccessLevelTextBox)
        Me.Controls.Add(Me.Tbl_adminBindingNavigator)
        Me.Name = "adminDatabaseTest"
        Me.Text = "adminDatabaseTest"
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_adminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_adminBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_adminBindingNavigator.ResumeLayout(False)
        Me.Tbl_adminBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents AdminIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdminNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccessLevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
