using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {

	public class DtoBook {
		public string BookID { get; set; }
		public string BookName { get; set; }
		public string CategoryName { get; set; }
		public string AuthorName { get; set; }
		public string PublisherName { get; set; }
		public int PublishedYear { get; set; }
		public int EditionNumber { get; set; }
		public int Price { get; set; }
		public string ISBN { get; set; }
		public string Status { get; set; }
		public string Notes { get; set; }
		public string Availability { get; set; }
		public byte[] BookCover { get; set; }

		public DtoBook() {
			PublishedYear = 0;
			EditionNumber = 1;
			Price = 0;
		}

		public DtoBook(string bookID, string bookName, string categoryName, string authorName, string publisherName, int publishedYear, int editionNumber, int price, string iSBN, string status, string notes, string enable, byte[] bookCover) {
			BookID = bookID;
			BookName = bookName;
			CategoryName = categoryName;
			AuthorName = authorName;
			PublisherName = publisherName;
			PublishedYear = publishedYear;
			EditionNumber = editionNumber;
			Price = price;
			ISBN = iSBN;
			Status = status;
			Notes = notes;
			Availability = enable;
			BookCover = bookCover;
		}
	}
}