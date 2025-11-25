//Уточнить нужно ли было делать ввод с клавиатуры, в задании ничего про это не сказано в отличие от двух предыдущих

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task3
{
    public class Point {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int XCord
        {
            get { return x; }
        }

        public int YCord
        {
            get { return y; }
        }

    }
    public class Figure {
        Point a, b, c, d, e;
        public Figure(Point A, Point B, Point C)
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
            this.e = E;
        }

        public double LengthSide(Point A, Point B) {
            return Math.Sqrt(Math.Pow((B.XCord - A.XCord), 2) + Math.Pow((B.YCord - A.YCord), 2));
        }
        
        public void PerimeterCalculator()
        {
            if (d == null)
            {
                Console.WriteLine($"Фигура - треугольник, её периметер {LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, a)}");
            }

            if (d != null && e == null)
            {
                Console.WriteLine($"Фигура - квадрат, её периметер {LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d,a)}");
            }
            if (e != null)
            {
                Console.WriteLine($"Фигура - пятиугольник, её периметер {LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, e) + LengthSide(e,a)}");
            }
                return;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 1);
            Point p2 = new Point(1, -5);
            Point p3 = new Point(5, 10);
            Point p4 = new Point(10, 10);
            Point p5 = new Point(6, 11);
            Figure mnogougolnik = new Figure(p1, p2, p3, p4);
            mnogougolnik.PerimeterCalculator();
        }
    }
}
