<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnRentals = New System.Windows.Forms.Button()
        Me.btnSearchGames = New System.Windows.Forms.Button()
        Me.btnBorrowHistory = New System.Windows.Forms.Button()
        Me.btnBorrowIssue = New System.Windows.Forms.Button()
        Me.btnGameManagement = New System.Windows.Forms.Button()
        Me.pnlBrand = New System.Windows.Forms.Panel()
        Me.lblBrandSub = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.gbRecentActivity = New System.Windows.Forms.GroupBox()
        Me.btnRefreshDashboard = New System.Windows.Forms.Button()
        Me.dgvRecentActivity = New System.Windows.Forms.DataGridView()
        Me.pnlStats = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlStatSold = New System.Windows.Forms.Panel()
        Me.lblSoldGamesCount = New System.Windows.Forms.Label()
        Me.lblSoldGamesTitle = New System.Windows.Forms.Label()
        Me.pnlStatRented = New System.Windows.Forms.Panel()
        Me.lblRentedGamesCount = New System.Windows.Forms.Label()
        Me.lblRentedGamesTitle = New System.Windows.Forms.Label()
        Me.pnlStatBorrowed = New System.Windows.Forms.Panel()
        Me.lblBorrowedGamesCount = New System.Windows.Forms.Label()
        Me.lblBorrowedGamesTitle = New System.Windows.Forms.Label()
        Me.pnlStatAvailable = New System.Windows.Forms.Panel()
        Me.lblAvailableGamesCount = New System.Windows.Forms.Label()
        Me.lblAvailableGamesTitle = New System.Windows.Forms.Label()
        Me.pnlStatCopies = New System.Windows.Forms.Panel()
        Me.lblTotalCopiesCount = New System.Windows.Forms.Label()
        Me.lblTotalCopiesTitle = New System.Windows.Forms.Label()
        Me.pnlStatTotal = New System.Windows.Forms.Panel()
        Me.lblTotalGamesCount = New System.Windows.Forms.Label()
        Me.lblTotalGamesTitle = New System.Windows.Forms.Label()
        Me.pnlHeaderArea = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlBrand.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.gbRecentActivity.SuspendLayout()
        CType(Me.dgvRecentActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStats.SuspendLayout()
        Me.pnlStatSold.SuspendLayout()
        Me.pnlStatRented.SuspendLayout()
        Me.pnlStatBorrowed.SuspendLayout()
        Me.pnlStatAvailable.SuspendLayout()
        Me.pnlStatCopies.SuspendLayout()
        Me.pnlStatTotal.SuspendLayout()
        Me.pnlHeaderArea.SuspendLayout()
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
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.White
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnRentals)
        Me.pnlSidebar.Controls.Add(Me.btnSearchGames)
        Me.pnlSidebar.Controls.Add(Me.btnBorrowHistory)
        Me.pnlSidebar.Controls.Add(Me.btnBorrowIssue)
        Me.pnlSidebar.Controls.Add(Me.btnGameManagement)
        Me.pnlSidebar.Controls.Add(Me.pnlBrand)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 4)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(230, 716)
        Me.pnlSidebar.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(12, 655)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(206, 44)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout System"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnReports.Location = New System.Drawing.Point(12, 330)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(206, 44)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "System Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnRentals
        '
        Me.btnRentals.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRentals.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRentals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnRentals.Location = New System.Drawing.Point(12, 280)
        Me.btnRentals.Name = "btnRentals"
        Me.btnRentals.Size = New System.Drawing.Size(206, 44)
        Me.btnRentals.TabIndex = 5
        Me.btnRentals.Text = "Rent && Sell Games"
        Me.btnRentals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRentals.UseVisualStyleBackColor = False
        '
        'btnSearchGames
        '
        Me.btnSearchGames.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearchGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchGames.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchGames.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnSearchGames.Location = New System.Drawing.Point(12, 230)
        Me.btnSearchGames.Name = "btnSearchGames"
        Me.btnSearchGames.Size = New System.Drawing.Size(206, 44)
        Me.btnSearchGames.TabIndex = 4
        Me.btnSearchGames.Text = "Search Catalog"
        Me.btnSearchGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchGames.UseVisualStyleBackColor = False
        '
        'btnBorrowHistory
        '
        Me.btnBorrowHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBorrowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowHistory.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnBorrowHistory.Location = New System.Drawing.Point(12, 180)
        Me.btnBorrowHistory.Name = "btnBorrowHistory"
        Me.btnBorrowHistory.Size = New System.Drawing.Size(206, 44)
        Me.btnBorrowHistory.TabIndex = 3
        Me.btnBorrowHistory.Text = "Borrow History"
        Me.btnBorrowHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowHistory.UseVisualStyleBackColor = False
        '
        'btnBorrowIssue
        '
        Me.btnBorrowIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBorrowIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowIssue.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowIssue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnBorrowIssue.Location = New System.Drawing.Point(12, 130)
        Me.btnBorrowIssue.Name = "btnBorrowIssue"
        Me.btnBorrowIssue.Size = New System.Drawing.Size(206, 44)
        Me.btnBorrowIssue.TabIndex = 2
        Me.btnBorrowIssue.Text = "Borrow && Issue"
        Me.btnBorrowIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowIssue.UseVisualStyleBackColor = False
        '
        'btnGameManagement
        '
        Me.btnGameManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnGameManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGameManagement.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGameManagement.ForeColor = System.Drawing.Color.White
        Me.btnGameManagement.Location = New System.Drawing.Point(12, 80)
        Me.btnGameManagement.Name = "btnGameManagement"
        Me.btnGameManagement.Size = New System.Drawing.Size(206, 44)
        Me.btnGameManagement.TabIndex = 1
        Me.btnGameManagement.Text = "Game Management"
        Me.btnGameManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGameManagement.UseVisualStyleBackColor = False
        '
        'pnlBrand
        '
        Me.pnlBrand.Controls.Add(Me.lblBrandSub)
        Me.pnlBrand.Controls.Add(Me.lblBrand)
        Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(230, 70)
        Me.pnlBrand.TabIndex = 0
        '
        'lblBrandSub
        '
        Me.lblBrandSub.AutoSize = True
        Me.lblBrandSub.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblBrandSub.Location = New System.Drawing.Point(12, 42)
        Me.lblBrandSub.Name = "lblBrandSub"
        Me.lblBrandSub.Size = New System.Drawing.Size(142, 15)
        Me.lblBrandSub.TabIndex = 1
        Me.lblBrandSub.Text = "MANAGEMENT SYSTEM"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblBrand.Location = New System.Drawing.Point(10, 10)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(155, 30)
        Me.lblBrand.TabIndex = 0
        Me.lblBrand.Text = "GLM LIBRARY"
        '
        'pnlMainContent
        '
        Me.pnlMainContent.Controls.Add(Me.gbRecentActivity)
        Me.pnlMainContent.Controls.Add(Me.pnlStats)
        Me.pnlMainContent.Controls.Add(Me.pnlHeaderArea)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(230, 4)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(778, 716)
        Me.pnlMainContent.TabIndex = 2
        '
        'gbRecentActivity
        '
        Me.gbRecentActivity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRecentActivity.BackColor = System.Drawing.Color.White
        Me.gbRecentActivity.Controls.Add(Me.btnRefreshDashboard)
        Me.gbRecentActivity.Controls.Add(Me.dgvRecentActivity)
        Me.gbRecentActivity.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRecentActivity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.gbRecentActivity.Location = New System.Drawing.Point(20, 215)
        Me.gbRecentActivity.Name = "gbRecentActivity"
        Me.gbRecentActivity.Size = New System.Drawing.Size(740, 480)
        Me.gbRecentActivity.TabIndex = 2
        Me.gbRecentActivity.TabStop = False
        Me.gbRecentActivity.Text = "Recent Library Activity && Transactions"
        '
        'btnRefreshDashboard
        '
        Me.btnRefreshDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnRefreshDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshDashboard.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnRefreshDashboard.Location = New System.Drawing.Point(600, 22)
        Me.btnRefreshDashboard.Name = "btnRefreshDashboard"
        Me.btnRefreshDashboard.Size = New System.Drawing.Size(125, 32)
        Me.btnRefreshDashboard.TabIndex = 1
        Me.btnRefreshDashboard.Text = "Refresh Data"
        Me.btnRefreshDashboard.UseVisualStyleBackColor = False
        '
        'dgvRecentActivity
        '
        Me.dgvRecentActivity.AllowUserToAddRows = False
        Me.dgvRecentActivity.AllowUserToDeleteRows = False
        Me.dgvRecentActivity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRecentActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentActivity.Location = New System.Drawing.Point(15, 60)
        Me.dgvRecentActivity.MultiSelect = False
        Me.dgvRecentActivity.Name = "dgvRecentActivity"
        Me.dgvRecentActivity.ReadOnly = True
        Me.dgvRecentActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecentActivity.Size = New System.Drawing.Size(710, 405)
        Me.dgvRecentActivity.TabIndex = 0
        '
        'pnlStats
        '
        Me.pnlStats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStats.ColumnCount = 6
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.pnlStats.Controls.Add(Me.pnlStatSold, 5, 0)
        Me.pnlStats.Controls.Add(Me.pnlStatRented, 4, 0)
        Me.pnlStats.Controls.Add(Me.pnlStatBorrowed, 3, 0)
        Me.pnlStats.Controls.Add(Me.pnlStatAvailable, 2, 0)
        Me.pnlStats.Controls.Add(Me.pnlStatCopies, 1, 0)
        Me.pnlStats.Controls.Add(Me.pnlStatTotal, 0, 0)
        Me.pnlStats.Location = New System.Drawing.Point(15, 80)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.RowCount = 1
        Me.pnlStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlStats.Size = New System.Drawing.Size(748, 120)
        Me.pnlStats.TabIndex = 1
        '
        'pnlStatSold
        '
        Me.pnlStatSold.BackColor = System.Drawing.Color.White
        Me.pnlStatSold.Controls.Add(Me.lblSoldGamesCount)
        Me.pnlStatSold.Controls.Add(Me.lblSoldGamesTitle)
        Me.pnlStatSold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatSold.Location = New System.Drawing.Point(625, 3)
        Me.pnlStatSold.Name = "pnlStatSold"
        Me.pnlStatSold.Size = New System.Drawing.Size(120, 114)
        Me.pnlStatSold.TabIndex = 5
        '
        'lblSoldGamesCount
        '
        Me.lblSoldGamesCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSoldGamesCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoldGamesCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblSoldGamesCount.Location = New System.Drawing.Point(0, 35)
        Me.lblSoldGamesCount.Name = "lblSoldGamesCount"
        Me.lblSoldGamesCount.Size = New System.Drawing.Size(120, 79)
        Me.lblSoldGamesCount.TabIndex = 1
        Me.lblSoldGamesCount.Text = "0"
        Me.lblSoldGamesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSoldGamesTitle
        '
        Me.lblSoldGamesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSoldGamesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoldGamesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblSoldGamesTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblSoldGamesTitle.Name = "lblSoldGamesTitle"
        Me.lblSoldGamesTitle.Size = New System.Drawing.Size(120, 35)
        Me.lblSoldGamesTitle.TabIndex = 0
        Me.lblSoldGamesTitle.Text = "Sold Games"
        Me.lblSoldGamesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStatRented
        '
        Me.pnlStatRented.BackColor = System.Drawing.Color.White
        Me.pnlStatRented.Controls.Add(Me.lblRentedGamesCount)
        Me.pnlStatRented.Controls.Add(Me.lblRentedGamesTitle)
        Me.pnlStatRented.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatRented.Location = New System.Drawing.Point(599, 3)
        Me.pnlStatRented.Name = "pnlStatRented"
        Me.pnlStatRented.Size = New System.Drawing.Size(146, 114)
        Me.pnlStatRented.TabIndex = 4
        '
        'lblRentedGamesCount
        '
        Me.lblRentedGamesCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRentedGamesCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentedGamesCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblRentedGamesCount.Location = New System.Drawing.Point(0, 35)
        Me.lblRentedGamesCount.Name = "lblRentedGamesCount"
        Me.lblRentedGamesCount.Size = New System.Drawing.Size(146, 79)
        Me.lblRentedGamesCount.TabIndex = 1
        Me.lblRentedGamesCount.Text = "0"
        Me.lblRentedGamesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRentedGamesTitle
        '
        Me.lblRentedGamesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRentedGamesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentedGamesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblRentedGamesTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblRentedGamesTitle.Name = "lblRentedGamesTitle"
        Me.lblRentedGamesTitle.Size = New System.Drawing.Size(146, 35)
        Me.lblRentedGamesTitle.TabIndex = 0
        Me.lblRentedGamesTitle.Text = "Active Rentals"
        Me.lblRentedGamesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStatBorrowed
        '
        Me.pnlStatBorrowed.BackColor = System.Drawing.Color.White
        Me.pnlStatBorrowed.Controls.Add(Me.lblBorrowedGamesCount)
        Me.pnlStatBorrowed.Controls.Add(Me.lblBorrowedGamesTitle)
        Me.pnlStatBorrowed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatBorrowed.Location = New System.Drawing.Point(450, 3)
        Me.pnlStatBorrowed.Name = "pnlStatBorrowed"
        Me.pnlStatBorrowed.Size = New System.Drawing.Size(143, 114)
        Me.pnlStatBorrowed.TabIndex = 3
        '
        'lblBorrowedGamesCount
        '
        Me.lblBorrowedGamesCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBorrowedGamesCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowedGamesCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblBorrowedGamesCount.Location = New System.Drawing.Point(0, 35)
        Me.lblBorrowedGamesCount.Name = "lblBorrowedGamesCount"
        Me.lblBorrowedGamesCount.Size = New System.Drawing.Size(143, 79)
        Me.lblBorrowedGamesCount.TabIndex = 1
        Me.lblBorrowedGamesCount.Text = "0"
        Me.lblBorrowedGamesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBorrowedGamesTitle
        '
        Me.lblBorrowedGamesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBorrowedGamesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowedGamesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblBorrowedGamesTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblBorrowedGamesTitle.Name = "lblBorrowedGamesTitle"
        Me.lblBorrowedGamesTitle.Size = New System.Drawing.Size(143, 35)
        Me.lblBorrowedGamesTitle.TabIndex = 0
        Me.lblBorrowedGamesTitle.Text = "Borrowed Games"
        Me.lblBorrowedGamesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStatAvailable
        '
        Me.pnlStatAvailable.BackColor = System.Drawing.Color.White
        Me.pnlStatAvailable.Controls.Add(Me.lblAvailableGamesCount)
        Me.pnlStatAvailable.Controls.Add(Me.lblAvailableGamesTitle)
        Me.pnlStatAvailable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatAvailable.Location = New System.Drawing.Point(301, 3)
        Me.pnlStatAvailable.Name = "pnlStatAvailable"
        Me.pnlStatAvailable.Size = New System.Drawing.Size(143, 114)
        Me.pnlStatAvailable.TabIndex = 2
        '
        'lblAvailableGamesCount
        '
        Me.lblAvailableGamesCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAvailableGamesCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableGamesCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblAvailableGamesCount.Location = New System.Drawing.Point(0, 35)
        Me.lblAvailableGamesCount.Name = "lblAvailableGamesCount"
        Me.lblAvailableGamesCount.Size = New System.Drawing.Size(143, 79)
        Me.lblAvailableGamesCount.TabIndex = 1
        Me.lblAvailableGamesCount.Text = "0"
        Me.lblAvailableGamesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvailableGamesTitle
        '
        Me.lblAvailableGamesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAvailableGamesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableGamesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblAvailableGamesTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblAvailableGamesTitle.Name = "lblAvailableGamesTitle"
        Me.lblAvailableGamesTitle.Size = New System.Drawing.Size(143, 35)
        Me.lblAvailableGamesTitle.TabIndex = 0
        Me.lblAvailableGamesTitle.Text = "Available Copies"
        Me.lblAvailableGamesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStatCopies
        '
        Me.pnlStatCopies.BackColor = System.Drawing.Color.White
        Me.pnlStatCopies.Controls.Add(Me.lblTotalCopiesCount)
        Me.pnlStatCopies.Controls.Add(Me.lblTotalCopiesTitle)
        Me.pnlStatCopies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatCopies.Location = New System.Drawing.Point(152, 3)
        Me.pnlStatCopies.Name = "pnlStatCopies"
        Me.pnlStatCopies.Size = New System.Drawing.Size(143, 114)
        Me.pnlStatCopies.TabIndex = 1
        '
        'lblTotalCopiesCount
        '
        Me.lblTotalCopiesCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalCopiesCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCopiesCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblTotalCopiesCount.Location = New System.Drawing.Point(0, 35)
        Me.lblTotalCopiesCount.Name = "lblTotalCopiesCount"
        Me.lblTotalCopiesCount.Size = New System.Drawing.Size(143, 79)
        Me.lblTotalCopiesCount.TabIndex = 1
        Me.lblTotalCopiesCount.Text = "0"
        Me.lblTotalCopiesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalCopiesTitle
        '
        Me.lblTotalCopiesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTotalCopiesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCopiesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblTotalCopiesTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTotalCopiesTitle.Name = "lblTotalCopiesTitle"
        Me.lblTotalCopiesTitle.Size = New System.Drawing.Size(143, 35)
        Me.lblTotalCopiesTitle.TabIndex = 0
        Me.lblTotalCopiesTitle.Text = "Total Copies"
        Me.lblTotalCopiesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStatTotal
        '
        Me.pnlStatTotal.BackColor = System.Drawing.Color.White
        Me.pnlStatTotal.Controls.Add(Me.lblTotalGamesCount)
        Me.pnlStatTotal.Controls.Add(Me.lblTotalGamesTitle)
        Me.pnlStatTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatTotal.Location = New System.Drawing.Point(3, 3)
        Me.pnlStatTotal.Name = "pnlStatTotal"
        Me.pnlStatTotal.Size = New System.Drawing.Size(143, 114)
        Me.pnlStatTotal.TabIndex = 0
        '
        'lblTotalGamesCount
        '
        Me.lblTotalGamesCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalGamesCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGamesCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblTotalGamesCount.Location = New System.Drawing.Point(0, 35)
        Me.lblTotalGamesCount.Name = "lblTotalGamesCount"
        Me.lblTotalGamesCount.Size = New System.Drawing.Size(143, 79)
        Me.lblTotalGamesCount.TabIndex = 1
        Me.lblTotalGamesCount.Text = "0"
        Me.lblTotalGamesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalGamesTitle
        '
        Me.lblTotalGamesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTotalGamesTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGamesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblTotalGamesTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTotalGamesTitle.Name = "lblTotalGamesTitle"
        Me.lblTotalGamesTitle.Size = New System.Drawing.Size(143, 35)
        Me.lblTotalGamesTitle.TabIndex = 0
        Me.lblTotalGamesTitle.Text = "Distinct Games"
        Me.lblTotalGamesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlHeaderArea
        '
        Me.pnlHeaderArea.Controls.Add(Me.lblSubtitle)
        Me.pnlHeaderArea.Controls.Add(Me.lblTitle)
        Me.pnlHeaderArea.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderArea.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderArea.Name = "pnlHeaderArea"
        Me.pnlHeaderArea.Size = New System.Drawing.Size(778, 70)
        Me.pnlHeaderArea.TabIndex = 0
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(20, 42)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(320, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Overview of library inventory, borrowings && rentals"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(18, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(332, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "System Dashboard Overview"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 720)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlAccentBar)
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard - Game Library System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlBrand.ResumeLayout(False)
        Me.pnlBrand.PerformLayout()
        Me.pnlMainContent.ResumeLayout(False)
        Me.gbRecentActivity.ResumeLayout(False)
        CType(Me.dgvRecentActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStatRented.ResumeLayout(False)
        Me.pnlStatBorrowed.ResumeLayout(False)
        Me.pnlStatAvailable.ResumeLayout(False)
        Me.pnlStatCopies.ResumeLayout(False)
        Me.pnlStatTotal.ResumeLayout(False)
        Me.pnlHeaderArea.ResumeLayout(False)
        Me.pnlHeaderArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAccentBar As System.Windows.Forms.Panel
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblBrandSub As System.Windows.Forms.Label
    Friend WithEvents btnGameManagement As System.Windows.Forms.Button
    Friend WithEvents btnBorrowIssue As System.Windows.Forms.Button
    Friend WithEvents btnBorrowHistory As System.Windows.Forms.Button
    Friend WithEvents btnSearchGames As System.Windows.Forms.Button
    Friend WithEvents btnRentals As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlMainContent As System.Windows.Forms.Panel
    Friend WithEvents pnlHeaderArea As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents pnlStats As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlStatTotal As System.Windows.Forms.Panel
    Friend WithEvents lblTotalGamesCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalGamesTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatCopies As System.Windows.Forms.Panel
    Friend WithEvents lblTotalCopiesCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalCopiesTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatAvailable As System.Windows.Forms.Panel
    Friend WithEvents lblAvailableGamesCount As System.Windows.Forms.Label
    Friend WithEvents lblAvailableGamesTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatBorrowed As System.Windows.Forms.Panel
    Friend WithEvents lblBorrowedGamesCount As System.Windows.Forms.Label
    Friend WithEvents lblBorrowedGamesTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatRented As System.Windows.Forms.Panel
    Friend WithEvents lblRentedGamesCount As System.Windows.Forms.Label
    Friend WithEvents lblRentedGamesTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatSold As System.Windows.Forms.Panel
    Friend WithEvents lblSoldGamesCount As System.Windows.Forms.Label
    Friend WithEvents lblSoldGamesTitle As System.Windows.Forms.Label
    Friend WithEvents gbRecentActivity As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRecentActivity As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefreshDashboard As System.Windows.Forms.Button
End Class
