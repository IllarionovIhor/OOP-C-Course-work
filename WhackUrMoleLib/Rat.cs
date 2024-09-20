using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WhackUrMoleLib
{
    public class Rat : Sprite
    {
        public Rat(int x, int y, int ttl, Game game, int priority = 2) : base(Properties.Resources.mole, x, y, ttl, game, priority)
        {
        }

        public override void OnClick()
        {
            game.SpawnAnotherEnemy();
            // gives +5 score, the hole logic does 10 - 5
            game.score += 10;
            game.RemoveSprite(this);
        }
    }
}
