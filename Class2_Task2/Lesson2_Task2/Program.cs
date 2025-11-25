using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task2
{
    public class Employee
    {
       private string name, surname, position;

        public Employee(string name, string surname) { 
            this.name = name;
            this.surname = surname;
        }

        private double payment(string position, int experience)
        {
            double basepayment;
            switch (position)
            {
                case "Директор":
                    basepayment = 5000; break;
                case "Главный инженер":
                    basepayment = 4800; break;
                case "Заместитель главного инженера":
                    basepayment = 4750; break;
                case "Инженер":
                    basepayment = 1850; break;
                default:
                    Console.WriteLine("Должность не найдена, но за старания накинем 300 рублей");
                    basepayment = 300; break;
            }
            return basepayment + (basepayment * experience * 0.1);
        }

        public void ShowInfo(string position, int experience)
        {
            Console.WriteLine($"Сотрудник: {this.name} {this.surname}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine("Оклад: " + payment(position, experience));
            Console.WriteLine("Налоговый сбор " + (payment(position, experience) * 0.13));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Олег", "Коновалов");
            emp.ShowInfo("Директор", 3);
        }
    }
}
