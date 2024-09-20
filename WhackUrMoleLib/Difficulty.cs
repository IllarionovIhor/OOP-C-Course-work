using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhackUrMoleLib
{
    public abstract class Difficulty
    {
        public string name;
        public int scoreModifier;
        public int totalTime;
        public int totalTimeLiving;
        public int minSpawnDelay;
        public int maxSpawnDelay;
        protected Random r;
        public abstract Sprite GetItem(Game game);
    }
}
