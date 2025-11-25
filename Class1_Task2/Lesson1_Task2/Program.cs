using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task2
{
    public class Title
    {
        private string _title;
        public Title(string message) 
        {
            this._title = message;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Название книги {this._title}");
        }
    }

    public class Author {
        private string _author;
        public Author(string message) 
        {
            this._author = message;
        }

      public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Автор книги {_author}");
        }
    }
    public class Content
    {
        private string _content;
        public Content(string message)
        {
            this._content = message;
        }
        public void Show() {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Содержание книги {_content}");
        }
    }
    public class Book
    {
        public Title title {  get; set; }
        public Author author { get; set; }
        public Content content { get; set; }

        public void Show()
        {
            Console.WriteLine();
            title?.Show();
            author?.Show();
            content?.Show();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Введите название книги");
            book.title = new Title(Console.ReadLine());
            Console.WriteLine("Введите автора книги");
            book.author = new Author(Console.ReadLine());
            Console.WriteLine("Введите содержание книги");
            book.content = new Content(Console.ReadLine());
            book.Show();
            Console.ResetColor();
        }
    }
}
