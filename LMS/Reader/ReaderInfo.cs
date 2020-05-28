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

	public partial class ReaderInfo : Form {

		public ReaderInfo() {
			InitializeComponent();
		}

		private DtoReader dtoReader = new DtoReader();
		private DtoCard dtoCard = new DtoCard();
		private readonly BllReader bllReader = new BllReader();
		private readonly BllCard bllCard = new BllCard();

		private void LoadDataGridView() {
			dgwReaderInfo.DataSource = bllReader.GetDataTable(txtSearchString.Text, chkShowBlockedReader.Checked);
		}

		private void ReaderInfo_Load(object sender, EventArgs e) {
			LoadDataGridView();
		}

		private void DgwReaderInfo_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (dgwReaderInfo.Rows.Count.Equals(0)) return;
			// reader
			string readerID = dgwReaderInfo.CurrentRow.Cells["ReaderID"].Value.ToString();
			dtoReader = bllReader.GetByID(readerID);
			txtReaderID.Text = dtoReader.ReaderID;
			txtDateOfBirth.Text = dtoReader.DateOfBirth.ToString("dd/MM/yyyy");
			txtAddress.Text = dtoReader.Address;
			txtEnable.Text = StringHelper.ActionStatus.GetByKey(dtoReader.Status).Display;
			txtReaderName.Text = dtoReader.ReaderName;
			txtGender.Text = StringHelper.Gender.GetByKey(dtoReader.Gender).Display;
			txtPhone.Text = dtoReader.Phone;
			// card
			string cardID = dgwReaderInfo.CurrentRow.Cells["CardID"].Value.ToString();
			dtoCard = bllCard.GetByID(cardID);
			txtCardID.Text = dtoCard.CardID;
			txtIssueDate.Text = dtoCard.IssueDate.ToString("dd/MM/yyyy");
			txtExpiration.Text = dtoCard.Expiration.ToString("dd/MM/yyyy");
			txtNotes.Text = dtoCard.Notes;
			//
			btnUpdateReader.Enabled = true;
			LoadImage();
		}

		private void ReloadForm() {
			Controls.Clear();
			InitializeComponent();
			LoadDataGridView();
		}

		private void BtnAddReader_Click(object sender, EventArgs e) {
			Add addReader = new Add();
			addReader.ShowDialog();
			ReloadForm();
		}

		private void BtnUpdateReader_Click(object sender, EventArgs e) {
			Update updateReader = new Update(dtoReader, dtoCard);
			updateReader.ShowDialog();
			ReloadForm();
		}

		private void ChkShowBlockedReader_CheckedChanged(object sender, EventArgs e) {
			LoadDataGridView();
		}

		private void TxtSearchString_TextChanged(object sender, EventArgs e) {
			LoadDataGridView();
		}

		private void LoadImage() {
			pbxAvatar.Image = null;
			if (dtoReader.Avatar == null) return;
			pbxAvatar.Image = ByteToImg(Convert.ToBase64String(dtoReader.Avatar));
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