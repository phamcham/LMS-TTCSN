using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS {

	public partial class Main : Form {

		public Main(DtoStaff dtoStaff) {
			InitializeComponent();
			Session.StaffWorking = dtoStaff;
		}

		private Form activeForm;

		#region Extension

		private void OpenChildForm(Form childForm) {
			if (activeForm != null) activeForm.Close();
			activeForm = childForm;
			childForm.Dock = DockStyle.Fill;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			pnlDisplayPane.Tag = childForm;
			pnlDisplayPane.Controls.Add(childForm);
			childForm.BringToFront();
			childForm.Show();
		}

		private void LoadImage() {
			pbxAvatar.Image = null;
			if (Session.StaffWorking.Avatar == null) return;
			LoadImage();
		}

		private Image ByteToImg(string byteString) {
			byte[] imgBytes = Convert.FromBase64String(byteString);
			MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
			ms.Write(imgBytes, 0, imgBytes.Length);
			Image image = Image.FromStream(ms, true);
			return image;
		}

		#endregion Extension

		private void BtnBook_Click(object sender, EventArgs e) {
			Book.BookInfo bookInfo = new Book.BookInfo();
			OpenChildForm(bookInfo);
			ChangeButtonColor(sender as Button);
		}

		private void BtnReader_Click(object sender, EventArgs e) {
			Reader.ReaderInfo readerInfo = new Reader.ReaderInfo();
			OpenChildForm(readerInfo);
			ChangeButtonColor(sender as Button);
		}

		private void BtnStaff_Click(object sender, EventArgs e) {
			Staff.StaffInfo staffInfo = new Staff.StaffInfo();
			OpenChildForm(staffInfo);
			ChangeButtonColor(sender as Button);
		}

		private void Main_Load(object sender, EventArgs e) {
			txtStaffName.Text = Session.StaffWorking.StaffName;

			pbxAvatar.Image = ByteToImg(Convert.ToBase64String(Session.StaffWorking.Avatar));

			BtnStatistic_Click(btnStatistic, null);
		}

		private void BtnIssueBook_Click(object sender, EventArgs e) {
			Issue.IssueInfo issueInterface = new Issue.IssueInfo();
			OpenChildForm(issueInterface);
			ChangeButtonColor(sender as Button);
		}

		private void BtnLogout_Click(object sender, EventArgs e) {
			Close();
			Thread thread = new Thread(
			delegate () {
				Application.Run(new Login());
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		private void BtnStatistic_Click(object sender, EventArgs e) {
			Statistic.Statistic statistic = new Statistic.Statistic();
			OpenChildForm(statistic);
			ChangeButtonColor(sender as Button);
		}

		private void ChangeButtonColor(Button clicked) {
			foreach (Button button in panelMenu.Controls.OfType<Button>()) {
				button.BackColor = Color.LightSlateGray;
			}
			clicked.BackColor = Color.WhiteSmoke;
		}

		private void LinkAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			AboutUs aboutUs = new AboutUs();
			aboutUs.ShowDialog();
		}
	}
}