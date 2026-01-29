using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
	public class TTHoaDon
	{
		public TTHoaDon(int id, int idhd, int idma, int soluong) 
		{
			this.ID = id;
			this.idHD = idHD;
			this.idMA = idMA;
			this.SoLuong = soluong;
		}
		public TTHoaDon(DataRow row) {
			this.ID = (int)row["id"];
			this.idHD = (int)row["idHD"];
			this.idMA = (int)row["idMA"];
			this.SoLuong = (int)row["soluong"];
		}

		private int soluong;
		public int SoLuong { get { return soluong; } set { soluong = value; } }
		private int idma;
		public int idMA { get { return idma; } set { idma = value; } }

		private int idhd;

		public int idHD { get { return idhd; } set { idhd = value; } }
		private int iD;

		public int ID { get { return iD; } set { iD = value; } }
	}
}
