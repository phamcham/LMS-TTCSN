using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	public class DalAccount {
		private readonly DataConnection data = new DataConnection();

		public bool CanLogin(DtoAccount dtoAccount) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT COUNT(*) FROM ACCOUNT WHERE Username = @Username AND Password = @Password";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = dtoAccount.Username;
				sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = dtoAccount.Password;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read())
						return sqlDataReader.GetInt32(0) > 0;
					return false;
				}
			}
		}

		public bool Update(DtoAccount dtoAccount) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"UPDATE ACCOUNT SET Password = @Password WHERE UserName = @UserName";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@UserName", SqlDbType.NChar).Value = dtoAccount.Username;
					cmd.Parameters.Add("@Password", SqlDbType.NChar).Value = dtoAccount.Password;
					cmd.ExecuteNonQuery();
				}
				catch {
					return false;
				}
			}
			return true;
		}

		public DtoAccount GetByUserName(string userName) {
			DataTable dataTable = new DataTable();
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM ACCOUNT WHERE UserName = @UserName";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@UserName", SqlDbType.NChar).Value = userName;
				SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
				dataAdapter.Fill(dataTable);
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return new DtoAccount(
							sqlDataReader["UserName"].ToString().Trim(),
							sqlDataReader["Password"].ToString().Trim());
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public bool Add(DtoAccount dtoAccount) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"INSERT INTO ACCOUNT VALUES(@UserName, @Password)";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@UserName", SqlDbType.NChar).Value = dtoAccount.Username;
					cmd.Parameters.Add("@Password", SqlDbType.NChar).Value = dtoAccount.Password;
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