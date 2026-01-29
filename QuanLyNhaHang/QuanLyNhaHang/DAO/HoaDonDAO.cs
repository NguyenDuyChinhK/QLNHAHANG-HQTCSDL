using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
	public class HoaDonDAO
	{
		private static HoaDonDAO instance;

		public static HoaDonDAO Instance
		{
			get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
			private set { HoaDonDAO.instance = value;  }
		} 

		private HoaDonDAO() { }

		public int LayHoaDonChuaThanhToanTuIDBan(int id)
		{
			DataTable data = DataProvider.Instance.ExecuteQuery("select * from tb_HoaDon where idBan = " + id + " and TrangThai = 0");
			if (data.Rows.Count > 0)
			{
				HoaDon hoadon = new HoaDon(data.Rows[0]);
				return hoadon.ID;
			}
			return -1;
		}
		public void ThanhToan(int id, int giamgia)
		{
			string query = "Update tb_HOADON SET TrangThai =1,  GiamGia = " + giamgia +" where idHD = " +id;
			DataProvider.Instance.ExecuteNonQuery(query);
		}
		public void TaoHoaDon(int id)
		{
			DataProvider.Instance.ExecuteNonQuery("exec proc_TaoHoaDon @idBan", new object[] { id });
		}

		public DataTable LayDoanhThuTheoNgay(DateTime Ngay1,  DateTime Ngay2)
		{
			return DataProvider.Instance.ExecuteQuery("SELECT * from view_ThongKeDoanhThuTheoNgay  where Ngay >= '"
				+ Ngay1.ToString("yyyy-MM-dd") + "' AND Ngay <= '" + Ngay2.ToString("yyyy-MM-dd") +"'");
		}

		public DataTable LayDoanhThuTheoBan(string tenBan)
		{
			return DataProvider.Instance.ExecuteQuery("SELECT * from view_ThongKeDoanhThuTheoBan where TenBan = '" + tenBan+"'");
		}
		public DataTable LayDSDoanhThuTheoBan ()
		{
			return DataProvider.Instance.ExecuteQuery("SELECT * from view_ThongKeDoanhThuTheoBan" );
		}

		public DataTable LayDSDoanhThuTheoHoaDon()
		{
			return DataProvider.Instance.ExecuteQuery("SELECT * from view_ThongKeDoanhThuTheoHoaDon");
		}

		public int LayIDHDCaoNhat()
		{
			try
			{
				return (int)DataProvider.Instance.ExecuteScalar("select Max(idHD) from tb_HOADON");
			}
			catch {  return 1; }
			
		}
		
	}
}
