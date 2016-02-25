using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontLine upLine = new HorizontLine(0, 78, 0, '=');
            HorizontLine downLine = new HorizontLine(0, 78, 24, '=');
            VerticalLine leftLine = new VerticalLine(1, 23, 0, '|');
            VerticalLine rightLine = new VerticalLine(1, 23, 78, '|');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(5, 5, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Drow();

            while (true)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.GetDirection(key.Key);
                }
                
                snake.Move();
                snake.Drow();

                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
