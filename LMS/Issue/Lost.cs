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

	public partial class Lost : Form {

		public Lost(DtoCard dtoCard, DtoBook dtoBook, DtoIssue dtoIssue) {
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
		private readonly BllBook bllBook = new BllBook();

		private void LostBook_Load(object sender, EventArgs e) {
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

			txtPrice.Text = dtoBook.Price.ToString();
			txtFine.Text = dtoBook.Price.ToString(); // need some update
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void BtnLost_Click(object sender, EventArgs e) {
			//dtoBook.Enable = "Vô hiệu hoá";
			dtoBook.Availability = StringHelper.Availability.Disable.Key;
			//dtoBook.Status = "Mất";
			dtoBook.Status = StringHelper.IsExist.No.Key;
			if (bllIssue.ReturnBook(dtoReturn)) {
				if (bllBook.Update(dtoBook)) {
					//MessageBox.Show("Thành công");
					MessageBox.Show(StringHelper.Notification.Success);
					Close();
				}
				else {
				}
			}
			else {
				//MessageBox.Show("Có lỗi xảy ra");
				MessageBox.Show(StringHelper.Notification.SomethingWentWrong);
			}
		}
	}
}