using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace KnightOfTheHollow
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //private Texture2D _HeroTexture;
        //private Vector2 _HeroPosition;
        private Sprites _hero;
        private Sprites _monsters;
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

            var heroTextures = Content.Load<Texture2D>("Hero");
            _hero = new Sprites(heroTextures)
            {
                _position = new Vector2(100, 0),
                Speed = 3f
            };

            var monstersTextures = Content.Load<Texture2D>("monsters");
            _monsters = new Sprites(monstersTextures)
            {
                _position = new Vector2(100, 0),
                Speed = 2f
            };
           
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            _hero.Update();
            _monsters.Update();

            if(Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _hero.Draw(_spriteBatch);
            _monsters.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}