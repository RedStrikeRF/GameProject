using Microsoft.Xna.Framework.Graphics;

namespace KnightOfHollow
{
    class Animation
    {
        /// <summary>
        /// Текстура, содержащая все кадры анимации, расположенные горизонтально.
        /// </summary>
        public Texture2D Texture
        {
            get { return texture; }
        }
        Texture2D texture;

        /// <summary>
        /// Время отображения каждого кадра.
        /// </summary>
        public float FrameTime
        {
            get { return frameTime; }
        }
        float frameTime;

        /// <summary>
        /// Флаг, указывающий, должна ли анимация продолжаться с начала после достижения конца.
        /// </summary>
        public bool IsLooping
        {
            get { return isLooping; }
        }
        bool isLooping;

        /// <summary>
        /// Количество кадров в анимации, которое вычисляется как ширина текстуры, деленная на высоту кадра.
        /// </summary>
        public int FrameCount
        {
            // Assume square frames.
            get { return Texture.Width / FrameHeight; }
        }

        /// <summary>
        /// Ширина кадра, которая вычисляется как высота текстуры.
        /// </summary>
        public int FrameWidth
        {
            // Assume square frames.
            get { return Texture.Height; }
        }

        /// <summary>
        /// Высота кадра, которая вычисляется как высота текстуры.
        /// </summary>
        public int FrameHeight
        {
            get { return Texture.Height; }
        }

        /// <summary>
        /// Конструктор анимации.
        /// </summary>        
        public Animation(Texture2D texture, float frameTime, bool isLooping)
        {
            this.texture = texture;
            this.frameTime = frameTime;
            this.isLooping = isLooping;
        }
    }
}