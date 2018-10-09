using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris 
{
    class UI : Instruments
    {
        public void ShowPlayerStatus(Player player)
        {
            Text(1, 1, "Score:" + player.score.ToString());
            Text(1, 2, "Lines:" + player.lines.ToString());
        }
    }
}
