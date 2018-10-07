using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Platform
    {
        public List<Dot> platform = new List<Dot>();

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

        public void FullPlatform()
        {
            List<int> fullY = new List<int>();
            for (int i = 39; i >10; i-=2)
            {
                int count = 0;
                foreach (Dot d in platform)
                {
                    if (d.y == i)
                        count++;
                }

                if (count == 30)
                {
                    fullY.Add(i);
                }
            }


            if (fullY.Count == 1)
            {
                int y = fullY[0];
                List<Dot> Removeable = new List<Dot>();
                List<Dot> Moveable = new List<Dot>();
                foreach (Dot dot in platform)
                {
                    if (dot.y == y || dot.y==y-1)
                    {
                        dot.Clear();
                        Removeable.Add(dot);
                    }
                }
                Remove(Removeable);

                foreach (Dot dot in platform)
                {
                    if (dot.y < y-1)
                    {
                        dot.Clear();
                        Moveable.Add(dot);
                    }
                }
                MoveDown(Moveable, 2);
                
                foreach(Dot d in Moveable)
                {
                    d.Draw();
                }
            }
            

            
        }

        private void MoveDown(List<Dot> moveable, int a)
        {
            foreach (Dot d in moveable)
                d.y += a;
        }

        private void Remove(List<Dot> removeable)
        {
            foreach (Dot d in removeable)
                platform.Remove(d);
        }
    }
}
