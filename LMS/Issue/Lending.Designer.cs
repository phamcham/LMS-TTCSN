namespace LMS.Issue
{
	partial class Lending
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkSetIssueDateIsToday = new System.Windows.Forms.CheckBox();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPublisherName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAuthorName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBookID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtStaffID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCardID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIssueID = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtSearchAuthorName = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtSearchBookName = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.dgwBookData = new System.Windows.Forms.DataGridView();
			this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label13 = new System.Windows.Forms.Label();
			this.txtSearchString = new System.Windows.Forms.TextBox();
			this.txtSearchBookID = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtSearchISBN = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtSearchPublisherName = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbxBookCover = new System.Windows.Forms.PictureBox();
			this.btnLend = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnFindBook = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwBookData)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBookCover)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkSetIssueDateIsToday);
			this.groupBox1.Controls.Add(this.txtStaffName);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.btnLend);
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.txtNotes);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.dtpIssueDate);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.txtStaffID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtCardID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtIssueID);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
			this.groupBox1.Size = new System.Drawing.Size(375, 628);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mượn sách";
			// 
			// chkSetIssueDateIsToday
			// 
			this.chkSetIssueDateIsToday.AutoSize = true;
			this.chkSetIssueDateIsToday.Location = new System.Drawing.Point(202, 454);
			this.chkSetIssueDateIsToday.Name = "chkSetIssueDateIsToday";
			this.chkSetIssueDateIsToday.Size = new System.Drawing.Size(79, 21);
			this.chkSetIssueDateIsToday.TabIndex = 43;
			this.chkSetIssueDateIsToday.Text = "Hôm nay";
			this.chkSetIssueDateIsToday.UseVisualStyleBackColor = true;
			this.chkSetIssueDateIsToday.CheckedChanged += new System.EventHandler(this.ChkSetIssueDateIsToday_CheckedChanged);
			// 
			// txtStaffName
			// 
			this.txtStaffName.Location = new System.Drawing.Point(202, 113);
			this.txtStaffName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.ReadOnly = true;
			this.txtStaffName.Size = new System.Drawing.Size(150, 25);
			this.txtStaffName.TabIndex = 42;
			this.txtStaffName.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(202, 93);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(87, 17);
			this.label11.TabIndex = 41;
			this.label11.Text = "Tên nhân viên";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(23, 506);
			this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(326, 56);
			this.txtNotes.TabIndex = 36;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(23, 486);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(51, 17);
			this.label10.TabIndex = 35;
			this.label10.Text = "Ghi chú";
			// 
			// dtpIssueDate
			// 
			this.dtpIssueDate.CustomFormat = "dd / MM / yyyy";
			this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpIssueDate.Location = new System.Drawing.Point(23, 449);
			this.dtpIssueDate.Name = "dtpIssueDate";
			this.dtpIssueDate.Size = new System.Drawing.Size(149, 25);
			this.dtpIssueDate.TabIndex = 34;
			this.dtpIssueDate.ValueChanged += new System.EventHandler(this.DtpIssueDate_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(23, 429);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 17);
			this.label9.TabIndex = 28;
			this.label9.Text = "Ngày mượn";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtStatus);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.btnFindBook);
			this.groupBox2.Controls.Add(this.txtISBN);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtPublisherName);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtAuthorName);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtBookName);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtBookID);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(23, 151);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
			this.groupBox2.Size = new System.Drawing.Size(329, 266);
			this.groupBox2.TabIndex = 27;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin sách mượn";
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(86, 225);
			this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size(162, 25);
			this.txtStatus.TabIndex = 41;
			this.txtStatus.TabStop = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(14, 228);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(66, 17);
			this.label12.TabIndex = 40;
			this.label12.Text = "Trạng thái";
			// 
			// txtISBN
			// 
			this.txtISBN.Location = new System.Drawing.Point(86, 187);
			this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.ReadOnly = true;
			this.txtISBN.Size = new System.Drawing.Size(220, 25);
			this.txtISBN.TabIndex = 37;
			this.txtISBN.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(45, 190);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 17);
			this.label8.TabIndex = 36;
			this.label8.Text = "ISBN";
			// 
			// txtPublisherName
			// 
			this.txtPublisherName.Location = new System.Drawing.Point(86, 149);
			this.txtPublisherName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtPublisherName.Name = "txtPublisherName";
			this.txtPublisherName.ReadOnly = true;
			this.txtPublisherName.Size = new System.Drawing.Size(220, 25);
			this.txtPublisherName.TabIndex = 35;
			this.txtPublisherName.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(47, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 17);
			this.label6.TabIndex = 34;
			this.label6.Text = "NXB";
			// 
			// txtAuthorName
			// 
			this.txtAuthorName.Location = new System.Drawing.Point(86, 111);
			this.txtAuthorName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtAuthorName.Name = "txtAuthorName";
			this.txtAuthorName.ReadOnly = true;
			this.txtAuthorName.Size = new System.Drawing.Size(220, 25);
			this.txtAuthorName.TabIndex = 33;
			this.txtAuthorName.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 17);
			this.label5.TabIndex = 32;
			this.label5.Text = "Tác giả";
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(86, 73);
			this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.ReadOnly = true;
			this.txtBookName.Size = new System.Drawing.Size(220, 25);
			this.txtBookName.TabIndex = 31;
			this.txtBookName.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 17);
			this.label4.TabIndex = 30;
			this.label4.Text = "Tên sách";
			// 
			// txtBookID
			// 
			this.txtBookID.Location = new System.Drawing.Point(86, 35);
			this.txtBookID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtBookID.Name = "txtBookID";
			this.txtBookID.Size = new System.Drawing.Size(119, 25);
			this.txtBookID.TabIndex = 1;
			this.txtBookID.TextChanged += new System.EventHandler(this.TxtBookID_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 17);
			this.label3.TabIndex = 28;
			this.label3.Text = "Mã sách";
			// 
			// txtStaffID
			// 
			this.txtStaffID.Location = new System.Drawing.Point(23, 113);
			this.txtStaffID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtStaffID.Name = "txtStaffID";
			this.txtStaffID.ReadOnly = true;
			this.txtStaffID.Size = new System.Drawing.Size(149, 25);
			this.txtStaffID.TabIndex = 26;
			this.txtStaffID.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 17);
			this.label2.TabIndex = 25;
			this.label2.Text = "Mã nhân viên";
			// 
			// txtCardID
			// 
			this.txtCardID.Location = new System.Drawing.Point(203, 58);
			this.txtCardID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtCardID.Name = "txtCardID";
			this.txtCardID.ReadOnly = true;
			this.txtCardID.Size = new System.Drawing.Size(149, 25);
			this.txtCardID.TabIndex = 24;
			this.txtCardID.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(203, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 23;
			this.label1.Text = "Mã thẻ";
			// 
			// txtIssueID
			// 
			this.txtIssueID.Location = new System.Drawing.Point(23, 58);
			this.txtIssueID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtIssueID.Name = "txtIssueID";
			this.txtIssueID.ReadOnly = true;
			this.txtIssueID.Size = new System.Drawing.Size(149, 25);
			this.txtIssueID.TabIndex = 22;
			this.txtIssueID.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 17);
			this.label7.TabIndex = 21;
			this.label7.Text = "Mã phiếu mượn";
			// 
			// txtSearchAuthorName
			// 
			this.txtSearchAuthorName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchAuthorName.Location = new System.Drawing.Point(86, 99);
			this.txtSearchAuthorName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtSearchAuthorName.Name = "txtSearchAuthorName";
			this.txtSearchAuthorName.ReadOnly = true;
			this.txtSearchAuthorName.Size = new System.Drawing.Size(232, 25);
			this.txtSearchAuthorName.TabIndex = 45;
			this.txtSearchAuthorName.TabStop = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(31, 102);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(49, 17);
			this.label14.TabIndex = 44;
			this.label14.Text = "Tác giả";
			// 
			// txtSearchBookName
			// 
			this.txtSearchBookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchBookName.Location = new System.Drawing.Point(86, 61);
			this.txtSearchBookName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtSearchBookName.Name = "txtSearchBookName";
			this.txtSearchBookName.ReadOnly = true;
			this.txtSearchBookName.Size = new System.Drawing.Size(232, 25);
			this.txtSearchBookName.TabIndex = 43;
			this.txtSearchBookName.TabStop = false;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(23, 64);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(58, 17);
			this.label15.TabIndex = 42;
			this.label15.Text = "Tên sách";
			// 
			// dgwBookData
			// 
			this.dgwBookData.AllowUserToAddRows = false;
			this.dgwBookData.AllowUserToDeleteRows = false;
			this.dgwBookData.AllowUserToResizeColumns = false;
			this.dgwBookData.AllowUserToResizeRows = false;
			this.dgwBookData.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwBookData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgwBookData.ColumnHeadersHeight = 25;
			this.dgwBookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgwBookData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.AuthorName,
            this.PublisherName,
            this.CategoryName,
            this.Availability,
            this.Status});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwBookData.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgwBookData.Location = new System.Drawing.Point(410, 350);
			this.dgwBookData.Name = "dgwBookData";
			this.dgwBookData.ReadOnly = true;
			this.dgwBookData.RowHeadersVisible = false;
			this.dgwBookData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgwBookData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwBookData.Size = new System.Drawing.Size(521, 286);
			this.dgwBookData.TabIndex = 48;
			this.dgwBookData.TabStop = false;
			this.dgwBookData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBookData_CellClick);
			// 
			// BookID
			// 
			this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.BookID.DataPropertyName = "BookID";
			this.BookID.FillWeight = 110F;
			this.BookID.HeaderText = "Mã sách";
			this.BookID.Name = "BookID";
			this.BookID.ReadOnly = true;
			// 
			// BookName
			// 
			this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.BookName.DataPropertyName = "BookName";
			this.BookName.FillWeight = 300F;
			this.BookName.HeaderText = "Tên sách";
			this.BookName.Name = "BookName";
			this.BookName.ReadOnly = true;
			// 
			// AuthorName
			// 
			this.AuthorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AuthorName.DataPropertyName = "AuthorName";
			this.AuthorName.FillWeight = 200F;
			this.AuthorName.HeaderText = "Tác giả";
			this.AuthorName.Name = "AuthorName";
			this.AuthorName.ReadOnly = true;
			// 
			// PublisherName
			// 
			this.PublisherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PublisherName.DataPropertyName = "PublisherName";
			this.PublisherName.FillWeight = 200F;
			this.PublisherName.HeaderText = "Nhà xuất bản";
			this.PublisherName.Name = "PublisherName";
			this.PublisherName.ReadOnly = true;
			// 
			// CategoryName
			// 
			this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CategoryName.DataPropertyName = "CategoryName";
			this.CategoryName.FillWeight = 150F;
			this.CategoryName.HeaderText = "Thể loại";
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.ReadOnly = true;
			this.CategoryName.Visible = false;
			// 
			// Availability
			// 
			this.Availability.DataPropertyName = "Availability";
			this.Availability.HeaderText = "Hiệu lực";
			this.Availability.Name = "Availability";
			this.Availability.ReadOnly = true;
			this.Availability.Visible = false;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Trạng thái";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(648, 322);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 17);
			this.label13.TabIndex = 50;
			this.label13.Text = "Tìm kiếm";
			// 
			// txtSearchString
			// 
			this.txtSearchString.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchString.Location = new System.Drawing.Point(714, 319);
			this.txtSearchString.Name = "txtSearchString";
			this.txtSearchString.Size = new System.Drawing.Size(186, 25);
			this.txtSearchString.TabIndex = 49;
			this.txtSearchString.TabStop = false;
			// 
			// txtSearchBookID
			// 
			this.txtSearchBookID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchBookID.Location = new System.Drawing.Point(86, 23);
			this.txtSearchBookID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtSearchBookID.Name = "txtSearchBookID";
			this.txtSearchBookID.ReadOnly = true;
			this.txtSearchBookID.Size = new System.Drawing.Size(129, 25);
			this.txtSearchBookID.TabIndex = 52;
			this.txtSearchBookID.TabStop = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(23, 26);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(57, 17);
			this.label16.TabIndex = 51;
			this.label16.Text = "Mã sách";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pbxBookCover);
			this.groupBox3.Location = new System.Drawing.Point(410, 15);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(173, 240);
			this.groupBox3.TabIndex = 53;
			this.groupBox3.TabStop = false;
			// 
			// txtSearchISBN
			// 
			this.txtSearchISBN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchISBN.Location = new System.Drawing.Point(86, 175);
			this.txtSearchISBN.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtSearchISBN.Name = "txtSearchISBN";
			this.txtSearchISBN.ReadOnly = true;
			this.txtSearchISBN.Size = new System.Drawing.Size(232, 25);
			this.txtSearchISBN.TabIndex = 45;
			this.txtSearchISBN.TabStop = false;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(45, 178);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(35, 17);
			this.label17.TabIndex = 44;
			this.label17.Text = "ISBN";
			// 
			// txtSearchPublisherName
			// 
			this.txtSearchPublisherName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchPublisherName.Location = new System.Drawing.Point(86, 137);
			this.txtSearchPublisherName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtSearchPublisherName.Name = "txtSearchPublisherName";
			this.txtSearchPublisherName.ReadOnly = true;
			this.txtSearchPublisherName.Size = new System.Drawing.Size(232, 25);
			this.txtSearchPublisherName.TabIndex = 43;
			this.txtSearchPublisherName.TabStop = false;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(47, 140);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(33, 17);
			this.label18.TabIndex = 42;
			this.label18.Text = "NXB";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtSearchISBN);
			this.groupBox4.Controls.Add(this.txtSearchBookID);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.txtSearchPublisherName);
			this.groupBox4.Controls.Add(this.txtSearchBookName);
			this.groupBox4.Controls.Add(this.txtSearchAuthorName);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Location = new System.Drawing.Point(598, 42);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 3, 15, 3);
			this.groupBox4.Size = new System.Drawing.Size(333, 213);
			this.groupBox4.TabIndex = 54;
			this.groupBox4.TabStop = false;
			// 
			// btnSelect
			// 
			this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelect.Location = new System.Drawing.Point(410, 258);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(173, 30);
			this.btnSelect.TabIndex = 42;
			this.btnSelect.TabStop = false;
			this.btnSelect.Text = "Chọn";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinimize.Location = new System.Drawing.Point(410, 294);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(173, 30);
			this.btnMinimize.TabIndex = 55;
			this.btnMinimize.TabStop = false;
			this.btnMinimize.Text = "Thu nhỏ";
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LMS.Properties.Resources.search_icon;
			this.pictureBox1.Location = new System.Drawing.Point(906, 319);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 56;
			this.pictureBox1.TabStop = false;
			// 
			// pbxBookCover
			// 
			this.pbxBookCover.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxBookCover.Location = new System.Drawing.Point(3, 16);
			this.pbxBookCover.Name = "pbxBookCover";
			this.pbxBookCover.Size = new System.Drawing.Size(167, 221);
			this.pbxBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxBookCover.TabIndex = 2;
			this.pbxBookCover.TabStop = false;
			// 
			// btnLend
			// 
			this.btnLend.Enabled = false;
			this.btnLend.Image = global::LMS.Properties.Resources.lendbook_icon;
			this.btnLend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLend.Location = new System.Drawing.Point(68, 575);
			this.btnLend.Name = "btnLend";
			this.btnLend.Size = new System.Drawing.Size(139, 35);
			this.btnLend.TabIndex = 3;
			this.btnLend.Text = "      Mượn sách";
			this.btnLend.UseVisualStyleBackColor = true;
			this.btnLend.Click += new System.EventHandler(this.BtnLend_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Image = global::LMS.Properties.Resources.cancel_icon;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(213, 575);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(139, 35);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Huỷ";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnFindBook
			// 
			this.btnFindBook.Image = global::LMS.Properties.Resources.search_icon;
			this.btnFindBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFindBook.Location = new System.Drawing.Point(211, 29);
			this.btnFindBook.Name = "btnFindBook";
			this.btnFindBook.Size = new System.Drawing.Size(95, 35);
			this.btnFindBook.TabIndex = 2;
			this.btnFindBook.Text = "    Tìm";
			this.btnFindBook.UseVisualStyleBackColor = true;
			this.btnFindBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
			// 
			// Lending
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 651);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtSearchString);
			this.Controls.Add(this.dgwBookData);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox4);
			this.MaximumSize = new System.Drawing.Size(959, 690);
			this.MinimumSize = new System.Drawing.Size(413, 690);
			this.Name = "Lending";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LendingBook";
			this.Load += new System.EventHandler(this.LendingBook_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwBookData)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBookCover)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtStaffID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCardID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIssueID;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtISBN;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPublisherName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAuthorName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBookID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpIssueDate;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnLend;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnFindBook;
		private System.Windows.Forms.TextBox txtStaffName;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox chkSetIssueDateIsToday;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtSearchAuthorName;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtSearchBookName;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DataGridView dgwBookData;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtSearchString;
		private System.Windows.Forms.TextBox txtSearchBookID;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
		private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtSearchISBN;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtSearchPublisherName;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.PictureBox pbxBookCover;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}