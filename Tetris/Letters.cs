
namespace Tetris
{
    class Letters : Instruments
    {
        int lastX;
        int space = 3; 

        public void Tetris(int x, int y, char sym)
        {
            T(x, y, sym);
            E(lastX + space, y, sym);
            T(lastX + space, y, sym);
            R(lastX + space, y, sym);
            I(lastX + space + 1, y, sym);
            S(lastX + space, y, sym);

        }

        private void T(int x , int y , char sym)
        {
            int countX = 7;
            int countY = 4;
                
            Horizontal(x, y, countX , sym);
            lastX = x + countX - 1; 
            Vertical(x + 3, y + 1, countY , sym);

        }
        private void L(int x, int y, char sym)
        {
            int countX = 7;
            int countY = 4;

            Horizontal(x+2, y + countY, countX-2, sym);
            lastX = x + countX - 1;
            Vertical(x+2, y , countY + 1 , sym);

        }
        private void Y(int x, int y, char sym)
        {
            int countX = 7;
            int countY = 3;

            Dot(x+2,y+2,sym);
            Dot(x+4,y+2,sym);
            Dot(x,y,sym);
            Dot(x+countX -1, y, sym);
            Dot(x + countX- 2, y + 1, sym);
            Dot(x+1,y+1,sym);
            lastX = x + countX - 1;
            Vertical(x + 3, y + 3, countY - 1, sym);

        }
        private void O(int x, int y, char sym)
        {
            int countX = 7;
            int countY = 4;

            Horizontal(x+1, y, countX-2, sym);
            Horizontal(x+1, y+4, countX-2, sym);
            lastX = x + countX - 1;
            Vertical(x + 0, y + 1, countY-1, sym);
            Vertical(x + 6, y + 1, countY-1, sym);

        }
        private void U(int x, int y, char sym)
        {
            int countX = 7;
            int countY = 4;

            
            Horizontal(x + 1, y + 4, countX - 2, sym);
            lastX = x + countX - 1;
            Vertical(x + 0, y , countY , sym);
            Vertical(x + 6, y , countY , sym);

        }
        private void E(int x, int y, char sym)
        {
            int countX = 6;
            int countY = 5;

            Horizontal(x, y, countX, sym);
            lastX = x + countX - 1;
            Horizontal(x, y+2 , countX, sym);
            Horizontal(x, y+4 , countX, sym);
            Vertical(x, y, countY, sym);

        }
        private void R(int x, int y, char sym)
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
        private void I(int x, int y, char sym)
        {
            int countX = 5;
            int countY = 3;

            Horizontal(x, y, countX, sym);
            Vertical(x+2, y+1, countY, sym);
            Horizontal(x, y + 4, countX, sym);

            lastX = x + countX - 1;
        }
        private void S(int x, int y, char sym)
        {
            int countX = 7;

            Horizontal(x + 1 , y, countX - 2, sym);
            Horizontal(x + 1, y+2, countX - 2, sym);
            Horizontal(x + 1, y+4, countX - 2, sym);
            Dot(x , y + 1, sym);
            Dot(x + countX -1 , y + 3, sym);
            lastX = x + countX - 1;
        }
        
        public void You(int x, int y, char sym)
        {
             lastX=0;
            Y(x, y, sym);
            O(lastX + space, y, sym);
            U(lastX + space, y, sym);
            
        }

        public void Lose(int x, int y, char sym)
        {
            lastX = 0;
            L(x, y, sym);
            O(lastX + space, y, sym);
            S(lastX + space, y, sym);
            E(lastX + space, y, sym);
        }

    }
}
