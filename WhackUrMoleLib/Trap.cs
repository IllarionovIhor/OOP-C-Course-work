using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WhackUrMoleLib
{
    public class Trap : Sprite
    {
        public Trap(int x, int y, int ttl, Game game, int priority = 2) : base(Properties.Resources.BearTrap, x, y, ttl, game, priority)
        {
        }

        public override void OnClick()
        {
            game.score += 5;
            game.difficulty.totalTime -= 5000;
            game.RemoveSprite(this);
        }
    }
}
