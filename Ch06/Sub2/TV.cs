using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// internet computer
///  ㅣ상속     ㅣ 다중상속
///         TV

namespace Ch06.Sub2
{
    internal class TV : Internet, IComputer       /// IComputer : Ctrl. - 인터페이스 구현
    {

        public void PowerOn()
        {
            Console.WriteLine("TV PowerOn...");
        }

        public void Booting()
        {
            Console.WriteLine("TV Booting...");
        }

        public void AccessInternet()
        {
            base.Access();
        }


    }
}
