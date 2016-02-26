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

            Walls walls = new Walls(79, 23);
            walls.CreateWalls();

            Point p = new Point(5, 5, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Drow();

            // создадим еду, случайную точку.
            FoodCreator foodCreator = new FoodCreator(78, 24, '@');
            Point food = foodCreator.CreateFood();
            food.Drow();


            while (true)
            {
                if (walls.IsHit(snake.GetLastPoint()))
                {
                    Console.SetCursorPosition(35, 12);
                    Console.Write("Game over!");
                    break;
                }

                if (snake.IsHit())
                {
                    Console.SetCursorPosition(35, 12);
                    Console.Write("Game over!");
                    break;                    
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();

                    walls.SetNextLevel(snake.GetSnakeLength());

                }else snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.GetDirection(key.Key);
                }
                
                //snake.Move();
                snake.Drow();

                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
