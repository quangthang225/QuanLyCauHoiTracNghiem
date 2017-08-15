using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAO
{
    public class AbstractDAO
    {
        string connectionString = "Data Source=(local);Initial Catalog=QuanLyCauHoiTracNghiem;Integrated Security=True";

        public SqlConnection ConnectDB()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
