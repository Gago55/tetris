﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class OppositeZ : Blocks
    {
        int x = 28;

        public override void Create()
        {
            squares = new List<Square>();

            Square s1 = new Square(x, y + 2 , sym);
            Square s2 = new Square(x + 2, y + 2, sym);
            Square s3 = new Square(x + 2, y, sym);
            Square s4 = new Square(x + 4, y, sym);

            squares.Add(s1);
            squares.Add(s3);
            squares.Add(s2);
            squares.Add(s4);

            Draw(squares);

            created = true;
        }

    }
}