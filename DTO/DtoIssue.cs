using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DtoIssue
	{
		public string IssueID { get; set; }
		public string CardID { get; set; }
		public string StaffID { get; set; }
		public string BookID { get; set; }
		public DateTime IssueDate { get; set; }
		public string Notes { get; set; }

		public DtoIssue()
		{
		}

		public DtoIssue(string issueID, string cardID, string staffID, string bookID, DateTime issueDate, string notes)
		{
			IssueID = issueID;
			CardID = cardID;
			StaffID = staffID;
			BookID = bookID;
			IssueDate = issueDate;
			Notes = notes;
		}
	}
}