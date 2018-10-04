using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Dot
    {
        public int x;
        public int y;
        char sym;

        public Dot(int _x , int _y , char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public void ChangePos(Direction dir)
        {
            switch (dir)
            {
                case Direction.LEFT:
                    x = x - 2;
                    break;
                case Direction.RIGTH:
                    x = x + 2;
                    break;
                case Direction.DOWN:
                    y = y + 1;
                    break;
            }
        }

        public void Clear()
        {
            char c;
            c = sym;
            sym = ' ';
            Draw();
            sym = c;
        }

        public void PosUp()
        {
            y = y - 1;
        }

        public bool IsHit(Dot d)
        {
            if (x == d.x && y == d.y)
                return true;
            else
                return false;
        }
    }
}
