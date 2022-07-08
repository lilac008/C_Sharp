using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._04
{
    class Apple                                            /// : object
    {
        public void Show()
        { Console.WriteLine("사과 입니다."); }
    }
    class Banana                                            /// : object
    {
        public void Show()
        { Console.WriteLine("바나나 입니다."); }
    }
    class Grape                                            /// : object
    {
        public void Show()
        { Console.WriteLine("포도 입니다."); }
    }

    internal class _4_08
    {
        static void Main1(string[] args)
        {
            Apple  a = new Apple();
            Banana b = new Banana();
            Grape  g = new Grape();

            Show(a);
            Show(b);
            Show(g);
        }

        public static void Show(object fruit)           
        {
            if (fruit is Apple)
            {
                Apple ap = (Apple)fruit;
                ap.Show();
            }
            else if (fruit is Banana)
            {
                Banana ba = fruit as Banana;
                ba.Show();
            }
            else if (fruit is Grape)
            {
                Grape gr = fruit as Grape;
                gr.Show();
            }
        }

    }
}
