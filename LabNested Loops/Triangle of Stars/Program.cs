namespace Triangle_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= triangleSize; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}