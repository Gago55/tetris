using System;
using System.Collections.Generic;

namespace Tetris
{
    class Instruments
    {
        public void Horizontal(int x, int y, int count, char sym)
        {
            for (int i = 0; i < count; i++)
            {
                Dot d = new Dot(x + i, y, sym);
                d.Draw();
            }
        }

        public void Vertical(int x, int y, int count, char sym)
        {
            for (int i = 0; i < count; i++)
            {
                Dot d = new Dot(x, y + i, sym);
                d.Draw();
            }
        }

        public List<Dot> HorizontalReturn(int x, int y, int count, char sym)
        {
            
            List<Dot> dots = new List<Dot>();

            for (int i = 0; i < count; i++)
            {
                Dot d = new Dot(x + i, y, sym);
                d.Draw();
                dots.Add(d);
            }
            return dots;
        }

        public List<Dot> VerticalReturn(int x, int y, int count, char sym)
        {
            List<Dot> dots = new List<Dot>();

            for (int i = 0; i < count; i++)
            {
                Dot d = new Dot(x, y + i, sym);
                d.Draw();
                dots.Add(d);
            }
            return dots;
        }

        public void Dot(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public void Text(int x, int y, string text)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
    }
}
