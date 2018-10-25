using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_quiz1
{
    class Fraction
    {
        int numerator;          // 분자 필드
        int denominator;       // 분모 필드
        public Fraction()       // 디폴트 생성자
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int n) // 생성자
        {
            numerator = n;
            denominator = 1;
        }
        public Fraction(int n, int d) // 생성자
        {
            numerator = n;
            denominator = d;
        }

        override public String ToString()
        {
            return (numerator + "/" + denominator);
        }
    }

    class Quiz4_1
    {
        public static void Main()
        {
            Fraction f1 = new Fraction(), f2 = new Fraction(2), f3 = new Fraction(1, 2);
            Fraction c1, c2;
            c1 = new Fraction(1, 2);
            c2 = new Fraction(3, 4);

            Console.WriteLine("c1 = {0}, c2 = {1}", c1, c2);
        }
    }
}
