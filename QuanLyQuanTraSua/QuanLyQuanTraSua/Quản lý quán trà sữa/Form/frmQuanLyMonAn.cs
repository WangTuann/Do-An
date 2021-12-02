using BusinessLogic;
using DataAccess;
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
    public partial class frmQuanLyMonAn : Form
    {
        public frmQuanLyMonAn()
        {
            InitializeComponent();
            LoadLoaiNuoc();
            LoadNuocDataToListView();
        }

        #region khai báo đối tượng toàn cục

        // danh sách toàn cục bảng LoaiNuoc
        List<LoaiNuoc> listLoaiNuoc = new List<LoaiNuoc>();

        // danh sách toàn cục bảng nước uống
        List<NuocUong> listNuocUong = new List<NuocUong>();

        // đối tượng NuocUong đang chọn hiện hành
        NuocUong nuocUongCurrent = new NuocUong();

        #endregion

        #region LoadLoaiNuoc - LoadNuocDataToListView

        private void LoadLoaiNuoc()
        {
            LoaiNuocBL loaiNuocBL = new LoaiNuocBL();

            listLoaiNuoc = loaiNuocBL.GetAll();

            cbbLoaiNuoc.DataSource = listLoaiNuoc;
            cbbLoaiNuoc.ValueMember = "MaLoai";
            cbbLoaiNuoc.DisplayMember = "TenLoai";
        }

        public void LoadNuocDataToListView()
        {
            NuocUongBL nuocUongBL = new NuocUongBL();

            listNuocUong = nuocUongBL.GetAll();
            int count = 1; // Biến số thứ tự
                           // Xoá dữ liệu trong ListView
            lvNuocUong.Items.Clear();
            // Duyệt mảng dữ liệu để đưa vào ListView
            foreach (var nuocUong in listNuocUong)
            {
                // Số thứ tự
                ListViewItem item = lvNuocUong.Items.Add(count.ToString());
                // Đưa dữ liệu TenNuoc, TenLoai, DonGia, DVT vào cột tiếp theo
                item.SubItems.Add(nuocUong.TenNuocUong);
                string tenLoai = listLoaiNuoc.Find(x => x.MaLoai == nuocUong.MaLoai).TenLoai;
                item.SubItems.Add(tenLoai);
                item.SubItems.Add(nuocUong.DonGia.ToString());
                item.SubItems.Add(nuocUong.DVT);
                // Theo dữ liệu của bảng MaLoaiNuoc, lấy Name để hiển thị
                count++;
            }
        }

        #endregion

        #region Load dữ liệu vào các control

        private void lvNuocUong_Click(object sender, EventArgs e)
        {
            // duyệt trong lv
            for (int i = 0; i < lvNuocUong.Items.Count; i++)
            {
                // nếu có thì lấy
                if (lvNuocUong.Items[i].Selected)
                {
                    nuocUongCurrent = listNuocUong[i];
                    txtTenNuocUong.Text = nuocUongCurrent.TenNuocUong;
                    txtIDNuoc.Text = nuocUongCurrent.MaNuocUong.ToString();
                    txtDonGia.Text = nuocUongCurrent.DonGia.ToString();
                    txtDVT.Text = nuocUongCurrent.DVT.ToString();
                    // lấy index của cbb theo mã loại nước uống
                    cbbLoaiNuoc.SelectedIndex = listLoaiNuoc.FindIndex(x => x.MaLoai == nuocUongCurrent.MaLoai);
                }
            }
        }

        #endregion

        #region nút thêm
        public int InsertNuoc()
        {
            NuocUong nuocUong = new NuocUong();
            nuocUong.MaNuocUong = 0;
            // kiểm tra các ô đã đầy đủ thông tin hay chưa
            if (txtTenNuocUong.Text == "" || txtDVT.Text == "" || txtDonGia.Text == "" || cbbLoaiNuoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng kiểm tra đầy đủ dữ liệu trước khi thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // giá trị DonGia là số nên bắt lỗi khi người dùng vô tình nhập sai
                int donGia = 0;
                try
                {
                    // lấy giá trị trong ô
                    donGia = int.Parse(txtDonGia.Text);
                }
                catch (Exception)
                {
                    // nếu sai thì gán giá trị lại cho DonGia = 0
                    donGia = 0;
                }
                nuocUong.DonGia = donGia;
                nuocUong.TenNuocUong = txtTenNuocUong.Text;
                nuocUong.DVT = txtDVT.Text;
                // giá trị của MaLoai được lấy từ cbb
                nuocUong.MaLoai = int.Parse(cbbLoaiNuoc.SelectedValue.ToString());
                // khai báo đối tượng NuocUongBL từ tầng Business
                NuocUongBL nuocUongBL = new NuocUongBL();
                // chèn dữ liệu vào
                return nuocUongBL.Insert(nuocUong);

            }
            return -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // gọi phương thức thêm dữ liệu
            int result = InsertNuoc();
            if (result > 0)
            {
                MessageBox.Show("Đã thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNuocDataToListView();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region nút xoá
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNuocUong.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá món ăn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    NuocUongBL nuocUongBL = new NuocUongBL();
                    if (nuocUongBL.Delete(nuocUongCurrent) > 0)
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNuocDataToListView();
                    }
                    else MessageBox.Show("Xoá không thành công, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Bạn phải chọn đối tượng để xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region cập nhật món
        public int UpdateNuocUong()
        {
            NuocUong nuocUong = nuocUongCurrent;
            if (txtDonGia.Text == "" || txtDVT.Text == "" || txtIDNuoc.Text == "" || txtTenNuocUong.Text == "")
            {
                MessageBox.Show("Kiểm tra bạn đã nhập thông tin đã đủ hay chưa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nuocUong.TenNuocUong = txtTenNuocUong.Text;
                nuocUong.DVT = txtDVT.Text;
                nuocUong.MaLoai = int.Parse(cbbLoaiNuoc.SelectedValue.ToString());
                int donGia;
                try
                {
                    donGia = int.Parse(txtDonGia.Text);
                }
                catch (Exception)
                {
                    donGia = 0;
                }
                nuocUong.DonGia = donGia;

                NuocUongBL nuocUongBL = new NuocUongBL();

                return nuocUongBL.Update(nuocUong);
            }
            return -1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int result = UpdateNuocUong();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNuocDataToListView();
            }
            else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm lại dữ liệu nhập");
        }
        #endregion

        #region nút reset 
        private void btnHuy_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn chắc chắn huỷ thao tác này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                txtIDNuoc.Text = "";
                txtDonGia.Text = "";
                txtTenNuocUong.Text = "";
                txtDVT.Text = "";
            }
        }

        #endregion

        #region Tìm kiếm
        List<NuocUong> TimKiemNuocBangTen(string ten)
        {
            List<NuocUong> dsNuocUong = new List<NuocUong>();

            return dsNuocUong;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiemNuocBangTen(txtTenNuocUong.Text);
        }
        #endregion

        #region Thêm loại nước
        public int InsertLoaiNuoc()
        {
            LoaiNuoc loaiNuoc = new LoaiNuoc();
            loaiNuoc.MaLoai = 0;
            if (txtThemLoai.Text == "")
            {
                MessageBox.Show("Lỗi khi thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                loaiNuoc.TenLoai = txtThemLoai.Text;
                LoaiNuocBL loaiNuocBL = new LoaiNuocBL();
                return loaiNuocBL.Insert(loaiNuoc);
            }
            return -1;
        }
        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            txtThemLoai.Visible = true;
            btnDongYLoai.Visible = true;
        }
        #endregion

        private void btnDongYLoai_Click(object sender, EventArgs e)
        {
            int result = InsertLoaiNuoc();
            if (result > 0)
            {
                MessageBox.Show("Đã thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiNuoc();
                txtThemLoai.Visible=false;
                btnDongYLoai.Visible = false;
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
