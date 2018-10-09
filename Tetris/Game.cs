using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Game : Instruments
    {
        List<Dot> hitZone = new List<Dot>();
        bool ifLose = false;
        bool alreadyLose = false;
        public Game()
        {
            for(int i = 25; i<= 34; i++)
                for(int j = 10; j<=11; j++)
                {
                    Dot dot = new Dot(i, j, ' ');
                    hitZone.Add(dot);
                }
        }

        public Blocks RandomBlock()
        {
            Array values = Enum.GetValues(typeof(Block));
            Random random = new Random();
            Block randomBlock = (Block)values.GetValue(random.Next(values.Length));
            Blocks b;

            switch (randomBlock)
            {
                case Block.BIGS:
                    b = new BigS();
                    break;
                case Block.LCORNER:
                    b = new LCorner();
                    break;
                case Block.LINE:
                    b = new Line();
                    break;
                case Block.RCORNER:
                    b = new RCorner();
                    break;
                case Block.T:
                    b = new T();
                    break;
                case Block.Z:
                    b = new Z();
                    break;
                default:
                    b = new OppositeZ();
                    break;

            }

            return b;
        }

        public bool IfLose (Platform platform)
        {

            foreach (Dot d in platform.platform)
            {
                foreach (Dot hitZoneDot in hitZone)
                {
                    if (d.x == hitZoneDot.x && d.y == hitZoneDot.y)
                        ifLose = true;
                }
            }

            return ifLose;
        }

        public void Lose(Player player)
        {
            if (!alreadyLose)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Horizontal(10, 2, 40, '=');
                Horizontal(10, 3, 40, '=');
                Horizontal(10, 47, 40, '=');
                Horizontal(10, 48, 40, '=');
                
                
                Text(26, 13, "YOU LOSE");
                Text(23, 20, "Your Score: " + player.score.ToString());
                Text(18, 40, "Press Enter to Play Again");

                if (player.IfHighScore())
                    Text(14, 25, "Congratulations New Highscore!!!");
                alreadyLose = true;
            }
        }

        public void PlayAgain(ConsoleKey key,World world , Platform platform , Player player)
        {
            if (key == ConsoleKey.Enter)
            {
                Console.Clear();
                world.Start();
                platform.emptyPlatform();
                player.score = 0;
                ifLose = false;
                alreadyLose = false;
            }
        }
    }
}
