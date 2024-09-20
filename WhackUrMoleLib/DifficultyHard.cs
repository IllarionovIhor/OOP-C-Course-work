﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhackUrMoleLib
{
    public class DifficultyHard : Difficulty
    {
        public DifficultyHard() {
            name = "Важка";
            scoreModifier = 10;
            totalTime = 60 * 1000;
            totalTimeLiving = 750;
            minSpawnDelay = 500;
            maxSpawnDelay = 1000;
            int seed = (int)DateTimeOffset.Now.ToUnixTimeMilliseconds();
            r = new Random(seed);
        }

        public override Sprite GetItem(Game game)
        {
            var x = r.Next(0, 3);
            var y = r.Next(0, 3);
            var type = r.Next(1, 21);
            if (type <=2)
            {
                // STAR
                return new Star(x, y, totalTimeLiving, game);
            } else if (type <= 4)
            {
                // TIME
                return new TimeBonus(x, y, totalTimeLiving, game);
            } else if (type <= 8)
            {
                // TRAP
                return new Trap(x, y, totalTimeLiving, game);
            } else
            {
                return new Rat(x, y, totalTimeLiving, game);
            }
        }
    }
}