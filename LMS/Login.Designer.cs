namespace LMS
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelFail = new System.Windows.Forms.Label();
			this.chkShowPassword = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCheckSqlServer = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(26, 40);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(298, 29);
			this.txtUserName.TabIndex = 1;
			this.txtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(26, 109);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(298, 29);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.TextChanged += new System.EventHandler(this.TxtPasswork_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mật khẩu";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnLogin.Enabled = false;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(221, 183);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(138, 31);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 407);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 31);
			this.button1.TabIndex = 5;
			this.button1.Text = "test";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labelFail);
			this.panel1.Controls.Add(this.chkShowPassword);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtUserName);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Location = new System.Drawing.Point(225, 131);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(20);
			this.panel1.Size = new System.Drawing.Size(382, 237);
			this.panel1.TabIndex = 6;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::LMS.Properties.Resources.password_icon;
			this.pictureBox2.Location = new System.Drawing.Point(330, 109);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(29, 29);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 28;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LMS.Properties.Resources.username_icon;
			this.pictureBox1.Location = new System.Drawing.Point(330, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 29);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// labelFail
			// 
			this.labelFail.AutoSize = true;
			this.labelFail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFail.ForeColor = System.Drawing.Color.Maroon;
			this.labelFail.Location = new System.Drawing.Point(22, 150);
			this.labelFail.Name = "labelFail";
			this.labelFail.Size = new System.Drawing.Size(252, 20);
			this.labelFail.TabIndex = 26;
			this.labelFail.Text = "* Sai tên đăng nhập hoặc mật khẩu";
			this.labelFail.Visible = false;
			// 
			// chkShowPassword
			// 
			this.chkShowPassword.AutoSize = true;
			this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowPassword.Location = new System.Drawing.Point(26, 190);
			this.chkShowPassword.Name = "chkShowPassword";
			this.chkShowPassword.Size = new System.Drawing.Size(110, 21);
			this.chkShowPassword.TabIndex = 25;
			this.chkShowPassword.Text = "Hiện mật khẩu";
			this.chkShowPassword.UseVisualStyleBackColor = true;
			this.chkShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(88, 89);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 17);
			this.label3.TabIndex = 23;
			this.label3.Text = "*";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(121, 20);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(13, 17);
			this.label9.TabIndex = 22;
			this.label9.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(308, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(211, 45);
			this.label4.TabIndex = 7;
			this.label4.Text = " TEAM9 LMS";
			// 
			// btnCheckSqlServer
			// 
			this.btnCheckSqlServer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckSqlServer.Location = new System.Drawing.Point(68, 407);
			this.btnCheckSqlServer.Name = "btnCheckSqlServer";
			this.btnCheckSqlServer.Size = new System.Drawing.Size(139, 31);
			this.btnCheckSqlServer.TabIndex = 8;
			this.btnCheckSqlServer.Text = "Cài đặt SQL Server";
			this.btnCheckSqlServer.UseVisualStyleBackColor = true;
			this.btnCheckSqlServer.Click += new System.EventHandler(this.BtnCheckSqlServer_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCheckSqlServer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chkShowPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelFail;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnCheckSqlServer;
	}
}