using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {

	public class BllStatistic {
		private readonly DalStatistic dalStatistic = new DalStatistic();

		public int GetNumberOfBooks() {
			return dalStatistic.GetNumberOfValidBooks();
		}

		public int GetNumberOfDisabledBooks() {
			return dalStatistic.GetNumberOfDisabledBooks();
		}

		public int GetTotalPrice() {
			return dalStatistic.GetTotalPrice();
		}

		public int GetNumberOfBooksBorrowed() {
			return dalStatistic.GetNumberOfBooksBorrowed();
		}

		public int GetNumberOfBookIssues() {
			return dalStatistic.GetNumberOfBookIssues();
		}

		public DataTable GetDataTableHistory(DateTime from, DateTime to, string filter) {
			DataTable res = dalStatistic.GetDataTableHistory(from, to, filter);
			foreach (DataRow dataRow in res.Rows) {
				string data = dataRow.Field<string>("Action").Trim();
				data = StringHelper.HistoryStatus.GetByKey(data).Display;
				dataRow.SetField("Action", data);
			}
			return res;
		}

		public int GetNumberOfReaders() {
			return dalStatistic.GetNumberOfReaders();
		}

		public int GetNumberOfReadersBorrowing() {
			return dalStatistic.GetNumberOfReadersBorrowing();
		}

		public int GetNumberOfLostBooks() {
			return dalStatistic.GetNumberOfLostBooks();
		}

		public int GetCountOfLentToday() {
			return dalStatistic.GetCountOfLentToday();
		}

		public int GetCountOfReturndToday() {
			return dalStatistic.GetCountOfReturnedToday();
		}
	}
}