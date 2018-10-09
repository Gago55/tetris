using System;
using System.IO;

namespace Tetris
{
    class Player
    {
        public int speed = 1;
        public int score = 0;
        public int lines = 0;
        public int level = 1;

        public string higescore;

        public Player()
        {
            ReadHighScores();
        }

        public void AddScore(int deltaScore)
        {
            score += deltaScore*level;
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
        
        public void ChangePlayerLevel()
        {
            if (score >= 1000 && score < 2000)
            {
                level = 2;
                speed = 2;
            }
            else if (score >= 2000 && score < 3500)
            {
                level = 3;
                speed = 3;
            }
            else if (score >= 3500 && score < 5000)
            {
                level = 4;
                speed = 4;
            }
            else if (score >= 5000 && score < 8000)
            {
                level = 5;
                speed = 5;
            }
            else if (score >= 8000 && score < 15000)
            {
                level = 6;
                speed = 6;
            }
            else if (score >= 15000 && score < 20000)
            {
                level = 7;
                speed = 7;
            }
        }

        public void ReadHighScores()
        {
            StreamReader sr = new StreamReader(@"..\..\..\..\HighScores.txt");

            higescore = sr.ReadLine();

            sr.Close();
        }

        public void WriteHighScores()
        {

            StreamWriter sw = new StreamWriter(@"..\..\..\..\HighScores.txt");

            sw.WriteLine(higescore);

            sw.Close();
        }
        
        public bool IfHighScore()
        {

            if (score > Convert.ToInt32(higescore))
            {
                higescore = score.ToString();
                WriteHighScores();
                return true;
            }
            else
                return false;
   
        }
    }
}
