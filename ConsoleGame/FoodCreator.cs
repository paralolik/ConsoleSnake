using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class FoodCreator : Figure
    {
        int width;
        int height;

        Point food;
        Random random = new Random();

        public FoodCreator(int width, int height)
        {
            this.width = width;
            this.height = height;
            food = new Point(0, 0, ' ', "", "red");
        }

        public Point CreateFoodPoint(List<Point> pList)
        {
            do
            {
                int x = random.Next(4, width - 4);
                int y = random.Next(4, height - 4);

                foreach (Point point in pList)
                {
                    if (x != point.x && y != point.y)
                    {
                        food.x = x;
                        food.y = y;

                        return food;
                    }
                }
            } while (true);
            
            
        }
    }
}
