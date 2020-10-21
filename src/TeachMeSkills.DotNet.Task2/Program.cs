using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace TeachMeSkills.DotNet.Task2
{
    class Program
    {


        static void Main(string[] args)
        {
            List<string> val = new List<string>{};

            Action<string, string, string> show = new Action<string,string,string>(Book.ShowBook);
            show += Author.ShowAuthor;
            show += Title.ShowTitle;
            Console.WriteLine("Enter Book name");
            Book bookName = new Book
            {
                book = Console.ReadLine()
            };
            val.Add(bookName.book);
            Console.WriteLine("Enter Author name");
            Author authorName = new Author
            {
                author = Console.ReadLine()
            };
            Console.WriteLine("Enter Title text");
            Title titleText = new Title
            {
                title = Console.ReadLine()
            };
            Console.WriteLine("==================================================");
            show(bookName.book, authorName.author, titleText.title);
        }
    }
}
