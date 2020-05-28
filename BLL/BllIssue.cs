using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {

	public class BllIssue {
		private readonly DalIssue dalIssue = new DalIssue();

		public DataTable GetByCardID(string cardID) {
			return dalIssue.GetByCardID(cardID);
		}

		public DtoIssue GetByID(string issueID) {
			return dalIssue.GetByID(issueID);
		}

		public string GetNextID() {
			return dalIssue.GetNextID();
		}

		public bool Add(DtoIssue dtoIssue) {
			return dalIssue.Add(dtoIssue);
		}

		public bool IsLent(DtoBook dtoBook) {
			return dalIssue.IsLent(dtoBook);
		}

		public bool ReturnBook(DtoReturn dtoReturn) {
			return dalIssue.ReturnBook(dtoReturn);
		}

		public DataTable GetHistoryReturnByCardID(string cardID) {
			return dalIssue.GetHistoryReturnByCardID(cardID);
		}
	}
}