using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Figure
    {
        public List<Point> pList = new List<Point>();
        public List<Figure> fList = new List<Figure>();

        public int x = 0;
        public int y = 0;
        protected char symbol = '*';
        public ConsoleColor bColor = ConsoleColor.Black;
        protected ConsoleColor color = ConsoleColor.White;

        protected ConsoleColor InitializeColor(string color)
        {
            color = color.ToLower();
            switch (color)
            {
                case "black":
                    return ConsoleColor.Black;
                case "darkblue":
                    return ConsoleColor.DarkBlue;
                case "darkgreen":
                    return ConsoleColor.DarkGreen;
                case "darkcyan":
                    return ConsoleColor.DarkCyan;
                case "darkred":
                    return ConsoleColor.DarkRed;
                case "darkmagenta":
                    return ConsoleColor.DarkMagenta;
                case "darkyellow":
                    return ConsoleColor.DarkYellow;
                case "gray":
                    return ConsoleColor.Gray;
                case "darkgray":
                    return ConsoleColor.DarkGray;
                case "blue":
                    return ConsoleColor.Blue;
                case "green":
                    return ConsoleColor.Green;
                case "cyan":
                    return ConsoleColor.Cyan;
                case "red":
                    return ConsoleColor.Red;
                case "magenta":
                    return ConsoleColor.Magenta;
                case "yellow":
                    return ConsoleColor.Yellow;
                case "white":
                    return ConsoleColor.White;
                default:
                    return ConsoleColor.White;
            }
        }

        //Рисует Point
        public void DrawPoint()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.BackgroundColor = bColor;

            Console.Write(symbol);
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        
        public void DrawFigure()
        {
            foreach (Point f in pList)
            {
                f.DrawPoint();
            }
        }
        public void ClearFigure()
        {
            foreach (Point f in pList)
            {
                f.Clear();
            }
        }
        public bool IsHit(Point point)
        {
            if (x == point.x && y == point.y)
                return true;
            else
                return false;
        }

        public bool IsHit(Figure figure)
        {
            foreach (Point p in figure.pList)
            {
                if (x == p.x && y == p.y)
                    return true;
            }
            return false;
        }

        public bool IsHitWall(Point point)
        {
            foreach (Figure line in fList)
            {
                foreach (Point p in line.pList)
                {
                    if (p.x == point.x && p.y == point.y)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
