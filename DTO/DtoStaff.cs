using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {

	public class DtoStaff {
		public string StaffID { get; set; }
		public string StaffName { get; set; }
		public string Gender { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string Role { get; set; }
		public string UserName { get; set; }
		public string Status { get; set; }
		public byte[] Avatar { get; set; }

		public DtoStaff() {
		}

		public DtoStaff(string staffID, string staffName, string gender, DateTime dateOfBirth, string phone, string address, string role, string userName, string status, byte[] avatar) {
			StaffID = staffID;
			StaffName = staffName;
			Gender = gender;
			DateOfBirth = dateOfBirth;
			Phone = phone;
			Address = address;
			Role = role;
			UserName = userName;
			Status = status;
			Avatar = avatar;
		}
	}
}