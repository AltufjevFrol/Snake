using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '-');
            p1.Drow();

            Point p2 = new Point(4, 5, 'o');
            p2.Drow();

            HLine lineH = new HLine(0, 30, 10, '|');
            lineH.Drow();

            VLine lineV = new VLine(11, 41, 30, '-');
            lineV.Drow();



            Console.ReadLine();
        }               
    }
}
