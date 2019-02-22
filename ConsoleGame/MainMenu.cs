using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class MainMenu
    {
        int selection = 0;
        HorizontalLine selectLine;

        int width;
        int height;
        int speed;

        Game game;

        public int Selection
        {
            set
            {
                if (value < 0)
                {
                    selection = 0;
                } else if (value > 2)
                {
                    selection = 2;
                } else
                {
                    selection = value;
                }
            }
            get
            {
                return selection;
            }
        }

        public MainMenu(int width, int height, int speed)
        {
            this.width = width;
            this.height = height;
            this.speed = speed;

            game = new Game(width, height, speed);
        }

        public void BuildMenu()
        {
            Console.Clear();

            Console.SetCursorPosition(45, 17);
            Console.Write("NEW GAME");

            Console.SetCursorPosition(45, 19);
            Console.Write("NOGHING!");

            Console.SetCursorPosition(47, 21);
            Console.Write("EXIT");
        }
        public void ShowMenu()
        {
            BuildMenu();

            while (true)
            {

                switch (selection)
                {
                    case 0:
                        
                        DrawLine(45,18,8);
                        break;
                    case 1:
                        DrawLine(45, 20, 8);
                        break;
                    case 2:
                        DrawLine(45, 22, 8);
                        break;
                    default:
                        break;
                }

                if (Console.KeyAvailable == true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        selectLine.ClearFigure();
                        Selection++;
                    } else if (key.Key == ConsoleKey.UpArrow)
                    {
                        selectLine.ClearFigure();
                        Selection--;
                    }

                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (selection == 0)
                        {
                            Console.Clear();
                            game.Start();
                            BuildMenu();
                        } else if (selection == 1)
                        {
                            new Nothing();
                            BuildMenu();

                        } else if (selection == 2)
                        {
                            break;
                        }
                    }
                }
            }
        }

        public void DrawLine(int x, int y, int length)
        {
            selectLine = new HorizontalLine(x, y, length, ' ', "", "cyan");

            selectLine.DrawFigure();

        }
    }
}
