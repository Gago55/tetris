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

                    if(menu.IfStarted() && !game.IfLose(platform))
                    {
                        if(actualBlock.moveable && actualBlock.created)
                            actualBlock.Move(actualBlock.squares, key.Key, world , platform);
                    }

                    if (game.IfLose(platform))
                        game.PlayAgain(key.Key, world, platform);

                }
                admin.ConsolePosShow(Console.CursorLeft , Console.CursorTop);
                if (menu.IfStarted() && !game.IfLose(platform))
                { 
                    platform.FullPlatform();
                    if (!actualBlock.created)
                        actualBlock.Create();
                }

                if (menu.IfStarted() && actualBlock.moveable && actualBlock.created && !game.IfLose(platform))
                    actualBlock.Gravity(actualBlock.squares , world , platform);
               

                if (!actualBlock.moveable && !game.IfLose(platform))
                    actualBlock = game.RandomBlock();

                if (game.IfLose(platform))
                    game.Lose();

                Thread.Sleep(100);
            }

            

            
        }
    }
}
