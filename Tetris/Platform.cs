using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Platform
    {
        List<Dot> platform;

        public void AddToPlatform(List<Square> squares)
        {
            foreach(Square square in squares)
            {
                foreach(Dot dot in square.dots)
                {
                    platform.Add(dot);
                }
            }
        }
    }
}
