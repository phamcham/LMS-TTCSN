namespace LMS.Book
{
	partial class BookInfo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblEnable = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEditionNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPublishedYear = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPublisherName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAuthorName = new System.Windows.Forms.TextBox();
			this.lblAuthorName = new System.Windows.Forms.Label();
			this.txtBookID = new System.Windows.Forms.TextBox();
			this.dgwBookInfo = new System.Windows.Forms.DataGridView();
			this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtSearchString = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.chkShowDisabledBook = new System.Windows.Forms.CheckBox();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.chkShowLostBook = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnUpdateBook = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.pbxBookCover = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwBookInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBookCover)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblEnable);
			this.groupBox1.Controls.Add(this.pbxBookCover);
			this.groupBox1.Location = new System.Drawing.Point(30, 30);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(173, 240);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// lblEnable
			// 
			this.lblEnable.AutoSize = true;
			this.lblEnable.BackColor = System.Drawing.Color.Tomato;
			this.lblEnable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnable.Location = new System.Drawing.Point(23, 199);
			this.lblEnable.Name = "lblEnable";
			this.lblEnable.Size = new System.Drawing.Size(124, 30);
			this.lblEnable.TabIndex = 0;
			this.lblEnable.Text = "Vô hiệu hoá";
			this.lblEnable.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtISBN);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtNotes);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtStatus);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtPrice);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtEditionNumber);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtPublishedYear);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtCategory);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtPublisherName);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtAuthorName);
			this.groupBox2.Controls.Add(this.lblAuthorName);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(230, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
			this.groupBox2.Size = new System.Drawing.Size(720, 230);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin sách";
			// 
			// txtISBN
			// 
			this.txtISBN.Location = new System.Drawing.Point(461, 109);
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.ReadOnly = true;
			this.txtISBN.Size = new System.Drawing.Size(220, 25);
			this.txtISBN.TabIndex = 15;
			this.txtISBN.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(420, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 17);
			this.label9.TabIndex = 14;
			this.label9.Text = "ISBN";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(83, 146);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ReadOnly = true;
			this.txtNotes.Size = new System.Drawing.Size(598, 61);
			this.txtNotes.TabIndex = 11;
			this.txtNotes.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(25, 149);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "Tóm tắt";
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(83, 109);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size(93, 25);
			this.txtStatus.TabIndex = 13;
			this.txtStatus.TabStop = false;
			this.txtStatus.Text = "                                                                                 " +
    "                                                                                " +
    "            ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Trạng thái";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(240, 109);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.Size = new System.Drawing.Size(93, 25);
			this.txtPrice.TabIndex = 11;
			this.txtPrice.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(207, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Giá";
			// 
			// txtEditionNumber
			// 
			this.txtEditionNumber.Location = new System.Drawing.Point(625, 72);
			this.txtEditionNumber.Name = "txtEditionNumber";
			this.txtEditionNumber.ReadOnly = true;
			this.txtEditionNumber.Size = new System.Drawing.Size(56, 25);
			this.txtEditionNumber.TabIndex = 9;
			this.txtEditionNumber.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(569, 75);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Tái bản";
			// 
			// txtPublishedYear
			// 
			this.txtPublishedYear.Location = new System.Drawing.Point(461, 72);
			this.txtPublishedYear.Name = "txtPublishedYear";
			this.txtPublishedYear.ReadOnly = true;
			this.txtPublishedYear.Size = new System.Drawing.Size(93, 25);
			this.txtPublishedYear.TabIndex = 7;
			this.txtPublishedYear.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(365, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Năm xuất bản";
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(83, 72);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.ReadOnly = true;
			this.txtCategory.Size = new System.Drawing.Size(250, 25);
			this.txtCategory.TabIndex = 5;
			this.txtCategory.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 75);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Thể loại";
			// 
			// txtPublisherName
			// 
			this.txtPublisherName.Location = new System.Drawing.Point(461, 35);
			this.txtPublisherName.Name = "txtPublisherName";
			this.txtPublisherName.ReadOnly = true;
			this.txtPublisherName.Size = new System.Drawing.Size(220, 25);
			this.txtPublisherName.TabIndex = 3;
			this.txtPublisherName.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(369, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nhà xuất bản";
			// 
			// txtAuthorName
			// 
			this.txtAuthorName.Location = new System.Drawing.Point(83, 35);
			this.txtAuthorName.Name = "txtAuthorName";
			this.txtAuthorName.ReadOnly = true;
			this.txtAuthorName.Size = new System.Drawing.Size(250, 25);
			this.txtAuthorName.TabIndex = 1;
			this.txtAuthorName.TabStop = false;
			// 
			// lblAuthorName
			// 
			this.lblAuthorName.AutoSize = true;
			this.lblAuthorName.Location = new System.Drawing.Point(28, 38);
			this.lblAuthorName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
			this.lblAuthorName.Name = "lblAuthorName";
			this.lblAuthorName.Size = new System.Drawing.Size(49, 17);
			this.lblAuthorName.TabIndex = 0;
			this.lblAuthorName.Text = "Tác giả";
			// 
			// txtBookID
			// 
			this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBookID.Location = new System.Drawing.Point(90, 285);
			this.txtBookID.Name = "txtBookID";
			this.txtBookID.ReadOnly = true;
			this.txtBookID.Size = new System.Drawing.Size(113, 25);
			this.txtBookID.TabIndex = 3;
			this.txtBookID.TabStop = false;
			// 
			// dgwBookInfo
			// 
			this.dgwBookInfo.AllowUserToAddRows = false;
			this.dgwBookInfo.AllowUserToDeleteRows = false;
			this.dgwBookInfo.AllowUserToResizeColumns = false;
			this.dgwBookInfo.AllowUserToResizeRows = false;
			this.dgwBookInfo.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwBookInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgwBookInfo.ColumnHeadersHeight = 25;
			this.dgwBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgwBookInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.AuthorName,
            this.PublisherName,
            this.CategoryName,
            this.Availability,
            this.Status});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwBookInfo.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgwBookInfo.Location = new System.Drawing.Point(30, 355);
			this.dgwBookInfo.Name = "dgwBookInfo";
			this.dgwBookInfo.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwBookInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgwBookInfo.RowHeadersVisible = false;
			this.dgwBookInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgwBookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwBookInfo.Size = new System.Drawing.Size(920, 225);
			this.dgwBookInfo.TabIndex = 4;
			this.dgwBookInfo.TabStop = false;
			this.dgwBookInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBookInfo_CellClick);
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
			// 
			// Availability
			// 
			this.Availability.DataPropertyName = "Availability";
			this.Availability.HeaderText = "Hiệu lực";
			this.Availability.Name = "Availability";
			this.Availability.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Trạng thái";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			// 
			// txtSearchString
			// 
			this.txtSearchString.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchString.Location = new System.Drawing.Point(671, 324);
			this.txtSearchString.Name = "txtSearchString";
			this.txtSearchString.Size = new System.Drawing.Size(248, 25);
			this.txtSearchString.TabIndex = 1;
			this.txtSearchString.TextChanged += new System.EventHandler(this.TxtSearchString_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(605, 327);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Tìm kiếm";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(27, 288);
			this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 17);
			this.label10.TabIndex = 16;
			this.label10.Text = "Mã sách";
			// 
			// chkShowDisabledBook
			// 
			this.chkShowDisabledBook.AutoSize = true;
			this.chkShowDisabledBook.Checked = true;
			this.chkShowDisabledBook.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShowDisabledBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowDisabledBook.Location = new System.Drawing.Point(440, 601);
			this.chkShowDisabledBook.Name = "chkShowDisabledBook";
			this.chkShowDisabledBook.Size = new System.Drawing.Size(170, 21);
			this.chkShowDisabledBook.TabIndex = 5;
			this.chkShowDisabledBook.Text = "Hiện sách bị vô hiệu hoá";
			this.chkShowDisabledBook.UseVisualStyleBackColor = true;
			this.chkShowDisabledBook.CheckedChanged += new System.EventHandler(this.ChkShowDisabledBook_CheckedChanged);
			// 
			// txtBookName
			// 
			this.txtBookName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBookName.Location = new System.Drawing.Point(223, 30);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.ReadOnly = true;
			this.txtBookName.Size = new System.Drawing.Size(711, 43);
			this.txtBookName.TabIndex = 16;
			this.txtBookName.TabStop = false;
			this.txtBookName.Text = "Chọn sách...";
			// 
			// chkShowLostBook
			// 
			this.chkShowLostBook.AutoSize = true;
			this.chkShowLostBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowLostBook.Location = new System.Drawing.Point(289, 601);
			this.chkShowLostBook.Name = "chkShowLostBook";
			this.chkShowLostBook.Size = new System.Drawing.Size(124, 21);
			this.chkShowLostBook.TabIndex = 4;
			this.chkShowLostBook.Text = "Hiện sách bị mất";
			this.chkShowLostBook.UseVisualStyleBackColor = true;
			this.chkShowLostBook.CheckedChanged += new System.EventHandler(this.ChkShowLostBook_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LMS.Properties.Resources.search_icon;
			this.pictureBox1.Location = new System.Drawing.Point(925, 324);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// btnUpdateBook
			// 
			this.btnUpdateBook.Enabled = false;
			this.btnUpdateBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateBook.Image = global::LMS.Properties.Resources.update;
			this.btnUpdateBook.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnUpdateBook.Location = new System.Drawing.Point(811, 586);
			this.btnUpdateBook.Name = "btnUpdateBook";
			this.btnUpdateBook.Size = new System.Drawing.Size(139, 42);
			this.btnUpdateBook.TabIndex = 3;
			this.btnUpdateBook.Text = "       Cập nhật";
			this.btnUpdateBook.UseVisualStyleBackColor = true;
			this.btnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = global::LMS.Properties.Resources.newbook_icon;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(666, 586);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(139, 42);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "       Thêm sách";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddBook_Click);
			// 
			// pbxBookCover
			// 
			this.pbxBookCover.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxBookCover.Location = new System.Drawing.Point(3, 16);
			this.pbxBookCover.Name = "pbxBookCover";
			this.pbxBookCover.Size = new System.Drawing.Size(167, 221);
			this.pbxBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxBookCover.TabIndex = 1;
			this.pbxBookCover.TabStop = false;
			// 
			// BookInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(983, 661);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.chkShowLostBook);
			this.Controls.Add(this.txtBookName);
			this.Controls.Add(this.chkShowDisabledBook);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtSearchString);
			this.Controls.Add(this.btnUpdateBook);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgwBookInfo);
			this.Controls.Add(this.txtBookID);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BookInfo";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "BookInfo";
			this.Load += new System.EventHandler(this.BookInfo_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwBookInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxBookCover)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtPublisherName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAuthorName;
		private System.Windows.Forms.Label lblAuthorName;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEditionNumber;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPublishedYear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBookID;
		private System.Windows.Forms.DataGridView dgwBookInfo;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdateBook;
		private System.Windows.Forms.TextBox txtSearchString;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblEnable;
		private System.Windows.Forms.TextBox txtISBN;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox chkShowDisabledBook;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.CheckBox chkShowLostBook;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
		private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.PictureBox pbxBookCover;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}