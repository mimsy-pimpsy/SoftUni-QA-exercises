﻿namespace Numbers_From_N_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int number = int.Parse(Console.ReadLine());
         for (int i = number;i >= 1; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}