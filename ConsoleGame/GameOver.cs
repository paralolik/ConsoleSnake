using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class GameOver
    {
        public GameOver(int count)
        {
            Console.Clear();
            Console.SetCursorPosition(41,17);
            Console.Write("GAME OVER");
            Console.SetCursorPosition(41, 19);
            Console.Write("YOUR SCORE");
            Console.SetCursorPosition(45, 21);
            Console.Write(count);
            Console.SetCursorPosition(33, 23);
            Console.Write("PRESS <ENTER> TO CONTINUE");

            while (true)
            {
                ConsoleKeyInfo key = new ConsoleKeyInfo();

                if (Console.KeyAvailable == true)
                {
                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }

                }
            }
        }
    }
}
