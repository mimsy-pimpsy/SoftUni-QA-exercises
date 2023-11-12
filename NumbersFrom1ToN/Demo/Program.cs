using System.Data;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1;i <=12; i= ++i)
            //{
            //    Console.WriteLine(i);
            //}

            //string text = "Hello, World!";
            //Console.WriteLine(text.Length);

            //Console.WriteLine(text[6]);
            //string text = Console.ReadLine();
            //for (int i = 0; i <= text.Length - 1; i++)
            //{
            //    Console.WriteLine(text[i]);
            //}

            //string text = Console.ReadLine();
            //int vowelWeight = 0;
            //for (int i = 0; i < text.Length; i++)
            //{

            //    char myChar = text[i];
            //    if (myChar == 'a')
            //    {
            //        vowelWeight += 1;
            //    }
            //    else if (myChar == 'e') 
            //    {
            //        vowelWeight +=2;
            //    }
            //    else if (myChar == 'i') 
            //    {
            //        vowelWeight += 3;
            //    }
            //    else if (myChar == 'o') 
            //    {
            //        vowelWeight += 4;
            //    }

            //    else if (myChar == 'u')
            //    {
            //        vowelWeight += 5;
            //    }

            //}
            //Console.WriteLine(vowelWeight);
            // while (bool condition only)
            //{
            //code
            //}
            //example for while

            //int a = 1;
            //while (a<= 10) 
            //{
            //    Console.WriteLine(a);
            //    a += 2;
            //}

            //int a = 1;

            //while (true)
            //{
            //    if (a >= 20)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(a);
            //    a += 2;
            //}

            //string command = Console.ReadLine();

            //while (command != "Exit") 
            //{
            //    Console.WriteLine(command);
            //    command = Console.ReadLine();
            //}

            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "Stop") 
            //    {
            //        break;
            //    }
            //    Console.WriteLine(command);
            //}


            
            string username = Console.ReadLine();
            
                string password = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != password)
            {
                Console.WriteLine(input);
               
            }
            Console.WriteLine($"Welcome: {username}!");



        }

    }
}