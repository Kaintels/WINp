using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1_한승우
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; char c;
            Console.Write("Enter a digit and a character = ");
            i = Console.Read() - '0';
            c = (char) Console.Read();
            Console.Write("i=" + i);
            Console.WriteLine(",c =" + c);

        }
    }
}
