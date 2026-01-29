using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
	public class TTHoaDonDAO
	{
		private static TTHoaDonDAO instance;

		public static TTHoaDonDAO Instance
		{
			get { if (instance == null) instance = new TTHoaDonDAO(); return instance; }
			private set { instance = value; }
		}

		private TTHoaDonDAO() { }

		public void XoaTTHoaDonBangIDMonAn(int id)
		{
			DataProvider.Instance.ExecuteQuery("DELETE tb_TTHOADON where idMA = " + id);
		}
		public List<TTHoaDon> LayDSTTHoaDon(int id) { 
			List<TTHoaDon> DSTTHoaDon = new List<TTHoaDon>();

			DataTable data = DataProvider.Instance.ExecuteQuery("Select * from tb_TTHoaDon where idHD = " + id);

			foreach (DataRow item in data.Rows)
			{
				TTHoaDon info = new TTHoaDon(item);
				DSTTHoaDon.Add(info);
			}

			return DSTTHoaDon;
		}
		public void TaoThongTinHoaDon(int idHD, int idMA, int soluong)
		{
			DataProvider.Instance.ExecuteNonQuery("proc_TaoTTHoaDon @idHD , @idMA , @soLuong", new object[] { idHD, idMA, soluong });
		}
	}

}
