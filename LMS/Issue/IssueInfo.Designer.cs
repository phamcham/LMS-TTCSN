namespace LMS.Issue
{
	partial class IssueInfo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSearchString = new System.Windows.Forms.TextBox();
			this.dgwReaderList = new System.Windows.Forms.DataGridView();
			this.ReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCardExpiration = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCardNotes = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCardIssueDate = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCardID = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtGender = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtReaderName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnLost = new System.Windows.Forms.Button();
			this.btnLending = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.dgwIssueBook = new System.Windows.Forms.DataGridView();
			this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IssueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtNoBookIssue = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gboIssueInfo = new System.Windows.Forms.GroupBox();
			this.txtLendingStaffName = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtIssueNotes = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtIssueBookDate = new System.Windows.Forms.TextBox();
			this.txtLendingStaffID = new System.Windows.Forms.TextBox();
			this.txtIssueID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dgwHistoryReturn = new System.Windows.Forms.DataGridView();
			this.BookID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ReturnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnReturnDetails = new System.Windows.Forms.Button();
			this.pbxBookCover = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwReaderList)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwIssueBook)).BeginInit();
			this.gboIssueInfo.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwHistoryReturn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBookCover)).BeginInit();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(632, 258);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 17);
			this.label11.TabIndex = 23;
			this.label11.Text = "Tìm kiếm";
			// 
			// txtSearchString
			// 
			this.txtSearchString.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchString.Location = new System.Drawing.Point(698, 255);
			this.txtSearchString.Name = "txtSearchString";
			this.txtSearchString.Size = new System.Drawing.Size(199, 25);
			this.txtSearchString.TabIndex = 1;
			this.txtSearchString.TextChanged += new System.EventHandler(this.TxtSearchString_TextChanged);
			// 
			// dgwReaderList
			// 
			this.dgwReaderList.AllowUserToAddRows = false;
			this.dgwReaderList.AllowUserToDeleteRows = false;
			this.dgwReaderList.AllowUserToResizeColumns = false;
			this.dgwReaderList.AllowUserToResizeRows = false;
			this.dgwReaderList.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwReaderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgwReaderList.ColumnHeadersHeight = 25;
			this.dgwReaderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgwReaderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReaderID,
            this.ReaderName,
            this.Phone,
            this.CardID,
            this.Status});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwReaderList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgwReaderList.Location = new System.Drawing.Point(635, 286);
			this.dgwReaderList.Name = "dgwReaderList";
			this.dgwReaderList.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwReaderList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgwReaderList.RowHeadersVisible = false;
			this.dgwReaderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwReaderList.Size = new System.Drawing.Size(293, 342);
			this.dgwReaderList.TabIndex = 21;
			this.dgwReaderList.TabStop = false;
			this.dgwReaderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwReaderList_CellClick);
			// 
			// ReaderID
			// 
			this.ReaderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ReaderID.DataPropertyName = "ReaderID";
			this.ReaderID.HeaderText = "Mã bạn đọc";
			this.ReaderID.Name = "ReaderID";
			this.ReaderID.ReadOnly = true;
			// 
			// ReaderName
			// 
			this.ReaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ReaderName.DataPropertyName = "ReaderName";
			this.ReaderName.FillWeight = 200F;
			this.ReaderName.HeaderText = "Tên bạn đọc";
			this.ReaderName.Name = "ReaderName";
			this.ReaderName.ReadOnly = true;
			// 
			// Phone
			// 
			this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Phone.DataPropertyName = "Phone";
			this.Phone.HeaderText = "Số điện thoại";
			this.Phone.Name = "Phone";
			this.Phone.ReadOnly = true;
			this.Phone.Visible = false;
			// 
			// CardID
			// 
			this.CardID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CardID.DataPropertyName = "CardID";
			this.CardID.HeaderText = "Mã thẻ đọc";
			this.CardID.Name = "CardID";
			this.CardID.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Trạng thái";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCardExpiration);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtCardNotes);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtCardIssueDate);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtCardID);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(33, 431);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(237, 197);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin thẻ đọc";
			// 
			// txtCardExpiration
			// 
			this.txtCardExpiration.Location = new System.Drawing.Point(91, 91);
			this.txtCardExpiration.Name = "txtCardExpiration";
			this.txtCardExpiration.ReadOnly = true;
			this.txtCardExpiration.Size = new System.Drawing.Size(129, 25);
			this.txtCardExpiration.TabIndex = 13;
			this.txtCardExpiration.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(21, 94);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 17);
			this.label10.TabIndex = 12;
			this.label10.Text = "Đến ngày";
			// 
			// txtCardNotes
			// 
			this.txtCardNotes.Location = new System.Drawing.Point(91, 122);
			this.txtCardNotes.Multiline = true;
			this.txtCardNotes.Name = "txtCardNotes";
			this.txtCardNotes.ReadOnly = true;
			this.txtCardNotes.Size = new System.Drawing.Size(129, 61);
			this.txtCardNotes.TabIndex = 11;
			this.txtCardNotes.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(33, 125);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 17);
			this.label9.TabIndex = 10;
			this.label9.Text = "Ghi chú";
			// 
			// txtCardIssueDate
			// 
			this.txtCardIssueDate.Location = new System.Drawing.Point(91, 60);
			this.txtCardIssueDate.Name = "txtCardIssueDate";
			this.txtCardIssueDate.ReadOnly = true;
			this.txtCardIssueDate.Size = new System.Drawing.Size(129, 25);
			this.txtCardIssueDate.TabIndex = 9;
			this.txtCardIssueDate.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 63);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 17);
			this.label8.TabIndex = 8;
			this.label8.Text = "Ngày cấp";
			// 
			// txtCardID
			// 
			this.txtCardID.Location = new System.Drawing.Point(91, 29);
			this.txtCardID.Name = "txtCardID";
			this.txtCardID.ReadOnly = true;
			this.txtCardID.Size = new System.Drawing.Size(129, 25);
			this.txtCardID.TabIndex = 7;
			this.txtCardID.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Mã thẻ đọc";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.txtPhone);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtGender);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.separatorControl1);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.txtReaderName);
			this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(33, 33);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(237, 392);
			this.panel1.TabIndex = 19;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(111, 351);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.ReadOnly = true;
			this.txtPhone.Size = new System.Drawing.Size(106, 25);
			this.txtPhone.TabIndex = 7;
			this.txtPhone.TabStop = false;
			this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 354);
			this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Số điện thoại";
			// 
			// txtGender
			// 
			this.txtGender.Location = new System.Drawing.Point(153, 320);
			this.txtGender.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.txtGender.Name = "txtGender";
			this.txtGender.ReadOnly = true;
			this.txtGender.Size = new System.Drawing.Size(64, 25);
			this.txtGender.TabIndex = 5;
			this.txtGender.TabStop = false;
			this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 323);
			this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Giới tính";
			// 
			// separatorControl1
			// 
			this.separatorControl1.Location = new System.Drawing.Point(3, 300);
			this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
			this.separatorControl1.Name = "separatorControl1";
			this.separatorControl1.Size = new System.Drawing.Size(231, 23);
			this.separatorControl1.TabIndex = 3;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox3.Controls.Add(this.pbxBookCover);
			this.groupBox3.Location = new System.Drawing.Point(42, 21);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(153, 211);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			// 
			// txtReaderName
			// 
			this.txtReaderName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReaderName.Location = new System.Drawing.Point(3, 264);
			this.txtReaderName.Name = "txtReaderName";
			this.txtReaderName.ReadOnly = true;
			this.txtReaderName.Size = new System.Drawing.Size(231, 33);
			this.txtReaderName.TabIndex = 2;
			this.txtReaderName.TabStop = false;
			this.txtReaderName.Text = "Chọn bạn đọc ...";
			this.txtReaderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnLost);
			this.groupBox2.Controls.Add(this.btnLending);
			this.groupBox2.Controls.Add(this.btnReturn);
			this.groupBox2.Controls.Add(this.dgwIssueBook);
			this.groupBox2.Controls.Add(this.txtNoBookIssue);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(276, 34);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(350, 339);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin sách mượn";
			// 
			// btnLost
			// 
			this.btnLost.Enabled = false;
			this.btnLost.Location = new System.Drawing.Point(236, 299);
			this.btnLost.Name = "btnLost";
			this.btnLost.Size = new System.Drawing.Size(108, 35);
			this.btnLost.TabIndex = 4;
			this.btnLost.Text = "Mất sách";
			this.btnLost.UseVisualStyleBackColor = true;
			this.btnLost.Click += new System.EventHandler(this.BtnLost_Click);
			// 
			// btnLending
			// 
			this.btnLending.Enabled = false;
			this.btnLending.Location = new System.Drawing.Point(6, 299);
			this.btnLending.Name = "btnLending";
			this.btnLending.Size = new System.Drawing.Size(108, 35);
			this.btnLending.TabIndex = 2;
			this.btnLending.Text = "Mượn sách";
			this.btnLending.UseVisualStyleBackColor = true;
			this.btnLending.Click += new System.EventHandler(this.BtnLending_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Enabled = false;
			this.btnReturn.Location = new System.Drawing.Point(120, 299);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(108, 35);
			this.btnReturn.TabIndex = 3;
			this.btnReturn.Text = "Trả sách";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
			// 
			// dgwIssueBook
			// 
			this.dgwIssueBook.AllowUserToAddRows = false;
			this.dgwIssueBook.AllowUserToDeleteRows = false;
			this.dgwIssueBook.AllowUserToResizeColumns = false;
			this.dgwIssueBook.AllowUserToResizeRows = false;
			this.dgwIssueBook.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwIssueBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgwIssueBook.ColumnHeadersHeight = 25;
			this.dgwIssueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgwIssueBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.IssueID});
			this.dgwIssueBook.Location = new System.Drawing.Point(6, 56);
			this.dgwIssueBook.Name = "dgwIssueBook";
			this.dgwIssueBook.ReadOnly = true;
			this.dgwIssueBook.RowHeadersVisible = false;
			this.dgwIssueBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgwIssueBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwIssueBook.Size = new System.Drawing.Size(338, 237);
			this.dgwIssueBook.TabIndex = 27;
			this.dgwIssueBook.TabStop = false;
			this.dgwIssueBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwIssueBook_CellClick);
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
			// IssueID
			// 
			this.IssueID.DataPropertyName = "IssueID";
			this.IssueID.HeaderText = "Mã phiếu mượn";
			this.IssueID.Name = "IssueID";
			this.IssueID.ReadOnly = true;
			this.IssueID.Visible = false;
			// 
			// txtNoBookIssue
			// 
			this.txtNoBookIssue.Location = new System.Drawing.Point(184, 25);
			this.txtNoBookIssue.Name = "txtNoBookIssue";
			this.txtNoBookIssue.ReadOnly = true;
			this.txtNoBookIssue.Size = new System.Drawing.Size(51, 25);
			this.txtNoBookIssue.TabIndex = 26;
			this.txtNoBookIssue.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 17);
			this.label1.TabIndex = 25;
			this.label1.Text = "Số sách đang mượn:";
			// 
			// gboIssueInfo
			// 
			this.gboIssueInfo.Controls.Add(this.txtLendingStaffName);
			this.gboIssueInfo.Controls.Add(this.label13);
			this.gboIssueInfo.Controls.Add(this.txtIssueNotes);
			this.gboIssueInfo.Controls.Add(this.label12);
			this.gboIssueInfo.Controls.Add(this.txtIssueBookDate);
			this.gboIssueInfo.Controls.Add(this.txtLendingStaffID);
			this.gboIssueInfo.Controls.Add(this.txtIssueID);
			this.gboIssueInfo.Controls.Add(this.label6);
			this.gboIssueInfo.Controls.Add(this.label5);
			this.gboIssueInfo.Controls.Add(this.label4);
			this.gboIssueInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gboIssueInfo.Location = new System.Drawing.Point(635, 34);
			this.gboIssueInfo.Name = "gboIssueInfo";
			this.gboIssueInfo.Size = new System.Drawing.Size(293, 215);
			this.gboIssueInfo.TabIndex = 26;
			this.gboIssueInfo.TabStop = false;
			this.gboIssueInfo.Text = "Thông tin phiếu mượn";
			// 
			// txtLendingStaffName
			// 
			this.txtLendingStaffName.Location = new System.Drawing.Point(120, 90);
			this.txtLendingStaffName.Name = "txtLendingStaffName";
			this.txtLendingStaffName.ReadOnly = true;
			this.txtLendingStaffName.Size = new System.Drawing.Size(153, 25);
			this.txtLendingStaffName.TabIndex = 9;
			this.txtLendingStaffName.TabStop = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(28, 93);
			this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 14);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(87, 17);
			this.label13.TabIndex = 8;
			this.label13.Text = "Tên nhân viên";
			// 
			// txtIssueNotes
			// 
			this.txtIssueNotes.Location = new System.Drawing.Point(120, 152);
			this.txtIssueNotes.Multiline = true;
			this.txtIssueNotes.Name = "txtIssueNotes";
			this.txtIssueNotes.ReadOnly = true;
			this.txtIssueNotes.Size = new System.Drawing.Size(153, 56);
			this.txtIssueNotes.TabIndex = 7;
			this.txtIssueNotes.TabStop = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(63, 155);
			this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 14);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(51, 17);
			this.label12.TabIndex = 6;
			this.label12.Text = "Ghi chú";
			// 
			// txtIssueBookDate
			// 
			this.txtIssueBookDate.Location = new System.Drawing.Point(120, 121);
			this.txtIssueBookDate.Name = "txtIssueBookDate";
			this.txtIssueBookDate.ReadOnly = true;
			this.txtIssueBookDate.Size = new System.Drawing.Size(153, 25);
			this.txtIssueBookDate.TabIndex = 5;
			this.txtIssueBookDate.TabStop = false;
			// 
			// txtLendingStaffID
			// 
			this.txtLendingStaffID.Location = new System.Drawing.Point(120, 59);
			this.txtLendingStaffID.Name = "txtLendingStaffID";
			this.txtLendingStaffID.ReadOnly = true;
			this.txtLendingStaffID.Size = new System.Drawing.Size(76, 25);
			this.txtLendingStaffID.TabIndex = 4;
			this.txtLendingStaffID.TabStop = false;
			// 
			// txtIssueID
			// 
			this.txtIssueID.Location = new System.Drawing.Point(120, 28);
			this.txtIssueID.Name = "txtIssueID";
			this.txtIssueID.ReadOnly = true;
			this.txtIssueID.Size = new System.Drawing.Size(153, 25);
			this.txtIssueID.TabIndex = 3;
			this.txtIssueID.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(37, 124);
			this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 17);
			this.label6.TabIndex = 2;
			this.label6.Text = "Ngày mượn";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 62);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "Mã nhân viên";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 31);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mã phiếu mượn";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnReturnDetails);
			this.groupBox4.Controls.Add(this.dgwHistoryReturn);
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(276, 379);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(350, 249);
			this.groupBox4.TabIndex = 27;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Lịch sử trả sách";
			// 
			// dgwHistoryReturn
			// 
			this.dgwHistoryReturn.AllowUserToAddRows = false;
			this.dgwHistoryReturn.AllowUserToDeleteRows = false;
			this.dgwHistoryReturn.AllowUserToResizeColumns = false;
			this.dgwHistoryReturn.AllowUserToResizeRows = false;
			this.dgwHistoryReturn.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwHistoryReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgwHistoryReturn.ColumnHeadersHeight = 25;
			this.dgwHistoryReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgwHistoryReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID2,
            this.BookName2,
            this.ReturnDate,
            this.ReturnID});
			this.dgwHistoryReturn.Location = new System.Drawing.Point(6, 24);
			this.dgwHistoryReturn.Name = "dgwHistoryReturn";
			this.dgwHistoryReturn.ReadOnly = true;
			this.dgwHistoryReturn.RowHeadersVisible = false;
			this.dgwHistoryReturn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgwHistoryReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwHistoryReturn.Size = new System.Drawing.Size(338, 178);
			this.dgwHistoryReturn.TabIndex = 31;
			this.dgwHistoryReturn.TabStop = false;
			this.dgwHistoryReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwHistoryReturn_CellClick);
			// 
			// BookID2
			// 
			this.BookID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.BookID2.DataPropertyName = "BookID";
			this.BookID2.FillWeight = 110F;
			this.BookID2.HeaderText = "Mã sách";
			this.BookID2.Name = "BookID2";
			this.BookID2.ReadOnly = true;
			// 
			// BookName2
			// 
			this.BookName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.BookName2.DataPropertyName = "BookName";
			this.BookName2.FillWeight = 180F;
			this.BookName2.HeaderText = "Tên sách";
			this.BookName2.Name = "BookName2";
			this.BookName2.ReadOnly = true;
			// 
			// ReturnDate
			// 
			this.ReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ReturnDate.DataPropertyName = "ReturnDate";
			this.ReturnDate.FillWeight = 120F;
			this.ReturnDate.HeaderText = "Ngày trả";
			this.ReturnDate.Name = "ReturnDate";
			this.ReturnDate.ReadOnly = true;
			// 
			// ReturnID
			// 
			this.ReturnID.DataPropertyName = "ReturnID";
			this.ReturnID.HeaderText = "Mã phiếu mượn";
			this.ReturnID.Name = "ReturnID";
			this.ReturnID.ReadOnly = true;
			this.ReturnID.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LMS.Properties.Resources.search_icon;
			this.pictureBox1.Location = new System.Drawing.Point(903, 255);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 28;
			this.pictureBox1.TabStop = false;
			// 
			// btnReturnDetails
			// 
			this.btnReturnDetails.Enabled = false;
			this.btnReturnDetails.Image = global::LMS.Properties.Resources.details_icon;
			this.btnReturnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReturnDetails.Location = new System.Drawing.Point(205, 208);
			this.btnReturnDetails.Name = "btnReturnDetails";
			this.btnReturnDetails.Size = new System.Drawing.Size(139, 35);
			this.btnReturnDetails.TabIndex = 5;
			this.btnReturnDetails.Text = "Chi tiết";
			this.btnReturnDetails.UseVisualStyleBackColor = true;
			this.btnReturnDetails.Click += new System.EventHandler(this.BtnReturnDetails_Click);
			// 
			// pbxBookCover
			// 
			this.pbxBookCover.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxBookCover.Location = new System.Drawing.Point(3, 21);
			this.pbxBookCover.Name = "pbxBookCover";
			this.pbxBookCover.Size = new System.Drawing.Size(147, 187);
			this.pbxBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxBookCover.TabIndex = 2;
			this.pbxBookCover.TabStop = false;
			// 
			// IssueInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 661);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.gboIssueInfo);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtSearchString);
			this.Controls.Add(this.dgwReaderList);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "IssueInfo";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "IssueInterface";
			this.Load += new System.EventHandler(this.IssueInterface_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwReaderList)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwIssueBook)).EndInit();
			this.gboIssueInfo.ResumeLayout(false);
			this.gboIssueInfo.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwHistoryReturn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBookCover)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSearchString;
		private System.Windows.Forms.DataGridView dgwReaderList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCardExpiration;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtCardNotes;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCardIssueDate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtCardID;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtGender;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.SeparatorControl separatorControl1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtReaderName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtNoBookIssue;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLending;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.DataGridView dgwIssueBook;
		private System.Windows.Forms.GroupBox gboIssueInfo;
		private System.Windows.Forms.TextBox txtIssueNotes;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtIssueBookDate;
		private System.Windows.Forms.TextBox txtLendingStaffID;
		private System.Windows.Forms.TextBox txtIssueID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
		private System.Windows.Forms.DataGridViewTextBoxColumn IssueID;
		private System.Windows.Forms.TextBox txtLendingStaffName;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dgwHistoryReturn;
		private System.Windows.Forms.Button btnLost;
		private System.Windows.Forms.Button btnReturnDetails;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookID2;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookName2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReturnID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReaderID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn CardID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.PictureBox pbxBookCover;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}