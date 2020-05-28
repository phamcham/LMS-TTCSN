using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	public class DalHistory {
		private readonly DataConnection data = new DataConnection();

		private bool IsEmpty() {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				SqlCommand sqlCommand = new SqlCommand {
					CommandText = @"SELECT COUNT(*) FROM HISTORY",
					Connection = sqlConnection
				};
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0) == 0;
					else throw new Exception();
				}
			}
		}

		public bool Add(DtoHistory dtoHistory) {
			try {
				using (SqlConnection sqlConnection = data.GetConnect()) {
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand {
						CommandText = @"INSERT INTO HISTORY VALUES(@HistoryID, @Action, @Object, @Time, @StaffID)",
						Connection = sqlConnection
					};
					sqlCommand.Parameters.Add("@HistoryID", SqlDbType.NChar).Value = dtoHistory.HistoryID;
					sqlCommand.Parameters.Add("@Action", SqlDbType.NChar).Value = dtoHistory.Action;
					sqlCommand.Parameters.Add("@Object", SqlDbType.NChar).Value = dtoHistory.Object;
					sqlCommand.Parameters.Add("@Time", SqlDbType.DateTime).Value = dtoHistory.Time;
					sqlCommand.Parameters.Add("@StaffID", SqlDbType.NChar).Value = dtoHistory.StaffID;
					sqlCommand.ExecuteNonQuery();
				}
			}
			catch {
				return false;
			}
			return true;
		}

		public string GetNextID() {
			if (IsEmpty()) return "hist001";
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				SqlCommand sqlCommand = new SqlCommand {
					CommandText = @"SELECT 'hist' + RIGHT('000' + CAST(MAX(RIGHT(RTRIM(HistoryID), 3)) + 1 AS NVARCHAR), 3) FROM HISTORY",
					Connection = sqlConnection
				};
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetString(0);
					else
						throw new Exception();
				}
			}
		}
	}
}