using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyNhaHang
{

	public partial class fAdmin : Form
	{
		BindingSource DSMonAn = new BindingSource();
		BindingSource DSLoaiMon = new BindingSource();
		BindingSource DSBanAn = new BindingSource();
		BindingSource DSTaiKhoan = new BindingSource();
		public TaiKhoan taikhoanhientai;
		public fAdmin()
		{
			InitializeComponent();
			load();
		}
		void load()
		{
			dgvMonAn.DataSource = DSMonAn;
			dgvLoaiMon.DataSource = DSLoaiMon;
			dgvBanAn.DataSource = DSBanAn;
			dgvTaiKhoan.DataSource = DSTaiKhoan;

			DateTimePickerHoaDon();
			HienThiDoanhThuTheoNgay(dtpNgay1.Value, dtpNgay2.Value);
			HienThicbBan();
			HienThiDSMonAn();
			HienThiLoaiMonVaoCB(cbLoaiMon);
			HienThiDSDoanhThuTheoBan();
			HienThiDSDoanhThuTheoHoaDon();
			HienThiDSLoaiMon();
			HienThiDSBanAn();
			HienThiTaiKhoan();
			BindingMonAn();
			BindingLoaiMon();
			BindingBanAn();
			BindingTaiKhoan();

		}
		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void txtIDMon_TextChanged(object sender, EventArgs e)
		{
			if (dgvMonAn.SelectedCells.Count > 0)
			{
				int id = (int)dgvMonAn.SelectedCells[0].OwningRow.Cells["idLM"].Value;
				LoaiMon loaimon = LoaiMonDAO.Instance.LayLoaiMonTuID(id);
				cbLoaiMon.SelectedItem = loaimon;

				int index = -1;
				int i = 0;
				foreach (LoaiMon item in cbLoaiMon.Items)
				{
					if (item.Idlm == loaimon.Idlm)
					{
						index = i; break;
					}
					i++;
				}
				cbLoaiMon.SelectedIndex = index;
			}



		}
		void DateTimePickerHoaDon()
		{
			DateTime today = DateTime.Now;
			dtpNgay1.Value = new DateTime(today.Year, today.Month, 1);
			dtpNgay2.Value = dtpNgay1.Value.AddMonths(1).AddDays(-1);
		}
		void HienThiDoanhThuTheoNgay(DateTime Ngay1, DateTime Ngay2)
		{
			dgvDoanhThuNgay.DataSource = HoaDonDAO.Instance.LayDoanhThuTheoNgay(Ngay1,Ngay2);
		}
		private void btnDoanhThuNgay_Click(object sender, EventArgs e)
		{
			HienThiDoanhThuTheoNgay(dtpNgay1.Value, dtpNgay2.Value);
		}
		void HienThiDSDoanhThuTheoHoaDon()
		{
			dgvDoanhThuHoaDon.DataSource = HoaDonDAO.Instance.LayDSDoanhThuTheoHoaDon();
		}

		private void dtpNgay1_ValueChanged(object sender, EventArgs e)
		{

		}
		void HienThiLoaiMonVaoCB(ComboBox cb)
		{
			cb.DataSource = LoaiMonDAO.Instance.LayDanhSachLoaiMon();
			cb.DisplayMember = "TenLoai";
		}
		void BindingMonAn()
		{
			txtTenMon.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "TenMon", true, DataSourceUpdateMode.Never));
			txtIDMon.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "idMa", true, DataSourceUpdateMode.Never));
			nmGiaMon.DataBindings.Add(new Binding("Value", dgvMonAn.DataSource, "Gia", true, DataSourceUpdateMode.Never));
		}
		void BindingBanAn()
		{
			txtIDBan.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "idBan", true, DataSourceUpdateMode.Never));
			txtTenBan.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "TenBan", true, DataSourceUpdateMode.Never));
			txtTrangThai.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
		}
		void BindingLoaiMon()
		{
			txtIDLoaiMon.DataBindings.Add(new Binding("Text", dgvLoaiMon.DataSource, "idLM", true, DataSourceUpdateMode.Never));
			txtTenLoaiMon.DataBindings.Add(new Binding("Text", dgvLoaiMon.DataSource, "TenLoai", true, DataSourceUpdateMode.Never));

		}
		void BindingTaiKhoan()
		{
			txtTenDangNhap.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
			txtTenHienThi.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "TenHienThi", true, DataSourceUpdateMode.Never));
			nmLoaiTK.DataBindings.Add(new Binding("Value", dgvTaiKhoan.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
		}

		void HienThiTaiKhoan()
		{
			DSTaiKhoan.DataSource = TaiKhoanDAO.Instance.LayDSTaiKhoan();
		}
		void HienThiDSMonAn()
		{
			DSMonAn.DataSource = MonAnDAO.Instance.LayDSMonAn();
		}
		void HienThiDSLoaiMon()
		{
			DSLoaiMon.DataSource = LoaiMonDAO.Instance.LayDanhSachLoaiMon();
		}

		void HienThiDSBanAn()
		{
			DSBanAn.DataSource = BanAnDAO.Instance.LoadDSBanAn();
		}
		
		private void btnThemMon_Click(object sender, EventArgs e)
		{
			string tenmon = txtTenMon.Text;
			int idlm = (cbLoaiMon.SelectedItem as LoaiMon).Idlm;
			float gia = (float)nmGiaMon.Value;

			if (MonAnDAO.Instance.ThemMonAn(tenmon, idlm, gia))
			{
				MessageBox.Show("Thêm món thành công");
				HienThiDSMonAn();
			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm món ăn");
			}
		}

		private void btnSuaMon_Click(object sender, EventArgs e)
		{
			string tenmon = txtTenMon.Text;
			int idlm = (cbLoaiMon.SelectedItem as LoaiMon).Idlm;
			float gia = (float)nmGiaMon.Value;
			int idma = Convert.ToInt32(txtIDMon.Text);

			if (MonAnDAO.Instance.CapNhatMonAn(idma, tenmon, idlm, gia))
			{
				MessageBox.Show("Sửa món thành công");
				HienThiDSMonAn();
			}
			else
			{
				MessageBox.Show("Có lỗi khi sửa món ăn");
			}
		}

		private void btnXoaMon_Click(object sender, EventArgs e)
		{
			int idma = Convert.ToInt32(txtIDMon.Text);

			if (MonAnDAO.Instance.XoaMonAn(idma))
			{
				MessageBox.Show("Xóa món thành công");
				HienThiDSMonAn();
			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa món ăn");
			}
		}

		private void btnThemLoaiMon_Click(object sender, EventArgs e)
		{
			string tenLoai = txtTenLoaiMon.Text;

			if (LoaiMonDAO.Instance.ThemLoaiMon(tenLoai))
			{
				MessageBox.Show("Thêm loại món thành công");
				HienThiDSLoaiMon();
			}
			else
			{
				MessageBox.Show("Có lỗi khi loại thêm món ăn");
			}
		}

		private void btnSuaLoaiMon_Click(object sender, EventArgs e)
		{
			string tenLoai = txtTenLoaiMon.Text;
			int idlm = Convert.ToInt32(txtIDLoaiMon.Text);

			if (LoaiMonDAO.Instance.CapNhatLoaiMon(idlm,tenLoai))
			{
				MessageBox.Show("Sửa loại món thành công");
				HienThiDSLoaiMon();
			}
			else
			{
				MessageBox.Show("Có lỗi khi loại Sửa món ăn");
			}
		}
		private void btnXoaLM_Click(object sender, EventArgs e)
		{
			int idlm = Convert.ToInt32(txtIDLoaiMon.Text);

			if (LoaiMonDAO.Instance.XoaLoaiMon(idlm))
			{
				MessageBox.Show("Xóa loại món thành công");
				HienThiDSLoaiMon();
			}
			else
			{
				MessageBox.Show("Có lỗi khi loại xóa món ăn");
			}
		}
		private void btnThemBan_Click(object sender, EventArgs e)
		{
			string tenban = txtTenBan.Text;
			string trangthai = txtTrangThai.Text;

			if (BanAnDAO.Instance.ThemBanAn(tenban,trangthai))
			{
				MessageBox.Show("Thêm bàn ăn thành công");
				HienThiDSBanAn();
			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm bàn ăn");
			}
		}

		private void btnSuaBan_Click(object sender, EventArgs e)
		{
			string tenban = txtTenBan.Text;
			string trangthai = txtTrangThai.Text;
			int idBan = Convert.ToInt32(txtIDBan.Text); 
			if (BanAnDAO.Instance.CapNhatBanAn(idBan,tenban, trangthai))
			{
				MessageBox.Show("Sửa bàn ăn thành công");
				HienThiDSBanAn();
			}
			else
			{
				MessageBox.Show("Có lỗi khi sửa bàn ăn");
			}
		}

		private void btnXoaBan_Click(object sender, EventArgs e)
		{
			
			int idBan = Convert.ToInt32(txtIDBan.Text);
			if (BanAnDAO.Instance.XoaBanAn(idBan))
			{
				MessageBox.Show("Xóa	 bàn ăn thành công");
				HienThiDSBanAn();
			}
			else
			{
				MessageBox.Show("Có lỗi khi Xóa bàn ăn");
			}
		}
		void ThemTK(string tendangnhap, string tenhienthi, int loaitk)
		{
			if(TaiKhoanDAO.Instance.ThemTaiKhoan(tendangnhap, tenhienthi, loaitk))
			{
				MessageBox.Show("Thêm tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Thêm tài khoản thất bại");
			}
			HienThiTaiKhoan();

		}
		void CapNhatTK(string tendangnhap, string tenhienthi, int loaitk)
		{
			if (TaiKhoanDAO.Instance.CapNhatTaiKhoan(tendangnhap, tenhienthi, loaitk))
			{
				MessageBox.Show("Sửa tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Sửa tài khoản thất bại");
			}
			HienThiTaiKhoan();

		}
		void XoaTK(string tendangnhap)
		{
			if (taikhoanhientai.TenDangNhap.Equals(tendangnhap))
			{
				MessageBox.Show("Không thể xóa bản thân");
				return;
			}else
			{
				if (TaiKhoanDAO.Instance.XoaTaiKhoan(tendangnhap))
				{
					MessageBox.Show("Xóa tài khoản thành công");
				}
				else
				{
					MessageBox.Show("Xóa tài khoản thất bại");
				}
				HienThiTaiKhoan();
			}
				

		}

		private void btnThemTaiKhoan_Click(object sender, EventArgs e)
		{
			string tenDangNhap = txtTenDangNhap.Text;
			string tenHienThi = txtTenHienThi.Text;
			int loaiTK = (int) nmLoaiTK.Value;

			ThemTK(tenDangNhap, tenHienThi, loaiTK);
		}

		private void btnXoataiKhoan_Click(object sender, EventArgs e)
		{
			string tenDangNhap = txtTenDangNhap.Text;

			XoaTK(tenDangNhap);
		}

		private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
		{
			string tenDangNhap = txtTenDangNhap.Text;
			string tenHienThi = txtTenHienThi.Text;
			int loaiTK = (int)nmLoaiTK.Value;

			CapNhatTK(tenDangNhap, tenHienThi, loaiTK);
		}

		void ResetMatKhau(string tendangnhap)
		{
			if (TaiKhoanDAO.Instance.ResetMatKhau(tendangnhap)){
				MessageBox.Show("Đặt lại mật khẩu thành công");
			}else
			{
				MessageBox.Show("Đặt lại mật khẩu thất bại");
			}
				
		}
		private void btnDatLaiMK_Click(object sender, EventArgs e)
		{
			string tendangnhap = txtTenDangNhap.Text;
			ResetMatKhau(tendangnhap);
		}

		private void panel26_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void txtTenHienThi_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel22_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tpTaikhoan_Click(object sender, EventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void label15_Click(object sender, EventArgs e)
		{

		}
		void HienThicbBan()
		{
			
			List<BanAn> dsBanAn = BanAnDAO.Instance.LoadDSBanAn();
			cbBan.DataSource = dsBanAn;
			cbBan.DisplayMember = "TenBan";
			
		}
		void HienThiDSDoanhThuTheoBan()
		{
			dgvDoanhThuBan.DataSource = HoaDonDAO.Instance.LayDSDoanhThuTheoBan();
		}
		void HienThiDoanhThuTheoBan(string tenban) { 
			
			dgvDoanhThuBan.DataSource = HoaDonDAO.Instance.LayDoanhThuTheoBan( tenban);
		}
		private void btnDoanhThuBan_Click(object sender, EventArgs e)
		{
			string tenBan = (cbBan.SelectedItem as BanAn).TenBan ;
			
			HienThiDoanhThuTheoBan(tenBan);
		}

		private void btnDoanhThuHoaDon_Click(object sender, EventArgs e)
		{

		}

		private void label16_Click(object sender, EventArgs e)
		{
					}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}
	
		private void btnDTNgay_Click(object sender, EventArgs e)
		{
			HienThiDoanhThuTheoNgay(dtpN1.Value, dtpN2.Value);
		}
	}
	
}
