using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///     날짜 : 2022/06/03
///     이름 : 최희원    
///     내용 : Switch 조건문  (p127)
/// 
///      Switch(조건)
///      {    case 값 :
///           case 값 :
///                  break;
///           defalt : 
///                  break;
///      }
///


namespace Ch03
{
    internal class _2_Switch
    {

        static void Main1(string[] args)
        {

            Console.Write("점수 입력 : ");
            string stScore = Console.ReadLine();
            int score = int.Parse(stScore);
            int grade = score / 10;

            switch (grade)
            {
                case 10:
                case 9:
                    Console.WriteLine("A 입니다.");
                    break;
                case 8:
                    Console.WriteLine("B 입니다.");
                    break;
                case 7:
                    Console.WriteLine("C 입니다.");
                    break;
                case 6:
                    Console.WriteLine("D 입니다.");
                    break;
                default:
                    Console.WriteLine("F 입니다.");
                    break;
            }






        }
    }
}
