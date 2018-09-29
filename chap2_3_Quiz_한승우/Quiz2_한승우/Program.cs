using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2_한승우
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("정수를 입력해주세요. (한자리수만 가능합니다.)\n");
            int max = 0;
            int[] data = new int[5];
            RESTART: // 재시작 레이블
            for (int i = 0; i < data.Length; i++)
            {
                input = Console.ReadLine();
                try
                {
                    data[i] = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("아무 숫자도 입력하지 않았습니다. 다시 입력해주세요.");
                    Console.Write("정수를 입력해주세요. (한자리수만 가능합니다.)\n");
                    goto RESTART;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("아무 숫자도 입력하지 않았습니다. 다시 입력해주세요.");
                    Console.Write("정수를 입력해주세요. (한자리수만 가능합니다.)\n");
                    goto RESTART;
                }
                if (data[i] > 9)
                {
                    Console.WriteLine("두자리 숫자를 입력하셨습니다. 다시 입력해주세요.");
                    Console.Write("정수를 입력해주세요. (한자리수만 가능합니다.)\n");
                    goto RESTART;
                }
                else if (data[i] == 0)
                {
                    Console.WriteLine("0을 입력하셨습니다. 다시 입력해주세요.");
                    Console.Write("정수를 입력해주세요. (한자리수만 가능합니다.)\n");
                    goto RESTART;
                }
                else if (data[i] > max)
                {
                    max = data[i];
                }
            }
            Console.WriteLine("최대값 : {0}", max);
        }      
    }
}
