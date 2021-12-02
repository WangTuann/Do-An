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
	public partial class frmAccount : Form
	{
		public frmAccount()
		{
			InitializeComponent();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

		}

		private void btnSua_Click(object sender, EventArgs e)
		{

		}
		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có đăng xuất ứng dụng hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
			{
				txtMaTaiKhoan.Text = "";
				txtMaNV.Text = "";
				txtTenDangNhap.Text = "";
				txtMK.Text = "";
				txtChucVu.Text = "";
			}
		}
	}
}
