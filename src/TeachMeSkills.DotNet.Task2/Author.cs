using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task2
{
    public class Author
    {
        public string author;
        public static void ShowAuthor(string bookName, string authorName, string titleText)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Author Name: { authorName}");
            Console.ResetColor();
        }
    }
}
