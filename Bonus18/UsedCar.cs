using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class UsedCar:Car
    {

        private double usedprice;
        private double miles;

        public double UsedPrice
        {
            set { usedprice = value; }
            get { return usedprice; }
        }

        public double Miles
        {
            set { miles = value; }
            get { return miles; }
        }
        //constructors

        //default constructor
        public UsedCar() //base constructor? 
        {
            usedprice = 0;
            miles = 0;
        }

        //consturctor with values
        public UsedCar(string make, string model, int year, double UsedCarPrice, double Miles)
        {
            make = Make;
            model = Model;
            year = Year;
            usedprice = UsedCarPrice;
            miles = Miles;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(Make + " " + Model + " " + Year + " " + UsedPrice+" (Used)" + Miles+" miles");
        }

    }
}
