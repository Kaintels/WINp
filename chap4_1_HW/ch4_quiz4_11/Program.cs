using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FractionTest
{
    class Fraction
    {
        public int numerator;
        public int denumerator;

        public Fraction(int n)
        {
            numerator = 1;
            denumerator = n;
        }

        public Fraction(int n, int d) // 생성자
        {
            numerator = n;
            denumerator = d;
        }

        override public string ToString()
        {
            return (numerator + "/" + denumerator);
        }

        public string ToString(int numberator, int denumerator)
        {
            return (numerator + "/" + denumerator);
        }

        public void GCD() // 최대 공약수 코드
        {
            int temp = numerator % denumerator;
            int i = 1;
            while (temp != 0)
            {
                i++;
                if (i % numerator == i % denumerator)
                    break;
            }
            int num = this.numerator;
            Console.WriteLine("최대 공약수 : " + num);
        }

        public void Irreducible() // 기약분수 코드
        {

            int i = 1;
            while (i % numerator != 0 && i % denumerator != 0)
            {
                i++;
            }
            Console.WriteLine("기약 분수 : " + numerator / i + "/" + denumerator / i);
        }

        public void AddFraction(Fraction a)                                       // 합 구하기
        {
            int i = 1;
            int numerator = this.numerator * a.denumerator + a.denumerator * this.numerator;
            int denumerator = this.denumerator * a.denumerator;
            while (i % numerator != 0 && i % denumerator != 0)
            {
                i++;
            }
            numerator /= i;
            denumerator /= i;
            Console.WriteLine("합 = " + ToString(numerator, denumerator));
        }
        public void SubFraction(Fraction a)                                       // 차 구하기
        {
            int i = 1;
            int numerator = this.numerator * a.denumerator - a.denumerator * this.numerator;
            int denumerator = this.denumerator * a.denumerator;
            if (numerator == 0)
            {
                Console.WriteLine("차 = " + 0);
            }
            else
            {
                while (i % numerator != 0 && i % denumerator != 0)
                {
                    i++;
                }
                numerator /= i;
                denumerator /= i;
                Console.WriteLine("차 = " + ToString(numerator, denumerator));
            }
        }
        public void MulFraction(Fraction a)                                       // 곱 구하기
        {
            int i = 1;
            int numerator = this.numerator * a.numerator;
            int denumerator = this.denumerator * a.denumerator;
            while (i % numerator != 0 && i % denumerator != 0)
            {
                i++;
            }
            numerator /= i;
            denumerator /= i;
            Console.WriteLine("곱 = " + ToString(numerator, denumerator));
        }
        public void DivFraction(Fraction a)                                       // 나눗셈 구하기
        {
            int i = 1;
            int numerator = this.numerator * a.denumerator;
            int denumerator = this.denumerator * a.numerator;
            while (i % numerator != 0 && i % denumerator != 0)
            {
                i++;
            }
            numerator /= i;
            denumerator /= i;
            Console.WriteLine("나누기 = " + ToString(numerator, denumerator));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction c1 = new Fraction(6);
            Console.WriteLine("c1 = {0}", c1); 
            Fraction c2 = new Fraction(1, 6);
            Console.WriteLine("c1 = {0} c2 = {1}",c1, c2);
            c2.GCD();
            c2.Irreducible();
            c1.AddFraction(c2);
            c1.SubFraction(c2);
            c1.MulFraction(c2);
            c1.DivFraction(c2);
        }
    }
}