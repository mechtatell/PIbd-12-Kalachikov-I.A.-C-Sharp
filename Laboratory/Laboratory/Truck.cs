using System;
using System.Drawing;

namespace Laboratory
{
    public class Truck : Vehicle, IEquatable<Truck>
    {
        protected readonly int truckWidth = 200;
        protected readonly int truckHeight = 100;
        protected readonly char separator = ';';

        public Truck(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Truck(string info)
        {
            string[] args = info.Split(separator);
            if (args.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(args[0]);
                Weight = Convert.ToInt32(args[1]);
                MainColor = Color.FromName(args[2]);
            }
        }

        protected Truck(int maxSpeed, float weight, Color mainColor, int truckWidth, int truckHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.truckWidth = truckWidth;
            this.truckHeight = truckHeight;
        }

        public override void Render(Graphics g)
        {
            Brush[] brushes = new Brush[3] { new SolidBrush(Color.Black), new SolidBrush(MainColor), new SolidBrush(Color.Gray) };

            //Кузов
            g.DrawRectangle(new Pen(Color.Black), posX + 134, posY + 4, truckWidth - 153, truckHeight - 33);
            g.DrawRectangle(new Pen(Color.Black), posX + 134, posY + 29, truckWidth - 133, truckHeight - 58);
            g.FillRectangle(brushes[1], posX + 135, posY + 5, truckWidth - 155, truckHeight - 35);
            g.FillRectangle(new SolidBrush(Color.Blue), posX + 140, posY + 10, truckWidth - 165, truckHeight - 80);
            g.FillRectangle(brushes[1], posX + 135, posY + 30, truckWidth - 135, truckHeight - 60);
            g.FillRectangle(brushes[2], posX + 10, posY + 55, truckWidth - 20, 20);

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
                    if (posX + step < frameWidth - truckWidth)
                    {
                        posX += step;
                    }
                    break;
                case Direction.Down:
                    if (posY + step < frameHeight - truckHeight)
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

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        public bool Equals(Truck other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Truck truckObject))
            {
                return false;
            }
            return Equals(truckObject);
        }
    }
}
