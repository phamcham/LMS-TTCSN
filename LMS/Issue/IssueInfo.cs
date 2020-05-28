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

namespace LMS.Issue {

	public partial class IssueInfo : Form {

		public IssueInfo() {
			InitializeComponent();
		}

		private readonly BllReader bllReader = new BllReader();
		private readonly BllCard bllCard = new BllCard();
		private readonly BllIssue bllIssue = new BllIssue();
		private readonly BllStaff bllStaff = new BllStaff();
		private readonly BllReturn bllReturn = new BllReturn();
		private readonly BllBook bllBook = new BllBook();
		private DtoReader dtoReader = new DtoReader();
		private DtoCard dtoCard = new DtoCard();
		private DtoIssue dtoIssue = new DtoIssue();
		private DtoStaff dtoLendingStaff = new DtoStaff();
		private DtoReturn dtoReturn = new DtoReturn();

		private void LoadDGWReader() {
			dgwReaderList.DataSource = bllReader.GetDataTable(txtSearchString.Text, false);
		}

		private void LoadDGWIssueBook() {
			dgwIssueBook.DataSource = bllIssue.GetByCardID(dtoCard.CardID);
		}

		private void LoadDGWHistoryReturn() {
			dgwHistoryReturn.DataSource = bllIssue.GetHistoryReturnByCardID(dtoCard.CardID);
		}

		private void IssueInterface_Load(object sender, EventArgs e) {
			LoadDGWReader();
		}

		private void DgwReaderList_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (dgwReaderList.Rows.Count.Equals(0)) return;
			//reader
			string ReaderID = dgwReaderList.CurrentRow.Cells["ReaderID"].Value.ToString();
			dtoReader = bllReader.GetByID(ReaderID);
			txtReaderName.Text = dtoReader.ReaderName;
			txtGender.Text = StringHelper.Gender.GetByKey(dtoReader.Gender).Display;
			txtPhone.Text = dtoReader.Phone;
			//card
			string CardID = dgwReaderList.CurrentRow.Cells["CardID"].Value.ToString();
			dtoCard = bllCard.GetByID(CardID);
			txtCardID.Text = dtoCard.CardID;
			txtCardIssueDate.Text = dtoCard.IssueDate.ToString("dd / MM / yyyy");
			txtCardExpiration.Text = dtoCard.Expiration.ToString("dd / MM / yyyy");
			txtCardNotes.Text = dtoCard.Notes;
			//
			LoadDGWIssueBook();
			LoadDGWHistoryReturn();
			txtNoBookIssue.Text = dgwIssueBook.Rows.Count.ToString();
			//
			btnLending.Enabled = true;
			foreach (TextBox textBox in gboIssueInfo.Controls.OfType<TextBox>())
				textBox.ResetText();
			btnLost.Enabled = false;
			btnReturn.Enabled = false;
			btnReturnDetails.Enabled = false;

			GetImage();
		}

		private void TxtSearchString_TextChanged(object sender, EventArgs e) {
			LoadDGWReader();
		}

		private void DgwIssueBook_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (dgwIssueBook.Rows.Count.Equals(0)) return;
			string issueID = dgwIssueBook.CurrentRow.Cells["IssueID"].Value.ToString();
			dtoIssue = bllIssue.GetByID(issueID);
			txtIssueID.Text = dtoIssue.IssueID;
			txtLendingStaffID.Text = dtoIssue.StaffID;
			dtoLendingStaff = bllStaff.GetByID(dtoIssue.StaffID);
			txtLendingStaffName.Text = dtoLendingStaff.StaffName;
			txtIssueBookDate.Text = dtoIssue.IssueDate.ToString("dd / MM / yyyy");
			txtIssueNotes.Text = dtoIssue.Notes;
			//
			btnReturn.Enabled = true;
			btnLost.Enabled = true;
		}

		private void BtnLending_Click(object sender, EventArgs e) {
			Lending lendingBook = new Lending(dtoCard);
			lendingBook.ShowDialog();
			LoadDGWIssueBook();
			LoadDGWHistoryReturn();
			txtNoBookIssue.Text = dgwIssueBook.Rows.Count.ToString();
		}

		private void BtnReturn_Click(object sender, EventArgs e) {
			string bookID = dgwIssueBook.CurrentRow.Cells["BookID"].Value.ToString();
			DtoBook dtoBook = bllBook.GetByID(bookID);
			Return returnBook = new Return(dtoCard, dtoBook, dtoIssue);
			returnBook.ShowDialog();
			LoadDGWIssueBook();
			LoadDGWHistoryReturn();
			txtNoBookIssue.Text = dgwIssueBook.Rows.Count.ToString();
			btnReturn.Enabled = false;
			btnLost.Enabled = false;
			btnReturnDetails.Enabled = true;
		}

		private void BtnLost_Click(object sender, EventArgs e) {
			string bookID = dgwIssueBook.CurrentRow.Cells["BookID"].Value.ToString();
			DtoBook dtoBook = bllBook.GetByID(bookID);
			Lost lostBook = new Lost(dtoCard, dtoBook, dtoIssue);
			lostBook.ShowDialog();
			LoadDGWIssueBook();
			LoadDGWHistoryReturn();
			txtNoBookIssue.Text = dgwIssueBook.Rows.Count.ToString();
			btnReturn.Enabled = false;
			btnLost.Enabled = false;
			btnReturnDetails.Enabled = true;
		}

		private void DgwHistoryReturn_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (dgwHistoryReturn.Rows.Count.Equals(0)) return;
			string returnID = dgwHistoryReturn.CurrentRow.Cells["ReturnID"].Value.ToString();
			dtoReturn = bllReturn.GetByID(returnID);
			btnReturnDetails.Enabled = true;
		}

		private void BtnReturnDetails_Click(object sender, EventArgs e) {
			ReturnDetails returnDetails = new ReturnDetails(dtoCard, dtoReturn);
			returnDetails.ShowDialog();
		}

		private Image ByteToImg(string byteString) {
			byte[] imgBytes = Convert.FromBase64String(byteString);
			MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
			ms.Write(imgBytes, 0, imgBytes.Length);
			Image image = Image.FromStream(ms, true);
			return image;
		}

		private void GetImage() {
			pbxBookCover.Image = null;
			if (dtoReader.Avatar == null) return;
			pbxBookCover.Image = ByteToImg(Convert.ToBase64String(dtoReader.Avatar));
		}
	}
}