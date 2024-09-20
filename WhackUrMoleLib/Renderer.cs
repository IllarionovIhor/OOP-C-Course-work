using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WhackUrMoleLib
{
    public class Renderer
    {
        public Graphics g;
        public Control element;
        public int[] gx = {10, 120, 230};
        public int[] gy = {10, 120, 230};
        public Sprite[] sprites = {};

        public Renderer(Control element)
        {
            this.element = element;
            this.g = element.CreateGraphics();
            this.element.Click += this.OnCanvasClick;
        }

        public void OnCanvasClick(Object sender, EventArgs args)
        {
            var e = (MouseEventArgs)args;
            foreach (var sprite in this.sprites)
            {
                var xInRange = gx[sprite.x] <= e.X && e.X <= gx[sprite.x] + sprite.image.Width;
                var yInRange = gy[sprite.y] <= e.Y && e.Y <= gy[sprite.y] + sprite.image.Height;
                if (xInRange && yInRange)
                {
                    sprite.OnClick();
                }
            }
        }

        public void Update(Sprite[] sprites)
        {
            this.sprites = sprites;
            Array.Sort(this.sprites, (s1, s2) => s1.priority.CompareTo(s2.priority));
            Render();
        }

        public void Render()
        {
            g.Clear(Color.White);
            foreach (var sprite in sprites)
            {
                var rect = new Rectangle(gx[sprite.x], gy[sprite.y], sprite.image.Width, sprite.image.Height);
                g.DrawImage(sprite.image, rect);
            }
        }
    }
}