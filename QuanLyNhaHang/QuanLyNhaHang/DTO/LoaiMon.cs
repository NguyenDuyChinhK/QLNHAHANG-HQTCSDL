using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
	public class LoaiMon
	{
		public LoaiMon(int id, string tenloai)
		{
			this.Idlm = id;
			this.tenloai = tenloai;
		}
		public LoaiMon(DataRow row)
		{
			this.Idlm = (int)row["idLM"];
			this.Tenloai = row["TenLoai"].ToString();
		}

		private string tenloai;
		private int idlm;

		public int Idlm { get => idlm; set => idlm = value; }
		public string Tenloai { get => tenloai; set => tenloai = value; }
	}
}
