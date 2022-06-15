using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    internal class _2_Switch
    {

        static void Main1(string[] args)
        {

            
            Console.WriteLine("점수 입력 : ");
            string strScore = Console.ReadLine();

            int score = int.Parse(strScore);
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
