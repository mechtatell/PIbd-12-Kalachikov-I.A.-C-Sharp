using System.Drawing;

namespace Laboratory
{
    class Truck : Vehicle
    {
        protected readonly int carWidth = 200;
        protected readonly int carHeight = 100;

        public Truck(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected Truck(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.carWidth = carWidth;
            this.carHeight = carHeight;
        }

        public override void Render(Graphics g)
        {
            Brush[] brushes = new Brush[3] { new SolidBrush(Color.Black), new SolidBrush(MainColor), new SolidBrush(Color.Gray) };

            //Кузов
            g.DrawRectangle(new Pen(Color.Black), posX + 134, posY + 4, carWidth - 153, carHeight - 33);
            g.DrawRectangle(new Pen(Color.Black), posX + 134, posY + 29, carWidth - 133, carHeight - 58);
            g.FillRectangle(brushes[1], posX + 135, posY + 5, carWidth - 155, carHeight - 35);
            g.FillRectangle(new SolidBrush(Color.Blue), posX + 140, posY + 10, carWidth - 165, carHeight - 80);
            g.FillRectangle(brushes[1], posX + 135, posY + 30, carWidth - 135, carHeight - 60);
            g.FillRectangle(brushes[2], posX + 10, posY + 55, carWidth - 20, 20);

            //Колеса
            g.FillEllipse(brushes[0], posX + 20, posY + 60, 40, 40);
            g.FillEllipse(brushes[0], posX + 145, posY + 60, 40, 40);
            g.FillEllipse(brushes[1], posX + 25, posY + 65, 30, 30);
            g.FillEllipse(brushes[1], posX + 150, posY + 65, 30, 30);
        }

        public override void MoveTransport(Direction direction)
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
    }
}
