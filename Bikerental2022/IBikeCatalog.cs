using System.Collections.Generic;

namespace Bikerental2022
{
    public interface IBikeCatalog
    {
        void AddBike(Bike aBike);
        void PrintBikeList();
        Bike SearchBike(int ChassisNumber);
        void DeleteBike(int ChassisNumber);
        List<Bike> SearchBikesOfModel(string Model);
        void DeleteAllBikesOfModel(string Model);
    }
}