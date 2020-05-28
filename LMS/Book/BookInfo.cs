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

	public partial class BookInfo : Form {

		public BookInfo() {
			InitializeComponent();
		}

		#region Field

		private readonly BllBook bllBook = new BllBook();
		private DtoBook dtoBook = new DtoBook();

		#endregion Field

		private void BookInfo_Load(object sender, EventArgs e) {
			LoadDataGridView();
		}

		private void DgwBookInfo_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (dgwBookInfo.Rows.Count.Equals(0)) return;
			GetInfo();
			btnUpdateBook.Enabled = true;
			GetImage();
		}

		private void GetInfo() {
			string bookID = dgwBookInfo.CurrentRow.Cells["BookID"].Value.ToString();
			dtoBook = bllBook.GetByID(bookID);
			txtBookID.Text = dtoBook.BookID;
			txtBookName.Text = dtoBook.BookName;
			txtAuthorName.Text = dtoBook.AuthorName;
			txtPublisherName.Text = dtoBook.PublisherName;
			txtCategory.Text = dtoBook.CategoryName;
			txtPublishedYear.Text = dtoBook.PublishedYear.ToString();
			txtEditionNumber.Text = dtoBook.EditionNumber.ToString();
			txtStatus.Text = StringHelper.IsExist.GetByKey(dtoBook.Status).Display;
			txtPrice.Text = dtoBook.Price.ToString();
			txtISBN.Text = dtoBook.ISBN;
			txtNotes.Text = dtoBook.Notes;
			lblEnable.Visible = dtoBook.Availability.Equals(StringHelper.Availability.Disable.Key);
		}

		private void BtnAddBook_Click(object sender, EventArgs e) {
			Add addBook = new Add();
			addBook.ShowDialog();
			ReloadForm();
		}

		private void BtnUpdateBook_Click(object sender, EventArgs e) {
			Update updateBook = new Update(dtoBook);
			updateBook.ShowDialog();
			ReloadForm();
		}

		#region Refresh

		private void LoadDataGridView() {
			dgwBookInfo.DataSource = bllBook.GetDataTable(txtSearchString.Text, chkShowDisabledBook.Checked, chkShowLostBook.Checked);
		}

		private void ChkShowLostBook_CheckedChanged(object sender, EventArgs e) {
			LoadDataGridView();
		}

		private void TxtSearchString_TextChanged(object sender, EventArgs e) {
			LoadDataGridView();
		}

		private void ChkShowDisabledBook_CheckedChanged(object sender, EventArgs e) {
			LoadDataGridView();
		}

		#endregion Refresh

		#region Extension

		private void ReloadForm() {
			Controls.Clear();
			InitializeComponent();
			LoadDataGridView();
		}

		private void GetImage() {
			pbxBookCover.Image = null;
			if (dtoBook.BookCover == null) return;
			pbxBookCover.Image = ByteToImg(Convert.ToBase64String(dtoBook.BookCover));
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