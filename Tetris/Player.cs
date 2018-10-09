using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Player
    {
        public int speed = 1;
        public int score = 0;

        public void AddScore(int deltaScore)
        {
            score += deltaScore;
        }

    }
}
