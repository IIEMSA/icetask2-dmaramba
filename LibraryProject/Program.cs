
using LibraryProject;

Book book = new Book();
book.Author = "J.K. Rowling";
book.Title = "Harry Potter and the Philosopher's Stone";
book.Year = 1997;
book.Description = "A young wizard's journey begins.";
book.Genre = "Fantasy";
//book.ISBN = "Test";

Book book2 = new Book();
book2.Author = "George Orwell";
book2.Title = "1984";
book2.Year = 1949;
book2.Description = "A dystopian novel about totalitarianism.";
book2.Genre = "Science Fiction";

Book book3 = new Book();
book3.Author = "F. Scott Fitzgerald";
book3.Title = "The Great Gatsby";
book3.Description = "A critique of the American Dream.";
book3.Genre = "Classic Literature";

Console.WriteLine("Book 1 Details");
Console.WriteLine($"Author: {book.Author}");
Console.WriteLine($"Title: {book.Title}");

//formating the output to make it more readable
Console.WriteLine(new string('-', 20));
Console.WriteLine("Book 2 Details");
Console.WriteLine($"Author: {book2.Author}");
Console.WriteLine($"Title: {book2.Title}");
Console.WriteLine(new string('-', 20));

Book book4 =new Book("Harper Lee", "To Kill a Mockingbird", 1960, "A novel about racial injustice in the Deep South.", "Classic Literature");

Book book5 = new Book(2025);


LibraryBook book6 = new LibraryBook();
book6.Author = "Svetlin Nakov";
book6.Title = "Fundamentals of Computer Programming with C# ";
book6.Year = 2024;
book6.Description = "A comprehensive guide to learning C# programming.";
book6.Genre = "Programming";

//library book specific properties
book6.Quantity = 10;
book6.ShelfNumber = "A1";
book6.IsAvailable = true;
//book6.Price = 300; // this a set, not allowed because the set accessor is private
Console.WriteLine(book6.Price); // this a get
//.DisplayBookInfo(); // Display common book information
//book6.DisplayLibraryBookInfo(); // Display library book specific information
try
{
    book6.Year = 2027; // This will throw an exception because the year is out of range, 
}catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Error setting year: {ex.Message}");
}
//Display books using the method in Book class
Console.WriteLine("Displaying Book 1 Information:");
book.DisplayBookInfo();
Console.WriteLine(new string('-', 20));
Console.WriteLine("Displaying Book 2 Information:");
book2.DisplayBookInfo();
Console.WriteLine(new string('-', 20));
Console.WriteLine("Displaying Book 3 Information:");
book3.DisplayBookInfo();
Console.WriteLine(new string('-', 20));
Console.WriteLine("Displaying Book 4 Information:");
book4.DisplayBookInfo();
Console.WriteLine(new string('-', 20));
Console.WriteLine("Displaying Library Book Information:");
book6.DisplayLibraryBookInfo();
Console.WriteLine(new string('-', 20));
Console.WriteLine("Displaying basic Book Information:");
book6.DisplayBookInfo(true);

Console.ReadKey();