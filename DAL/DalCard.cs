using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	public class DalCard {
		private readonly DataConnection data = new DataConnection();

		public DtoCard GetByID(string cardID) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM CARD WHERE CardID = @CardID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@CardID", SqlDbType.NVarChar).Value = cardID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return new DtoCard(
							sqlDataReader.GetString(0).Trim(),
							sqlDataReader.GetDateTime(1),
							sqlDataReader.GetDateTime(2),
							sqlDataReader.GetString(3).Trim());
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public bool Update(DtoCard dtoCard) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"UPDATE CARD SET IssueDate = @IssueDate, Expiration = @Expiration, Notes = @Notes WHERE  CardID = @CardID";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@CardID", SqlDbType.NChar).Value = dtoCard.CardID;
					cmd.Parameters.Add("@IssueDate", SqlDbType.Date).Value = dtoCard.IssueDate;
					cmd.Parameters.Add("@Expiration", SqlDbType.Date).Value = dtoCard.Expiration;
					cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = dtoCard.Notes;
					cmd.ExecuteNonQuery();
				}
				catch {
					return false;
				}
			}
			return true;
		}

		public bool Add(DtoCard dtoCard) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"INSERT INTO CARD VALUES(@CardID, @IssueDate, @Expiration, @Notes)";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@CardID", SqlDbType.NChar).Value = dtoCard.CardID;
					cmd.Parameters.Add("@IssueDate", SqlDbType.Date).Value = dtoCard.IssueDate;
					cmd.Parameters.Add("@Expiration", SqlDbType.Date).Value = dtoCard.Expiration;
					cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = dtoCard.Notes;
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
				string sql = @"SELECT COUNT(*) FROM CARD";
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
			if (IsEmpty()) return "card001";
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT 'card' + RIGHT('000' + CAST(MAX(RIGHT(RTRIM(CardID), 3)) + 1 AS NVARCHAR), 3) FROM CARD";
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
	}
}