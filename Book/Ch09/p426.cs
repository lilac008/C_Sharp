using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Interface
/// IComparable Interface



namespace Book.Ch09
{

    internal class p426
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }

        static void Main1(string[] args)
        {

            List<Product> li = new List<Product>()
            {
                new Product(){ Name = "당근", Price = 1000 },
                new Product(){ Name = "호박", Price = 2000 },
                new Product(){ Name = "우엉", Price = 3000 },
                new Product(){ Name = "연근", Price = 4000 },
            };
            ///li.Sort();           /// 오류 : sort() method가 Product class를 어떤 기준으로 정렬해야할지 모르기 때문

            foreach (var item in li) 
            {
                Console.WriteLine(item);
            }

        }






    }
}
