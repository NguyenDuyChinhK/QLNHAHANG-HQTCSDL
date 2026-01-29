using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
	public class MonAnDAO
	{
		private static MonAnDAO instance;

		public static MonAnDAO Instance { get {if (instance == null) instance = new MonAnDAO(); return MonAnDAO.instance; } private set => MonAnDAO.instance = value; }

		private MonAnDAO() { }

		public List<MonAn> LayMonAnTuidLoaiMon(int id)
		{
			List<MonAn> ds = new List<MonAn>();
			string query = "select * from tb_MonAn where idLM = "+ id;

			DataTable data =  DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows) {
				MonAn monan = new MonAn(item);
				ds.Add(monan);
			}
			return ds;
		}

		public List<MonAn> LayDSMonAn()
		{
			List<MonAn> ds = new List<MonAn>();
			string query = "select * from tb_MonAn ";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				MonAn monan = new MonAn(item);
				ds.Add(monan);
			}
			return ds;
		}

		public bool ThemMonAn(string tenmon, int idlm, float gia)
		{
			string query = string.Format("Insert tb_MonAn (TenMon, idLM, Gia) Values(N'{0}',{1},{2})", tenmon, idlm, gia);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}
		public bool CapNhatMonAn(int idma, string tenmon, int idlm, float gia)
		{
			string query = string.Format("UPDATE tb_MonAn set TenMon = N'{0}', idLM = {1}, Gia = {2} where idMa = {3} ", tenmon, idlm, gia, idma);
			int result = DataProvider.Instance.ExecuteNonQuery(query);
			
			return result > 0;

		}
		public bool XoaMonAn(int idma)
		{
			string query = string.Format("Delete tb_MONAN where idMa = " + idma);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}

	}
}
