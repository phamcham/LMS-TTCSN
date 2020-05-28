using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL {

	public partial class AskToConnect : Form {

		public AskToConnect() {
			InitializeComponent();
		}

		private void BtnConnect_Click(object sender, EventArgs e) {
			StringHelper.serverName = cboServerNames.Text;
			Properties.Settings.Default.ServerName = StringHelper.serverName;
			Properties.Settings.Default.Save();
			string connectionString = "Data Source=" + StringHelper.serverName + @";Initial Catalog=LMS;Integrated Security=True";
			try {
				using (var test = new SqlConnection(connectionString)) {
					test.Open();
				}
				MessageBox.Show("Kết nối tới server name " + StringHelper.serverName + " thành công");
			}
			catch (Exception) {
				MessageBox.Show("Thất bại");
			}
			Close();
		}

		private void AskToConnect_Load(object sender, EventArgs e) {
			Size = MinimumSize;
		}

		private void BtnWhatTheFuck_Click(object sender, EventArgs e) {
			Size = MaximumSize;
		}

		private void Button1_Click(object sender, EventArgs e) {
			DialogResult dialogResult = MessageBox.Show("Đuôi server name có \\SQLEXPRESS hay không?\nNói dối fail cả chương trình!", "\\SQLEXPRESS ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			StringHelper.serverName = Properties.Settings.Default.ServerName;
			string connectionString;
			if (dialogResult == DialogResult.Yes)
				connectionString = @"Data Source=.\SQLEXPRESS; Integrated Security=True;";
			else
				connectionString = @"Data Source=.; Integrated Security=True;";
			using (SqlConnection sqlConnection = new SqlConnection(connectionString)) {
				sqlConnection.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT @@SERVERNAME", sqlConnection)) {
					using (SqlDataReader dr = cmd.ExecuteReader()) {
						while (dr.Read()) {
							cboServerNames.Items.Add(dr.GetString(0));
						}
					}
				}
			}
			if (cboServerNames.Items.Count > 0)
				cboServerNames.SelectedIndex = 0;
		}
	}
}