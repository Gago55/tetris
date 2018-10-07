using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Menu : Instruments
    {
        bool started = false;
        public Menu()
        {
            

            Console.ForegroundColor = ConsoleColor.Yellow;
            Horizontal(10, 2, 40, '=');
            Horizontal(10, 3, 40, '=');
           

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            Letters tetris = new Letters(6, 15, 'O');

            Horizontal(10, 47, 40, '=');
            Horizontal(10, 48, 40, '=');

            Text(20, 25 , "Press Enter to Start");

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
