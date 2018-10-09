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
            Player player = new Player();
            UI ui = new UI();

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
                            actualBlock.Move(actualBlock.squares, key.Key, world , platform , player);
                    }

                    if (game.IfLose(platform))
                        game.PlayAgain(key.Key, world, platform , player);

                }
                admin.ConsolePosShow(Console.CursorLeft , Console.CursorTop);
                if (menu.IfStarted() && !game.IfLose(platform))
                {
                    player.ChangePlayerLevel();
                    ui.ShowPlayerStatus(player);
                    platform.FullPlatform(player);
                    if (!actualBlock.created)
                        actualBlock.Create();
                }

                if (menu.IfStarted() && actualBlock.moveable && actualBlock.created && !game.IfLose(platform))
                    if(actualBlock.gravityTime == 3)
                    actualBlock.Gravity(actualBlock.squares , world , platform);
               

                if (!actualBlock.moveable && !game.IfLose(platform))
                    actualBlock = game.RandomBlock();

                if (game.IfLose(platform))
                    game.Lose(player);

                actualBlock.AddGravityTime();
                Thread.Sleep(150/player.speed);
            }

            

            
        }
    }
}
