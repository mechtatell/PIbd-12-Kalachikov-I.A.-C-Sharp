using System.Drawing;

namespace Laboratory
{
    abstract class Vehicle : ITransport
    {
        protected float posX;
        protected float posY;
        protected int frameWidth;
        protected int frameHeight;

        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }

        public void SetPosition(int posX, int posY, int frameWidth, int frameHeight)
        {
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
            if (posX >= 0 && posX < frameWidth &&
                posY >= 0 && posY < frameHeight)
            {
                this.posX = posX;
                this.posY = posY;
            }
        }

        public abstract void MoveTransport(Direction direction);
        public abstract void Render(Graphics g);
    }
}
