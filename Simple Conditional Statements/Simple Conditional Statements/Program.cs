namespace Simple_Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double temperture = double.Parse(Console.ReadLine());
            if (temperture <= 0) 
            {
                Console.WriteLine("Freezing weather!");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}