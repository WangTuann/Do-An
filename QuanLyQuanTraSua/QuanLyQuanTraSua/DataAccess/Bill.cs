using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Bill
    {
        public int MaHoaDon { get; set; }
        public string TenHoaDon { get; set; }
        public int MaBan { get; set; }
        public int TongTien { get; set; }
        public float GiamGia { get; set; }
        public float Thue { get; set; }
        public int TrangThaiHD { get; set; }
        public DateTime NgayTao { get; set; }
        public string TaiKhoanTao { get; set; }
    }
}
