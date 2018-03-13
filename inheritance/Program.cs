using System;
using System.Reflection;

//public struct ValueStruct : ValueType  // Generates CS0527

//public abstract class  A
public class A
{
    private int value = 10;

    public class B : A
    {
        public int GetValue()
        {
            return this.value;
        }
    }

    public void Method1()
    {
        // Method implementation.
    }

    //public abstract void Method2();

}

public class SimpleClass
{

}

public class C : A
{
/*     public int GetValue()
    {
        return this.value;
    } */
}

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //.Console.WriteLine("Hello World!");
            var b = new A.B();
            Console.WriteLine(b.GetValue());
            // The example display the following output:
            // 10

            // Display info about SimpleClass
            Type t = typeof(SimpleClass);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                                BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
            MemberInfo[] members = t.GetMembers(flags);
            Console.WriteLine($"Type {t.Name} has {members.Length} members: ");                 
            foreach (var member in members)
            {
                string access = "";
                string stat = "";
                var method = member as MethodBase;
                if (method != null)
                {
                    if (method.IsPublic)
                        access = " Public";
                    else if (method.IsPrivate)
                        access = " Private";
                    else if (method.IsFamily)
                        access = " Protected";
                    else if (method.IsAssembly)
                        access = " Internal";
                    else if (method.IsFamilyOrAssembly)
                        access = "Protected Internal";
                    if (method.IsStatic)
                        stat = " Static";
                }
                var output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                Console.WriteLine(output);
            }

            // Test using ToString() method with SimpleClass
            SimpleClass sc = new SimpleClass();
            Console.WriteLine(sc.ToString());
            // Display output: SimpleClass
        }
    }

}
