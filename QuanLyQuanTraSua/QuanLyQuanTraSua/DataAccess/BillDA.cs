using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillDA
    {
        private int GetBillIDByTableID(int idTable)
        {
            SqlConnection sqlConn = new SqlConnection((Ultilities.ConnectionString));
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandText = "SELECT MaHoaDon From [HoaDon] WHERE MaBan = @maBan and TrangThaiHD = 0";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaBan", SqlDbType.Int).Value = idTable;

            int result = Convert.ToInt32(cmd.ExecuteReader());

            return result;   
        }
    }
}
