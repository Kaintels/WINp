using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_quiz4_13
{

    class Stack
    {
        private int[] stack;
        int sp = -1;

        public Stack()
        {
            stack = new int[100];
        }
        public Stack(int size) // 생성자
        {
            size = 100; // 스택 크기
            stack = new int[size];
        }

        public void Push(int data)
        {
            stack[++sp] = data;
        }
        public int Pop()
        {
            return stack[sp--];
        }
        public int GetStack()
        {
            return sp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack a = new Stack();

            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Push(4);
            a.Push(5);
            a.Push(6);
            a.Push(7);
            a.Push(8);
            a.Push(9);
            a.Push(10);
            while (a.GetStack() != -1)
            {
                Console.WriteLine(a.Pop()); // 역순으로 출력
            }
        }
    }
}
