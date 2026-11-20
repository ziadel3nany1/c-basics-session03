class Program
{
    public static void Main()
    {
        #region Question 1

        //1. Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.
        //Use the && operator.
        int pages = 464;
        bool isAvilable = true;
        if (pages > 300 && isAvilable == true)
            Console.WriteLine("You can borrow this book");

        #endregion

        #region Question 2

        //2. Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code",
        //"Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

        string title = "Refactoring";
        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;
            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;
            default:
                Console.WriteLine("Never heard of it");
                break;
        }

        #endregion

        #region Question 3
        //3. Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel 
        //(same rule as question 6: long if pages > 300).

        pages = 464;
        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

        #endregion

        #region Question 4
        //4. Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //, use a for loop to print each book with its position number, like 1. Clean Code.

        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        for (int i = 0; i < books.Length; i++)
        {
            int count = i + 1;
            Console.WriteLine(count + "." +books[i]);
        }
        #endregion

        #region Question 5

        //5. Using the same books array, use a while loop to print every book title.

        int n = 0;
        while (n < books.Length)
        {
            Console.WriteLine(books[n]);
            n++;
        }
        #endregion

        #region Question 6
        //6. Write a do-while loop that prints "Checking book..." exactly 3 times.

        int num = 0;
        do
        {
            Console.WriteLine("Checking book...");
            num++;
        } while (num < 4);
        #endregion
    }
}