using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {

	public class BllReader {
		private readonly DalReader dalReader = new DalReader();

		public DataTable GetDataTable(string searchString, bool showBlockedReader) {
			DataTable res = dalReader.GetDataTable(searchString, showBlockedReader);
			foreach (DataRow dataRow in res.Rows) {
				string data = dataRow.Field<string>("Status").Trim();
				data = StringHelper.ActionStatus.GetByKey(data).Display;
				dataRow.SetField("Status", data);
			}
			return res;
		}

		public DtoReader GetByID(string readerID) {
			return dalReader.GetByID(readerID);
		}

		public string GetNextID() {
			return dalReader.GetNextID();
		}

		public bool Add(DtoReader dtoReader) {
			return dalReader.Add(dtoReader);
		}

		public bool Update(DtoReader dtoReader) {
			return dalReader.Update(dtoReader);
		}
	}
}