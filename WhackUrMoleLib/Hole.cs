using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WhackUrMoleLib
{
    public class Hole : Sprite
    {
        public Hole(int x, int y, int ttl, Game game, int priority = 1) : base(Properties.Resources.hole, x, y, ttl, game, priority)
        {
        }

        public override void OnClick()
        {
            // this will ALWAYS be clicked
            // I can't capture clicks on other sprites without holes being clicked
            // so there will be adjastment +5 on all non-hole sprites
            if(!game.stared)
            {
                game.score -= 5;
            }
        }
    }
}
