using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        int wallWidht;
        int wallHeight;
        int level;
        int maxSnakeWidht;

        public Walls(int wallWidht, int wallHeight)
        {
            this.wallWidht = wallWidht;
            this.wallHeight = wallHeight;
            level = 1;
            maxSnakeWidht = 10;
        }

        public void CreateWalls()
        {
            List<Figure> figure = new List<Figure>();

            figure.Add(new HorizontLine(1, wallWidht, 1, '='));
            figure.Add(new HorizontLine(1, wallWidht, wallHeight+1, '='));
            figure.Add(new VerticalLine(1, wallHeight, 1, '|'));
            figure.Add(new VerticalLine(1, wallHeight, wallWidht, '|'));

            foreach (Figure wall in figure)
            {
                wall.Drow();
            }
            DrowLevel();
        }

        public void SetNextLevel(int snakeLength)
        {
            if (snakeLength == maxSnakeWidht)
            {
                level++;
                maxSnakeWidht = maxSnakeWidht + 5;
                DrowLevel();
            }
            
        }

        void DrowLevel()
        {
            Console.SetCursorPosition((wallWidht - 3) / 2, 0);
            Console.Write("Level " + level.ToString());
          
        }

        public bool IsHit(Point p)
        {
            if (p.x == 1 || p.x == wallWidht || p.y == 1 || p.y == wallHeight)
            {
                return true;
            }
            else return false;
        }
    }
}
