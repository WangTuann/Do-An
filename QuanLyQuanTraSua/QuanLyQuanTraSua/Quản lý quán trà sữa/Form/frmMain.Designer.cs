
namespace Quản_lý_quán_trà_sữa
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlChildForm = new System.Windows.Forms.Panel();
			this.pnlContentMenu = new System.Windows.Forms.Panel();
			this.btnDangXuat = new System.Windows.Forms.Button();
			this.pnlAdmin = new System.Windows.Forms.Panel();
			this.btnDoiMatKhau = new System.Windows.Forms.Button();
			this.btnThongKeNhanVien = new System.Windows.Forms.Button();
			this.btnQuanLyHoaDon = new System.Windows.Forms.Button();
			this.btnQuanLyBan = new System.Windows.Forms.Button();
			this.btnQuanLyMon = new System.Windows.Forms.Button();
			this.btnQuanLy = new System.Windows.Forms.Button();
			this.pnlNhanVien = new System.Windows.Forms.Panel();
			this.btnInHoaDon = new System.Windows.Forms.Button();
			this.btnChonMon = new System.Windows.Forms.Button();
			this.btnDatMon = new System.Windows.Forms.Button();
			this.btnChucNang = new System.Windows.Forms.Button();
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.pnlContentMenu.SuspendLayout();
			this.pnlAdmin.SuspendLayout();
			this.pnlNhanVien.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlChildForm
			// 
			this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlChildForm.Location = new System.Drawing.Point(250, 0);
			this.pnlChildForm.Name = "pnlChildForm";
			this.pnlChildForm.Size = new System.Drawing.Size(1271, 816);
			this.pnlChildForm.TabIndex = 4;
			// 
			// pnlContentMenu
			// 
			this.pnlContentMenu.AutoScroll = true;
			this.pnlContentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.pnlContentMenu.Controls.Add(this.btnDangXuat);
			this.pnlContentMenu.Controls.Add(this.pnlAdmin);
			this.pnlContentMenu.Controls.Add(this.btnQuanLy);
			this.pnlContentMenu.Controls.Add(this.pnlNhanVien);
			this.pnlContentMenu.Controls.Add(this.btnChucNang);
			this.pnlContentMenu.Controls.Add(this.pnlLogo);
			this.pnlContentMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlContentMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlContentMenu.Name = "pnlContentMenu";
			this.pnlContentMenu.Size = new System.Drawing.Size(250, 816);
			this.pnlContentMenu.TabIndex = 3;
			// 
			// btnDangXuat
			// 
			this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnDangXuat.FlatAppearance.BorderSize = 0;
			this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnDangXuat.Location = new System.Drawing.Point(0, 771);
			this.btnDangXuat.Name = "btnDangXuat";
			this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnDangXuat.Size = new System.Drawing.Size(250, 45);
			this.btnDangXuat.TabIndex = 9;
			this.btnDangXuat.Text = "Đăng xuất";
			this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDangXuat.UseVisualStyleBackColor = true;
			this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
			// 
			// pnlAdmin
			// 
			this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
			this.pnlAdmin.Controls.Add(this.btnDoiMatKhau);
			this.pnlAdmin.Controls.Add(this.btnThongKeNhanVien);
			this.pnlAdmin.Controls.Add(this.btnQuanLyHoaDon);
			this.pnlAdmin.Controls.Add(this.btnQuanLyBan);
			this.pnlAdmin.Controls.Add(this.btnQuanLyMon);
			this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAdmin.Location = new System.Drawing.Point(0, 313);
			this.pnlAdmin.Name = "pnlAdmin";
			this.pnlAdmin.Size = new System.Drawing.Size(250, 208);
			this.pnlAdmin.TabIndex = 4;
			// 
			// btnDoiMatKhau
			// 
			this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
			this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoiMatKhau.ForeColor = System.Drawing.Color.LightGray;
			this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 160);
			this.btnDoiMatKhau.Name = "btnDoiMatKhau";
			this.btnDoiMatKhau.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnDoiMatKhau.Size = new System.Drawing.Size(250, 40);
			this.btnDoiMatKhau.TabIndex = 5;
			this.btnDoiMatKhau.Text = "Đổi mật khẩu cho Admin";
			this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoiMatKhau.UseVisualStyleBackColor = true;
			this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click_1);
			// 
			// btnThongKeNhanVien
			// 
			this.btnThongKeNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnThongKeNhanVien.FlatAppearance.BorderSize = 0;
			this.btnThongKeNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThongKeNhanVien.ForeColor = System.Drawing.Color.LightGray;
			this.btnThongKeNhanVien.Location = new System.Drawing.Point(0, 120);
			this.btnThongKeNhanVien.Name = "btnThongKeNhanVien";
			this.btnThongKeNhanVien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnThongKeNhanVien.Size = new System.Drawing.Size(250, 40);
			this.btnThongKeNhanVien.TabIndex = 3;
			this.btnThongKeNhanVien.Text = "Thống kê nhân viên";
			this.btnThongKeNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThongKeNhanVien.UseVisualStyleBackColor = true;
			this.btnThongKeNhanVien.Click += new System.EventHandler(this.btnThongKeNhanVien_Click_1);
			// 
			// btnQuanLyHoaDon
			// 
			this.btnQuanLyHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnQuanLyHoaDon.FlatAppearance.BorderSize = 0;
			this.btnQuanLyHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyHoaDon.ForeColor = System.Drawing.Color.LightGray;
			this.btnQuanLyHoaDon.Location = new System.Drawing.Point(0, 80);
			this.btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
			this.btnQuanLyHoaDon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnQuanLyHoaDon.Size = new System.Drawing.Size(250, 40);
			this.btnQuanLyHoaDon.TabIndex = 2;
			this.btnQuanLyHoaDon.Text = "Quản lý hoá đơn";
			this.btnQuanLyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnQuanLyHoaDon.UseVisualStyleBackColor = true;
			this.btnQuanLyHoaDon.Click += new System.EventHandler(this.btnQuanLyHoaDon_Click);
			// 
			// btnQuanLyBan
			// 
			this.btnQuanLyBan.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnQuanLyBan.FlatAppearance.BorderSize = 0;
			this.btnQuanLyBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyBan.ForeColor = System.Drawing.Color.LightGray;
			this.btnQuanLyBan.Location = new System.Drawing.Point(0, 40);
			this.btnQuanLyBan.Name = "btnQuanLyBan";
			this.btnQuanLyBan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnQuanLyBan.Size = new System.Drawing.Size(250, 40);
			this.btnQuanLyBan.TabIndex = 1;
			this.btnQuanLyBan.Text = "Quản lý bàn";
			this.btnQuanLyBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnQuanLyBan.UseVisualStyleBackColor = true;
			this.btnQuanLyBan.Click += new System.EventHandler(this.btnQuanLyBan_Click);
			// 
			// btnQuanLyMon
			// 
			this.btnQuanLyMon.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnQuanLyMon.FlatAppearance.BorderSize = 0;
			this.btnQuanLyMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			this.btnQuanLyMon.ForeColor = System.Drawing.Color.LightGray;
			this.btnQuanLyMon.Location = new System.Drawing.Point(0, 0);
			this.btnQuanLyMon.Name = "btnQuanLyMon";
			this.btnQuanLyMon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnQuanLyMon.Size = new System.Drawing.Size(250, 40);
			this.btnQuanLyMon.TabIndex = 0;
			this.btnQuanLyMon.Text = "Quản lý món";
			this.btnQuanLyMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnQuanLyMon.UseVisualStyleBackColor = true;
			this.btnQuanLyMon.Click += new System.EventHandler(this.btnQuanLyMon_Click);
			// 
			// btnQuanLy
			// 
			this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnQuanLy.FlatAppearance.BorderSize = 0;
			this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLy.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnQuanLy.Location = new System.Drawing.Point(0, 268);
			this.btnQuanLy.Name = "btnQuanLy";
			this.btnQuanLy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnQuanLy.Size = new System.Drawing.Size(250, 45);
			this.btnQuanLy.TabIndex = 3;
			this.btnQuanLy.Text = "Quản lý";
			this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnQuanLy.UseVisualStyleBackColor = true;
			this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
			// 
			// pnlNhanVien
			// 
			this.pnlNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
			this.pnlNhanVien.Controls.Add(this.btnInHoaDon);
			this.pnlNhanVien.Controls.Add(this.btnChonMon);
			this.pnlNhanVien.Controls.Add(this.btnDatMon);
			this.pnlNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlNhanVien.Location = new System.Drawing.Point(0, 145);
			this.pnlNhanVien.Name = "pnlNhanVien";
			this.pnlNhanVien.Size = new System.Drawing.Size(250, 123);
			this.pnlNhanVien.TabIndex = 2;
			// 
			// btnInHoaDon
			// 
			this.btnInHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnInHoaDon.FlatAppearance.BorderSize = 0;
			this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInHoaDon.ForeColor = System.Drawing.Color.LightGray;
			this.btnInHoaDon.Location = new System.Drawing.Point(0, 80);
			this.btnInHoaDon.Name = "btnInHoaDon";
			this.btnInHoaDon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnInHoaDon.Size = new System.Drawing.Size(250, 40);
			this.btnInHoaDon.TabIndex = 2;
			this.btnInHoaDon.Text = "In hoá đơn trong ngày";
			this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInHoaDon.UseVisualStyleBackColor = true;
			this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
			// 
			// btnChonMon
			// 
			this.btnChonMon.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnChonMon.FlatAppearance.BorderSize = 0;
			this.btnChonMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChonMon.ForeColor = System.Drawing.Color.LightGray;
			this.btnChonMon.Location = new System.Drawing.Point(0, 40);
			this.btnChonMon.Name = "btnChonMon";
			this.btnChonMon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnChonMon.Size = new System.Drawing.Size(250, 40);
			this.btnChonMon.TabIndex = 1;
			this.btnChonMon.Text = "Chọn món";
			this.btnChonMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChonMon.UseVisualStyleBackColor = true;
			this.btnChonMon.Click += new System.EventHandler(this.btnChonMon_Click);
			// 
			// btnDatMon
			// 
			this.btnDatMon.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDatMon.FlatAppearance.BorderSize = 0;
			this.btnDatMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDatMon.ForeColor = System.Drawing.Color.LightGray;
			this.btnDatMon.Location = new System.Drawing.Point(0, 0);
			this.btnDatMon.Name = "btnDatMon";
			this.btnDatMon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.btnDatMon.Size = new System.Drawing.Size(250, 40);
			this.btnDatMon.TabIndex = 0;
			this.btnDatMon.Text = "Trạng thái bàn";
			this.btnDatMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDatMon.UseVisualStyleBackColor = true;
			this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
			// 
			// btnChucNang
			// 
			this.btnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnChucNang.FlatAppearance.BorderSize = 0;
			this.btnChucNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChucNang.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnChucNang.Location = new System.Drawing.Point(0, 100);
			this.btnChucNang.Name = "btnChucNang";
			this.btnChucNang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnChucNang.Size = new System.Drawing.Size(250, 45);
			this.btnChucNang.TabIndex = 1;
			this.btnChucNang.Text = "Chức năng";
			this.btnChucNang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChucNang.UseVisualStyleBackColor = true;
			this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
			// 
			// pnlLogo
			// 
			this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(250, 100);
			this.pnlLogo.TabIndex = 0;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1521, 816);
			this.Controls.Add(this.pnlChildForm);
			this.Controls.Add(this.pnlContentMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chức năng";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.pnlContentMenu.ResumeLayout(false);
			this.pnlAdmin.ResumeLayout(false);
			this.pnlNhanVien.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlChildForm;
		private System.Windows.Forms.Panel pnlContentMenu;
		private System.Windows.Forms.Button btnDangXuat;
		private System.Windows.Forms.Panel pnlAdmin;
		private System.Windows.Forms.Button btnDoiMatKhau;
		private System.Windows.Forms.Button btnThongKeNhanVien;
		private System.Windows.Forms.Button btnQuanLyHoaDon;
		private System.Windows.Forms.Button btnQuanLyBan;
		private System.Windows.Forms.Button btnQuanLyMon;
		private System.Windows.Forms.Button btnQuanLy;
		private System.Windows.Forms.Panel pnlNhanVien;
		private System.Windows.Forms.Button btnInHoaDon;
		private System.Windows.Forms.Button btnChonMon;
		private System.Windows.Forms.Button btnDatMon;
		private System.Windows.Forms.Button btnChucNang;
		private System.Windows.Forms.Panel pnlLogo;
	}
}