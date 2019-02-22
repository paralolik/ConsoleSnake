using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Game
    {
        private double speed;
        private double _speed;
        protected int mapWidth;
        protected int mapHeight;
        FoodCreator food;
        Point foodPoint;
        Wall wall;
        int count = 0;

        public Game()
        {
            speed = 100.0;
            mapWidth = 56;
            mapHeight = 24;
        }
        public Game(int speed)
        {
            this.speed = speed;
            mapWidth = 56;
            mapHeight = 24;
        }
        public Game(int width, int height)
        {
            speed = 100.0;
            mapWidth = width;
            mapHeight = height;
        }
        public Game(int width, int height, int speed)
        {
            this.speed = speed;
            mapWidth = width;
            mapHeight = height;
        }

        public void Start()
        {
            Console.Title = "Змейка";
            count = 0;
            speed = 100.0;
            food = new FoodCreator(mapWidth, mapHeight);

            wall = new Wall(mapWidth, mapHeight);
            wall.Draw();

            Snake snake = new Snake(new Point(6, 20, ' ', "green", "cyan"), 10, Direction.RIGHT);
            snake.DrawSnake();
            foodPoint = new Point(food.CreateFoodPoint(snake.pList));
            foodPoint.DrawPoint();
            Console.Write("   YOU SCORE " + count + " ");
            MoveSnakeCore(snake);
        }

        public void MoveSnakeCore(Snake snake)
        {
            _speed = speed;

            while (true)
            {
                if (wall.IsHitWall(snake.head) == true || snake.IsHitSnake())
                {
                    new GameOver(count);
                    break;
                }

                if (foodPoint.IsHit(snake.head) == true)
                {
                    foodPoint = food.CreateFoodPoint(snake.pList);
                    foodPoint.DrawPoint();
                    snake.FoodEat();
                    count++;
                    speed = speed - 2.0;
                    Console.Write("   YOU SCORE "+count+" ");
                }

                if (Console.KeyAvailable == true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    //
                    //Псхалыч для Сереги
                    if (key.Key == ConsoleKey.S)
                    {
                        Console.Write("А ВОТ И ПАСХАЛОЧКА               ыыыыыыы");
                        //С
                        new HorizontalLine(7, 5, 5, ' ', "cyan", "yellow");
                        new VerticalLine(7, 5, 4, ' ', "cyan", "yellow");
                        new HorizontalLine(7, 9, 5, ' ', "cyan", "yellow");
                        //Е
                        new VerticalLine(13, 5, 4, ' ', "cyan", "yellow");
                        new HorizontalLine(13, 5, 5, ' ', "cyan", "yellow");
                        new HorizontalLine(13, 7, 5, ' ', "cyan", "yellow");
                        new HorizontalLine(13, 9, 5, ' ', "cyan", "yellow");
                        //Г
                        new VerticalLine(20, 5, 5, ' ', "cyan", "yellow");
                        new HorizontalLine(20, 5, 5, ' ', "cyan", "yellow");
                        //А
                        new Point(26, 9, ' ', "", "yellow").DrawPoint();
                        new Point(27, 8, ' ', "", "yellow").DrawPoint();
                        new Point(28, 7, ' ', "", "yellow").DrawPoint();
                        new Point(29, 6, ' ', "", "yellow").DrawPoint();
                        new Point(30, 5, ' ', "", "yellow").DrawPoint();
                        new Point(31, 6, ' ', "", "yellow").DrawPoint();
                        new Point(32, 7, ' ', "", "yellow").DrawPoint();
                        new Point(33, 8, ' ', "", "yellow").DrawPoint();
                        new Point(34, 9, ' ', "", "yellow").DrawPoint();

                        new HorizontalLine(28, 8, 5, ' ', "cyan", "yellow");
                        //!
                        new VerticalLine(36, 5, 3, ' ', "cyan", "yellow");

                        new Point(36, 9, ' ', "", "yellow").DrawPoint();
                        //С
                        new HorizontalLine(7, 11, 5, ' ', "cyan", "yellow");
                        new VerticalLine(7, 11, 4, ' ', "cyan", "yellow");
                        new HorizontalLine(7, 15, 5, ' ', "cyan", "yellow");
                        //Д
                        new VerticalLine(20, 14, 2, ' ', "cyan", "yellow");
                        new HorizontalLine(21, 14, 7, ' ', "cyan", "yellow");
                        new VerticalLine(21, 11, 3, ' ', "cyan", "yellow");
                        new HorizontalLine(21, 11, 5, ' ', "cyan", "yellow");
                        new VerticalLine(26, 11, 3, ' ', "cyan", "yellow");

                        new Point(27, 15, ' ', "", "yellow").DrawPoint();
                        //Р
                        new VerticalLine(29, 11, 5, ' ', "cyan", "yellow");
                        new HorizontalLine(29, 11, 6, ' ', "cyan", "yellow");
                        new HorizontalLine(29, 13, 6, ' ', "cyan", "yellow");
                        new VerticalLine(34, 11, 3, ' ', "cyan", "yellow");
                        //!
                        new VerticalLine(36, 11, 3, ' ', "cyan", "yellow");

                        new Point(36, 15, ' ', "", "yellow").DrawPoint();
                    }

                    if (key.Key == ConsoleKey.LeftArrow && snake.direction != Direction.RIGHT)
                    {
                        snake.direction = Direction.LEFT;
                        _speed = speed / 1.7;
                    }
                    else if (key.Key == ConsoleKey.RightArrow && snake.direction != Direction.LEFT)
                    {
                        snake.direction = Direction.RIGHT;
                        _speed = speed / 1.7;
                    }
                    else if (key.Key == ConsoleKey.UpArrow && snake.direction != Direction.DOWN)
                    {
                        snake.direction = Direction.UP;
                        _speed = speed;
                    }
                    else if (key.Key == ConsoleKey.DownArrow && snake.direction != Direction.UP)
                    {
                        snake.direction = Direction.DOWN;
                        _speed = speed;
                    }
                }
                Thread.Sleep(Convert.ToInt16(_speed));
                snake.Move();
            }
        }
    }
}
