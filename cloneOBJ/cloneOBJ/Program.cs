using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloneOBJ
{
    public class Program
    {
              
        static void Main(string[] args)
        {
            var myCar = new Vehicle("VOLVO", "BLUE", 1988);
            var my2car = new Vehicle("PAGANI HYURA", "PINK", 2013);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("myCar is a: {1} {0} from year: {2}" + Environment.NewLine, myCar.Brand, myCar.Color, myCar.Year);
                        
            myCar.CloneCar(myCar);
            myCar.CloneCar(my2car);
            
            Console.ReadLine();

        }
               
    }
}
