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
            TableBL tableBL = new TableBL();
            tableList = tableBL.GetAll();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = 50, Height = 50 };
                flpDanhSachBan.Controls.Add(btn);
            }
        }
        #endregion

        
    }
}
