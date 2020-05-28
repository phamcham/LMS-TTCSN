using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DtoReturn
	{
		public string ReturnID { get; set; }
		public string IssueID { get; set; }
		public string StaffID { get; set; }
		public int BeReturned { get; set; }
		public DateTime ReturnDate { get; set; }

		public DtoReturn()
		{
		}

		public DtoReturn(string returnID, string issueID, string staffID, int beReturned, DateTime returnDate)
		{
			ReturnID = returnID;
			IssueID = issueID;
			StaffID = staffID;
			BeReturned = beReturned;
			ReturnDate = returnDate;
		}
	}
}