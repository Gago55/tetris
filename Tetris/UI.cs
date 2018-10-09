using System;

namespace Tetris 
{
    class UI : Instruments
    {
        public void ShowPlayerStatus(Player player)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Text(26, 1, "Score:" + player.score.ToString());
            Text(4, 1, "Lines:" + player.lines.ToString());
            Text(50, 1, "Level:" + player.level.ToString());
            Console.ForegroundColor = color;
        }

        public void Instruction()
        {
            Text(2, 42, "Instruction");
            Text(2, 44, "Left Arrow - Move Left");
            Text(2, 45, "Right Arrow - Move Right");
            Text(2, 46, "Down Arrow - Move Down ");
            Text(2, 47, "Up Arrow - Rotate");
            Text(2, 48, "Spacebar - Drop Block ");
        }
    }
}
