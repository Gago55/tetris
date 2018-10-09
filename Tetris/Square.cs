using System.Collections.Generic;

namespace Tetris
{
    class Square 
    {
        public List<Dot> dots = new List<Dot>();
        public Square(int x, int y, char sym)
        {
            
            Dot d1 = new Dot(x, y, sym);
            Dot d2 = new Dot(x+1, y, sym);
            Dot d3 = new Dot(x, y+1, sym);
            Dot d4 = new Dot(x+1, y+1, sym);

            dots.Add(d1);
            dots.Add(d2);
            dots.Add(d3);
            dots.Add(d4);
            
           // Draw(dots);
        }

        public void Draw ()
        {
            foreach(Dot d in dots)
            {
                d.Draw();
            }
        }

        public void ChangePos(Direction dir)
        {
            foreach (Dot d in dots)
            {
                d.ChangePos(dir);
            }
        }

        public void PosUp()
        {
            foreach (Dot d in dots)
            {
                d.PosUp();
            }
        }

        public void Clear()
        {
            foreach (Dot d in dots)
            {
                d.Clear();
            }
        }
        
        
    }
}
