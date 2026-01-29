using QuanLyNhaHang.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhaHang.DAO
{
	public class LoaiMonDAO
	{
		private static LoaiMonDAO instance;

		public static LoaiMonDAO Instance { get { if (instance == null) instance = new LoaiMonDAO(); return LoaiMonDAO.instance; }  private set => LoaiMonDAO.instance = value; }

		private LoaiMonDAO() { }

		public List<LoaiMon> LayDanhSachLoaiMon()
		{
			List<LoaiMon > ds = new List<LoaiMon>();
			string query = "select * from tb_LOAIMON";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows) {
				LoaiMon loaimon = new LoaiMon(item);
				ds.Add(loaimon);
			}

			return ds;
		}
		public LoaiMon LayLoaiMonTuID(int id)
		{
			LoaiMon loaimon = null;

			string query = "select * from tb_LOAIMON where idLM = "+ id;
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				loaimon = new LoaiMon(item);
				return loaimon;
			}
			return loaimon;
		}

		public bool ThemLoaiMon( string tenloai)
		{
			string query = string.Format("Insert tb_LoaiMon (TenLoai) Values(N'{0}')", tenloai);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}
		public bool CapNhatLoaiMon(int idlm, string tenloai)
		{
			string query = string.Format("UPDATE tb_LoaiMon set TenLoai = N'{0}' where idLM = {1} ", tenloai, idlm);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}

		public bool XoaLoaiMon(int idlm)
		{
			string query = string.Format("Delete tb_LOAIMON where idLM = " + idlm);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;

		}
	}
}
