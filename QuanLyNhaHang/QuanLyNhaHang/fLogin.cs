using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
	public partial class fLogin : Form
	{
		public fLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string TenDangNhap = txtUserName.Text;
			string MatKhau = txtMatKhau.Text;
			if (login(TenDangNhap, MatKhau))
			{
				TaiKhoan taikhoandangnhap = TaiKhoanDAO.Instance.LayTaiKhoanTuTenDangNhap(TenDangNhap);
				fBanAn f = new fBanAn(taikhoandangnhap);
				this.Hide();
				f.ShowDialog();
				this.Show();
				
			}else
			{
				MessageBox.Show("Sai tên tài khoản và mật khẩu!");
			}
			
		}
		bool login(string TenDangNhap, String MatKhau)
		{
			return TaiKhoanDAO.Instance.Login(TenDangNhap, MatKhau);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(MessageBox.Show("Bạn có thực sự muốn thát?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
		}
	}
}
