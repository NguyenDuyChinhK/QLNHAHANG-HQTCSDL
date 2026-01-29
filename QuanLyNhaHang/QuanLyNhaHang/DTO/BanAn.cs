using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
	public class BanAn
	{
		public BanAn(int id, string tenban, string trangthai) { 
			this.IDBAN = id;
			this.TenBan = tenban;
			this.Trangthai = trangthai;
		}
		public BanAn(DataRow row) {
			this.IDBAN = (int)row["idBan"];
			this.TenBan = row["TenBan"].ToString();
			this.Trangthai = row["TrangThai"].ToString();
		}
		
		private string tenban;
		public string TenBan { get { return tenban; } set { tenban = value; } }

		private int idban;
		

		private string trangthai;
		public string Trangthai { get => trangthai; set => trangthai = value; }
		public int IDBAN { get => idban; set => idban = value; }
	}
}
