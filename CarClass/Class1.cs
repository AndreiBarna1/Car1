using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Passengercar
    {
        public double price { get; set; }
        public int age { get; set; }
        public string place { get; set; }
        public string name { get; set; }

        public void GetPassengercarInfo()
        {
            Console.WriteLine($"Имя: {name}| |Лет с момента покупки: {age}| |Страна производства: {place}|");
        }
    }


    class Truck : Passengercar
    {
        public string type { get; set; }

        public virtual void GetTruckInfo()
        {
            Console.WriteLine($"Имя: {name}| |Лет с момента покупки: {age}| |Место: {place}| |Цена автомобиля: {price}|");
        }
    }
}