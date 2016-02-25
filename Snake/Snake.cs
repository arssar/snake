using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;

            pLine = new List<Point>();
            for(int i = 1; i <= length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pLine.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pLine.First();
            pLine.Remove(tail);
            Point head = GetNextPoint();
            pLine.Add(head);

            tail.Clear();
            head.Drow();
            
        }

        private Point GetNextPoint()
        {
            Point pLast = pLine.Last();
            Point pNext = new Point(pLast);
            pNext.Move(1, direction);

            return pNext;
        }

        public void GetDirection(ConsoleKey key)
        {
            if(key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }
    }
}
