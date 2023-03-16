using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class PlantSpecies : Data
    {
        int temp;
        public PlantSpecies(string w, string g, string t) : base (w,g,t)
        {
            this.t = t;
        }
        override public void PrintData()
        {
            Console.WriteLine("В такой(-их) старне(-ах)/континенте(-ах), как: " + g + " растет: " + w + ", такой вид растения в данном регионе " + t);
        }
    }
}