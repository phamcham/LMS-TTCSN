using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {

	public class BllCard {
		private readonly DalCard dalCard = new DalCard();

		public DtoCard GetByID(string cardID) {
			return dalCard.GetByID(cardID);
		}

		public string GetNextID() {
			return dalCard.GetNextID();
		}

		public bool Add(DtoCard dtoCard) {
			return dalCard.Add(dtoCard);
		}

		public bool Update(DtoCard dtoCard) {
			return dalCard.Update(dtoCard);
		}
	}
}