using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikerental2022
{
    class BikeCatalogDictionary:IBikeCatalog
    {
        public Dictionary<int, Bike> bikeDictionary;

        public BikeCatalogDictionary()
        {
            bikeDictionary = new Dictionary<int, Bike>();
        }

        public void AddBike(Bike aBike)
        {
            if (bikeDictionary.ContainsKey(aBike.ChasisNumber))
            {
                throw new ArgumentException("Bike with ChassisNumber is already registered in the BikeCatalog.");
            }
            else
            {
                bikeDictionary.Add(aBike.ChasisNumber, aBike);
            }
        }

        public void PrintBikeList()
        {
            foreach (Bike item in bikeDictionary.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Number Of Items: {bikeDictionary.Count}");
            Console.WriteLine($"Current Time: {DateTime.Now}");
        }

        public Bike SearchBike(int chassisNumber)
        {
            //foreach (KeyValuePair<int, Bike> item in bikeDictionary)
            //{
            //    if (item.Key == chassisNumber)
            //    {
            //        return item.Value;
            //    }
            //}

            //return null;
            if (bikeDictionary.ContainsKey(chassisNumber))
            {
                return bikeDictionary[chassisNumber];
            }
            else
            {
                return null;
            }

        }

        public void DeleteBike(int chassisNumber)
        {
            
            if (bikeDictionary.ContainsKey(chassisNumber))
            {
                bikeDictionary.Remove(chassisNumber);
            }
        }

        public List<Bike> SearchBikesOfModel(string model)
        {
            List<Bike> bikeList = new List<Bike>();

            foreach (Bike item in bikeDictionary.Values)
            {
                if (item.Model == model)
                {
                    bikeList.Add(item);
                }
            }
            if (bikeList.Count!= 0)
                return bikeList;
            else
            {
                return null;
            }
        }

        public void DeleteAllBikesOfModel(string model)
        {
            foreach (KeyValuePair<int, Bike> item in bikeDictionary)
            {
                if (item.Value.Model == model)
                {
                    bikeDictionary.Remove(item.Key);
                }
            }
        }
    }
}
