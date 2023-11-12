namespace Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char chr1 = char.Parse(Console.ReadLine());
            char chr2 = char.Parse(Console.ReadLine());

            for (char i = chr1;  i <= chr2; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
}