using Ch05.Sub1;          /// Car - ctrl.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/08
 * 이름 : 최희원
 * 내용 : Class와 Object(객체) 실습 (p203)
 * 
 * 
 *   Class : object의 설계도, object를 생성하는 구조체이며, Method와 Field(속성)로 구성된다.
 *   
 *   Oject : class의 실제 instance(object를 소프트웨어에 실체화)이며, new 연산자로 생성한다.
 *  
 */



namespace Ch05
{
    internal class _1_Class
    {
        static void Main1(string[] args)
        {

            /// Car - sonata
            Car sonata = new Car();        /// object 생성 

            sonata.name = "소나타";        /// object 초기화
            sonata.color = "흰색";
            sonata.speed = 0;

            sonata.SpeedUp(10);            /// object method
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();



            /// Car - bmw
            Car bmw = new Car();

            bmw.name = "bmw 520d";
            bmw.color = "회색";
            bmw.speed = 0;

            bmw.SpeedUp(10);
            bmw.SpeedUp(90);
            bmw.SpeedDown(30);
            bmw.Show();



            /// KB Account 
            Account kb = new Account();

            kb.bank = "국민은행";
            kb.accountID = "101-12-1234";
            kb.name = "김유신";
            kb.balance = 10000;

            kb.Deposit(25000);
            kb.Withdraw(5000);
            kb.Show();



            /// NH Account 
            Account nh = new Account();

            nh.bank = "농협";
            nh.accountID = "120-11-1424";
            nh.name = "김춘추";
            nh.balance = 30000;

            nh.Deposit(70000);
            nh.Withdraw(20000);
            nh.Show();








        }


    }
}
