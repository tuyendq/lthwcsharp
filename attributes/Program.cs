using System;

namespace attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ObsoleteClass A = new ObsoleteClass();
        }
    }

    public class MySpecialAttribute : Attribute
    {

    }

    [MySpecial]
    public class SomeOtherClass
    {

    }

    //[Obsolete("This class is obsolete. Please user ... class")]
    public class ObsoleteClass
    {
        public ObsoleteClass()
        {
            Console.WriteLine("This class is obsolete!");
        }

        ~ObsoleteClass()
        {
            Console.WriteLine("Object is destroyed!");
        }
       
    }
}
