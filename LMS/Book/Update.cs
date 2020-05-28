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

namespace LMS.Book {

	public partial class Update : Form {

		public Update(DtoBook dtoBook) {
			InitializeComponent();
			this.dtoBook = dtoBook;
		}

		#region Field

		private readonly DtoBook dtoBook = new DtoBook();
		private readonly BllBook bllBook = new BllBook();
		private readonly BllIssue bllIssue = new BllIssue();
		private readonly BllHistory bllHistory = new BllHistory();
		private string bookCoverFileName = string.Empty;

		#endregion Field

		private void CboEnable_Load() {
			List<StringHelper.KeyDisplayPair> items = new List<StringHelper.KeyDisplayPair>
			{
				StringHelper.Availability.Enable,
				StringHelper.Availability.Disable
			};
			cboEnable.DataSource = items;
			cboEnable.DisplayMember = "Display";
			cboEnable.ValueMember = "Key";
		}

		private void CboStatus_Load() {
			List<StringHelper.KeyDisplayPair> items = new List<StringHelper.KeyDisplayPair>
			{
				StringHelper.IsExist.Yes,
				StringHelper.IsExist.No
			};
			cboStatus.DataSource = items;
			cboStatus.DisplayMember = "Display";
			cboStatus.ValueMember = "Key";
		}

		private void UpdateBook_Load(object sender, EventArgs e) {
			CboEnable_Load();
			CboStatus_Load();
			LoadInfo();
			LoadImage();
		}

		private void LoadImage() {
			if (dtoBook.BookCover == null) return;
			pbxBookCover.Image = ByteToImg(Convert.ToBase64String(dtoBook.BookCover));
		}

		private void LoadInfo() {
			txtBookID.Text = dtoBook.BookID;
			txtBookName.Text = dtoBook.BookName;
			txtAuthorName.Text = dtoBook.AuthorName;
			txtPublisherName.Text = dtoBook.PublisherName;
			txtCategoryName.Text = dtoBook.CategoryName;
			txtPublishedYear.Text = dtoBook.PublishedYear.ToString();
			txtEditionNumber.Text = dtoBook.EditionNumber.ToString();
			txtPrice.Text = dtoBook.Price.ToString();
			txtISBN.Text = dtoBook.ISBN.ToString();
			txtNotes.Text = dtoBook.Notes;
			cboStatus.SelectedItem = StringHelper.IsExist.GetByKey(dtoBook.Status);
			cboEnable.SelectedItem = StringHelper.Availability.GetByKey(dtoBook.Availability);
			if (bllIssue.IsLent(dtoBook)) {
				cboStatus.Enabled = false;
				cboEnable.Enabled = false;
				txtCheckBorrowing.Text = StringHelper.IsLent.Yes.Display;
			}
			else {
				txtCheckBorrowing.Text = StringHelper.IsLent.No.Display;
			}
		}

		#region Check whether AddButton could be pressed

		private void CheckUpdatingBook() {
			btnUpdateBook.Enabled = true;
			if (String.IsNullOrWhiteSpace(txtBookName.Text)) btnUpdateBook.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtAuthorName.Text)) btnUpdateBook.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtPublisherName.Text)) btnUpdateBook.Enabled = false;
			if (String.IsNullOrWhiteSpace(txtCategoryName.Text)) btnUpdateBook.Enabled = false;
		}

		private void TxtBookName_TextChanged(object sender, EventArgs e) {
			CheckUpdatingBook();
		}

		private void TxtAuthorName_TextChanged(object sender, EventArgs e) {
			CheckUpdatingBook();
		}

		private void TxtPublisherName_TextChanged(object sender, EventArgs e) {
			CheckUpdatingBook();
		}

		private void TxtCategoryName_TextChanged(object sender, EventArgs e) {
			CheckUpdatingBook();
		}

		#endregion Check whether AddButton could be pressed

		#region Input only number in textbox

		private void TxtPublishedYear_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		private void TxtEditionNumber_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
		}

		#endregion Input only number in textbox

		private void SaveHistory() {
			DtoHistory dtoHistory = new DtoHistory(
					bllHistory.GetNextID(),
					StringHelper.HistoryStatus.Update.Key,
					dtoBook.BookID,
					Session.StaffWorking.StaffID,
					DateTime.Now);
			if (!bllHistory.Add(dtoHistory)) MessageBox.Show("Không thể ghi lịch sử");
		}

		private void BtnUpdateBook_Click(object sender, EventArgs e) {
			GetInfo();
			GetImage();
			UpdateBook();
		}

		private void UpdateBook() {
			if (bllBook.Update(dtoBook)) {
				MessageBox.Show(StringHelper.Notification.Success);

				SaveHistory();

				Close();
			}
			else {
				MessageBox.Show(StringHelper.Notification.SomethingWentWrong);
			}
		}

		private void GetInfo() {
			dtoBook.BookName = txtBookName.Text;
			dtoBook.AuthorName = txtAuthorName.Text;
			dtoBook.PublisherName = txtPublisherName.Text;
			dtoBook.CategoryName = txtCategoryName.Text;
			dtoBook.PublishedYear = int.Parse(txtPublishedYear.Text);
			dtoBook.EditionNumber = int.Parse(txtEditionNumber.Text);
			dtoBook.Price = int.Parse(txtPrice.Text);
			dtoBook.ISBN = txtISBN.Text;
			dtoBook.Notes = txtNotes.Text;
			dtoBook.Status = StringHelper.KeyDisplayPair.Parse(cboStatus.SelectedItem).Key;
			dtoBook.Availability = StringHelper.KeyDisplayPair.Parse(cboEnable.SelectedItem).Key;
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void CboStatus_SelectedIndexChanged(object sender, EventArgs e) {
			if (StringHelper.IsExist.Yes.Equals(cboStatus.SelectedItem)) {
				cboEnable.Enabled = true;
			}
			else {
				cboEnable.SelectedItem = StringHelper.Availability.Disable;
				cboEnable.Enabled = false;
			}
		}

		#region Extension

		private void GetImage() {
			if (string.IsNullOrEmpty(bookCoverFileName)) return;
			dtoBook.BookCover = ConverImgToByte();
		}

		private void BtnSelectPhoto_Click(object sender, EventArgs e) {
			openFileDialog.ShowDialog();
		}

		private void OpenFileDialog_FileOk(object sender, CancelEventArgs e) {
			bookCoverFileName = openFileDialog.FileName;
			pbxBookCover.Image = Image.FromFile(bookCoverFileName);
		}

		private byte[] ConverImgToByte() {
			FileStream fs = new FileStream(bookCoverFileName, FileMode.Open, FileAccess.Read);
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

		#endregion Extension
	}
}