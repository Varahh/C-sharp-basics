using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task1
{
    class Rectangle
    {
        private double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            Console.WriteLine("Площадь прямоугольника равна  ");
            return side1 * side2;
        }

        private double PerimeterCalculator() {
            return 2 * side1 + 2 * side2;
        }

        public double Area
        {
            get {  return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите длину прямоугольника");
            double side1 = ReadDouble();
            Console.WriteLine("Введите ширину прямоугольника");
            double side2 = ReadDouble();

            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine($"Площадь равна {rect.Area}");
            Console.WriteLine($"Периметер равен {rect.Perimeter}");
        }

        static double ReadDouble()
        {
            double value;
            while(!double.TryParse(Console.ReadLine(), out value)){
                Console.WriteLine("[ОШИБКА]: Введите верное значение");
            }
            return Math.Abs(value);
        }
    }
}
