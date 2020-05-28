namespace LMS.Staff
{
	partial class StaffInfo
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
			this.chkShowBlockedStaff = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSearchString = new System.Windows.Forms.TextBox();
			this.dgwStaffInfo = new System.Windows.Forms.DataGridView();
			this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEnable = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDateOfBirth = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtStaffID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtGender = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUpdateStaff = new System.Windows.Forms.Button();
			this.btnAddStaff = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbxAvatar = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwStaffInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// chkShowBlockedStaff
			// 
			this.chkShowBlockedStaff.AutoSize = true;
			this.chkShowBlockedStaff.Checked = true;
			this.chkShowBlockedStaff.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShowBlockedStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowBlockedStaff.Location = new System.Drawing.Point(365, 202);
			this.chkShowBlockedStaff.Name = "chkShowBlockedStaff";
			this.chkShowBlockedStaff.Size = new System.Drawing.Size(159, 21);
			this.chkShowBlockedStaff.TabIndex = 2;
			this.chkShowBlockedStaff.Text = "Hiện nhân viên bị khoá";
			this.chkShowBlockedStaff.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(622, 203);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 17);
			this.label11.TabIndex = 26;
			this.label11.Text = "Tìm kiếm";
			// 
			// txtSearchString
			// 
			this.txtSearchString.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchString.Location = new System.Drawing.Point(688, 200);
			this.txtSearchString.Name = "txtSearchString";
			this.txtSearchString.Size = new System.Drawing.Size(231, 25);
			this.txtSearchString.TabIndex = 1;
			this.txtSearchString.TextChanged += new System.EventHandler(this.TxtSearchString_TextChanged);
			// 
			// dgwStaffInfo
			// 
			this.dgwStaffInfo.AllowUserToAddRows = false;
			this.dgwStaffInfo.AllowUserToDeleteRows = false;
			this.dgwStaffInfo.AllowUserToResizeColumns = false;
			this.dgwStaffInfo.AllowUserToResizeRows = false;
			this.dgwStaffInfo.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwStaffInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgwStaffInfo.ColumnHeadersHeight = 25;
			this.dgwStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgwStaffInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.StaffName,
            this.Phone,
            this.UserName,
            this.Status});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwStaffInfo.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgwStaffInfo.Location = new System.Drawing.Point(305, 231);
			this.dgwStaffInfo.Name = "dgwStaffInfo";
			this.dgwStaffInfo.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwStaffInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgwStaffInfo.RowHeadersVisible = false;
			this.dgwStaffInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwStaffInfo.Size = new System.Drawing.Size(645, 349);
			this.dgwStaffInfo.TabIndex = 22;
			this.dgwStaffInfo.TabStop = false;
			this.dgwStaffInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwStaffInfo_CellClick);
			// 
			// StaffID
			// 
			this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.StaffID.DataPropertyName = "StaffID";
			this.StaffID.HeaderText = "Mã nhân viên";
			this.StaffID.Name = "StaffID";
			this.StaffID.ReadOnly = true;
			// 
			// StaffName
			// 
			this.StaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.StaffName.DataPropertyName = "StaffName";
			this.StaffName.FillWeight = 200F;
			this.StaffName.HeaderText = "Tên nhân viên";
			this.StaffName.Name = "StaffName";
			this.StaffName.ReadOnly = true;
			// 
			// Phone
			// 
			this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Phone.DataPropertyName = "Phone";
			this.Phone.HeaderText = "Số điện thoại";
			this.Phone.Name = "Phone";
			this.Phone.ReadOnly = true;
			// 
			// UserName
			// 
			this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.UserName.DataPropertyName = "UserName";
			this.UserName.HeaderText = "Tên tài khoản";
			this.UserName.Name = "UserName";
			this.UserName.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Trạng thái";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 323);
			this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Giới tính";
			// 
			// separatorControl1
			// 
			this.separatorControl1.Location = new System.Drawing.Point(4, 300);
			this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
			this.separatorControl1.Name = "separatorControl1";
			this.separatorControl1.Size = new System.Drawing.Size(251, 23);
			this.separatorControl1.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtUserName);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtEnable);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtAddress);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtDateOfBirth);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtStaffID);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(305, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
			this.groupBox2.Size = new System.Drawing.Size(507, 161);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin nhân viên";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(333, 115);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.ReadOnly = true;
			this.txtUserName.Size = new System.Drawing.Size(151, 25);
			this.txtUserName.TabIndex = 7;
			this.txtUserName.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(242, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Tên tài khoản";
			// 
			// txtEnable
			// 
			this.txtEnable.Location = new System.Drawing.Point(109, 115);
			this.txtEnable.Name = "txtEnable";
			this.txtEnable.ReadOnly = true;
			this.txtEnable.Size = new System.Drawing.Size(116, 25);
			this.txtEnable.TabIndex = 5;
			this.txtEnable.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 118);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 17);
			this.label6.TabIndex = 4;
			this.label6.Text = "Trạng thái";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(109, 66);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ReadOnly = true;
			this.txtAddress.Size = new System.Drawing.Size(375, 43);
			this.txtAddress.TabIndex = 5;
			this.txtAddress.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(56, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Địa chỉ";
			// 
			// txtDateOfBirth
			// 
			this.txtDateOfBirth.Location = new System.Drawing.Point(333, 35);
			this.txtDateOfBirth.Name = "txtDateOfBirth";
			this.txtDateOfBirth.ReadOnly = true;
			this.txtDateOfBirth.Size = new System.Drawing.Size(151, 25);
			this.txtDateOfBirth.TabIndex = 3;
			this.txtDateOfBirth.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(261, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Ngày sinh";
			// 
			// txtStaffID
			// 
			this.txtStaffID.Location = new System.Drawing.Point(109, 35);
			this.txtStaffID.Name = "txtStaffID";
			this.txtStaffID.ReadOnly = true;
			this.txtStaffID.Size = new System.Drawing.Size(116, 25);
			this.txtStaffID.TabIndex = 1;
			this.txtStaffID.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã nhân viên";
			// 
			// txtGender
			// 
			this.txtGender.Location = new System.Drawing.Point(154, 320);
			this.txtGender.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.txtGender.Name = "txtGender";
			this.txtGender.ReadOnly = true;
			this.txtGender.Size = new System.Drawing.Size(84, 25);
			this.txtGender.TabIndex = 5;
			this.txtGender.TabStop = false;
			this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox3.Controls.Add(this.pbxAvatar);
			this.groupBox3.Location = new System.Drawing.Point(43, 21);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(173, 240);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			// 
			// txtStaffName
			// 
			this.txtStaffName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStaffName.Location = new System.Drawing.Point(4, 264);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.ReadOnly = true;
			this.txtStaffName.Size = new System.Drawing.Size(251, 33);
			this.txtStaffName.TabIndex = 2;
			this.txtStaffName.TabStop = false;
			this.txtStaffName.Text = "Chọn nhân viên ...";
			this.txtStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.panel1.Controls.Add(this.txtStaffName);
			this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(33, 33);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(257, 392);
			this.panel1.TabIndex = 20;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(112, 351);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.ReadOnly = true;
			this.txtPhone.Size = new System.Drawing.Size(126, 25);
			this.txtPhone.TabIndex = 7;
			this.txtPhone.TabStop = false;
			this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 354);
			this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Số điện thoại";
			// 
			// btnUpdateStaff
			// 
			this.btnUpdateStaff.Enabled = false;
			this.btnUpdateStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateStaff.Image = global::LMS.Properties.Resources.editper_icon;
			this.btnUpdateStaff.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnUpdateStaff.Location = new System.Drawing.Point(811, 586);
			this.btnUpdateStaff.Name = "btnUpdateStaff";
			this.btnUpdateStaff.Size = new System.Drawing.Size(139, 42);
			this.btnUpdateStaff.TabIndex = 40;
			this.btnUpdateStaff.Text = "       Cập nhật";
			this.btnUpdateStaff.UseVisualStyleBackColor = true;
			this.btnUpdateStaff.Click += new System.EventHandler(this.BtnUpdateStaff_Click);
			// 
			// btnAddStaff
			// 
			this.btnAddStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddStaff.Image = global::LMS.Properties.Resources.addper_icon;
			this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddStaff.Location = new System.Drawing.Point(666, 586);
			this.btnAddStaff.Name = "btnAddStaff";
			this.btnAddStaff.Size = new System.Drawing.Size(139, 42);
			this.btnAddStaff.TabIndex = 39;
			this.btnAddStaff.Text = "       Thêm nhân viên";
			this.btnAddStaff.UseVisualStyleBackColor = true;
			this.btnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LMS.Properties.Resources.search_icon;
			this.pictureBox1.Location = new System.Drawing.Point(925, 200);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// pbxAvatar
			// 
			this.pbxAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxAvatar.Location = new System.Drawing.Point(3, 21);
			this.pbxAvatar.Name = "pbxAvatar";
			this.pbxAvatar.Size = new System.Drawing.Size(167, 216);
			this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxAvatar.TabIndex = 24;
			this.pbxAvatar.TabStop = false;
			// 
			// StaffInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(983, 661);
			this.Controls.Add(this.btnUpdateStaff);
			this.Controls.Add(this.btnAddStaff);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.chkShowBlockedStaff);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtSearchString);
			this.Controls.Add(this.dgwStaffInfo);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StaffInfo";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "StaffInfo";
			this.Load += new System.EventHandler(this.StaffInfo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwStaffInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkShowBlockedStaff;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSearchString;
		private System.Windows.Forms.DataGridView dgwStaffInfo;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.SeparatorControl separatorControl1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtEnable;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDateOfBirth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtStaffID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGender;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtStaffName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.PictureBox pbxAvatar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnAddStaff;
		private System.Windows.Forms.Button btnUpdateStaff;
	}
}