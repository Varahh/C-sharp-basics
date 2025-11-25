using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class13_Task1
{
    public class Car
    {
        public string brand, model, colour;
        public int year;

        public Car(string brand, string model, string colour, int year)
        {
            this.brand = brand;
            this.model = model;
            this.colour = colour;
            this.year = year;
        }
    }

    public class Sales
    {
        public string model, name, phone_numb;

        public Sales(string model, string name, string phone_numb)
        {
            this.model = model;
            this.name = name;
            this.phone_numb = phone_numb;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car("Toyota", "Corolla", "Черный", 2007),
                new Car("Lada", "2107", "Вишневый", 1985),
                new Car("Nissan", "Sport", "Синий", 2000),
                new Car("BMW", "X6", "Белый", 2019)
            };

            List<Sales> sales = new List<Sales>()
            {
                new Sales("2107", "Виктор Иванович", "+375298547722"),
                new Sales("X6", "Александр Владимирович", "+375448884212")
            };

            var result = from car in cars join sale in sales on car.model equals sale.model select new { car.brand, car.model, car.colour, car.year, sale.name, sale.phone_numb };
            foreach (var res in result)
            {
                Console.WriteLine($"Марка машины: {res.brand}");
                Console.WriteLine($"Модель машины: {res.model}");
                Console.WriteLine($"Цвет машины: {res.colour}");
                Console.WriteLine($"Год выпуска машины: {res.year}");
                Console.WriteLine($"Имя покупателя: {res.name}");
                Console.WriteLine($"Номер покупателя: {res.phone_numb}\n");
            }
        }
    }
}
