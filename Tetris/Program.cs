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
            World world = new World();
            Platform platform = new Platform();
            Game game = new Game();

            Blocks actualBlock = game.RandomBlock();

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

                        if(actualBlock.moveable && actualBlock.created)
                            actualBlock.Move(actualBlock.squares, key.Key, world , platform);
                    }
                        
                }
                admin.ConsolePosShow(Console.CursorLeft , Console.CursorTop);
                if (menu.IfStarted())
                {
                    platform.FullPlatform();
                    if (!actualBlock.created)
                        actualBlock.Create();
                }

                if (menu.IfStarted() && actualBlock.moveable && actualBlock.created)
                    actualBlock.Gravity(actualBlock.squares , world , platform);
               

                if (!actualBlock.moveable)
                    actualBlock = game.RandomBlock();

                Thread.Sleep(100);
            }

            

            
        }
    }
}
