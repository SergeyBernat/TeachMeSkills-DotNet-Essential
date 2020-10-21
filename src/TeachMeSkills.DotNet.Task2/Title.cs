using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task2
{
    public class Title
    {
        public string title;
        public static void ShowTitle(string bookName, string authorName, string titleText)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Title: {titleText}");
            Console.ResetColor();
        }
    }
}
