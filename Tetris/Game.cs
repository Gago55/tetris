using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Game : Instruments
    {
        List<Dot> hitZone = new List<Dot>();
        bool ifLose = false;
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

        public void Lose()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Text(26, 13, "YOU LOSE");
            Text(18, 25, "Press Enter to Play Again");
        }

        public void PlayAgain(ConsoleKey key,World world , Platform platform)
        {
            if (key == ConsoleKey.Enter)
            {
                Console.Clear();
                world.Start();
                platform.emptyPlatform();
                ifLose = false;
            }
        }
    }
}
