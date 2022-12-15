<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Train
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
        Dim LabelTrainNo As System.Windows.Forms.Label
        Dim LabelDeparture As System.Windows.Forms.Label
        Dim LabelArrival As System.Windows.Forms.Label
        Dim LabelPrice As System.Windows.Forms.Label
        Dim LabelTimeDepart As System.Windows.Forms.Label
        Dim LabelDateDepart As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Train))
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.SabahTrainDatabase2000DataSet = New SabahTrain_1_.SabahTrainDatabase2000DataSet()
        Me.Tbl_trainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_trainTableAdapter = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_trainTableAdapter()
        Me.TableAdapterManager = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager()
        Me.Tbl_trainBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_trainBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TextBoxTrainNo = New System.Windows.Forms.TextBox()
        Me.TextBoxDeparture = New System.Windows.Forms.TextBox()
        Me.TextBoxArrival = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxTimeDepart = New System.Windows.Forms.TextBox()
        Me.DateTimePickerDateDepart = New System.Windows.Forms.DateTimePicker()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Tbl_adminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_adminTableAdapter = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_adminTableAdapter()
        Me.ButtonBack = New System.Windows.Forms.Button()
        LabelTrainNo = New System.Windows.Forms.Label()
        LabelDeparture = New System.Windows.Forms.Label()
        LabelArrival = New System.Windows.Forms.Label()
        LabelPrice = New System.Windows.Forms.Label()
        LabelTimeDepart = New System.Windows.Forms.Label()
        LabelDateDepart = New System.Windows.Forms.Label()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_trainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_trainBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_trainBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_adminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTrainNo
        '
        LabelTrainNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        LabelTrainNo.AutoSize = True
        LabelTrainNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelTrainNo.Location = New System.Drawing.Point(28, 251)
        LabelTrainNo.Name = "LabelTrainNo"
        LabelTrainNo.Size = New System.Drawing.Size(119, 28)
        LabelTrainNo.TabIndex = 13
        LabelTrainNo.Text = "Train No:"
        '
        'LabelDeparture
        '
        LabelDeparture.Anchor = System.Windows.Forms.AnchorStyles.Top
        LabelDeparture.AutoSize = True
        LabelDeparture.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelDeparture.Location = New System.Drawing.Point(212, 251)
        LabelDeparture.Name = "LabelDeparture"
        LabelDeparture.Size = New System.Drawing.Size(139, 28)
        LabelDeparture.TabIndex = 15
        LabelDeparture.Text = "Departure:"
        '
        'LabelArrival
        '
        LabelArrival.Anchor = System.Windows.Forms.AnchorStyles.Top
        LabelArrival.AutoSize = True
        LabelArrival.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelArrival.Location = New System.Drawing.Point(486, 251)
        LabelArrival.Name = "LabelArrival"
        LabelArrival.Size = New System.Drawing.Size(100, 28)
        LabelArrival.TabIndex = 17
        LabelArrival.Text = "Arrival:"
        '
        'LabelPrice
        '
        LabelPrice.Anchor = System.Windows.Forms.AnchorStyles.Top
        LabelPrice.AutoSize = True
        LabelPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelPrice.Location = New System.Drawing.Point(758, 251)
        LabelPrice.Name = "LabelPrice"
        LabelPrice.Size = New System.Drawing.Size(82, 28)
        LabelPrice.TabIndex = 19
        LabelPrice.Text = "Price:"
        '
        'LabelTimeDepart
        '
        LabelTimeDepart.Anchor = System.Windows.Forms.AnchorStyles.Top
        LabelTimeDepart.AutoSize = True
        LabelTimeDepart.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelTimeDepart.Location = New System.Drawing.Point(911, 251)
        LabelTimeDepart.Name = "LabelTimeDepart"
        LabelTimeDepart.Size = New System.Drawing.Size(163, 28)
        LabelTimeDepart.TabIndex = 21
        LabelTimeDepart.Text = "Time Depart:"
        '
        'LabelDateDepart
        '
        LabelDateDepart.Anchor = System.Windows.Forms.AnchorStyles.Top
        LabelDateDepart.AutoSize = True
        LabelDateDepart.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelDateDepart.Location = New System.Drawing.Point(1094, 251)
        LabelDateDepart.Name = "LabelDateDepart"
        LabelDateDepart.Size = New System.Drawing.Size(160, 28)
        LabelDateDepart.TabIndex = 23
        LabelDateDepart.Text = "Date Depart:"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(661, 59)
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
        'Tbl_trainBindingSource
        '
        Me.Tbl_trainBindingSource.DataMember = "tbl_train"
        Me.Tbl_trainBindingSource.DataSource = Me.SabahTrainDatabase2000DataSet
        '
        'Tbl_trainTableAdapter
        '
        Me.Tbl_trainTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_adminTableAdapter = Nothing
        Me.TableAdapterManager.tbl_customerCareTableAdapter = Nothing
        Me.TableAdapterManager.tbl_trainTableAdapter = Me.Tbl_trainTableAdapter
        Me.TableAdapterManager.tbl_transactionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_trainBindingNavigator
        '
        Me.Tbl_trainBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_trainBindingNavigator.BindingSource = Me.Tbl_trainBindingSource
        Me.Tbl_trainBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_trainBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_trainBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_trainBindingNavigatorSaveItem})
        Me.Tbl_trainBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_trainBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_trainBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_trainBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_trainBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_trainBindingNavigator.Name = "Tbl_trainBindingNavigator"
        Me.Tbl_trainBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_trainBindingNavigator.Size = New System.Drawing.Size(1513, 27)
        Me.Tbl_trainBindingNavigator.TabIndex = 13
        Me.Tbl_trainBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
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
        'Tbl_trainBindingNavigatorSaveItem
        '
        Me.Tbl_trainBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_trainBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_trainBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_trainBindingNavigatorSaveItem.Name = "Tbl_trainBindingNavigatorSaveItem"
        Me.Tbl_trainBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Tbl_trainBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TextBoxTrainNo
        '
        Me.TextBoxTrainNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxTrainNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_trainBindingSource, "TrainNo", True))
        Me.TextBoxTrainNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTrainNo.Location = New System.Drawing.Point(33, 300)
        Me.TextBoxTrainNo.Name = "TextBoxTrainNo"
        Me.TextBoxTrainNo.Size = New System.Drawing.Size(165, 34)
        Me.TextBoxTrainNo.TabIndex = 14
        '
        'TextBoxDeparture
        '
        Me.TextBoxDeparture.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxDeparture.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_trainBindingSource, "Departure", True))
        Me.TextBoxDeparture.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDeparture.Location = New System.Drawing.Point(217, 300)
        Me.TextBoxDeparture.Name = "TextBoxDeparture"
        Me.TextBoxDeparture.Size = New System.Drawing.Size(256, 34)
        Me.TextBoxDeparture.TabIndex = 16
        '
        'TextBoxArrival
        '
        Me.TextBoxArrival.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxArrival.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_trainBindingSource, "Arrival", True))
        Me.TextBoxArrival.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxArrival.Location = New System.Drawing.Point(491, 300)
        Me.TextBoxArrival.Name = "TextBoxArrival"
        Me.TextBoxArrival.Size = New System.Drawing.Size(256, 34)
        Me.TextBoxArrival.TabIndex = 18
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_trainBindingSource, "Price", True))
        Me.TextBoxPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrice.Location = New System.Drawing.Point(763, 300)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(134, 34)
        Me.TextBoxPrice.TabIndex = 20
        '
        'TextBoxTimeDepart
        '
        Me.TextBoxTimeDepart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxTimeDepart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_trainBindingSource, "TimeDepart", True))
        Me.TextBoxTimeDepart.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTimeDepart.Location = New System.Drawing.Point(916, 300)
        Me.TextBoxTimeDepart.Name = "TextBoxTimeDepart"
        Me.TextBoxTimeDepart.Size = New System.Drawing.Size(158, 34)
        Me.TextBoxTimeDepart.TabIndex = 22
        '
        'DateTimePickerDateDepart
        '
        Me.DateTimePickerDateDepart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerDateDepart.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDateDepart.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_trainBindingSource, "DateDepart", True))
        Me.DateTimePickerDateDepart.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDateDepart.Location = New System.Drawing.Point(1099, 300)
        Me.DateTimePickerDateDepart.Name = "DateTimePickerDateDepart"
        Me.DateTimePickerDateDepart.Size = New System.Drawing.Size(398, 34)
        Me.DateTimePickerDateDepart.TabIndex = 24
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonSearch.Location = New System.Drawing.Point(200, 389)
        Me.ButtonSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(164, 40)
        Me.ButtonSearch.TabIndex = 25
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonAdd.Location = New System.Drawing.Point(502, 389)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(164, 40)
        Me.ButtonAdd.TabIndex = 26
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonClear.Location = New System.Drawing.Point(827, 389)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(164, 40)
        Me.ButtonClear.TabIndex = 28
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonDelete.BackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonDelete.Location = New System.Drawing.Point(1123, 389)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(164, 40)
        Me.ButtonDelete.TabIndex = 29
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 462)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1464, 302)
        Me.DataGridView1.TabIndex = 30
        Me.DataGridView1.Visible = False
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
        'ButtonBack
        '
        Me.ButtonBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonBack.BackColor = System.Drawing.Color.White
        Me.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBack.Location = New System.Drawing.Point(703, 790)
        Me.ButtonBack.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(137, 39)
        Me.ButtonBack.TabIndex = 31
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'Add_Train
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1513, 831)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(LabelTrainNo)
        Me.Controls.Add(Me.TextBoxTrainNo)
        Me.Controls.Add(LabelDeparture)
        Me.Controls.Add(Me.TextBoxDeparture)
        Me.Controls.Add(LabelArrival)
        Me.Controls.Add(Me.TextBoxArrival)
        Me.Controls.Add(LabelPrice)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(LabelTimeDepart)
        Me.Controls.Add(Me.TextBoxTimeDepart)
        Me.Controls.Add(LabelDateDepart)
        Me.Controls.Add(Me.DateTimePickerDateDepart)
        Me.Controls.Add(Me.Tbl_trainBindingNavigator)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Name = "Add_Train"
        Me.Text = "Add_Train"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_trainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_trainBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_trainBindingNavigator.ResumeLayout(False)
        Me.Tbl_trainBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_adminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents SabahTrainDatabase2000DataSet As SabahTrain_1_.SabahTrainDatabase2000DataSet
    Friend WithEvents Tbl_trainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_trainTableAdapter As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_trainTableAdapter
    Friend WithEvents TableAdapterManager As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_trainBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_trainBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBoxTrainNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDeparture As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxArrival As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTimeDepart As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerDateDepart As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Tbl_adminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_adminTableAdapter As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_adminTableAdapter
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
End Class
