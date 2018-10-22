using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheksLibruary
{
    class Pawn: Chess//Пешка
    {
        Pawn(int a,int b): base(a,b)
        { }
        public override List<int> FindPozitions()
        {
            var list = new List<int> ();
            int Poz = ReturnPozition();
            int a = Poz / 10;
            int b = Poz % 10;
            if (a == 2)
            {
                list.Add(ReturnPozition(a + 2, b));
                list.Add(ReturnPozition(a + 1, b));
            }
            else
                list.Add(ReturnPozition(a + 1, b));
            return list;
        }
    }
}
