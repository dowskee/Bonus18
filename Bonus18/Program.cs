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
            Console.WriteLine("Welcome to the Grand Circus Car Lot! Here is your list of cars you may buy:");

            Console.WriteLine("Make".PadRight(8, ' ') + "\t" + "Model".PadRight(8, ' ') + "\t" + "Year".PadRight(8, ' ') + "\t" + "Price".PadRight(8, ' ')+ "\t" + "Miles");

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
                Console.WriteLine(InventoryList[i].ToString()); //print override info from UsedCar and Car
                //you can even write this without ToString Method, because the compiler will automatically do this for the printing of the object.
            }
            Console.WriteLine("7. Quit");

            Console.WriteLine("Which car would you like?");
            int CarChoice = int.Parse(Console.ReadLine());
            CarChoice = CarChoice - 1;
            if (CarChoice == InventoryList.Length)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                //Console.WriteLine(InventoryList[CarChoice].Make);
                //validate input is only 1-6
                InventoryList[CarChoice].PrintInfo(); //can also be done with ToString
            }
            //to remove from list:
            //int indexToRemove = int.Parse(Console.ReadLine());
            //InventoryList = InventoryList.Where((source, index) => index != indexToRemove).ToArray(); (insert above)


        }

    }
}
