using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {

	public class DtoReader {
		public string ReaderID { get; set; }
		public string ReaderName { get; set; }
		public string Gender { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string CardID { get; set; }
		public string Status { get; set; }
		public byte[] Avatar { get; set; }

		public DtoReader() {
		}

		public DtoReader(string readerID, string readerName, string gender, DateTime dateOfBirth, string phone, string address, string cardID, string status, byte[] avatar) {
			ReaderID = readerID;
			ReaderName = readerName;
			Gender = gender;
			DateOfBirth = dateOfBirth;
			Phone = phone;
			Address = address;
			CardID = cardID;
			Status = status;
			Avatar = avatar;
		}
	}
}