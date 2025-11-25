using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class13_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> list = new List<dynamic>()
            {
                new {eng = "Laptop      ", rus = "Ноутбук"},
                new {eng = "Mouse       ", rus = "Мышь"},
                new {eng = "Monitor     ", rus = "Монитор"},
                new {eng = "Cat         ", rus = "Кот"},
                new {eng = "Headache    ", rus = "Головная боль"},
                new {eng = "Task        ", rus = "Задача"},
                new {eng = "Car         ", rus = "Машина"},
                new {eng = "Phone number", rus = "Номер телефона"},
                new {eng = "Water       ", rus = "Вода"},
                new {eng = "Grass       ", rus = "Трава"},
            };

            foreach (var item in list) {
                Console.WriteLine($"Английский вариант: {item.eng} ||| Русский вариант: {item.rus}");
            }
        }
    }
}
