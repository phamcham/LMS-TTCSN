using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	public class DalStatistic {
		private readonly DataConnection data = new DataConnection();

		public int GetNumberOfValidBooks() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*) FROM BOOK WHERE Availability = @Availability AND Status = @Status";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@Availability", SqlDbType.NVarChar).Value = StringHelper.Availability.Enable.Key;
				sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = StringHelper.IsExist.Yes.Key;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					return 0;
				}
			}
		}

		public DataTable GetDataTableHistory(DateTime from, DateTime to, string filter) {
			DataTable dataTable = new DataTable();
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT HistoryID, Action, Object, Time, HISTORY.StaffID, StaffName
								FROM HISTORY JOIN STAFF ON HISTORY.StaffID = STAFF.StaffID
								WHERE (Time BETWEEN @From AND @To)";
				if (!filter.Equals(StringHelper.HistoryStatus.All.Key)) sql += " AND Action = @Filter";
				SqlCommand cmd = new SqlCommand(sql, sqlConnection);
				SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
				if (!filter.Equals(StringHelper.HistoryStatus.All.Key)) cmd.Parameters.Add("@Filter", SqlDbType.NVarChar).Value = filter;
				cmd.Parameters.Add("@From", SqlDbType.DateTime).Value = from;
				cmd.Parameters.Add("@To", SqlDbType.DateTime).Value = to;
				dataAdapter.Fill(dataTable);
			}
			return dataTable;
		}

		public int GetNumberOfLostBooks() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*) FROM BOOK WHERE Status = @Status";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = StringHelper.IsExist.No.Key;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					return 0;
				}
			}
		}

		public int GetCountOfReturnedToday() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*)
								FROM ISSUE INNER JOIN [RETURN] ON ISSUE.IssueID = [RETURN].IssueID
								WHERE IssueDate = @IssueDate AND BeReturned = 1";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@IssueDate", SqlDbType.Date).Value = DateTime.Today;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					return 0;
				}
			}
		}

		public int GetCountOfLentToday() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*)
								FROM ISSUE INNER JOIN [RETURN] ON ISSUE.IssueID = [RETURN].IssueID
								WHERE IssueDate = @IssueDate";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@IssueDate", SqlDbType.Date).Value = DateTime.Today;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					return 0;
				}
			}
		}

		public int GetNumberOfReadersBorrowing() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(DISTINCT ReaderID)
								FROM READER INNER JOIN CARD ON READER.CardID = CARD.CardID
											INNER JOIN ISSUE ON CARD.CardID = ISSUE.CardID
											INNER JOIN [RETURN] ON ISSUE.IssueID = [RETURN].IssueID
								WHERE BeReturned = 0;";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@Availability", SqlDbType.NVarChar).Value = StringHelper.Availability.Enable.Key;
				sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = StringHelper.IsExist.Yes.Key;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					return 0;
				}
			}
		}

		public int GetNumberOfReaders() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*) FROM READER WHERE Status = @Status";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = StringHelper.ActionStatus.Active.Key;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					return 0;
				}
			}
		}

		public int GetNumberOfBookIssues() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*) FROM ISSUE";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					return 0;
				}
			}
		}

		public int GetNumberOfBooksBorrowed() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(DISTINCT ISSUE.CardID)
								FROM ISSUE INNER JOIN READER ON ISSUE.CardID = READER.CardID
									INNER JOIN [RETURN] ON ISSUE.IssueID = [RETURN].IssueID
								WHERE Status = @Status AND [RETURN].BeReturned = 0";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = StringHelper.ActionStatus.Active.Key;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					return 0;
				}
			}
		}

		public int GetTotalPrice() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT ISNULL(SUM(Price), 0) FROM BOOK";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					else
						throw new Exception();
				}
			}
		}

		public int GetNumberOfDisabledBooks() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*) FROM BOOK WHERE Availability = @Availability";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@Availability", SqlDbType.NVarChar).Value = StringHelper.Availability.Enable.Key;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0);
					return 0;
				}
			}
		}
	}
}