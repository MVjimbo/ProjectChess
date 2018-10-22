using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheksLibruary
{
    class Elephant:Chess//Слон
    {
        Elephant(int a, int b) : base(a, b)
        { }
        public override List<int> FindPozitions()
        {
            var list = new List<int>();
            int Poz = ReturnPozition();
            int a = Poz / 10 + 1;
            int b = Poz % 10+1;
            while ((a < 9) && (b<9))
            {
                list.Add(ReturnPozition(a++, b++));
            }
            a = Poz / 10 + 1;
            b = Poz % 10 - 1;
            while ((a <9) && (b>0))
            {
                list.Add(ReturnPozition(a++, b--));
            }
            a = Poz / 10-1;
            b = Poz % 10 + 1;
            while ((a>0) && (b < 9))
            {
                list.Add(ReturnPozition(a--, b++));
            }
            a = Poz / 10 - 1;
            b = Poz % 10 - 1;
            while ((a>0) && (b > 0))
            {
                list.Add(ReturnPozition(a--, b--));
            }
            return list;
        }
    }
}
