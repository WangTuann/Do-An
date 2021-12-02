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
	public partial class frmThongKeNhanVien : Form
	{
		public frmThongKeNhanVien()
		{
			InitializeComponent();
		}

		private void btnThemNhanVien_Click(object sender, EventArgs e)
		{
			frmNhanVien frm = new frmNhanVien();
			frm.ShowDialog();
		}
	}
}
