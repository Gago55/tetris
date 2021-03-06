﻿using System;
using System.Collections.Generic;

namespace Tetris
{
    class BigS : Blocks
    {
        public int x = 29;

        public override void Create()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            squares = new List<Square>();

            Square s1 = new Square(x, y, sym);
            Square s2 = new Square(x + 2, y, sym);
            Square s3 = new Square(x, y + 2, sym);
            Square s4 = new Square(x + 2, y + 2, sym);

            squares.Add(s1);
            squares.Add(s3);
            squares.Add(s2);
            squares.Add(s4);

            Draw(squares);

            created = true;

        }

        public override void Rotate(ref int actual, World world, Platform platform)
        {
            //:D
        }
    }
}
