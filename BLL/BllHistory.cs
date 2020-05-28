using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {

	public class BllHistory {
		private readonly DalHistory dalHistory = new DalHistory();

		public string GetNextID() {
			return dalHistory.GetNextID();
		}

		public bool Add(DtoHistory dtoHistory) {
			return dalHistory.Add(dtoHistory);
		}
	}
}