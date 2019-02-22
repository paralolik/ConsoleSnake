using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 100 если комп тупит, 300 если комп шустрый
            int speed = 100;
            int width = 100;
            int height = 34;//не больше 44

            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            MainMenu mainMenu = new MainMenu(width, height, speed);
            mainMenu.ShowMenu();
        }
    }
}
