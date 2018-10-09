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
        public bool moveable = true;
   //     public bool rotatable;
      //  public int rotatationCount;
        public int actualRotatationNumber = 1;
        public int gravityTime = 0;
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

        public void Gravity(List<Square> squares , World world , Platform platform)
        {
            Clear(squares);
            foreach (Square s in squares)
            {
                s.ChangePos(Direction.DOWN);
            }

            if (!IsHit(squares, world.walls[0]) && !IsHit(squares, platform.platform))
                Draw(squares);
            else
            {
                foreach (Square s in squares)
                {
                    s.PosUp();
                }
                Draw(squares);
                platform.AddToPlatform(squares);
                moveable = false;
            }
        }

        public void Clear(List<Square> squares)
        {
            foreach (Square s in squares)
            {
                s.Clear();
            }
        }

        public void Move(List<Square> squares, ConsoleKey key, World world , Platform platform , Player player)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                Clear(squares);
                foreach (Square s in squares)
                {
                    s.ChangePos(Direction.LEFT);
                }

                if (!IsHit(squares, world.walls[1]) && !IsHit(squares, platform.platform))
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

                if (!IsHit(squares, world.walls[2]) && !IsHit(squares, platform.platform))
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

                if (!IsHit(squares, world.walls[0]) && !IsHit(squares, platform.platform))
                    Draw(squares);
                else
                {
                    foreach (Square s in squares)
                    {
                        s.PosUp();
                    }
                    Draw(squares);
                    platform.AddToPlatform(squares);
                    moveable = false;
                }

                player.AddScore(1);
            }
            else if (key == ConsoleKey.UpArrow)
                Rotate(ref actualRotatationNumber, world, platform);
            else if (key == ConsoleKey.Spacebar)
                SpaceTrick(world , platform , player);
        }

        private void SpaceTrick(World world , Platform platform , Player player)
        {
            Clear(squares);
            foreach (Square s in squares)
            {
                s.ChangePos(Direction.DOWN);
            }

            if (!IsHit(squares, world.walls[0]) && !IsHit(squares, platform.platform))
            {
                player.AddScore(2);
                SpaceTrick(world, platform, player);
            }
            else
            {
                foreach (Square s in squares)
                {
                    s.PosUp();
                }
                Draw(squares);
                platform.AddToPlatform(squares);
                moveable = false;
            }
        }

        public void AddGravityTime()
        {
            if (gravityTime < 3)
                gravityTime++;
            else
                gravityTime = 0;
        }

        public bool IsHit(List<Square> squares, List<Dot> wall)
        {

            List<Dot> dots;
            dots = DotList(squares);
            
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

        public List<Dot> DotList(List<Square> squares)
        {
            List<Dot> downers = new List<Dot>();            

            foreach (Square s in squares)
                foreach (Dot d in s.dots)
                     downers.Add(d);   
            return downers;
        }

        

        public virtual void Create()
        {

        }

        public virtual void Rotate(ref int actual , World world, Platform platform)
        {

        }

        

    }
}
