using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_quiz4_12
{
    class Complex
    {
        public double real; // 실수부
        public double image; // 허수부
        public Complex()
        {
            real = 0.0;
            image = 0.0;
        }
        public Complex(double real, double image) // 생성자
        {
            this.real = real; ;
            this.image = image;
        }

        override public String ToString()
        {
            return real.ToString() + "+" + image.ToString() +"i";
        }

        public Complex AddComplex(Complex a) // 합 구하기
        {
            return new Complex(real + a.real, image + a.image);
        }

        public Complex SubComplex(Complex a) // 차 구하기
        {
            return new Complex(real - a.real, image - a.image);
        }

        public Complex MulComplex(Complex a) // 곱 구하기
        {
            return new Complex(real * a.real - image * a.image, real * a.image + image * a.real);
        }

        public Complex DivComplex(Complex a) // 나눗셈 구하기
        {
            return new Complex((real * a.real + image * a.image) / (a.real * a.real + a.image * a.image), (image * a.real - real * a.image) / (a.real * a.real + a.image * a.image));
        }

        class Program
        {
            static void Main(string[] args)
            {
                Complex a1 = new Complex(2, 3);
                Complex a2 = new Complex(5, 1);
                Console.WriteLine("{0}", a1);
                Console.WriteLine("{0}", a2);
                Complex c1, c2, c3, c4;
                c1 = a1.AddComplex(a2);
                c2 = a1.SubComplex(a2);
                c3 = a1.MulComplex(a2);
                c4 = a1.DivComplex(a2);
                Console.WriteLine("합 : {0}", c1);
                Console.WriteLine("차 : {0}", c2);
                Console.WriteLine("곱 : {0}", c3);
                Console.WriteLine("나누기 : {0}", c4);
            }
        }
    }
}
