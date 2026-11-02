<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameManagementForm
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
        Me.gbGameDetails = New System.Windows.Forms.GroupBox()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.lblSellingPrice = New System.Windows.Forms.Label()
        Me.txtRentalPrice = New System.Windows.Forms.TextBox()
        Me.lblRentalPrice = New System.Windows.Forms.Label()
        Me.txtAvailableQty = New System.Windows.Forms.TextBox()
        Me.lblAvailableQty = New System.Windows.Forms.Label()
        Me.txtTotalQty = New System.Windows.Forms.TextBox()
        Me.lblTotalQty = New System.Windows.Forms.Label()
        Me.txtReleaseYear = New System.Windows.Forms.TextBox()
        Me.lblReleaseYear = New System.Windows.Forms.Label()
        Me.txtDeveloper = New System.Windows.Forms.TextBox()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.txtPlatform = New System.Windows.Forms.TextBox()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.txtGameName = New System.Windows.Forms.TextBox()
        Me.lblGameName = New System.Windows.Forms.Label()
        Me.txtGameID = New System.Windows.Forms.TextBox()
        Me.lblGameID = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDeleteGame = New System.Windows.Forms.Button()
        Me.btnUpdateGame = New System.Windows.Forms.Button()
        Me.btnAddGame = New System.Windows.Forms.Button()
        Me.dgvGames = New System.Windows.Forms.DataGridView()
        Me.pnlHeaderArea.SuspendLayout()
        Me.gbGameDetails.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.dgvGames, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblSubtitle.Size = New System.Drawing.Size(270, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Manage titles, stock quantities && rental pricing"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(18, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(267, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Game Management"
        '
        'gbGameDetails
        '
        Me.gbGameDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGameDetails.BackColor = System.Drawing.Color.White
        Me.gbGameDetails.Controls.Add(Me.txtSellingPrice)
        Me.gbGameDetails.Controls.Add(Me.lblSellingPrice)
        Me.gbGameDetails.Controls.Add(Me.txtRentalPrice)
        Me.gbGameDetails.Controls.Add(Me.lblRentalPrice)
        Me.gbGameDetails.Controls.Add(Me.txtAvailableQty)
        Me.gbGameDetails.Controls.Add(Me.lblAvailableQty)
        Me.gbGameDetails.Controls.Add(Me.txtTotalQty)
        Me.gbGameDetails.Controls.Add(Me.lblTotalQty)
        Me.gbGameDetails.Controls.Add(Me.txtReleaseYear)
        Me.gbGameDetails.Controls.Add(Me.lblReleaseYear)
        Me.gbGameDetails.Controls.Add(Me.txtDeveloper)
        Me.gbGameDetails.Controls.Add(Me.lblDeveloper)
        Me.gbGameDetails.Controls.Add(Me.txtPlatform)
        Me.gbGameDetails.Controls.Add(Me.lblPlatform)
        Me.gbGameDetails.Controls.Add(Me.txtGenre)
        Me.gbGameDetails.Controls.Add(Me.lblGenre)
        Me.gbGameDetails.Controls.Add(Me.txtGameName)
        Me.gbGameDetails.Controls.Add(Me.lblGameName)
        Me.gbGameDetails.Controls.Add(Me.txtGameID)
        Me.gbGameDetails.Controls.Add(Me.lblGameID)
        Me.gbGameDetails.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGameDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.gbGameDetails.Location = New System.Drawing.Point(15, 80)
        Me.gbGameDetails.Name = "gbGameDetails"
        Me.gbGameDetails.Size = New System.Drawing.Size(978, 160)
        Me.gbGameDetails.TabIndex = 2
        Me.gbGameDetails.TabStop = False
        Me.gbGameDetails.Text = "Game Inventory Details"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingPrice.Location = New System.Drawing.Point(890, 110)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(60, 27)
        Me.txtSellingPrice.TabIndex = 19
        '
        'lblSellingPrice
        '
        Me.lblSellingPrice.AutoSize = True
        Me.lblSellingPrice.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellingPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblSellingPrice.Location = New System.Drawing.Point(825, 113)
        Me.lblSellingPrice.Name = "lblSellingPrice"
        Me.lblSellingPrice.Size = New System.Drawing.Size(63, 19)
        Me.lblSellingPrice.TabIndex = 18
        Me.lblSellingPrice.Text = "Sell ($):"
        '
        'txtRentalPrice
        '
        Me.txtRentalPrice.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentalPrice.Location = New System.Drawing.Point(750, 110)
        Me.txtRentalPrice.Name = "txtRentalPrice"
        Me.txtRentalPrice.Size = New System.Drawing.Size(65, 27)
        Me.txtRentalPrice.TabIndex = 17
        '
        'lblRentalPrice
        '
        Me.lblRentalPrice.AutoSize = True
        Me.lblRentalPrice.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblRentalPrice.Location = New System.Drawing.Point(675, 113)
        Me.lblRentalPrice.Name = "lblRentalPrice"
        Me.lblRentalPrice.Size = New System.Drawing.Size(73, 19)
        Me.lblRentalPrice.TabIndex = 16
        Me.lblRentalPrice.Text = "Rent ($):"
        '
        'txtAvailableQty
        '
        Me.txtAvailableQty.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQty.Location = New System.Drawing.Point(800, 70)
        Me.txtAvailableQty.Name = "txtAvailableQty"
        Me.txtAvailableQty.Size = New System.Drawing.Size(150, 27)
        Me.txtAvailableQty.TabIndex = 15
        '
        'lblAvailableQty
        '
        Me.lblAvailableQty.AutoSize = True
        Me.lblAvailableQty.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblAvailableQty.Location = New System.Drawing.Point(675, 73)
        Me.lblAvailableQty.Name = "lblAvailableQty"
        Me.lblAvailableQty.Size = New System.Drawing.Size(102, 19)
        Me.lblAvailableQty.TabIndex = 14
        Me.lblAvailableQty.Text = "Available Qty:"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQty.Location = New System.Drawing.Point(800, 30)
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.Size = New System.Drawing.Size(150, 27)
        Me.txtTotalQty.TabIndex = 13
        '
        'lblTotalQty
        '
        Me.lblTotalQty.AutoSize = True
        Me.lblTotalQty.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblTotalQty.Location = New System.Drawing.Point(675, 33)
        Me.lblTotalQty.Name = "lblTotalQty"
        Me.lblTotalQty.Size = New System.Drawing.Size(74, 19)
        Me.lblTotalQty.TabIndex = 12
        Me.lblTotalQty.Text = "Total Qty:"
        '
        'txtReleaseYear
        '
        Me.txtReleaseYear.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReleaseYear.Location = New System.Drawing.Point(450, 110)
        Me.txtReleaseYear.Name = "txtReleaseYear"
        Me.txtReleaseYear.Size = New System.Drawing.Size(200, 27)
        Me.txtReleaseYear.TabIndex = 11
        '
        'lblReleaseYear
        '
        Me.lblReleaseYear.AutoSize = True
        Me.lblReleaseYear.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReleaseYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblReleaseYear.Location = New System.Drawing.Point(340, 113)
        Me.lblReleaseYear.Name = "lblReleaseYear"
        Me.lblReleaseYear.Size = New System.Drawing.Size(95, 19)
        Me.lblReleaseYear.TabIndex = 10
        Me.lblReleaseYear.Text = "Release Year:"
        '
        'txtDeveloper
        '
        Me.txtDeveloper.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeveloper.Location = New System.Drawing.Point(450, 70)
        Me.txtDeveloper.Name = "txtDeveloper"
        Me.txtDeveloper.Size = New System.Drawing.Size(200, 27)
        Me.txtDeveloper.TabIndex = 9
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeveloper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblDeveloper.Location = New System.Drawing.Point(340, 73)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(84, 19)
        Me.lblDeveloper.TabIndex = 8
        Me.lblDeveloper.Text = "Developer:"
        '
        'txtPlatform
        '
        Me.txtPlatform.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlatform.Location = New System.Drawing.Point(450, 30)
        Me.txtPlatform.Name = "txtPlatform"
        Me.txtPlatform.Size = New System.Drawing.Size(200, 27)
        Me.txtPlatform.TabIndex = 7
        '
        'lblPlatform
        '
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblPlatform.Location = New System.Drawing.Point(340, 33)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(73, 19)
        Me.lblPlatform.TabIndex = 6
        Me.lblPlatform.Text = "Platform:"
        '
        'txtGenre
        '
        Me.txtGenre.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenre.Location = New System.Drawing.Point(125, 110)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(200, 27)
        Me.txtGenre.TabIndex = 5
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblGenre.Location = New System.Drawing.Point(15, 113)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(54, 19)
        Me.lblGenre.TabIndex = 4
        Me.lblGenre.Text = "Genre:"
        '
        'txtGameName
        '
        Me.txtGameName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameName.Location = New System.Drawing.Point(125, 70)
        Me.txtGameName.Name = "txtGameName"
        Me.txtGameName.Size = New System.Drawing.Size(200, 27)
        Me.txtGameName.TabIndex = 3
        '
        'lblGameName
        '
        Me.lblGameName.AutoSize = True
        Me.lblGameName.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblGameName.Location = New System.Drawing.Point(15, 73)
        Me.lblGameName.Name = "lblGameName"
        Me.lblGameName.Size = New System.Drawing.Size(97, 19)
        Me.lblGameName.TabIndex = 2
        Me.lblGameName.Text = "Game Name:"
        '
        'txtGameID
        '
        Me.txtGameID.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameID.Location = New System.Drawing.Point(125, 30)
        Me.txtGameID.Name = "txtGameID"
        Me.txtGameID.ReadOnly = True
        Me.txtGameID.Size = New System.Drawing.Size(200, 27)
        Me.txtGameID.TabIndex = 1
        '
        'lblGameID
        '
        Me.lblGameID.AutoSize = True
        Me.lblGameID.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblGameID.Location = New System.Drawing.Point(15, 33)
        Me.lblGameID.Name = "lblGameID"
        Me.lblGameID.Size = New System.Drawing.Size(69, 19)
        Me.lblGameID.TabIndex = 0
        Me.lblGameID.Text = "Game ID:"
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.Controls.Add(Me.btnRefresh)
        Me.pnlButtons.Controls.Add(Me.btnClear)
        Me.pnlButtons.Controls.Add(Me.btnDeleteGame)
        Me.pnlButtons.Controls.Add(Me.btnUpdateGame)
        Me.pnlButtons.Controls.Add(Me.btnAddGame)
        Me.pnlButtons.Location = New System.Drawing.Point(15, 250)
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
        Me.btnRefresh.Location = New System.Drawing.Point(790, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(170, 40)
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
        Me.btnClear.Location = New System.Drawing.Point(595, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 40)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDeleteGame
        '
        Me.btnDeleteGame.BackColor = System.Drawing.Color.White
        Me.btnDeleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteGame.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnDeleteGame.Location = New System.Drawing.Point(400, 5)
        Me.btnDeleteGame.Name = "btnDeleteGame"
        Me.btnDeleteGame.Size = New System.Drawing.Size(170, 40)
        Me.btnDeleteGame.TabIndex = 2
        Me.btnDeleteGame.Text = "Delete Game"
        Me.btnDeleteGame.UseVisualStyleBackColor = False
        '
        'btnUpdateGame
        '
        Me.btnUpdateGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnUpdateGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateGame.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateGame.ForeColor = System.Drawing.Color.White
        Me.btnUpdateGame.Location = New System.Drawing.Point(205, 5)
        Me.btnUpdateGame.Name = "btnUpdateGame"
        Me.btnUpdateGame.Size = New System.Drawing.Size(170, 40)
        Me.btnUpdateGame.TabIndex = 1
        Me.btnUpdateGame.Text = "Update Game"
        Me.btnUpdateGame.UseVisualStyleBackColor = False
        '
        'btnAddGame
        '
        Me.btnAddGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddGame.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGame.ForeColor = System.Drawing.Color.White
        Me.btnAddGame.Location = New System.Drawing.Point(10, 5)
        Me.btnAddGame.Name = "btnAddGame"
        Me.btnAddGame.Size = New System.Drawing.Size(170, 40)
        Me.btnAddGame.TabIndex = 0
        Me.btnAddGame.Text = "+ Add Game"
        Me.btnAddGame.UseVisualStyleBackColor = False
        '
        'dgvGames
        '
        Me.dgvGames.AllowUserToAddRows = False
        Me.dgvGames.AllowUserToDeleteRows = False
        Me.dgvGames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGames.Location = New System.Drawing.Point(15, 315)
        Me.dgvGames.MultiSelect = False
        Me.dgvGames.Name = "dgvGames"
        Me.dgvGames.ReadOnly = True
        Me.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGames.Size = New System.Drawing.Size(978, 390)
        Me.dgvGames.TabIndex = 4
        '
        'GameManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 720)
        Me.Controls.Add(Me.dgvGames)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.gbGameDetails)
        Me.Controls.Add(Me.pnlHeaderArea)
        Me.Controls.Add(Me.pnlAccentBar)
        Me.Name = "GameManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Management - Game Library System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeaderArea.ResumeLayout(False)
        Me.pnlHeaderArea.PerformLayout()
        Me.gbGameDetails.ResumeLayout(False)
        Me.gbGameDetails.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.dgvGames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAccentBar As System.Windows.Forms.Panel
    Friend WithEvents pnlHeaderArea As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents gbGameDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtGameID As System.Windows.Forms.TextBox
    Friend WithEvents lblGameID As System.Windows.Forms.Label
    Friend WithEvents txtGameName As System.Windows.Forms.TextBox
    Friend WithEvents lblGameName As System.Windows.Forms.Label
    Friend WithEvents txtGenre As System.Windows.Forms.TextBox
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents txtPlatform As System.Windows.Forms.TextBox
    Friend WithEvents lblPlatform As System.Windows.Forms.Label
    Friend WithEvents txtDeveloper As System.Windows.Forms.TextBox
    Friend WithEvents lblDeveloper As System.Windows.Forms.Label
    Friend WithEvents txtReleaseYear As System.Windows.Forms.TextBox
    Friend WithEvents lblReleaseYear As System.Windows.Forms.Label
    Friend WithEvents txtTotalQty As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalQty As System.Windows.Forms.Label
    Friend WithEvents txtAvailableQty As System.Windows.Forms.TextBox
    Friend WithEvents lblAvailableQty As System.Windows.Forms.Label
    Friend WithEvents txtRentalPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblRentalPrice As System.Windows.Forms.Label
    Friend WithEvents txtSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblSellingPrice As System.Windows.Forms.Label
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDeleteGame As System.Windows.Forms.Button
    Friend WithEvents btnUpdateGame As System.Windows.Forms.Button
    Friend WithEvents btnAddGame As System.Windows.Forms.Button
    Friend WithEvents dgvGames As System.Windows.Forms.DataGridView
End Class
