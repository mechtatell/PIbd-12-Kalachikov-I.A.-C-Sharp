using System.Collections.Generic;
using System.Linq;

namespace Laboratory
{
    class GarageCollection
    {
        private readonly Dictionary<string, Garage<Truck>> garageStages;
        private readonly int frameWidth;
        private readonly int frameHeight;

        public GarageCollection(int frameWidth, int frameHeight)
        {
            garageStages = new Dictionary<string, Garage<Truck>>();
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
        }

        public List<string> Keys => garageStages.Keys.ToList();

        public void AddGarage(string name)
        {
            if (!garageStages.ContainsKey(name))
            {
                garageStages.Add(name, new Garage<Truck>(frameWidth, frameHeight));
            }
        }

        public void RemoveGarage(string name)
        {
            if (garageStages.ContainsKey(name))
            {
                garageStages.Remove(name);
            }
        }

        public Garage<Truck> this[string name]
        {
            get => garageStages[name];
        }
    }
}
