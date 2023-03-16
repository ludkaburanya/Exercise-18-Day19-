using System;
using System.Collections.Generic;
using System.Text;

namespace z1
{
    class Program
    {
        static void Main()
        {
            var s = "abc#d##c";
            var sk = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch == '#' && sk.Count != 0) sk.Pop();
                else sk.Push(ch);
            }
            var result = new StringBuilder();
            while (sk.Count != 0) result.Insert(0, sk.Pop());
            Console.WriteLine("После преобразования текста 'abc#d##c' получается следующий результат: " + result.ToString());
        }
    }
}