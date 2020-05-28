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

	public partial class Lending : Form {

		public Lending(DtoCard dtoCard) {
			InitializeComponent();
			this.dtoCard = dtoCard;
		}

		private readonly DtoIssue dtoIssue = new DtoIssue();
		private readonly DtoCard dtoCard = new DtoCard();
		private DtoBook dtoBook = new DtoBook();
		private readonly BllIssue bllIssue = new BllIssue();
		private readonly BllBook bllBook = new BllBook();
		private readonly BllReturn bllReturn = new BllReturn();
		private DtoBook dtoSearchBook = new DtoBook();

		private void LendingBook_Load(object sender, EventArgs e) {
			Size = new Size(413, 690);

			txtIssueID.Text = dtoIssue.IssueID = bllIssue.GetNextID();
			txtCardID.Text = dtoCard.CardID;
			txtStaffID.Text = Session.StaffWorking.StaffID;
			txtStaffName.Text = Session.StaffWorking.StaffName;

			dgwBookData.DataSource = bllBook.GetDataTable(txtSearchString.Text, false, false);
		}

		private void TxtBookID_TextChanged(object sender, EventArgs e) {
			btnLend.Enabled = bllBook.TryGetByID(txtBookID.Text, out dtoBook);
			txtBookName.Text = dtoBook.BookName;
			txtAuthorName.Text = dtoBook.AuthorName;
			txtPublisherName.Text = dtoBook.PublisherName;
			txtISBN.Text = dtoBook.ISBN;
			if (btnLend.Enabled) {
				if (bllBook.IsLost(dtoBook)) {
					txtStatus.Text = StringHelper.IsExist.No.Display;
					btnLend.Enabled = false;
				}
				else if (bllBook.IsEnabled(dtoBook)) {
					txtStatus.Text = StringHelper.Availability.Disable.Display;
					btnLend.Enabled = false;
				}
				else if (bllIssue.IsLent(dtoBook)) {
					txtStatus.Text = StringHelper.IsLent.Yes.Display;
					btnLend.Enabled = false;
				}
				else {
					txtStatus.Text = StringHelper.Availability.Enable.Display;
				}
			}
			else {
				txtStatus.ResetText();
			}
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void ChkSetIssueDateIsToday_CheckedChanged(object sender, EventArgs e) {
			if (chkSetIssueDateIsToday.Checked) dtpIssueDate.Value = DateTime.Today;
		}

		private void DtpIssueDate_ValueChanged(object sender, EventArgs e) {
			chkSetIssueDateIsToday.Checked = (dtpIssueDate.Value == DateTime.Today);
		}

		private void SaveHistory() {
			BllHistory bllHistory = new BllHistory();
			DtoHistory dtoHistory = new DtoHistory(
					bllHistory.GetNextID(),
					StringHelper.HistoryStatus.Lend.Key,
					dtoBook.BookID,
					Session.StaffWorking.StaffID,
					DateTime.Now);
			if (!bllHistory.Add(dtoHistory)) MessageBox.Show("Không thể ghi lịch sử");
		}

		private void BtnLend_Click(object sender, EventArgs e) {
			dtoIssue.CardID = dtoCard.CardID;
			dtoIssue.StaffID = Session.StaffWorking.StaffID;
			dtoIssue.BookID = dtoBook.BookID;
			dtoIssue.IssueDate = dtpIssueDate.Value;
			dtoIssue.Notes = txtNotes.Text;
			if (bllIssue.Add(dtoIssue)) {
				DtoReturn dtoReturn = new DtoReturn(
					bllReturn.GetNextID(),
					dtoIssue.IssueID,
					Session.StaffWorking.StaffID,
					0,
					DateTime.Now);
				if (bllReturn.Add(dtoReturn)) {
					MessageBox.Show(StringHelper.Notification.Success);
					SaveHistory();
					Close();
				}
			}
			else {
				MessageBox.Show(StringHelper.Notification.SomethingWentWrong);
			}
		}

		private void BtnSearchBook_Click(object sender, EventArgs e) {
			Size = new Size(959, 690);
		}

		private void DgwBookData_CellClick(object sender, DataGridViewCellEventArgs e) {
			string bookID = dgwBookData.CurrentRow.Cells["BookID"].Value.ToString();
			dtoSearchBook = bllBook.GetByID(bookID);

			txtSearchBookID.Text = dtoSearchBook.BookID;
			txtSearchBookName.Text = dtoSearchBook.BookName;
			txtSearchAuthorName.Text = dtoSearchBook.AuthorName;
			txtSearchPublisherName.Text = dtoSearchBook.PublisherName;
			txtSearchISBN.Text = dtoSearchBook.ISBN;

			GetImage();
		}

		private void BtnSelect_Click(object sender, EventArgs e) {
			txtBookID.Text = dtoSearchBook.BookID;
		}

		private void BtnMinimize_Click(object sender, EventArgs e) {
			Size = new Size(413, 690);
		}

		private void GetImage() {
			pbxBookCover.Image = null;
			if (dtoSearchBook.BookCover == null) return;
			pbxBookCover.Image = ByteToImg(Convert.ToBase64String(dtoSearchBook.BookCover));
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