using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris 
{
    class UI : Instruments
    {
        public void ShowPlayerStatus(Player player)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Text(1, 1, "Score:" + player.score.ToString());
            Text(1, 2, "Lines:" + player.lines.ToString());
            Text(1, 3, "Level:" + player.level.ToString());
            Console.ForegroundColor = color;
        }
    }
}
