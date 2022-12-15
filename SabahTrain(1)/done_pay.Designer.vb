<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class done_pay
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
        Dim Transaction_DateLabel As System.Windows.Forms.Label
        Dim ParticularLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(done_pay))
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SabahTrainDatabase2000DataSet = New SabahTrain_1_.SabahTrainDatabase2000DataSet()
        Me.Tbl_transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_transactionTableAdapter = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_transactionTableAdapter()
        Me.TableAdapterManager = New SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager()
        Me.Tbl_transactionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_transactionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelDArrive = New System.Windows.Forms.Label()
        Me.LabelDDepature = New System.Windows.Forms.Label()
        Me.LabelTArrive = New System.Windows.Forms.Label()
        Me.LabelTDeparture = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelPsgPax = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelDeparture = New System.Windows.Forms.Label()
        Me.LabelArrival = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Labeltotalprice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Transaction_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ParticularTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Transaction_DateLabel = New System.Windows.Forms.Label()
        ParticularLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_transactionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_transactionBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Transaction_DateLabel
        '
        Transaction_DateLabel.AutoSize = True
        Transaction_DateLabel.Location = New System.Drawing.Point(1355, 105)
        Transaction_DateLabel.Name = "Transaction_DateLabel"
        Transaction_DateLabel.Size = New System.Drawing.Size(121, 17)
        Transaction_DateLabel.TabIndex = 23
        Transaction_DateLabel.Text = "Transaction Date:"
        Transaction_DateLabel.Visible = False
        '
        'ParticularLabel
        '
        ParticularLabel.AutoSize = True
        ParticularLabel.Location = New System.Drawing.Point(1355, 132)
        ParticularLabel.Name = "ParticularLabel"
        ParticularLabel.Size = New System.Drawing.Size(72, 17)
        ParticularLabel.TabIndex = 25
        ParticularLabel.Text = "Particular:"
        ParticularLabel.Visible = False
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(1355, 160)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(65, 17)
        QuantityLabel.TabIndex = 27
        QuantityLabel.Text = "Quantity:"
        QuantityLabel.Visible = False
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(1355, 188)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(60, 17)
        AmountLabel.TabIndex = 29
        AmountLabel.Text = "Amount:"
        AmountLabel.Visible = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(818, -6)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(179, 165)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 18
        Me.PictureBoxLogo.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'SabahTrainDatabase2000DataSet
        '
        Me.SabahTrainDatabase2000DataSet.DataSetName = "SabahTrainDatabase2000DataSet"
        Me.SabahTrainDatabase2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_transactionBindingSource
        '
        Me.Tbl_transactionBindingSource.DataMember = "tbl_transaction"
        Me.Tbl_transactionBindingSource.DataSource = Me.SabahTrainDatabase2000DataSet
        '
        'Tbl_transactionTableAdapter
        '
        Me.Tbl_transactionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_adminTableAdapter = Nothing
        Me.TableAdapterManager.tbl_customerCareTableAdapter = Nothing
        Me.TableAdapterManager.tbl_trainTableAdapter = Nothing
        Me.TableAdapterManager.tbl_transactionTableAdapter = Me.Tbl_transactionTableAdapter
        Me.TableAdapterManager.UpdateOrder = SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_transactionBindingNavigator
        '
        Me.Tbl_transactionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_transactionBindingNavigator.BindingSource = Me.Tbl_transactionBindingSource
        Me.Tbl_transactionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_transactionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_transactionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_transactionBindingNavigatorSaveItem})
        Me.Tbl_transactionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_transactionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_transactionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_transactionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_transactionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_transactionBindingNavigator.Name = "Tbl_transactionBindingNavigator"
        Me.Tbl_transactionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_transactionBindingNavigator.Size = New System.Drawing.Size(1702, 27)
        Me.Tbl_transactionBindingNavigator.TabIndex = 23
        Me.Tbl_transactionBindingNavigator.Text = "BindingNavigator1"
        Me.Tbl_transactionBindingNavigator.Visible = False
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
        'Tbl_transactionBindingNavigatorSaveItem
        '
        Me.Tbl_transactionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_transactionBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_transactionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_transactionBindingNavigatorSaveItem.Name = "Tbl_transactionBindingNavigatorSaveItem"
        Me.Tbl_transactionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Tbl_transactionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(387, 174)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment successful!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 431)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Your ticket ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(613, 436)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "00001"
        '
        'LabelDArrive
        '
        Me.LabelDArrive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelDArrive.AutoSize = True
        Me.LabelDArrive.BackColor = System.Drawing.Color.Transparent
        Me.LabelDArrive.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDArrive.Location = New System.Drawing.Point(260, 263)
        Me.LabelDArrive.Name = "LabelDArrive"
        Me.LabelDArrive.Size = New System.Drawing.Size(324, 39)
        Me.LabelDArrive.TabIndex = 9
        Me.LabelDArrive.Text = "Date of Departure:"
        Me.LabelDArrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDDepature
        '
        Me.LabelDDepature.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelDDepature.AutoSize = True
        Me.LabelDDepature.BackColor = System.Drawing.Color.Transparent
        Me.LabelDDepature.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDDepature.Location = New System.Drawing.Point(611, 273)
        Me.LabelDDepature.Name = "LabelDDepature"
        Me.LabelDDepature.Size = New System.Drawing.Size(200, 32)
        Me.LabelDDepature.TabIndex = 10
        Me.LabelDDepature.Text = "DateDepature"
        Me.LabelDDepature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTArrive
        '
        Me.LabelTArrive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTArrive.AutoSize = True
        Me.LabelTArrive.BackColor = System.Drawing.Color.Transparent
        Me.LabelTArrive.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTArrive.Location = New System.Drawing.Point(257, 303)
        Me.LabelTArrive.Name = "LabelTArrive"
        Me.LabelTArrive.Size = New System.Drawing.Size(327, 39)
        Me.LabelTArrive.TabIndex = 11
        Me.LabelTArrive.Text = "Time of Departure:"
        Me.LabelTArrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTDeparture
        '
        Me.LabelTDeparture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTDeparture.AutoSize = True
        Me.LabelTDeparture.BackColor = System.Drawing.Color.Transparent
        Me.LabelTDeparture.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTDeparture.Location = New System.Drawing.Point(607, 311)
        Me.LabelTDeparture.Name = "LabelTDeparture"
        Me.LabelTDeparture.Size = New System.Drawing.Size(202, 32)
        Me.LabelTDeparture.TabIndex = 12
        Me.LabelTDeparture.Text = "TimeDepature"
        Me.LabelTDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPrice
        '
        Me.LabelPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrice.Location = New System.Drawing.Point(367, 342)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(222, 39)
        Me.LabelPrice.TabIndex = 13
        Me.LabelPrice.Text = "Passengers:"
        Me.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPsgPax
        '
        Me.LabelPsgPax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelPsgPax.AutoSize = True
        Me.LabelPsgPax.BackColor = System.Drawing.Color.Transparent
        Me.LabelPsgPax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPsgPax.Location = New System.Drawing.Point(607, 350)
        Me.LabelPsgPax.Name = "LabelPsgPax"
        Me.LabelPsgPax.Size = New System.Drawing.Size(204, 32)
        Me.LabelPsgPax.TabIndex = 14
        Me.LabelPsgPax.Text = "PassengerPax"
        Me.LabelPsgPax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 39)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total price:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDeparture
        '
        Me.LabelDeparture.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelDeparture.AutoSize = True
        Me.LabelDeparture.BackColor = System.Drawing.Color.Transparent
        Me.LabelDeparture.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeparture.Location = New System.Drawing.Point(312, 224)
        Me.LabelDeparture.Name = "LabelDeparture"
        Me.LabelDeparture.Size = New System.Drawing.Size(186, 39)
        Me.LabelDeparture.TabIndex = 16
        Me.LabelDeparture.Text = "Departure"
        Me.LabelDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelArrival
        '
        Me.LabelArrival.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelArrival.AutoSize = True
        Me.LabelArrival.BackColor = System.Drawing.Color.Transparent
        Me.LabelArrival.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArrival.Location = New System.Drawing.Point(675, 224)
        Me.LabelArrival.Name = "LabelArrival"
        Me.LabelArrival.Size = New System.Drawing.Size(127, 39)
        Me.LabelArrival.TabIndex = 17
        Me.LabelArrival.Text = "Arrival"
        Me.LabelArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label5.Location = New System.Drawing.Point(559, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 54)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "→"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(320, 516)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(244, 37)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Return to home page"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(620, 516)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 37)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Print ticket ⎙"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Labeltotalprice
        '
        Me.Labeltotalprice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Labeltotalprice.AutoSize = True
        Me.Labeltotalprice.BackColor = System.Drawing.Color.Transparent
        Me.Labeltotalprice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltotalprice.Location = New System.Drawing.Point(669, 389)
        Me.Labeltotalprice.Name = "Labeltotalprice"
        Me.Labeltotalprice.Size = New System.Drawing.Size(142, 32)
        Me.Labeltotalprice.TabIndex = 23
        Me.Labeltotalprice.Text = "totalprice"
        Me.Labeltotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(605, 385)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 36)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "RM"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1377, 211)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Labeltotalprice)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabelArrival)
        Me.GroupBox1.Controls.Add(Me.LabelDeparture)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LabelPsgPax)
        Me.GroupBox1.Controls.Add(Me.LabelPrice)
        Me.GroupBox1.Controls.Add(Me.LabelTDeparture)
        Me.GroupBox1.Controls.Add(Me.LabelTArrive)
        Me.GroupBox1.Controls.Add(Me.LabelDDepature)
        Me.GroupBox1.Controls.Add(Me.LabelDArrive)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(257, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1060, 592)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Slip"
        '
        'Transaction_DateDateTimePicker
        '
        Me.Transaction_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_transactionBindingSource, "Transaction_Date", True))
        Me.Transaction_DateDateTimePicker.Location = New System.Drawing.Point(1482, 101)
        Me.Transaction_DateDateTimePicker.Name = "Transaction_DateDateTimePicker"
        Me.Transaction_DateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Transaction_DateDateTimePicker.TabIndex = 24
        Me.Transaction_DateDateTimePicker.Visible = False
        '
        'ParticularTextBox
        '
        Me.ParticularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_transactionBindingSource, "Particular", True))
        Me.ParticularTextBox.Location = New System.Drawing.Point(1482, 129)
        Me.ParticularTextBox.Name = "ParticularTextBox"
        Me.ParticularTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ParticularTextBox.TabIndex = 26
        Me.ParticularTextBox.Visible = False
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_transactionBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(1482, 157)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(200, 22)
        Me.QuantityTextBox.TabIndex = 28
        Me.QuantityTextBox.Visible = False
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_transactionBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(1482, 185)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AmountTextBox.TabIndex = 30
        Me.AmountTextBox.Visible = False
        '
        'done_pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImage = Global.SabahTrain_1_.My.Resources.Resources.Untitled_design__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1702, 626)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Transaction_DateLabel)
        Me.Controls.Add(Me.Transaction_DateDateTimePicker)
        Me.Controls.Add(ParticularLabel)
        Me.Controls.Add(Me.ParticularTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.Tbl_transactionBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "done_pay"
        Me.Text = "done_pay"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SabahTrainDatabase2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_transactionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_transactionBindingNavigator.ResumeLayout(False)
        Me.Tbl_transactionBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Tbl_transactionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_transactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SabahTrainDatabase2000DataSet As SabahTrain_1_.SabahTrainDatabase2000DataSet
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
    Friend WithEvents Tbl_transactionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_transactionTableAdapter As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.tbl_transactionTableAdapter
    Friend WithEvents TableAdapterManager As SabahTrain_1_.SabahTrainDatabase2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Labeltotalprice As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelArrival As System.Windows.Forms.Label
    Friend WithEvents LabelDeparture As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelPsgPax As System.Windows.Forms.Label
    Friend WithEvents LabelPrice As System.Windows.Forms.Label
    Friend WithEvents LabelTDeparture As System.Windows.Forms.Label
    Friend WithEvents LabelTArrive As System.Windows.Forms.Label
    Friend WithEvents LabelDDepature As System.Windows.Forms.Label
    Friend WithEvents LabelDArrive As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Transaction_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ParticularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
End Class
