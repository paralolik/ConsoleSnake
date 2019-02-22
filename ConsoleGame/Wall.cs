using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Wall : Figure
    {
        public Wall()
        {

        }
        public Wall(int mapWidth, int mapHeight)
        {;
            fList.Add(new HorizontalLine(3, 3, mapWidth - 6, ' ', "", "yellow"));
            fList.Add(new HorizontalLine(3, mapHeight - 3, mapWidth - 6, ' ', "", "yellow"));
            fList.Add(new VerticalLine(3, 3, mapHeight - 5, ' ', "", "yellow"));
            fList.Add(new VerticalLine(mapWidth - 3, 3, mapHeight - 5, ' ', "", "yellow"));
        }

        public void Draw()
        {
            foreach (Figure line in fList)
            {
                line.DrawFigure();
            }
        }
    }
}
