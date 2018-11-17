using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 30);
            Console.SetBufferSize(90, 30);
            // Отрисовка рамки
            HLine upline = new HLine(2, 88, 2, '-');
            HLine downline = new HLine(2, 88, 28, '-');
            VLine leftline = new VLine(1, 29, 1, '|');
            VLine rightline = new VLine(1, 29, 89, '|');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            Point p = new Point(4, 5, 'o');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Drow();

            while (true)
            {
                if(snake.Eat( food ) )
				{
					food = foodCreator.CreateFood();
					food.Drow();
				}
				else
				{
					snake.Move();
				}					

				Thread.Sleep( 100 );

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey( key.Key );
				}
            }

            
            
           







         
        }               
    }
}
