<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowIssueForm
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
        Me.gbIssueDetails = New System.Windows.Forms.GroupBox()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.txtBorrowerContact = New System.Windows.Forms.TextBox()
        Me.lblBorrowerContact = New System.Windows.Forms.Label()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.lblBorrowerName = New System.Windows.Forms.Label()
        Me.cmbGames = New System.Windows.Forms.ComboBox()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.txtIssueID = New System.Windows.Forms.TextBox()
        Me.lblIssueID = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReturnGame = New System.Windows.Forms.Button()
        Me.btnIssueGame = New System.Windows.Forms.Button()
        Me.dgvActiveIssues = New System.Windows.Forms.DataGridView()
        Me.lblGridHeader = New System.Windows.Forms.Label()
        Me.pnlHeaderArea.SuspendLayout()
        Me.gbIssueDetails.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.dgvActiveIssues, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblSubtitle.Size = New System.Drawing.Size(298, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Issue games to borrowers and process returns"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(18, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(287, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Borrow && Issue Games"
        '
        'gbIssueDetails
        '
        Me.gbIssueDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbIssueDetails.BackColor = System.Drawing.Color.White
        Me.gbIssueDetails.Controls.Add(Me.dtpDueDate)
        Me.gbIssueDetails.Controls.Add(Me.lblDueDate)
        Me.gbIssueDetails.Controls.Add(Me.dtpIssueDate)
        Me.gbIssueDetails.Controls.Add(Me.lblIssueDate)
        Me.gbIssueDetails.Controls.Add(Me.txtBorrowerContact)
        Me.gbIssueDetails.Controls.Add(Me.lblBorrowerContact)
        Me.gbIssueDetails.Controls.Add(Me.txtBorrowerName)
        Me.gbIssueDetails.Controls.Add(Me.lblBorrowerName)
        Me.gbIssueDetails.Controls.Add(Me.cmbGames)
        Me.gbIssueDetails.Controls.Add(Me.lblGame)
        Me.gbIssueDetails.Controls.Add(Me.txtIssueID)
        Me.gbIssueDetails.Controls.Add(Me.lblIssueID)
        Me.gbIssueDetails.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIssueDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.gbIssueDetails.Location = New System.Drawing.Point(15, 80)
        Me.gbIssueDetails.Name = "gbIssueDetails"
        Me.gbIssueDetails.Size = New System.Drawing.Size(978, 160)
        Me.gbIssueDetails.TabIndex = 2
        Me.gbIssueDetails.TabStop = False
        Me.gbIssueDetails.Text = "Issue Transaction"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDueDate.Location = New System.Drawing.Point(670, 110)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(280, 27)
        Me.dtpDueDate.TabIndex = 11
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblDueDate.Location = New System.Drawing.Point(510, 113)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(75, 19)
        Me.lblDueDate.TabIndex = 10
        Me.lblDueDate.Text = "Due Date:"
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpIssueDate.Location = New System.Drawing.Point(670, 70)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(280, 27)
        Me.dtpIssueDate.TabIndex = 9
        '
        'lblIssueDate
        '
        Me.lblIssueDate.AutoSize = True
        Me.lblIssueDate.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblIssueDate.Location = New System.Drawing.Point(510, 73)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.Size = New System.Drawing.Size(81, 19)
        Me.lblIssueDate.TabIndex = 8
        Me.lblIssueDate.Text = "Issue Date:"
        '
        'txtBorrowerContact
        '
        Me.txtBorrowerContact.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerContact.Location = New System.Drawing.Point(670, 30)
        Me.txtBorrowerContact.Name = "txtBorrowerContact"
        Me.txtBorrowerContact.Size = New System.Drawing.Size(280, 27)
        Me.txtBorrowerContact.TabIndex = 7
        '
        'lblBorrowerContact
        '
        Me.lblBorrowerContact.AutoSize = True
        Me.lblBorrowerContact.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblBorrowerContact.Location = New System.Drawing.Point(510, 33)
        Me.lblBorrowerContact.Name = "lblBorrowerContact"
        Me.lblBorrowerContact.Size = New System.Drawing.Size(127, 19)
        Me.lblBorrowerContact.TabIndex = 6
        Me.lblBorrowerContact.Text = "Borrower Contact:"
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerName.Location = New System.Drawing.Point(160, 110)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(320, 27)
        Me.txtBorrowerName.TabIndex = 5
        '
        'lblBorrowerName
        '
        Me.lblBorrowerName.AutoSize = True
        Me.lblBorrowerName.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblBorrowerName.Location = New System.Drawing.Point(20, 113)
        Me.lblBorrowerName.Name = "lblBorrowerName"
        Me.lblBorrowerName.Size = New System.Drawing.Size(117, 19)
        Me.lblBorrowerName.TabIndex = 4
        Me.lblBorrowerName.Text = "Borrower Name:"
        '
        'cmbGames
        '
        Me.cmbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGames.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGames.FormattingEnabled = True
        Me.cmbGames.Location = New System.Drawing.Point(160, 70)
        Me.cmbGames.Name = "cmbGames"
        Me.cmbGames.Size = New System.Drawing.Size(320, 28)
        Me.cmbGames.TabIndex = 3
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblGame.Location = New System.Drawing.Point(20, 73)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(95, 19)
        Me.lblGame.TabIndex = 2
        Me.lblGame.Text = "Select Game:"
        '
        'txtIssueID
        '
        Me.txtIssueID.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssueID.Location = New System.Drawing.Point(160, 30)
        Me.txtIssueID.Name = "txtIssueID"
        Me.txtIssueID.ReadOnly = True
        Me.txtIssueID.Size = New System.Drawing.Size(320, 27)
        Me.txtIssueID.TabIndex = 1
        '
        'lblIssueID
        '
        Me.lblIssueID.AutoSize = True
        Me.lblIssueID.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblIssueID.Location = New System.Drawing.Point(20, 33)
        Me.lblIssueID.Name = "lblIssueID"
        Me.lblIssueID.Size = New System.Drawing.Size(65, 19)
        Me.lblIssueID.TabIndex = 0
        Me.lblIssueID.Text = "Issue ID:"
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.Controls.Add(Me.btnRefresh)
        Me.pnlButtons.Controls.Add(Me.btnClear)
        Me.pnlButtons.Controls.Add(Me.btnReturnGame)
        Me.pnlButtons.Controls.Add(Me.btnIssueGame)
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
        Me.btnRefresh.Location = New System.Drawing.Point(740, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(210, 40)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(500, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(210, 40)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnReturnGame
        '
        Me.btnReturnGame.BackColor = System.Drawing.Color.White
        Me.btnReturnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnGame.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnReturnGame.Location = New System.Drawing.Point(260, 5)
        Me.btnReturnGame.Name = "btnReturnGame"
        Me.btnReturnGame.Size = New System.Drawing.Size(210, 40)
        Me.btnReturnGame.TabIndex = 1
        Me.btnReturnGame.Text = "Return Game"
        Me.btnReturnGame.UseVisualStyleBackColor = False
        '
        'btnIssueGame
        '
        Me.btnIssueGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnIssueGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssueGame.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueGame.ForeColor = System.Drawing.Color.White
        Me.btnIssueGame.Location = New System.Drawing.Point(20, 5)
        Me.btnIssueGame.Name = "btnIssueGame"
        Me.btnIssueGame.Size = New System.Drawing.Size(210, 40)
        Me.btnIssueGame.TabIndex = 0
        Me.btnIssueGame.Text = "+ Issue Game"
        Me.btnIssueGame.UseVisualStyleBackColor = False
        '
        'dgvActiveIssues
        '
        Me.dgvActiveIssues.AllowUserToAddRows = False
        Me.dgvActiveIssues.AllowUserToDeleteRows = False
        Me.dgvActiveIssues.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvActiveIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActiveIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActiveIssues.Location = New System.Drawing.Point(15, 345)
        Me.dgvActiveIssues.MultiSelect = False
        Me.dgvActiveIssues.Name = "dgvActiveIssues"
        Me.dgvActiveIssues.ReadOnly = True
        Me.dgvActiveIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActiveIssues.Size = New System.Drawing.Size(978, 360)
        Me.dgvActiveIssues.TabIndex = 4
        '
        'lblGridHeader
        '
        Me.lblGridHeader.AutoSize = True
        Me.lblGridHeader.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGridHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblGridHeader.Location = New System.Drawing.Point(15, 312)
        Me.lblGridHeader.Name = "lblGridHeader"
        Me.lblGridHeader.Size = New System.Drawing.Size(282, 21)
        Me.lblGridHeader.TabIndex = 5
        Me.lblGridHeader.Text = "Currently Issued / Borrowed Games"
        '
        'BorrowIssueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 720)
        Me.Controls.Add(Me.lblGridHeader)
        Me.Controls.Add(Me.dgvActiveIssues)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.gbIssueDetails)
        Me.Controls.Add(Me.pnlHeaderArea)
        Me.Controls.Add(Me.pnlAccentBar)
        Me.Name = "BorrowIssueForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrow and Issue Games - Game Library System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeaderArea.ResumeLayout(False)
        Me.pnlHeaderArea.PerformLayout()
        Me.gbIssueDetails.ResumeLayout(False)
        Me.gbIssueDetails.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.dgvActiveIssues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlAccentBar As System.Windows.Forms.Panel
    Friend WithEvents pnlHeaderArea As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents gbIssueDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtIssueID As System.Windows.Forms.TextBox
    Friend WithEvents lblIssueID As System.Windows.Forms.Label
    Friend WithEvents cmbGames As System.Windows.Forms.ComboBox
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents txtBorrowerName As System.Windows.Forms.TextBox
    Friend WithEvents lblBorrowerName As System.Windows.Forms.Label
    Friend WithEvents txtBorrowerContact As System.Windows.Forms.TextBox
    Friend WithEvents lblBorrowerContact As System.Windows.Forms.Label
    Friend WithEvents dtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblIssueDate As System.Windows.Forms.Label
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnReturnGame As System.Windows.Forms.Button
    Friend WithEvents btnIssueGame As System.Windows.Forms.Button
    Friend WithEvents dgvActiveIssues As System.Windows.Forms.DataGridView
    Friend WithEvents lblGridHeader As System.Windows.Forms.Label
End Class
