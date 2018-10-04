using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Game
    {
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
    }
}
