using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/08
///     이름 : 최희원    
///     내용 : Encapsulation (캡슐화) (p203)
///
///     Encapsulation : Object의 Field를 외부에서 참조하지 못하도록 Object의 정보를 은닉
///                     - 접근제한자 public, private, protected를 제공
///                     - 은닉된 정보의 안전한 제공을 위해 Get, Set을 제공 (C#에서 Property)
/// 


namespace Ch05
{
    internal class _2_Encapsulation
    {
        static void Main1(string[] args)
        {

            /// Account
            Account kb = new Account("국민은행", "110-11-1234", "김유신", 1000);    /// object 생성과 초기화(생성자 호출)

            kb.Deposit(4000);                                                      /// 기능
            kb.Withdraw(3000);

            ///kb.balance--;                                                       /// 캡슐화로 취약코드 예방
            ///kb.balance += 10;

            kb.Show();

            
            
            
            /// Car 
            Car sonata = new Car("소나타", "흰색", 0);                             /// Car 객체 생성과 초기화
            Car bmw = new Car("BMW", "검정색", 0);
            Car benz = new Car("벤츠", "검정색", 0);


            sonata.Name = "EF소나타";                                              /// setter 실행
            sonata.Speed = -100;

            Console.WriteLine("sonata 객체 name : " + sonata.Name);                /// getter 실행

            sonata.SpeedUp(60);
            sonata.Show();

            bmw.SpeedUp(50);
            bmw.Show();

            benz.SpeedUp(30);
            benz.Show();




















        }
    }
}
