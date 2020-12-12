using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Laboratory
{
    class Garage<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, ITransport
    {
        private readonly List<T> places;
        private readonly int maxCount;
        private readonly int placeWidth = 240;
        private readonly int placeHeight = 140;
        private readonly int frameWidth;
        private readonly int frameHeight;

        private int currentIndex;

        public T Current => places[currentIndex];

        object IEnumerator.Current => places[currentIndex];

        public Garage(int frameWidth, int frameHeight)
        {
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
            int columnsCount = frameWidth / placeWidth;
            int rowsCount = frameHeight / placeHeight;
            maxCount = columnsCount * rowsCount;
            places = new List<T>();
            currentIndex = -1;
        }

        public static bool operator +(Garage<T> garage, T truck)
        {
            if (garage.places.Count >= garage.maxCount)
            {
                throw new GarageOverflowException();
            }
            if (garage.places.Contains(truck))
            {
                throw new GarageAlreadyHaveException();
            }
            garage.places.Add(truck);
            return true;
        }

        public static T operator -(Garage<T> garage, int index)
        {
            if (index < 0 || index >= garage.places.Count)
            {
                throw new GarageNotFoundException(index);
            }
            T truck = garage.places[index];
            garage.places.RemoveAt(index);
            return truck;
        }

        public void Render(Graphics g)
        {
            int margin = 30;
            int rowsCount = frameHeight / placeHeight;

            RenderMarking(g);
            for (int i = 0; i < places.Count; i++)
            {
                places[i].SetPosition(margin + placeWidth * (i / rowsCount), margin + placeHeight * (i % rowsCount), frameWidth, frameHeight);
                places[i].Render(g);
            }
        }

        public void RenderMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            int margin = 15;
            int rowsCount = frameHeight / placeHeight;
            int columnsCount = frameWidth / placeWidth;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    g.DrawLine(pen, margin + j * placeWidth, margin + i * placeHeight, margin + (j + 1) * placeWidth, margin + i * placeHeight);
                    if (j > 0)
                    {
                        g.DrawLine(pen, margin + j * placeWidth, margin + i * placeHeight, margin + j * placeWidth, margin + (i + 1) * placeHeight);
                    }
                }
            }

            for (int j = 0; j < columnsCount; j++)
            {
                g.DrawLine(pen, margin + j * placeWidth, margin + rowsCount * placeHeight, margin + (j + 1) * placeWidth, margin + rowsCount * placeHeight);
            }
        }

        public T GetTruck(int index)
        {
            if (index >= 0 && index < places.Count)
            {
                return places[index];
            }
            return null;
        }

        public void Sort() => places.Sort((IComparer<T>)new TruckComparer());

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < places.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public void Dispose()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
