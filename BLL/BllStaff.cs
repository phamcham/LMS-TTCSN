using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {

	public class BllStaff {
		private readonly DalStaff dalStaff = new DalStaff();

		public DtoStaff GetByUserName(string username) {
			return dalStaff.GetByUserName(username);
		}

		public DtoStaff GetByID(string staffID) {
			return dalStaff.GetByID(staffID);
		}

		public DataTable GetDataTable(string searchString, bool showBlockedStaff) {
			DataTable res = dalStaff.GetDataTable(searchString, showBlockedStaff);
			foreach (DataRow dataRow in res.Rows) {
				string data = dataRow.Field<string>("Status").Trim();
				data = StringHelper.ActionStatus.GetByKey(data).Display;
				dataRow.SetField("Status", data);
				Console.WriteLine(data);
			}
			return res;
		}

		public string GetNextID() {
			return dalStaff.GetNextID();
		}

		public bool Add(DtoStaff dtoStaff) {
			return dalStaff.Add(dtoStaff);
		}

		public bool Update(DtoStaff dtoStaff) {
			return dalStaff.Update(dtoStaff);
		}
	}
}