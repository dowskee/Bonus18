using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class UsedCar:Car
    {

        private double miles;

        public double Miles
        {
            set { miles = value; }
            get { return miles; }
        }
        //constructors

        //default constructor
        public UsedCar() //base constructor? 
        {
            
            miles = 0;
        }

        //consturctor with values
        public UsedCar(string CarModel, string CarMake, int CarYear, double CarPrice, double CarMiles)
        {
            
            make = CarMake;
            model = CarModel;
            year = CarYear;
            price = CarPrice;
            miles = CarMiles;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(Make + " " + Model + " " + Year + " " + Price+"(Used) " + Miles+" miles");
        }

    }
}
