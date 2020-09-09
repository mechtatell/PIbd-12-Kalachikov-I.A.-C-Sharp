using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laboratory
{
    class Tanker
    {
        private float posX;
        private float posY;
        private int frameWidth;
        private int frameHeight;

        private readonly int carWidth = 200;
        private readonly int carHeight = 100;

        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color OtherColor { private set; get; }
        public bool HasSiren { private set; get; }
        public bool HasStrip { private set; get; }
        public bool HasBumper { private set; get; }
        public bool HasTank { private set; get; }

        public Tanker(int maxSpeed, float weight, Color mainColor, Color otherColor, bool hasSiren, bool hasStrip, bool hasBumper, bool hasTank)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            OtherColor = otherColor;
            HasSiren = hasSiren;
            HasStrip = hasStrip;
            HasBumper = hasBumper;
            HasTank = hasTank;
        }

        public void SetPosition(float posX, float posY, int frameWidth, int frameHeight)
        {
            this.frameHeight = frameHeight;
            this.frameWidth = frameWidth;
            if (posX >= 0 && posX + carWidth < frameWidth &&
                posY >= 0 && posY + carHeight < frameHeight)
            {
                this.posX = posX;
                this.posY = posY;
            }
        }

        public void MoveCar(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Up:
                    if (posY - step > 0)
                    {
                        posY -= step;
                    }
                    break;
                case Direction.Right:
                    if (posX + step < frameWidth - carWidth)
                    {
                        posX += step;
                    }
                    break;
                case Direction.Down:
                    if (posY + step < frameHeight - carHeight)
                    {
                        posY += step;
                    }
                    break;
                case Direction.Left:
                    if (posX - step > 0)
                    {
                        posX -= step;
                    }
                    break;
            }
        }

        public void Render(Graphics g)
        {
            Brush[] brushes = new Brush[4] { new SolidBrush(Color.Black), new SolidBrush(MainColor), new SolidBrush(OtherColor), new SolidBrush(Color.Gray)};

            //Бак
            if (HasTank)
            {
                g.FillRectangle(brushes[2], posX + 5, posY + 5, carWidth - 85, carHeight - 35);
                g.FillEllipse(brushes[2], posX, posY + 5, 10, carHeight - 35);
                g.FillEllipse(brushes[2], posX + 115, posY + 5, 10, carHeight - 35);
            }

            //Кузов
            g.DrawRectangle(new Pen(Color.Black), posX + 134, posY + 4, carWidth - 153, carHeight - 33);
            g.DrawRectangle(new Pen(Color.Black), posX + 134, posY + 29, carWidth - 133, carHeight - 58);
            g.FillRectangle(brushes[1], posX + 135, posY + 5, carWidth - 155, carHeight - 35);
            g.FillRectangle(new SolidBrush(Color.Blue), posX + 140, posY + 10, carWidth - 165, carHeight - 80);
            g.FillRectangle(brushes[1], posX + 135, posY + 30, carWidth - 135, carHeight - 60);
            g.FillRectangle(brushes[3], posX + 10, posY + 55, carWidth - 20, 20);

            //Колеса
            g.FillEllipse(brushes[0], posX + 20, posY + 60, 40, 40);
            g.FillEllipse(brushes[0], posX + 145, posY + 60, 40, 40);
            g.FillEllipse(new SolidBrush(OtherColor), posX + 25, posY + 65, 30, 30);
            g.FillEllipse(new SolidBrush(OtherColor), posX + 150, posY + 65, 30, 30);

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
                g.FillRectangle(brushes[2], posX + 140, posY + 45, carWidth - 150, 5);

                if (HasTank)
                {
                    g.FillRectangle(brushes[1], posX + 10, posY + 25, carWidth - 95, 5);
                    g.FillRectangle(brushes[1], posX + 10, posY + 35, carWidth - 95, 5);
                }
            }

            //Бампер
            if (HasBumper)
            {
                g.FillRectangle(new SolidBrush(Color.SlateGray), posX + 185, posY + 28, 15, 45);
            }
        }
    }
}
