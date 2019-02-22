using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int y, int length)
        {
            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x, y + i));
            }
        }
        public VerticalLine(int x, int y, int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x, y + i, symbol));
            }
        }
        public VerticalLine(int x, int y, int length, char symbol, string color)
        {
            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x, y + i, symbol, color));
            }
        }
        public VerticalLine(int x, int y, int length, char symbol, string color, string bColor)
        {
            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x, y + i, symbol, color, bColor));
                
            }
        }

    }
}
