using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WhackUrMoleLib
{
    public class Sprite
    {
        public Bitmap image;
        public int x;
        public int y;
        public int ttl;
        public int priority;
        public long createdAt;
        public Game game;

        public Sprite(Bitmap image, int x, int y, int ttl, Game game, int priority = 1)
        {
            this.image = image;
            this.x = x;
            this.y = y;
            this.ttl = ttl;
            this.game = game;
            this.priority = priority;
            createdAt = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public virtual void OnClick() { }
    }
}
