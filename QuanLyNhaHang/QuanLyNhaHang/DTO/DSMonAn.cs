using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
	public class DSMonAn
	{
		public DSMonAn(string tenma, int soluong, float gia, float thanhtien = 0) {
			this.TenMa = tenma;
			this.SoLuong = soluong;
			this.Gia = gia;
			this.ThanhTien = thanhtien;
		}
		public DSMonAn(DataRow row)
		{
			this.TenMa = row["TenMon"].ToString();
			this.SoLuong = (int)row["soluong"];
			this.Gia = (float)Convert.ToDouble(row["Gia"].ToString());
			this.ThanhTien = (float)Convert.ToDouble(row["ThanhTien"].ToString()) ;
		}	

		private float thanhtien;
		public float ThanhTien { get { return thanhtien; } set { thanhtien = value; } }
		private float gia;

		public float Gia { get {return gia;} set { gia = value; } }
		private int soluong;
		
		public int SoLuong { get { return soluong; } set { soluong = value; } }

		private string tenma;
		public string TenMa { get { return tenma; } set { tenma = value; } }
	}
}
