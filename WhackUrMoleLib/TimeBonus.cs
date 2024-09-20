using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WhackUrMoleLib
{
    public class TimeBonus : Sprite
    {
        public TimeBonus(int x, int y, int ttl, Game game, int priority = 2) : base(Properties.Resources.clock, x, y, ttl, game, priority)
        {
        }

        public override void OnClick()
        {
            // adjusts the holes' -5
            game.score += 5;
            game.difficulty.totalTime += 5000;
            game.RemoveSprite(this);
        }
    }
}
