using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laboratory
{
    class Garage<T> where T : class, ITransport
    {
        private T[] places;
        private readonly int placeWidth = 220;
        private readonly int placeHeight = 120;
        private int frameWidth;
        private int frameHeight;
        private int occupiedPlaceCount;

        public Garage(int frameWidth, int frameHeight)
        {
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
            int columnsCount = frameWidth / placeWidth;
            int rowsCount = frameHeight / placeHeight;
            places = new T[columnsCount * rowsCount];
        }

        public static bool operator +(Garage<T> garage, T transport)
        {
            if (garage.occupiedPlaceCount < garage.places.Length)
            {
                garage.places[garage.occupiedPlaceCount] = transport;
                garage.occupiedPlaceCount += 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static T operator -(Garage<T> garage, T transport)
        {
            if (garage.occupiedPlaceCount > 0)
            {
                garage.occupiedPlaceCount -= 1;
                return garage.places[garage.occupiedPlaceCount];
            }
            else
            {
                return null;
            }
        }

        public void Render(Graphics g)
        {
            RenderMarking(g);

        }
        
        public void RenderMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            int columnCount = frameWidth / placeWidth;
            int rowsCount = frameHeight / placeHeight;
            int margin = 30;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    g.DrawLine(pen, margin + i * placeHeight, margin + j * placeWidth, margin + (i + 1) * placeHeight, margin + j * placeWidth);
                    g.DrawLine(pen, margin + i * placeHeight, margin + j * placeWidth, margin + i * placeHeight, margin + (j + 1) * placeWidth);
                }
            }

            for (int j = 0; j < columnCount; j++)
            {
                g.DrawLine(pen, margin + rowsCount * placeHeight, margin + j * placeWidth, margin + rowsCount * placeHeight, margin + (j + 1) * placeWidth);
            }
        }
    }
}
