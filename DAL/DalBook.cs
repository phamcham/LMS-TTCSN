using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	public class DalBook {
		private readonly DataConnection data = new DataConnection();

		public DataTable GetDataTable(string searchString, bool showDisabledBook, bool showLostBook) {
			DataTable dataTable = new DataTable();
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT BookID, BookName, AuthorName, PublisherName, CategoryName, Availability, Status
								FROM BOOK
							   WHERE (BookID LIKE '%' + @SearchString + '%' OR
									BookName LIKE '%' + @SearchString + '%' OR
									AuthorName LIKE '%' + @SearchString + '%' OR
									PublisherName LIKE '%' + @SearchString + '%' OR
									CategoryName LIKE '%' + @SearchString + '%')";
				if (!showDisabledBook)
					sql += " AND Availability = @Availability";
				if (!showLostBook)
					sql += " AND Status = @Status";
				SqlCommand cmd = new SqlCommand(sql, sqlConnection);
				cmd.Parameters.Add("@SearchString", SqlDbType.NVarChar).Value = searchString;
				if (!showDisabledBook)
					cmd.Parameters.Add("@Availability", SqlDbType.NVarChar).Value = StringHelper.Availability.Enable.Key;
				if (!showLostBook)
					cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = StringHelper.IsExist.Yes.Key;
				SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
				dataAdapter.Fill(dataTable);
				sqlConnection.Close();
			}
			return dataTable;
		}

		public bool IsEnabled(DtoBook dtoBook) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT Availability FROM BOOK WHERE BookID = @BookID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@BookID", SqlDbType.NChar).Value = dtoBook.BookID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return sqlDataReader.GetString(0).Equals(StringHelper.Availability.Disable.Key);
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public bool IsLost(DtoBook dtoBook) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT Status FROM BOOK WHERE BookID = @BookID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@BookID", SqlDbType.NChar).Value = dtoBook.BookID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return sqlDataReader.GetString(0).Equals(StringHelper.IsExist.No.Key);
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public bool Update(DtoBook dtoBook) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = "UPDATE BOOK SET BookName = @BookName, CategoryName = @CategoryName," +
						" AuthorName = @AuthorName, PublisherName = @PublisherName, PublishedYear = @PublishedYear," +
						" EditionNumber = @EditionNumber, Price = @Price, ISBN = @ISBN, Status = @Status, " +
						" Notes = @Notes, Availability = @Availability, BookCover = @BookCover " +
						" WHERE BookID = @BooKID";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@BookID", SqlDbType.NChar).Value = dtoBook.BookID;
					cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = dtoBook.BookName;
					cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = dtoBook.CategoryName;
					cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = dtoBook.AuthorName;
					cmd.Parameters.Add("@PublisherName", SqlDbType.NVarChar).Value = dtoBook.PublisherName;
					cmd.Parameters.Add("@PublishedYear", SqlDbType.Int).Value = dtoBook.PublishedYear;
					cmd.Parameters.Add("@EditionNumber", SqlDbType.Int).Value = dtoBook.EditionNumber;
					cmd.Parameters.Add("@Price", SqlDbType.Int).Value = dtoBook.Price;
					cmd.Parameters.Add("@ISBN", SqlDbType.NChar).Value = dtoBook.ISBN;
					cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = dtoBook.Status;
					cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = dtoBook.Notes;
					cmd.Parameters.Add("@Availability", SqlDbType.NVarChar).Value = dtoBook.Availability;
					if (dtoBook.BookCover is null) {
						cmd.Parameters.Add("@BookCover", SqlDbType.Image).Value = DBNull.Value;
					}
					else {
						cmd.Parameters.Add("@BookCover", SqlDbType.Image).Value = dtoBook.BookCover;
					}
					cmd.ExecuteNonQuery();
				}
				catch {
					return false;
				}
			}
			return true;
		}

		public bool Add(DtoBook dtoBook) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"INSERT INTO BOOK VALUES(@BookID, @BookName, @CategoryName, @AuthorName, @PublisherName, @PublishedYear, @EditionNumber, @Price, @ISBN, @Status, @Notes, @Availability, @BookCover)";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@BookID", SqlDbType.NChar).Value = dtoBook.BookID;
					cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = dtoBook.BookName;
					cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = dtoBook.CategoryName;
					cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = dtoBook.AuthorName;
					cmd.Parameters.Add("@PublisherName", SqlDbType.NVarChar).Value = dtoBook.PublisherName;
					cmd.Parameters.Add("@PublishedYear", SqlDbType.Int).Value = dtoBook.PublishedYear;
					cmd.Parameters.Add("@EditionNumber", SqlDbType.Int).Value = dtoBook.EditionNumber;
					cmd.Parameters.Add("@Price", SqlDbType.Int).Value = dtoBook.Price;
					cmd.Parameters.Add("@ISBN", SqlDbType.NChar).Value = dtoBook.ISBN;
					cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = dtoBook.Status;
					cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = dtoBook.Notes;
					cmd.Parameters.Add("@Availability", SqlDbType.NVarChar).Value = dtoBook.Availability;
					if (dtoBook.BookCover is null) {
						cmd.Parameters.Add("@BookCover", SqlDbType.Image).Value = DBNull.Value;
					}
					else {
						cmd.Parameters.Add("@BookCover", SqlDbType.Image).Value = dtoBook.BookCover;
					}
					cmd.ExecuteNonQuery();
				}
				catch {
					return false;
				}
			}
			return true;
		}

		private bool IsEmpty() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*) FROM BOOK";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return sqlDataReader.GetInt32(0) == 0;
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public string GetNextID() {
			if (IsEmpty()) return "book001";
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT 'book' + RIGHT('000' + CAST(MAX(RIGHT(RTRIM(BookID), 3)) + 1 AS NVARCHAR), 3) FROM BOOK";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return sqlDataReader.GetString(0);
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public DtoBook GetByID(string bookID) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM BOOK WHERE BookID = @bookID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@bookID", SqlDbType.NChar).Value = bookID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return new DtoBook(
							sqlDataReader.GetString(0).Trim(),
							sqlDataReader.GetString(1).Trim(),
							sqlDataReader.GetString(2).Trim(),
							sqlDataReader.GetString(3).Trim(),
							sqlDataReader.GetString(4).Trim(),
							sqlDataReader.GetInt32(5),
							sqlDataReader.GetInt32(6),
							sqlDataReader.GetInt32(7),
							sqlDataReader.GetString(8).Trim(),
							sqlDataReader.GetString(9).Trim(),
							sqlDataReader.GetString(10).Trim(),
							sqlDataReader.GetString(11).Trim(),
							sqlDataReader.IsDBNull(12) ? null : (byte[])sqlDataReader.GetValue(12));
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public bool TryGetByID(string bookID, out DtoBook dtoBook) {
			dtoBook = new DtoBook();
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM BOOK WHERE BookID = @bookID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@bookID", SqlDbType.NVarChar).Value = bookID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						dtoBook = new DtoBook(
							sqlDataReader.GetString(0).Trim(),
							sqlDataReader.GetString(1).Trim(),
							sqlDataReader.GetString(2).Trim(),
							sqlDataReader.GetString(3).Trim(),
							sqlDataReader.GetString(4).Trim(),
							sqlDataReader.GetInt32(5),
							sqlDataReader.GetInt32(6),
							sqlDataReader.GetInt32(7),
							sqlDataReader.GetString(8).Trim(),
							sqlDataReader.GetString(9).Trim(),
							sqlDataReader.GetString(10).Trim(),
							sqlDataReader.GetString(11).Trim(),
							sqlDataReader.IsDBNull(12) ? null : (byte[])sqlDataReader.GetValue(12));
						return true;
					}
					else {
						return false;
					}
				}
			}
		}
	}
}