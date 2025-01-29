using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace monogameGame
{
    public class GameManager : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private player player;
        private List<gameEntity> gameEntities = new List<gameEntity>();
        public GraphicsDeviceManager Graphics { get { return _graphics; } }
        public SpriteBatch Spritebatch { get { return _spriteBatch;  } }
        public bool isGameOver { get; set; }
        public GameManager()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        public bool isColliding(gameEntity entityCheck)
        {
            foreach (var entity in gameEntities)
            {
                if (entity == entityCheck) continue;
                if (entity ==)
            }
        }
        protected override void Initialize()
        {
            Window.AllowUserResizing = true;
            // TODO: Add your initialization logic here
            player = new player(this, new Vector2 (100, 100));
            base.Initialize();
        }
        public void createPipe(Vector2 pipePos)
        {
            var newPipe = new pipe(this, pipePos);
            gameEntities.Add(newPipe);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            float deltaTime = gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            

            int windHeight =  _graphics.PreferredBackBufferHeight;
            player.Update(deltaTime);
            foreach (var entity in gameEntities)
            {
                entity.Update(deltaTime);
            }
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            player.Draw();
            foreach (var entity in gameEntities)
            {
                entity.Draw();
            }
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
