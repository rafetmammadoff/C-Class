using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Class
{
    internal class Car
    {
        
        public string Brand;
        public string Model;
        public int CurrentFuel;//10
        public int FuelFor1Km; 
        public int Millage;
        
        public void Drive(int distance)
        {
            int requiredFuelForDistance = distance * FuelFor1Km;
            if(requiredFuelForDistance > CurrentFuel)
            {
                Console.WriteLine($"{CurrentFuel} l yanacaq {distance} KM yolu getmek ucun kifayet etmir!!");
                return;
            }
            Console.WriteLine($"{distance} KM mesafeni gede bilersiniz..");
            Console.WriteLine($"Millage : {Millage + distance} KM");
            Console.WriteLine($"Benzin : {CurrentFuel - requiredFuelForDistance} l");
            CurrentFuel = CurrentFuel - requiredFuelForDistance; // Benzinin miqdarini azaldib return edirem
            Millage = Millage + distance;
        }
    }
}
