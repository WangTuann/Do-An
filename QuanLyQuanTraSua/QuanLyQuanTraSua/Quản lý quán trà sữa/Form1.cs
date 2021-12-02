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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region nút đăng nhập
		private void btnLogin_Click(object sender, EventArgs e)
		{
			//	SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-O55J47Q;Initial Catalog=QuanLyTraSua;Integrated Security=True");
			//	SqlDataAdapter data = new SqlDataAdapter("select * from TaiKhoan where TenDangNhap=N'" + txtTenDangNhap.Text + "'and MatKhau = N'" + txtMatKhau.Text + "'", cn);
			//	DataTable dt = new DataTable();
			//	data.Fill(dt);
			//if (String.IsNullOrEmpty(txtUser.Text.Trim()))
			//{
			//	MessageBox.Show("Bạn chưa điền tên đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	txtUser.Focus();
			//	return;
			//}
			//if (String.IsNullOrEmpty(txtPass.Text.Trim()))
			//{
			//	MessageBox.Show("Bạn chưa điền mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	txtPass.Focus();
			//	return;
			//}
			//if (dt.Rows.Count > 0)
			//{
			//	MessageBox.Show("đăng nhập thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//	//frmMain frm = new frmMain(dt.rows[0][0].tostring(), dt.rows[0][1].tostring(), dt.rows[0][2].tostring());
			//	frmMain frm = new frmMain();
			//	this.Hide();
			//	frm.ShowDialog();
			//	this.Show();
			//	return;
			//}
			//else
			//{
			//	MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	txtTenDangNhap.Focus();
			//	return;
			//}
			frmMain frm = new frmMain();
			this.Hide();
			frm.ShowDialog();
			this.Show();

		}
		#endregion

		#region nút thoát và sự kiện thoát app
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
		}
		#endregion
	}
}
