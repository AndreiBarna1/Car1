using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Passengercar Passengercar = new Passengercar();
            Passengercar.name = "Hyundai Solaris";
            Passengercar.price = 600000;
            Passengercar.age = 1;
            Passengercar.place = "Корея";

            Passengercar.GetPassengercarInfo();

            Truck truck = new Truck();
            truck.name = "МАЗ-5440";
            truck.place = "Минск";
            truck.price = 2500000;
            truck.age =  5;


            truck.GetTruckInfo();

            Console.ReadLine();
        }
    }
}
