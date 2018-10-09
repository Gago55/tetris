using System;

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
