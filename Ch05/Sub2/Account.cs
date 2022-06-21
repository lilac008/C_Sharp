using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Ch05.Sub2
{
    internal class Account
    {


        private string bank;                                  /// private - Field Encapsulation.
        private string accountID;
        private string name;
        private int balance;


        public Account(string bank, string accountID, string name, int balance)  /// Constructor (캡슐화된 속성을 초기화 하기 위한 Method)
        {
            this.bank = bank;
            this.accountID = accountID;
            this.name = name;
            this.balance = balance;
        }


        public void Deposit(int money)                       ///method
        { this.balance += money; }

        public void Withdraw(int money)
        { this.balance -= money; }

        public void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("은행명 : " + bank);
            Console.WriteLine("계좌번호 : " + accountID);
            Console.WriteLine("입금주 : " + name);
            Console.WriteLine("현재잔액 : " + balance);
            Console.WriteLine("-----------------");
        }


    }
}
