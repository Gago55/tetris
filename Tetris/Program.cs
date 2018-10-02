using System;
using System.Collections.Generic;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window(60, 50);
            Menu menu = new Menu();
            Admin admin = new Admin();
            Blocks bigS = new BigS();
            World world = new World();
            Platform platform = new Platform();
            
            //List<Dot> d = bigS.Righter(bigS.squares);

            while (true)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    menu.Start(key.Key , world);
                    admin.ConsolePos(key.Key);
                    admin.ConsoleChangePos(key.Key , Console.CursorLeft , Console.CursorTop);

                    if(menu.IfStarted())
                    {
                        if(!bigS.created)
                        bigS.Create();

                        if(bigS.moveable)
                        bigS.Move(bigS.squares, key.Key, world , platform);
                    }
                        
                }
                admin.ConsolePosShow(Console.CursorLeft , Console.CursorTop);

                if (menu.IfStarted() && bigS.moveable)
                    bigS.Gravity(bigS.squares , world , platform);
                Thread.Sleep(300);
            }

            

            //Console.ReadLine();
        }
    }
}
