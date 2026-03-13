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
        public string Author {  get; set; } //Value - will be stored in a private variable
        public string Title {  get; set; }

        //Using access properties to validate year
        private int year; // private variable to store the year value
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0 || value > DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException("Year must be between 0 and the current year.");
                year = value;
            }
        }
        public string Description {  get; set; }
        public string Genre {  get; set; }
        private string ISBN { get; set; }


 
        public double Price { get; private set; } // properties to controll set and get the price of the book, private set means it can only be set within the class

        //constructor to initialize the book properties
        public Book()  //() its function, dont terminate it with a semicolon
        {
            Year = 2026;
            Price = 200;
            ISBN = "123-4567890123";
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
            ISBN = "123-4567890123";
            Price = 200;
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
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Price: {Price}");
        }
        public void DisplayBookInfo(bool basicInfo)
        {
            if (basicInfo)
            {
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"Title: {Title}");
            }
            else
            {
                DisplayBookInfo();
            }
        }
    }
}
