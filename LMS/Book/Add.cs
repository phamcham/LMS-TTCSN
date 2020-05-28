using BLL;
using DTO;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LMS.Book {

	public partial class Add : Form {

		public Add() {
			InitializeComponent();
		}

		#region Field

		private readonly DtoBook dtoBook = new DtoBook();
		private readonly BllBook bllBook = new BllBook();
		private readonly BllHistory bllHistory = new BllHistory();
		private string bookCoverFileName = string.Empty;

		#endregion Field

		private void BtnAddBook_Click(object sender, EventArgs e) {
			GetInfo();
			GetImage();
			AddBook();
		}

		private void AddBook() {
			if (bllBook.Add(dtoBook)) {
				MessageBox.Show(StringHelper.Notification.Success);
				SaveHistory();
				Close();
			}
			else {
				MessageBox.Show(StringHelper.Notification.SomethingWentWrong);
			}
		}

		private void AddBook_Load(object sender, EventArgs e) {
			txtBookID.Text = dtoBook.BookID = bllBook.GetNextID();
		}

		private void SaveHistory() {
			DtoHistory dtoHistory = new DtoHistory(
					bllHistory.GetNextID(),
					StringHelper.HistoryStatus.Add.Key,
					dtoBook.BookID,
					Session.StaffWorking.StaffID,
					DateTime.Now);
			if (!bllHistory.Add(dtoHistory)) MessageBox.Show("Không thể ghi lịch sử");
		}

		private void GetInfo() {
			dtoBook.BookName = txtBookName.Text;
			dtoBook.AuthorName = txtAuthorName.Text;
			dtoBook.PublisherName = txtPublisherName.Text;
			dtoBook.CategoryName = txtCategoryName.Text;
			if (string.IsNullOrEmpty(txtPublishedYear.Text)) dtoBook.PublishedYear = 0;
			else dtoBook.PublishedYear = int.Parse(txtPublishedYear.Text);
			if (string.IsNullOrEmpty(txtEditionNumber.Text)) dtoBook.EditionNumber = 1;
			else dtoBook.EditionNumber = int.Parse(txtEditionNumber.Text);
			if (string.IsNullOrEmpty(txtPrice.Text)) dtoBook.Price = 0;
			else dtoBook.Price = int.Parse(txtPrice.Text);
			dtoBook.ISBN = txtISBN.Text;
			dtoBook.Notes = txtNotes.Text;
			dtoBook.Status = StringHelper.IsExist.Yes.Key;
			dtoBook.Availability = StringHelper.Availability.Enable.Key;
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		#region Check whether AddButton could be pressed

		private void CheckAddingBook() {
			btnAddBook.Enabled = true;
			if (String.IsNullOrWhiteSpace(txtBookName.Text)) btnAddBook.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtAuthorName.Text)) btnAddBook.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtPublisherName.Text)) btnAddBook.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtCategoryName.Text)) btnAddBook.Enabled = false;
		}

		private void TxtBookName_TextChanged(object sender, EventArgs e) {
			CheckAddingBook();
		}

		private void TxtAuthorName_TextChanged(object sender, EventArgs e) {
			CheckAddingBook();
		}

		private void TxtPublisherName_TextChanged(object sender, EventArgs e) {
			CheckAddingBook();
		}

		private void TxtCategoryName_TextChanged(object sender, EventArgs e) {
			CheckAddingBook();
		}

		#endregion Check whether AddButton could be pressed

		#region Input only number in textbox

		private void TxtPublishedYear_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		private void TxtEditionNumber_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		#endregion Input only number in textbox

		#region Extension

		private void GetImage() {
			if (string.IsNullOrEmpty(bookCoverFileName)) {
				return;
			}
			dtoBook.BookCover = ConverImgToByte();
		}

		private void BtnSelectPhoto_Click(object sender, EventArgs e) {
			ofdOpenFile.ShowDialog();
		}

		private void OpenFileDialog_FileOk(object sender, CancelEventArgs e) {
			string filePath = ofdOpenFile.FileName;
			pbxBookCover.Image = Image.FromFile(filePath);
			bookCoverFileName = ofdOpenFile.FileName;
		}

		private byte[] ConverImgToByte() {
			FileStream fs = new FileStream(bookCoverFileName, FileMode.Open, FileAccess.Read);
			byte[] picbyte = new byte[fs.Length];
			fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
			fs.Close();
			return picbyte;
		}

		#endregion Extension
	}
}