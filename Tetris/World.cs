using System;
using System.Collections.Generic;

namespace Tetris
{
    class World : Instruments
    {
        public List<List<Dot>> walls = new List<List<Dot>>();
        public List<Dot> downWall;
        public List<Dot> leftWall;
        public List<Dot> rightWall;
        public List<Dot> upWall;
        public void Start()
        {
            

            Console.ForegroundColor = ConsoleColor.White;

            upWall = HorizontalReturn(15, 9 , 30, '═'); // alt + 205
            downWall = HorizontalReturn(15, 40, 30, '═'); // alt + 205
            leftWall = VerticalReturn(14, 10, 30, '║'); // alt + 186
            rightWall = VerticalReturn(45, 10, 30, '║'); // alt + 186
            Dot(14,40,'╚');//alt + 200
            Dot(45,40,'╝');//alt + 188
            Dot(14, 9, '╔');//alt + 201
            Dot(45, 9, '╗');//alt + 187

            walls.Add(downWall);
            walls.Add(leftWall);
            walls.Add(rightWall);

        }

        public List<Dot> wallsDots()
        {
            List<Dot> walls = new List<Dot>();

            foreach (Dot d in downWall)
                walls.Add(d);
            foreach (Dot d in leftWall)
                walls.Add(d);
            foreach (Dot d in rightWall)
                walls.Add(d);
            foreach (Dot d in upWall)
                walls.Add(d);

            return walls;
        }
            
    }
}
