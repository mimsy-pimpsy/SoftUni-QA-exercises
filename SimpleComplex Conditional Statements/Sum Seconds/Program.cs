namespace Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int athleteOne = int.Parse(Console.ReadLine());
           int athleteTwo = int.Parse(Console.ReadLine());
           int athleteThree= int.Parse(Console.ReadLine());

            //TimeSpan time = TimeSpan.FromSeconds(890);

            //// backslash is used to ":" colon formatting you will not see it in output
            //string str = time.ToString(@"hh\:mm\:ss");
            //Console.WriteLine(str);

            int totalSeconds = athleteOne + athleteTwo + athleteThree;  
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            string str = time.ToString(@"m\:ss");
            Console.WriteLine(str);

        }
    }
}