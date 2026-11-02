<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Me.gbReportTypes = New System.Windows.Forms.GroupBox()
        Me.btnFinalReport = New System.Windows.Forms.Button()
        Me.btnSoldReport = New System.Windows.Forms.Button()
        Me.btnAvailableReport = New System.Windows.Forms.Button()
        Me.btnRentalReport = New System.Windows.Forms.Button()
        Me.btnReturnedReport = New System.Windows.Forms.Button()
        Me.btnBorrowedReport = New System.Windows.Forms.Button()
        Me.btnGameListReport = New System.Windows.Forms.Button()
        Me.lblReportTitle = New System.Windows.Forms.Label()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.pnlHeaderArea.SuspendLayout()
        Me.gbReportTypes.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblSubtitle.Size = New System.Drawing.Size(350, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Generate analytical reports for available, rented && sold games"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(18, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(209, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "System Reports"
        '
        'gbReportTypes
        '
        Me.gbReportTypes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbReportTypes.BackColor = System.Drawing.Color.White
        Me.gbReportTypes.Controls.Add(Me.btnFinalReport)
        Me.gbReportTypes.Controls.Add(Me.btnSoldReport)
        Me.gbReportTypes.Controls.Add(Me.btnAvailableReport)
        Me.gbReportTypes.Controls.Add(Me.btnRentalReport)
        Me.gbReportTypes.Controls.Add(Me.btnReturnedReport)
        Me.gbReportTypes.Controls.Add(Me.btnBorrowedReport)
        Me.gbReportTypes.Controls.Add(Me.btnGameListReport)
        Me.gbReportTypes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbReportTypes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.gbReportTypes.Location = New System.Drawing.Point(15, 80)
        Me.gbReportTypes.Name = "gbReportTypes"
        Me.gbReportTypes.Size = New System.Drawing.Size(978, 125)
        Me.gbReportTypes.TabIndex = 2
        Me.gbReportTypes.TabStop = False
        Me.gbReportTypes.Text = "Select Report Category"
        '
        'btnFinalReport
        '
        Me.btnFinalReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnFinalReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalReport.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnFinalReport.Location = New System.Drawing.Point(585, 26)
        Me.btnFinalReport.Name = "btnFinalReport"
        Me.btnFinalReport.Size = New System.Drawing.Size(375, 40)
        Me.btnFinalReport.TabIndex = 6
        Me.btnFinalReport.Text = "* Final Report: Available, Rented && Sold"
        Me.btnFinalReport.UseVisualStyleBackColor = False
        '
        'btnSoldReport
        '
        Me.btnSoldReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnSoldReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSoldReport.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoldReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnSoldReport.Location = New System.Drawing.Point(395, 26)
        Me.btnSoldReport.Name = "btnSoldReport"
        Me.btnSoldReport.Size = New System.Drawing.Size(180, 40)
        Me.btnSoldReport.TabIndex = 5
        Me.btnSoldReport.Text = "Sold Games"
        Me.btnSoldReport.UseVisualStyleBackColor = False
        '
        'btnAvailableReport
        '
        Me.btnAvailableReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAvailableReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvailableReport.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailableReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnAvailableReport.Location = New System.Drawing.Point(15, 26)
        Me.btnAvailableReport.Name = "btnAvailableReport"
        Me.btnAvailableReport.Size = New System.Drawing.Size(180, 40)
        Me.btnAvailableReport.TabIndex = 4
        Me.btnAvailableReport.Text = "Available Games"
        Me.btnAvailableReport.UseVisualStyleBackColor = False
        '
        'btnRentalReport
        '
        Me.btnRentalReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnRentalReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRentalReport.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRentalReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnRentalReport.Location = New System.Drawing.Point(205, 26)
        Me.btnRentalReport.Name = "btnRentalReport"
        Me.btnRentalReport.Size = New System.Drawing.Size(180, 40)
        Me.btnRentalReport.TabIndex = 3
        Me.btnRentalReport.Text = "Rented Games"
        Me.btnRentalReport.UseVisualStyleBackColor = False
        '
        'btnReturnedReport
        '
        Me.btnReturnedReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnReturnedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnedReport.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnedReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnReturnedReport.Location = New System.Drawing.Point(395, 73)
        Me.btnReturnedReport.Name = "btnReturnedReport"
        Me.btnReturnedReport.Size = New System.Drawing.Size(180, 40)
        Me.btnReturnedReport.TabIndex = 2
        Me.btnReturnedReport.Text = "Returned Borrowing"
        Me.btnReturnedReport.UseVisualStyleBackColor = False
        '
        'btnBorrowedReport
        '
        Me.btnBorrowedReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBorrowedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowedReport.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowedReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnBorrowedReport.Location = New System.Drawing.Point(205, 73)
        Me.btnBorrowedReport.Name = "btnBorrowedReport"
        Me.btnBorrowedReport.Size = New System.Drawing.Size(180, 40)
        Me.btnBorrowedReport.TabIndex = 1
        Me.btnBorrowedReport.Text = "Borrowed / Issued"
        Me.btnBorrowedReport.UseVisualStyleBackColor = False
        '
        'btnGameListReport
        '
        Me.btnGameListReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnGameListReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGameListReport.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGameListReport.ForeColor = System.Drawing.Color.White
        Me.btnGameListReport.Location = New System.Drawing.Point(15, 73)
        Me.btnGameListReport.Name = "btnGameListReport"
        Me.btnGameListReport.Size = New System.Drawing.Size(180, 40)
        Me.btnGameListReport.TabIndex = 0
        Me.btnGameListReport.Text = "All Games Catalog"
        Me.btnGameListReport.UseVisualStyleBackColor = False
        '
        'lblReportTitle
        '
        Me.lblReportTitle.AutoSize = True
        Me.lblReportTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblReportTitle.Location = New System.Drawing.Point(15, 215)
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.Size = New System.Drawing.Size(217, 21)
        Me.lblReportTitle.TabIndex = 3
        Me.lblReportTitle.Text = "Report Data: All Games List"
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(15, 245)
        Me.dgvReport.MultiSelect = False
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReport.Size = New System.Drawing.Size(978, 425)
        Me.dgvReport.TabIndex = 4
        '
        'lblRecordCount
        '
        Me.lblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lblRecordCount.Location = New System.Drawing.Point(15, 685)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(201, 21)
        Me.lblRecordCount.TabIndex = 5
        Me.lblRecordCount.Text = "Total Records Displayed: 0"
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 720)
        Me.Controls.Add(Me.lblRecordCount)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.lblReportTitle)
        Me.Controls.Add(Me.gbReportTypes)
        Me.Controls.Add(Me.pnlHeaderArea)
        Me.Controls.Add(Me.pnlAccentBar)
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports - Game Library System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeaderArea.ResumeLayout(False)
        Me.pnlHeaderArea.PerformLayout()
        Me.gbReportTypes.ResumeLayout(False)
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlAccentBar As System.Windows.Forms.Panel
    Friend WithEvents pnlHeaderArea As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents gbReportTypes As System.Windows.Forms.GroupBox
    Friend WithEvents btnAvailableReport As System.Windows.Forms.Button
    Friend WithEvents btnRentalReport As System.Windows.Forms.Button
    Friend WithEvents btnReturnedReport As System.Windows.Forms.Button
    Friend WithEvents btnBorrowedReport As System.Windows.Forms.Button
    Friend WithEvents btnGameListReport As System.Windows.Forms.Button
    Friend WithEvents btnSoldReport As System.Windows.Forms.Button
    Friend WithEvents btnFinalReport As System.Windows.Forms.Button
    Friend WithEvents lblReportTitle As System.Windows.Forms.Label
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
End Class
