using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pLine;

        public void Drow()
        {
            foreach (Point p in pLine)
            {
                p.Drow();
            }
        }
    }
}
