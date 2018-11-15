using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VLine : Figure
    {
        
        public VLine(int yH, int yL, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yH; y <= yL; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        
    }
}
