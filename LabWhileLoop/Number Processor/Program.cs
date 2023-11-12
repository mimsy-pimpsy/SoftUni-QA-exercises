namespace Number_Processor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string command  = string.Empty;

            while ((command = Console.ReadLine()) != "End") 
            { 
                if (command == "Inc")
                {
                    num++;
                    
                }
                else if (command == "Dec")
                {
                    num--;
                    
                }
                
            }
            Console.WriteLine(num);
        }
    }
}