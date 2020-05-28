using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {

	public class DtoHistory {
		public string HistoryID { get; set; }
		public string Action { get; set; }
		public string Object { get; set; }
		public string StaffID { get; set; }
		public DateTime Time { get; set; }

		public DtoHistory() {
		}

		public DtoHistory(string historyID, string action, string _object, string staffID, DateTime time) {
			HistoryID = historyID;
			Action = action;
			Object = _object;
			StaffID = staffID;
			Time = time;
		}
	}
}