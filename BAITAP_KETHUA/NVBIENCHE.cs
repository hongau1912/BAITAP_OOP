using System;
namespace BAITAP_KETHUA
{
	public class NVBIENCHE:NHANVIEN
	{
		private double heSoLuong;

		public double HESOLUONG
		{
			set { this.heSoLuong = value; }
			get { return this.heSoLuong; }
		}

		public NVBIENCHE():base()
		{
		}

		public NVBIENCHE(string maNv, string hoTen, DateTime ngaySinh, string gioiTinh, long soCm, DateTime ngayVaoCoQuan, double heSoLuong)
			: base (maNv, hoTen, ngaySinh, gioiTinh, soCm, ngayVaoCoQuan)
		{
			this.heSoLuong = heSoLuong;
		}

		public double PHUCAP()
		{
			if (base.THAMNIEN() >= 10)
				return base.luongCoBan * 0.1 + 500000;
			else
				return base.luongCoBan * 0.1 + 200000;
		}

		public double THUCLINH()
		{
			return (base.luongCoBan * this.heSoLuong) + this.PHUCAP();
		}

		public void NHAP()
		{
			base.NHAP();
			Console.WriteLine("Nhap he so luong: ");
			this.heSoLuong = double.Parse(Console.ReadLine());
		}

		public void XUAT()
		{
			base.XUAT();
			Console.WriteLine("He so luong: " +this.heSoLuong);
			Console.WriteLine("Tham nien: " +this.THAMNIEN());
			Console.WriteLine("Thuc linh: " +this.THUCLINH());
		}
	}
}

