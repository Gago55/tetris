using System;

namespace Tetris
{
    class Admin : Instruments
    {
        bool ConsoleMode = false;

        public void ConsolePos(ConsoleKey key)
        {
            if (key == ConsoleKey.Escape)
            {
                if (ConsoleMode)
                    ConsoleModeOff();
                else
                    ConsoleModeOn();
            }
        }

        private void ConsoleModeOn()
        {
            Console.CursorVisible = true;
            
            ConsoleMode = true;
        }

        internal void ConsolePosShow(int x , int y)
        {
            if (ConsoleMode)
            {
                Text(0, 1, "Y:" + y);
                Text(0, 0, "X:" + x);
  
            }
            else
            {
                Text(0, 0, "    ");
                Text(0, 1, "    ");
            }
            Console.SetCursorPosition(x, y);
        }

        internal void ConsoleChangePos(ConsoleKey key , int x, int y)
        {
            if (ConsoleMode)
            {
                if (key == ConsoleKey.LeftArrow)
                    Console.SetCursorPosition(x - 2, y);
                else if (key == ConsoleKey.RightArrow)
                    Console.SetCursorPosition(x, y);
                else if (key == ConsoleKey.UpArrow)
                    Console.SetCursorPosition(x - 1, y - 1);
                else if (key == ConsoleKey.DownArrow)
                    Console.SetCursorPosition(x - 1, y + 1);
            }
        }

        private void ConsoleModeOff()
        {
            Console.CursorVisible = false;
            ConsoleMode = false; 
        }

    }
}
