using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	public class DalIssue {
		private readonly DataConnection data = new DataConnection();

		public DataTable GetByCardID(string cardID) {
			DataTable dataTable = new DataTable();
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT ISSUE.BookID, BookName, ISSUE.IssueID
								FROM ISSUE INNER JOIN [RETURN] ON ISSUE.IssueID = [RETURN].IssueID
											INNER JOIN BOOK ON ISSUE.BookID = BOOK.BookID
								WHERE CardID = @CardID AND BeReturned = 0";
				SqlCommand cmd = new SqlCommand(sql, sqlConnection);
				cmd.Parameters.Add("@CardID", SqlDbType.NChar).Value = cardID;
				SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
				dataAdapter.Fill(dataTable);
				sqlConnection.Close();
			}
			return dataTable;
		}

		public DataTable GetHistoryReturnByCardID(string cardID) {
			DataTable dataTable = new DataTable();
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT ISSUE.BookID, BookName, ReturnDate, ReturnID
								FROM ISSUE INNER JOIN [RETURN] ON ISSUE.IssueID = [RETURN].IssueID
											INNER JOIN BOOK ON ISSUE.BookID = BOOK.BookID
								WHERE CardID = @CardID AND BeReturned = 1";
				SqlCommand cmd = new SqlCommand(sql, sqlConnection);
				cmd.Parameters.Add("@CardID", SqlDbType.NChar).Value = cardID;
				SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
				dataAdapter.Fill(dataTable);
				sqlConnection.Close();
			}
			return dataTable;
		}

		public bool ReturnBook(DtoReturn dtoReturn) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"UPDATE [RETURN] SET BeReturned = 1, ReturnDate = @ReturnDate WHERE IssueID = @IssueID";
					SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
					sqlCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = dtoReturn.ReturnDate;
					sqlCommand.Parameters.Add("@IssueID", SqlDbType.NChar).Value = dtoReturn.IssueID;
					sqlCommand.ExecuteNonQuery();
				}
				catch {
					return false;
				}
			}
			return true;
		}

		public bool IsLent(DtoBook dtoBook) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*)
								FROM ISSUE INNER JOIN [RETURN] ON ISSUE.IssueID = [RETURN].IssueID
								WHERE BookID = @BookID AND BeReturned = 0";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@BookID", SqlDbType.NChar).Value = dtoBook.BookID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return sqlDataReader.GetInt32(0) > 0;
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public bool Add(DtoIssue dtoIssue) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"INSERT INTO ISSUE VALUES(@IssueID, @CardID, @StaffID, @BookID, @IssueDate, @Notes)";
					SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
					sqlCommand.Parameters.Add("@IssueID", SqlDbType.NChar).Value = dtoIssue.IssueID;
					sqlCommand.Parameters.Add("@CardID", SqlDbType.NChar).Value = dtoIssue.CardID;
					sqlCommand.Parameters.Add("@StaffID", SqlDbType.NChar).Value = dtoIssue.StaffID;
					sqlCommand.Parameters.Add("@BookID", SqlDbType.NChar).Value = dtoIssue.BookID;
					sqlCommand.Parameters.Add("@IssueDate", SqlDbType.Date).Value = dtoIssue.IssueDate;
					sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = dtoIssue.Notes;
					sqlCommand.ExecuteNonQuery();
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
				string sql = @"SELECT COUNT(*) FROM ISSUE";
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
			if (IsEmpty()) return "issu001";
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT 'issu' + RIGHT('000' + CAST(MAX(RIGHT(RTRIM(IssueID), 3)) + 1 AS NVARCHAR), 3) FROM ISSUE";
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

		public DtoIssue GetByID(string issueID) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM ISSUE WHERE IssueID = @IssueID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@IssueID", SqlDbType.NChar).Value = issueID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return new DtoIssue(
							sqlDataReader.GetString(0).Trim(),
							sqlDataReader.GetString(1).Trim(),
							sqlDataReader.GetString(2).Trim(),
							sqlDataReader.GetString(3).Trim(),
							sqlDataReader.GetDateTime(4),
							sqlDataReader.GetString(5).Trim());
					}
					else {
						throw new Exception();
					}
				}
			}
		}
	}
}