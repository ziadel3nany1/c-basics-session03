using System.Drawing;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Net.NetworkInformation;

class Program
{
    public static void Main()
    {
        #region Question 1

        ////1. Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.
        ////Use the && operator.
        //int pages = 464;
        //bool isAvilable = true;
        //if (pages > 300 && isAvilable == true)
        //    Console.WriteLine("You can borrow this book");

        #endregion

        #region Question 2

        ////2. Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code",
        ////"Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

        //string title = "Refactoring";
        //switch (title)
        //{
        //    case "Clean Code":
        //        Console.WriteLine("Great choice!");
        //        break;
        //    case "Refactoring":
        //        Console.WriteLine("Nice pick!");
        //        break;
        //    default:
        //        Console.WriteLine("Never heard of it");
        //        break;
        //}

        #endregion

        #region Question 3
        ////3. Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel 
        ////(same rule as question 6: long if pages > 300).

        //pages = 464;
        //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

        #endregion

        #region Question 4
        //4. Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //, use a for loop to print each book with its position number, like 1. Clean Code.

        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //for (int i = 0; i < books.Length; i++)
        //{
        //    int count = i + 1;
        //    Console.WriteLine(count + "." +books[i]);
        //}
        #endregion

        #region Question 5

        ////5. Using the same books array, use a while loop to print every book title.

        //int n = 0;
        //while (n < books.Length)
        //{
        //    Console.WriteLine(books[n]);
        //    n++;
        //}
        #endregion

        #region Question 6
        ////6. Write a do-while loop that prints "Checking book..." exactly 3 times.

        //int num = 0;
        //do
        //{
        //    Console.WriteLine("Checking book...");
        //    num++;
        //} while (num < 4);
        #endregion

        #region Question 7

        ////7. Using the same books array, use a foreach loop to print every book title.

        //foreach (string book in books)
        //{
        //    Console.WriteLine(book);
        //}
        #endregion

        #region Question 8

        ////8. Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring".

        //for (int i = 0; i < books.Length; i++)
        //{
        //    if (books[i] == "Refactoring")
        //    {
        //        break;
        //    }

        //    Console.WriteLine(books[i]);
        //}
        #endregion

        #region Question 9
        ////9. Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).

        //for (int i = 0; i < books.Length; i++)
        //{
        //    if (books[i] == "The Pragmatic Programmer")
        //    {
        //        continue;
        //    }

        //    Console.WriteLine(books[i]);
        //}
        #endregion

        #region Question 10
        ////10. Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty, use return to exit the method early instead of printing anything.

        //static void PrintFirstBook(string[] arr)
        //{
        //    if (arr.Length == 0)
        //        return;

        //    Console.WriteLine(arr[0]);
        //}
        //PrintFirstBook(books);
        #endregion

        #region Question 1 Updated

        //1.Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
        //both title and upperTitle to show that title did not change

        string title = "clean code";
        string upperTitle = title.ToUpper();
        Console.WriteLine(title);
        Console.WriteLine(upperTitle);

        #endregion

        #region Question 2 Updated

        //2.Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
        //to check if they point to the same object in memory

        string str1 = "Clean Code";
        string str2 = "Clean Code";
        bool isEqual = string.ReferenceEquals(str1, str2);
        Console.WriteLine(isEqual);

        #endregion

        #region Question 3 Updated

        //3.Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
        //object.Print the final result.

        StringBuilder sb = new StringBuilder();
        sb.Append("Book List");
        sb.Append(" - Updated");
        Console.WriteLine(sb);

        #endregion

        #region Question 4 Updated

        //4.Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
        //Print the result.

        sb.Replace("Book List", "Library");
        Console.WriteLine(sb);

        #endregion

        #region Question 5 Updated

        //5.Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
        //Pages: 464" using the + operator
        title = "Clean Code";
        int pages = 464;
        Console.WriteLine("Book: " + title + ", Pages: "+ pages);
        #endregion

        #region Question 6 Updated

        //6.Build the same sentence as above, but using string interpolation ($"...").

        title = "Clean Code";
        pages = 464;
        Console.WriteLine($"Book: {title}, Pages: {pages}");
        #endregion




    }
}