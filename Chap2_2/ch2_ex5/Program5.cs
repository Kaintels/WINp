using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_ex5
{
    class Program5
    {
        static void Main(string[] args)
        {
            char c = 'A';
            int i;
            i = c + 1;
            Console.WriteLine("c = " + c + "\nnext c = " + (char)i);
            Console.WriteLine("\"I am a string.\"");
            Console.WriteLine(@"""I am a string.""");
            Console.ReadLine();
        }
    }
}
