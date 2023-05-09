using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace KnightOfTheHollow
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //private Texture2D _HeroTexture;
        //private Vector2 _HeroPosition;
        //private Sprites _hero;
        //private Sprites _monsters;
        private List<Sprites> _sprites;
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
            var monstersTextures = Content.Load<Texture2D>("Hero");//было monsters
            var Test = Content.Load<Texture2D>("Test");

            _sprites = new List<Sprites>()
            {   
                new Sprites(Test)
                {
                    Position = new Vector2(0,0),
                    Input = new Input()
                    {
                        Up = Keys.Up,
                        Down = Keys.Down,
                        Left = Keys.Left,
                        Right = Keys.Right//,
                        //Attack = Keys.RightAlt,
                        //Shift = Keys.RightControl
                    },
                    OriginPosition = new Vector2(16,10),//Texture. тоже можно использовать
                }
            };

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            foreach(var sprite in _sprites)
            {
                sprite.Update();
            }

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

            foreach (var sprite in _sprites)
            {
                sprite.Draw(_spriteBatch);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}