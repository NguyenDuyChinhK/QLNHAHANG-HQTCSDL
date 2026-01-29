using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;

namespace QuanLyNhaHang.DAO
{
	public class TaiKhoanDAO
	{
		private static TaiKhoanDAO instance;
		public static TaiKhoanDAO Instance
		{ 
			get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
			private set { instance = value; }
		}
		private TaiKhoanDAO() { }

		public bool Login(string TenDangNhap, string MatKhau)
		{
			string query = "PROC_DangNhap @TenDangNhap , @MatKhau";
			DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {TenDangNhap, MatKhau});
			return result.Rows.Count >0; 
		}
		public bool CapNhatTaiKhoan(string tendangnhap, string tenhienthi, string matkhau, string matkhaumoi)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("exec proc_ThayDoiMatKhau @TenDangNhap , @TenHienThi , @MatKhau , @MatKhauMoi", new object[] {tendangnhap, tenhienthi, matkhau, matkhaumoi});
			return result >0;
		}


		public DataTable LayDSTaiKhoan()
		{
			return DataProvider.Instance.ExecuteQuery("SELECT TenDangNhap, TenHienThi, LoaiTK from tb_TAIKHOAN");
		}
		public TaiKhoan LayTaiKhoanTuTenDangNhap(string tendangnhap)
		{
			DataTable data = DataProvider.Instance.ExecuteQuery("Select * from tb_TAIKHOAN where TenDangNhap = '" + tendangnhap + "'");

			foreach (DataRow item in data.Rows)
			{
				return new TaiKhoan(item);
			}
			return null;
		}

		public bool ThemTaiKhoan(string tendangnhap, string tenhienthi, int loaitk)
		{
			string query = string.Format("Insert tb_TaiKhoan (TenDangNhap, TenHienThi, LoaiTK) Values(N'{0}',N'{1}',{2})", tendangnhap, tenhienthi, loaitk);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}
		public bool CapNhatTaiKhoan(string tendangnhap, string tenhienthi, int loaitk)
		{
			string query = string.Format("UPDATE tb_TaiKhoan set TenHienThi = N'{1}', LoaiTK = {2} where TenDangNhap = '{0}' ", tendangnhap, tenhienthi, loaitk);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}
		public bool XoaTaiKhoan(string tendangnhap)
		{
			
			string query = string.Format("Delete tb_TAIKHOAN where TenDangNhap = N'{0}'", tendangnhap);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		} 

		public bool ResetMatKhau(string tendangnhap)
		{
			string query = string.Format("update tb_TAIKHOAN set passwoed = N'0' where UserName = N{0}", tendangnhap);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}
		
	}
}
