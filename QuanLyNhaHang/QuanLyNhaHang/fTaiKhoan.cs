using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
	public partial class fTaiKhoan : Form
	{
		private TaiKhoan taiKhoanDangNhap;

		public TaiKhoan TaiKhoanDangNhap { get => taiKhoanDangNhap; set { taiKhoanDangNhap = value; ThayDoiTaiKhoan(taiKhoanDangNhap); } }

		public fTaiKhoan(TaiKhoan taiKhoan)
		{
			InitializeComponent();
			TaiKhoanDangNhap = taiKhoan;
		}

		void ThayDoiTaiKhoan(TaiKhoan taikhoan)
		{
			txtTenDangNhap.Text = taiKhoanDangNhap.TenDangNhap;
			txtTenHienThi.Text = taiKhoanDangNhap.TenHienThi;
		}
		private void fTaiKhoan_Load(object sender, EventArgs e)
		{

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void CapNhatTaiKhoan()
		{
			string tenDangNhap = txtTenDangNhap.Text;
			string tenHienThi = txtTenHienThi.Text;
			string matKhau = txtMatKhau.Text;
			string matKhauMoi = txtMatKhauMoi.Text;
			string nhapLai = txtNhapLai.Text;

			if (!matKhauMoi.Equals(nhapLai))
			{
				MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
			}
			else
			{
				if (TaiKhoanDAO.Instance.CapNhatTaiKhoan(tenDangNhap, tenHienThi, matKhau, matKhauMoi))
				{
					MessageBox.Show("Cập nhật thành công");
				}
				else {
					MessageBox.Show("Vui lòng nhập lại đúng mật khẩu");
				}
			}
		}
		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			CapNhatTaiKhoan();
		}
	}
}
