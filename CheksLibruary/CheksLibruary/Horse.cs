using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheksLibruary
{
    class Horse:Chess//Конь
    {
        Horse(int a, int b) : base(a, b)
        { }
        public override List<int> FindPozitions()
        {
            var list = new List<int>();
            int Poz = ReturnPozition();
            int a = Poz / 10;
            int b = Poz % 10;
            if ((a > 2) && (b > 1))
                list.Add(ReturnPozition(a - 2, b - 1));
            if ((a > 2) && (b < 8))
                list.Add(ReturnPozition(a - 2, b +1));
            if ((a > 1) && (b > 2))
                list.Add(ReturnPozition(a - 1 , b -2));
            if ((a > 1) && (b < 7))
                list.Add(ReturnPozition(a - 1, b + 2));
            if ((a <7) && (b >1))
                list.Add(ReturnPozition(a + 2, b -1));
            if ((a < 7) && (b < 8))
                list.Add(ReturnPozition(a +2, b + 1));
            if ((a <8) && (b > 2))
                list.Add(ReturnPozition(a + 1, b -2));
            if ((a < 8) && (b < 7))
                list.Add(ReturnPozition(a + 1, b + 2));
            return list;
        }
    }
}
