using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz4_4
{
    class Fraction
    {
        public enum Index { }
        private int numerator;
        private int denominator;
        public int this[int num, int Numerator]
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int this[Index deno, int Denominator]
        {
            get { return denominator; }
            set { if (value != 0) denominator = value; }
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
            result.numerator = a / i;
            result.denominator = b / i;
            return result;
        }
        public static Fraction operator +(Fraction op1, Fraction op2)
        {
            Fraction result = new Fraction(1, 1);
            result.denominator = op1.denominator * op2.denominator;
            result.numerator = op1.numerator * op2.denominator + op2.numerator * op1.denominator;
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
    class ClickEventApp : Form
    {
        public ClickEventApp()
        {
            this.Text = "ClickEventApp";
            this.Click += new EventHandler(ClickEvent);
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            Fraction result;
            Fraction operand1 = new Fraction(1, 2);
            Fraction operand2 = new Fraction(3, 4);
            result = operand1 + operand2;
            MessageBox.Show(operand1 + "+" + operand2 + "=" + result);
        }
        public static void Main()
        {
            Application.Run(new ClickEventApp());
        }
    }
}
