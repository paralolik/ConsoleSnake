using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Snake : Figure
    {
        //Список с Point'ами змейки
        public Direction direction;
        public Point head;
        Point nextPoint;
        public Point tail;

        public Snake(Point _tail, int lenght, Direction _direction)
        {
            direction = _direction;
            tail = _tail;

            pList = new List<Point>();
            //Создает Point'ы змейки в pList в заданном direction
            for (int i = 0; i < lenght; i++)
            {
                tail.Move(1, direction);
                pList.Add(new Point(tail));
            }
            head = pList.Last();
        }

        public void DrawSnake()
        {
            foreach (Point p in pList)
            {
                p.DrawPoint();
            }
        }

        public void FoodEat()
        {
            head = GetNextPoint();
            pList.Add(head);
            head.DrawPoint();
        }

        internal void Move()
        {
            tail = pList.First();
            pList.Remove(tail);

            head = GetNextPoint();

            

            pList.Add(head);

            tail.Clear();
            head.DrawPoint();
        }
        Point GetNextPoint()
        {
            Point head = pList.Last();
            nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public bool IsHitSnake()
        {

            Point head = pList.Last();


            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
