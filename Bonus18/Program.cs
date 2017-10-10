using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of car models and types

            Car c1 = new Car("1. Nikkolai", "Model S", 2017, 54999.90);

            Car c2 = new Car("2. Fourd", "Escapade", 2017, 31999.90);

            Car c3 = new Car("3. Chewie", "Vette", 2017, 44989.95);

            UsedCar u1 = new UsedCar("4. Hyonda", "Prior", 2015, 14795.50, 35987.6);

            UsedCar u2 = new UsedCar("5. GC", "Chirpus", 2013, 8500.00, 12345.0);

            UsedCar u3 = new UsedCar("6. GC", "Witherell", 2016, 14450.00, 3500.3);



            Car[] InventoryList = new Car[6]; //array of Inventory

            InventoryList[0] = c1;
            InventoryList[1] = c2;
            InventoryList[2] = c3;

            InventoryList[3] = u1; // polymorphism 
            InventoryList[4] = u2; // polymorphism 
            InventoryList[5] = u3; // polymorphism 
            //InventoryList[6] = Console.WriteLine("6. Quit"); ??

            for (int i = 0; i < InventoryList.Length; i++)
            {
                InventoryList[i].PrintInfo(); //print override info from UsedCar and Car
            }

            Console.WriteLine("Which car would you like?");

            int UserSelection = int.Parse(Console.ReadLine());


        }
    }
}
