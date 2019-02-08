using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4_2
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }
        public int Denominator
        {
            get { return this.denominator; }
            set { if (value !=0) this.denominator = value; }
        }
        public Fraction(int num, int deno)
        {
            numerator = num;
            denominator = deno;
        }
        public static Fraction CommonMeasure(int a, int b)//공약수
        {
            int i;
            Fraction result = new Fraction(1, 1);
            for (i = b; i > 0; i--)
            { if (a % i == 0 && b % i == 0) break; }
            result.numerator= a / i;
            result.denominator = b / i;
            return result;
        }
        public static Fraction operator +(Fraction op1, Fraction op2)
        {
            Fraction result = new Fraction(1, 1);
            result.denominator = op1.denominator * op2.denominator;
            result.numerator = op1.numerator * op2.denominator +op2.numerator * op1.denominator;
            result = CommonMeasure(result.numerator, result.denominator);
            return result;
        }
        public static Fraction operator -(Fraction op1, Fraction op2)
        {
            Fraction result = new Fraction(1, 1);
            result.denominator = op1.denominator * op2.denominator;
            result.numerator = op1.numerator * op2.denominator - op2.numerator * op1.denominator;
            result = CommonMeasure(result.numerator, result.denominator);
            return result;
        }
        public static Fraction operator *(Fraction op1, Fraction op2)
        {
            Fraction result = new Fraction(op1.numerator * op2.numerator, op1.denominator * op2.denominator);
            result = CommonMeasure(result.numerator, result.denominator);
            return result;
        }
        public static Fraction operator /(Fraction op1, Fraction op2)
        {
            Fraction result = new Fraction(op1.numerator * op2.denominator, op1.denominator * op2.numerator);
            result = CommonMeasure(result.numerator, result.denominator);
            return result;
        }
        override public string ToString()
        { return (numerator + "/" + denominator); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction result;
            Fraction operand1 = new Fraction(1, 2);
            Fraction operand2 = new Fraction(3, 4);
            result = operand1 + operand2;
            Console.WriteLine(operand1 + "+" + operand2 + "=" + result);
            result = operand1 - operand2;
            Console.WriteLine(operand1 + "-" + operand2 + "=" + result);
            result = operand1 * operand2;
            Console.WriteLine(operand1 + "*" + operand2 + "=" + result);
            result = operand1 / operand2;
            Console.WriteLine(operand1 + "/" + operand2 + "=" + result);
            operand2.Denominator = operand2.Numerator - 1;
            Console.WriteLine(operand2.ToString());
        }
    }
}
