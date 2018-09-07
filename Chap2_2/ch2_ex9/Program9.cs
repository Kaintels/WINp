using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Color { Red, Green, Blue }

namespace ch2_ex9
{
    class Program9
    {
        static void Main(string[] args)
        {
            Color c = Color.Red;
            c++;
            int i = (int)c;
            Console.WriteLine("Cardinality of " + c + " = " + i);
        }
    }
}
