using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Object : C#의 최상위 클래스, 모든 클래스는 Object Class의 상속을 받는다.    
/// 
/// class Object
///      l 
/// class Animal
///      l
/// class Dog : Animal, class Cat : Animal


namespace Book.Ch07
{

    //Object Class 선언

    /// class Object
    /// {
    ///    public Object();

    ///    public virtual bool Equals(object obj);
    ///    public static bool Equals(object objA, object objB);
    ///    public virtual int GetHashCode();
    ///    public Type GetType();
    ///    protected object MemberwiseClone();
    ///    public static bool ReferenceEquals(object objA, object objB);
    ///    public virtual string ToString();
    /// }

    internal class p344_345__
    {
        static void Main1(string[] args)
        {

            //Object Class의 다형성 - (1)

            ///List<Object> o = new List<Object>();
            ///o.Add(new Dog());
            ///o.Add(new Cat());



            //Object Class의 다형성 - (2)

            ///List<Object> o1 = new List<Object>();
            ///o1.Add(new Dog());
            ///o1.Add(new Cat());
            ///o1.Add(52);
            ///o1.Add(52l);
            ///o1.Add(52.273f);
            ///o1.Add(52.273);
        }







    }
}
