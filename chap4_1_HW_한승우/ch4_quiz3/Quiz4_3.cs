using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_quiz3
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        // 생성자 정의
        // 속성 정의
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

        // 사칙연산 연산자 오버로딩 정의
        public static Fraction operator +(Fraction op1, Fraction op2)
        {
            Fraction result = new Fraction(1, 1);
            //분모 계산
            //분자 계산
            result.denominator = op1.denominator * op2.denominator;
            result.numerator = op1.numerator * op2.denominator + op2.numerator * op1.denominator;
            return result;
        }

        public static Fraction operator -(Fraction op1, Fraction op2)
        {
            Fraction result = new Fraction(1, 1);
            result.denominator = op1.denominator * op2.denominator;
            result.numerator = op1.numerator * op2.denominator - op2.numerator * op1.denominator;
            return result;
        }

        public static Fraction operator *(Fraction op1, Fraction op2)
        {
            Fraction result = new Fraction(op1.numerator * op2.numerator, op1.denominator * op2.denominator);
            return result;
        }

        public static Fraction operator /(Fraction op1, Fraction op2)
        {
            Fraction result = new Fraction(op1.numerator * op2.denominator, op1.denominator * op2.numerator);
            return result;
        }
        //ToString() method overriding
        override public String ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    class Quiz4_3
    {
        static void Main(string[] args)
        {
            Fraction result;
            Fraction operand1 = new Fraction(2, 5);
            Fraction operand2 = new Fraction(1, 4);
            result = operand1 + operand2;
            Console.WriteLine(operand1 + " + " + operand2 + " = " + result);
            result = operand1 - operand2;
            Console.WriteLine(operand1 + " - " + operand2 + " = " + result);
            result = operand1 * operand2;
            Console.WriteLine(operand1 + " * " + operand2 + " = " + result);
            result = operand1 / operand2;
            Console.WriteLine(operand1 + " / " + operand2 + " = " + result);
        }
    }
}
