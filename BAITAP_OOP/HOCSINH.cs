using System;
namespace BAITAP_OOP
{
	public class HOCSINH // truong du lieu
	{
		private String hoTen;
		private DateTime ngaySinh;
		private String gioiTinh;
		private long soCM;
		private float diemToan;
		private float diemLy;
		private float diemHoa;

		private String[] diachimail;
		public String[] Diachimail
		{
			set { this.diachimail = value; }
			get { return this.diachimail; }
		}

		public String HOTEN // thuoc tinh
		{
			set { this.hoTen = value; } // write du lieu
			get { return this.hoTen; } // read du lieu
		}

		public DateTime NGAYSINH
		{
			set { this.ngaySinh = value; }
			get { return this.ngaySinh; }
		}

		public String GIOITINH
		{
			set { this.gioiTinh = value; }
			get { return this.gioiTinh; }
		}

        public long SOCM
        {
            set { this.soCM = value; }
            get { return this.soCM; }
        }

        public float DIEMTOAN
        {
            set { this.diemToan = value; }
            get { return this.diemToan; }
        }

        public float DIEMLY
        {
            set { this.diemLy = value; }
            get { return this.diemLy; }
        }

        public float DIEMHOA
        {
            set { this.diemHoa = value; }
            get { return this.diemHoa; }
        }
        public float DIEMTB()
		{
			return (this.diemToan + this.diemLy + this.diemHoa) / 3;
		}

		public string XEPLOAI()
		{
			float diemtb = this.DIEMTB();
			if (diemtb < 3)
				return "Kem";
			else if (diemtb < 5)
				return "Yeu";
			else if (diemtb < 7)
				return "Trung binh";
			else if (diemtb < 8)
				return "Kha";
			else
				return "Gioi";
		}

		public void XUAT()
		{
			Console.WriteLine(this.hoTen);
			Console.WriteLine(this.ngaySinh);
			Console.WriteLine(this.gioiTinh);
			Console.WriteLine(this.soCM);
			Console.WriteLine(this.DIEMTB());
			Console.WriteLine(this.XEPLOAI());
		}
		public void NHAP()
		{
			Console.WriteLine("hoten: ");
			this.hoTen = Console.ReadLine();
            Console.WriteLine("hoten: ");
            this.gioiTinh = Console.ReadLine();
        }
		// phuong thuc tinh
		public static void XEMSISO()
		{
			Console.WriteLine("So luong: " +SOLUONGHOCSINH);
		}
        public HOCSINH()
		{
		}
	}
}

