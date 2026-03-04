using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class Book
    {

        /*
         properties of the book class
        state they hold information about the book 
         */
        public string Author;
        public string Title;
        public int Year;
        public string Description;
        public string Genre;

        /*
         Method to display the book information
         */
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}
