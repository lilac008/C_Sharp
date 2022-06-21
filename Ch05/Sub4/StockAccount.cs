using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class StockAccount : Account    /// 1-1) StockAccount - 빠른작업리팩터링 - 생성자 생성
    {                                        /// 1-2) StockAccount - 빠른작업리팩터링 - 매개변수 추가


        private string stock;
        private int amount;
        private int price;

        public StockAccount(string bank, string id, string name, int balance, string stock, int amount, int price) : base(bank, id, name, balance)
        {
            this.stock = stock;
            this.amount = amount;
            this.price = price;
        }

        public void Sell(int amount, int price)
        {
            this.amount -= amount;
            base.balance += amount * price;                  ///balance 빗금 -> 모class에서 private을 protected로 전환
        }

        public void Buy(int amount, int price)
        {
            this.amount += amount;
            base.balance -= amount * price;
        }

        public void Show()                                  ///모class에서 호출
        {
            base.Show();
            Console.WriteLine("주식종목 : " + stock);
            Console.WriteLine("주식수량 : " + amount);
            Console.WriteLine("주식가격 : " + price);
            Console.WriteLine("---------------------");
        }







    }
}
