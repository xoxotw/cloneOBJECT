using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloneOBJ
{
    public class Vehicle
    {
        public string Brand;
        public string Color;
        public int Year;

        public Vehicle()
        { 
            
        }

        public Vehicle(string brand, string color, int year)
        {
            Brand = brand;
            Color = color;
            Year = year;
        }

        public void CloneCar(Vehicle mycar)
        {
            var myClonedCar = new Vehicle();
            myClonedCar = mycar;
            if (myClonedCar.Color == "BLUE")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("myClonedCar is a: {1} {0} from year: {2}" + Environment.NewLine, myClonedCar.Brand, myClonedCar.Color, myClonedCar.Year);
        }
    }
}
