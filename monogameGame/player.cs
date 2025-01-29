using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameGame
{
    public class player : gameEntity
    {
        private bool jumped = false;
        private float gravity = 20.0f;
        private float flap = 60.0f;
        public player(GameManager game, Vector2 initialPosition) : base(game, initialPosition)
        {
            movementDirection = new Vector2(0, gravity);
            sprite = gameManager.Content.Load<Texture2D>("googly-a");
        }
        public void Update(float deltaTime)
        {
            base.Update(deltaTime);
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Space))
            {
                if (!jumped)
                {
                    position.Y -= flap;
                    jumped = true;
                }
            }
            else
            {
                jumped = false;
            }

            // TODO: Add your update logic here
            
        }

    }
    
}
