using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4_한승우
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array1 = new int[] { 1, 4, 7 };
                int[] array2 = new int[] { 8, 6 };
                int[] array3 = new int[] { 5, 3, 9, 4 };
                int[][] array_array = { array1, array2, array3 };
                int i, j, k;
                for (i = 0; i < array1.Length; i++)
                    Console.Write(array1[i] + " ");
                Console.WriteLine("합 = {0}", array1.Sum());
                for (j = 0; j < array2.Length; j++)
                    Console.Write(array2[j] + " ");
                Console.WriteLine("합 = {0}", array2.Sum());
                for (k = 0; k < array3.Length; k++)
                    Console.Write(array3[k] + " ");
                Console.WriteLine("합 = {0}", array3.Sum());
            }
        }
    }
}
