using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task3
{
    public class Invoice
    {
        public readonly int account;
        public readonly string customer, provider;
        private string article;
        private int quantity;

        public Invoice (int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        private double NoNDS(double price)
        {
            return price * quantity;
        }

        private double WithNDS(double price) {

            return price * quantity * 1.20;
        }

        public void ShowInfo(double price)
        {
            Console.WriteLine($"Название товара {this.article}");
            Console.WriteLine("Стоимость товара без НДС: " + NoNDS(price));
            Console.WriteLine("Стоимость товара с НДС: " + WithNDS(price));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Газпром", "БелНефтьГаз", "Танкеры", 20);
            invoice.ShowInfo(5000);
        }
    }
}
