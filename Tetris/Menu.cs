using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Menu : Instruments
    {
        bool started = false;
        public Menu(Player player)
        {
            

            Console.ForegroundColor = ConsoleColor.Yellow;
            Horizontal(10, 2, 40, '=');
            Horizontal(10, 3, 40, '=');
           

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            Letters tetris = new Letters();
            tetris.Tetris(6, 15, 'O');

            Horizontal(10, 47, 40, '=');
            Horizontal(10, 48, 40, '=');

            Text(20, 25 , "Press Enter to Start");

            if(!(player.higescore == "0"))
            {
                Text(20, 45, "Your Highscore: " + player.higescore);
            }

        }

        public void Start(ConsoleKey key , World world )
        {
            if (key == ConsoleKey.Enter  && !started)
            {
                Console.Clear();
                world.Start();
                started = true; 
            }
            
        }

        public bool IfStarted()
        {
            if (started)
                return true;
            else
                return false;
        }
        
    }
}
