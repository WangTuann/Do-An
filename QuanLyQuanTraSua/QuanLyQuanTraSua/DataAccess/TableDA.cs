using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TableDA
    {
        public List<Table> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Table_GetAll;
            SqlDataReader reader = command.ExecuteReader();
            List<Table> tableList = new List<Table>();
            while (reader.Read())
            {
                Table table = new Table();
                table.MaBan = Convert.ToInt32(reader["MaBan"]);
                table.TenBan = reader["TenBan"].ToString();
                table.TrangThaiBan = Convert.ToInt32(reader["TrangThaiBan"]);
                tableList.Add(table);
            }
            // Đóng kết nối và trả về danh sách
            sqlConn.Close();
            return tableList;
        }
    }
}
