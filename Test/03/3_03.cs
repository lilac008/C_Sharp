using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._03
{
	class Car
	{
		private string company;
		private string name;
		private int price;

		public Car(string company, string name, int price)
		{
			this.company = company;							 ///매개변수로 초기값 재설정 
			this.name = name;
			this.price = price;
		}

		private void Drive()
		{
			Console.WriteLine(name + " 운행 중...");
		}

		public void Show()
		{
			Drive();										///다른 method 포함
			Console.WriteLine("제조사 : " + company);
			Console.WriteLine("차량명 : " + name);
			Console.WriteLine("가격 : " + price);
			Console.WriteLine();
		}
	}



	internal class _3_03
    {
        static void Main1(string[] args)
        {
			Car sonata;
			Car bmw;

			sonata = new Car("현대", "소나타", 3000);
			bmw = new Car("BMW", "520d", 5000);

			sonata.Show();
			bmw.Show();

		}

	}
}
