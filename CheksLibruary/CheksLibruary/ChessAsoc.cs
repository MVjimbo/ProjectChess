using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheksLibruary
{
    abstract class Chess//Абстрактный класс шахмат
    {
        int _pozition { get; set; }
        public Chess (int a,int b)
        {
            _pozition = a * 10 + b;
        }
        public int ReturnPozition()
        {
            return _pozition;
        }
        public int ReturnPozition(int a,int b)
        {
            return a * 10 + b;
        }
        public int ChangeReturnPozition(int a, int b)
        {
            return _pozition = a * 10 + b;
        }
        public abstract List<int> FindPozitions(); 
    }
}
