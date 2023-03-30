using System;
namespace BAITAP_KETHUA
{
	public class NHANVIEN
	{
		protected string maNv;
		protected string hoTen;
		protected DateTime ngaySinh;
		protected string gioiTinh;
		protected long soCm;
		protected DateTime ngayVaoCoQuan;
		protected double luongCoBan = 1490000;

		public NHANVIEN()
		{
		}

		public NHANVIEN(string maNv, string hoTen, DateTime ngaySinh, string gioiTinh, long soCm, DateTime ngayVaoCoQuan)
		{
			this.maNv = maNv;
			this.hoTen = hoTen;
			this.ngaySinh = ngaySinh;
			this.gioiTinh = gioiTinh;
			this.soCm = soCm;
			this.ngayVaoCoQuan = ngayVaoCoQuan;
		}

		public int THAMNIEN()
		{
			DateTime todayDate = DateTime.Today;
			return (int)((todayDate - this.ngayVaoCoQuan).TotalDays / 365.242199);
		}
		public void NHAP()
		{
			Console.WriteLine("maNv: ");
			this.maNv = Console.ReadLine();
			Console.WriteLine("hoTen: ");
			this.hoTen = Console.ReadLine();
			Console.WriteLine("ngaySinh: ");
			this.ngaySinh = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("gioiTinh: ");
			this.gioiTinh = Console.ReadLine();
			Console.WriteLine("soCm: ");
			this.soCm = Convert.ToInt64(Console.ReadLine());
			Console.WriteLine("ngayVaoCoQuan: ");
			this.ngayVaoCoQuan = DateTime.Parse(Console.ReadLine());
		}

		public void XUAT()
		{
            Console.WriteLine("maNv: " +maNv);
            Console.WriteLine("hoTen: " +hoTen);
            Console.WriteLine("ngaySinh: " +ngaySinh.ToString("dd/mm/yyyy"));
            Console.WriteLine("gioiTinh: " +gioiTinh);
            Console.WriteLine("soCm: " +soCm);
            Console.WriteLine("ngayVaoCoQuan: " +ngayVaoCoQuan.ToString("dd/mm/yyyy"));
        }
	}
}

