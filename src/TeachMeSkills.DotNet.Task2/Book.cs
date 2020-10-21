using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task2
{
    public class Book
    {
        public string book;

        public static void ShowBook(string bookName, string authorName, string titleText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Book Name: { bookName}");
            Console.ResetColor();
        }
    }
}
