using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monogameGame
{
    public class gameEntity
    {
        protected Texture2D sprite;
        protected Rectangle collider;
        protected Vector2 position;
        protected float speed;
        protected GameManager gameManager;
        protected Vector2 movementDirection;

        public gameEntity(GameManager game, Vector2 initialPosition)
        {
            position = initialPosition;
            gameManager = game;
            movementDirection = new Vector2(-10, 0);
        }
        public virtual void Update(float deltaTime)
        {
            position += movementDirection * deltaTime;
            collider = new Rectangle((int)(position.X - sprite.Width / 3), (int)(position.Y - sprite.Height / 3), sprite.Width, sprite.Height);
        }
        public void Draw()
        {
            gameManager.Spritebatch.Draw(sprite, new Rectangle((int)position.X, (int)position.Y, sprite.Width / 3, sprite.Height / 3), Color.White);
        }
    }
}
