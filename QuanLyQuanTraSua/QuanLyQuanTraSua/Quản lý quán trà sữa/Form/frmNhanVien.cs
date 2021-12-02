using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_trà_sữa
{
	public partial class frmNhanVien : Form
	{
		public frmNhanVien()
		{
			InitializeComponent();
		}

		#region nút thêm
		private void btnThem_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#region nút reset
		private void btnReset_Click(object sender, EventArgs e)
		{
			txtMaNV.Focus();
			txtMaNV.Text = "";
			txtGioiTinh.Text = "";
			txtSDT.Text = "";
			txtLuongCoBan.Text = "";
			txtDiaChi.Text = "";
			txtHoTen.Text = "";
			txtTuoi.Text = "";
			dtpNgayVaoLam.Value = DateTime.Now;
			txtCaTruc.Text = "";
			txtTenTaiKhoan.Text = "";
			txtMatKhau.Text = "";
			txtLoaiTaiKhoan.Text = "";
		}

		#endregion

		#region nút huỷ
		private void btnHuy_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bạn chắc chắn muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			this.Close();
		}
        #endregion

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
