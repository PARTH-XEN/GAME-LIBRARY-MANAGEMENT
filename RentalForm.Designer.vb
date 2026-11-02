<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalForm
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlAccentBar = New System.Windows.Forms.Panel()
        Me.pnlHeaderArea = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbRentalDetails = New System.Windows.Forms.GroupBox()
        Me.lblFilterView = New System.Windows.Forms.Label()
        Me.cmbFilterView = New System.Windows.Forms.ComboBox()
        Me.lblTransType = New System.Windows.Forms.Label()
        Me.cmbTransType = New System.Windows.Forms.ComboBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.lblCustomerPhone = New System.Windows.Forms.Label()
        Me.txtRentalPrice = New System.Windows.Forms.TextBox()
        Me.lblRentalPrice = New System.Windows.Forms.Label()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.lblReturnDate = New System.Windows.Forms.Label()
        Me.dtpRentalDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRentalDate = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.cmbGames = New System.Windows.Forms.ComboBox()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.txtRentalID = New System.Windows.Forms.TextBox()
        Me.lblRentalID = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReturnRental = New System.Windows.Forms.Button()
        Me.btnSellGame = New System.Windows.Forms.Button()
        Me.btnRentGame = New System.Windows.Forms.Button()
        Me.dgvRentals = New System.Windows.Forms.DataGridView()
        Me.pnlHeaderArea.SuspendLayout()
        Me.gbRentalDetails.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.dgvRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAccentBar
        '
        Me.pnlAccentBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.pnlAccentBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAccentBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlAccentBar.Name = "pnlAccentBar"
        Me.pnlAccentBar.Size = New System.Drawing.Size(1008, 4)
        Me.pnlAccentBar.TabIndex = 0
        '
        'pnlHeaderArea
        '
        Me.pnlHeaderArea.Controls.Add(Me.btnBack)
        Me.pnlHeaderArea.Controls.Add(Me.lblSubtitle)
        Me.pnlHeaderArea.Controls.Add(Me.lblTitle)
        Me.pnlHeaderArea.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderArea.Location = New System.Drawing.Point(0, 4)
        Me.pnlHeaderArea.Name = "pnlHeaderArea"
        Me.pnlHeaderArea.Size = New System.Drawing.Size(1008, 70)
        Me.pnlHeaderArea.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(820, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(170, 40)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "<- Dashboard"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(20, 42)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(375, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Manage commercial game rentals, customer sales && returns"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(18, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(252, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Rent && Sell Games"
        '
        'gbRentalDetails
        '
        Me.gbRentalDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRentalDetails.BackColor = System.Drawing.Color.White
        Me.gbRentalDetails.Controls.Add(Me.lblFilterView)
        Me.gbRentalDetails.Controls.Add(Me.cmbFilterView)
        Me.gbRentalDetails.Controls.Add(Me.lblTransType)
        Me.gbRentalDetails.Controls.Add(Me.cmbTransType)
        Me.gbRentalDetails.Controls.Add(Me.txtCustomerAddress)
        Me.gbRentalDetails.Controls.Add(Me.lblCustomerAddress)
        Me.gbRentalDetails.Controls.Add(Me.txtCustomerPhone)
        Me.gbRentalDetails.Controls.Add(Me.lblCustomerPhone)
        Me.gbRentalDetails.Controls.Add(Me.txtRentalPrice)
        Me.gbRentalDetails.Controls.Add(Me.lblRentalPrice)
        Me.gbRentalDetails.Controls.Add(Me.dtpReturnDate)
        Me.gbRentalDetails.Controls.Add(Me.lblReturnDate)
        Me.gbRentalDetails.Controls.Add(Me.dtpRentalDate)
        Me.gbRentalDetails.Controls.Add(Me.lblRentalDate)
        Me.gbRentalDetails.Controls.Add(Me.txtCustomerName)
        Me.gbRentalDetails.Controls.Add(Me.lblCustomerName)
        Me.gbRentalDetails.Controls.Add(Me.cmbGames)
        Me.gbRentalDetails.Controls.Add(Me.lblGame)
        Me.gbRentalDetails.Controls.Add(Me.txtRentalID)
        Me.gbRentalDetails.Controls.Add(Me.lblRentalID)
        Me.gbRentalDetails.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRentalDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.gbRentalDetails.Location = New System.Drawing.Point(15, 80)
        Me.gbRentalDetails.Name = "gbRentalDetails"
        Me.gbRentalDetails.Size = New System.Drawing.Size(978, 195)
        Me.gbRentalDetails.TabIndex = 2
        Me.gbRentalDetails.TabStop = False
        Me.gbRentalDetails.Text = "Rental && Sale Transaction Details"
        '
        'lblFilterView
        '
        Me.lblFilterView.AutoSize = True
        Me.lblFilterView.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblFilterView.Location = New System.Drawing.Point(695, 153)
        Me.lblFilterView.Name = "lblFilterView"
        Me.lblFilterView.Size = New System.Drawing.Size(80, 19)
        Me.lblFilterView.TabIndex = 19
        Me.lblFilterView.Text = "Filter Grid:"
        '
        'cmbFilterView
        '
        Me.cmbFilterView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterView.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilterView.FormattingEnabled = True
        Me.cmbFilterView.Items.AddRange(New Object() {"All Records", "Rentals Only", "Sales Only"})
        Me.cmbFilterView.Location = New System.Drawing.Point(785, 149)
        Me.cmbFilterView.Name = "cmbFilterView"
        Me.cmbFilterView.Size = New System.Drawing.Size(175, 28)
        Me.cmbFilterView.TabIndex = 18
        '
        'lblTransType
        '
        Me.lblTransType.AutoSize = True
        Me.lblTransType.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblTransType.Location = New System.Drawing.Point(15, 73)
        Me.lblTransType.Name = "lblTransType"
        Me.lblTransType.Size = New System.Drawing.Size(84, 19)
        Me.lblTransType.TabIndex = 17
        Me.lblTransType.Text = "Trans Type:"
        '
        'cmbTransType
        '
        Me.cmbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransType.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTransType.FormattingEnabled = True
        Me.cmbTransType.Items.AddRange(New Object() {"Rent", "Sell"})
        Me.cmbTransType.Location = New System.Drawing.Point(125, 69)
        Me.cmbTransType.Name = "cmbTransType"
        Me.cmbTransType.Size = New System.Drawing.Size(185, 28)
        Me.cmbTransType.TabIndex = 16
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress.Location = New System.Drawing.Point(450, 110)
        Me.txtCustomerAddress.Multiline = True
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(220, 62)
        Me.txtCustomerAddress.TabIndex = 15
        '
        'lblCustomerAddress
        '
        Me.lblCustomerAddress.AutoSize = True
        Me.lblCustomerAddress.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblCustomerAddress.Location = New System.Drawing.Point(330, 113)
        Me.lblCustomerAddress.Name = "lblCustomerAddress"
        Me.lblCustomerAddress.Size = New System.Drawing.Size(99, 19)
        Me.lblCustomerAddress.TabIndex = 14
        Me.lblCustomerAddress.Text = "Cust Address:"
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerPhone.Location = New System.Drawing.Point(450, 70)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(220, 27)
        Me.txtCustomerPhone.TabIndex = 13
        '
        'lblCustomerPhone
        '
        Me.lblCustomerPhone.AutoSize = True
        Me.lblCustomerPhone.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblCustomerPhone.Location = New System.Drawing.Point(330, 73)
        Me.lblCustomerPhone.Name = "lblCustomerPhone"
        Me.lblCustomerPhone.Size = New System.Drawing.Size(98, 19)
        Me.lblCustomerPhone.TabIndex = 12
        Me.lblCustomerPhone.Text = "Customer Ph:"
        '
        'txtRentalPrice
        '
        Me.txtRentalPrice.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentalPrice.Location = New System.Drawing.Point(125, 150)
        Me.txtRentalPrice.Name = "txtRentalPrice"
        Me.txtRentalPrice.Size = New System.Drawing.Size(185, 27)
        Me.txtRentalPrice.TabIndex = 11
        '
        'lblRentalPrice
        '
        Me.lblRentalPrice.AutoSize = True
        Me.lblRentalPrice.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblRentalPrice.Location = New System.Drawing.Point(15, 153)
        Me.lblRentalPrice.Name = "lblRentalPrice"
        Me.lblRentalPrice.Size = New System.Drawing.Size(69, 19)
        Me.lblRentalPrice.TabIndex = 10
        Me.lblRentalPrice.Text = "Price ($):"
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReturnDate.Location = New System.Drawing.Point(785, 70)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(175, 27)
        Me.dtpReturnDate.TabIndex = 9
        '
        'lblReturnDate
        '
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblReturnDate.Location = New System.Drawing.Point(695, 73)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.Size = New System.Drawing.Size(87, 19)
        Me.lblReturnDate.TabIndex = 8
        Me.lblReturnDate.Text = "Return Due:"
        '
        'dtpRentalDate
        '
        Me.dtpRentalDate.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRentalDate.Location = New System.Drawing.Point(785, 30)
        Me.dtpRentalDate.Name = "dtpRentalDate"
        Me.dtpRentalDate.Size = New System.Drawing.Size(175, 27)
        Me.dtpRentalDate.TabIndex = 7
        '
        'lblRentalDate
        '
        Me.lblRentalDate.AutoSize = True
        Me.lblRentalDate.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblRentalDate.Location = New System.Drawing.Point(695, 33)
        Me.lblRentalDate.Name = "lblRentalDate"
        Me.lblRentalDate.Size = New System.Drawing.Size(44, 19)
        Me.lblRentalDate.TabIndex = 6
        Me.lblRentalDate.Text = "Date:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(450, 30)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(220, 27)
        Me.txtCustomerName.TabIndex = 5
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(330, 33)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(121, 19)
        Me.lblCustomerName.TabIndex = 4
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'cmbGames
        '
        Me.cmbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGames.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGames.FormattingEnabled = True
        Me.cmbGames.Location = New System.Drawing.Point(125, 110)
        Me.cmbGames.Name = "cmbGames"
        Me.cmbGames.Size = New System.Drawing.Size(185, 25)
        Me.cmbGames.TabIndex = 3
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblGame.Location = New System.Drawing.Point(15, 113)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(96, 19)
        Me.lblGame.TabIndex = 2
        Me.lblGame.Text = "Select Game:"
        '
        'txtRentalID
        '
        Me.txtRentalID.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentalID.Location = New System.Drawing.Point(125, 30)
        Me.txtRentalID.Name = "txtRentalID"
        Me.txtRentalID.ReadOnly = True
        Me.txtRentalID.Size = New System.Drawing.Size(185, 27)
        Me.txtRentalID.TabIndex = 1
        '
        'lblRentalID
        '
        Me.lblRentalID.AutoSize = True
        Me.lblRentalID.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblRentalID.Location = New System.Drawing.Point(15, 33)
        Me.lblRentalID.Name = "lblRentalID"
        Me.lblRentalID.Size = New System.Drawing.Size(66, 19)
        Me.lblRentalID.TabIndex = 0
        Me.lblRentalID.Text = "Trans ID:"
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.Controls.Add(Me.btnRefresh)
        Me.pnlButtons.Controls.Add(Me.btnClear)
        Me.pnlButtons.Controls.Add(Me.btnReturnRental)
        Me.pnlButtons.Controls.Add(Me.btnSellGame)
        Me.pnlButtons.Controls.Add(Me.btnRentGame)
        Me.pnlButtons.Location = New System.Drawing.Point(15, 285)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(978, 50)
        Me.pnlButtons.TabIndex = 3
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(785, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(180, 40)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(590, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(180, 40)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnReturnRental
        '
        Me.btnReturnRental.BackColor = System.Drawing.Color.White
        Me.btnReturnRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnRental.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnRental.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnReturnRental.Location = New System.Drawing.Point(395, 5)
        Me.btnReturnRental.Name = "btnReturnRental"
        Me.btnReturnRental.Size = New System.Drawing.Size(180, 40)
        Me.btnReturnRental.TabIndex = 2
        Me.btnReturnRental.Text = "Return Rental"
        Me.btnReturnRental.UseVisualStyleBackColor = False
        '
        'btnSellGame
        '
        Me.btnSellGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnSellGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSellGame.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellGame.ForeColor = System.Drawing.Color.White
        Me.btnSellGame.Location = New System.Drawing.Point(200, 5)
        Me.btnSellGame.Name = "btnSellGame"
        Me.btnSellGame.Size = New System.Drawing.Size(180, 40)
        Me.btnSellGame.TabIndex = 1
        Me.btnSellGame.Text = "Sell Game"
        Me.btnSellGame.UseVisualStyleBackColor = False
        '
        'btnRentGame
        '
        Me.btnRentGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnRentGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRentGame.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRentGame.ForeColor = System.Drawing.Color.White
        Me.btnRentGame.Location = New System.Drawing.Point(10, 5)
        Me.btnRentGame.Name = "btnRentGame"
        Me.btnRentGame.Size = New System.Drawing.Size(175, 40)
        Me.btnRentGame.TabIndex = 0
        Me.btnRentGame.Text = "Rent Game"
        Me.btnRentGame.UseVisualStyleBackColor = False
        '
        'dgvRentals
        '
        Me.dgvRentals.AllowUserToAddRows = False
        Me.dgvRentals.AllowUserToDeleteRows = False
        Me.dgvRentals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRentals.Location = New System.Drawing.Point(15, 345)
        Me.dgvRentals.MultiSelect = False
        Me.dgvRentals.Name = "dgvRentals"
        Me.dgvRentals.ReadOnly = True
        Me.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRentals.Size = New System.Drawing.Size(978, 360)
        Me.dgvRentals.TabIndex = 4
        '
        'RentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 720)
        Me.Controls.Add(Me.dgvRentals)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.gbRentalDetails)
        Me.Controls.Add(Me.pnlHeaderArea)
        Me.Controls.Add(Me.pnlAccentBar)
        Me.Name = "RentalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Rentals & Sales - Game Library System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeaderArea.ResumeLayout(False)
        Me.pnlHeaderArea.PerformLayout()
        Me.gbRentalDetails.ResumeLayout(False)
        Me.gbRentalDetails.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.dgvRentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAccentBar As System.Windows.Forms.Panel
    Friend WithEvents pnlHeaderArea As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents gbRentalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtRentalID As System.Windows.Forms.TextBox
    Friend WithEvents lblRentalID As System.Windows.Forms.Label
    Friend WithEvents cmbGames As System.Windows.Forms.ComboBox
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerPhone As System.Windows.Forms.Label
    Friend WithEvents txtCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerAddress As System.Windows.Forms.Label
    Friend WithEvents cmbTransType As System.Windows.Forms.ComboBox
    Friend WithEvents lblTransType As System.Windows.Forms.Label
    Friend WithEvents dtpRentalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRentalDate As System.Windows.Forms.Label
    Friend WithEvents dtpReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblReturnDate As System.Windows.Forms.Label
    Friend WithEvents txtRentalPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblRentalPrice As System.Windows.Forms.Label
    Friend WithEvents lblFilterView As System.Windows.Forms.Label
    Friend WithEvents cmbFilterView As System.Windows.Forms.ComboBox
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnReturnRental As System.Windows.Forms.Button
    Friend WithEvents btnSellGame As System.Windows.Forms.Button
    Friend WithEvents btnRentGame As System.Windows.Forms.Button
    Friend WithEvents dgvRentals As System.Windows.Forms.DataGridView
End Class
