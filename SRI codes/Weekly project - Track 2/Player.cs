using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject
{
    internal class Player
    {
        public string name;
        private int score;
        public string recentUserName;
        public static int usercount = 0;
        public Player(string argName)
        {
            this.name = argName;
            this.score = 0;
            this.recentUserName = argName;
            usercount++;
        }

        public void SetScore(int more)
        {
            this.score += more;
        }

        public int GetScore()
        {
            return this.score;
        }
    }
}
