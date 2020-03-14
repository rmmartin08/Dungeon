using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Animations
{
    public class Lightning
    {
        public static void LightningFlashes()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Thread.Sleep(100);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Thread.Sleep(100);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(100);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Thread.Sleep(100);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Thread.Sleep(100);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

        }
    }
}
