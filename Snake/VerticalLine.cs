using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yStart,int yEnd,char symb)
        {
            pList = new List<Point>();
            for (int y = yStart; y <= yEnd; y++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
        }

        
    }
}
