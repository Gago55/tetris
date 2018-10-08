using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class T : Blocks
    {
        int x = 29;
        bool recursion = false;

        public override void Create()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            squares = new List<Square>();

            Square s2 = new Square(x , y, sym);
            Square s1 = new Square(x , y + 2 , sym);
            Square s3 = new Square(x - 2 , y + 2, sym);
            Square s4 = new Square(x + 2, y + 2, sym);

            squares.Add(s1);
            squares.Add(s3);
            squares.Add(s2);
            squares.Add(s4);

            Draw(squares);
           
            created = true;
            
        }

        public override void Rotate(ref int actual , World world, Platform platform)
        {
            if (actual == 1)
            {
                int x;
                int y;

                x = squares[0].dots[0].x;
                y = squares[0].dots[0].y;

                if (!recursion)
                    Clear(squares);
                squares.Clear();

                Square s1 = new Square(x, y, sym);
                Square s2 = new Square(x, y + 2, sym);
                Square s3 = new Square(x, y - 2, sym);
                Square s4 = new Square(x + 2, y, sym);

                squares.Add(s1);
                squares.Add(s3);
                squares.Add(s2);
                squares.Add(s4);

                
                actual++;
            }
            else if (actual == 2)
            {
                int x;
                int y;

                x = squares[0].dots[0].x;
                y = squares[0].dots[0].y;

                if(!recursion)
                Clear(squares);
                squares.Clear();

                Square s1 = new Square(x, y, sym);
                Square s2 = new Square(x, y + 2, sym);
                Square s3 = new Square(x - 2, y, sym);
                Square s4 = new Square(x + 2, y, sym);

                squares.Add(s1);
                squares.Add(s3);
                squares.Add(s2);
                squares.Add(s4);
                

                actual++;
            }
            else if (actual == 3)
            {
                int x;
                int y;

                x = squares[0].dots[0].x;
                y = squares[0].dots[0].y;

                if (!recursion)
                    Clear(squares);
                squares.Clear();
                
                Square s1 = new Square(x, y, sym);
                Square s2 = new Square(x, y + 2, sym);
                Square s3 = new Square(x - 2, y, sym);
                Square s4 = new Square(x, y - 2, sym);

                squares.Add(s1);
                squares.Add(s3);
                squares.Add(s2);
                squares.Add(s4);

                actual++;
            }
            else if(actual == 4)
            {
                int x;
                int y;

                x = squares[0].dots[0].x;
                y = squares[0].dots[0].y;

                if (!recursion)
                    Clear(squares);
                squares.Clear();

                Square s1 = new Square(x, y, sym);
                Square s2 = new Square(x, y - 2, sym);
                Square s3 = new Square(x - 2, y, sym);
                Square s4 = new Square(x + 2, y , sym);

                squares.Add(s1);
                squares.Add(s3);
                squares.Add(s2);
                squares.Add(s4);

                actual = 1;
            }

            if (IsHit(squares, world.wallsDots()) || IsHit(squares, platform.platform))
            {
                if (actual == 2)
                    actual = 4;
                else
                    actual = actual - 2;
                recursion = true;
                Rotate(ref actual, world, platform);
            }
            else
            {
                recursion = false;
                Draw(squares);
            }
        }
    }
}
