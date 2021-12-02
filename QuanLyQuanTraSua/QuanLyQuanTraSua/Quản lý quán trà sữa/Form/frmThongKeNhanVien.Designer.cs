
namespace Quản_lý_quán_trà_sữa
{
	partial class frmThongKeNhanVien
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
            this.btnThemNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.BorderRadius = 10;
            this.btnThemNhanVien.CheckedState.Parent = this.btnThemNhanVien;
            this.btnThemNhanVien.CustomImages.Parent = this.btnThemNhanVien;
            this.btnThemNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemNhanVien.DisabledState.Parent = this.btnThemNhanVien;
            this.btnThemNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.HoverState.Parent = this.btnThemNhanVien;
            this.btnThemNhanVien.Image = global::Quản_lý_quán_trà_sữa.Properties.Resources.add_50px;
            this.btnThemNhanVien.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThemNhanVien.Location = new System.Drawing.Point(12, 12);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.ShadowDecoration.Parent = this.btnThemNhanVien;
            this.btnThemNhanVien.Size = new System.Drawing.Size(158, 45);
            this.btnThemNhanVien.TabIndex = 26;
            this.btnThemNhanVien.Text = "Thêm nhân viên";
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(513, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(12, 91);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(1251, 682);
            this.lvNhanVien.TabIndex = 28;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            // 
            // frmThongKeNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1381, 785);
            this.Controls.Add(this.lvNhanVien);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btnThemNhanVien;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvNhanVien;
    }
}