using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_quiz2
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator // 속성 추가
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator // 속성 추가
        {
            get { return denominator; }
            set { denominator = value; }
        }
        override public string ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    class Quiz4_2
    {
        public static void Main()
        {
            Fraction f = new Fraction();
            int i;
            f.Numerator = 1;
            i = f.Numerator + 1;
            f.Denominator = i;
            Console.WriteLine(f.ToString());
        }
    }
}
