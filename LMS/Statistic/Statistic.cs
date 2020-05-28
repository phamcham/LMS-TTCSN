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
using System.Windows.Threading;

namespace LMS.Statistic {

	public partial class Statistic : Form {

		public Statistic() {
			InitializeComponent();
		}

		private readonly BllStatistic bllStatistic = new BllStatistic();

		private void History_Load(DateTime from, DateTime to, string filter) {
			dgwHistory.DataSource = bllStatistic.GetDataTableHistory(from, to, filter);
		}

		private void CboFilter_Load() {
			cboFilter.DataSource = new List<StringHelper.KeyDisplayPair>
			{
				StringHelper.HistoryStatus.All,
				StringHelper.HistoryStatus.Add,
				StringHelper.HistoryStatus.Update,
				StringHelper.HistoryStatus.Lend,
				StringHelper.HistoryStatus.Return
			};
			cboFilter.DisplayMember = "Display";
			cboFilter.ValueMember = "Key";
		}

		private void Statistic_Load(object sender, EventArgs e) {
			txtNoBooks.Text = bllStatistic.GetNumberOfBooks().ToString();
			txtNoDisabledBooks.Text = bllStatistic.GetNumberOfDisabledBooks().ToString();
			txtNoLostBooks.Text = bllStatistic.GetNumberOfLostBooks().ToString();
			txtTotalPrice.Text = bllStatistic.GetTotalPrice().ToString();

			txtNoBooksBorrowed.Text = bllStatistic.GetNumberOfBooksBorrowed().ToString();
			txtNoBookIssues.Text = bllStatistic.GetNumberOfBookIssues().ToString();
			txtCountOfLentToday.Text = bllStatistic.GetCountOfLentToday().ToString();
			txtCountOfReturnedToday.Text = bllStatistic.GetCountOfReturndToday().ToString();

			txtNoReaders.Text = bllStatistic.GetNumberOfReaders().ToString();
			txtNoReadersBorrowingBook.Text = bllStatistic.GetNumberOfReadersBorrowing().ToString();

			txtTimeNow.Text = DateTime.Now.ToShortTimeString();
			txtDateNow.Text = DateTime.Now.Date.ToString("dd / MM / yyyy");
			UpdateTime();

			CboFilter_Load();
			dtpFrom.Value = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day, 0, 0, 0);
			dtpTo.Value = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day, 23, 59, 59);
			History_Load(dtpFrom.Value, dtpTo.Value, StringHelper.KeyDisplayPair.Parse(cboFilter.SelectedItem).Key);
		}

		private void UpdateTime() {
			DispatcherTimer dptSecond = new DispatcherTimer();
			dptSecond.Tick += delegate {
				txtTimeNow.Text = DateTime.Now.ToShortTimeString();
			};
			dptSecond.Interval = new TimeSpan(0, 1, 0);
			dptSecond.Start();
			DispatcherTimer dptDay = new DispatcherTimer();
			dptDay.Tick += delegate {
				txtDateNow.Text = DateTime.Now.Date.ToString("dd / MM / yyyy");
			};
			dptDay.Interval = new TimeSpan(1, 0, 0);
			dptDay.Start();
		}

		private void DtpFrom_ValueChanged(object sender, EventArgs e) {
			History_Load(dtpFrom.Value, dtpTo.Value, StringHelper.KeyDisplayPair.Parse(cboFilter.SelectedItem).Key);
		}

		private void DtpTo_ValueChanged(object sender, EventArgs e) {
			History_Load(dtpFrom.Value, dtpTo.Value, StringHelper.KeyDisplayPair.Parse(cboFilter.SelectedItem).Key);
		}

		private void CboFilter_SelectedIndexChanged(object sender, EventArgs e) {
			History_Load(dtpFrom.Value, dtpTo.Value, StringHelper.KeyDisplayPair.Parse(cboFilter.SelectedItem).Key);
		}
	}
}