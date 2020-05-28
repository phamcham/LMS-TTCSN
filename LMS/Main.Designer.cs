namespace LMS
{
	partial class Main
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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnStatistic = new System.Windows.Forms.Button();
			this.btnIssueBook = new System.Windows.Forms.Button();
			this.btnStaff = new System.Windows.Forms.Button();
			this.btnReader = new System.Windows.Forms.Button();
			this.btnBook = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.pnlDisplayPane = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
			this.pbxAvatar = new System.Windows.Forms.PictureBox();
			this.linkAboutUs = new System.Windows.Forms.LinkLabel();
			this.panelMenu.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panelMenu.Controls.Add(this.linkAboutUs);
			this.panelMenu.Controls.Add(this.btnLogout);
			this.panelMenu.Controls.Add(this.btnStatistic);
			this.panelMenu.Controls.Add(this.btnStaff);
			this.panelMenu.Controls.Add(this.btnBook);
			this.panelMenu.Controls.Add(this.btnReader);
			this.panelMenu.Controls.Add(this.btnIssueBook);
			this.panelMenu.Controls.Add(this.panel2);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(201, 661);
			this.panelMenu.TabIndex = 0;
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.Location = new System.Drawing.Point(0, 548);
			this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(201, 54);
			this.btnLogout.TabIndex = 6;
			this.btnLogout.Text = "Đăng xuất";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
			// 
			// btnStatistic
			// 
			this.btnStatistic.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnStatistic.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnStatistic.FlatAppearance.BorderSize = 0;
			this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStatistic.Location = new System.Drawing.Point(0, 494);
			this.btnStatistic.Margin = new System.Windows.Forms.Padding(0);
			this.btnStatistic.Name = "btnStatistic";
			this.btnStatistic.Size = new System.Drawing.Size(201, 54);
			this.btnStatistic.TabIndex = 5;
			this.btnStatistic.Text = "Thống kê";
			this.btnStatistic.UseVisualStyleBackColor = false;
			this.btnStatistic.Click += new System.EventHandler(this.BtnStatistic_Click);
			// 
			// btnIssueBook
			// 
			this.btnIssueBook.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnIssueBook.FlatAppearance.BorderSize = 0;
			this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIssueBook.Location = new System.Drawing.Point(0, 278);
			this.btnIssueBook.Margin = new System.Windows.Forms.Padding(0);
			this.btnIssueBook.Name = "btnIssueBook";
			this.btnIssueBook.Size = new System.Drawing.Size(201, 54);
			this.btnIssueBook.TabIndex = 1;
			this.btnIssueBook.Text = "Mượn trả";
			this.btnIssueBook.UseVisualStyleBackColor = false;
			this.btnIssueBook.Click += new System.EventHandler(this.BtnIssueBook_Click);
			// 
			// btnStaff
			// 
			this.btnStaff.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnStaff.FlatAppearance.BorderSize = 0;
			this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStaff.Location = new System.Drawing.Point(0, 440);
			this.btnStaff.Margin = new System.Windows.Forms.Padding(0);
			this.btnStaff.Name = "btnStaff";
			this.btnStaff.Size = new System.Drawing.Size(201, 54);
			this.btnStaff.TabIndex = 4;
			this.btnStaff.Text = "Nhân viên";
			this.btnStaff.UseVisualStyleBackColor = false;
			this.btnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
			// 
			// btnReader
			// 
			this.btnReader.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnReader.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnReader.FlatAppearance.BorderSize = 0;
			this.btnReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReader.Location = new System.Drawing.Point(0, 332);
			this.btnReader.Margin = new System.Windows.Forms.Padding(0);
			this.btnReader.Name = "btnReader";
			this.btnReader.Size = new System.Drawing.Size(201, 54);
			this.btnReader.TabIndex = 2;
			this.btnReader.Text = "Bạn đọc";
			this.btnReader.UseVisualStyleBackColor = false;
			this.btnReader.Click += new System.EventHandler(this.BtnReader_Click);
			// 
			// btnBook
			// 
			this.btnBook.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBook.FlatAppearance.BorderSize = 0;
			this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBook.Location = new System.Drawing.Point(0, 386);
			this.btnBook.Margin = new System.Windows.Forms.Padding(0);
			this.btnBook.Name = "btnBook";
			this.btnBook.Size = new System.Drawing.Size(201, 54);
			this.btnBook.TabIndex = 3;
			this.btnBook.Text = "Sách";
			this.btnBook.UseVisualStyleBackColor = false;
			this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Teal;
			this.panel2.Controls.Add(this.separatorControl1);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtStaffName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(201, 278);
			this.panel2.TabIndex = 0;
			// 
			// txtStaffName
			// 
			this.txtStaffName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStaffName.Location = new System.Drawing.Point(12, 239);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.ReadOnly = true;
			this.txtStaffName.Size = new System.Drawing.Size(176, 25);
			this.txtStaffName.TabIndex = 0;
			this.txtStaffName.TabStop = false;
			this.txtStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pnlDisplayPane
			// 
			this.pnlDisplayPane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.pnlDisplayPane.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDisplayPane.Location = new System.Drawing.Point(201, 0);
			this.pnlDisplayPane.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDisplayPane.Name = "pnlDisplayPane";
			this.pnlDisplayPane.Size = new System.Drawing.Size(983, 661);
			this.pnlDisplayPane.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(5, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(189, 40);
			this.label4.TabIndex = 8;
			this.label4.Text = " TEAM9 LMS";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pbxAvatar);
			this.panel3.Location = new System.Drawing.Point(12, 83);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(176, 150);
			this.panel3.TabIndex = 9;
			// 
			// separatorControl1
			// 
			this.separatorControl1.Location = new System.Drawing.Point(3, 52);
			this.separatorControl1.Name = "separatorControl1";
			this.separatorControl1.Size = new System.Drawing.Size(195, 23);
			this.separatorControl1.TabIndex = 10;
			// 
			// pbxAvatar
			// 
			this.pbxAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxAvatar.Location = new System.Drawing.Point(0, 0);
			this.pbxAvatar.Name = "pbxAvatar";
			this.pbxAvatar.Size = new System.Drawing.Size(176, 150);
			this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxAvatar.TabIndex = 9;
			this.pbxAvatar.TabStop = false;
			// 
			// linkAboutUs
			// 
			this.linkAboutUs.AutoSize = true;
			this.linkAboutUs.LinkColor = System.Drawing.Color.MediumBlue;
			this.linkAboutUs.Location = new System.Drawing.Point(12, 639);
			this.linkAboutUs.Name = "linkAboutUs";
			this.linkAboutUs.Size = new System.Drawing.Size(96, 13);
			this.linkAboutUs.TabIndex = 7;
			this.linkAboutUs.TabStop = true;
			this.linkAboutUs.Text = "Về nhóm chúng tôi";
			this.linkAboutUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAboutUs_LinkClicked);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 661);
			this.Controls.Add(this.pnlDisplayPane);
			this.Controls.Add(this.panelMenu);
			this.MaximumSize = new System.Drawing.Size(1200, 700);
			this.MinimumSize = new System.Drawing.Size(1200, 700);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Main_Load);
			this.panelMenu.ResumeLayout(false);
			this.panelMenu.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Button btnBook;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnlDisplayPane;
		private System.Windows.Forms.Button btnReader;
		private System.Windows.Forms.Button btnStaff;
		private System.Windows.Forms.TextBox txtStaffName;
		private System.Windows.Forms.Button btnIssueBook;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnStatistic;
		private System.Windows.Forms.PictureBox pbxAvatar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private DevExpress.XtraEditors.SeparatorControl separatorControl1;
		private System.Windows.Forms.LinkLabel linkAboutUs;
	}
}

