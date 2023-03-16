using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class InfoObj
    {
        public static void Info<tip>(tip obj)
            where tip : Data
        {
            obj.PrintData();
        }
    }
}
