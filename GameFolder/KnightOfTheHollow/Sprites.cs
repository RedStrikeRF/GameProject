using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace KnightOfTheHollow
{
    internal class Sprites
    {
        private Texture2D _texture;
        public Input Input;
        public Vector2 _position;
        public float Speed = 2f;
        public Sprites(Texture2D texture)
        {
            _texture = texture;
        }

        public void Update()
        {
            Move();
            Fight();
        }
        private void Move()
        {
            if (Input == null)
                return;
            if (Keyboard.GetState().IsKeyDown(Input.Left))
            {
                _position.X -= Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Right))
            {
                _position.X += Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Down))
            {
                _position.Y += Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Jump))
            {
                _position.Y -= Speed;
            }
        }
        private void Fight()
        {
            if (Keyboard.GetState().IsKeyDown(Input.Attack))
            {
                _position.Y -= Speed*10;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Shift))
            {
                _position.X -= Speed*20;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
