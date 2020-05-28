using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {

	internal class DataConnection {

		public SqlConnection GetConnect() {
			string connectionString = "Data Source=" + StringHelper.serverName + @";Initial Catalog=LMS;Integrated Security=True";
			//string connectionString = @"Data Source=(local).\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True";
			return new SqlConnection(connectionString);
		}
	}
}