using System;
namespace BAITAP_KETHUA
{
	public class NVHOPDONG:NHANVIEN
	{
		private double mucLuong = 1000000;
		public double MUCLUONG
		{
			set { this.mucLuong = value; }
			get { return this.mucLuong; }
		}
		public NVHOPDONG():base()
		{
		}

		public NVHOPDONG(string maNv, string hoTen, DateTime ngaySinh, string gioiTinh, long soCm, DateTime ngayVaoCoQuan, double mucLuong)
			: base(maNv, hoTen, ngaySinh, gioiTinh, soCm, ngayVaoCoQuan)
		{
			this.mucLuong = mucLuong;
		}

		public double PHUCAP()
		{
			if (base.THAMNIEN() >= 2)
				return this.mucLuong * 0.1 + 200000;
			else
				return this.mucLuong * 0.1 + 100000;
		}

		public override void NHAP()
		{
			base.NHAP();
		}

		public override void XUAT()
		{
			base.XUAT();
			Console.WriteLine("mucLuong: " +this.mucLuong);
			Console.WriteLine("thamNien: " +this.THAMNIEN());
			Console.WriteLine("thucLinh: " +this.THUCLINH());
		}

		public double THUCLINH()
		{
			return base.luongCoBan + this.mucLuong + this.PHUCAP();
		}
	}
}

