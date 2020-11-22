using System.Drawing;

namespace Laboratory
{
    class Tanker : Truck
    {
        public Color OtherColor { private set; get; }
        public bool HasSiren { private set; get; }
        public bool HasStrip { private set; get; }
        public bool HasBumper { private set; get; }
        public bool HasTank { private set; get; }
        
        public Tanker(int maxSpeed, float weight, Color mainColor, Color otherColor, bool hasSiren, bool hasStrip, bool hasBumper, bool hasTank)
            : base(maxSpeed, weight, mainColor, 200, 100)
        {
            OtherColor = otherColor;
            HasSiren = hasSiren;
            HasStrip = hasStrip;
            HasBumper = hasBumper;
            HasTank = hasTank;
        }

        public override void Render(Graphics g)
        {
            Brush[] brushes = new Brush[4] { new SolidBrush(Color.Black), new SolidBrush(MainColor), new SolidBrush(OtherColor), new SolidBrush(Color.Gray) };

            //Бак
            if (HasTank)
            {
                g.FillRectangle(brushes[2], posX + 5, posY + 5, truckWidth - 85, truckHeight - 35);
                g.FillEllipse(brushes[2], posX, posY + 5, 10, truckHeight - 35);
                g.FillEllipse(brushes[2], posX + 115, posY + 5, 10, truckHeight - 35);
            }

            base.Render(g);

            //Сирена
            if (HasSiren)
            {
                Point[] points = new Point[4]
                {
                    new Point((int)(posX + 150), (int)(posY + 6)),
                    new Point((int)(posX + 155), (int)posY),
                    new Point((int)(posX + 165), (int)posY),
                    new Point((int)(posX + 170), (int)(posY + 6))
                };
                g.FillPolygon(new SolidBrush(Color.Yellow), points);
                if (HasTank)
                {
                    g.FillRectangle(new SolidBrush(Color.Yellow), posX + 30, posY, 15, 6);
                }
            }

            //Полосы
            if (HasStrip)
            {
                g.FillRectangle(brushes[2], posX + 140, posY + 45, truckWidth - 150, 5);
                if (HasTank)
                {
                    g.FillRectangle(brushes[1], posX + 10, posY + 25, truckWidth - 95, 5);
                    g.FillRectangle(brushes[1], posX + 10, posY + 35, truckWidth - 95, 5);
                }
            }

            //Бампер
            if (HasBumper)
            {
                g.FillRectangle(new SolidBrush(Color.SlateGray), posX + 185, posY + 28, 15, 45);
            }
        }

        public void SetOtherColor(Color color)
        {
            OtherColor = color;
        }
    }
}
