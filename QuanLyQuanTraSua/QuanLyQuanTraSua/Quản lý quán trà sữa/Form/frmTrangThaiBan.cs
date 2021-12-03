using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccess;
using System.Windows.Forms;

namespace Quản_lý_quán_trà_sữa
{
    public partial class frmTrangThaiBan : Form
    {
        List<Table> tableList = new List<Table>();
        public frmTrangThaiBan()
        {
            InitializeComponent();
        }
        private void frmTrangThaiBan_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        #region Method
        private void LoadTable()
        {
            string trangThai;   
            TableBL tableBL = new TableBL();
            tableList = tableBL.GetAll();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                flpDanhSachBan.Controls.Add(btn);
                if (item.TrangThaiBan == 0)
                {
                    trangThai = "Bàn trống";
                }
                else
                {
                    trangThai = "Hoạt động";
                }
                btn.Text = item.TenBan + Environment.NewLine + trangThai;
                btn.ForeColor = Color.White;
                btn.Click += Btn_Click;
                btn.Tag = item;

                switch(item.TrangThaiBan)
                {
                    case 0:
                        btn.BackColor = Color.Black;
                        break;
                    case 1:
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        break;
                }    
            }
        }

        void ShowBill(int id)
        {

        }
        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = (sender as Table).MaBan;
            ShowBill(tableID);
        }
        #endregion

    }
}
