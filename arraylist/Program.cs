using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using generalized ArrayList list to keep  collection
            var list = new ArrayList();

            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            
            foreach (object item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine($"List Count: {list.Count}");
            Console.WriteLine($"List Capacity: {list.Capacity}");
            Console.WriteLine($"Is List Fixed szie? {list.IsFixedSize}");
            Console.WriteLine($"Is List Read Only? {list.IsReadOnly}");

            // Using a generic class

            var listOfString = new List<String>();
            listOfString.Add("apple");
            listOfString.Add("grape");
            listOfString.Add("lemon");
            listOfString.Add("onion");

            foreach (string str in listOfString) {
                Console.WriteLine(str);
            }

            // Call SimpleReturn
            Console.WriteLine($"Call 1st: {SimpleReturn()}");
            Console.WriteLine($"Call 2nd: {SimpleReturn()}");
            Console.WriteLine($"Call 3rd: {SimpleReturn()}");
            Console.WriteLine($"Call 4th: {SimpleReturn()}");

            // Call YieldReturn
            foreach (int i in YieldReturn()) {
                Console.WriteLine(i);
            }
            
        }

        static int SimpleReturn() {
            return 1;
            return 2;
            return 3;
        }

        static IEnumerable<int> YieldReturn() {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }
    }
}
