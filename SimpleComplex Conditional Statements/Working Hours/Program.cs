﻿namespace Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayofWeek = Console.ReadLine();

            if (dayofWeek == "Sunday")
            {
                Console.WriteLine("closed");
            }
            else
            {
                if (hour >= 10 &&  hour <= 18) {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }

        }
    }
}