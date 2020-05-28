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

	public partial class Update : Form {

		public Update(string userName, DtoStaff dtoStaff) {
			InitializeComponent();
			this.dtoAccount = bllAccount.GetByUserName(userName);
			this.dtoStaff = dtoStaff;
		}

		private readonly BllAccount bllAccount = new BllAccount();
		private readonly BllStaff bllStaff = new BllStaff();
		private readonly DtoAccount dtoAccount = new DtoAccount();
		private readonly DtoStaff dtoStaff = new DtoStaff();
		private string AvatarFileName = string.Empty;

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

		private void UpdateStaff_Load(object sender, EventArgs e) {
			CboGender_Load();
			LoadInfo();
			LoadImage();
		}

		private void LoadInfo() {
			txtStaffID.Text = dtoStaff.StaffID;
			txtStaffName.Text = dtoStaff.StaffName;
			cboGender.SelectedItem = StringHelper.Gender.GetByKey(dtoStaff.Gender);
			dtpDateOfBirth.Value = dtoStaff.DateOfBirth;
			txtPhone.Text = dtoStaff.Phone;
			txtAddress.Text = dtoStaff.Address;
			txtUserName.Text = dtoAccount.Username;
			txtPassword.Text = dtoAccount.Password;
		}

		private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		private void CheckAddingStaff() {
			btnUpdateStaff.Enabled = true;
			if (String.IsNullOrWhiteSpace(txtStaffName.Text)) btnUpdateStaff.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtPhone.Text)) btnUpdateStaff.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtUserName.Text)) btnUpdateStaff.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtPassword.Text)) btnUpdateStaff.Enabled = false;
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
			this.Close();
		}

		private void SaveHistory() {
			BllHistory bllHistory = new BllHistory();
			DtoHistory dtoHistory = new DtoHistory(
					bllHistory.GetNextID(),
					StringHelper.HistoryStatus.Update.Key,
					dtoStaff.StaffID,
					Session.StaffWorking.StaffID,
					DateTime.Now);
			if (!bllHistory.Add(dtoHistory)) MessageBox.Show("Không thể ghi lịch sử");
		}

		private void BtnUpdateStaff_Click(object sender, EventArgs e) {
			GetInfo();
			GetImage();
			UpdateStaff();
		}

		private void UpdateStaff() {
			if (bllAccount.Update(dtoAccount)) {
				if (bllStaff.Update(dtoStaff)) {
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
			dtoStaff.StaffID = txtStaffID.Text;
			dtoStaff.StaffName = txtStaffName.Text;
			dtoStaff.Gender = StringHelper.KeyDisplayPair.Parse(cboGender.SelectedItem).Key;
			dtoStaff.DateOfBirth = dtpDateOfBirth.Value;
			dtoStaff.Phone = txtPhone.Text;
			dtoStaff.Address = txtAddress.Text;
			dtoAccount.Username = txtUserName.Text;
			dtoAccount.Password = txtPassword.Text;
		}

		private void LoadImage() {
			if (dtoStaff.Avatar == null) return;
			pbxAvatar.Image = ByteToImg(Convert.ToBase64String(dtoStaff.Avatar));
		}

		private void GetImage() {
			if (string.IsNullOrEmpty(AvatarFileName)) return;
			dtoStaff.Avatar = ConverImgToByte();
		}

		private void BtnSelectPhoto_Click(object sender, EventArgs e) {
			ofdOpenFile.ShowDialog();
		}

		private void OpenFileDialog_FileOk(object sender, CancelEventArgs e) {
			AvatarFileName = ofdOpenFile.FileName;
			pbxAvatar.Image = Image.FromFile(AvatarFileName);
		}

		private byte[] ConverImgToByte() {
			FileStream fs = new FileStream(AvatarFileName, FileMode.Open, FileAccess.Read);
			byte[] picbyte = new byte[fs.Length];
			fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
			fs.Close();
			return picbyte;
		}

		private Image ByteToImg(string byteString) {
			byte[] imgBytes = Convert.FromBase64String(byteString);
			MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
			ms.Write(imgBytes, 0, imgBytes.Length);
			Image image = Image.FromStream(ms, true);
			return image;
		}
	}
}