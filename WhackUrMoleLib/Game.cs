using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WhackUrMoleLib
{
    public class Game
    {
        
        public Random r;
        public Renderer renderer;
        public Timer t;
        // random entity generator in difficulty
        public Difficulty difficulty;
        public List<Sprite> sprites;
        
        // timer variables
        public long lastSpawn = 0;
        public int interval = 0;
        public long startedAt = 0;
       
        public int score = 0;
        
        // outputs
        Label scoreLabel;
        Label timerLabel;

        // is effected by star
        public bool stared = false;
        public long staredAt = 0;
        public int timeStared = 10000;

        public long timeElapsed
        {
            get => DateTimeOffset.Now.ToUnixTimeMilliseconds() - startedAt;
        }

        public Game(Control canvasElement, Difficulty df, Label scoreLbl, Label timerLbl)
        {
            scoreLabel = scoreLbl;
            timerLabel = timerLbl;
            r = new Random((int)DateTimeOffset.Now.ToUnixTimeMilliseconds());
            renderer = new Renderer(canvasElement);
            difficulty = df;
            sprites = new List<Sprite>();
            t = new Timer();
            t.Interval = 50;
            t.Tick += OnTick;
        }

        public void OnTick(object sender, EventArgs e)
        {
            scoreLabel.Text = $"{score}";
            var now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            timerLabel.Text = $"{(difficulty.totalTime - (now - startedAt))/1000}";

            // when time runs out
            if (now - startedAt > difficulty.totalTime && startedAt != 0)
            {
                End();
                return;
            }
            
            // when the set amount of time passed spawn a sprite
            if (now - lastSpawn > interval || lastSpawn == 0)
            {
                sprites.Add(difficulty.GetItem(this));
                interval = r.Next(difficulty.minSpawnDelay, difficulty.maxSpawnDelay + 1);
                lastSpawn = now;
            }

            // for when the effect of star should end
            if(stared && now - staredAt > timeStared)
            {
                stared = false;
            }
            
            //foreach (var sprite in sprites)
            for(int i = 0; i < sprites.Count-1; i++)
            {
                if (sprites[i].ttl != 0 && now - sprites[i].createdAt > sprites[i].ttl )
                {
                    RemoveSprite(sprites[i]);
                }
            }
            
        }

        public void AddSprite(Sprite sprite)
        {
            this.sprites.Add(sprite);
            this.renderer.Update(this.sprites.ToArray());
        }
        
        public void RemoveSprite(Sprite sprite)
        {
            this.sprites.Remove(sprite);
            this.renderer.Update(this.sprites.ToArray());
        }

        public void SpawnAnotherEnemy()
        {
            sprites.Add(difficulty.GetItem(this));
            interval = r.Next(difficulty.minSpawnDelay, difficulty.maxSpawnDelay + 1);
            var now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            lastSpawn = now;
        }

        public void initTheHoles() {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.AddSprite(new Hole(j, i, 6000000, this));
                }
            }
        }

        public void Start()
        {
            startedAt = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            t.Start();
        }

        public void End()
        {
            t.Stop();
        }
    }
}
