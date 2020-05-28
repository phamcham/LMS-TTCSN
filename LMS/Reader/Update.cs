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

	public partial class Update : Form {

		public Update(DtoReader dtoReader, DtoCard dtoCard) {
			InitializeComponent();
			this.dtoReader = dtoReader;
			this.dtoCard = dtoCard;
		}

		private readonly DtoReader dtoReader = new DtoReader();
		private readonly DtoCard dtoCard = new DtoCard();
		private int duration = 0;
		private readonly BllReader bllReader = new BllReader();
		private readonly BllCard bllCard = new BllCard();
		private readonly BllIssue bllIssue = new BllIssue();
		private readonly BllHistory bllHistory = new BllHistory();
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

		private void CboEnable_Load() {
			List<StringHelper.KeyDisplayPair> items = new List<StringHelper.KeyDisplayPair>
			{
				StringHelper.ActionStatus.Active,
				StringHelper.ActionStatus.Blocked
			};
			cboEnable.DataSource = items;
			cboEnable.DisplayMember = "Display";
			cboEnable.ValueMember = "Key";
		}

		private void UpdateReader_Load(object sender, EventArgs e) {
			CboGender_Load();
			CboEnable_Load();
			LoadInfo();
			LoadImage();
		}

		private void LoadInfo() {
			txtReaderID.Text = dtoReader.ReaderID;
			txtReaderName.Text = dtoReader.ReaderName;
			cboGender.SelectedItem = StringHelper.Gender.GetByKey(dtoReader.Gender);
			dtpDateOfBirth.Value = dtoReader.DateOfBirth;
			txtPhone.Text = dtoReader.Phone;
			txtAddress.Text = dtoReader.Address;
			cboEnable.SelectedItem = StringHelper.Availability.GetByKey(dtoReader.Status);
			txtCardID.Text = dtoCard.CardID;
			dtpIssueDate.Value = dtoCard.IssueDate;
			txtExpiration.Text = dtoCard.Expiration.ToString("dd / MM / yyyy");
			duration = 12 * (dtoCard.Expiration.Year - dtoCard.IssueDate.Year) + (dtoCard.Expiration.Month - dtoCard.IssueDate.Month);
			txtDuration.Text = duration.ToString();
			txtNotes.Text = dtoCard.Notes;
			//
			if (bllIssue.GetByCardID(dtoCard.CardID).Rows.Count > 0) {
				cboEnable.Enabled = false;
				labelCanEditStatus.Visible = true;
			}
		}

		private void TxtDuration_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		private void CheckUpdatingReader() {
			btnUpdateReader.Enabled = true;
			if (String.IsNullOrWhiteSpace(txtReaderName.Text)) btnUpdateReader.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtPhone.Text)) btnUpdateReader.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtDuration.Text)) btnUpdateReader.Enabled = false;
		}

		private void TxtReaderName_TextChanged(object sender, EventArgs e) {
			CheckUpdatingReader();
		}

		private void TxtPhone_TextChanged(object sender, EventArgs e) {
			CheckUpdatingReader();
		}

		private void TxtDuration_TextChanged(object sender, EventArgs e) {
			CheckUpdatingReader();
			if (String.IsNullOrEmpty(txtDuration.Text)) txtExpiration.Text = String.Empty;
			else txtExpiration.Text = dtpIssueDate.Value.AddMonths(int.Parse(txtDuration.Text)).ToString("dd / MM / yyyy");
		}

		private void SaveHistory() {
			DtoHistory dtoHistory = new DtoHistory(
					bllHistory.GetNextID(),
					StringHelper.HistoryStatus.Update.Key,
					dtoReader.ReaderID,
					Session.StaffWorking.StaffID,
					DateTime.Now);
			if (!bllHistory.Add(dtoHistory)) MessageBox.Show("Không thể ghi lịch sử");
		}

		private void BtnUpdateReader_Click(object sender, EventArgs e) {
			GetInfo();
			GetImage();
			UpdateReader();
		}

		private void UpdateReader() {
			if (bllCard.Update(dtoCard)) {
				if (bllReader.Update(dtoReader)) {
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
			dtoCard.IssueDate = dtpIssueDate.Value;
			dtoCard.Expiration = dtoCard.IssueDate.AddMonths(int.Parse(txtDuration.Text));
			dtoCard.Notes = txtNotes.Text;
			dtoReader.ReaderName = txtReaderName.Text;
			dtoReader.Gender = StringHelper.KeyDisplayPair.Parse(cboGender.SelectedItem).Key;
			dtoReader.DateOfBirth = dtpDateOfBirth.Value;
			dtoReader.Phone = txtPhone.Text;
			dtoReader.Address = txtAddress.Text;
			dtoReader.Status = StringHelper.KeyDisplayPair.Parse(cboEnable.SelectedItem).Key;
		}

		private void DtpIssueDate_ValueChanged(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(txtDuration.Text)) txtExpiration.Text = String.Empty;
			else txtExpiration.Text = dtpIssueDate.Value.AddMonths(int.Parse(txtDuration.Text)).ToString("dd / MM / yyyy");
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void LoadImage() {
			if (dtoReader.Avatar == null) return;
			pbxAvatar.Image = ByteToImg(Convert.ToBase64String(dtoReader.Avatar));
		}

		private void GetImage() {
			if (string.IsNullOrEmpty(AvatarFileName)) return;
			dtoReader.Avatar = ConverImgToByte();
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