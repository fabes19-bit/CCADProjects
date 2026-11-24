namespace Assignment3_3_2;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private Panel pnlHeader;
    private Label lblTitle;
    private Label lblSubtitle;

    private GroupBox grpStudentInfo;
    private Label lblStudId;
    private TextBox txtStudId;
    private Label lblFirstName;
    private TextBox txtFirstName;
    private Label lblLastName;
    private TextBox txtLastName;
    private Label lblAddress;
    private TextBox txtAddress;
    private Label lblMonth;
    private ComboBox cmbMonth;
    private Label lblGrade;
    private ComboBox cmbGrade;
    private Button btnAdd;
    private Button btnClear;
    private Button btnSeed;

    private GroupBox grpGrid;
    private DataGridView dgvStudents;
    private Button btnDelete;
    private Label lblCount;

    private StatusStrip statusStrip;
    private ToolStripStatusLabel statusLabel;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        DataGridViewCellStyle dgvHeaderStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvAltRowStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvDefaultRowStyle = new DataGridViewCellStyle();

        pnlHeader = new Panel();
        lblTitle = new Label();
        lblSubtitle = new Label();

        grpStudentInfo = new GroupBox();
        lblStudId = new Label();
        txtStudId = new TextBox();
        lblFirstName = new Label();
        txtFirstName = new TextBox();
        lblLastName = new Label();
        txtLastName = new TextBox();
        lblAddress = new Label();
        txtAddress = new TextBox();
        lblMonth = new Label();
        cmbMonth = new ComboBox();
        lblGrade = new Label();
        cmbGrade = new ComboBox();
        btnAdd = new Button();
        btnClear = new Button();
        btnSeed = new Button();

        grpGrid = new GroupBox();
        dgvStudents = new DataGridView();
        btnDelete = new Button();
        lblCount = new Label();

        statusStrip = new StatusStrip();
        statusLabel = new ToolStripStatusLabel();

        pnlHeader.SuspendLayout();
        grpStudentInfo.SuspendLayout();
        grpGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
        statusStrip.SuspendLayout();
        SuspendLayout();

        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(24, 76, 120);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1008, 75);
        pnlHeader.TabIndex = 0;

        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(18, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(390, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Student Record Management System";

        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9.5F);
        lblSubtitle.ForeColor = Color.FromArgb(210, 230, 250);
        lblSubtitle.Location = new Point(20, 44);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(575, 17);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Assignment 3.3.2 — Student Class, Enums (Monthofadmission), and DataGridView Operations";

        // 
        // grpStudentInfo
        // 
        grpStudentInfo.Controls.Add(lblStudId);
        grpStudentInfo.Controls.Add(txtStudId);
        grpStudentInfo.Controls.Add(lblFirstName);
        grpStudentInfo.Controls.Add(txtFirstName);
        grpStudentInfo.Controls.Add(lblLastName);
        grpStudentInfo.Controls.Add(txtLastName);
        grpStudentInfo.Controls.Add(lblAddress);
        grpStudentInfo.Controls.Add(txtAddress);
        grpStudentInfo.Controls.Add(lblMonth);
        grpStudentInfo.Controls.Add(cmbMonth);
        grpStudentInfo.Controls.Add(lblGrade);
        grpStudentInfo.Controls.Add(cmbGrade);
        grpStudentInfo.Controls.Add(btnAdd);
        grpStudentInfo.Controls.Add(btnClear);
        grpStudentInfo.Controls.Add(btnSeed);
        grpStudentInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpStudentInfo.ForeColor = Color.FromArgb(30, 41, 59);
        grpStudentInfo.Location = new Point(18, 88);
        grpStudentInfo.Name = "grpStudentInfo";
        grpStudentInfo.Size = new Size(330, 520);
        grpStudentInfo.TabIndex = 1;
        grpStudentInfo.TabStop = false;
        grpStudentInfo.Text = " Student Details ";

        // 
        // lblStudId
        // 
        lblStudId.AutoSize = true;
        lblStudId.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblStudId.Location = new Point(16, 30);
        lblStudId.Name = "lblStudId";
        lblStudId.Size = new Size(65, 15);
        lblStudId.TabIndex = 0;
        lblStudId.Text = "Student ID:";

        // 
        // txtStudId
        // 
        txtStudId.Font = new Font("Segoe UI", 9.5F);
        txtStudId.Location = new Point(16, 48);
        txtStudId.Name = "txtStudId";
        txtStudId.PlaceholderText = "e.g., 101";
        txtStudId.Size = new Size(295, 24);
        txtStudId.TabIndex = 1;

        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblFirstName.Location = new Point(16, 82);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(67, 15);
        lblFirstName.TabIndex = 2;
        lblFirstName.Text = "First Name:";

        // 
        // txtFirstName
        // 
        txtFirstName.Font = new Font("Segoe UI", 9.5F);
        txtFirstName.Location = new Point(16, 100);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.PlaceholderText = "e.g., Fabian";
        txtFirstName.Size = new Size(295, 24);
        txtFirstName.TabIndex = 3;

        // 
        // lblLastName
        // 
        lblLastName.AutoSize = true;
        lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblLastName.Location = new Point(16, 134);
        lblLastName.Name = "lblLastName";
        lblLastName.Size = new Size(66, 15);
        lblLastName.TabIndex = 4;
        lblLastName.Text = "Last Name:";

        // 
        // txtLastName
        // 
        txtLastName.Font = new Font("Segoe UI", 9.5F);
        txtLastName.Location = new Point(16, 152);
        txtLastName.Name = "txtLastName";
        txtLastName.PlaceholderText = "e.g., Rollins";
        txtLastName.Size = new Size(295, 24);
        txtLastName.TabIndex = 5;

        // 
        // lblAddress
        // 
        lblAddress.AutoSize = true;
        lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblAddress.Location = new Point(16, 186);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new Size(52, 15);
        lblAddress.TabIndex = 6;
        lblAddress.Text = "Address:";

        // 
        // txtAddress
        // 
        txtAddress.Font = new Font("Segoe UI", 9.5F);
        txtAddress.Location = new Point(16, 204);
        txtAddress.Name = "txtAddress";
        txtAddress.PlaceholderText = "e.g., 123 Campus Way";
        txtAddress.Size = new Size(295, 24);
        txtAddress.TabIndex = 7;

        // 
        // lblMonth
        // 
        lblMonth.AutoSize = true;
        lblMonth.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblMonth.Location = new Point(16, 238);
        lblMonth.Name = "lblMonth";
        lblMonth.Size = new Size(160, 15);
        lblMonth.TabIndex = 8;
        lblMonth.Text = "Month of Admission (Enum):";

        // 
        // cmbMonth
        // 
        cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMonth.Font = new Font("Segoe UI", 9.5F);
        cmbMonth.FormattingEnabled = true;
        cmbMonth.Location = new Point(16, 256);
        cmbMonth.Name = "cmbMonth";
        cmbMonth.Size = new Size(295, 25);
        cmbMonth.TabIndex = 9;

        // 
        // lblGrade
        // 
        lblGrade.AutoSize = true;
        lblGrade.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        lblGrade.Location = new Point(16, 292);
        lblGrade.Name = "lblGrade";
        lblGrade.Size = new Size(130, 15);
        lblGrade.TabIndex = 10;
        lblGrade.Text = "Grade (Character A - F):";

        // 
        // cmbGrade
        // 
        cmbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbGrade.Font = new Font("Segoe UI", 9.5F);
        cmbGrade.FormattingEnabled = true;
        cmbGrade.Location = new Point(16, 310);
        cmbGrade.Name = "cmbGrade";
        cmbGrade.Size = new Size(295, 25);
        cmbGrade.TabIndex = 11;

        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(16, 124, 65);
        btnAdd.Cursor = Cursors.Hand;
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(16, 360);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(295, 36);
        btnAdd.TabIndex = 12;
        btnAdd.Text = "+ Add New Record";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;

        // 
        // btnClear
        // 
        btnClear.BackColor = Color.FromArgb(226, 232, 240);
        btnClear.Cursor = Cursors.Hand;
        btnClear.FlatAppearance.BorderSize = 0;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        btnClear.ForeColor = Color.FromArgb(30, 41, 59);
        btnClear.Location = new Point(16, 406);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(142, 32);
        btnClear.TabIndex = 13;
        btnClear.Text = "Clear Fields";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;

        // 
        // btnSeed
        // 
        btnSeed.BackColor = Color.FromArgb(226, 232, 240);
        btnSeed.Cursor = Cursors.Hand;
        btnSeed.FlatAppearance.BorderSize = 0;
        btnSeed.FlatStyle = FlatStyle.Flat;
        btnSeed.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        btnSeed.ForeColor = Color.FromArgb(30, 41, 59);
        btnSeed.Location = new Point(169, 406);
        btnSeed.Name = "btnSeed";
        btnSeed.Size = new Size(142, 32);
        btnSeed.TabIndex = 14;
        btnSeed.Text = "Load Samples";
        btnSeed.UseVisualStyleBackColor = false;
        btnSeed.Click += btnSeed_Click;

        // 
        // grpGrid
        // 
        grpGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grpGrid.Controls.Add(dgvStudents);
        grpGrid.Controls.Add(btnDelete);
        grpGrid.Controls.Add(lblCount);
        grpGrid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpGrid.ForeColor = Color.FromArgb(30, 41, 59);
        grpGrid.Location = new Point(360, 88);
        grpGrid.Name = "grpGrid";
        grpGrid.Size = new Size(630, 520);
        grpGrid.TabIndex = 2;
        grpGrid.TabStop = false;
        grpGrid.Text = " Student Records (Grid View) ";

        // 
        // dgvStudents
        // 
        dgvStudents.AllowUserToAddRows = false;
        dgvStudents.AllowUserToDeleteRows = false;
        dgvStudents.AllowUserToOrderColumns = true;
        dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvStudents.BackgroundColor = Color.White;
        dgvStudents.BorderStyle = BorderStyle.Fixed3D;
        dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = Color.FromArgb(24, 76, 120);
        dgvHeaderStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dgvHeaderStyle.ForeColor = Color.White;
        dgvHeaderStyle.SelectionBackColor = Color.FromArgb(24, 76, 120);
        dgvHeaderStyle.SelectionForeColor = Color.White;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvStudents.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvStudents.ColumnHeadersHeight = 35;
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvStudents.EnableHeadersVisualStyles = false;

        dgvDefaultRowStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvDefaultRowStyle.BackColor = Color.White;
        dgvDefaultRowStyle.Font = new Font("Segoe UI", 9.5F);
        dgvDefaultRowStyle.ForeColor = Color.FromArgb(30, 41, 59);
        dgvDefaultRowStyle.SelectionBackColor = Color.FromArgb(186, 215, 242);
        dgvDefaultRowStyle.SelectionForeColor = Color.Black;
        dgvDefaultRowStyle.WrapMode = DataGridViewTriState.False;
        dgvStudents.DefaultCellStyle = dgvDefaultRowStyle;

        dgvAltRowStyle.BackColor = Color.FromArgb(248, 250, 252);
        dgvStudents.AlternatingRowsDefaultCellStyle = dgvAltRowStyle;

        dgvStudents.GridColor = Color.FromArgb(226, 232, 240);
        dgvStudents.Location = new Point(16, 30);
        dgvStudents.MultiSelect = false;
        dgvStudents.Name = "dgvStudents";
        dgvStudents.ReadOnly = true;
        dgvStudents.RowHeadersVisible = false;
        dgvStudents.RowTemplate.Height = 28;
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStudents.Size = new Size(598, 428);
        dgvStudents.TabIndex = 0;
        dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;

        // 
        // btnDelete
        // 
        btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnDelete.BackColor = Color.FromArgb(197, 34, 31);
        btnDelete.Cursor = Cursors.Hand;
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(444, 470);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(170, 36);
        btnDelete.TabIndex = 1;
        btnDelete.Text = "🗑 Delete Record";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;

        // 
        // lblCount
        // 
        lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblCount.AutoSize = true;
        lblCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
        lblCount.ForeColor = Color.FromArgb(71, 85, 105);
        lblCount.Location = new Point(16, 480);
        lblCount.Name = "lblCount";
        lblCount.Size = new Size(140, 17);
        lblCount.TabIndex = 2;
        lblCount.Text = "Total Students: 0 records";

        // 
        // statusStrip
        // 
        statusStrip.BackColor = Color.FromArgb(241, 245, 249);
        statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
        statusStrip.Location = new Point(0, 629);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1008, 22);
        statusStrip.TabIndex = 3;
        statusStrip.Text = "statusStrip1";

        // 
        // statusLabel
        // 
        statusLabel.Font = new Font("Segoe UI", 9F);
        statusLabel.ForeColor = Color.FromArgb(51, 65, 85);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(185, 17);
        statusLabel.Text = "Ready — enter student information";

        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(1008, 651);
        Controls.Add(statusStrip);
        Controls.Add(grpGrid);
        Controls.Add(grpStudentInfo);
        Controls.Add(pnlHeader);
        MinimumSize = new Size(950, 620);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Student Management System - Assignment 3.3.2";
        Load += Form1_Load;
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpStudentInfo.ResumeLayout(false);
        grpStudentInfo.PerformLayout();
        grpGrid.ResumeLayout(false);
        grpGrid.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
