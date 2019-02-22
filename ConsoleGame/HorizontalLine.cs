using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int x, int y, int length)
        {
            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x+i, y));
            }
        }
        public HorizontalLine(int x, int y, int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x + i, y,symbol));
            }
        }
        public HorizontalLine(int x, int y, int length, char symbol, string color)
        {
            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x + i, y, symbol, color));
            }
        }
        public HorizontalLine(int x, int y, int length, char symbol, string color, string bColor)
        {
            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x + i, y, symbol, color, bColor));
                
            }
        }
    }
}
