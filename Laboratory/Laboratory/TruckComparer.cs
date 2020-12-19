using System.Collections.Generic;

namespace Laboratory
{
    class TruckComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle first, Vehicle second)
        {
            if (first.GetType().Name != second.GetType().Name)
            {
                return first.GetType().Name.CompareTo(second.GetType().Name);
            }
            if (first is Truck && second is Truck)
            {
                return ComparerTruck(first as Truck, second as Truck);
            }
            if (first is Tanker && second is Tanker)
            {
                return ComparerTanker(first as Tanker, second as Tanker);
            }
            return 0;
        }

        private int ComparerTruck(Truck first, Truck second)
        {
            if (first.MaxSpeed != second.MaxSpeed)
            {
                return first.MaxSpeed.CompareTo(second.MaxSpeed);
            }
            if (first.Weight != second.Weight)
            {
                return first.Weight.CompareTo(second.Weight);
            }
            if (first.MainColor != second.MainColor)
            {
                return first.MainColor.Name.CompareTo(second.MainColor.Name);
            }
            return 0;
        }

        private int ComparerTanker(Tanker first, Tanker second)
        {
            int result = ComparerTruck(first, second);
            if (result != 0)
            {
                return result;
            }
            if (first.OtherColor != second.OtherColor)
            {
                return first.OtherColor.Name.CompareTo(second.OtherColor.Name);
            }
            if (first.HasSiren != second.HasSiren)
            {
                return first.HasSiren.CompareTo(second.HasSiren);
            }
            if (first.HasStrip != second.HasStrip)
            {
                return first.HasStrip.CompareTo(second.HasStrip);
            }
            if (first.HasBumper != second.HasBumper)
            {
                return first.HasBumper.CompareTo(second.HasBumper);
            }
            if (first.HasTank != second.HasTank)
            {
                return first.HasTank.CompareTo(second.HasTank);
            }
            return 0;
        }
    }
}
