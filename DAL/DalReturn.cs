using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	public class DalReturn {
		private readonly DataConnection data = new DataConnection();

		public bool Add(DtoReturn dtoReturn) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"INSERT INTO [RETURN] VALUES(@ReturnID, @IssueID, @StaffID, @BeReturned, @ReturnDate)";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@ReturnID", SqlDbType.NChar).Value = dtoReturn.ReturnID;
					cmd.Parameters.Add("@IssueID", SqlDbType.NChar).Value = dtoReturn.IssueID;
					cmd.Parameters.Add("@StaffID", SqlDbType.NChar).Value = dtoReturn.StaffID;
					cmd.Parameters.Add("@BeReturned", SqlDbType.Int).Value = dtoReturn.BeReturned;
					cmd.Parameters.Add("@ReturnDate", SqlDbType.Date).Value = dtoReturn.ReturnDate;
					cmd.ExecuteNonQuery();
				}
				catch {
					return false;
				}
			}
			return true;
		}

		public DtoReturn GetByID(string returnID) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM [RETURN] WHERE ReturnID = @ReturnID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@ReturnID", SqlDbType.NChar).Value = returnID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return new DtoReturn(
							sqlDataReader.GetString(0).Trim(),
							sqlDataReader.GetString(1).Trim(),
							sqlDataReader.GetString(2).Trim(),
							sqlDataReader.GetInt32(3),
							sqlDataReader.GetDateTime(4));
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public DtoReturn GetByIssueID(string issueID) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM [RETURN] WHERE IssueID = @IssueID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@IssueID", SqlDbType.NChar).Value = issueID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return new DtoReturn(
							sqlDataReader.GetString(0).Trim(),
							sqlDataReader.GetString(1).Trim(),
							sqlDataReader.GetString(2).Trim(),
							sqlDataReader.GetInt32(3),
							sqlDataReader.GetDateTime(4));
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		private bool IsEmpty() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*) FROM [RETURN]";
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
			if (IsEmpty()) return "retu001";
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT 'retu' + RIGHT('000' + CAST(MAX(RIGHT(RTRIM(ReturnID), 3)) + 1 AS NVARCHAR), 3) FROM [RETURN]";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return sqlDataReader.GetString(0).Trim();
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public bool UpdateReturn(DtoReturn dtoReturn) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"UPDATE [RETURN] SET IssueID = @IssueID, StaffID = @StaffID, BeReturned = @BeReturned, ReturnDate = @ReturnDate WHERE ReturnID = @ReturnID";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@ReturnID", SqlDbType.NChar).Value = dtoReturn.ReturnID;
					cmd.Parameters.Add("@IssueID", SqlDbType.NChar).Value = dtoReturn.IssueID;
					cmd.Parameters.Add("@StaffID", SqlDbType.NChar).Value = dtoReturn.StaffID;
					cmd.Parameters.Add("@BeReturned", SqlDbType.Int).Value = dtoReturn.BeReturned;
					cmd.Parameters.Add("@ReturnDate", SqlDbType.Date).Value = dtoReturn.ReturnDate;
					cmd.ExecuteNonQuery();
				}
				catch {
					return false;
				}
			}
			return true;
		}
	}
}