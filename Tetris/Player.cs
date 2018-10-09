using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Player
    {
        public int speed = 1;
        public int score = 0;
        public int lines = 0;

        public void AddScore(int deltaScore)
        {
            score += deltaScore;
        }

        public void LinesControls(int count)
        {
            lines += count;

            if (count == 1)
                AddScore(100);
            else if (count == 2)
                AddScore(300);
            else if (count == 3)
                AddScore(500);
            else if (count == 4)
                AddScore(800);

        }
    }
}
