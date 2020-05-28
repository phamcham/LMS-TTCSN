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

namespace LMS.Staff {

	public partial class StaffInfo : Form {

		public StaffInfo() {
			InitializeComponent();
		}

		private readonly BllStaff bllStaff = new BllStaff();
		private DtoStaff dtoStaff = new DtoStaff();

		private void LoadDataGridView() {
			dgwStaffInfo.DataSource = bllStaff.GetDataTable(txtSearchString.Text, chkShowBlockedStaff.Checked);
		}

		private void StaffInfo_Load(object sender, EventArgs e) {
			LoadDataGridView();
		}

		private void DgwStaffInfo_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (dgwStaffInfo.Rows.Count.Equals(0)) return;
			// staff
			string staffID = dgwStaffInfo.CurrentRow.Cells["StaffID"].Value.ToString();
			dtoStaff = bllStaff.GetByID(staffID);
			txtStaffID.Text = dtoStaff.StaffID;
			txtDateOfBirth.Text = dtoStaff.DateOfBirth.ToString("dd/MM/yyyy");
			txtAddress.Text = dtoStaff.Address;
			txtEnable.Text = StringHelper.ActionStatus.GetByKey(dtoStaff.Status).Display;
			txtStaffName.Text = dtoStaff.StaffName;
			txtGender.Text = StringHelper.Gender.GetByKey(dtoStaff.Gender).Display;
			txtPhone.Text = dtoStaff.Phone;
			txtUserName.Text = dtoStaff.UserName;
			//
			btnUpdateStaff.Enabled = true;
			LoadImage();
		}

		private void BtnAddStaff_Click(object sender, EventArgs e) {
			Add addStaff = new Add();
			addStaff.ShowDialog();
			ReloadForm();
		}

		private void BtnUpdateStaff_Click(object sender, EventArgs e) {
			Update updateStaff = new Update(dtoStaff.UserName, dtoStaff);
			updateStaff.ShowDialog();
			ReloadForm();
		}

		private void LoadImage() {
			pbxAvatar.Image = null;
			if (dtoStaff.Avatar == null) return;
			pbxAvatar.Image = ByteToImg(Convert.ToBase64String(dtoStaff.Avatar));
		}

		private Image ByteToImg(string byteString) {
			byte[] imgBytes = Convert.FromBase64String(byteString);
			MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
			ms.Write(imgBytes, 0, imgBytes.Length);
			Image image = Image.FromStream(ms, true);
			return image;
		}

		private void TxtSearchString_TextChanged(object sender, EventArgs e) {
			LoadDataGridView();
		}

		private void ReloadForm() {
			Controls.Clear();
			InitializeComponent();
			LoadDataGridView();
		}
	}
}