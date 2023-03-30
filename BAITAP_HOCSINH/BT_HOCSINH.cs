using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BAITAP_HOCSINH
{
	class BT_HOCSINH // truong du lieu
	{
		private String hoTen;
		private String gioiTinh;
		private long soCM;
		private DateTime ngaySinh;
		private float diemToan;
		private float diemLy;
		private float diemHoa;
		private String[] diaChiEmail = new string[3];

		public String[] DIACHIEMAIL
		{
			set { this.diaChiEmail = value; }
			get { return this.diaChiEmail; }
		}

		public String this[int index]
		{
			set
			{
				if (index < this.diaChiEmail.Length && index <= 0)
					this.diaChiEmail[index] = value;
			}
			get
			{
				if (index < this.diaChiEmail.Length && index <= 0)
					return this.diaChiEmail[index];
				else
					return null;
            }
		}

		private Dictionary<String, long> soDienThoai = new Dictionary<string, long>();
		public Dictionary<String, long> SODIENTHOAI
		{
			set { this.soDienThoai = value; }
			get { return this.soDienThoai; }
		}

		public long this[String key]
		{
			set { this.soDienThoai.Add(key, value); }
			get { return this.soDienThoai[key]; }
		}

		public static int SOLUONGHOCSINH;

		public String HOTEN
		{
			set { this.hoTen = value; }
			get { return this.hoTen; }
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

		public DateTime NGAYSINH
		{
			set { this.ngaySinh = value; }
			get { return this.ngaySinh; }
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

		public void NHAP()
		{
			Console.WriteLine("hoTen: ");
			this.hoTen = Console.ReadLine();
			Console.WriteLine("gioiTinh: ");
			this.gioiTinh = Console.ReadLine();
			Console.WriteLine("soCM: ");
			this.soCM = long.Parse(Console.ReadLine());
			Console.WriteLine("diemToan: ");
			this.diemToan = float.Parse(Console.ReadLine());
			Console.WriteLine("diemLy: ");
			this.diemLy = float.Parse(Console.ReadLine());
			Console.WriteLine("diemHoa: ");
			this.diemHoa = float.Parse(Console.ReadLine());

		}
		public void XUAT()
		{
            Console.WriteLine("hoTen:" + this.hoTen);
            Console.WriteLine("gioiTinh:" + this.gioiTinh);
            Console.WriteLine("soCM:" + this.soCM);
            Console.WriteLine("diemToan:" + this.diemToan);
            Console.WriteLine("diemLy:" + this.diemLy);
            Console.WriteLine("diemHoa:" + this.diemHoa);
			Console.WriteLine("diemTb: " + DIEMTB());

        }

		public float DIEMTB()
		{
			return (this.diemToan + this.diemLy + this.diemHoa) / 3;
		}

		public String XEPLOAI()
		{
			float diemTrungBinh = this.DIEMTB();
			if (diemTrungBinh < 3)
				return "Kem";
			else if (diemTrungBinh < 5)
				return "Yeu";
			else if (diemTrungBinh < 7)
				return "Trung Binh";
			else if (diemTrungBinh < 8)
				return "Kha";
			else
				return "Gioi";
		}
		public BT_HOCSINH()
		{
			SOLUONGHOCSINH++;
		}

		public BT_HOCSINH(String ht, String gt, long scm, DateTime ns, float dt, float dl, float dh)
		{
			this.hoTen = ht;
			this.gioiTinh = gt;
			this.soCM = scm;
			this.ngaySinh = ns;
			this.diemToan = dt;
			this.diemLy = dl;
			this.diemHoa = dh;
			SOLUONGHOCSINH++;
		}

		public BT_HOCSINH(BT_HOCSINH hs)
		{
			this.hoTen = hs.hoTen;
			this.gioiTinh = hs.gioiTinh;
			this.soCM = hs.soCM;
			this.ngaySinh = hs.ngaySinh;
			this.diemToan = hs.diemToan;
			this.diemLy = hs.diemLy;
			this.diemHoa = hs.diemHoa;
			SOLUONGHOCSINH++;
		}

		public static void XEMSISO()
		{
			Console.WriteLine("So luong" +SOLUONGHOCSINH);
		}
	}
}

