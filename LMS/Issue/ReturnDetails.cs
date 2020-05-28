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

	public partial class ReturnDetails : Form {

		public ReturnDetails(DtoCard dtoCard, DtoReturn dtoReturn) {
			InitializeComponent();
			this.dtoCard = dtoCard;
			this.dtoReturn = dtoReturn;
		}

		private readonly DtoCard dtoCard = new DtoCard();
		private DtoBook dtoBook = new DtoBook();
		private DtoIssue dtoIssue = new DtoIssue();
		private readonly DtoReturn dtoReturn = new DtoReturn();
		private readonly BllBook bllBook = new BllBook();
		private readonly BllIssue bllIssue = new BllIssue();

		private void ReturnDetails_Load(object sender, EventArgs e) {
			dtoIssue = bllIssue.GetByID(dtoReturn.IssueID);
			dtoBook = bllBook.GetByID(dtoIssue.BookID);
			txtReturnID.Text = dtoReturn.ReturnID;
			txtCardID.Text = dtoCard.CardID;
			txtStaffID.Text = Session.StaffWorking.StaffID;
			txtStaffName.Text = Session.StaffWorking.StaffName;
			txtBookID.Text = dtoBook.BookID;
			txtBookName.Text = dtoBook.BookName;
			txtAuthorName.Text = dtoBook.AuthorName;
			txtPublisherName.Text = dtoBook.PublisherName;
			txtISBN.Text = dtoBook.ISBN;
			txtIssueDate.Text = dtoIssue.IssueDate.ToString("dd / MM / yyyy");
			txtReturnDate.Text = dtoReturn.ReturnDate.ToString("dd / MM / yyyy");
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}
	}
}