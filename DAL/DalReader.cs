using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	public class DalReader {
		private readonly DataConnection data = new DataConnection();

		public DataTable GetDataTable(string searchString, bool showBlockedReader) {
			DataTable dataTable = new DataTable();
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT ReaderID, ReaderName, Phone, CardID, Status
								FROM READER
								WHERE (ReaderID LIKE '%' + @SearchString + '%' OR
									ReaderName LIKE '%' + @SearchString + '%' OR
									Phone LIKE '%' + @SearchString + '%' OR
									CardID LIKE '%' + @SearchString + '%' OR
									Status LIKE '%' + @SearchString + '%')";
				if (!showBlockedReader) sql += " AND Status = @Active";
				SqlCommand cmd = new SqlCommand(sql, sqlConnection);
				cmd.Parameters.Add("@SearchString", SqlDbType.NVarChar).Value = searchString;
				if (!showBlockedReader)
					cmd.Parameters.Add("@Active", SqlDbType.NVarChar).Value = StringHelper.ActionStatus.Active.Key;
				SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
				dataAdapter.Fill(dataTable);
				sqlConnection.Close();
			}
			return dataTable;
		}

		public bool Update(DtoReader dtoReader) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"UPDATE READER SET ReaderName = @ReaderName, Gender = @Gender, DateOfBirth = @DateOfBirth, Phone = @Phone, Address = @Address, CardID = @CardID, Status = @Status, Avatar = @Avatar WHERE ReaderID = @ReaderID";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@ReaderID", SqlDbType.NChar).Value = dtoReader.ReaderID;
					cmd.Parameters.Add("@ReaderName", SqlDbType.NVarChar).Value = dtoReader.ReaderName;
					cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = dtoReader.Gender;
					cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dtoReader.DateOfBirth;
					cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = dtoReader.Phone;
					cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = dtoReader.Address;
					cmd.Parameters.Add("@CardID", SqlDbType.NChar).Value = dtoReader.CardID;
					cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = dtoReader.Status;
					if (dtoReader.Avatar == null)
						cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = DBNull.Value;
					else
						cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = dtoReader.Avatar;
					cmd.ExecuteNonQuery();
				}
				catch {
					return false;
				}
			}
			return true;
		}

		public bool Add(DtoReader dtoReader) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"INSERT INTO READER VALUES(@ReaderID, @ReaderName, @Gender, @DateOfBirth, @Phone, @Address, @CardID, @Status, @Avatar)";
					SqlCommand cmd = new SqlCommand(sql, sqlConnection);
					cmd.Parameters.Add("@ReaderID", SqlDbType.NChar).Value = dtoReader.ReaderID;
					cmd.Parameters.Add("@ReaderName", SqlDbType.NVarChar).Value = dtoReader.ReaderName;
					cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = dtoReader.Gender;
					cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dtoReader.DateOfBirth;
					cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = dtoReader.Phone;
					cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = dtoReader.Address;
					cmd.Parameters.Add("@CardID", SqlDbType.NChar).Value = dtoReader.CardID;
					cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = StringHelper.ActionStatus.Active.Key;
					if (dtoReader.Avatar == null)
						cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = DBNull.Value;
					else
						cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = dtoReader.Avatar;
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
				string sql = @"SELECT COUNT(*) FROM READER";
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
			if (IsEmpty()) return "read001";
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT 'read' + RIGHT('000' + CAST(MAX(RIGHT(RTRIM(ReaderID), 3)) + 1 AS NVARCHAR), 3) FROM READER";
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

		public DtoReader GetByID(string readerID) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM READER WHERE ReaderID = @ReaderID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@ReaderID", SqlDbType.NVarChar).Value = readerID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return new DtoReader(
							sqlDataReader.GetString(0).Trim(),
							sqlDataReader.GetString(1).Trim(),
							sqlDataReader.GetString(2).Trim(),
							sqlDataReader.GetDateTime(3),
							sqlDataReader.GetString(4).Trim(),
							sqlDataReader.GetString(5).Trim(),
							sqlDataReader.GetString(6).Trim(),
							sqlDataReader.GetString(7).Trim(),
							sqlDataReader.IsDBNull(8) ? null : (byte[])sqlDataReader.GetValue(8));
					}
					else {
						throw new Exception();
					}
				}
			}
		}
	}
}