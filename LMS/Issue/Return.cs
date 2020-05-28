using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Issue {

	public partial class Return : Form {

		public Return(DtoCard dtoCard, DtoBook dtoBook, DtoIssue dtoIssue) {
			InitializeComponent();
			this.dtoCard = dtoCard;
			this.dtoBook = dtoBook;
			this.dtoIssue = dtoIssue;
		}

		private readonly DtoCard dtoCard = new DtoCard();
		private readonly DtoBook dtoBook = new DtoBook();
		private readonly DtoIssue dtoIssue = new DtoIssue();
		private DtoReturn dtoReturn = new DtoReturn();
		private readonly BllReturn bllReturn = new BllReturn();
		private readonly BllIssue bllIssue = new BllIssue();

		private void ReturnBook_Load(object sender, EventArgs e) {
			txtReturnID.Text = bllReturn.GetNextID();
			txtCardID.Text = dtoCard.CardID;
			txtStaffID.Text = Session.StaffWorking.StaffID;
			txtStaffName.Text = Session.StaffWorking.StaffName;
			txtBookID.Text = dtoBook.BookID;
			txtBookName.Text = dtoBook.BookName;
			txtAuthorName.Text = dtoBook.AuthorName;
			txtPublisherName.Text = dtoBook.PublisherName;
			txtISBN.Text = dtoBook.ISBN;
			txtIssueDate.Text = dtoIssue.IssueDate.ToString("dd / MM / yyyy");
			txtReturnDate.Text = DateTime.Today.ToString("dd / MM / yyyy");
			//
			dtoReturn = bllReturn.GetByIssueID(dtoIssue.IssueID);
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void SaveHistory() {
			BllHistory bllHistory = new BllHistory();
			DtoHistory dtoHistory = new DtoHistory(
					bllHistory.GetNextID(),
					StringHelper.HistoryStatus.Return.Key,
					dtoBook.BookID,
					Session.StaffWorking.StaffID,
					DateTime.Now);
			if (!bllHistory.Add(dtoHistory)) MessageBox.Show("Không thể ghi lịch sử");
		}

		private void BtnReturn_Click(object sender, EventArgs e) {
			if (bllIssue.ReturnBook(dtoReturn)) {
				MessageBox.Show(StringHelper.Notification.Success);
				SaveHistory();
				Close();
			}
			else {
				MessageBox.Show(StringHelper.Notification.SomethingWentWrong);
			}
		}
	}
}