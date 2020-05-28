using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	public class DalStaff {
		private readonly DataConnection data = new DataConnection();

		public DtoStaff GetByUserName(string username) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM STAFF WHERE UserName = @UserName";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@UserName", SqlDbType.NChar).Value = username;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return new DtoStaff(
							sqlDataReader.GetString(0).Trim(),
							sqlDataReader.GetString(1).Trim(),
							sqlDataReader.GetString(2).Trim(),
							sqlDataReader.GetDateTime(3),
							sqlDataReader.GetString(4).Trim(),
							sqlDataReader.GetString(5).Trim(),
							sqlDataReader.GetString(6).Trim(),
							sqlDataReader.GetString(7).Trim(),
							sqlDataReader.GetString(8).Trim(),
							sqlDataReader.IsDBNull(9) ? null : (byte[])sqlDataReader.GetValue(9));
					}
					else {
						throw new Exception();
					}
				}
			}
		}

		public bool Update(DtoStaff dtoStaff) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"UPDATE STAFF SET StaffName = @StaffName, Gender = @Gender, DateOfBirth = @DateOfBirth, Phone = @Phone, Address = @Address, UserName = @UserName, Status = @Status, Avatar = @Avatar WHERE StaffID = @StaffID";
					SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
					sqlCommand.Parameters.Add("@StaffID", SqlDbType.NChar).Value = dtoStaff.StaffID;
					sqlCommand.Parameters.Add("@StaffName", SqlDbType.NVarChar).Value = dtoStaff.StaffName;
					sqlCommand.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = dtoStaff.Gender;
					sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dtoStaff.DateOfBirth;
					sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = dtoStaff.Phone;
					sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = dtoStaff.Address;
					sqlCommand.Parameters.Add("@UserName", SqlDbType.NChar).Value = dtoStaff.UserName;
					sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = dtoStaff.Status;
					if (dtoStaff.Avatar == null)
						sqlCommand.Parameters.Add("@Avatar", SqlDbType.Image).Value = DBNull.Value;
					else
						sqlCommand.Parameters.Add("@Avatar", SqlDbType.Image).Value = dtoStaff.Avatar;
					sqlCommand.ExecuteNonQuery();
				}
				catch {
					return false;
				}
			}
			return true;
		}

		public bool Add(DtoStaff dtoStaff) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				try {
					sqlConnection.Open();
					string sql = @"INSERT INTO STAFF VALUES(@StaffID, @StaffName, @Gender, @DateOfBirth, @Phone, @Address, @Role, @UserName, @Status, @Avatar)";
					SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
					sqlCommand.Parameters.Add("@StaffID", SqlDbType.NChar).Value = dtoStaff.StaffID;
					sqlCommand.Parameters.Add("@StaffName", SqlDbType.NVarChar).Value = dtoStaff.StaffName;
					sqlCommand.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = dtoStaff.Gender;
					sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dtoStaff.DateOfBirth;
					sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = dtoStaff.Phone;
					sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = dtoStaff.Address;
					sqlCommand.Parameters.Add("@Role", SqlDbType.NVarChar).Value = StringHelper.Role.Admin.Key;
					sqlCommand.Parameters.Add("@UserName", SqlDbType.NChar).Value = dtoStaff.UserName;
					sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = StringHelper.ActionStatus.Active.Key;
					if (dtoStaff.Avatar == null)
						sqlCommand.Parameters.Add("@Avatar", SqlDbType.Image).Value = DBNull.Value;
					else
						sqlCommand.Parameters.Add("@Avatar", SqlDbType.Image).Value = dtoStaff.Avatar;
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
				string sql = @"SELECT COUNT(*) FROM STAFF";
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
			if (IsEmpty()) return "staf001";
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT 'staf' + RIGHT('000' + CAST(MAX(RIGHT(RTRIM(StaffID), 3)) + 1 AS NVARCHAR), 3) FROM STAFF";
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

		public DataTable GetDataTable(string searchString, bool showBlockedStaff) {
			DataTable dataTable = new DataTable();
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT StaffID, StaffName, Phone, UserName, Status
								FROM STAFF
								WHERE (StaffID LIKE '%' + @SearchString + '%' OR
									StaffName LIKE '%' + @SearchString + '%' OR
									Phone LIKE '%' + @SearchString + '%' OR
									UserName LIKE '%' + @SearchString + '%')";
				if (!showBlockedStaff) sql += " AND Status = @Active";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@SearchString", SqlDbType.NVarChar).Value = searchString;
				if (!showBlockedStaff)
					sqlCommand.Parameters.Add("@Active", SqlDbType.NVarChar).Value = StringHelper.ActionStatus.Active;
				SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
				dataAdapter.Fill(dataTable);
				sqlConnection.Close();
			}
			return dataTable;
		}

		public DtoStaff GetByID(string staffID) {
			using (SqlConnection sqlConnection = data.GetConnect()) {
				sqlConnection.Open();
				string sql = @"SELECT * FROM STAFF WHERE StaffID = @StaffID";
				SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
				sqlCommand.Parameters.Add("@StaffID", SqlDbType.NChar).Value = staffID;
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
					if (sqlDataReader.Read()) {
						return new DtoStaff(
							sqlDataReader.GetString(0).Trim(),
							sqlDataReader.GetString(1).Trim(),
							sqlDataReader.GetString(2).Trim(),
							sqlDataReader.GetDateTime(3),
							sqlDataReader.GetString(4).Trim(),
							sqlDataReader.GetString(5).Trim(),
							sqlDataReader.GetString(6).Trim(),
							sqlDataReader.GetString(7).Trim(),
							sqlDataReader.GetString(8).Trim(),
							sqlDataReader.IsDBNull(9) ? null : (byte[])sqlDataReader.GetValue(9));
					}
					else {
						throw new Exception();
					}
				}
			}
		}
	}
}