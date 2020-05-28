namespace LMS.Book
{
	partial class Update
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCheckBorrowing = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.btnSelectPhoto = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cboEnable = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cboStatus = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEditionNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPublishedYear = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtPublisherName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtAuthorName = new System.Windows.Forms.TextBox();
			this.lblAuthorName = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBookID = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.pbxBookCover = new System.Windows.Forms.PictureBox();
			this.btnUpdateBook = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxBookCover)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCancel);
			this.groupBox2.Controls.Add(this.btnUpdateBook);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.txtCheckBorrowing);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.btnSelectPhoto);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtBookID);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(13, 11);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
			this.groupBox2.Size = new System.Drawing.Size(623, 642);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cập nhật sách";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pbxBookCover);
			this.groupBox1.Location = new System.Drawing.Point(20, 38);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(134, 209);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			// 
			// txtCheckBorrowing
			// 
			this.txtCheckBorrowing.Location = new System.Drawing.Point(20, 443);
			this.txtCheckBorrowing.Name = "txtCheckBorrowing";
			this.txtCheckBorrowing.ReadOnly = true;
			this.txtCheckBorrowing.Size = new System.Drawing.Size(134, 25);
			this.txtCheckBorrowing.TabIndex = 24;
			this.txtCheckBorrowing.TabStop = false;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(17, 423);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(67, 17);
			this.label19.TabIndex = 23;
			this.label19.Text = "Tình trạng";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(23, 313);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(131, 71);
			this.label18.TabIndex = 22;
			this.label18.Text = "Lưu ý: Chỉ có thể sửa đổi trạng thái và hiệu lực khi sách chưa được mượn";
			// 
			// btnSelectPhoto
			// 
			this.btnSelectPhoto.Location = new System.Drawing.Point(20, 260);
			this.btnSelectPhoto.Name = "btnSelectPhoto";
			this.btnSelectPhoto.Size = new System.Drawing.Size(134, 26);
			this.btnSelectPhoto.TabIndex = 0;
			this.btnSelectPhoto.Text = "Chọn hình";
			this.btnSelectPhoto.UseVisualStyleBackColor = true;
			this.btnSelectPhoto.Click += new System.EventHandler(this.BtnSelectPhoto_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.cboEnable);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.cboStatus);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.txtBookName);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.txtNotes);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.txtISBN);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.txtPrice);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.txtEditionNumber);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txtPublishedYear);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.txtCategoryName);
			this.groupBox3.Controls.Add(this.txtPublisherName);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.txtAuthorName);
			this.groupBox3.Controls.Add(this.lblAuthorName);
			this.groupBox3.Location = new System.Drawing.Point(175, 72);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(50, 3, 50, 10);
			this.groupBox3.Size = new System.Drawing.Size(425, 515);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin sách";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Red;
			this.label17.Location = new System.Drawing.Point(290, 455);
			this.label17.Margin = new System.Windows.Forms.Padding(0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(13, 17);
			this.label17.TabIndex = 30;
			this.label17.Text = "*";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Red;
			this.label16.Location = new System.Drawing.Point(122, 455);
			this.label16.Margin = new System.Windows.Forms.Padding(0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(13, 17);
			this.label16.TabIndex = 29;
			this.label16.Text = "*";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Red;
			this.label15.Location = new System.Drawing.Point(110, 186);
			this.label15.Margin = new System.Windows.Forms.Padding(0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(13, 17);
			this.label15.TabIndex = 28;
			this.label15.Text = "*";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(142, 131);
			this.label14.Margin = new System.Windows.Forms.Padding(0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(13, 17);
			this.label14.TabIndex = 27;
			this.label14.Text = "*";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(105, 76);
			this.label13.Margin = new System.Windows.Forms.Padding(0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(13, 17);
			this.label13.TabIndex = 26;
			this.label13.Text = "*";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(114, 21);
			this.label12.Margin = new System.Windows.Forms.Padding(0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(13, 17);
			this.label12.TabIndex = 25;
			this.label12.Text = "*";
			// 
			// cboEnable
			// 
			this.cboEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEnable.FormattingEnabled = true;
			this.cboEnable.Items.AddRange(new object[] {
            "Có sẵn",
            "Vô hiệu hoá"});
			this.cboEnable.Location = new System.Drawing.Point(232, 475);
			this.cboEnable.Name = "cboEnable";
			this.cboEnable.Size = new System.Drawing.Size(139, 25);
			this.cboEnable.TabIndex = 10;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(232, 455);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 17);
			this.label10.TabIndex = 23;
			this.label10.Text = "Hiệu lực";
			// 
			// cboStatus
			// 
			this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboStatus.FormattingEnabled = true;
			this.cboStatus.Location = new System.Drawing.Point(53, 475);
			this.cboStatus.Name = "cboStatus";
			this.cboStatus.Size = new System.Drawing.Size(121, 25);
			this.cboStatus.TabIndex = 9;
			this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.CboStatus_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(53, 455);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 17);
			this.label9.TabIndex = 21;
			this.label9.Text = "Trạng thái";
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(53, 41);
			this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(318, 25);
			this.txtBookName.TabIndex = 1;
			this.txtBookName.TextChanged += new System.EventHandler(this.TxtBookName_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(53, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 17);
			this.label7.TabIndex = 19;
			this.label7.Text = "Tên sách";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(53, 371);
			this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(318, 74);
			this.txtNotes.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(53, 351);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 17);
			this.label6.TabIndex = 17;
			this.label6.Text = "Tóm tắt";
			// 
			// txtISBN
			// 
			this.txtISBN.Location = new System.Drawing.Point(232, 316);
			this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.Size = new System.Drawing.Size(139, 25);
			this.txtISBN.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(229, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "ISBN";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(53, 316);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(152, 25);
			this.txtPrice.TabIndex = 7;
			this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrice_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(50, 296);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "Giá";
			// 
			// txtEditionNumber
			// 
			this.txtEditionNumber.Location = new System.Drawing.Point(232, 261);
			this.txtEditionNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtEditionNumber.Name = "txtEditionNumber";
			this.txtEditionNumber.Size = new System.Drawing.Size(57, 25);
			this.txtEditionNumber.TabIndex = 6;
			this.txtEditionNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEditionNumber_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(229, 241);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "Tái bản";
			// 
			// txtPublishedYear
			// 
			this.txtPublishedYear.Location = new System.Drawing.Point(53, 261);
			this.txtPublishedYear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtPublishedYear.Name = "txtPublishedYear";
			this.txtPublishedYear.Size = new System.Drawing.Size(87, 25);
			this.txtPublishedYear.TabIndex = 5;
			this.txtPublishedYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPublishedYear_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Năm xuất bản";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(53, 206);
			this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(152, 25);
			this.txtCategoryName.TabIndex = 4;
			this.txtCategoryName.TextChanged += new System.EventHandler(this.TxtCategoryName_TextChanged);
			// 
			// txtPublisherName
			// 
			this.txtPublisherName.Location = new System.Drawing.Point(53, 151);
			this.txtPublisherName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtPublisherName.Name = "txtPublisherName";
			this.txtPublisherName.Size = new System.Drawing.Size(318, 25);
			this.txtPublisherName.TabIndex = 3;
			this.txtPublisherName.TextChanged += new System.EventHandler(this.TxtPublisherName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Thể loại";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(53, 131);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(86, 17);
			this.label11.TabIndex = 5;
			this.label11.Text = "Nhà xuất bản";
			// 
			// txtAuthorName
			// 
			this.txtAuthorName.Location = new System.Drawing.Point(53, 96);
			this.txtAuthorName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtAuthorName.Name = "txtAuthorName";
			this.txtAuthorName.Size = new System.Drawing.Size(318, 25);
			this.txtAuthorName.TabIndex = 2;
			this.txtAuthorName.TextChanged += new System.EventHandler(this.TxtAuthorName_TextChanged);
			// 
			// lblAuthorName
			// 
			this.lblAuthorName.AutoSize = true;
			this.lblAuthorName.Location = new System.Drawing.Point(53, 76);
			this.lblAuthorName.Name = "lblAuthorName";
			this.lblAuthorName.Size = new System.Drawing.Size(49, 17);
			this.lblAuthorName.TabIndex = 0;
			this.lblAuthorName.Text = "Tác giả";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(172, 44);
			this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 17);
			this.label8.TabIndex = 16;
			this.label8.Text = "Mã sách";
			// 
			// txtBookID
			// 
			this.txtBookID.Location = new System.Drawing.Point(235, 41);
			this.txtBookID.Name = "txtBookID";
			this.txtBookID.ReadOnly = true;
			this.txtBookID.Size = new System.Drawing.Size(84, 25);
			this.txtBookID.TabIndex = 17;
			this.txtBookID.TabStop = false;
			this.txtBookID.Text = "book999";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
			// 
			// pbxBookCover
			// 
			this.pbxBookCover.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxBookCover.Location = new System.Drawing.Point(3, 21);
			this.pbxBookCover.Name = "pbxBookCover";
			this.pbxBookCover.Size = new System.Drawing.Size(128, 185);
			this.pbxBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxBookCover.TabIndex = 22;
			this.pbxBookCover.TabStop = false;
			// 
			// btnUpdateBook
			// 
			this.btnUpdateBook.Enabled = false;
			this.btnUpdateBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateBook.Image = global::LMS.Properties.Resources.update;
			this.btnUpdateBook.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnUpdateBook.Location = new System.Drawing.Point(316, 593);
			this.btnUpdateBook.Name = "btnUpdateBook";
			this.btnUpdateBook.Size = new System.Drawing.Size(139, 42);
			this.btnUpdateBook.TabIndex = 23;
			this.btnUpdateBook.Text = "       Cập nhật";
			this.btnUpdateBook.UseVisualStyleBackColor = true;
			this.btnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Image = global::LMS.Properties.Resources.cancel_icon;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnCancel.Location = new System.Drawing.Point(461, 593);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(139, 42);
			this.btnCancel.TabIndex = 26;
			this.btnCancel.Text = "Huỷ";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// Update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 665);
			this.Controls.Add(this.groupBox2);
			this.MinimumSize = new System.Drawing.Size(665, 694);
			this.Name = "Update";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update";
			this.Load += new System.EventHandler(this.UpdateBook_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxBookCover)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnSelectPhoto;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.TextBox txtISBN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEditionNumber;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPublishedYear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtPublisherName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtAuthorName;
		private System.Windows.Forms.Label lblAuthorName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBookID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboEnable;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cboStatus;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtCheckBorrowing;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pbxBookCover;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button btnUpdateBook;
		private System.Windows.Forms.Button btnCancel;
	}
}