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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Staff {

	public partial class Add : Form {

		public Add() {
			InitializeComponent();
		}

		private readonly DtoStaff dtoStaff = new DtoStaff();
		private readonly DtoAccount dtoAccount = new DtoAccount();
		private readonly BllStaff bllStaff = new BllStaff();
		private readonly BllAccount bllAccount = new BllAccount();
		private readonly BllHistory bllHistory = new BllHistory();
		private string avatarFileName = string.Empty;

		private void CboGender_Load() {
			List<StringHelper.KeyDisplayPair> items = new List<StringHelper.KeyDisplayPair>
			{
				StringHelper.Gender.Male,
				StringHelper.Gender.Female,
			};
			cboGender.DataSource = items;
			cboGender.DisplayMember = "Display";
			cboGender.ValueMember = "Key";
		}

		private void AddStaff_Load(object sender, EventArgs e) {
			CboGender_Load();

			txtStaffID.Text = dtoStaff.StaffID = bllStaff.GetNextID();
			cboGender.SelectedItem = StringHelper.Gender.Male;
		}

		private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		private void CheckAddingStaff() {
			btnAddStaff.Enabled = true;
			if (String.IsNullOrWhiteSpace(txtStaffName.Text)) btnAddStaff.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtPhone.Text)) btnAddStaff.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtUserName.Text)) btnAddStaff.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtPassword.Text)) btnAddStaff.Enabled = false;
		}

		private void TxtStaffName_TextChanged(object sender, EventArgs e) {
			CheckAddingStaff();
		}

		private void TxtPhone_TextChanged(object sender, EventArgs e) {
			CheckAddingStaff();
		}

		private void TxtUserName_TextChanged(object sender, EventArgs e) {
			CheckAddingStaff();
		}

		private void TxtPassword_TextChanged(object sender, EventArgs e) {
			CheckAddingStaff();
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void SaveHistory() {
			DtoHistory dtoHistory = new DtoHistory(
					bllHistory.GetNextID(),
					StringHelper.HistoryStatus.Add.Key,
					dtoStaff.StaffID,
					Session.StaffWorking.StaffID,
					DateTime.Now);
			if (!bllHistory.Add(dtoHistory)) MessageBox.Show("Không thể ghi lịch sử");
		}

		private void BtnAddStaff_Click(object sender, EventArgs e) {
			GetInfo();
			GetImage();
			AddStaff();
		}

		private void AddStaff() {
			if (bllAccount.Add(dtoAccount)) {
				if (bllStaff.Add(dtoStaff)) {
					MessageBox.Show(StringHelper.Notification.Success);
					SaveHistory();
					Close();
				}
			}
			else {
				MessageBox.Show(StringHelper.Notification.SomethingWentWrong);
			}
		}

		private void GetInfo() {
			dtoStaff.StaffName = txtStaffName.Text;
			dtoStaff.Gender = cboGender.Text;
			dtoStaff.DateOfBirth = dtpDateOfBirth.Value;
			dtoStaff.Phone = txtPhone.Text;
			dtoStaff.Address = txtAddress.Text;
			dtoStaff.UserName = txtUserName.Text;
			dtoAccount.Username = txtUserName.Text;
			dtoAccount.Password = txtPassword.Text;
		}

		private void GetImage() {
			if (string.IsNullOrEmpty(avatarFileName)) {
				return;
			}
			dtoStaff.Avatar = ConverImgToByte();
		}

		private void BtnSelectPhoto_Click(object sender, EventArgs e) {
			ofdOpenFile.ShowDialog();
		}

		private void OpenFileDialog_FileOk(object sender, CancelEventArgs e) {
			string filePath = ofdOpenFile.FileName;
			pbxAvatar.Image = Image.FromFile(filePath);
			avatarFileName = ofdOpenFile.FileName;
		}

		private byte[] ConverImgToByte() {
			FileStream fs = new FileStream(avatarFileName, FileMode.Open, FileAccess.Read);
			byte[] picbyte = new byte[fs.Length];
			fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
			fs.Close();
			return picbyte;
		}
	}
}