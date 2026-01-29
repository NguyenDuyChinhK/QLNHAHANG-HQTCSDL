using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
	public class BanAnDAO
	{
		private static BanAnDAO instance;

		public static BanAnDAO Instance {
			get { if (instance == null) instance = new BanAnDAO(); return BanAnDAO.instance; }
			set => instance = value; }

		public static int TableWidth = 80;
		public static int TableHeight = 80;
		private BanAnDAO() { }

		public List<BanAn> LoadDSBanAn()
		{
			List<BanAn> ds = new List<BanAn>();
			DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from tb_BANAN");
		
			foreach (DataRow item in data.Rows) {
				BanAn banan = new BanAn(item);
				ds.Add(banan);
			}
			return ds;
		}

		public bool ThemBanAn(string tenban, string trangthai)
		{
			string query = string.Format("Insert tb_BANAN (TenBan, TrangThai) Values(N'{0}',N'{1}')", tenban, trangthai);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}
		public bool CapNhatBanAn(int idban, string tenban, string trangthai)
		{
			string query = string.Format("UPDATE tb_BanAn set TenBan = N'{0}', TrangThai = N'{1}' where idBan = {2} ", tenban, trangthai, idban);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}

		public bool XoaBanAn(int idban)
		{
			string query = string.Format("Delete tb_BANAN where idBan = " + idban);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}
	}
}
