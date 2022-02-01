using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikerental2022
{
    class EBike : Bike
    {
        private string _motor;

        public string Motor
        {
            get { return _motor; }
            set { _motor = value; }
        }

        public EBike(string model, int yearOfPurchase, string frameColor, int chasisNumber, string motor) : base(model, yearOfPurchase, frameColor, chasisNumber)
        {
            _motor = motor;
        }

        public override string ToString()
        {
            return base.ToString() + $" Motor: {_motor}";
        }

    }
}
