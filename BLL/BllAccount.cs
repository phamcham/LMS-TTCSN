using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {

	public class BllAccount {
		private readonly DalAccount dalAccount = new DalAccount();

		public bool CanLogin(DtoAccount dtoAccount) {
			return dalAccount.CanLogin(dtoAccount);
		}

		public bool Add(DtoAccount dtoAccount) {
			return dalAccount.Add(dtoAccount);
		}

		public DtoAccount GetByUserName(string userName) {
			return dalAccount.GetByUserName(userName);
		}

		public bool Update(DtoAccount dtoAccount) {
			return dalAccount.Update(dtoAccount);
		}
	}
}