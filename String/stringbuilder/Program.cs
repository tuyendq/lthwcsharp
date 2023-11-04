/* C# Convention
* To append strings in loops, especially when you are working with
* large amount of text, use a StringBuilder object.
*/
using System;
using System.Text;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
            var manyPhrases = new StringBuilder();
            for (var i = 0; i < 10000; i++)
            {
                manyPhrases.Append(phrase);
            }
            Console.WriteLine("tra" + manyPhrases);
        }
    }
}
