using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris 
{
    class UI : Instruments
    {
        public void ShowScore(Player player)
        {
            Text(1, 1, "Score:" + player.score.ToString());
        }
    }
}
