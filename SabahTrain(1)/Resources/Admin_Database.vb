Imports System.Data.OleDb
Imports System.Data

Public Class Admin_Database
    Dim conn As New OleDbConnection(My.Settings.SabahTrainDatabase2000ConnectionString)

    Private Sub bind_data()
        Dim cmd1 As New OleDbCommand("SELECT * FROM tbl_admin", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim tblAdmin As New DataTable
        tblAdmin.Clear()
        da.Fill(tblAdmin)
        DataGridView1.DataSource = tblAdmin
    End Sub

    Private Sub Admin_Database_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TODO: This line of code loads data into the 'SabahTrainDatabase2000DataSet1.tbl_admin' table. You can move, or remove it, as needed.
        'Me.Tbl_adminTableAdapter1.Fill(Me.SabahTrainDatabase2000DataSet1.tbl_admin)

        bind_data()
    End Sub

    Private Sub Tbl_adminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_adminBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_adminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SabahTrainDatabase2000DataSet)

    End Sub

    Private Sub Admin_Database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SabahTrainDatabase2000DataSet.tbl_admin' table. You can move, or remove it, as needed.
        Me.Tbl_adminTableAdapter.Fill(Me.SabahTrainDatabase2000DataSet.tbl_admin)

        bind_data()
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Dim strsql As String
        strsql = "INSERT INTO tbl_admin([AdminID],[AdminName],[Username],[Password],[AccessLevel]) VALUES (@AdminID,@AdminName,@Username,@Password,@AccessLevel)"
        Dim cmd2 As New OleDbCommand(strsql, conn)
        cmd2.Parameters.AddWithValue("@AdminID", TextBoxAdminID.Text)
        cmd2.Parameters.AddWithValue("@AdminName", TextBoxAdminName.Text)
        cmd2.Parameters.AddWithValue("@Username", TextBoxUsername.Text)
        cmd2.Parameters.AddWithValue("@Password", TextBoxPassword.Text)
        cmd2.Parameters.AddWithValue("@AccessLevel", TextBoxAccessLevel.Text)
        MessageBox.Show("Admin Successfully Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Open()
        cmd2.ExecuteNonQuery()
        conn.Close()
        bind_data()
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        TextBoxAdminID.Text = ""
        TextBoxAdminName.Text = ""
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
        TextBoxAccessLevel.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)
        TextBoxAdminID.Text = selectedRow.Cells(0).Value.ToString
        TextBoxAdminName.Text = selectedRow.Cells(1).Value.ToString
        TextBoxUsername.Text = selectedRow.Cells(2).Value.ToString
        TextBoxPassword.Text = selectedRow.Cells(3).Value.ToString
        TextBoxAccessLevel.Text = selectedRow.Cells(4).Value.ToString
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim cmd4 As New OleDbCommand("UPDATE tbl_admin SET AdminName=@TextBoxAdminName.Text, Username=@TextBoxUsername.Text, Password=@TextBoxPassword.Text , AccessLevel = @TextBoxAccessLevel.Text WHERE AdminID = @TextBoxAdminID.Text", conn)
        'conn.Open()
        ''cmd4.Parameters.AddWithValue("@AdminID", TextBoxAdminID.Text)
        'cmd4.Parameters.AddWithValue("@AdminName", TextBoxAdminName.Text)
        'cmd4.Parameters.AddWithValue("@Username", TextBoxUsername.Text)
        'cmd4.Parameters.AddWithValue("@Password", TextBoxPassword.Text)
        'cmd4.Parameters.AddWithValue("@AccessLevel", TextBoxAccessLevel.Text)
        'cmd4.ExecuteNonQuery()
        'conn.Close()
        'bind_data()

        'Dim cmd4 As New OleDbCommand("Update tbl_admin set AdminName= '" & TextBoxAdminName.Text & "', Username= '" & TextBoxUsername.Text & "', Password= '" & TextBoxPassword.Text & "',AccessLevel= '" & TextBoxAccessLevel.Text & "' where AdminID= " & TextBoxAdminID & "", conn)
        'conn.Open()
        'cmd4.ExecuteNonQuery()
        'conn.Close()
        'MessageBox.Show("Data update successful")
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim cmd5 As New OleDbCommand("DELETE FROM tbl_admin WHERE AdminID=@AdminID", conn)
        cmd5.Parameters.AddWithValue("@AdminID", TextBoxAdminID.Text)
        MessageBox.Show("Admin Successfully Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Open()
        cmd5.ExecuteNonQuery()
        conn.Close()
        bind_data()
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        conn.Open()
        Dim cmd6 As New OleDbCommand("SELECT * FROM tbl_admin WHERE AdminID=@AdminID OR AdminName=@AdminName OR Username=@Username OR Password=@Password OR AccessLevel=@AccessLevel", conn)
        cmd6.Parameters.AddWithValue("@AdminID", TextBoxAdminID.Text.Trim)
        cmd6.Parameters.AddWithValue("@AdminName", TextBoxAdminName.Text)
        cmd6.Parameters.AddWithValue("@Username", TextBoxUsername.Text)
        cmd6.Parameters.AddWithValue("@Password", TextBoxPassword.Text)
        cmd6.Parameters.AddWithValue("@AccessLevel", TextBoxAccessLevel.Text)
        Dim reader1 As OleDbDataReader
        reader1 = cmd6.ExecuteReader
        If reader1.Read() Then
            TextBoxAdminID.Text = reader1("AdminID").ToString
            TextBoxAdminName.Text = reader1("AdminName").ToString
            TextBoxUsername.Text = reader1("Username").ToString
            TextBoxPassword.Text = reader1("Password").ToString
            TextBoxAccessLevel.Text = reader1("AccessLevel").ToString
            bind_data()
        Else
            TextBoxAdminID.Text = ""
            TextBoxAdminName.Text = ""
            TextBoxUsername.Text = ""
            TextBoxPassword.Text = ""
            TextBoxAccessLevel.Text = ""
            MessageBox.Show("Data no found")
        End If
        conn.Close()
    End Sub

    'Private Sub TextBoxAdminID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAdminID.TextChanged
    '    Try
    '        Me.Tbl_adminTableAdapter.AdminID(Me.SabahTrainDatabase2000DataSet, TextBoxAdminID.Text & "%")
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LabelAdminID As System.Windows.Forms.Label
        Dim LabelAdminName As System.Windows.Forms.Label
        Dim LabelUsername As System.Windows.Forms.Label
        Dim LabelPassword As System.Windows.Forms.Label
        Dim LabelAccessLevel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Database))
        Me.SabahTrainDatabase2000DataSet = New SabahTrain_1_.SabahTrainDatabase2000DataSet()
        Me.Tbl_adminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_adminTableAdapter = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_adminTableAdapter()
        Me.TableAdapterManager = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager()
        Me.Tbl_adminBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_adminBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TextBoxAdminName = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxAccessLevel = New System.Windows.Forms.TextBox()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TextBoxAdminID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.AdminIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        LabelAdminID = New System.Windows.Forms.Label()
        LabelAdminName = New System.Windows.Forms.Label()
        LabelUsername = New System.Windows.Forms.Label()
        LabelPassword = New System.Windows.Forms.Label()
        LabelAccessLevel = New System.Windows.Forms.Label()
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_adminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_adminBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_adminBindingNavigator.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAdminID
        '
        LabelAdminID.AutoSize = True
        LabelAdminID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelAdminID.Location = New System.Drawing.Point(53, 251)
        LabelAdminID.Name = "LabelAdminID"
        LabelAdminID.Size = New System.Drawing.Size(126, 28)
        LabelAdminID.TabIndex = 1
        LabelAdminID.Text = "Admin ID:"
        '
        'LabelAdminName
        '
        LabelAdminName.AutoSize = True
        LabelAdminName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelAdminName.Location = New System.Drawing.Point(309, 251)
        LabelAdminName.Name = "LabelAdminName"
        LabelAdminName.Size = New System.Drawing.Size(167, 28)
        LabelAdminName.TabIndex = 3
        LabelAdminName.Text = "Admin Name:"
        '
        'LabelUsername
        '
        LabelUsername.AutoSize = True
        LabelUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelUsername.Location = New System.Drawing.Point(598, 251)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New System.Drawing.Size(139, 28)
        LabelUsername.TabIndex = 5
        LabelUsername.Text = "Username:"
        '
        'LabelPassword
        '
        LabelPassword.AutoSize = True
        LabelPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelPassword.Location = New System.Drawing.Point(895, 251)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New System.Drawing.Size(136, 28)
        LabelPassword.TabIndex = 7
        LabelPassword.Text = "Password:"
        '
        'LabelAccessLevel
        '
        LabelAccessLevel.AutoSize = True
        LabelAccessLevel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelAccessLevel.Location = New System.Drawing.Point(1184, 251)
        LabelAccessLevel.Name = "LabelAccessLevel"
        LabelAccessLevel.Size = New System.Drawing.Size(173, 28)
        LabelAccessLevel.TabIndex = 9
        LabelAccessLevel.Text = "Access Level:"
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
        Me.Tbl_adminBindingNavigator.Size = New System.Drawing.Size(1370, 27)
        Me.Tbl_adminBindingNavigator.TabIndex = 0
        Me.Tbl_adminBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_adminBindingNavigatorSaveItem
        '
        Me.Tbl_adminBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_adminBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_adminBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_adminBindingNavigatorSaveItem.Name = "Tbl_adminBindingNavigatorSaveItem"
        Me.Tbl_adminBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Tbl_adminBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TextBoxAdminName
        '
        Me.TextBoxAdminName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "AdminName", True))
        Me.TextBoxAdminName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdminName.Location = New System.Drawing.Point(314, 298)
        Me.TextBoxAdminName.Name = "TextBoxAdminName"
        Me.TextBoxAdminName.Size = New System.Drawing.Size(223, 34)
        Me.TextBoxAdminName.TabIndex = 4
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "Username", True))
        Me.TextBoxUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(603, 298)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(223, 34)
        Me.TextBoxUsername.TabIndex = 6
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "Password", True))
        Me.TextBoxPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(900, 298)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(223, 34)
        Me.TextBoxPassword.TabIndex = 8
        '
        'TextBoxAccessLevel
        '
        Me.TextBoxAccessLevel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "AccessLevel", True))
        Me.TextBoxAccessLevel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAccessLevel.Location = New System.Drawing.Point(1189, 298)
        Me.TextBoxAccessLevel.Name = "TextBoxAccessLevel"
        Me.TextBoxAccessLevel.Size = New System.Drawing.Size(176, 34)
        Me.TextBoxAccessLevel.TabIndex = 10
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(601, 70)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(179, 165)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 11
        Me.PictureBoxLogo.TabStop = False
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonSearch.Location = New System.Drawing.Point(195, 375)
        Me.ButtonSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(164, 40)
        Me.ButtonSearch.TabIndex = 12
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonAdd.Location = New System.Drawing.Point(495, 375)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(164, 40)
        Me.ButtonAdd.TabIndex = 13
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonClear.Location = New System.Drawing.Point(795, 375)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(164, 40)
        Me.ButtonClear.TabIndex = 15
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonDelete.Location = New System.Drawing.Point(1068, 375)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(164, 40)
        Me.ButtonDelete.TabIndex = 16
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'TextBoxAdminID
        '
        Me.TextBoxAdminID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_adminBindingSource, "AdminID", True))
        Me.TextBoxAdminID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdminID.Location = New System.Drawing.Point(58, 298)
        Me.TextBoxAdminID.Name = "TextBoxAdminID"
        Me.TextBoxAdminID.Size = New System.Drawing.Size(176, 34)
        Me.TextBoxAdminID.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdminIDDataGridViewTextBoxColumn, Me.AdminNameDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.AccessLevelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Tbl_adminBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(28, 443)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1307, 283)
        Me.DataGridView1.TabIndex = 17
        Me.DataGridView1.Visible = False
        '
        'ButtonBack
        '
        Me.ButtonBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonBack.BackColor = System.Drawing.Color.White
        Me.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBack.Location = New System.Drawing.Point(627, 720)
        Me.ButtonBack.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(137, 39)
        Me.ButtonBack.TabIndex = 32
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'AdminIDDataGridViewTextBoxColumn
        '
        Me.AdminIDDataGridViewTextBoxColumn.DataPropertyName = "AdminID"
        Me.AdminIDDataGridViewTextBoxColumn.HeaderText = "AdminID"
        Me.AdminIDDataGridViewTextBoxColumn.Name = "AdminIDDataGridViewTextBoxColumn"
        '
        'AdminNameDataGridViewTextBoxColumn
        '
        Me.AdminNameDataGridViewTextBoxColumn.DataPropertyName = "AdminName"
        Me.AdminNameDataGridViewTextBoxColumn.HeaderText = "AdminName"
        Me.AdminNameDataGridViewTextBoxColumn.Name = "AdminNameDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'AccessLevelDataGridViewTextBoxColumn
        '
        Me.AccessLevelDataGridViewTextBoxColumn.DataPropertyName = "AccessLevel"
        Me.AccessLevelDataGridViewTextBoxColumn.HeaderText = "AccessLevel"
        Me.AccessLevelDataGridViewTextBoxColumn.Name = "AccessLevelDataGridViewTextBoxColumn"
        '
        'Admin_Database
        '
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(LabelAdminID)
        Me.Controls.Add(Me.TextBoxAdminID)
        Me.Controls.Add(LabelAdminName)
        Me.Controls.Add(Me.TextBoxAdminName)
        Me.Controls.Add(LabelUsername)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(LabelPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(LabelAccessLevel)
        Me.Controls.Add(Me.TextBoxAccessLevel)
        Me.Controls.Add(Me.Tbl_adminBindingNavigator)
        Me.Name = "Admin_Database"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_adminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_adminBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_adminBindingNavigator.ResumeLayout(False)
        Me.Tbl_adminBindingNavigator.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        Admin_Welcome.Show()
        Me.Close()
    End Sub

    Private Sub TextBoxAccessLevel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAccessLevel.TextChanged

    End Sub
End Class
