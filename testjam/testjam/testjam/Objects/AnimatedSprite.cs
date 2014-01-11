using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace testjam
{
    class AnimatedSprite
    {
        Texture2D spriteTexture;
        
        float timer = 0f;
        float interval = 40f;
        int currentFrame = 0;
        Rectangle sourceRect;
        int frameCount;
        Boolean repeat;
        public Vector2 position;
        public Vector2 origin;
        public Texture2D texture;

        public AnimatedSprite(Texture2D texture, int currentFrame, int frameCount, Boolean repeat)
        {
            this.spriteTexture = texture;
            this.currentFrame = currentFrame;
            this.frameCount = frameCount;
            this.repeat = repeat;
        }

        public void Animate(GameTime gameTime)
        {
            sourceRect = new Rectangle(currentFrame * (texture.Width / frameCount), 0, (texture.Width / frameCount), texture.Height);
            timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            if (timer > interval)
            {
                currentFrame++;
                if (repeat)
                {
                    if (currentFrame > frameCount)
                    {
                        currentFrame = 1;
                    }
                }
                else
                {
                    if (currentFrame > frameCount)
                    {
                        currentFrame = frameCount;
                    }
                }
                timer = 0f;
            }
            //origin = new Vector2(sourceRect.Width / 2, sourceRect.Height / 2);
        }
    }
}
