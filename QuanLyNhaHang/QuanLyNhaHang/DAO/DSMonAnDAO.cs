using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
	public class DSMonAnDAO
	{
		private static DSMonAnDAO instance;
		
		public static DSMonAnDAO Instance
		{
			get { if (instance == null) instance = new DSMonAnDAO(); return instance; }
			private set { DSMonAnDAO.instance = value; }
		}

		private DSMonAnDAO() { }

		public List<DTO.DSMonAn> LayDSMonAnTuBan(int id)
		{
			List<DTO.DSMonAn> dsMonAn = new List<DTO.DSMonAn>();
			string query = "Exec proc_DSMonAn '" + id+"'";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			
			foreach (DataRow item in data.Rows)
			{
				DTO.DSMonAn monan = new DTO.DSMonAn(item);
				dsMonAn.Add(monan);
			}

			return dsMonAn;
		}
	}
}
