using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Point : Figure
    {
        public Point()
        {
            
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }
        public Point(int x, int y, char symbol, string color)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
            this.color = InitializeColor(color);
        }
        public Point(int x, int y, char symbol, string color, string bColor)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
            this.color = InitializeColor(color);
            this.bColor = InitializeColor(bColor);
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
            color = p.color;
            bColor = p.bColor;
        }

        public void Move(int offset, Direction direcrion)
        {
            if (direcrion == Direction.LEFT)
            {
                x = x - offset;
            }
            if (direcrion == Direction.RIGHT)
            {
                x = x + offset;
            }
            if (direcrion == Direction.UP)
            {
                y = y - offset;
            }
            if (direcrion == Direction.DOWN)
            {
                y = y + offset;
            }
        }
        public void Clear()
        {
            new Point(x, y, ' ', "", "black").DrawPoint();
            
        }
    }
}
