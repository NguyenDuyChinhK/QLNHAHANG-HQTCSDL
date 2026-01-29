using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
	public class HoaDon
	{
		public HoaDon(int id, DateTime? Ngay, int TrangThai, int giamgia = 0)
		{
			this.ID = id;
			this.Ngay = Ngay;
			this.TrangThai = TrangThai; 
			this.Giamgia = giamgia;
		}

		public HoaDon(DataRow row)
		{
			this.ID = (int)row["idHD"];
			this.Ngay = (DateTime?)row["Ngay"];
			this.TrangThai = (int)row["TrangThai"];
			this.Giamgia = (int)row["GiamGia"];
		}

		private int giamgia; 
		public int Giamgia { get => giamgia; set => giamgia = value; }
		private int trangthai;

		public int TrangThai { get { return trangthai; } set { trangthai = value; } }

		private DateTime? ngay;
		public DateTime? Ngay { get { return ngay; } set { ngay = value; } }

		private int iD;

		public int ID { get { return iD; } set { iD = value; } }

		
	}
}
