using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
	public class MonAn
	{
		public MonAn(int idma,string tenmon, int idllm, float gia) {
			this.Idma = idma;
			this.Tenmon = tenmon;
			this.Idlm = idlm;
			this.Gia = gia;
		}
		public MonAn(DataRow row)
		{
			this.Idma = (int)row["idMa"];
			this.Tenmon = row["TenMon"].ToString();
			this.Idlm = (int)row["idLM"];
			this.Gia = (float)Convert.ToDouble(row["Gia"].ToString());
		}
		private int idma;
		private string tenmon;
		private int idlm;
		private float gia;

		public int Idma { get => idma; set => idma = value; }
		public string Tenmon { get => tenmon; set => tenmon = value; }
		public int Idlm { get => idlm; set => idlm = value; }
		public float Gia { get => gia; set => gia = value; }
	}
}
