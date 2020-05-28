using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {

	public class BllBook {
		private readonly DalBook dalBook = new DalBook();

		public DataTable GetDataTable(string searchString, bool showDisabledBook, bool showLostBook) {
			DataTable res = dalBook.GetDataTable(searchString, showDisabledBook, showLostBook);
			foreach (DataRow dataRow in res.Rows) {
				string data = dataRow.Field<string>("Availability").Trim();
				data = StringHelper.Availability.GetByKey(data).Display;
				dataRow.SetField("Availability", data);

				data = dataRow.Field<string>("Status").Trim();
				data = StringHelper.IsExist.GetByKey(data).Display;
				dataRow.SetField("Status", data);
			}
			return res;
		}

		public DtoBook GetByID(string bookID) {
			return dalBook.GetByID(bookID);
		}

		public bool TryGetByID(string bookID, out DtoBook dtoBook) {
			return dalBook.TryGetByID(bookID, out dtoBook);
		}

		public string GetNextID() {
			return dalBook.GetNextID();
		}

		public bool Add(DtoBook dtoBook) {
			return dalBook.Add(dtoBook);
		}

		public bool Update(DtoBook dtoBook) {
			return dalBook.Update(dtoBook);
		}

		public bool IsLost(DtoBook dtoBook) {
			return dalBook.IsLost(dtoBook);
		}

		public bool IsEnabled(DtoBook dtoBook) {
			return dalBook.IsEnabled(dtoBook);
		}
	}
}