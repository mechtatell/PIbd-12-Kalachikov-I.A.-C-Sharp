using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Laboratory
{
    class GarageCollection
    {
        private readonly Dictionary<string, Garage<Truck>> garageStages;
        private readonly int frameWidth;
        private readonly int frameHeight;
        private readonly char separator = ':';

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
            get
            {
                if (garageStages.ContainsKey(name))
                {
                    return garageStages[name];
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            using (StreamWriter streamWriter = new StreamWriter
                (filename, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine("GarageCollection");
                foreach (var level in garageStages)
                {
                    streamWriter.WriteLine("Garage" + separator + level.Key);

                    ITransport truck;
                    for (int i = 0; (truck = level.Value.GetTruck(i)) != null; i++)
                    {
                        if (truck.GetType().Name == "Truck")
                        {
                            streamWriter.Write("Truck" + separator);
                        }
                        else if (truck.GetType().Name == "Tanker")
                        {
                            streamWriter.Write("Tanker" + separator);
                        }
                        streamWriter.WriteLine(truck);
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader streamReader = new StreamReader
                (filename, System.Text.Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("GarageCollection"))
                {
                    garageStages.Clear();
                }
                else
                {
                    throw new FileLoadException("Неверный формат файла");
                }
                Truck truck = null;
                string key = string.Empty;
                string line;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains("Garage"))
                    {
                        key = line.Split(separator)[1];
                        garageStages.Add(key, new Garage<Truck>(frameWidth, frameHeight));
                    }
                    else if (line.Contains(separator))
                    {
                        if (line.Contains("Truck"))
                        {
                            truck = new Truck(line.Split(separator)[1]);
                        }
                        else if (line.Contains("Tanker"))
                        {
                            truck = new Tanker(line.Split(separator)[1]);
                        }
                        if (!(garageStages[key] + truck))
                        {
                            throw new GarageOverflowException();
                        }
                    }
                }
            }
        }
    }
}
