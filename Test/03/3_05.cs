using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._03
{
	class Vehicle
	{
		private string name;
		private int price;

		public Vehicle(string name, int price)
		{
			this.name = name;
			this.price = price;
		}

		public void Show()
		{
			Console.WriteLine("================");
			Console.WriteLine("차량명 : " + name);
			Console.WriteLine("가격 : " + price);
			Console.WriteLine("----------------");
		}
	}

	class CarFactory
	{
		private static CarFactory instance = new CarFactory();     /// new CarFactory();를 static(정적)에 고정
		private CarFactory() { }                                   /// CarFactory();를 new 못하도록 private

		public static CarFactory Instance
		{
			get { return instance; }
		}

		public Vehicle MakeCar(string name, int price)
		{
			return new Vehicle(name, price);
		}
	}

	internal class _3_05
	{
		static void Main1(string[] args)
		{
			CarFactory f = CarFactory.Instance;

			Vehicle avante = f.MakeCar("아반테", 2500);
			Vehicle sonata = f.MakeCar("소나타", 3000);

			avante.Show();
			sonata.Show();
		}
	}



}
