using System.Drawing;

namespace Laboratory
{
    public interface ITransport
    {
        void SetPosition(int posX, int posY, int frameWidth, int frameHeight);
        void MoveTransport(Direction direction);
        void Render(Graphics g);
        void SetMainColor(Color color);
    }
}
