using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
	public partial class fBanAn : Form
	{
		private TaiKhoan taiKhoanDangNhap;

		public TaiKhoan TaiKhoanDangNhap { get => taiKhoanDangNhap; set { taiKhoanDangNhap = value; ThayDoiTaiKhoan(taiKhoanDangNhap.LoaiTK); } }
		public fBanAn(TaiKhoan taiKhoan)
		{
			InitializeComponent();
			HienThiBanAn();
			HienThiLoaiMon();
			this.TaiKhoanDangNhap = taiKhoan;
			
		}
		#region Method
		void ThayDoiTaiKhoan(int loaitk)
		{
			adminToolStripMenuItem.Enabled = loaitk == 1;
			thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + taiKhoanDangNhap.TenHienThi + ")";
		}
		void HienThiLoaiMon()
		{
			List<LoaiMon> dsLoaiMon = LoaiMonDAO.Instance.LayDanhSachLoaiMon();
			cbLoaiMon.DataSource = dsLoaiMon;
			cbLoaiMon.DisplayMember = "TenLoai";
		}
		void HienThiMonAnTheoIDLM(int id)
		{
			List<MonAn> dsMonAn = MonAnDAO.Instance.LayMonAnTuidLoaiMon(id);
			cbMonAn.DataSource = dsMonAn;
			cbMonAn.DisplayMember = "TenMon";

			HienThiGiaMon();
			
		}
		void HienThiGiaMon()
		{
			CultureInfo culture = new CultureInfo("vi-VN");
			if(nmSoLuong.Value > 0)
			{
				txtGiaTien.Text = ((int)(cbMonAn.SelectedItem as MonAn).Gia * (int)nmSoLuong.Value).ToString("c", culture);
			}
			else
			{
				txtGiaTien.Text = "0";
			}
			
		}
		void HienThiBanAn()
		{
			flpBanAn.Controls.Clear();
			List<BanAn> DSBanAn = BanAnDAO.Instance.LoadDSBanAn();

			foreach (BanAn item in DSBanAn)
			{
				Button btn = new Button() { Width = BanAnDAO.TableWidth, Height = BanAnDAO.TableHeight };
				btn.Text = item.TenBan + Environment.NewLine + item.Trangthai;
				btn.Click += btn_Click;

				btn.Tag = item;
				switch (item.Trangthai)
				{
					case "Trống":
						btn.BackColor = Color.Aqua; break;
					default:
						btn.BackColor = Color.LightPink; break;
				}
				flpBanAn.Controls.Add(btn);
			}
		}
		float tt = 0;
		CultureInfo culture = new CultureInfo("vi-VN");


		void hienThiHoaDon(int id)
		{
			lsvHoaDon.Items.Clear();
			List<DSMonAn> DSMA = DSMonAnDAO.Instance.LayDSMonAnTuBan(id);
			float tongtien = 0;
			foreach (DSMonAn item in DSMA)
			{
				ListViewItem lsvItem = new ListViewItem(item.TenMa.ToString());
				lsvItem.SubItems.Add(item.SoLuong.ToString());
				lsvItem.SubItems.Add(item.Gia.ToString());
				lsvItem.SubItems.Add(item.ThanhTien.ToString());
				tongtien += item.ThanhTien;
				lsvHoaDon.Items.Add(lsvItem);
			}
			tt = tongtien;
			nmGiamGia.Value = 0;
			tongtien *=(float)(1- (float)nmGiamGia.Value * 0.01);
			CultureInfo culture = new CultureInfo("vi-VN");
			txtTongTien.Text = tongtien.ToString("c", culture);
		}
		#endregion

		#region event
		private void btn_Click(object sender, EventArgs e)
		{
			int idBanAn = ((sender as Button).Tag as BanAn).IDBAN;
			lsvHoaDon.Tag = (sender as Button).Tag;
			hienThiHoaDon(idBanAn);
		}
		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			BanAn banan = lsvHoaDon.Tag as BanAn;

			int idHD = HoaDonDAO.Instance.LayHoaDonChuaThanhToanTuIDBan(banan.IDBAN);
			int giamgia = (int)nmGiamGia.Value;
			
			if (idHD != -1)
			{
				if (MessageBox.Show(string.Format("Bạn muốn thanh toán hóa đơn cho {0} \nTổng tiền: {1}\nGiảm giá: {2}%\nTổng tiền: {3}", banan.TenBan,tt.ToString("c",culture),nmGiamGia.Value.ToString(),txtTongTien.Text), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
				{
					HoaDonDAO.Instance.ThanhToan(idHD,giamgia);
					hienThiHoaDon(banan.IDBAN);
					HienThiBanAn();
				}
			}
		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fTaiKhoan f = new fTaiKhoan(taiKhoanDangNhap);
			f.ShowDialog();

		}
		
		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAdmin f = new fAdmin();
			f.taikhoanhientai = TaiKhoanDangNhap;
			f.ShowDialog();

		}
		#endregion

		private void cbChuyenBan_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = 0;
			ComboBox cb = sender as ComboBox;

			if (cb.SelectedItem == null)
				return;

			LoaiMon selected = cb.SelectedItem as LoaiMon;
			id = selected.Idlm;
			HienThiMonAnTheoIDLM(id);
		}

		private void btnThemMon_Click(object sender, EventArgs e)
		{
			BanAn banan = lsvHoaDon.Tag as BanAn;
			int idHD = HoaDonDAO.Instance.LayHoaDonChuaThanhToanTuIDBan(banan.IDBAN);
			int idMA = (cbMonAn.SelectedItem as MonAn).Idma;
			int soluong = (int)nmSoLuong.Value;
			if (idHD == -1)
			{
				HoaDonDAO.Instance.TaoHoaDon(banan.IDBAN);
				TTHoaDonDAO.Instance.TaoThongTinHoaDon(HoaDonDAO.Instance.LayIDHDCaoNhat(), idMA, soluong);
			}
			else
			{
				TTHoaDonDAO.Instance.TaoThongTinHoaDon(idHD, idMA, soluong);
			}
			hienThiHoaDon(banan.IDBAN);
			HienThiBanAn();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void nmSoLuong_ValueChanged(object sender, EventArgs e)
		{
			HienThiGiaMon();
		}

		
		private void nmGiamGia_ValueChanged(object sender, EventArgs e)
		{
			float tongtien = tt * (float)(1 - (float)nmGiamGia.Value * 0.01);
			
			txtTongTien.Text = tongtien.ToString("c", culture);
		}
	}
}
