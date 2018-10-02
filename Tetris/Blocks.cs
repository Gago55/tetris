using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{

    class Blocks
    {
        public char sym = '■'; // 254 219
        public int y = 10;
        public bool created = false;

        //protected List<Dot> dots;
        public List<Square> squares;

        public void Draw(List<Dot> dots)
        {
            foreach (Dot d in dots)
            {
                d.Draw();
            }
        }

        public void Draw(List<Square> squares)
        {
            foreach (Square s in squares)
            {
                s.Draw();
            }
        }

        public void Gravity(List<Square> squares , World world)
        {
            Clear(squares);
            foreach (Square s in squares)
            {
                s.ChangePos(Direction.DOWN);
            }

            if (!IsHit(squares, Direction.DOWN, world.walls[0]))
                Draw(squares);
            else
            {
                foreach (Square s in squares)
                {
                    s.PosUp();
                }
                Draw(squares);
            }
        }

        public void Clear(List<Square> squares)
        {
            foreach (Square s in squares)
            {
                s.Clear();
            }
        }

        public void Move(List<Square> squares, ConsoleKey key, World world)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                Clear(squares);
                foreach (Square s in squares)
                {
                    s.ChangePos(Direction.LEFT);
                }

                if (!IsHit(squares, Direction.LEFT, world.walls[1]))
                    Draw(squares);
                else
                {
                    foreach (Square s in squares)
                    {
                        s.ChangePos(Direction.RIGTH);
                    }
                    Draw(squares);
                }

            }
            else if (key == ConsoleKey.RightArrow)
            {
                Clear(squares);
                foreach (Square s in squares)
                {
                    s.ChangePos(Direction.RIGTH);
                }

                if (!IsHit(squares, Direction.RIGTH, world.walls[2]))
                    Draw(squares);
                else
                {
                    foreach (Square s in squares)
                    {
                        s.ChangePos(Direction.LEFT);
                    }
                    Draw(squares);
                }
            }
            else if (key == ConsoleKey.DownArrow)
            {
                Clear(squares);
                foreach (Square s in squares)
                {
                    s.ChangePos(Direction.DOWN);
                }

                if (!IsHit(squares, Direction.DOWN, world.walls[0]))
                    Draw(squares);
                else
                {
                    foreach (Square s in squares)
                    {
                        s.PosUp();
                    }
                    Draw(squares);
                }
            }
        }

        public bool IsHit(List<Square> squares, Direction dir, List<Dot> wall)
        {

            List<Dot> dots;
            if (dir == Direction.LEFT)
                dots = Lefter(squares);
            else if (dir == Direction.RIGTH)
                dots = Righter(squares);
            else
                dots = Downer(squares);

            foreach (Dot d in dots)
            {
                foreach (Dot _d in wall)
                {
                    if (d.IsHit(_d))
                        return true;
                }
            }
            return false;

        }

        public List<Dot> Downer(List<Square> squares)
        {
            int maxY = 0;
            List<Dot> downers = new List<Dot>();

            foreach (Square s in squares)
            {
                foreach (Dot d in s.dots)
                {
                    if (d.y > maxY)
                        maxY = d.y;
                }
            }

            foreach (Square s in squares)
            {
                foreach (Dot d in s.dots)
                {
                    if (d.y == maxY)
                        downers.Add(d);
                }
            }

            return downers;
        }
        public List<Dot> Lefter(List<Square> squares)
        {
            int minX = 500;
            List<Dot> downers = new List<Dot>();

            foreach (Square s in squares)
            {
                foreach (Dot d in s.dots)
                {
                    if (d.x < minX)
                        minX = d.x;
                }
            }

            foreach (Square s in squares)
            {
                foreach (Dot d in s.dots)
                {
                    if (d.x == minX
)
                        downers.Add(d);
                }
            }

            return downers;
        }
        public List<Dot> Righter(List<Square> squares)
        {
            int maxX = 0;
            List<Dot> downers = new List<Dot>();

            foreach (Square s in squares)
            {
                foreach (Dot d in s.dots)
                {
                    if (d.x > maxX)
                        maxX = d.x;
                }
            }

            foreach (Square s in squares)
            {
                foreach (Dot d in s.dots)
                {
                    if (d.x == maxX)
                        downers.Add(d);
                }
            }

            return downers;
        }

        public virtual void Create()
        {

        }
        

        
        
    }
}
