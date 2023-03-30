using System;
namespace BAITAP_MYCLASS
{
	public class TAMGIAC
	{
		private float aB;
		private float bC;
		private float cA;

		public float AB
		{
			set { this.aB = value; }
			get { return this.aB; }
		}

		public float BC
		{
			set{this.bC = value; }
			get { return this.bC; }
		}

		public float CA
		{
			set { this.cA = value; }
			get { return this.cA; }
		}
		public float CHUVI()
		{
			return (AB + BC + CA);
		}

		public void NHAP()
		{
			Console.WriteLine("AB: ");
			aB = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine("BC: ");
			bC = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine("CA: ");
			cA = Convert.ToSingle(Console.ReadLine());
		}

		public void XUAT()
		{
			//Console.WriteLine(this.AB);
			//Console.WriteLine(this.BC);
			//Console.WriteLine(this.CA);
			Console.WriteLine("Chu vi: {0}",this.CHUVI());
		}
		public TAMGIAC()
		{
		}
	}
}

