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

namespace LMS.Reader {

	public partial class Add : Form {

		public Add() {
			InitializeComponent();
		}

		private readonly DtoReader dtoReader = new DtoReader();
		private readonly DtoCard dtoCard = new DtoCard();
		private readonly BllReader bllReader = new BllReader();
		private readonly BllCard bllCard = new BllCard();
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

		private void AddReader_Load(object sender, EventArgs e) {
			CboGender_Load();

			txtReaderID.Text = dtoReader.ReaderID = bllReader.GetNextID();
			txtCardID.Text = dtoCard.CardID = dtoReader.CardID = bllCard.GetNextID();
			//cboGender.SelectedItem = "Nam";
			cboGender.SelectedItem = StringHelper.Gender.Male;
		}

		private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		private void TxtDuration_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		private void BtnSelectDurationIs3_Click(object sender, EventArgs e) {
			txtDuration.Text = 3.ToString();
		}

		private void BtnSelectDurationIs6_Click(object sender, EventArgs e) {
			txtDuration.Text = 6.ToString();
		}

		private void BtnSelectDurationIs12_Click(object sender, EventArgs e) {
			txtDuration.Text = 12.ToString();
		}

		private void BtnSelectIssueDateIsOnToday_Click(object sender, EventArgs e) {
			dtpIssueDate.Value = DateTime.Now;
		}

		private void CheckAddingReader() {
			btnAddReader.Enabled = true;
			if (String.IsNullOrWhiteSpace(txtReaderName.Text)) btnAddReader.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtPhone.Text)) btnAddReader.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtDuration.Text)) btnAddReader.Enabled = false;
		}

		private void TxtReaderName_TextChanged(object sender, EventArgs e) {
			CheckAddingReader();
		}

		private void TxtPhone_TextChanged(object sender, EventArgs e) {
			CheckAddingReader();
		}

		private void TxtDuration_TextChanged(object sender, EventArgs e) {
			CheckAddingReader();
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void SaveHistory() {
			DtoHistory dtoHistory = new DtoHistory(
					bllHistory.GetNextID(),
					StringHelper.HistoryStatus.Add.Key,
					dtoReader.ReaderID,
					Session.StaffWorking.StaffID,
					DateTime.Now);
			if (!bllHistory.Add(dtoHistory)) MessageBox.Show("Không thể ghi lịch sử");
		}

		private void BtnAddReader_Click(object sender, EventArgs e) {
			GetInfo();
			GetImage();
			AddReader();
		}

		private void AddReader() {
			if (bllCard.Add(dtoCard)) {
				if (bllReader.Add(dtoReader)) {
					MessageBox.Show(StringHelper.Notification.Success);
					SaveHistory();
					Close();
				}
				else {
					MessageBox.Show("Toang");
				}
			}
			else {
				MessageBox.Show(StringHelper.Notification.SomethingWentWrong);
			}
		}

		private void GetInfo() {
			dtoCard.IssueDate = dtpIssueDate.Value;
			dtoCard.Expiration = dtoCard.IssueDate.AddMonths(int.Parse(txtDuration.Text));
			dtoCard.Notes = txtNotes.Text;
			dtoReader.ReaderName = txtReaderName.Text;
			dtoReader.Gender = StringHelper.KeyDisplayPair.Parse(cboGender.SelectedItem).Key;
			dtoReader.DateOfBirth = dtpDateOfBirth.Value;
			dtoReader.Phone = txtPhone.Text;
			dtoReader.Address = txtAddress.Text;
		}

		private void GetImage() {
			if (string.IsNullOrEmpty(avatarFileName)) {
				return;
			}
			dtoReader.Avatar = ConverImgToByte();
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