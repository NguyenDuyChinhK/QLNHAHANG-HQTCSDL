using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
	public class TaiKhoan
	{
		public TaiKhoan(string tendangnhap, string tenhienthi, int loaitk, string matkhau = null) {
			this.TenDangNhap = tendangnhap;
			this.TenHienThi = tenhienthi;
			this.LoaiTK = loaitk;
			this.MatKhau = matkhau;
		
		}

		public TaiKhoan(DataRow row) {
			this.TenDangNhap = row["TenDangNhap"].ToString();
			this.TenHienThi = row ["TenHienThi"].ToString();
			this.LoaiTK = (int) row["LoaiTK"];
			this.MatKhau = row["MatKhau"].ToString();
		}

		private int loaiTK;
		private string matKhau;
		private string tenHienThi;
		private string tenDangNhap;

		public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
		public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }
		public string MatKhau { get => matKhau; set => matKhau = value; }
		public int LoaiTK { get => loaiTK; set => loaiTK = value; }
	}
}
