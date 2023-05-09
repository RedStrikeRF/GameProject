using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
namespace KnightOfTheHollow
{
    internal class Sprites
    {
        private Texture2D _texture;
        public Input Input;
        public Vector2 Position;
        public Vector2 OriginPosition;
        
        public float Rotation;

        public float Speed = 2f;
        public float RotationVelocity = 3f;
        public float LinearVelocity = 4f;

        public Sprites(Texture2D texture)
        {
            _texture = texture;
        }

        public void Update()
        {
            Move();
            //Fight();
        }
        private void Move()
        {   
            
            if (Input == null)
                return;
            //поворот осуществляется по часовой стрелке где:
            //0 часов - 0 градусов
            //3 часа - 90 градусов
            //6 часов - 180 градусов
            //9 часов - 270 градусов
            //X - смотрится по горизонтали сверху вниз
            //Y - по вертикали сверху вниз
            if (Keyboard.GetState().IsKeyDown(Input.Up))
            {   
                Rotation = MathHelper.ToRadians(0);
                Position.Y -= Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Right))
            {
                Rotation = MathHelper.ToRadians(90);
                Position.X += Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Down))
            {
                Rotation = MathHelper.ToRadians(180);
                Position.Y += Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Left))
            {
                Rotation = MathHelper.ToRadians(270);
                Position.X -= Speed;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, null,  Color.White, Rotation, OriginPosition,1, SpriteEffects.None, 0f);
        }
    }
}
