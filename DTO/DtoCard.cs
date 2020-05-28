using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DtoCard
	{
		public string CardID { get; set; }
		public DateTime IssueDate { get; set; }
		public DateTime Expiration { get; set; }
		public string Notes { get; set; }

		public DtoCard()
		{
		}

		public DtoCard(string cardID, DateTime issueDate, DateTime expiration, string notes)
		{
			CardID = cardID;
			IssueDate = issueDate;
			Expiration = expiration;
			Notes = notes;
		}
	}
}