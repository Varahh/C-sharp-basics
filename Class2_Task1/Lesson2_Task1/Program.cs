using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task1
{
    public class Converter
    {
        double usd, eur, rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double FromGryvn(string val, double sum)
        {
            switch (val)
            {
                case ("usd"):
                    return sum * 0.024;
                case ("eur"):
                    return sum * 0.021;
                case ("rub"):
                    return sum * 1.93;
                default:
                    Console.WriteLine("Валюта выбрана неверно");
                    return 0;
            }
        }
        public double ToGryvn(string val, double sum)
        {
                switch (val)
                {
                    case ("usd"):
                        return sum * 42.07;
                    case ("eur"):
                        return sum * 48.74;
                    case ("rub"):
                        return sum * 0.52;
                    default:
                        Console.WriteLine("Валюта выбрана неверно");
                        return 0;
                }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Converter conv = new Converter(10, 20, 30);
                Console.WriteLine(conv.ToGryvn("usd", 100));
            }
        }
    }
}
