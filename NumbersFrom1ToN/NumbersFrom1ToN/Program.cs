﻿namespace NumbersFrom1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}