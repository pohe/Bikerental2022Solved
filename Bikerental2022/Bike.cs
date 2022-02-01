using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikerental2022
{
    public class Bike
    {
        
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private int _yearOfPurchase;

        public int YearOfPurchase
        {
            get { return _yearOfPurchase; }
            set { _yearOfPurchase = value; }
        }

        private string _frameColor;

        public string FrameColor
        {
            get { return _frameColor; }
            set { _frameColor = value; }
        }

        private int _chasisNumber;


        public int ChasisNumber
        {

            get { return _chasisNumber; }

        }

        public Bike(string model, int yearOfPurchase, string frameColor, int chasisNumber)
        {
            Model = model;
            YearOfPurchase = yearOfPurchase;
            FrameColor = frameColor;
            _chasisNumber = chasisNumber;
        }

        public override string ToString()
        {
            return $"Model: {_model}, Year of purchase: {_yearOfPurchase}, Frame color: {_frameColor} & Chasis number: {_chasisNumber}";
        }

    }
}
