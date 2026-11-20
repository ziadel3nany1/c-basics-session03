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
    }
}