using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhackUrMoleLib
{
    public class User
    {
        public string score;
        public string difficulty;
        public string username;


        public User(string username, string score, string difficulty)
        {
            this.score = score;
            this.difficulty = difficulty;
            this.username = username;
        }

        public override string ToString()
        {
            return String.Concat(username, ",", score, ",", difficulty, "|");
        }
    }
}
