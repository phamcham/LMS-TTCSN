using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS {

	public partial class Login : Form {

		public Login() {
			InitializeComponent();
		}

		private readonly DtoAccount dtoAccount = new DtoAccount();
		private readonly BllAccount bllAccount = new BllAccount();
		private DtoStaff dtoStaff = new DtoStaff();
		private readonly BllStaff bllStaff = new BllStaff();

		private void CheckLogin() {
			btnLogin.Enabled = true;
			if (string.IsNullOrEmpty(txtUserName.Text)) btnLogin.Enabled = false;
			if (string.IsNullOrEmpty(txtPassword.Text)) btnLogin.Enabled = false;
		}

		private void TxtUserName_TextChanged(object sender, EventArgs e) {
			CheckLogin();
		}

		private void TxtPasswork_TextChanged(object sender, EventArgs e) {
			CheckLogin();
		}

		private void BtnLogin_Click(object sender, EventArgs e) {
			dtoAccount.Username = txtUserName.Text;
			dtoAccount.Password = txtPassword.Text;
			if (bllAccount.CanLogin(dtoAccount)) {
				dtoStaff = bllStaff.GetByUserName(txtUserName.Text);
				Close();
				Thread thread = new Thread(
				delegate () {
					Application.Run(new Main(dtoStaff));
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
			}
			else {
				labelFail.Visible = true;
			}
		}

		private void Button1_Click(object sender, EventArgs e) {
			txtUserName.Text = "admin";
			txtPassword.Text = "123";
		}

		private void ChkShowPassword_CheckedChanged(object sender, EventArgs e) {
			txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
		}

		private void BtnCheckSqlServer_Click(object sender, EventArgs e) {
			DAL.AskToConnect askToConnect = new DAL.AskToConnect();
			askToConnect.ShowDialog();
		}
	}
}