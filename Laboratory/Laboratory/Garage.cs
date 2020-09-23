using System.Drawing;

namespace Laboratory
{
    class Garage<T> where T : class, ITransport
    {
        private T[] places;
        private readonly int placeWidth = 240;
        private readonly int placeHeight = 140;
        private int frameWidth;
        private int frameHeight;

        private int occupiedPlaceCount;
        private readonly int columnsCount;
        private readonly int rowsCount;

        public Garage(int frameWidth, int frameHeight)
        {
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
            columnsCount = frameWidth / placeWidth;
            rowsCount = frameHeight / placeHeight;
            places = new T[columnsCount * rowsCount];
        }

        public static bool operator +(Garage<T> garage, T transport)
        {
            int margin = 30;
            if (garage.occupiedPlaceCount < garage.places.Length)
            {
                transport.SetPosition(margin + garage.placeWidth * ((garage.occupiedPlaceCount) / garage.rowsCount), margin + garage.placeHeight * ((garage.occupiedPlaceCount) % garage.rowsCount), garage.frameWidth, garage.frameHeight);
                garage.places[garage.occupiedPlaceCount] = transport;
                garage.occupiedPlaceCount += 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static T operator -(Garage<T> garage, int index)
        {
            if (index >= 0 && index < garage.places.Length && garage.places[index] != null)
            {
                T temp = garage.places[index];
                garage.places[index] = null;
                garage.occupiedPlaceCount -= 1;
                return temp;
            }
            else
            {
                return null;
            }
        }

        public void Render(Graphics g)
        {
            RenderMarking(g);
            for (int i = 0; i < places.Length; i++)
            {
                places[i]?.Render(g);
            }
        }
        
        public void RenderMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            int margin = 15;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    g.DrawLine(pen, margin + j * placeWidth, margin + i * placeHeight, margin + (j + 1) * placeWidth, margin + i * placeHeight);
                    g.DrawLine(pen, margin + j * placeWidth, margin + i * placeHeight, margin + j * placeWidth, margin + (i + 1) * placeHeight);
                }
            }

            for (int j = 0; j < columnsCount; j++)
            {
                g.DrawLine(pen, margin + j * placeWidth, margin + rowsCount * placeHeight, margin + (j + 1) * placeWidth, margin + rowsCount * placeHeight);
            }
        }
    }
}
