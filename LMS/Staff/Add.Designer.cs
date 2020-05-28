namespace LMS.Staff
{
	partial class Add
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
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSelectPhoto = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.label12 = new System.Windows.Forms.Label();
			this.cboGender = new System.Windows.Forms.ComboBox();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblAuthorName = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtStaffID = new System.Windows.Forms.TextBox();
			this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.pbxAvatar = new System.Windows.Forms.PictureBox();
			this.btnAddStaff = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnAddStaff);
			this.groupBox2.Controls.Add(this.btnCancel);
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.btnSelectPhoto);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.txtStaffID);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
			this.groupBox2.Size = new System.Drawing.Size(623, 532);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thêm nhân viên";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.txtPassword);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.txtUserName);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Location = new System.Drawing.Point(175, 340);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(50, 3, 50, 10);
			this.groupBox4.Size = new System.Drawing.Size(425, 133);
			this.groupBox4.TabIndex = 28;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Đăng kí tài khoản";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(118, 76);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 17);
			this.label5.TabIndex = 36;
			this.label5.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(136, 21);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 17);
			this.label4.TabIndex = 32;
			this.label4.Text = "*";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(53, 96);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(318, 25);
			this.txtPassword.TabIndex = 8;
			this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(53, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 17);
			this.label3.TabIndex = 34;
			this.label3.Text = "Mật khẩu";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(53, 41);
			this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(318, 25);
			this.txtUserName.TabIndex = 7;
			this.txtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 17);
			this.label2.TabIndex = 32;
			this.label2.Text = "Tên tài khoản";
			// 
			// btnSelectPhoto
			// 
			this.btnSelectPhoto.Location = new System.Drawing.Point(20, 260);
			this.btnSelectPhoto.Name = "btnSelectPhoto";
			this.btnSelectPhoto.Size = new System.Drawing.Size(134, 26);
			this.btnSelectPhoto.TabIndex = 1;
			this.btnSelectPhoto.Text = "Chọn hình";
			this.btnSelectPhoto.UseVisualStyleBackColor = true;
			this.btnSelectPhoto.Click += new System.EventHandler(this.BtnSelectPhoto_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.dtpDateOfBirth);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.cboGender);
			this.groupBox3.Controls.Add(this.txtStaffName);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.txtAddress);
			this.groupBox3.Controls.Add(this.txtPhone);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.lblAuthorName);
			this.groupBox3.Location = new System.Drawing.Point(175, 72);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(50, 3, 50, 10);
			this.groupBox3.Size = new System.Drawing.Size(425, 262);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin nhân viên";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(141, 131);
			this.label14.Margin = new System.Windows.Forms.Padding(0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(13, 17);
			this.label14.TabIndex = 31;
			this.label14.Text = "*";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(136, 21);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(13, 17);
			this.label9.TabIndex = 28;
			this.label9.Text = "*";
			// 
			// dtpDateOfBirth
			// 
			this.dtpDateOfBirth.CustomFormat = "dd / MM / yyyy";
			this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateOfBirth.Location = new System.Drawing.Point(222, 96);
			this.dtpDateOfBirth.Name = "dtpDateOfBirth";
			this.dtpDateOfBirth.Size = new System.Drawing.Size(149, 25);
			this.dtpDateOfBirth.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(219, 76);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(66, 17);
			this.label12.TabIndex = 26;
			this.label12.Text = "Ngày sinh";
			// 
			// cboGender
			// 
			this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboGender.FormattingEnabled = true;
			this.cboGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
			this.cboGender.Location = new System.Drawing.Point(53, 96);
			this.cboGender.Name = "cboGender";
			this.cboGender.Size = new System.Drawing.Size(121, 25);
			this.cboGender.TabIndex = 3;
			// 
			// txtStaffName
			// 
			this.txtStaffName.Location = new System.Drawing.Point(53, 41);
			this.txtStaffName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.Size = new System.Drawing.Size(318, 25);
			this.txtStaffName.TabIndex = 2;
			this.txtStaffName.TextChanged += new System.EventHandler(this.TxtStaffName_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(53, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 17);
			this.label7.TabIndex = 19;
			this.label7.Text = "Tên nhân viên";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(53, 206);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(318, 41);
			this.txtAddress.TabIndex = 6;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(53, 151);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(152, 25);
			this.txtPhone.TabIndex = 5;
			this.txtPhone.TextChanged += new System.EventHandler(this.TxtPhone_TextChanged);
			this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Địa chỉ";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(53, 131);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 17);
			this.label11.TabIndex = 5;
			this.label11.Text = "Số điện thoại";
			// 
			// lblAuthorName
			// 
			this.lblAuthorName.AutoSize = true;
			this.lblAuthorName.Location = new System.Drawing.Point(53, 76);
			this.lblAuthorName.Name = "lblAuthorName";
			this.lblAuthorName.Size = new System.Drawing.Size(56, 17);
			this.lblAuthorName.TabIndex = 0;
			this.lblAuthorName.Text = "Giới tính";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(172, 44);
			this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 17);
			this.label8.TabIndex = 16;
			this.label8.Text = "Mã nhân viên";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pbxAvatar);
			this.groupBox1.Location = new System.Drawing.Point(20, 38);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(134, 209);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// txtStaffID
			// 
			this.txtStaffID.Location = new System.Drawing.Point(264, 41);
			this.txtStaffID.Name = "txtStaffID";
			this.txtStaffID.ReadOnly = true;
			this.txtStaffID.Size = new System.Drawing.Size(84, 25);
			this.txtStaffID.TabIndex = 17;
			this.txtStaffID.TabStop = false;
			this.txtStaffID.Text = "read999";
			// 
			// ofdOpenFile
			// 
			this.ofdOpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
			// 
			// pbxAvatar
			// 
			this.pbxAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxAvatar.Location = new System.Drawing.Point(3, 21);
			this.pbxAvatar.Name = "pbxAvatar";
			this.pbxAvatar.Size = new System.Drawing.Size(128, 185);
			this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxAvatar.TabIndex = 24;
			this.pbxAvatar.TabStop = false;
			// 
			// btnAddStaff
			// 
			this.btnAddStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAddStaff.Enabled = false;
			this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddStaff.Image = global::LMS.Properties.Resources.addper_icon;
			this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddStaff.Location = new System.Drawing.Point(315, 479);
			this.btnAddStaff.Name = "btnAddStaff";
			this.btnAddStaff.Size = new System.Drawing.Size(139, 42);
			this.btnAddStaff.TabIndex = 38;
			this.btnAddStaff.Text = "       Thêm nhân viên";
			this.btnAddStaff.UseVisualStyleBackColor = true;
			this.btnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Image = global::LMS.Properties.Resources.cancel_icon;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnCancel.Location = new System.Drawing.Point(461, 479);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(139, 42);
			this.btnCancel.TabIndex = 37;
			this.btnCancel.Text = "Huỷ";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// Add
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 552);
			this.Controls.Add(this.groupBox2);
			this.MaximumSize = new System.Drawing.Size(663, 591);
			this.MinimumSize = new System.Drawing.Size(663, 586);
			this.Name = "Add";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddStaff";
			this.Load += new System.EventHandler(this.AddStaff_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSelectPhoto;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cboGender;
		private System.Windows.Forms.TextBox txtStaffName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblAuthorName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtStaffID;
		private System.Windows.Forms.PictureBox pbxAvatar;
		private System.Windows.Forms.OpenFileDialog ofdOpenFile;
		private System.Windows.Forms.Button btnAddStaff;
		private System.Windows.Forms.Button btnCancel;
	}
}