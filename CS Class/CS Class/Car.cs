using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Class
{
    internal class Car
    {
        
        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1Km;
        public int Millage;
        
        public int Drive(int distance)
        {
            if (CurrentFuel >= distance*FuelFor1Km)
            {
                Console.WriteLine($"{distance} KM mesafeni gede bilersiniz..");
                Console.WriteLine($"Millage : {Millage + distance} KM");
                Console.WriteLine($"Benzin : {CurrentFuel-distance*FuelFor1Km} l");

                CurrentFuel = CurrentFuel - distance * FuelFor1Km; // Benzinin miqdarini azaldib return edirem

                Millage = Millage + distance;
                return Millage;
                return CurrentFuel;

            }
            else
            {
                Console.WriteLine($"{CurrentFuel} l yanacaq {distance} KM yolu getmek ucun kifayet etmir!!");
                return CurrentFuel;
                
            }
        }
    }
}
