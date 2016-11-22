using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            Console.WriteLine($"x is null: {x}");

            //Null conditional operator
            List<string> authors = null;
            int? count = authors?.Count;

            //Ternary operator
            string message = count == null ? "Count is null " : "Count is not null" ;
            Console.WriteLine(message);

            //Null coalescing
            int howMany = authors?.Count ?? 0;
            Console.WriteLine($"howmany: {howMany}");

            authors = new List<string>
            {
                "author one",
                "author two"
            };

            howMany = authors?.Count ?? 0;
            Console.WriteLine($"howmany = {howMany}");

            Console.ReadLine();
        }
    }
}
