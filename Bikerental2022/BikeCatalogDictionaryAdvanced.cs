using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikerental2022
{
    class BikeCatalogDictionaryAdvanced
    {
        private Dictionary<int, Bike> _catalog;

        public BikeCatalogDictionaryAdvanced()
        {
            _catalog = new Dictionary<int, Bike>();
        }

        public void AddBike(Bike aBike)
        {
            if (_catalog.ContainsKey(aBike.ChasisNumber))
                throw new ArgumentException("Can not have two or more Bikes with the same chasisNum");
            _catalog.Add(aBike.ChasisNumber, aBike);
        }

        public void PrintBikeList()
        {
            Console.WriteLine("All Bikes: \n\t"
                              + string.Join("\n\t", _catalog.Values)
                              + $"\nThere are currently {_catalog.Count} bikes and the time is {DateTime.Now}");
        }

        public Bike SearchBike(int chasisNum)
        {
            if (_catalog.ContainsKey(chasisNum))
                return _catalog[chasisNum];
            return null;
        }

        public void DeleteBike(int chasisNum)
        {
            _catalog.Remove(chasisNum);
        }

        public List<Bike> SearchBikesOfModel(string model)
        {
            return _catalog.Values.Where(x => x.Model == model).ToList();
        }

        public void DeleteAllBikesOfModel(string model)
        {
            foreach (Bike bike in SearchBikesOfModel(model))
            {
                DeleteBike(bike.ChasisNumber);
            }
        }
    }
}
