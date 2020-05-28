using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {

	public class BllReturn {
		private readonly DalReturn dalReturn = new DalReturn();

		public bool Add(DtoReturn dtoReturn) {
			return dalReturn.Add(dtoReturn);
		}

		// not
		public bool UpdateReturn(DtoReturn dtoReturn) {
			return dalReturn.UpdateReturn(dtoReturn);
		}

		public string GetNextID() {
			return dalReturn.GetNextID();
		}

		public DtoReturn GetByIssueID(string issueID) {
			return dalReturn.GetByIssueID(issueID);
		}

		public DtoReturn GetByID(string returnID) {
			return dalReturn.GetByID(returnID);
		}
	}
}