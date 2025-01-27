using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D mySprite;
        private Texture2D mySprite2;
        private bool jumped = false;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            mySprite = Content.Load<Texture2D>("googly-a");
            mySprite2 = Content.Load<Texture2D>("googly-c");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            float deltaTime = gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Space))
            {
                if (!jumped)
                {
                    characterPos.Y -= flap;
                    jumped = true;
                }
            }
            else
            {
                jumped = false;
            }

            // TODO: Add your update logic here
            characterPos.Y += gravity * deltaTime;

            int windHeight =  _graphics.PreferredBackBufferHeight;
            base.Update(gameTime);
        }
      
        private Vector2 characterPos = new Vector2(100,100);
        private float gravity = 20.0f;
        private float flap = 60.0f;
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(mySprite, new Rectangle((int)characterPos.X, (int)characterPos.Y, mySprite.Width/3, mySprite.Height/3), Color.White);
            
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
