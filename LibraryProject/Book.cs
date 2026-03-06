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

        //constructor to initialize the book properties
        public Book()  //() its function, dont terminate it with a semicolon
        {
            Year = 2026;
            Console.WriteLine("Constructor function called");
        }

        public Book(int year)  //() its function, dont terminate it with a semicolon
        {
            Year = year;
        }
        //Parameterized constructor to initialize the book properties with specific values
        public Book(string author, string title, int year, string description, string genre)
        {
            Author = author;
            Title = title;
            Year = year;
            Description = description;
            Genre = genre;
        }

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
