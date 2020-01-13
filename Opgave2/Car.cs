using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2
{
    class Car
    {
        private string make;
        private string model;
        private string colour;
        private double price;
        private bool isSold;
        private bool isOnSale;

        public Car(string make, string model, string colour, double price, bool isSold)
        {
            Make = make;
            Model = model;
            Colour = colour;
            Price = price;
            IsSold = isSold;
            IsOnSale = false;
        }
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("", "Man kan ikke sælge en bil for mindre end 1 krone! Prøv igen.");
                }
                price = value;
            }
        }
        public bool IsSold
        {
            get
            {
                return isSold;
            }
            set
            {
                isSold = value;
            }
        }
        public bool IsOnSale
        {
            get
            {
                return isOnSale;
            }
            set
            {
                isOnSale = value;
            }
        }

        public override string ToString()
        {
            if(IsSold)
            {
                return $"SOLGT! Bilen er en {Make} {Model} i farven {Colour}. Prisen er {Price} DKK.";
            }
            else
            {
                return $"Bilen er en {Make} {Model} i farven {Colour}. Prisen er {Price} DKK.";
            }
        }
        public void PutOnSale()
        {
            if(!isOnSale)
            {
                isOnSale = true;
                Price *= 0.9;
            }
        }
    }
}
