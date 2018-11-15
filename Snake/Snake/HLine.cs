using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HLine
    {
        List<Point> pList;

        public HLine(int xL, int xR, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xL; x <= xR; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Drow();

            }
        }

    }
}
