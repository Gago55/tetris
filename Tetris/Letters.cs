using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Letters : Instruments
    {
        int lastX;
        int space = 3; 

        public Letters(int x, int y, char sym)
        {
            T(x, y, sym);
            E(lastX + space, y, sym);
            T(lastX + space, y, sym);
            R(lastX + space, y, sym);
            I(lastX + space + 1, y, sym);
            S(lastX + space, y, sym);

        }
        public void T(int x , int y , char sym)
        {
            int countX = 7;
            int countY = 4;
                
            Horizontal(x, y, countX , sym);
            lastX = x + countX - 1; 
            Vertical(x + 3, y + 1, countY , sym);

        }

        public void E(int x, int y, char sym)
        {
            int countX = 6;
            int countY = 5;

            Horizontal(x, y, countX, sym);
            lastX = x + countX - 1;
            Horizontal(x, y+2 , countX, sym);
            Horizontal(x, y+4 , countX, sym);
            Vertical(x, y, countY, sym);

        }

        public void R(int x, int y, char sym)
        {
            int countX = 5;
            int countY = 5;

            Vertical(x, y, countY, sym);
            Horizontal(x, y, countX , sym);
            Horizontal(x, y+2, countX, sym);
            Dot(x + countX  , y + 1, sym);
            Dot(x + 4, y + 3, sym);
            Dot(x + 5, y + 4, sym);

            lastX = x + countX - 1; 
        }

        public void I(int x, int y, char sym)
        {
            int countX = 5;
            int countY = 3;

            Horizontal(x, y, countX, sym);
            Vertical(x+2, y+1, countY, sym);
            Horizontal(x, y + 4, countX, sym);

            lastX = x + countX - 1;
        }

        public void S(int x, int y, char sym)
        {
            int countX = 7;

            Horizontal(x + 1 , y, countX - 2, sym);
            Horizontal(x + 1, y+2, countX - 2, sym);
            Horizontal(x + 1, y+4, countX - 2, sym);
            Dot(x , y + 1, sym);
            Dot(x + countX -1 , y + 3, sym);
            
        }
        
    }
}
