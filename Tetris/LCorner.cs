using System;
using System.Collections.Generic;


namespace Tetris
{
    class LCorner : Blocks
    {
        int x = 27;
        bool recursion;

        public override void Create()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            squares = new List<Square>();

            Square s1 = new Square(x, y, sym);
            Square s2 = new Square(x, y + 2, sym);
            Square s3 = new Square(x + 2, y + 2, sym);
            Square s4 = new Square(x + 4, y + 2, sym);

            squares.Add(s1);
            squares.Add(s3);
            squares.Add(s2);
            squares.Add(s4);

            Draw(squares);

            created = true;
            
        }

        public override void Rotate(ref int actual, World world, Platform platform)
        {
            int x;
            int y;
            if (actual == 1)
            {

                x = squares[0].dots[0].x + 2;
                y = squares[0].dots[0].y;

                Rotation(ref actual, x, y);

            }
            else if (actual == 2)
            {
               
                x = squares[0].dots[0].x;
                y = squares[0].dots[0].y + 2;

                Rotation(ref actual, x, y);
            }
            else if (actual == 3)
            {
                

                x = squares[0].dots[0].x - 2;
                y = squares[0].dots[0].y;

                Rotation(ref actual, x, y);
            }
            else 
            {
               
                x = squares[0].dots[0].x - 2;
                y = squares[0].dots[0].y;

                Rotation(ref actual, x, y);
            }

            if (IsHit(squares, world.wallsDots()) || IsHit(squares, platform.platform))
            {
                if (actual == 1)
                    actual = 3;
                else if (actual == 2)
                    actual = 4;
                else
                    actual = actual - 2;
                recursion = true;
                Rotation(ref actual, x, y);
               
            }
            else
            {
                recursion = false;
                
            }

            Draw(squares);
        }

        public void Rotation(ref int actual, int x, int y)
        {
            if (actual == 1)
            {

                if (!recursion)
                    Clear(squares);
                squares.Clear();

                Square s1 = new Square(x, y - 2, sym);
                Square s2 = new Square(x - 2, y - 2, sym);
                Square s3 = new Square(x - 2, y, sym);
                Square s4 = new Square(x - 2, y + 2, sym);

                squares.Add(s1);
                squares.Add(s3);
                squares.Add(s2);
                squares.Add(s4);


                actual++;
            }
            else if (actual == 2)
            {

                if (!recursion)
                    Clear(squares);
                squares.Clear();

                Square s1 = new Square(x + 2, y, sym);
                Square s2 = new Square(x - 2, y - 2, sym);
                Square s3 = new Square(x, y - 2, sym);
                Square s4 = new Square(x + 2, y - 2, sym);

                squares.Add(s1);
                squares.Add(s3);
                squares.Add(s2);
                squares.Add(s4);

                actual++;
            }
            else if (actual == 3)
            {

                if (!recursion)
                    Clear(squares);
                squares.Clear();

                Square s1 = new Square(x + 2, y, sym);
                Square s2 = new Square(x + 2, y + 2, sym);
                Square s3 = new Square(x + 2, y - 2, sym);
                Square s4 = new Square(x, y + 2, sym);

                squares.Add(s1);
                squares.Add(s3);
                squares.Add(s2);
                squares.Add(s4);

                actual++;
            }
            else if (actual == 4)
            {

                if (!recursion)
                    Clear(squares);
                squares.Clear();

                Square s1 = new Square(x - 2, y, sym);
                Square s2 = new Square(x - 2, y + 2, sym);
                Square s3 = new Square(x, y + 2, sym);
                Square s4 = new Square(x + 2, y + 2, sym);

                squares.Add(s1);
                squares.Add(s3);
                squares.Add(s2);
                squares.Add(s4);

                actual = 1;
            }
            recursion = false;
        }

    }
}
