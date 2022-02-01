using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikerental2022
{
    class BikeCatalogList : IBikeCatalog
    {
        private List<Bike> bikeList;

        public BikeCatalogList()
        {
            bikeList = new List<Bike>();
        }

        public void AddBike(Bike aBike)
        {
            if (SearchBike(aBike.ChasisNumber) == null)
            {
                bikeList.Add(aBike);
            }
            else
            {
                throw new ArgumentException($"Chassis Number {aBike.ChasisNumber} already exists");
            }

        }


        public void PrintBikeList()
        {
            foreach (Bike bike in bikeList)
            {
                Console.WriteLine(bike);
            }
            Console.WriteLine(bikeList.Count);
            Console.WriteLine(DateTime.Now);
        }

        public Bike SearchBike(int ChassisNumber)
        {
            foreach (Bike bike in bikeList)
            {
                if (ChassisNumber == bike.ChasisNumber)
                {
                    return bike;
                }
            }

            return null;
        }

        public void DeleteBike(int ChassisNumber)
        {
            //foreach (Bike bike in bikeList)
            //{
            //    if (bike.ChasisNumber == ChassisNumber)
            //    {
            //        bikeList.Remove(bike);
            //        break;
            //    }
            //}
            Bike b = SearchBike(ChassisNumber);
            if (b!=null)
                bikeList.Remove(b);
        }

        public List<Bike> SearchBikesOfModel(string Model)
        {
            List<Bike> bikesOfModel = new List<Bike>();

            foreach (Bike bike in bikeList)
            {
                if (bike.Model == Model)
                {
                    bikesOfModel.Add(bike);
                }
            }

            if (bikesOfModel.Count != 0)
            {
                return bikesOfModel;
            }

            return null;
        }

        public void DeleteAllBikesOfModel(string Model)
        {
            
            //int i = 0;
            //while (i < bikeList.Count)
            //{
            //    Bike bikeToBeRemoved = bikeList[i];

            //    if (bikeToBeRemoved.Model == Model)
            //    {
            //        bikeList.Remove(bikeToBeRemoved);
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}

            foreach (Bike bike in SearchBikesOfModel(Model))
            {
                DeleteBike(bike.ChasisNumber);
            }


        }
    }
}
