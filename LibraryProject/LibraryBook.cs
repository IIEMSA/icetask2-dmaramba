using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    //book in a library, it can be used to represent a book in the library,
    internal class LibraryBook : Book
    {
        public int Quantity;
        public string ShelfNumber;
        public bool IsAvailable;

        public void DisplayLibraryBookInfo()
        {
            //if its true this access everything in the book class and display
            Console.WriteLine($"Author: {Author}");// by association

            //But private members of the book class are not accessible in the library book class
            //   Console.WriteLine($"ISBN: {ISBN}");//error

            //Reuse the method from the book class to display the common information
            DisplayBookInfo(); // by association

            //Display the additional information specific to the library book

            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Shelf Number: {ShelfNumber}");
            Console.WriteLine($"Is Available: {IsAvailable}");
        }
    }
}   
