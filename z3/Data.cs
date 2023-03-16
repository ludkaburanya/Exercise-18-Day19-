using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Data
    {
        public string w;
        public string g;
        public string t;
        public Data(string w, string g, string t)
        {
            this.w = w;
            this.g = g;
            this.t = t;
        }
        virtual public void PrintData()
        {
            Console.WriteLine("В такой(-их) стране(-ах)/континенте(-ах), как: " + g + " растет: " + w + ", такой вид растения в данном регионе:" + t);
        }
    }
}
