using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub5
{
    internal class Animal
    {
        public virtual void Move()                      ///virtual(override) : virtual을 지우면 hiding
        {
            Console.WriteLine("Animal Move...");
        }
    }
}
