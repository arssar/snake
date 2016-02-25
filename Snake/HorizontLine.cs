using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontLine : Figure
    {
        public HorizontLine(int xleft, int xright, int y, char sym)
        {
            pLine = new List<Point>();
            for( int i = xleft; i <= xright; i++)
            {
                Point p = new Point(i, y, sym);
                pLine.Add(p);
            }
        }
    }
}
