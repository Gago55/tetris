using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Window
    {
        public Window(int width, int height)
        {
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            Console.CursorVisible = false;
        }
    }
}
