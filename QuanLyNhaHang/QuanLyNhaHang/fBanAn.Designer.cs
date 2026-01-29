namespace QuanLyNhaHang
{
	partial class fBanAn
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lsvHoaDon = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.flpBanAn = new System.Windows.Forms.FlowLayoutPanel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGiaTien = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
			this.btnThemMon = new System.Windows.Forms.Button();
			this.cbMonAn = new System.Windows.Forms.ComboBox();
			this.cbLoaiMon = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1313, 36);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 32);
			this.adminToolStripMenuItem.Text = "Admin";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
			this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
			this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Tài khoản";
			// 
			// xemThôngTinToolStripMenuItem
			// 
			this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
			this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
			this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
			this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.flpBanAn);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1313, 575);
			this.panel2.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lsvHoaDon);
			this.panel1.Location = new System.Drawing.Point(780, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(498, 355);
			this.panel1.TabIndex = 6;
			// 
			// lsvHoaDon
			// 
			this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lsvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvHoaDon.GridLines = true;
			this.lsvHoaDon.HideSelection = false;
			this.lsvHoaDon.Location = new System.Drawing.Point(0, 0);
			this.lsvHoaDon.Name = "lsvHoaDon";
			this.lsvHoaDon.Size = new System.Drawing.Size(498, 355);
			this.lsvHoaDon.TabIndex = 0;
			this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
			this.lsvHoaDon.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên món";
			this.columnHeader1.Width = 123;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số lượng";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Đơn giá";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Thành tiền";
			this.columnHeader4.Width = 85;
			// 
			// flpBanAn
			// 
			this.flpBanAn.AutoScroll = true;
			this.flpBanAn.Location = new System.Drawing.Point(5, 3);
			this.flpBanAn.Name = "flpBanAn";
			this.flpBanAn.Size = new System.Drawing.Size(768, 563);
			this.flpBanAn.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.nmGiamGia);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.txtTongTien);
			this.panel3.Controls.Add(this.btnThanhToan);
			this.panel3.Location = new System.Drawing.Point(774, 503);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(507, 96);
			this.panel3.TabIndex = 3;
			// 
			// nmGiamGia
			// 
			this.nmGiamGia.Location = new System.Drawing.Point(19, 50);
			this.nmGiamGia.Name = "nmGiamGia";
			this.nmGiamGia.Size = new System.Drawing.Size(62, 26);
			this.nmGiamGia.TabIndex = 10;
			this.nmGiamGia.ValueChanged += new System.EventHandler(this.nmGiamGia_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(245, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Tổng tiền";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Giảm giá(%)";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.txtTongTien.Location = new System.Drawing.Point(235, 50);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(142, 26);
			this.txtTongTien.TabIndex = 6;
			this.txtTongTien.Text = "0";
			this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.AutoSize = true;
			this.btnThanhToan.Location = new System.Drawing.Point(383, 5);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(104, 81);
			this.btnThanhToan.TabIndex = 3;
			this.btnThanhToan.Text = "Thanh Toán";
			this.btnThanhToan.UseVisualStyleBackColor = true;
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.txtGiaTien);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.nmSoLuong);
			this.panel4.Controls.Add(this.btnThemMon);
			this.panel4.Controls.Add(this.cbMonAn);
			this.panel4.Controls.Add(this.cbLoaiMon);
			this.panel4.Location = new System.Drawing.Point(774, 36);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(507, 99);
			this.panel4.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(326, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Giá";
			// 
			// txtGiaTien
			// 
			this.txtGiaTien.Location = new System.Drawing.Point(366, 55);
			this.txtGiaTien.Name = "txtGiaTien";
			this.txtGiaTien.ReadOnly = true;
			this.txtGiaTien.Size = new System.Drawing.Size(141, 26);
			this.txtGiaTien.TabIndex = 4;
			this.txtGiaTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(326, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Số lượng";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(-4, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tên món";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-4, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Loại món";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// nmSoLuong
			// 
			this.nmSoLuong.Location = new System.Drawing.Point(431, 6);
			this.nmSoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nmSoLuong.Name = "nmSoLuong";
			this.nmSoLuong.Size = new System.Drawing.Size(73, 26);
			this.nmSoLuong.TabIndex = 3;
			this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmSoLuong.ValueChanged += new System.EventHandler(this.nmSoLuong_ValueChanged);
			// 
			// btnThemMon
			// 
			this.btnThemMon.AutoSize = true;
			this.btnThemMon.Location = new System.Drawing.Point(226, 3);
			this.btnThemMon.Name = "btnThemMon";
			this.btnThemMon.Size = new System.Drawing.Size(94, 81);
			this.btnThemMon.TabIndex = 2;
			this.btnThemMon.Text = "Thêm món";
			this.btnThemMon.UseVisualStyleBackColor = true;
			this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
			// 
			// cbMonAn
			// 
			this.cbMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMonAn.FormattingEnabled = true;
			this.cbMonAn.Location = new System.Drawing.Point(73, 58);
			this.cbMonAn.Name = "cbMonAn";
			this.cbMonAn.Size = new System.Drawing.Size(147, 28);
			this.cbMonAn.TabIndex = 1;
			this.cbMonAn.SelectedIndexChanged += new System.EventHandler(this.nmSoLuong_ValueChanged);
			// 
			// cbLoaiMon
			// 
			this.cbLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbLoaiMon.FormattingEnabled = true;
			this.cbLoaiMon.Location = new System.Drawing.Point(73, 6);
			this.cbLoaiMon.Name = "cbLoaiMon";
			this.cbLoaiMon.Size = new System.Drawing.Size(147, 28);
			this.cbLoaiMon.TabIndex = 0;
			this.cbLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbLoaiMon_SelectedIndexChanged);
			// 
			// fBanAn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1313, 611);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "fBanAn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý nhà hàng ";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView lsvHoaDon;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ComboBox cbMonAn;
		private System.Windows.Forms.ComboBox cbLoaiMon;
		private System.Windows.Forms.NumericUpDown nmSoLuong;
		private System.Windows.Forms.Button btnThemMon;
		private System.Windows.Forms.FlowLayoutPanel flpBanAn;
		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGiaTien;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nmGiamGia;
	}
}