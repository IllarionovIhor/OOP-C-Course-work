using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WhackUrMoleLib
{
    public class Star : Sprite
    {
        public Star(int x, int y, int ttl, Game game, int priority = 2) : base(Properties.Resources.star, x, y, ttl, game, priority)
        {
        }

        public override void OnClick()
        {
            // adjusts the holes' -5
            game.score += 5;
            game.stared = true;
            var now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            game.staredAt = now;
            game.RemoveSprite(this);
        }
    }
}
