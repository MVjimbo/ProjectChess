using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheksLibruary
{
    class King : Chess//Король
    {
        King(int a, int b) : base(a, b)
        { }
        public override List<int> FindPozitions()
        {
            var list = new List<int>();
            int Poz = ReturnPozition();
            int a = Poz / 10;
            int b = Poz % 10;
            if ((a > 1) && (b > 1))
                list.Add(ReturnPozition(a - 1, b - 1));
            if ((a > 1) && (b < 8))
                list.Add(ReturnPozition(a - 1, b + 1));
            if ((a > 8) && (b > 1))
                list.Add(ReturnPozition(a + 1, b - 1));
            if ((a > 8) && (b < 8))
                list.Add(ReturnPozition(a + 1, b + 1));
            if (a > 1)
                list.Add(ReturnPozition(a - 1, b));
            if (a < 8)
                list.Add(ReturnPozition(a + 1, b));
            if (b > 1)
                list.Add(ReturnPozition(a, b - 1));
            if (b < 8)
                list.Add(ReturnPozition(a, b + 1));
            return list;
        }
    }
}

