using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Weth : IEnumerable
    {
        private ArrayList list;
        public Weth()
        {
            list = new ArrayList();
        }
        public Weth(ArrayList a)
        {
            list = a;
        }
        public void Add(PlantSpecies m)
        {
            list.Add(m);
        }
        public Weth Clone()
        {
            return new Weth(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}