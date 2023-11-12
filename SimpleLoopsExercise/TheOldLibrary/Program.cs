namespace TheOldLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook= Console.ReadLine();
            string nextBookName = Console.ReadLine();
            int counter = 0;

            while (nextBookName != "No More Books" && nextBookName != favouriteBook)
            {
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (nextBookName == favouriteBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}