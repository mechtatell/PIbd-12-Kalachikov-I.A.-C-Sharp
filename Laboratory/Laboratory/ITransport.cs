using System.Drawing;

namespace Laboratory
{
    interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        void Render(Graphics g);
    }
}
